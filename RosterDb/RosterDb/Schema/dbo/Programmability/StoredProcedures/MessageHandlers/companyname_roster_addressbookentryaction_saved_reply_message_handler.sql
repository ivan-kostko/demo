
/*
	The procedure implements message handler for message type = [//CompanyName/Roster/AddressBookEntryAction/Saved/Reply]
*/
CREATE PROCEDURE [dbo].[companyname_roster_addressbookentryaction_saved_reply_message_handler]
	
    @message_body_xml			XML		-- the message body to be processed

AS
BEGIN
	SET NOCOUNT ON

	DECLARE @tran_count			INT = @@TRANCOUNT						-- initial number of transactions
			, @address_book_entry_xml_temp_storage_id	INT		-- the identificator of xml temporary stored at [<schema>].[ADDRESS_BOOK_ENTRY_XML_TEMP_STORAGE]
			, @address_book_id				INT 
			, @saved_address_book_status_id INT	= 1				-- address book status identificator at dbo.ADDRESS_BOOK_STATUS when address book is created and saved successfully

	BEGIN TRY
				
		-- parse message. assaign values to variables
		SELECT 
			@address_book_entry_xml_temp_storage_id = @message_body_xml.value('(/address_book_entry/address_book_entry_xml_temp_storage_id/text())[1]', 'INT')
		
		SELECT
			@address_book_id = [Address_book_id]
		FROM
			[dbo].[XML_TEMP_STORAGE_ID_TO_ADDRESS_BOOK_ID_MAP]
		WHERE
			[Address_book_entry_xml_temp_storage_id] = @address_book_entry_xml_temp_storage_id
        		
		-- update address book status to saved
		UPDATE [dbo].[ADDRESS_BOOK]
			SET [Address_book_status_id] = @saved_address_book_status_id
		WHERE
			[Id] = @address_book_id

		-- cleanup sync mapping table
		DELETE [dbo].[XML_TEMP_STORAGE_ID_TO_ADDRESS_BOOK_ID_MAP]
		WHERE
			[Address_book_entry_xml_temp_storage_id] = @address_book_entry_xml_temp_storage_id
        
		-- the inmemory cache should be already cleaned up on saving address book entries

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
