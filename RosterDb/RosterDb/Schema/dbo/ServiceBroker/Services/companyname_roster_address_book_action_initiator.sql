
CREATE SERVICE [//CompanyName/Roster/Address_Book_Action/Initiator] 
   ON QUEUE [dbo].[ADDRESS_BOOK_ACTION_INITIATOR]
   ([//CompanyName/Roster/AddressBookActionContract])
