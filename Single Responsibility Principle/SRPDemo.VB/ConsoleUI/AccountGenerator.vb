Module AccountGenerator

    Public Sub CreateAccount(ByVal user As Person)

        'Create a user name for this person
        Console.WriteLine($"Your username is { user.FirstName.Substring(0, 1) }{ user.LastName }")

    End Sub

End Module
