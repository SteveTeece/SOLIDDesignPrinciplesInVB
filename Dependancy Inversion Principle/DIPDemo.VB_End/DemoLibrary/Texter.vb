Imports DemoLibrary

Public Class Texter
    Implements IMessageSender

    Public Sub SendMessage(person As IPerson, message As String) Implements IMessageSender.SendMessage

        Console.WriteLine($"I am texting {person.FirstName} to say {message}")

    End Sub
End Class
