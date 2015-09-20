
CREATE QUEUE [dbo].[ADDRESS_BOOK_ENTRY_XML_ACTION_TARGET]
	WITH	STATUS = ON
			, RETENTION = ON
			, ACTIVATION (
							STATUS = ON, 
							PROCEDURE_NAME = [dbo].[address_book_entry_xml_action_target_queue_handler],
							MAX_QUEUE_READERS = 4,
							EXECUTE AS OWNER 
						 )
	ON [DEFAULT]
    