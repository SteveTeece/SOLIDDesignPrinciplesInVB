Imports OCPLibrary

Public Class ManagerAccounts
    Implements IAccounts

    Public Function Create(person As IApplicantModel) As EmployeeModel Implements IAccounts.Create

        Dim output As EmployeeModel = New EmployeeModel()

        output.FirstName = person.FirstName
        output.LastName = person.LastName
        output.EmailAddress = person.FirstName.Substring(0, 1) + person.LastName + "@acmecorp.com"

        output.IsManager = True

        Return output

    End Function
End Class
