
/*
	The procedure implements entrance point of error logging functionality.
	Exact implementation is out of scope of the assignment
*/

CREATE PROCEDURE [dbo].[log_error]
	   @options           BIGINT        
	 , @ERROR_NUMBER      INT           
	 , @ERROR_SEVERITY    INT           
	 , @ERROR_STATE       INT           
	 , @ERROR_LINE        INT           
	 , @ERROR_PROCEDURE   NVARCHAR(255) 
	 , @ERROR_MESSAGE     NVARCHAR(4000)
	 , @separator_char    CHAR      
	 , @error_msg         NVARCHAR(MAX)		OUT
AS
BEGIN
      
	  SET @separator_char = ISNULL(@separator_char, N'|')
	  SELECT
         @error_msg ='Opt: ' + ISNULL(CAST(@options AS NVARCHAR(19)),'NULL') + @separator_char +
                     'Err: ' + ISNULL(CAST(@ERROR_NUMBER AS NVARCHAR(19)),'NULL')  + @separator_char +
                     'Svr: ' + ISNULL(CAST(@ERROR_SEVERITY AS NVARCHAR(19)),'NULL')  + @separator_char +
                     'Stt: ' + ISNULL(CAST(@ERROR_STATE AS NVARCHAR(19)),'NULL')  + @separator_char +
                     'Ln : ' + ISNULL(CAST(@ERROR_LINE AS NVARCHAR(19)),'NULL')  + @separator_char +
                     'Prc: ' + ISNULL(CAST(@ERROR_PROCEDURE AS NVARCHAR(255)),'NULL')  + @separator_char +
                     'Msg: ' + ISNULL(CAST(@ERROR_MESSAGE AS NVARCHAR(4000)),'NULL')  + @separator_char

	INSERT INTO [dbo].[LOG]([Error_message])
	VALUES (@error_msg)

END