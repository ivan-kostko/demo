/*
	The table stores address book entry xml data while message is passing throuh several queue(s)
	It is implemented as static table due to have compatibility with failover functionality(for.ex. mirroring) and to be able to reprocess aborted operations.
*/
CREATE TABLE [dbo].[ADDRESS_BOOK_ENTRY_XML_TEMP_STORAGE]
(
	[Id]			INT IDENTITY(1,1) NOT NULL PRIMARY KEY NONCLUSTERED
	--, [Status_id]	BIT CONSTRAINT [DF_ADDRESS_BOOK_ENTRY_XML_TEMP_STORAGE_Status_id] DEFAULT (0) -- 0=notprocessed; NULL=in prasing process; 1=done;
	, [Address_book_entry_xml]	XML	(AddressBookEntrySchemaCollection)
	, CONSTRAINT [UQ_ADDRESS_BOOK_ENTRY_XML_TEMP_STORAGE_Status_id_Id] UNIQUE NONCLUSTERED ([Id])
)
