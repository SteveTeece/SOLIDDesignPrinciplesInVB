Imports DemoLibrary

Module Program

    Sub Main()

        Dim owner As Person = New Person()
        With owner
            .FirstName = "Tim"
            .LastName = "Corey"
            .EmailAddress = "tim@iamtimcorey.com"
            .PhoneNumber = "555-1212"
        End With

        Dim chore As Chore = New Chore()
        With chore
            .ChoreName = "Take out the trash"
            .Owner = owner
        End With

        chore.PerformedWork(3)
        chore.PerformedWork(1.5)
        chore.CompleteChore()

        Console.ReadLine()

    End Sub

End Module
