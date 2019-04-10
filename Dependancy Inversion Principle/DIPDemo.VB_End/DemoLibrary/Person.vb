Public Class Person
    Implements IPerson

    Public Property FirstName As String Implements IPerson.FirstName
    Public Property LastName As String Implements IPerson.LastName
    Public Property PhoneNumber As String Implements IPerson.PhoneNumber
    Public Property EmailAddress As String Implements IPerson.EmailAddress
End Class
