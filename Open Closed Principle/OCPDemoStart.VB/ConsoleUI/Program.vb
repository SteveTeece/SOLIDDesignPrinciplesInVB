Imports OCPLibrary

Module Program

    Sub Main()
        Dim applicants As List(Of PersonModel) = New List(Of PersonModel)() From
            {
            New PersonModel With {.FirstName = "Tim", .LastName = "Corey"},
            New PersonModel With {.FirstName = "Sue", .LastName = "Storm"},
            New PersonModel With {.FirstName = "Nancy", .LastName = "Roman"}
            }

        Dim employees As List(Of EmployeeModel) = New List(Of EmployeeModel)
        Dim accountsprocessor As Accounts = New Accounts()

        For Each person As PersonModel In applicants
            employees.Add(accountsprocessor.Create(person))
        Next

        For Each emp As EmployeeModel In employees
            Console.WriteLine("{0} {1}: {2}, IsManager: {3}, IsExecutive: {4}", emp.FirstName, emp.LastName, emp.EmailAddress, emp.IsManager, emp.IsExecutive)

        Next
        Console.ReadLine()




    End Sub

End Module
