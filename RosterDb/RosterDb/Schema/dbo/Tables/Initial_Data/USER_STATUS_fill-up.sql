-- Initial data for [dbo].[USER_STATUS]
;WITH Q_Data AS (
	SELECT 0 AS [Id], N'Inactive' AS [Name] UNION ALL
	SELECT 1 AS [Id], N'Active' AS [Name] 
)
INSERT INTO [dbo].[USER_STATUS] ([Id], [Name])
SELECT * FROM Q_Data qd 
WHERE NOT EXISTS(SELECT 1 FROM [dbo].[USER_STATUS] us WHERE us.[Id] = qd.[Id])