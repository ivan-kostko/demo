/*
	The table stores user ids which have recent changes and should be processed into warehouse
*/
CREATE TABLE [dw].[ROSTERDW_USER_TRANSFER_CANDIDATE]
(
	[User_id] INT NOT NULL
)
