
/*
	The procedure implements message handler for message type = [//CompanyName/Roster/AddressBookAction/Register/Reply]
*/
CREATE PROCEDURE [dbo].[companyname_roster_addressbookaction_register_reply_message_handler]
	
    @message_body_xml			XML		-- the message body to be processed
	, @reply_message_body_xml	XML OUT	-- generated reply message

AS
BEGIN
	SET NOCOUNT ON

	DECLARE @tran_count			INT = @@TRANCOUNT						-- initial number of transactions
 			, @user_id			INT										-- user(address book owner) identificator at dbo.USER 
			, @user_new_address_book_id		INT							-- newly created users address book

	BEGIN TRY
				
		-- reset reply message
		SET @reply_message_body_xml = NULL

		-- parse message. assaign values to variables
		SELECT 
			@user_id = x.value('(/address_book/user_id/text())[1]', 'INT')
			, @user_new_address_book_id = x.value('(/address_book/user_new_address_book_id/text())[1]', 'INT')
		FROM
			@message_body_xml.nodes('/address_book') doc(x)

		-- Now address book is ready to go live for user
		UPDATE [dbo].[USER]
			SET [User_actual_address_book_id] = @user_new_address_book_id
		WHERE
			[Id] = @user_id		

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

		INSERT INTO [dbo].[ADDRESS_BOOK_ACTION_NOTIFICATION_ERROR_LOG]
				([Message_body], [Error_msg])
		VALUES	(@message_body_xml, @error_msg)

	END CATCH
END
