/*
	the function generates random emails
	Used for testing purpose
*/
CREATE FUNCTION [test].[fn_generate_emails]
(
	@not_existing_count INT		-- number of not existing emails
	, @existing_count	INT	= 0	-- number of existing emails
	, @users_count		INT = 0	-- number of users emails
	, @nulls_count		INT = 0 -- number of null values
)
RETURNS TABLE AS RETURN 
	
	-- generate non existing emails; Chances of collision are very low.
	WITH Q_New_Emails AS (
		SELECT
			1 AS [lvl]
			, [test].[fn_get_newid_nvarchar]()+'@'+[test].[fn_get_newid_nvarchar]()+'.'+[test].[fn_get_newid_nvarchar]() AS [Email]
		WHERE
			1 <= @not_existing_count
		UNION ALL
		SELECT
			q.[lvl] + 1
			, [test].[fn_get_newid_nvarchar]()+'@'+[test].[fn_get_newid_nvarchar]()+'.'+[test].[fn_get_newid_nvarchar]() AS [Email]
		FROM
			Q_New_Emails q
		WHERE
			q.[lvl] < @not_existing_count
	), Q_Null_emails AS (
		SELECT
			1 AS [lvl]
			, CAST(NULL AS NVARCHAR(320)) AS [Email]
		WHERE
			1 <= @nulls_count
		UNION ALL
		SELECT
			q.[lvl] + 1
			, CAST(NULL AS NVARCHAR(320)) AS [Email]
		FROM
			Q_New_Emails q
		WHERE
			q.[lvl] < @nulls_count	
	)
	SELECT
		CAST(q.[Email] AS NVARCHAR(320)) AS [Email]
	FROM
		Q_New_Emails q
	UNION ALL
	SELECT 
		TOP (@existing_count)
		[Email] 
	FROM 
		[dbo].[EMAIL] e   
	UNION ALL
	SELECT
		CAST(q.[Email] AS NVARCHAR(320)) AS [Email]
	FROM
		Q_Null_emails q
	UNION ALL	
	SELECT
		TOP(@users_count)
		e.[Email]
	FROM
		[dbo].[USER] u  
		INNER JOIN [dbo].[EMAIL] e   ON e.[Id] = u.[Email_id] 
	ORDER BY [test].[fn_get_newid_nvarchar]()


