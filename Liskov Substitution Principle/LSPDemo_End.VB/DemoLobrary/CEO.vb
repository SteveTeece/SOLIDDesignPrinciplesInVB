Imports DemoLobrary

Public Class CEO
    Inherits BaseEmployee
    Implements IManager

    Public Sub GeneratePerformanceReview() Implements IManager.GeneratePerformanceReview

        ' Simulate reviewing a direct report
        Console.WriteLine("I'm reviewing a direct report's performance.")

    End Sub

    Public Sub FireSomeone()

        ' Simulate firing someone
        Console.WriteLine("You're Fired!")

    End Sub
End Class
