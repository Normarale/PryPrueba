Public Class Shippers
    Private _ShipperId As Integer
    Private _CompanyName As String
    Private _Phone As String

    Public Property ShipperId As Integer
        Get
            Return _ShipperId
        End Get
        Set(value As Integer)
            _ShipperId = value
        End Set
    End Property

    Public Property CompanyName As String
        Get
            Return _CompanyName
        End Get
        Set(value As String)
            _CompanyName = value
        End Set
    End Property

    Public Property Phone As String
        Get
            Return _Phone
        End Get
        Set(value As String)
            _Phone = value
        End Set
    End Property
End Class
