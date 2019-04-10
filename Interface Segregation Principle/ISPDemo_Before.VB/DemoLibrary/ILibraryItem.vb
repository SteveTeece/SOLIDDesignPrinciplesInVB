Public Interface ILibraryItem

    Property Author As String
    Property BorrowDate As DateTime
    Property Borrower As String
    Property CheckOutDurationInDays As Integer
    Property LibraryID As String
    Property Pages As Integer
    Property Title As String

    Sub Checkin()
    Sub Checkout(borrower As String)
    Function GetDueDate() As DateTime

End Interface
