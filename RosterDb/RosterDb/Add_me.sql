
DECLARE @RC AS INT
		, @user_name AS NVARCHAR (255) = N'ivan.kostko'
		, @user_email AS NVARCHAR (320) = N'kostko_i@yahoo.com'
		, @address_book_xml AS XML(CONTENT [dbo].[AddressBookEntrySchemaCollection])
		, @save_address_book_async AS BIT = 0

;WITH Q_Emails AS (
	SELECT N'kostko_i@yahoo.com' AS [Email] UNION ALL
	SELECT N'ivan.kostko@gmail.com'
)
SELECT @address_book_xml = (
	SELECT		
		(SELECT
			*
		FROM
			Q_Emails
		FOR XML RAW, TYPE
	   ) AS address_book_entry   
	FOR XML PATH(''), ELEMENTS)

EXECUTE @RC = [dbo].[register_user_contact_list] @user_name, @user_email, @address_book_xml, @save_address_book_async;
