
/*
	The table stores address book entries data
*/
CREATE TABLE [dbo].[ADDRESS_BOOK_ENTRY]
(
	[Address_book_id]		INT					NOT NULL	-- reference to [<schema>].[ADDRESS_BOOK].[Id]
	, [Contact_name]		NVARCHAR(255)		NULL		-- entry contact name (it is ot of the assignment scope)
	, [Email_id]			INT					NULL		-- reference to [<schema>].[EMAIL].[Id]
	, [Some_contact_data1]	NVARCHAR(255)		NULL		-- Some text data field
	, [Some_contact_data2]	NVARCHAR(255)		NULL		-- Some text data field
	, [Some_contact_data3]	NVARCHAR(255)		NULL		-- Some text data field
)
GO
--CREATE CLUSTERED INDEX [CX_ADDRESS_BOOK_ENTRY__Address_book_id_Email_id] ON [dbo].[ADDRESS_BOOK_ENTRY]([Address_book_id], [Email_id])
CREATE NONCLUSTERED INDEX [IX_ADDRESS_BOOK_ENTRY_Address_book_id] ON [dbo].[ADDRESS_BOOK_ENTRY]([Address_book_id]) INCLUDE ([Email_id])
