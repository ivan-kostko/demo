
/*
	The procedure implements [<schema>].[ADDRESS_BOOK_ENTRY_ACTION_TARGET] queue entry handler
*/
CREATE PROCEDURE [dbo].[address_book_entry_action_target_queue_handler]
	-- Shouldn't have any input params
AS
BEGIN
	SET NOCOUNT ON

	DECLARE @tran_count			INT = @@TRANCOUNT						-- initial number of transactions
            
			, @init_dlg_handle			UNIQUEIDENTIFIER	
			, @message_body_xml			XML
			, @reply_message_body_xml	XML
			, @message_type				NVARCHAR(256)

            
            
	BEGIN TRY
		
        
        -- read messages one by one while queue is not empty
		WHILE (1=1)
		BEGIN
         
			SET @reply_message_body_xml = NULL 

			WAITFOR 
			(
				RECEIVE 
					TOP (1) 
					@init_dlg_handle	=  [Conversation_Handle]
					, @message_type		=  [Message_Type_Name]
					, @message_body_xml =  [Message_Body]
				FROM
					[dbo].[ADDRESS_BOOK_ENTRY_ACTION_TARGET]
			), TIMEOUT 600;
         
			IF @@ROWCOUNT <= 0
			BEGIN
				BREAK;
			END
		
			-- execute appropriate handler handler by message type
			IF @message_type = N'//CompanyName/Roster/AddressBookEntryAction/SaveOnAddressBookCreated/Request'
			BEGIN
				
				EXEC [dbo].[companyname_roster_addressbookentryaction_saveonaddressbookcreated_request_message_handler] 
					@message_body_xml = @message_body_xml
					, @reply_message_body_xml = @reply_message_body_xml OUT

			END
			ELSE  IF @message_type = N'//CompanyName/Roster/AddressBookEntryAction/SaveOnAddressBookEntryXmlParsed/Request'
			BEGIN
				
				EXEC [dbo].[companyname_roster_addressbookentryaction_saveonaddressbookentryxmlparsed_request_message_handler] 
					@message_body_xml = @message_body_xml
					, @reply_message_body_xml = @reply_message_body_xml OUT

			END
			ELSE 
			BEGIN
			   SET @message_type = ISNULL(@message_type, '(NULL)')
			   RAISERROR('Unsupported message type "%s"',16,1, @message_type)
			END

			-- reply if have reply message
			IF @reply_message_body_xml IS NOT NULL
			BEGIN
				;SEND 
					ON CONVERSATION @init_dlg_handle 
					MESSAGE TYPE [//CompanyName/Roster/AddressBookEntryAction/Saved/Reply]
					(@reply_message_body_xml); 
			END 
			
			-- end conversation
			END CONVERSATION @init_dlg_handle;

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

		INSERT INTO [dbo].[ADDRESS_BOOK_ENTRY_ACTION_NOTIFICATION_ERROR_LOG]
				([Message_body], [Error_msg])
		VALUES	(@message_body_xml, @error_msg)

	END CATCH
END
