Public Class diary
    Private data As Date
    Private contextpath As String

    Public Sub New(data As Date, contextpath As String)
        Me.Data1 = data
        Me.Contextpath1 = contextpath
    End Sub

    Public Property Data1 As Date
        Get
            Return data
        End Get
        Set(value As Date)
            data = value
        End Set
    End Property

    Public Property Contextpath1 As String
        Get
            Return contextpath
        End Get
        Set(value As String)
            contextpath = value
        End Set
    End Property
End Class
