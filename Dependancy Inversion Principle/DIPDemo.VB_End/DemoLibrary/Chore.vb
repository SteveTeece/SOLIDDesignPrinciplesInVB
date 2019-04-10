Option Strict Off
Imports DemoLibrary

' NOTE:
' Theis class uses Full Property declarations for the HoursWorked and 
' IsComplete properties, while the others use auto-implemented properties.
'
' The reason for this is Visual Basig does not support different accessability
' levels for a single property (ie, Public Get and Private Set).
'
' The Private Set says the only way this property can be changed is from within
' this (the Chore) class.

' I have also had to include the compiler directive "Option Strict Off" to avoid
' an error relating to late binding and properties with a public Get but private Set


Public Class Chore
    Implements IChore

    Private _hoursWorked As Double
    Private _isComplete As Boolean
    Private _logger As ILogger
    Private _messageSender As IMessageSender

    Public Property ChoreName As String Implements IChore.ChoreName

    Public Property HoursWorked As Double Implements IChore.HoursWorked
        Get
            Return _hoursWorked
        End Get
        Set(value As Double)
            _hoursWorked = value
        End Set
    End Property

    Public Property IsComplete As Boolean Implements IChore.IsComplete
        Get
            Return _isComplete
        End Get
        Set(value As Boolean)
            _isComplete = value
        End Set
    End Property

    Public Property Owner As IPerson Implements IChore.Owner


    'In VB, this is how to create what C# calls a constructor
    ' The original C# code starts the line with "Public Chore"
    Public Sub New(lgr As ILogger, message As IMessageSender) ' NOTE: Due to VB case insensitivity, I needed to change "logger" to "lgr" in this line
        _logger = lgr
        _messageSender = message

    End Sub

    Public Sub CompleteChore() Implements IChore.CompleteChore

        IsComplete = True


        _logger.Log($"Completed {ChoreName}")

        _messageSender.SendMessage(Owner, $"The chore {ChoreName} is complete")

    End Sub

    Public Sub PerformedWork(hours As Double) Implements IChore.PerformedWork

        _hoursWorked += hours   'NOTE: Under normal circumstances, the private variable would not be used here
        _logger.Log($"Performed work on {ChoreName}")

    End Sub
End Class
