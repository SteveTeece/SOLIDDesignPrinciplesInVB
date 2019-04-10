Imports OCPLibrary

Public Class ManagerModel
    Implements IApplicantModel

    Public Property FirstName As String Implements IApplicantModel.FirstName
    Public Property LastName As String Implements IApplicantModel.LastName

    Public Property AccountProcessor As IAccounts = New ManagerAccounts() Implements IApplicantModel.AccountProcessor

End Class
