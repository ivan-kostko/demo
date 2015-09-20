
/*
	The table stores unique emails within CompanyName Rostering System
	
	According to standart description http://tools.ietf.org/html/rfc5321:
	4.5.3.1.1.  Local-part
	   The maximum total length of a user name or other local-part is 64
	   octets.
	4.5.3.1.2.  Domain
	   The maximum total length of a domain name or number is 255 octets.
*/
CREATE TABLE [dbo].[EMAIL]
(
	[Id]							INT IDENTITY(1,1)		NOT NULL
	, [Hash]						AS CAST(HASHBYTES('md5', [Email]) AS BIGINT)	
	, [Email]						NVARCHAR(320)			NOT NULL	-- full email string value
	, CONSTRAINT [PK_EMAIL]				PRIMARY KEY CLUSTERED ([Id])
	, CONSTRAINT [UQ_EMAIL_Hash_Email]	UNIQUE NONCLUSTERED ([Hash],[Email])
)
