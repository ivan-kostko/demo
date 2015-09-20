/*
	The procedure fills up table [dbo].[ADDRESS_BOOK_ENTRY_PARSED].[Email_id] field 
	with correcponding [<schema>].[EMAIL].[Id] to emails at inmemory table [dbo].[ADDRESS_BOOK_ENTRY_PARSED].[Email]
	by 
	
	New emails are saved to [<schema>].[EMAIL]  

	URGENT!!! Procedure doesn't do any pre or post validation of provided emails.

*/

CREATE PROCEDURE [dbo].[resolve_email_identificator]
	@address_book_entry_xml_temp_storage_id	INT	= NULL	-- identificator at [<schema>].[ADDRESS_BOOK_ENTRY_XML_TEMP_STORAGE].[Id]
AS
BEGIN

	BEGIN TRY	
	
		-- insert new nonexisting emails
		;WITH Q_emails_to_resolve AS (
			SELECT 
				DISTINCT
				[Hash]
				, [Email]
			FROM
				[dbo].[ADDRESS_BOOK_ENTRY_PARSED] abep WITH(SNAPSHOT) 
			WHERE
				abep.[Address_book_entry_xml_temp_storage_id] = @address_book_entry_xml_temp_storage_id
			AND abep.[Email_id] IS NULL
			AND abep.[Email] IS NOT NULL
		)
		INSERT INTO [dbo].[EMAIL] ( 
			[Email] 
		)
		SELECT
			tetr.[Email]
		FROM
			Q_emails_to_resolve tetr
		WHERE
			NOT EXISTS(SELECT 1 FROM [dbo].[EMAIL] e WITH(INDEX = [UQ_EMAIL_Hash_Email]) WHERE e.[Hash] = tetr.[Hash] AND e.[Email] = tetr.[Email])

		-- resolve emails ids	
		;WITH Q_Emails AS (
			SELECT 
				abep.[Email_id]
				, e.[Id] AS [Q_Email_id]
			FROM
				[dbo].[ADDRESS_BOOK_ENTRY_PARSED] abep WITH(SNAPSHOT) 
				INNER JOIN [dbo].[EMAIL] e WITH(INDEX = [UQ_EMAIL_Hash_Email]) ON e.[Hash] = abep.[Hash] AND e.[Email] = abep.[Email]
			WHERE
				abep.[Address_book_entry_xml_temp_storage_id] = @address_book_entry_xml_temp_storage_id
			AND abep.[Email_id] IS NULL
		)
		UPDATE Q_Emails
			SET [Email_id] = [Q_Email_id]	

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