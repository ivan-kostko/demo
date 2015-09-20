/*
	The constraint implements a reference from [<schema>].[USER].[User_actual_address_book_id] to [<schema>].[ADDRESS_BOOK].[Id]
*/
ALTER TABLE [dbo].[USER]
	ADD CONSTRAINT [FK_USER_to_ADDRESS_BOOK__User_actual_address_book_id_to_Id]
	FOREIGN KEY ([User_actual_address_book_id])
	REFERENCES [ADDRESS_BOOK] ([Id])
