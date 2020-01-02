Public Class address
    Private name As String
    Private tel As String
    Private email As String
    Private adr As String

    Public Sub New(name As String, tel As String, email As String, adr As String)
        Me.Name1 = name
        Me.Tel1 = tel
        Me.Email1 = email
        Me.Adr1 = adr
    End Sub

    Public Property Name1 As String
        Get
            Return name
        End Get
        Set(value As String)
            name = value
        End Set
    End Property

    Public Property Tel1 As String
        Get
            Return tel
        End Get
        Set(value As String)
            tel = value
        End Set
    End Property

    Public Property Email1 As String
        Get
            Return email
        End Get
        Set(value As String)
            email = value
        End Set
    End Property

    Public Property Adr1 As String
        Get
            Return adr
        End Get
        Set(value As String)
            adr = value
        End Set
    End Property
End Class
