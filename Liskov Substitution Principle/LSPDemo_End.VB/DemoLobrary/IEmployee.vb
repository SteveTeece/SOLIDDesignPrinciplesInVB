Public Interface IEmployee

    Property FirstName As String
    Property LastName As String
    Property Salary As Decimal

    Sub CalculatePerHourRate(rank As Integer)

End Interface
