Module Program

    Sub Main()

        StandardMessages.WelcomeMessage()

        Dim user As Person = PersonDataCapture.Capture()
        Dim isUserValid As Boolean = PersonValidator.Validate(user)

        If Not isUserValid Then

            StandardMessages.EndApplication()
            Environment.Exit(0)

        End If

        AccountGenerator.CreateAccount(user)
        StandardMessages.EndApplication()

    End Sub

End Module
