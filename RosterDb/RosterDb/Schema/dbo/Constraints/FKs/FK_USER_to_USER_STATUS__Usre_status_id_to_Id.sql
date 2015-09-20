/*
	The constraint implements a reference from [<schema>].[USER].[User_status_id] to [<schema>].[USER_STATUS].[Id]
*/
ALTER TABLE [dbo].[USER]
	ADD CONSTRAINT [FK_USER_to_USER_STATUS__Usre_status_id_to_Id]
	FOREIGN KEY ([User_status_id])
	REFERENCES [USER_STATUS] ([Id])
