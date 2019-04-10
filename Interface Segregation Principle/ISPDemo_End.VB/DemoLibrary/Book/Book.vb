Imports DemoLibrary

Public Class Book
    Implements IBorrowableBook

    Public Property BorrowDate As Date Implements IBorrowable.BorrowDate

    Public Property Borrower As String Implements IBorrowable.Borrower

    Public Property CheckoutDurationInDays As Integer = 14 Implements IBorrowable.CheckoutDurationInDays

    Public Property Author As String Implements IBook.Author

    Public Property Pages As Integer Implements IBook.Pages

    Public Property LibraryID As String Implements ILibraryItem.LibraryID

    Public Property Title As String Implements ILibraryItem.Title

    Public Sub Checkin() Implements IBorrowable.Checkin
        Borrower = ""
    End Sub

    Public Sub CheckOut(b As String) Implements IBorrowable.CheckOut
        Borrower = b
        BorrowDate = DateTime.Now
    End Sub

    Public Function GetDueDate() As Date Implements IBorrowable.GetDueDate
        Return BorrowDate.AddDays(CheckoutDurationInDays)
    End Function
End Class
