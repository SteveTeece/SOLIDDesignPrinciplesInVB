Imports DemoLibrary

Public Class ReferenceBook
    Implements IBook

    Public Property Author As String Implements IBook.Author

    Public Property Pages As Integer Implements IBook.Pages

    Public Property LibraryID As String Implements ILibraryItem.LibraryID

    Public Property Title As String Implements ILibraryItem.Title

End Class
