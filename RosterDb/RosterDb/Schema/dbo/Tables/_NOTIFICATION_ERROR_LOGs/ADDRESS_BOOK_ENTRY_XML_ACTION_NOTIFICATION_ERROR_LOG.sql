
/*
	The table represents heap of logged errors during message processing by ADDRESS_BOOK_ENTRY_XML_ACTION_* queues
*/
CREATE TABLE [dbo].[ADDRESS_BOOK_ENTRY_XML_ACTION_NOTIFICATION_ERROR_LOG]
(
	[Message_body]		XML
	, [Message_type]	NVARCHAR(255)
	, [Error_msg]		NVARCHAR(4000)
	, [Date_time]		DATETIME CONSTRAINT [DF_ADDRESS_BOOK_ENTRY_XML_ACTION_NOTIFICATION_ERROR_LOG_Date_time] DEFAULT (GETDATE()) 
)
