/*
	The table represents heap of logged errors
*/
CREATE TABLE [dbo].[LOG]
(
	[Id]				INT IDENTITY(1,1)
	, [Error_message]   NVARCHAR(4000)
	, [Date_time]		DATETIME  CONSTRAINT [DF_LOG_Date_time] DEFAULT  (GETDATE())
)