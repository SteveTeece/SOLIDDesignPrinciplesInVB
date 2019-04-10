Public Class Accounts

    Public Function Create(person As PersonModel) As EmployeeModel

        Dim output As EmployeeModel = New EmployeeModel()

        output.FirstName = person.FirstName
        output.LastName = person.LastName
        output.EmailAddress = person.FirstName.Substring(0, 1) + output.LastName + "@acme.com"

        Return output

    End Function


End Class
