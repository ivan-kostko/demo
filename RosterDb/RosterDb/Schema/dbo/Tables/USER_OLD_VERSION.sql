CREATE TABLE [dbo].[USER_OLD_VERSION]
(
	[User_id]				INT				NOT NULL	
	, [Email_id]			INT				NOT NULL	-- reference to [<schema>].[EMAIL].[Id]
	, [Name]				NVARCHAR(255)	NOT NULL	-- user name
	, [User_status_id]		INT				NOT NULL	-- reference to [<schema>].[USER_STATUS].[Id]
	, [Valid_from]			DATETIME2		NOT NULL	-- datetime user data valid from
	, [Valid_until]			DATETIME2		NOT NULL	-- datetime user data valid until;
)
