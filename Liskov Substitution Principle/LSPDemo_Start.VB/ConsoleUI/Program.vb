Imports DemoLibrary

Module Program

    Sub Main()

        Dim accountingVP As Manager = New Manager()

        accountingVP.FirstName = "Emma"
        accountingVP.LastName = "Stone"
        accountingVP.CalculatePerHourRate(4)

        Dim emp As Employee = New CEO() ' Note: New CEO - this will violate LSP

        emp.FirstName = "Tim"
        emp.LastName = "Corey"
        ' It is expected that the program will crash executing the next line
        ' because it violates LSP (CEO does not have a manager)
        emp.AssignManager(accountingVP)
        emp.CalculatePerHourRate(2)

        Console.WriteLine($"{emp.FirstName}'s salary is ${emp.Salary}/hour.")
        Console.ReadLine()

    End Sub

End Module
