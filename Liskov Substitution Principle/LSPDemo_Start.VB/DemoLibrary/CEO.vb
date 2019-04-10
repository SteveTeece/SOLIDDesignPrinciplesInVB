

Imports DemoLibrary

Public Class CEO
    Inherits Employee

    Public Overrides Sub CalculatePerHourRate(rank As Integer)

        Dim baseAmount As Decimal = 150D

        Salary = baseAmount * rank

    End Sub

    Public Overrides Sub AssignManager(mgr As Employee)

        Throw New InvalidOperationException("The CEO has no manager.")

    End Sub

    Public Sub GeneratePerformanceReview()

        ' Simulate reviewing a direct report
        Console.WriteLine("I'm reviewing a direct report's performance.")

    End Sub

    Public Sub FireSomeone()

        ' Simulate firing someone
        Console.WriteLine("You're fired!")

    End Sub

End Class
