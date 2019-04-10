Imports DemoLibrary

Public Class Emailer
    Implements IMessageSender

    Public Sub SendMessage(person As IPerson, message As String) Implements IMessageSender.SendMessage

        Console.WriteLine($"Simulating sending an email to { person.EmailAddress }")

    End Sub
End Class
