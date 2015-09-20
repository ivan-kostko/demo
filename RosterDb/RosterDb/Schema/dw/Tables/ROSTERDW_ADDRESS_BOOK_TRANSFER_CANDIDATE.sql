/*
	The table stores address books which have recent changes and should be processed into warehouse
*/
CREATE TABLE [dw].[ROSTERDW_ADDRESS_BOOK_TRANSFER_CANDIDATE]
(
	[Address_book_id]			INT NOT NULL
	, [Entries_are_transfered]	BIT NOT NULL CONSTRAINT [DF_ROSTERDW_ADDRESS_BOOK_TRANSFER_CANDIDATE_Entries_are_transfered] DEFAULT ((0))
)
