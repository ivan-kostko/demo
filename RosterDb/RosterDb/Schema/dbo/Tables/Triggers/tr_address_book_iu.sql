CREATE TRIGGER [tr_address_book_iu]	ON [dbo].[ADDRESS_BOOK]
FOR INSERT, UPDATE
AS
BEGIN
	INSERT INTO [dw].[ROSTERDW_ADDRESS_BOOK_TRANSFER_CANDIDATE]([Address_book_id])
	SELECT [Id] FROM inserted i WHERE i.[Address_book_status_id] = 1
END
