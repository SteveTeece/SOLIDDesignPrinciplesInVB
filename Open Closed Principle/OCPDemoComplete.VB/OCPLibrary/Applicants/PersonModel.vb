Imports OCPLibrary

Public Class PersonModel
    Implements IApplicantModel

    Public Property FirstName As String Implements IApplicantModel.FirstName
    Public Property LastName As String Implements IApplicantModel.LastName

    Public Property AccountProcessor As IAccounts = New Accounts() Implements IApplicantModel.AccountProcessor

End Class
