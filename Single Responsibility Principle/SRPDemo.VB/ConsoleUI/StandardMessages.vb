Module StandardMessages

    Public Sub WelcomeMessage()

        Console.WriteLine("Welcome to my application!")

    End Sub

    Public Sub EndApplication()

        Console.Write("Press enter to close...")
        Console.ReadLine()

    End Sub

    Public Sub DisplayValidationError(ByVal fieldName As String)

        Console.WriteLine($"You did not give us a valid {fieldName}!")

    End Sub

End Module
