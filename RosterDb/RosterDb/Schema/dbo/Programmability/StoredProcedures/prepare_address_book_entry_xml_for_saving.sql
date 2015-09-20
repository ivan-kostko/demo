/*
	The procedure parses address_book_entry_xml into [ADDRESS_BOOK_ENTRY_PARSED]
*/

CREATE PROCEDURE [dbo].[prepare_address_book_entry_xml_for_saving]
	@address_book_entry_xml XML	(AddressBookEntrySchemaCollection)	-- xml representation of address book entries <see=AddressBookEntrySchemaCollection/>
	, @address_book_entry_xml_temp_storage_id				INT		-- identificator at [<schema>].[ADDRESS_BOOK_ENTRY_XML_TEMP_STORAGE].[Id]
	, @the_procedure_invoked_async							BIT = 0	-- whether the procedure is invoked sync(0) or async(1)
AS 
BEGIN
	
	DECLARE @tran_count				INT = @@TRANCOUNT							-- initial number of transactions
			, @address_book_doc		INT											-- OPENXML document identificator
			, @xml					XML = CAST(@address_book_entry_xml AS XML)	-- sp_xml_preparedocument can only process untyped XML. Cast the input value to XML or to a string type
			, @message_body_xml		XML											-- message xml representation
			
			            
	BEGIN TRY

		IF (@address_book_entry_xml IS NULL)
		BEGIN
			
			-- retreive xml from temp storage if a case				
			SELECT 
				@xml = [Address_book_entry_xml] 
			FROM 
				[ADDRESS_BOOK_ENTRY_XML_TEMP_STORAGE]   
			WHERE 
				[Id] = @address_book_entry_xml_temp_storage_id
		END

		--Create an internal representation of the XML document.
		EXEC sp_xml_preparedocument @address_book_doc OUTPUT, @xml
		
		-- extract data from xml by template table schema
		INSERT INTO [dbo].[ADDRESS_BOOK_ENTRY_PARSED](	
			[Address_book_entry_xml_temp_storage_id]
			, [Contact_name]		
			, [Email_id]			
			, [Some_contact_data1]	
			, [Some_contact_data2]	
			, [Some_contact_data3]	
			, [Hash]				
			, [Email]	
		)			
		SELECT
			@address_book_entry_xml_temp_storage_id
			, [Contact_name]		
			, [Email_id]			
			, [Some_contact_data1]	
			, [Some_contact_data2]	
			, [Some_contact_data3]	
			, [Hash] = [dbo].[fn_hash_email](Email)
			, [Email]				
		FROM 
			OPENXML(@address_book_doc, '/address_book_entry/row', 4) 
			WITH [dbo].[ADDRESS_BOOK_ENTRY_PARSED]

		-- remove document right after parsing
		EXEC [sp_xml_removedocument] @address_book_doc	

		---- resolve emails
		EXEC [dbo].[resolve_email_identificator]		
			@address_book_entry_xml_temp_storage_id = @address_book_entry_xml_temp_storage_id

		-- if there is no transaction opened yet - open a new one. Otherwise, if there is/are - no need to increase @@TRANCOUNT
		IF @tran_count = 0
			BEGIN TRANSACTION

			-- if procedure invoced async - notify next service that address book entry xml successfully parsed and ready for furthem process
			IF @the_procedure_invoked_async = 1
			BEGIN
				-- coock message
				SET @message_body_xml = (
					SELECT
						@address_book_entry_xml_temp_storage_id	AS [address_book_entry_xml_temp_storage_id]
						FOR XML PATH('address_book_entry'), TYPE, ELEMENTS) 
				
				-- send notification
				EXEC [dbo].[companyname_roster_addressbookentryaction_saveonaddressbookentryxmlparsed_request_message_sender]
					@message_body_xml = @message_body_xml
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

		-- remove document from memory if it is still there
		IF EXISTS(SELECT 1 FROM sys.dm_exec_xml_handles(@@SPID) AS f WHERE f.document_id = @address_book_doc)
		BEGIN
			EXEC [sp_xml_removedocument] @address_book_doc
		END

		-- clean up inmemory temp storages
		-- It is recommendet to call NCSPs with unnamed params
		EXEC [dbo].[remove_address_book_entry_parsed] @address_book_entry_xml_temp_storage_id	

		RAISERROR(@error_msg, 16,1) 

	END CATCH
END