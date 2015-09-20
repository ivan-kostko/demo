/*
 returns all connections = users, having input email in their currently active address books. Uses and rely on "materialized view" [dbo].[V_USER_TO_USER_CONNECTION]
*/
CREATE PROCEDURE [dbo].[get_user_connections_by_email_using_view_index]
	@user_email				NVARCHAR(320)							-- users email
AS
	
BEGIN
	
	DECLARE @tran_count						INT = @@TRANCOUNT		-- initial number of transactions
			, @user_email_id				INT						-- email identificator at dbo.EMAIL 

	BEGIN TRY
		
		-- resolve user email identificator
		EXEC [dbo].[resolve_single_email_id]
			@email = @user_email
			, @email_id = @user_email_id OUT

		SELECT
			e.[Email] AS [Connected_with_user_email] 
			, vu2uc.[Connected_with_user_name]
		FROM
			[dbo].[V_USER_TO_USER_CONNECTION] vu2uc WITH(NOEXPAND)
			INNER JOIN [dbo].[EMAIL] e ON e.[Id] = vu2uc.[Email_id]
		WHERE
			 vu2uc.[Email_id] = @user_email_id
			
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
	