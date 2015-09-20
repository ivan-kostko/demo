
/*
	The procedure implements message handler for message type = [//CompanyName/Roster/AddressBookEntryAction/SaveOnAddressBookCreated/Request]
*/
CREATE PROCEDURE [dbo].[companyname_roster_addressbookentryaction_saveonaddressbookcreated_request_message_handler]
	
    @message_body_xml			XML		-- the message body to be processed
	, @reply_message_body_xml	XML OUT	-- generated reply message

AS
BEGIN
	SET NOCOUNT ON

	DECLARE @tran_count					INT = @@TRANCOUNT		-- initial number of transactions
			, @address_book_id			INT 
			, @address_book_entry_xml_temp_storage_id	INT		-- the identificator of xml temporary stored at [<schema>].[ADDRESS_BOOK_ENTRY_XML_TEMP_STORAGE]
			, @address_book_entry_has_been_saved		BIT = 0

	BEGIN TRY

		-- reset reply message
		SET @reply_message_body_xml = NULL
				
		-- parse message. assaign values to variables
		SELECT 
			@address_book_id = x.value('(/address_book_entry/address_book_id/text())[1]', 'INT')
			, @address_book_entry_xml_temp_storage_id = x.value('(/address_book_entry/address_book_entry_xml_temp_storage_id/text())[1]', 'INT')
		FROM
			@message_body_xml.nodes('/address_book_entry') doc(x)

		IF @address_book_entry_xml_temp_storage_id IS NOT NULL  
		BEGIN
			IF @address_book_id IS NOT NULL
			BEGIN
				EXEC [dbo].[register_addressbook_created]
					@address_book_entry_xml_temp_storage_id = @address_book_entry_xml_temp_storage_id
					, @address_book_id = @address_book_id
			END

			EXEC [dbo].[execute_save_address_book_entry_save_on_all_components_synced]
				@address_book_entry_xml_temp_storage_id = @address_book_entry_xml_temp_storage_id
				, @address_book_entry_has_been_saved = @address_book_entry_has_been_saved OUT
		END


		-- generate reply
		IF @address_book_entry_has_been_saved = 1 
		BEGIN
			SET @reply_message_body_xml = (
				SELECT
					@address_book_entry_xml_temp_storage_id AS [address_book_entry_xml_temp_storage_id]
					FOR XML PATH('address_book_entry'), TYPE, ELEMENTS) 
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
