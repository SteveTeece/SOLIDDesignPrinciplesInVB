

Public Class Employee

    'Auto implimented Properties
    Public Property FirstName As String
    Public Property LastName As String
    Public Property Manager As Employee = Nothing
    Public Property Salary As Decimal

    'Note: Code changed from original c#, because in VB "Manager" and "manager" are the same
    ' ie, VB is not cast sensitive, where c# is. Therefore, parameter 'manager' in the 
    ' original c# method has been changed to 'mgr' in the VB translation.
    '
    ' "Overridable" keyword in VB is the equivalent of the c# "virtual" keyword
    ' For those watching the C# video, 'void' in c# simply means teh method
    ' does not return a value.
    Public Overridable Sub AssignManager(mgr As Employee)

        ' Simulate doing other tasks here - otherwise this should be
        ' a Property Set statement, not a method.
        Manager = mgr

    End Sub

    Public Overridable Sub CalculatePerHourRate(rank As Integer)

        ' in the original c# code, the value of baseAmount has a trailing M
        ' (decimal baseAmount = 12.50M;). This makes the value of the decimal a 
        ' 'literal value'. The VB equivalent of 'M' is "D"
        Dim baseAmount As Decimal = 12.5D

        Salary = baseAmount + (rank * 2)

    End Sub


End Class
