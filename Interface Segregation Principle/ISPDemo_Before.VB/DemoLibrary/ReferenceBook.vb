Public Class ReferenceBook
    Implements ILibraryItem

    Public Property Author As String = "" Implements ILibraryItem.Author

    Public Property BorrowDate As Date Implements ILibraryItem.BorrowDate

    Public Property Borrower As String Implements ILibraryItem.Borrower

    Public Property CheckOutDurationInDays As Integer = 0 Implements ILibraryItem.CheckOutDurationInDays

    Public Property LibraryID As String Implements ILibraryItem.LibraryID

    Public Property Pages As Integer Implements ILibraryItem.Pages

    Public Property Title As String Implements ILibraryItem.Title

    Public Sub Checkin() Implements ILibraryItem.Checkin
        Throw New NotImplementedException
    End Sub

    Public Sub Checkout(b As String) Implements ILibraryItem.Checkout
        Throw New NotImplementedException
    End Sub

    Public Function GetDueDate() As Date Implements ILibraryItem.GetDueDate
        Throw New NotImplementedException
    End Function
End Class
