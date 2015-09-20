/*
	the function generates address book entries with random values
	USed for testing purpose
*/
CREATE FUNCTION [test].[fn_generate_address_book_entries]
(
	@not_existing_emails_count	INT	-- number of not existing emails
	, @existing_emails_count	INT -- number of existing emails
	, @user_emails_count		INT -- number of users emails
	, @nulls_count			INT = 0 -- number of null values
)
RETURNS TABLE AS RETURN
(
	SELECT
		CAST([test].[fn_get_newid_nvarchar]()	AS nvarchar(255))	AS [Contact_name]
		, f.[Email]													AS [Email]
		, CAST([test].[fn_get_newid_nvarchar]() AS nvarchar(255))	AS [Some_contact_data1]
		, CAST([test].[fn_get_newid_nvarchar]() AS nvarchar(255))	AS [Some_contact_data2]
		, CAST([test].[fn_get_newid_nvarchar]() AS nvarchar(255))	AS [Some_contact_data3] 
	FROM
		[test].[fn_generate_emails](@not_existing_emails_count, @existing_emails_count, @user_emails_count, @nulls_count) f
)