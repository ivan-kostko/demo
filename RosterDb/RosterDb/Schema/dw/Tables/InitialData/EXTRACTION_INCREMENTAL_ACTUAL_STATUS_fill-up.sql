;WITH Q_Data AS (
	SELECT
		N'RosterDW' AS [Destination]	
		, N'RosterDbToDW' AS [Package]		
		, N'Email' AS [Source]		
		, 0 AS [Value_int]	
		, NULL AS [Value_str]
	UNION ALL	
	SELECT
		N'RosterDW' AS [Destination]	
		, N'RosterDbToDW' AS [Package]		
		, N'User' AS [Source]		
		, 0 AS [Value_int]	
		, NULL AS [Value_str]
	UNION ALL
	SELECT
		N'RosterDW' AS [Destination]	
		, N'RosterDbToDW' AS [Package]		
		, N'Address_book_entry_email' AS [Source]		
		, 0 AS [Value_int]	
		, NULL AS [Value_str]
)
INSERT INTO [dw].[EXTRACTION_INCREMENTAL_ACTUAL_STATUS](
	[Destination]	
	, [Package]		
	, [Source]		
	, [Value_int]	
	, [Value_str]	
)
SELECT
	[Destination]	
	, [Package]		
	, [Source]		
	, [Value_int]	
	, [Value_str]	
FROM
	Q_Data q
WHERE
	NOT EXISTS(SELECT 1 FROM [dw].[EXTRACTION_INCREMENTAL_ACTUAL_STATUS] t 
				WHERE t.[Destination]	=	q.[Destination]
					AND	t.[Package]		=	q.[Package]
					AND	t.[Source]		=	q.[Source]	)
