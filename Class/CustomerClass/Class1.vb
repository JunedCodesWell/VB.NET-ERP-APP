Public Class Customer

    Dim stFirstName As String
    Dim stLastName As String
    Dim dtDateOfBirth As Date
    Dim stGender As String
    Dim stAddress As String

    Public Property FirstName As String
        Set(value As String)
            stFirstName = value
        End Set
        Get
            Return stFirstName
        End Get
    End Property

    Public Property LastName As String
        Set(value As String)
            stLastName = value
        End Set
        Get
            Return stLastName
        End Get
    End Property

    Public Property DateOfBirth As Date
        Set(value As Date)
            If (Year(Now) - Year(value)) Then
                MsgBox(Me.FirstName & " " & Me.LastName & ", the age is less than 18")
                Exit Property
            Else
                dtDateOfBirth = value
            End If
        End Set
        Get
            Return dtDateOfBirth
        End Get
    End Property

    Public Property Gender As String
        Set(value As String)
            stGender = value
        End Set
        Get
            Return stGender
        End Get
    End Property

    Public Property Address As String
        Set(value As String)
            stAddress = value
        End Set
        Get
            Return stAddress
        End Get
    End Property

End Class
