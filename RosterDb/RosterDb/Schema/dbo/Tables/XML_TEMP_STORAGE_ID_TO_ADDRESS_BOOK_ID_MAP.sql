/*
	The table represents temp / cached storage for mapping between resolved address book id and corresponding address book entry XML temp storage id
	It is implemented as static table due to have compatibility with failover functionality(for.ex. mirroring) and to be able to reprocess aborted operations.
*/

CREATE TABLE [dbo].[XML_TEMP_STORAGE_ID_TO_ADDRESS_BOOK_ID_MAP]
(
	[Address_book_entry_xml_temp_storage_id]	INT NOT NULL 
	, [Address_book_id]							INT NULL
	, [Address_book_entry_xml_is_parsed]		BIT NULL
	, CONSTRAINT [PK_XML_TEMP_STORAGE_ID_TO_ADDRESS_BOOK_ID_MAP] PRIMARY KEY CLUSTERED ([Address_book_entry_xml_temp_storage_id])
) 