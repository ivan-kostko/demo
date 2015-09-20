
/*
	The table stores a description list of unique user statuses within CompanyName Rostering System
*/
CREATE TABLE [dbo].[USER_STATUS]
(
	[Id]			INT				NOT NULL -- status identificator
	, [Name]		NVARCHAR(255)	NOT NULL -- human readable name/description
	, CONSTRAINT [PK_USER_STATUS]	PRIMARY KEY CLUSTERED ([Id])
)
