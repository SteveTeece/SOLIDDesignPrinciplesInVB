Imports OCPLibrary

Module Program

    Sub Main()

        Dim applicants As List(Of IApplicantModel) = New List(Of IApplicantModel)() From
            {
            New PersonModel With {.FirstName = "Tim", .LastName = "Corey"},
            New ManagerModel With {.FirstName = "Sue", .LastName = "Storm"},
            New ExecutiveModel With {.FirstName = "Nancy", .LastName = "Roman"}
            }

        Dim employees As List(Of EmployeeModel) = New List(Of EmployeeModel)

        For Each person As IApplicantModel In applicants
            employees.Add(person.AccountProcessor.Create(person))
        Next

        For Each emp As EmployeeModel In employees
            Console.WriteLine("{0} {1}: {2}, IsManager: {3}, IsExecutive: {4}", emp.FirstName, emp.LastName, emp.EmailAddress, emp.IsManager, emp.IsExecutive)

        Next
        Console.ReadLine()

    End Sub

End Module
