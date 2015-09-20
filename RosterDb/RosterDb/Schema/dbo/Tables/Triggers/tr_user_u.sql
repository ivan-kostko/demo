CREATE TRIGGER [tr_user_u] ON [dbo].[USER]
FOR UPDATE, DELETE
AS
BEGIN
	SET NOCOUNT ON

	BEGIN TRY

		-- if initially Last_update field was not updated
		IF ( UPDATE( [Name] ) OR UPDATE( [Email_id] ) OR UPDATE ( [User_status_id] ))
		BEGIN
			
			DECLARE @last_update DATETIME = GETDATE()
			
			INSERT INTO [dbo].[USER_OLD_VERSION] ( 
				[User_id] 
				, [Name] 
				, [Email_id] 
				, [User_status_id] 
				, [Valid_from]
				, [Valid_until] 
			)
			OUTPUT inserted.[User_id] INTO [dw].[ROSTERDW_USER_TRANSFER_CANDIDATE]([User_id])
			SELECT
				d.[Id]
				, d.[Name] 
				, d.[Email_id] 
				, d.[User_status_id] 	
				, d.[Last_update]
				, @last_update
			FROM
				deleted d			

			UPDATE u
				SET [Last_update] = @last_update
			FROM
				inserted i
				INNER JOIN [dbo].[USER] u ON u.[Id] = i.[Id] 
				
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

