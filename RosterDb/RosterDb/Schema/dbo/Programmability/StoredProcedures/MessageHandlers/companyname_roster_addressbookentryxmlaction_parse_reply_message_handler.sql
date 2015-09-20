
/*
	The procedure implements message handler for message type = [//CompanyName/Roster/AddressBookEntryXmlAction/Parse/Reply]
	For the moment the procedure is not executed at all cause service //CompanyName/Roster/Address_Book_Entry_Xml_Action/Target does not send any reply to Initiator
*/
CREATE PROCEDURE [dbo].[companyname_roster_addressbookentryxmlaction_parse_reply_message_handler]
	
    @message_body_xml			XML		-- the message body to be processed
	, @reply_message_body_xml	XML OUT	-- generated reply message

AS
BEGIN
	SET NOCOUNT ON

	DECLARE @tran_count			INT = @@TRANCOUNT						-- initial number of transactions
            --
            
            
	BEGIN TRY
		
 		-- reset reply message
		SET @reply_message_body_xml = NULL

       -- //TODO: put some code
        
        -- if there is no transaction opened yet - open a new one. Otherwise, if there is/are - no need to increase @@TRANCOUNT
		IF @tran_count = 0
			BEGIN TRANSACTION
		
        --
        
        IF @tran_count = 0
			COMMIT TRANSACTION
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

		INSERT INTO [dbo].[ADDRESS_BOOK_ENTRY_XML_ACTION_NOTIFICATION_ERROR_LOG]
				([Message_body], [Error_msg])
		VALUES	(@message_body_xml, @error_msg)

	END CATCH
END
