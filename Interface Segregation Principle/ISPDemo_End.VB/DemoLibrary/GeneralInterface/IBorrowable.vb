Public Interface IBorrowable

    Property BorrowDate As DateTime
    Property Borrower As String
    Property CheckoutDurationInDays As Integer

    Sub Checkin()
    Sub CheckOut(b As String)
    Function GetDueDate() As DateTime


End Interface
