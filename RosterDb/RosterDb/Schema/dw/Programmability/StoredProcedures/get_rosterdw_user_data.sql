/*
	the procedure retreives user data (actual and historical) for ETL processing by RosterDbToDW
*/
CREATE PROCEDURE [dw].[get_rosterdw_user_data]
	@is_incremental	BIT = 0	 -- if 0 retreives all; 1 - only incremental update
AS
BEGIN
	
	DECLARE @tran_count						INT = @@TRANCOUNT		-- initial number of transactions
			, @destination					NVARCHAR(255) = N'RosterDW'
			, @package						NVARCHAR(255) = N'RosterDbToDW'
			, @source						NVARCHAR(255) = N'User'

	BEGIN TRY

		IF OBJECT_ID('tempdb..#USER_ID_2B_PROCESSED') IS NOT NULL
			EXEC('DROP TABLE #USER_ID_2B_PROCESSED')

		CREATE TABLE #USER_ID_2B_PROCESSED( [User_id] INT)

		
		-- if there is no transaction opened yet - open a new one. Otherwise, if there is/are - no need to increase @@TRANCOUNT
		IF @tran_count = 0
			BEGIN TRANSACTION

			IF @is_incremental = 1
			BEGIN
				DELETE [dw].[ROSTERDW_USER_TRANSFER_CANDIDATE] WITH (READPAST)
				OUTPUT deleted.[User_id] INTO #USER_ID_2B_PROCESSED([User_id])
			END
			ELSE
			BEGIN
				INSERT INTO #USER_ID_2B_PROCESSED([User_id])
				SELECT [Id] FROM [dbo].[USER] WITH (READPAST)
			END
		
			-- get rid of duplicates
			;WITH Q_Dpl AS (
				SELECT
					ROW_NUMBER() OVER(PARTITION BY [User_id] ORDER BY [User_id]) AS RN
					, [User_id]
				FROM
					#USER_ID_2B_PROCESSED
			)
			DELETE Q_Dpl 
			WHERE 
				RN > 1

			-- extraxt data
			SELECT
				u.[Id] 
				, u.[Name]
				, u.[Email_id] 
				, u.[User_status_id] 
				, u.[Last_update] AS [Valid_from]
				, CAST(NULL AS DATETIME) AS [Valid_until] 
			FROM
				#USER_ID_2B_PROCESSED t
				INNER JOIN [dbo].[USER] u ON u.[Id] = t.[User_id] 
			UNION ALL
			SELECT
				u.[User_id] 
				, u.[Name]
				, u.[Email_id] 
				, u.[User_status_id] 
				, u.[Valid_from]
				, u.[Valid_until] 
			FROM
				#USER_ID_2B_PROCESSED t
				INNER JOIN [dbo].[USER_OLD_VERSION] u ON u.[User_id] = t.[User_id] 
		
		IF @tran_count = 0
			COMMIT TRANSACTION		
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
