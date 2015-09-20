
/*
	The table stores address book history data
*/
CREATE TABLE [dbo].[ADDRESS_BOOK]
(
	[Id]			INT IDENTITY(1,1)	NOT NULL
	, [User_id]		INT					NOT NULL		-- owner user identificator; -- reference to [<schema>].[USER].[Id]
	, [Address_book_status_id]	INT		NOT NULL		-- address book stetus; -- reference to [<schema>].[ADDRESS_BOOK_STATUS].[Id]
	, [Valid_from]	DATETIME2			NOT NULL		-- datetime address book valid from
	, [Valid_until] DATETIME2			NULL			-- datetime address book valid until; for active address book should be NULL
	, CONSTRAINT [PK_ADDRESS_BOOK] PRIMARY KEY CLUSTERED ([Id])
)
