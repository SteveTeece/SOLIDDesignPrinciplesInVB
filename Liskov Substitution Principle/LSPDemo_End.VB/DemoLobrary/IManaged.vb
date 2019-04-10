Public Interface IManaged
    Inherits IEmployee

    Property Manager As IEmployee

    Sub AssignManager(mgr As IEmployee)

End Interface
