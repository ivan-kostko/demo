
/*
	The procedure implements message handler for message type = [//CompanyName/Roster/AddressBookEntryXmlAction/Parse/Request]
*/
CREATE PROCEDURE [dbo].[companyname_roster_addressbookentryxmlaction_parse_request_message_handler]
	
    @message_body_xml			XML		-- the message body to be processed
	, @reply_message_body_xml	XML OUT	-- generated reply message

AS
BEGIN
	SET NOCOUNT ON

	DECLARE @tran_count			INT = @@TRANCOUNT					-- initial number of transactions
            , @address_book_entry_xml_temp_storage_id	INT			-- identificator at [<schema>].[ADDRESS_BOOK_ENTRY_XML_TEMP_STORAGE].[Id] to be processed
                 
	BEGIN TRY

		-- reset reply message
		SET @reply_message_body_xml = NULL
		
		SELECT
			@address_book_entry_xml_temp_storage_id = x.value('(/address_book/address_book_entry_xml_temp_storage_id/text())[1]', 'INT')
		FROM
			@message_body_xml.nodes('/address_book') doc(x)

		EXEC [dbo].[prepare_address_book_entry_xml_for_saving] 
			@address_book_entry_xml = NULL
			, @address_book_entry_xml_temp_storage_id = @address_book_entry_xml_temp_storage_id
			, @the_procedure_invoked_async = 1

		-- it is faster to assign xml value instead of generating a new one.
		SET @reply_message_body_xml = @message_body_xml

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
