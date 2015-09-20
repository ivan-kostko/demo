DECLARE @test TABLE(
	 [User_name]	NVARCHAR(255)
	, [Email]		NVARCHAR(320)
	, [Address_book_xml] XML		
)

UPDATE TOP (1) [test].[PERFORMANCE_TEST_PARAMETER_VALUES]WITH(TABLOCKX)
	SET  [Status] = 1
OUTPUT inserted.[User_name], inserted.[Email], inserted.[Address_book_xml]  INTO @test([User_name],[Email],[Address_book_xml])
WHERE
	[Status] = 0

DECLARE @user_name			NVARCHAR(255)
		, @email			NVARCHAR(320)
		, @address_book_xml XML

SELECT
	@user_name = [User_name]		
	, @email = [Email]			
	, @address_book_xml = [Address_book_xml]	
FROM
	@test t
	
SELECT 
	@user_name			
	, @email			
	, @address_book_xml


EXECUTE [dbo].[register_user_contact_list] 
	@user_name
	, @email
	, @address_book_xml
	, 1