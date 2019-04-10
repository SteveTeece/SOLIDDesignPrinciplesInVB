Imports DemoLibrary

Public Class Book
    Implements ILibraryItem

    Public Property Author As String Implements ILibraryItem.Author

    Public Property BorrowDate As Date Implements ILibraryItem.BorrowDate

    Public Property Borrower As String Implements ILibraryItem.Borrower

    Public Property CheckOutDurationInDays As Integer = 14 Implements ILibraryItem.CheckOutDurationInDays

    Public Property LibraryID As String Implements ILibraryItem.LibraryID

    Public Property Pages As Integer Implements ILibraryItem.Pages

    Public Property Title As String Implements ILibraryItem.Title

    Public Sub Checkin() Implements ILibraryItem.Checkin
        Borrower = ""
    End Sub

    Public Sub Checkout(b As String) Implements ILibraryItem.Checkout
        Borrower = b
        BorrowDate = DateTime.Now()
    End Sub

    Public Function GetDueDate() As Date Implements ILibraryItem.GetDueDate
        Return BorrowDate.AddDays(CheckOutDurationInDays)
    End Function
End Class
