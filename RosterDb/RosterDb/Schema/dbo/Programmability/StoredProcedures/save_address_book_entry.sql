/*
	The procedure implements the entrance point interface to save entries for address book
*/
CREATE PROCEDURE [dbo].[save_address_book_entry]
	@address_book_id										INT			-- current address book to which entries belong
	, @address_book_entry_xml XML (AddressBookEntrySchemaCollection)	-- xml representation of address book entries <see=AddressBookEntrySchemaCollection/>
	, @address_book_entry_xml_temp_storage_id				INT			-- identificator at [<schema>].[ADDRESS_BOOK_ENTRY_XML_TEMP_STORAGE].[Id]
	, @the_procedure_invoked_async							BIT = 0		-- whether the procedure is invoked sync(0) or async(1)
AS
BEGIN

	DECLARE @tran_count				INT	= @@TRANCOUNT	-- initial number of transactions
			, @saved_address_book_status_id INT	= 1		-- address book status identificator at dbo.ADDRESS_BOOK_STATUS when address book is created and saved successfully

	BEGIN TRY
		
		IF @address_book_entry_xml IS NOT NULL
		BEGIN
			-- get @address_book_entry_xml_temp_storage_id
			INSERT INTO [dbo].[ADDRESS_BOOK_ENTRY_XML_TEMP_STORAGE]([Address_book_entry_xml])
			VALUES(NULL)

			SET @address_book_entry_xml_temp_storage_id = SCOPE_IDENTITY()

			EXEC [dbo].[prepare_address_book_entry_xml_for_saving]
				@address_book_entry_xml = @address_book_entry_xml
				, @address_book_entry_xml_temp_storage_id = @address_book_entry_xml_temp_storage_id
				, @the_procedure_invoked_async = @the_procedure_invoked_async
		END
				
		-- if there is no transaction opened yet - open a new one. Otherwise, if there is/are - no need to increase @@TRANCOUNT
		IF @tran_count = 0
			BEGIN TRANSACTION

			-- insert into static table
			INSERT INTO [dbo].[ADDRESS_BOOK_ENTRY](
				[Address_book_id]		
				, [Contact_name]		
				, [Email_id]			
				, [Some_contact_data1]	
				, [Some_contact_data2]	
				, [Some_contact_data3]	
			)
			SELECT
				@address_book_id		AS [Address_book_id]
				, [Contact_name]		AS [Contact_name]		
				, [Email_id] 			AS [Email_id]			
				, [Some_contact_data1]	AS [Some_contact_data1]	
				, [Some_contact_data2]	AS [Some_contact_data2]	
				, [Some_contact_data3]	AS [Some_contact_data3]	
			FROM
				[ADDRESS_BOOK_ENTRY_PARSED] WITH (SNAPSHOT)
			WHERE
				[Address_book_entry_xml_temp_storage_id] = @address_book_entry_xml_temp_storage_id

			-- clean up inmemory temp storages
			EXEC [dbo].[remove_address_book_entry_parsed]
				 @address_book_entry_xml_temp_storage_id		
			
			-- delete from temp storage if sync. otherwise it should be deleted on reply
			IF @the_procedure_invoked_async = 0
			BEGIN
				DELETE [dbo].[ADDRESS_BOOK_ENTRY_XML_TEMP_STORAGE]
				WHERE
					[Id] = @address_book_entry_xml_temp_storage_id	
			END
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

		-- clean up inmemory temp storages
		-- It is recommendet to call NCSPs with unnamed params
		EXEC [dbo].[remove_address_book_entry_parsed] @address_book_entry_xml_temp_storage_id	

		RAISERROR(@error_msg, 16,1) 
      
	END CATCH

END