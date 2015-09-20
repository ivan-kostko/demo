/*
	the procedure retreives address book entry data for ETL processing by RosterDbToDW
*/
CREATE PROCEDURE [dbo].[get_rosterdw_address_book_data]
	@is_incremental	BIT = 0 -- if 0 retreives all; 1 - only incremental update
AS
BEGIN
	
	DECLARE @tran_count						INT = @@TRANCOUNT		-- initial number of transactions
			, @destination					NVARCHAR(255) = N'RosterDW'
			, @package						NVARCHAR(255) = N'RosterDbToDW'
			, @source						NVARCHAR(255) = N'Address_book_entry_email'
	
	BEGIN TRY

		IF OBJECT_ID('tempdb..#ADDRESS_BOOK_ID_2B_PROCESSED') IS NOT NULL
			EXEC('DROP TABLE #ADDRESS_BOOK_ID_2B_PROCESSED')

		CREATE TABLE #ADDRESS_BOOK_ID_2B_PROCESSED( [Address_book_id] INT)

		-- get min id
		IF @is_incremental = 0
		BEGIN
			INSERT INTO [dw].[ROSTERDW_ADDRESS_BOOK_TRANSFER_CANDIDATE]([Address_book_id])
			SELECT [Id] FROM [dbo].[ADDRESS_BOOK] ab WITH(READPAST) WHERE ab.[Address_book_status_id] = 1
		END

		-- if there is no transaction opened yet - open a new one. Otherwise, if there is/are - no need to increase @@TRANCOUNT
		IF @tran_count = 0
			BEGIN TRANSACTION

			-- get list of address books to be processed
			DELETE [dw].[ROSTERDW_ADDRESS_BOOK_TRANSFER_CANDIDATE]
			OUTPUT deleted.[Address_book_id] INTO #ADDRESS_BOOK_ID_2B_PROCESSED([Address_book_id]) 
			WHERE
				[Entries_are_transfered] = 1
			
			-- get rid of duplicates
			;WITH Q_Dpl AS (
				SELECT
					ROW_NUMBER() OVER(PARTITION BY [Address_book_id] ORDER BY [Address_book_id]) AS RN
					, [Address_book_id]
				FROM
					#ADDRESS_BOOK_ID_2B_PROCESSED 
			)
			DELETE Q_Dpl
			WHERE
				RN > 1

			-- extraxt data
			SELECT
				ab.[Id]
				, ab.[User_id] 
				, ab.[Valid_from] 
				, ab.[Valid_until] 
			FROM
				#ADDRESS_BOOK_ID_2B_PROCESSED t
				INNER JOIN [dbo].[ADDRESS_BOOK] ab ON ab.[Id] = t.[Address_book_id] 

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
