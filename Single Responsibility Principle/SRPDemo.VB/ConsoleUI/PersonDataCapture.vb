Module PersonDataCapture

    Public Function Capture() As Person

        'Ask for user information
        Dim output As Person = New Person

        Console.Write("What is your First name? ")
        output.FirstName = Console.ReadLine()

        Console.Write("What is your Last name? ")
        output.LastName = Console.ReadLine()

        Return output

    End Function

End Module
