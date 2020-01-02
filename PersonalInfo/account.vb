Public Class account
    Private item As String
    Private amount As String
    Private kind As String
    Private consumptionDate As String

    Public Sub New(item As String, amount As String, kind As String, consumptionDate As String)
        Me.item = item
        Me.amount = amount
        Me.kind = kind
        Me.consumptionDate = consumptionDate
    End Sub

    Public Property Item1 As String
        Get
            Return item
        End Get
        Set(value As String)
            item = value
        End Set
    End Property

    Public Property Amount1 As String
        Get
            Return amount
        End Get
        Set(value As String)
            amount = value
        End Set
    End Property

    Public Property ConsumptionDate1 As String
        Get
            Return consumptionDate
        End Get
        Set(value As String)
            consumptionDate = value
        End Set
    End Property

    Public Property Kind1 As String
        Get
            Return kind
        End Get
        Set(value As String)
            kind = value
        End Set
    End Property
End Class
