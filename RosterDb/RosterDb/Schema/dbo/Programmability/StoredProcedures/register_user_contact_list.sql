
/*
	The procedure implements the entrance point interface to register user and/or users address book
*/

CREATE PROCEDURE [dbo].[register_user_contact_list]
	@user_name					NVARCHAR(255)							-- users name
	, @user_email				NVARCHAR(320)							-- users email
	, @address_book_entry_xml	XML	(AddressBookEntrySchemaCollection)	-- xml representation of address book entries <see=AddressBookEntrySchemaCollection/>
	, @save_address_book_async	BIT = 1									-- process address book creating and entries saving sync(0) or async(1)
AS
BEGIN
	
	DECLARE @tran_count						INT = @@TRANCOUNT		-- initial number of transactions
			, @user_email_id				INT						-- email identificator at dbo.EMAIL 
			, @user_id						INT						-- user identificator at dbo.USER 
			, @user_current_address_book_id INT						-- current user address book identificator
			, @user_new_address_book_id		INT						-- newly created users address book
			, @initial_user_status			INT			= 1			-- user status identificator at dbo.USER_STATUS when user just created
			, @address_book_entry_xml_temp_storage_id	INT	= NULL	-- identificator at [<schema>].[ADDRESS_BOOK_ENTRY_XML_TEMP_STORAGE].[Id]
			, @message_body_xml							XML			-- message xml representation
		
	BEGIN TRY
		
		-- resolve user email identificator
		EXEC [dbo].[resolve_single_email_id]
			@email = @user_email
			, @email_id = @user_email_id OUT

		-- if async then save xml and send message to process it ASAP
		IF @save_address_book_async = 1
		BEGIN
			IF @address_book_entry_xml IS NOT NULL
			BEGIN
				INSERT INTO [dbo].[ADDRESS_BOOK_ENTRY_XML_TEMP_STORAGE](Address_book_entry_xml)
				VALUES(@address_book_entry_xml)

				SET @address_book_entry_xml_temp_storage_id = SCOPE_IDENTITY()
				
				SET @message_body_xml = (
					SELECT
						@address_book_entry_xml_temp_storage_id	AS [address_book_entry_xml_temp_storage_id]
						FOR XML PATH('address_book'), TYPE, ELEMENTS) 
					
				EXEC [dbo].[companyname_roster_addressbookentryxmlaction_parse_request_message_sender]
					@message_body_xml = @message_body_xml
			END
		END

		-- insert user if it is new one
		INSERT INTO [dbo].[USER] (
			[Email_id]
			, [Name]
			, [User_status_id]
		)
		SELECT
			@user_email_id
			, @user_name	
			, @initial_user_status
		WHERE
			NOT EXISTS(SELECT 1 FROM [dbo].[USER] u   WHERE u.[Email_id] = @user_email_id AND u.[Name] = @user_name)
	
		-- resolve user identificatorand current address book
		SELECT 
			@user_id = u.[Id] 
			, @user_current_address_book_id = u.[User_actual_address_book_id]	-- if the user has already active address book
		FROM
			dbo.[USER] u  
		WHERE
			u.Email_id = @user_email_id
		AND u.Name = @user_name

		-- if there is no transactions opened yet - open a new one. Otherwise, if there is/are - no need to increase @@TRANCOUNT
		IF @tran_count = 0
			BEGIN TRANSACTION

			-- process address book creating and saving
			IF ISNULL(@save_address_book_async, 0) = 0
			BEGIN
				-- save the address book data sync
				EXEC [dbo].[create_address_book] 
					@user_id = @user_id
					, @user_current_address_book_id = @user_current_address_book_id
					, @user_new_address_book_id = @user_new_address_book_id OUT
					, @address_book_entry_xml = @address_book_entry_xml

				-- Now address book is ready to go live for user
				UPDATE [dbo].[USER]
					SET [User_actual_address_book_id] = @user_new_address_book_id
				WHERE
					[Id] = @user_id
		
			END
			ELSE -- @save_address_book_async = 1
			BEGIN
				-- save the address book data async
				EXEC [dbo].[create_address_book_async] 
					@user_id = @user_id
					, @user_current_address_book_id = @user_current_address_book_id
					, @address_book_entry_xml = NULL -- we've saved it already, so pass identificator at [<schema>].[ADDRESS_BOOK_ENTRY_XML_TEMP_STORAGE].[Id]
					, @address_book_entry_xml_temp_storage_id = @address_book_entry_xml_temp_storage_id

				-- The new address book will be assigned to user asynchronusly by reply
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
GO
