/*
	The procedure implements registering synchronization information about created address book mapping between [<schema>].[ADDRESS_BOOK].[Id] and temp address book entry storage 
*/
CREATE PROCEDURE [dbo].[register_addressbook_created]
	@address_book_entry_xml_temp_storage_id	INT		-- the identificator of xml temporary stored at [<schema>].[ADDRESS_BOOK_ENTRY_XML_TEMP_STORAGE]
	, @address_book_id						INT
AS
BEGIN
	
	DECLARE @tran_count				INT	= @@TRANCOUNT	-- initial number of transactions

	BEGIN TRY
		
		INSERT INTO [dbo].[XML_TEMP_STORAGE_ID_TO_ADDRESS_BOOK_ID_MAP](
			[Address_book_entry_xml_temp_storage_id]
			, [Address_book_id] 
			, [Address_book_entry_xml_is_parsed]
		)
		SELECT
			@address_book_entry_xml_temp_storage_id
			, @address_book_id
			, NULL
		WHERE 
			NOT EXISTS(SELECT 1 FROM [dbo].[XML_TEMP_STORAGE_ID_TO_ADDRESS_BOOK_ID_MAP] 
						WHERE [Address_book_entry_xml_temp_storage_id] = @address_book_entry_xml_temp_storage_id)
		
		-- 
		IF @@ROWCOUNT = 0
		BEGIN
			UPDATE [dbo].[XML_TEMP_STORAGE_ID_TO_ADDRESS_BOOK_ID_MAP] 
				SET [Address_book_id] = @address_book_id
			WHERE 
				[Address_book_entry_xml_temp_storage_id] = @address_book_entry_xml_temp_storage_id	
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
		
		RAISERROR(@error_msg, 16,1) 
      
	END CATCH
END