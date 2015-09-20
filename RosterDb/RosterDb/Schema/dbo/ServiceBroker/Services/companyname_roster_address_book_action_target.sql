
CREATE SERVICE [//CompanyName/Roster/Address_Book_Action/Target] 
   ON QUEUE [dbo].[ADDRESS_BOOK_ACTION_TARGET]
   ([//CompanyName/Roster/AddressBookActionContract])
