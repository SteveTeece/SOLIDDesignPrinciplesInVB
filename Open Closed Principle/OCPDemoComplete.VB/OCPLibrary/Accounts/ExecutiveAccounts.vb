Imports OCPLibrary

Public Class ExecutiveAccounts
    Implements IAccounts

    Public Function Create(person As IApplicantModel) As EmployeeModel Implements IAccounts.Create

        Dim output As EmployeeModel = New EmployeeModel()

        output.FirstName = person.FirstName
        output.LastName = person.LastName
        output.EmailAddress = person.FirstName + "." + person.LastName + "@acmecorp.com"

        output.IsManager = True
        output.IsExecutive = True

        Return output

    End Function
End Class
