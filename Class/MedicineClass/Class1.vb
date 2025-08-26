Public Class Medicine

    Dim intId As Integer
    Dim stMedicineName As String
    Dim intStockAvlb As Integer
    Dim dcPricePS As Decimal
    Dim intMedUpdateId As Integer
    Dim intMedDeleteId As Integer

    Public Property medId As Integer
        Get
            Return intId
        End Get
        Set(ByVal value As Integer)
            intId = value
        End Set
    End Property

    Public Property medDeleteId As Integer
        Set(ByVal value As Integer)
            intMedDeleteId = value
        End Set
        Get
            Return intMedDeleteId
        End Get
    End Property

    Public Property medUpdateId As Integer
        Set(ByVal value As Integer)
            intMedUpdateId = value
        End Set
        Get
            Return intMedUpdateId
        End Get
    End Property

    Public Property MedicineName As String
        Set(value As String)
            stMedicineName = value
        End Set
        Get
            Return stMedicineName
        End Get
    End Property

    Public Property StockAvailable As Integer
        Set(value As Integer)
            intStockAvlb = value
        End Set
        Get
            Return intStockAvlb
        End Get
    End Property

    Public Property PricePerStrip As Decimal
        Set(value As Decimal)
            dcPricePS = value
        End Set
        Get
            Return dcPricePS
        End Get
    End Property

End Class
