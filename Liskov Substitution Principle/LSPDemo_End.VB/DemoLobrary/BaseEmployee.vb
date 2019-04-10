Imports DemoLobrary

Public Class BaseEmployee
    Implements IEmployee

    Public Property FirstName As String Implements IEmployee.FirstName
    Public Property LastName As String Implements IEmployee.LastName
    Public Property Salary As Decimal Implements IEmployee.Salary

    Public Overridable Sub CalculatePerHourRate(rank As Integer) Implements IEmployee.CalculatePerHourRate

        Dim baseAmount As Decimal = 12.5D
        Salary = baseAmount + (rank * 2)

    End Sub
End Class
