
/*
	The procedure implements the entrance point interface to queue up a message to create abbress book and save its entries for registered user 
*/

CREATE PROCEDURE [dbo].[create_address_book_async]
	@user_id							INT								-- user(address book owner) identificator at dbo.USER 
	, @user_current_address_book_id		INT 
	, @address_book_entry_xml XML	(AddressBookEntrySchemaCollection)	-- xml representation of address book entries <see=AddressBookEntrySchemaCollection/>
	, @address_book_entry_xml_temp_storage_id	INT	= NULL				-- identificator at [<schema>].[ADDRESS_BOOK_ENTRY_XML_TEMP_STORAGE].[Id] if it is used
AS
BEGIN
	DECLARE @tran_count				INT	= @@TRANCOUNT	-- initial number of transactions
			, @message_body_xml		XML		-- message xml representation

	BEGIN TRY
		
		-- store xml at the temp storage. it avoids redundant INSERTS and READS of big XML through the queue 
		IF @address_book_entry_xml IS NOT NULL
		BEGIN
			INSERT INTO [dbo].[ADDRESS_BOOK_ENTRY_XML_TEMP_STORAGE](Address_book_entry_xml)
			VALUES(@address_book_entry_xml)

			SET @address_book_entry_xml_temp_storage_id = SCOPE_IDENTITY()
		END

		SET @message_body_xml = (
			SELECT
				@user_id									AS [user_id]
				, @user_current_address_book_id				AS [user_current_address_book_id]
				, @address_book_entry_xml_temp_storage_id	AS [address_book_entry_xml_temp_storage_id]
				FOR XML PATH('address_book'), TYPE, ELEMENTS) 
		
		-- if there is no transaction opened yet - open a new one. Otherwise, if there is/are - no need to increase @@TRANCOUNT
		IF @tran_count = 0
			BEGIN TRANSACTION

			EXEC [dbo].[companyname_roster_addressbookaction_register_request_message_sender]
				@message_body_xml = @message_body_xml

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

		RAISERROR(@error_msg, 16,1) 
      
	END CATCH

END