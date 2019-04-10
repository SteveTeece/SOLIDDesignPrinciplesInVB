Imports DemoLibrary

Public Class Logger
    Implements ILogger

    Public Sub Log(message As String) Implements ILogger.Log

        Console.WriteLine($"Write to Console: { message }")

    End Sub
End Class
