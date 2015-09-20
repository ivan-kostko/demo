/*
	The constraint implements a reference from [<schema>].[ADDRESS_BOOK].[Address_book_status_id] to [<schema>].[ADDRESS_BOOK_STATUS].[Id]
*/
ALTER TABLE [dbo].[ADDRESS_BOOK]
	ADD CONSTRAINT [FK_ADDRESS_BOOK_to_ADDRESS_BOOK_STATUS__Address_book_status_id_to_Id]
	FOREIGN KEY ([Address_book_status_id])
	REFERENCES [dbo].[ADDRESS_BOOK_STATUS] ([Id])
