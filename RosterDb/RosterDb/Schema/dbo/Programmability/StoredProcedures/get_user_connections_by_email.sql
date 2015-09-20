/*
	returns all connections = users, having input email in their currently active address books. Does not use indexed view
*/

CREATE PROCEDURE [dbo].[get_user_connections_by_email]
	@user_email				NVARCHAR(320)							-- users email
AS
	
BEGIN
	
	DECLARE @tran_count						INT = @@TRANCOUNT		-- initial number of transactions
			, @user_email_id				INT	= NULL				-- email identificator at dbo.EMAIL 

	BEGIN TRY
		
		-- resolve user email identificator
		EXEC [dbo].[resolve_single_email_id]
			@email = @user_email
			, @email_id = @user_email_id OUT

		SELECT
			e.[Email]	AS [Connected_with_user_email]	-- "connected with" user Email 
			, u.[Name]	AS [Connected_with_user_name]	-- "connected with" user Name 
		FROM
			[dbo].[ADDRESS_BOOK_ENTRY] abe
			INNER JOIN [dbo].[USER] u 
				INNER JOIN [dbo].[EMAIL] e ON e.[Id] = u.[Email_id]
			ON u.[User_actual_address_book_id] = abe.[Address_book_id]
		WHERE
			abe.Email_id = @user_email_id
		AND EXISTS(SELECT 1 FROM [dbo].[ADDRESS_BOOK] ad WHERE ad.[Id] = abe.[Address_book_id] AND ad.[User_id] = u.[User_actual_address_book_id] )

			
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