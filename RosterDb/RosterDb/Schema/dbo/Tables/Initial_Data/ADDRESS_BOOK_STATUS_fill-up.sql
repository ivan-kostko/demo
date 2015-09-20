-- Initial data for [dbo].[ADDRESS_BOOK_STATUS]
;WITH Q_Data AS (
	SELECT 0 AS [Id], N'Inactive' AS [Name] UNION ALL
	SELECT 1 AS [Id], N'Active' AS [Name] UNION ALL
	SELECT 2 AS [Id], N'Saving address book entries' AS [Name] 
)
INSERT INTO [dbo].[ADDRESS_BOOK_STATUS] ([Id], [Name])
SELECT * FROM Q_Data qd 
WHERE NOT EXISTS(SELECT 1 FROM [dbo].[ADDRESS_BOOK_STATUS] us WHERE us.[Id] = qd.[Id])