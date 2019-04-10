
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

Option Strict Off

Public Class Chore
    ' Private backing fields
    Private _hoursWorked As Double
    Private _isComplete As Boolean

    ' Auto-Implemented properties
    Public Property ChoreName As String
    Public Property Owner As Person

    ' Full Property Definitions (these include the backing fields above)
    Public Property HoursWorked
        Get
            Return _hoursWorked
        End Get
        Private Set(value)
            _hoursWorked = value
        End Set
    End Property

    Public Property IsComplete
        Get
            Return _isComplete
        End Get
        Private Set(value)
            _isComplete = value
        End Set
    End Property

    'Public Methods
    Public Sub PerformedWork(hours As Double)

        _hoursWorked += hours   'NOTE: Under normal circumstances, the private variable would not be used here
        Dim log As Logger = New Logger()
        log.Log($"Performed work on {ChoreName}")

    End Sub

    Public Sub CompleteChore()

        IsComplete = True

        Dim log As Logger = New Logger()
        log.Log($"Completed {ChoreName}")

        Dim emailer As Emailer = New Emailer()
        emailer.SendEmail(Owner, $"The chore {ChoreName} is complete")

    End Sub

End Class
