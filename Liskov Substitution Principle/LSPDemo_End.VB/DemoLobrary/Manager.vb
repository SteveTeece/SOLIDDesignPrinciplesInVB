Imports DemoLobrary

Public Class Manager
    Inherits Employee
    Implements IManager

    Public Overrides Sub CalculatePerHourRate(rank As Integer)

        Dim baseAmount As Decimal = 19.75D

        Salary = baseAmount + (rank * 4)

    End Sub

    Public Sub GeneratePerformanceReview() Implements IManager.GeneratePerformanceReview

        ' Simulate reviewing a direct report
        Console.WriteLine("I'm reviewing a direct report's performance.")

    End Sub
End Class
