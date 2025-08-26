Public Class Customer

    Dim intId As Integer
    Dim intUpdateId As Integer
    Dim intDeleteId As Integer
    Dim stFirstName As String
    Dim stLastName As String
    Dim dtDateOfBirth As Date
    Dim stGender As String
    Dim stAddress As String

    'Public Property EnableValidation As Boolean
    'Public Sub New(FirstName As String, LastName As String, DateOfBirth As Date, Gender As String)

    'Me.FirstName = FirstName
    'Me.LastName = LastName
    'Me.DateOfBirth = DateOfBirth
    'Me.Gender = Gender

    'End Sub

    Public Property Id As Integer
        Get
            Return intId
        End Get
        Set(ByVal value As Integer)
            intId = value
        End Set
    End Property

    Public Property UpdateId As Integer
        Set(ByVal value As Integer)
            intUpdateId = value
        End Set
        Get
            Return intUpdateId
        End Get
    End Property

    Public Property DeleteId As Integer
        Set(ByVal value As Integer)
            intDeleteId = value
        End Set
        Get
            Return intDeleteId
        End Get
    End Property

    Public Property FirstName As String
        Set(value As String)
            If value Is Nothing Then
                MsgBox("Names cannot be Empty")
            ElseIf value.Any(Function(c) Char.IsDigit(c)) Then
                MsgBox("Numbers are not allowed as Names")

            ElseIf value.Any(Function(c) Not Char.IsLetter(c) AndAlso Not Char.IsWhiteSpace(c)) Then
                MsgBox("Please Enter only Alphabets")

            ElseIf value.Count(Function(c) c = " "c) > 3 Then
                MsgBox("Invalid Entry")

            ElseIf value.Count(Function(c) Char.IsLetter(c)) > 20 Then
                MsgBox("You cannot enter more than 20 letters")
            Else
                stFirstName = value
            End If
        End Set
        Get
            Return stFirstName
        End Get
    End Property

    Public Property LastName As String
        Set(value As String)
            If value Is Nothing Then
                MsgBox("Names cannot be Empty")
            ElseIf value.Any(Function(c) Char.IsDigit(c)) Then
                MsgBox("Numbers are not allowed as Names.")

            ElseIf value.Any(Function(c) Not Char.IsLetter(c) AndAlso Not Char.IsWhiteSpace(c)) Then
                MsgBox("Please Enter only Alphabets")

            ElseIf value.Count(Function(c) c = " "c) > 3 Then
                MsgBox("Invalid Entry")

            ElseIf value.Count(Function(c) Char.IsLetter(c)) > 20 Then
                MsgBox("You cannot enter more than 20 letters")
            Else
                stLastName = value
            End If
        End Set
        Get
            Return stLastName
        End Get
    End Property

    Public Property DateOfBirth As Date
        Set(value As Date)
            If (Year(Now) - Year(value)) < 18 Then
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
            If value.Length > 200 Then
                MsgBox("You cannot enter more than 200 characters.")
            End If
            stAddress = value
        End Set
        Get
            Return stAddress
        End Get
    End Property

End Class
