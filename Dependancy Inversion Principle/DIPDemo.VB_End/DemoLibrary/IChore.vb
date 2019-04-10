Public Interface IChore

    Property ChoreName As String
    Property HoursWorked As Double
    Property IsComplete As Boolean
    Property Owner As IPerson

    Sub CompleteChore()
    Sub PerformedWork(hours As Double)

End Interface
