/*
	The constraint implements a reference from [<schema>].[ADDRESS_BOOK].[User_id] to [<schema>].[USER].[Id]
*/

ALTER TABLE [dbo].[ADDRESS_BOOK]
	ADD CONSTRAINT [FK_ADDRESS_BOOK_to_USER__User_id_to_Id]
	FOREIGN KEY ([User_id])
	REFERENCES [USER] ([Id])
