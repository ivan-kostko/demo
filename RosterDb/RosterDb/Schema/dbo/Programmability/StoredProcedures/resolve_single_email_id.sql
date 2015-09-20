/*
	The procedure returns corresponding [<schema>].[EMAIL].[Id] (as @email_id OUT) for provided @email 
	In case the email is new and doesn't exist at [<schema>].[EMAIL] - it is saved there
*/
CREATE PROCEDURE [dbo].[resolve_single_email_id]
	@email				NVARCHAR(320)				-- users email
	, @email_id			INT				OUT			-- email identificator at dbo.EMAIL 
AS
BEGIN
	
	DECLARE @tran_count				INT = @@TRANCOUNT		-- initial number of transactions
			, @hash					BIGINT = [dbo].[fn_hash_email](@email)

	BEGIN TRY
		
		SET @email_id = NULL

		-- it could be a case that the email is inserted in between of executions of two queries by another thread. Thats why it should be done in a loop
		WHILE (@email_id IS NULL)
		BEGIN
			SELECT
				@email_id = e.[Id]
			FROM
				[dbo].[EMAIL] e
			WHERE
				e.[Hash] = @hash
			AND e.[Email] = @email

			IF @email_id IS NULL
			BEGIN
				-- resolve email identificator 
				INSERT INTO [dbo].[EMAIL]([Email])
				SELECT @email
				WHERE NOT EXISTS(SELECT 1 FROM [dbo].[EMAIL] e WHERE e.[Hash] = @hash AND e.[Email] = @email)
			
				SET @email_id = SCOPE_IDENTITY()
			END
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