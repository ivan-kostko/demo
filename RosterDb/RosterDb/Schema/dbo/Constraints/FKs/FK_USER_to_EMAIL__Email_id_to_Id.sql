
/*
	The constraint implements a reference from [<schema>].[USER].[Email_id] to [<schema>].[EMAIL].[Id]
*/
ALTER TABLE [dbo].[USER]
	ADD CONSTRAINT [FK_USER_to_EMAIL__Email_id_to_Id]
	FOREIGN KEY (Email_id)
	REFERENCES [EMAIL] (Id)
