/*
	The table represents last processed values by incremental extraction processes
*/
CREATE TABLE [dw].[EXTRACTION_INCREMENTAL_ACTUAL_STATUS]
(
	[Destination]	NVARCHAR(255)	NOT NULL
	, [Package]		NVARCHAR(255)	NOT NULL
	, [Source]		NVARCHAR(255)	NOT NULL
	, [Value_int]	INT				NULL
	, [Value_str]	NVARCHAR(255)	NULL
	, CONSTRAINT [UC_EXTRACTION_INCREMENTAL_ACTUAL_STATUS_Destination_Package_Source] UNIQUE CLUSTERED ([Destination], [Package], [Source])		
)
