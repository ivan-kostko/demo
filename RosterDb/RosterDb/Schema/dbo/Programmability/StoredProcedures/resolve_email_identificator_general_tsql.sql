/*
	The procedure fills up #EMAILS_TO_RESOLVE.[Id] field with correcponding [<schema>].[EMAIL].[Id] to emails at #EMAILS_TO_RESOLVE.[Email]
	New emails are saved to [<schema>].[EMAIL]  

	URGENT!!! Procedure doesn't do any pre or post validation of provided emails.

	Acceptable temp table structure is like the following:
		CREATE TABLE #EMAILS_TO_RESOLVE(
				[Id]					INT					NULL		-- sp fills this field with correcponding [<schema>].[EMAIL].[Id]
				, [Hash] AS CAST(HASHBYTES('md5', [Email]) AS BIGINT)	-- keep in sync with [<schema>].[dbo].[EMAIL].[Hash] function !!!  
				, [Email]				NVARCHAR(320)		NOT NULL	-- email to be resolved
		)
*/

CREATE PROCEDURE [dbo].[resolve_email_identificator]
	@email			NVARCHAR(320) = NULL
	, @email_id		INT = NULL				OUT
AS
BEGIN

	SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED

	BEGIN TRY	
		-- declaration of main variables
		DECLARE @table_emails_to_resolve_initially_exists	BIT = ISNULL(OBJECT_ID('tempdb..#EMAILS_TO_RESOLVE'),0)
				, @inputed_as_param_email_hash				BIGINT

		DECLARE @inserted_email TABLE ([Hash] BIGINT, [Email] NVARCHAR(320)) 
	
		-- check temp table existance
		IF @table_emails_to_resolve_initially_exists = 0 -- no temp table provided
		BEGIN
			CREATE TABLE #EMAILS_TO_RESOLVE(
				[Id]					INT					NULL		-- sp fills this field with correcponding [<schema>].[EMAIL].[Id]
				, [Hash] AS CAST(HASHBYTES('md5', [Email]) AS BIGINT)	-- keep in sync with [<schema>].[dbo].[EMAIL].[Hash] function !!!  
				, [Email]				NVARCHAR(320)		NOT NULL	-- email to be resolved
			)
		END

		-- insert input-param email into temp table
		IF @email IS NOT NULL
		BEGIN
			INSERT INTO #EMAILS_TO_RESOLVE ([Email])
				OUTPUT inserted.[Hash], inserted.[Email] INTO @inserted_email
			VALUES (@email)

			SELECT
				@inputed_as_param_email_hash = ie.[Hash]
			FROM
				@inserted_email ie
			WHERE
				ie.[Email] = @email 
		END

		-- remove duplicates
		;WITH Q_Duplicates AS (
			SELECT
				ROW_NUMBER() OVER(PARTITION BY [Email] ORDER BY [Id]) AS [Entry]
				, [Email]
			FROM
				#EMAILS_TO_RESOLVE
		)
		DELETE Q_Duplicates
		WHERE
			[Entry] > 1

		;WITH Q_Emails AS (
			SELECT 
				tetr.*
				, ISNULL(e.[Id], 0) AS [Q_Email_id]
			FROM
				#EMAILS_TO_RESOLVE tetr
				LEFT JOIN [dbo].[EMAIL] e WITH(INDEX = [UQ_EMAIL_Hash_Email]) ON e.[Hash] = tetr.[Hash] AND e.[Email] = tetr.[Email]
		)
		UPDATE Q_Emails
			SET [Id] = [Q_Email_id]
		
		-- some heplful index
		CREATE UNIQUE NONCLUSTERED INDEX [IX_EMAILS_TO_RESOLVE_Id_Hash_Email] ON #EMAILS_TO_RESOLVE([Id], [Hash], [Email])
			
		-- insert new nonexisting emails
		INSERT INTO [dbo].[EMAIL]( 
			[Email] 
		)
		SELECT
			tetr.[Email]
		FROM
			#EMAILS_TO_RESOLVE tetr
		WHERE
			tetr.[Id] = 0
		AND NOT EXISTS(SELECT 1 FROM [dbo].[EMAIL] e WITH(INDEX = [UQ_EMAIL_Hash_Email]) WHERE e.[Hash] = tetr.[Hash] AND e.[Email] = tetr.[Email])

		-- resolve last emails ids	
		;WITH Q_Emails AS (
			SELECT 
				tetr.*
				, e.[Id] AS [Q_Email_id]
			FROM
				#EMAILS_TO_RESOLVE tetr
				INNER JOIN [dbo].[EMAIL] e WITH(INDEX = [UQ_EMAIL_Hash_Email]) ON e.[Hash] = tetr.[Hash] AND e.[Email] = tetr.[Email]
			WHERE
				tetr.[Id] = 0
		)
		UPDATE Q_Emails
			SET [Id] = [Q_Email_id]	
	
		-- set output @email_id if there was @email provided
		IF @email IS NOT NULL
		BEGIN
			SELECT
				@email_id = [Id]
			FROM
				#EMAILS_TO_RESOLVE tetr
			WHERE
				tetr.[Hash] = @inputed_as_param_email_hash
			AND	tetr.[Email] = @email 
		END

	END TRY
	BEGIN CATCH

		IF @@TRANCOUNT > 0      
			ROLLBACK
               
		DECLARE
			  @options           BIGINT         = @@OPTIONS
			, @ERROR_NUMBER      INT            = ERROR_NUMBER()
			, @ERROR_SEVERITY    INT            = ERROR_SEVERITY()
			, @ERROR_STATE       INT            = ERROR_STATE()
			, @ERROR_LINE        INT            = ERROR_LINE()
			, @ERROR_PROCEDURE   NVARCHAR(255)  = ERROR_PROCEDURE()
			, @ERROR_MESSAGE     NVARCHAR(4000) = ERROR_MESSAGE()
			, @error_msg         NVARCHAR(MAX)  = ''
			, @separator_char    CHAR           = CHAR(10)   
      
		EXEC [dbo].[log_error] 
			  @options         = @options        
			, @ERROR_NUMBER    = @ERROR_NUMBER   
			, @ERROR_SEVERITY  = @ERROR_SEVERITY 
			, @ERROR_STATE     = @ERROR_STATE    
			, @ERROR_LINE      = @ERROR_LINE     
			, @ERROR_PROCEDURE = @ERROR_PROCEDURE
			, @ERROR_MESSAGE   = @ERROR_MESSAGE  
			, @error_msg       = @error_msg			OUT
			, @separator_char  = @separator_char 

		RAISERROR(@error_msg, 16,1) 
      
	END CATCH
END
GO