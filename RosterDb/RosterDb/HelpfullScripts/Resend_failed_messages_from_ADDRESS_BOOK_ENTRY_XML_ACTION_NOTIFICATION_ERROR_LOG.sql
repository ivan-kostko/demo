DECLARE @message_table AS TABLE ([Message_body] XML)
DECLARE @message_body_xml XML
WHILE 1=1
BEGIN
	-- the error is logged at a general logging system. So, we could easily delete entries at a queue log
	DELETE TOP (1) [dbo].[ADDRESS_BOOK_ENTRY_XML_ACTION_NOTIFICATION_ERROR_LOG] 
		OUTPUT deleted.[Message_body] INTO @message_table([Message_body])
	WHERE 
		1=1
	
	IF @@ROWCOUNT <= 0
	BEGIN
		BREAK;
	END
	ELSE
	BEGIN
		SELECT @message_body_xml = [Message_body] 
		FROM @message_table

		EXEC [dbo].[companyname_roster_addressbookentryxmlaction_parse_request_message_sender]
			@message_body_xml = @message_body_xml
	END
END