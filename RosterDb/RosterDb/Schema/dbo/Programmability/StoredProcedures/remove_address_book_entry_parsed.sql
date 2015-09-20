/*
	The procedure removes from [dbo].[ADDRESS_BOOK_ENTRY_PARSED] all entries assigned to [Address_book_entry_xml_temp_storage_id] = @address_book_entry_xml_temp_storage_id
*/

/*
The database must have a MEMORY_OPTIMIZED_DATA filegroup
before the memory optimized object can be created.
*/

CREATE PROCEDURE [dbo].[remove_address_book_entry_parsed]
	 @address_book_entry_xml_temp_storage_id				INT		-- identificator at [<schema>].[ADDRESS_BOOK_ENTRY_XML_TEMP_STORAGE].[Id]
WITH NATIVE_COMPILATION, SCHEMABINDING, EXECUTE AS OWNER 
AS BEGIN ATOMIC WITH (
      TRANSACTION ISOLATION LEVEL = SNAPSHOT,
      LANGUAGE = 'English')
	
		DELETE [dbo].[ADDRESS_BOOK_ENTRY_PARSED]
		WHERE [Address_book_entry_xml_temp_storage_id] = @address_book_entry_xml_temp_storage_id

RETURN 0
END