/*
	The constraint implements a reference from [<schema>].[ADDRESS_BOOK_ENTRY].[Address_book_id] to [<schema>].[ADDRESS_BOOK].[Id]
*/
ALTER TABLE [dbo].[ADDRESS_BOOK_ENTRY]
	ADD CONSTRAINT [FK_ADDRESS_BOOK_ENTRY_to_ADDRESS_BOOK__Address_book_id_to_Id]
	FOREIGN KEY ([Address_book_id])
	REFERENCES [ADDRESS_BOOK] ([Id])
GO
GO

ALTER TABLE [dbo].[ADDRESS_BOOK_ENTRY] NOCHECK CONSTRAINT [FK_ADDRESS_BOOK_ENTRY_to_ADDRESS_BOOK__Address_book_id_to_Id]
GO
	