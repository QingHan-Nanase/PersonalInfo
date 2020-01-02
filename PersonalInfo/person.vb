Public Class person
    Private username As String
    Private password As String

    Public Sub New(username As String, password As String)
        Me.Username1 = username
        Me.Password1 = password
    End Sub

    Public Property Username1 As String
        Get
            Return username
        End Get
        Set(value As String)
            username = value
        End Set
    End Property

    Public Property Password1 As String
        Get
            Return password
        End Get
        Set(value As String)
            password = value
        End Set
    End Property
End Class
