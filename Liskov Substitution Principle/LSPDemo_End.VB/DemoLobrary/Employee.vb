Imports DemoLobrary

Public Class Employee
    Inherits BaseEmployee
    Implements IManaged

    Public Property Manager As IEmployee Implements IManaged.Manager

    Public Sub AssignManager(mgr As IEmployee) Implements IManaged.AssignManager

        ' Simulate doing other tasks here - otherwise this should be
        ' a property set statement, not a method
        Manager = mgr

    End Sub
End Class
