
/*
	The table stores unique users within CompanyName Rostering System
*/
CREATE TABLE [dbo].[USER]
(
	[Id]							INT IDENTITY(1,1)	NOT NULL 
	, [Email_id]					INT					NOT NULL	-- reference to [<schema>].[EMAIL].[Id]
	, [Name]						NVARCHAR(255)		NOT NULL	-- user name
	, [User_status_id]				INT					NOT NULL	-- reference to [<schema>].[USER_STATUS].[Id]
	, [User_actual_address_book_id] INT					NULL		-- reference to [<schema>].[ADDRESS_BOOK].[Id]
	, [Last_update]					DATETIME			NOT NULL CONSTRAINT [DF_USER_Last_update] DEFAULT (GETDATE())

	, CONSTRAINT [PK_USER] PRIMARY KEY CLUSTERED ([Id])
	, CONSTRAINT [UQ_USER__Email_id_Name] UNIQUE NONCLUSTERED ([Email_id], [Name])
)
