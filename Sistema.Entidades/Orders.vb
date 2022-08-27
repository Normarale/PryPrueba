Public Class Orders
    Private _IdOrder As Integer
    Private _IdCustomer As String
    Private _IdEmployee As Integer
    Private _OrdeDate As Date
    Private _RequiredDate As Date
    Private _ShippedDate As Date
    Private _ShipVia As Integer
    Private _Freight As Decimal
    Private _ShipName As String
    Private _ShipAdress As String
    Private _ShipCity As String
    Private _ShipRegion As String
    Private _ShipPostalCode As String
    Private _ShipCountry As String

    Public Property IdOrder As Integer
        Get
            Return _IdOrder
        End Get
        Set(value As Integer)
            _IdOrder = value
        End Set
    End Property

    Public Property IdCustomer As String
        Get
            Return _IdCustomer
        End Get
        Set(value As String)
            _IdCustomer = value
        End Set
    End Property

    Public Property IdEmployee As Integer
        Get
            Return _IdEmployee
        End Get
        Set(value As Integer)
            _IdEmployee = value
        End Set
    End Property

    Public Property OrdeDate As Date
        Get
            Return _OrdeDate
        End Get
        Set(value As Date)
            _OrdeDate = value
        End Set
    End Property

    Public Property RequiredDate As Date
        Get
            Return _RequiredDate
        End Get
        Set(value As Date)
            _RequiredDate = value
        End Set
    End Property

    Public Property ShippedDate As Date
        Get
            Return _ShippedDate
        End Get
        Set(value As Date)
            _ShippedDate = value
        End Set
    End Property

    Public Property ShipVia As Integer
        Get
            Return _ShipVia
        End Get
        Set(value As Integer)
            _ShipVia = value
        End Set
    End Property

    Public Property Freight As Decimal
        Get
            Return _Freight
        End Get
        Set(value As Decimal)
            _Freight = value
        End Set
    End Property

    Public Property ShipName As String
        Get
            Return _ShipName
        End Get
        Set(value As String)
            _ShipName = value
        End Set
    End Property

    Public Property ShipAdress As String
        Get
            Return _ShipAdress
        End Get
        Set(value As String)
            _ShipAdress = value
        End Set
    End Property

    Public Property ShipCity As String
        Get
            Return _ShipCity
        End Get
        Set(value As String)
            _ShipCity = value
        End Set
    End Property

    Public Property ShipRegion As String
        Get
            Return _ShipRegion
        End Get
        Set(value As String)
            _ShipRegion = value
        End Set
    End Property

    Public Property ShipPostalCode As String
        Get
            Return _ShipPostalCode
        End Get
        Set(value As String)
            _ShipPostalCode = value
        End Set
    End Property

    Public Property ShipCountry As String
        Get
            Return _ShipCountry
        End Get
        Set(value As String)
            _ShipCountry = value
        End Set
    End Property
End Class
