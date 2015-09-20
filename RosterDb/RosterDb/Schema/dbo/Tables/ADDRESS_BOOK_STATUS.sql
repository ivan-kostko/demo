/*
	The table stores a description list of unique address book statuses within CompanyName Rostering System
*/
CREATE TABLE [dbo].[ADDRESS_BOOK_STATUS]
(
	[Id]			INT				NOT NULL -- status identificator
	, [Name]		NVARCHAR(255)	NOT NULL -- human readable name/description
	, CONSTRAINT [PK_ADDRESS_BOOK_STATUS]	PRIMARY KEY CLUSTERED ([Id])
)
