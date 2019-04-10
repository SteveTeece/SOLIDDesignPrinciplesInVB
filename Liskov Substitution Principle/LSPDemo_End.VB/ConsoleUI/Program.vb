Imports DemoLobrary

Module Program

    Sub Main()

        Dim accountingVP As IManager = New Manager()

        accountingVP.FirstName = "Emma"
        accountingVP.LastName = "Stone"
        accountingVP.CalculatePerHourRate(4)

        Dim emp As IManaged = New Manager()

        emp.FirstName = "Tim"
        emp.LastName = "Corey"
        emp.AssignManager(accountingVP)
        emp.CalculatePerHourRate(2)

        Console.WriteLine($"{ emp.FirstName }'s salary is ${ emp.Salary }/hour.")

        Console.ReadLine()

    End Sub

End Module
