Public Class DigitalMovie
    Implements IBorrowableDVD

    Public Property Actors As List(Of String) Implements IDVD.Actors

    Public Property RunimeInMinutes As Integer Implements IDVD.RunimeInMinutes

    Public Property BorrowDate As Date Implements IBorrowable.BorrowDate

    Public Property Borrower As String Implements IBorrowable.Borrower

    Public Property CheckoutDurationInDays As Integer = 14 Implements IBorrowable.CheckoutDurationInDays

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
