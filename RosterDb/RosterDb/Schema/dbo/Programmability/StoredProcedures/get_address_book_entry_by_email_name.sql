/*
	returns content of currently active address book
*/

CREATE PROCEDURE [dbo].[get_address_book_entry_by_email_name]
	@user_name					NVARCHAR(255)							-- users name
	, @user_email				NVARCHAR(320)							-- users email
AS
	
BEGIN
	
	DECLARE @tran_count						INT = @@TRANCOUNT		-- initial number of transactions
			, @user_email_id				INT						-- email identificator at dbo.EMAIL 
			, @user_id						INT						-- user identificator at dbo.USER 
			, @user_actual_address_book_id	INT						-- current/actual user address book identificator

	BEGIN TRY
		
		-- resolve user email identificator
		EXEC [dbo].[resolve_single_email_id]
			@email = @user_email
			, @email_id = @user_email_id OUT

		-- resolve users address book identificator
		SELECT 
			@user_actual_address_book_id = u.[User_actual_address_book_id]	
		FROM
			dbo.[USER] u  
		WHERE
			u.Email_id = @user_email_id
		AND u.Name = @user_name

		-- if user has actual address book
		IF @user_actual_address_book_id IS NOT NULL
		BEGIN
			-- retreive address book entries
			SELECT
				abe.[Contact_name]		
				, e.[Email] 			
				, abe.[Some_contact_data1]	
				, abe.[Some_contact_data2]	
				, abe.[Some_contact_data3]	
			FROM
				[dbo].[ADDRESS_BOOK_ENTRY] abe
				INNER JOIN [dbo].[EMAIL] e ON e.[Id] = abe.[Email_id] 
			WHERE
				abe.[Address_book_id] = @user_actual_address_book_id
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
		