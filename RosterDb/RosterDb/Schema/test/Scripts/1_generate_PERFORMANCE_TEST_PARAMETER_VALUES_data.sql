WITH Q_Params AS (
	SELECT
		1 AS [lvl]
		, [RosterDb].[test].[fn_get_newid_nvarchar]() AS [User_name]
		, [RosterDb].[test].[fn_get_newid_nvarchar]()+'@'+[RosterDb].[test].[fn_get_newid_nvarchar]() AS [Email]
		, (SELECT		
			(SELECT
				*
			FROM
				[RosterDb].[test].[fn_generate_address_book_entries](480, 480, 20)	
				FOR XML RAW, TYPE
		   ) AS address_book_entry   
		FOR XML PATH(''), ELEMENTS) AS [Address_book_xml]
	UNION ALL
	SELECT
		[lvl] + 1 AS [lvl]
		, [RosterDb].[test].[fn_get_newid_nvarchar]() AS [User_name]
		, [RosterDb].[test].[fn_get_newid_nvarchar]()+'@'+[RosterDb].[test].[fn_get_newid_nvarchar]() AS [Email]
		, (SELECT		
			(SELECT
				*
			FROM
				[RosterDb].[test].[fn_generate_address_book_entries](480, 480, 20) AS t	
				FOR XML RAW, TYPE
		   ) AS address_book_entry   
		FOR XML PATH(''), ELEMENTS) AS [Address_book_xml]
	FROM
		Q_Params
	WHERE
		[lvl] < 100
)
INSERT INTO [RosterDb].[test].[PERFORMANCE_TEST_PARAMETER_VALUES] (
	[Status]
	, [User_name]
	, [Email]
	, [Address_book_xml]
)
SELECT 
	0 AS [Status]
	, [User_name]
	, [Email]
	, [Address_book_xml]
FROM Q_Params
OPTION (MAXRECURSION  1000)