Imports DemoLibrary

Public Class Factory

    Public Shared Function CreatePerson() As IPerson
        Return New Person()
    End Function

    Public Shared Function CreateChore() As IChore
        Return New Chore(CreateLogger(), CreateMessageSender())
    End Function

    Public Shared Function CreateLogger() As ILogger
        Return New Logger()
    End Function

    Public Shared Function CreateMessageSender() As IMessageSender
        Return New Texter()
    End Function

End Class
