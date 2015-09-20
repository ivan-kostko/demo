/*
	The view represents "connections" between [Email_id] and users; -- COUNT_BIG(*) AS [Count] just for unqueness
*/

CREATE VIEW [dbo].[V_USER_TO_USER_CONNECTION]
WITH SCHEMABINDING
AS
	SELECT
		abe.[Email_id] AS [Email_id]					-- Email, which has entries in users address books
		, u.[Id]       AS [Connected_with_user_id]		-- [RosterDb].[<schema>].[USER].[Id] identificator of user, who has email entry at his address book
		, u.[Email_id] AS [Connected_with_user_email_id]-- Email identificator of user *see above
		, u.[Name]     AS [Connected_with_user_name]	-- Name  of user *see above
		, COUNT_BIG(*) AS [Count]						-- Just for uniqueness
	FROM
		[dbo].[USER] u
		INNER JOIN [dbo].[ADDRESS_BOOK] ab ON ab.[Id] = u.[User_actual_address_book_id] AND ab.[User_id] = u.[Id]
		INNER JOIN [dbo].[ADDRESS_BOOK_ENTRY] abe ON abe.[Address_book_id] = ab.[Id] 
	GROUP BY
	   abe.[Email_id]
		, u.[Id]
		, u.[Email_id]
		, u.[Name]    
GO

CREATE UNIQUE CLUSTERED INDEX [UC_V_USER_TO_USER_CONNECTION_User_id_Connected_with_user_id] ON [dbo].[V_USER_TO_USER_CONNECTION]([Email_id],[Connected_with_user_id])
