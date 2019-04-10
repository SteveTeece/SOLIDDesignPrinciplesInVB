Imports OCPLibrary

Public Class ExecutiveModel
    Implements IApplicantModel

    Public Property FirstName As String Implements IApplicantModel.FirstName
    Public Property LastName As String Implements IApplicantModel.LastName

    Public Property AccountProcessor As IAccounts = New ExecutiveAccounts() Implements IApplicantModel.AccountProcessor

End Class
