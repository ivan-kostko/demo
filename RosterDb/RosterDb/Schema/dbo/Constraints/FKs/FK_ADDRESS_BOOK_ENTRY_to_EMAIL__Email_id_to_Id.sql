/*
	The constraint implements a reference from [<schema>].[ADDRESS_BOOK_ENTRY].[Email_id] to [<schema>].[EMAIL].[Id]
*/
ALTER TABLE [dbo].[ADDRESS_BOOK_ENTRY]
	ADD CONSTRAINT [FK_ADDRESS_BOOK_ENTRY_to_EMAIL__Email_id_to_Id]
	FOREIGN KEY ([Email_id])
	REFERENCES [EMAIL] ([Id])
