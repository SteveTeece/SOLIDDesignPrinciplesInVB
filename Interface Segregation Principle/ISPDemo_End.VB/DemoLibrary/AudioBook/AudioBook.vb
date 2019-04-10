Imports DemoLibrary

Public Class AudioBook
    Implements IBorrowableAudioBook

    Public Property RunTimeInMinutes As Integer Implements IAudioBook.RunTimeInMinutes

    Public Property LibraryID As String Implements ILibraryItem.LibraryID

    Public Property Title As String Implements ILibraryItem.Title

    Public Property BorrowDate As Date Implements IBorrowable.BorrowDate

    Public Property Borrower As String Implements IBorrowable.Borrower

    Public Property CheckoutDurationInDays As Integer = 14 Implements IBorrowable.CheckoutDurationInDays

    Public Sub Checkin() Implements IBorrowable.Checkin
        Borrower = ""
    End Sub

    Public Sub CheckOut(b As String) Implements IBorrowable.CheckOut
        Borrower = Borrower
        BorrowDate = DateTime.Now
    End Sub

    Public Function GetDueDate() As Date Implements IBorrowable.GetDueDate
        Return BorrowDate.AddDays(CheckoutDurationInDays)
    End Function
End Class
