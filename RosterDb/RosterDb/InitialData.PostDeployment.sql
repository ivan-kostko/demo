/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/

:r .\Schema\dbo\Tables\Initial_Data\USER_STATUS_fill-up.sql

:r .\Schema\dbo\Tables\Initial_Data\ADDRESS_BOOK_STATUS_fill-up.sql

:r .\Schema\dw\Tables\InitialData\EXTRACTION_INCREMENTAL_ACTUAL_STATUS_fill-up.sql

:r .\Add_me.sql