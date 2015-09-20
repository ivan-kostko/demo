/*
	The table represents temp cache storage for parsed address book entry xml 
	To reduce redundant I/O load on file system it is done as inmemory table
	In case of moving it to static - consider to refactor SP [dbo].[remove_address_book_entry_parsed] from NCSP to general one
*/

CREATE TABLE [dbo].[ADDRESS_BOOK_ENTRY_PARSED]
(
	[Address_book_entry_xml_temp_storage_id] INT NOT NULL INDEX [IX_ADDRESS_BOOK_ENTRY_PARSED_Address_book_entry_xml_temp_storage_id] NONCLUSTERED
	, [Contact_name]		NVARCHAR(255)		NULL		-- entry contact name (it is ot of the assignment scope)
	, [Email_id]			INT					NULL		-- reference to [<schema>].[EMAIL].[Id]
	, [Some_contact_data1]	NVARCHAR(255)		NULL		-- Some text data field
	, [Some_contact_data2]	NVARCHAR(255)		NULL		-- Some text data field
	, [Some_contact_data3]	NVARCHAR(255)		NULL		-- Some text data field
	, [Hash]				BIGINT				NULL		-- email hash. fill up with [dbo].[fn_hash_email] synced with [<schema>].[EMAIL].[Hash] function
	, [Email]				NVARCHAR(320)		NULL		-- full email string value
) WITH (MEMORY_OPTIMIZED = ON, DURABILITY = SCHEMA_ONLY)

GO