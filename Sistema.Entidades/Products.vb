
Public Class Products
    Private _ProductID As Integer
    Private _ProductName As String
    Private _SuplierID As Integer
    Private _CategoryId As Integer
    Private _QuantityPerUnit As String
    Private _UnitPrice As Decimal
    Private _UnitsInStock As Integer
    Private _UnitsOnOrder As Integer
    Private _ReorderLevel As Integer
    Private _Discontinued As Boolean

    Public Property ProductID As Integer
        Get
            Return _ProductID
        End Get
        Set(value As Integer)
            _ProductID = value
        End Set
    End Property

    Public Property ProductName As String
        Get
            Return _ProductName
        End Get
        Set(value As String)
            _ProductName = value
        End Set
    End Property

    Public Property SuplierID As Integer
        Get
            Return _SuplierID
        End Get
        Set(value As Integer)
            _SuplierID = value
        End Set
    End Property

    Public Property CategoryId As Integer
        Get
            Return _CategoryId
        End Get
        Set(value As Integer)
            _CategoryId = value
        End Set
    End Property

    Public Property QuantityPerUnit As String
        Get
            Return _QuantityPerUnit
        End Get
        Set(value As String)
            _QuantityPerUnit = value
        End Set
    End Property

    Public Property UnitPrice As Decimal
        Get
            Return _UnitPrice
        End Get
        Set(value As Decimal)
            _UnitPrice = value
        End Set
    End Property

    Public Property UnitsInStock As Integer
        Get
            Return _UnitsInStock
        End Get
        Set(value As Integer)
            _UnitsInStock = value
        End Set
    End Property

    Public Property UnitsOnOrder As Integer
        Get
            Return _UnitsOnOrder
        End Get
        Set(value As Integer)
            _UnitsOnOrder = value
        End Set
    End Property

    Public Property ReorderLevel As Integer
        Get
            Return _ReorderLevel
        End Get
        Set(value As Integer)
            _ReorderLevel = value
        End Set
    End Property

    Public Property Discontinued As Boolean
        Get
            Return _Discontinued
        End Get
        Set(value As Boolean)
            _Discontinued = value
        End Set
    End Property
End Class
