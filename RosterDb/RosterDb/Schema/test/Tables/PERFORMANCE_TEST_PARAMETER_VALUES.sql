/*
	the table stores pregenerated input parameters values for [dbo].[register_user_contact_list] sp
	Used for testing purposes
*/
CREATE TABLE [test].[PERFORMANCE_TEST_PARAMETER_VALUES](
	[Test_id]			INT IDENTITY(1,1) NOT NULL
	, [Status]			BIT NOT NULL
	, [User_name]			NVARCHAR(255) NOT NULL
	, [Email]				NVARCHAR(320) NOT NULL
	, [Address_book_xml]	XML NOT NULL
	, CONSTRAINT [UC_PERFORMANCE_TEST_PARAMETER_VALUES_Status_Test_Id] UNIQUE NONCLUSTERED ([Status] ASC, [Test_id] ASC)
)
