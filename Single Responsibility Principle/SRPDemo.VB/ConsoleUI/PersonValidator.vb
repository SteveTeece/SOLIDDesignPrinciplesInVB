Module PersonValidator


    Public Function Validate(ByVal person As Person) As Boolean

        'Check to ensure the first name and last name are valid

        If String.IsNullOrWhiteSpace(person.FirstName) Then

            StandardMessages.DisplayValidationError("first name")
            Return False

        End If

        If String.IsNullOrWhiteSpace(person.LastName) Then

            StandardMessages.DisplayValidationError("last name")
            Return False

        End If

        Return True

    End Function
End Module
