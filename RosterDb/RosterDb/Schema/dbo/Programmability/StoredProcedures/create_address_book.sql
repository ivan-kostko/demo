
/*
	The procedure implements the entrance point interface to create address book and its entries for registered user
*/

CREATE PROCEDURE [dbo].[create_address_book]
	@user_id											INT			-- user(address book owner) identificator at dbo.USER 
	, @user_current_address_book_id						INT			-- current active users address book
	, @user_new_address_book_id							INT	OUT		-- newly created users address book
	, @address_book_entry_xml XML (AddressBookEntrySchemaCollection)-- xml representation of address book entries <see=AddressBookEntrySchemaCollection/>
	, @address_book_entry_xml_temp_storage_id			INT	= NULL	-- identificator at [<schema>].[ADDRESS_BOOK_ENTRY_XML_TEMP_STORAGE].[Id] if it is used
	, @the_procedure_invoked_async						BIT = 0		-- whether the procedure is invoked sync(0) or async(1)
AS
BEGIN
	
	DECLARE @tran_count				INT	= @@TRANCOUNT	-- initial number of transactions
			, @saved_address_book_status_id INT	= 1		-- address book status identificator at dbo.ADDRESS_BOOK_STATUS when address book is created and saved
			, @initial_address_book_status_id INT = 2	-- address book status identificator at dbo.ADDRESS_BOOK_STATUS when address book is created but saved
			, @registering_datetime	DATETIME = GETDATE()-- date and time of switching/registering address book. Most likely - current date and time
			
	BEGIN TRY
		
		-- if there is no transaction opened yet - open a new one. Otherwise, if there is/are - no need to increase @@TRANCOUNT
		IF @tran_count = 0
			BEGIN TRANSACTION
		
		-- if user has active address book - change [<schema>].[ADDRESS_BOOK].[Valid_until] value
		IF @user_current_address_book_id IS NOT NULL
		BEGIN
			UPDATE [dbo].[ADDRESS_BOOK]
				SET [Valid_until] = @registering_datetime
			WHERE 
				[Id] = @user_current_address_book_id
		END

		-- if new address book entries exist
		IF ((ISNULL(@the_procedure_invoked_async, 0) = 0 AND @address_book_entry_xml IS NOT NULL)
			OR (@the_procedure_invoked_async = 1 
					AND EXISTS(SELECT 1 FROM [ADDRESS_BOOK_ENTRY_XML_TEMP_STORAGE] WHERE [Id] = @address_book_entry_xml_temp_storage_id AND [Address_book_entry_xml] IS NOT NULL)))
		BEGIN

			-- create address book
			INSERT INTO [ADDRESS_BOOK] (
				[User_id]
				, [Address_book_status_id]
				, [Valid_from]
			)
			SELECT 
				@user_id
				,	CASE WHEN @the_procedure_invoked_async = 1 THEN @initial_address_book_status_id -- status will be updated async to @saved_address_book_status_id when the book is saved
						ELSE @saved_address_book_status_id END
				,	@registering_datetime		

			-- get created address book identificator
			SET @user_new_address_book_id = SCOPE_IDENTITY()

			-- create a new address book 
			IF @the_procedure_invoked_async = 1
			BEGIN
				-- execute address book saving in the same way as current procedure is invoked
				EXEC [dbo].[save_address_book_entry_async]
					@address_book_id = @user_new_address_book_id
					, @address_book_entry_xml = NULL
					, @address_book_entry_xml_temp_storage_id = @address_book_entry_xml_temp_storage_id
			END
			ELSE
			BEGIN
				-- execute address book saving in the same way as current procedure is invoked
				EXEC [dbo].[save_address_book_entry]
					@address_book_id = @user_new_address_book_id
					, @address_book_entry_xml = @address_book_entry_xml
					, @address_book_entry_xml_temp_storage_id = NULL
					, @the_procedure_invoked_async = @the_procedure_invoked_async
			END
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
		
		RAISERROR(@error_msg, 16,1) 
      
	END CATCH

END