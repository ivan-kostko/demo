
/*
	the function generates HASH for given email. For the moment the algorithm is md5.
	KEEP in sync with [<schema>].[EMAIL].[Hash] function
*/
CREATE FUNCTION [dbo].[fn_hash_email]
(
	@email NVARCHAR(320)
)
RETURNS BIGINT
AS
BEGIN
	RETURN CAST(HASHBYTES('md5', @email) AS BIGINT)	
END
