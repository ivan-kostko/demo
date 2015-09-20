CREATE FUNCTION [test].[fn_get_newid_nvarchar]()
RETURNS NVARCHAR(64)
AS
BEGIN
	RETURN (SELECT TOP 1 [Nnewid_nvarchar] FROM [test].[V_NEWID_VALUE])
END
