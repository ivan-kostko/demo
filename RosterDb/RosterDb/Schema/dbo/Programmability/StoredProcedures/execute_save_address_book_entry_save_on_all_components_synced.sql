/*
	The procedure checks whether all components are synced and if so executes [dbo].[save_address_book_entry] 
*/

CREATE PROCEDURE [dbo].[execute_save_address_book_entry_save_on_all_components_synced]
	@address_book_entry_xml_temp_storage_id	INT			-- the identificator of xml temporary stored at [<schema>].[ADDRESS_BOOK_ENTRY_XML_TEMP_STORAGE]
	, @the_procedure_invoked_async			BIT = 0		-- whether the procedure is invoked sync(0) or async(1)
	, @address_book_entry_has_been_saved	BIT = 0	OUT	-- 
AS
BEGIN
	
	DECLARE @tran_count				INT	= @@TRANCOUNT	-- initial number of transactions
			, @address_book_id		INT = NULL

	BEGIN TRY
		
		-- reset out param
		SET @address_book_entry_has_been_saved = 0

		SELECT
			@address_book_id = [Address_book_id]
			, @address_book_entry_has_been_saved = 0
		FROM
			[dbo].[XML_TEMP_STORAGE_ID_TO_ADDRESS_BOOK_ID_MAP]
		WHERE
			[Address_book_entry_xml_temp_storage_id] = @address_book_entry_xml_temp_storage_id
		AND [Address_book_entry_xml_is_parsed] = 1

		IF @address_book_id IS NOT NULL AND @address_book_entry_xml_temp_storage_id IS NOT NULL
		BEGIN
			-- save the address book data
			EXEC [dbo].[save_address_book_entry] 
				@address_book_id = @address_book_id
				-- pass the temp storage id instead of xml
				, @address_book_entry_xml = NULL
				, @address_book_entry_xml_temp_storage_id = @address_book_entry_xml_temp_storage_id
				-- the procedure executed async
				, @the_procedure_invoked_async = @the_procedure_invoked_async
			
			SET @address_book_entry_has_been_saved = 1
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