/*
	the procedure retreives email data from ETL processing by RosterDbToDW
*/

CREATE PROCEDURE [dw].[get_rosterdw_email_data]
	@is_incremental	BIT = 0 -- if 0 extracts all, 1 only incremental update
AS
BEGIN
	
	DECLARE @tran_count						INT = @@TRANCOUNT		-- initial number of transactions
			, @min_email_id					INT
			, @max_email_id					INT
			, @destination					NVARCHAR(255) = N'RosterDW'
			, @package						NVARCHAR(255) = N'RosterDbToDW'
			, @source						NVARCHAR(255) = N'Email'
	
	BEGIN TRY

		-- get min id
		IF @is_incremental = 1
		BEGIN
			-- get min email id from settings
			SELECT
				@min_email_id = ISNULL(t.[Value_int], 0) 
			FROM
				[dw].[EXTRACTION_INCREMENTAL_ACTUAL_STATUS] t
			WHERE
				t.[Destination]	= @destination
			AND t.[Package]		= @package 
			AND t.[Source]		= @source
		END
		ELSE
		BEGIN
			SET @min_email_id = 0
		END

		-- get max email id
		SELECT 
			@max_email_id = MAX([Id])
		FROM
			[dbo].[EMAIL]

		SELECT
			e.[Id] 
			, e.[Email] 
		FROM
			[dbo].[EMAIL] e
		WHERE
			e.[Id] BETWEEN @min_email_id AND @max_email_id

		UPDATE [dw].[EXTRACTION_INCREMENTAL_ACTUAL_STATUS]
			SET [Value_int] = @max_email_id
		WHERE
			[Destination]	= @destination
		AND [Package]		= @package 
		AND [Source]		= @source
	
	END TRY
	BEGIN CATCH

		IF @@TRANCOUNT > 0      
			ROLLBACK
               
		DECLARE
			  @options           BIGINT         = @@OPTIONS
			, @ERROR_NUMBER      INT            = ERROR_NUMBER()
			, @ERROR_SEVERITY    INT            = ERROR_SEVERITY()
			, @ERROR_STATE       INT            = ERROR_STATE()
			, @ERROR_LINE        INT            = ERROR_LINE()
			, @ERROR_PROCEDURE   NVARCHAR(255)  = ERROR_PROCEDURE()
			, @ERROR_MESSAGE     NVARCHAR(4000) = ERROR_MESSAGE()
			, @error_msg         NVARCHAR(MAX)  = ''
			, @separator_char    CHAR           = CHAR(10)   
      
		EXEC [dbo].[log_error] 
			  @options         = @options        
			, @ERROR_NUMBER    = @ERROR_NUMBER   
			, @ERROR_SEVERITY  = @ERROR_SEVERITY 
			, @ERROR_STATE     = @ERROR_STATE    
			, @ERROR_LINE      = @ERROR_LINE     
			, @ERROR_PROCEDURE = @ERROR_PROCEDURE
			, @ERROR_MESSAGE   = @ERROR_MESSAGE  
			, @error_msg       = @error_msg			OUT
			, @separator_char  = @separator_char 

		RAISERROR(@error_msg, 16,1) 
      
	END CATCH
END
GO
