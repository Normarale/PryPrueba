Public Class Employees

    Private _EmployeeId As Integer
    Private _LastName As String
    Private _FirstName As String
    Private _Title As String
    Private _TitleOfcourtesy As String
    Private _BrthDate As Date
    Private _HreDate As Date
    Private _Address As String
    Private _City As String
    Private _Region As String
    Private _PostalCode As String
    Private _Country As String
    Private _HomePhone As String
    Private _Extension As String
    Private _Photo As Byte
    Private _Notes As String
    Private _Reports As Integer
    Private _PhotoPath As String

    Public Property EmployeeId As Integer
        Get
            Return _EmployeeId
        End Get
        Set(value As Integer)
            _EmployeeId = value
        End Set
    End Property

    Public Property LastName As String
        Get
            Return _LastName
        End Get
        Set(value As String)
            _LastName = value
        End Set
    End Property

    Public Property FirstName As String
        Get
            Return _FirstName
        End Get
        Set(value As String)
            _FirstName = value
        End Set
    End Property

    Public Property Title As String
        Get
            Return _Title
        End Get
        Set(value As String)
            _Title = value
        End Set
    End Property

    Public Property TitleOfcourtesy As String
        Get
            Return _TitleOfcourtesy
        End Get
        Set(value As String)
            _TitleOfcourtesy = value
        End Set
    End Property

    Public Property BrthDate As Date
        Get
            Return _BrthDate
        End Get
        Set(value As Date)
            _BrthDate = value
        End Set
    End Property

    Public Property HreDate As Date
        Get
            Return _HreDate
        End Get
        Set(value As Date)
            _HreDate = value
        End Set
    End Property

    Public Property Address As String
        Get
            Return _Address
        End Get
        Set(value As String)
            _Address = value
        End Set
    End Property

    Public Property City As String
        Get
            Return _City
        End Get
        Set(value As String)
            _City = value
        End Set
    End Property

    Public Property Region As String
        Get
            Return _Region
        End Get
        Set(value As String)
            _Region = value
        End Set
    End Property

    Public Property PostalCode As String
        Get
            Return _PostalCode
        End Get
        Set(value As String)
            _PostalCode = value
        End Set
    End Property

    Public Property Country As String
        Get
            Return _Country
        End Get
        Set(value As String)
            _Country = value
        End Set
    End Property

    Public Property HomePhone As String
        Get
            Return _HomePhone
        End Get
        Set(value As String)
            _HomePhone = value
        End Set
    End Property

    Public Property Extension As String
        Get
            Return _Extension
        End Get
        Set(value As String)
            _Extension = value
        End Set
    End Property

    Public Property Photo As Byte
        Get
            Return _Photo
        End Get
        Set(value As Byte)
            _Photo = value
        End Set
    End Property

    Public Property Notes As String
        Get
            Return _Notes
        End Get
        Set(value As String)
            _Notes = value
        End Set
    End Property

    Public Property Reports As Integer
        Get
            Return _Reports
        End Get
        Set(value As Integer)
            _Reports = value
        End Set
    End Property

    Public Property PhotoPath As String
        Get
            Return _PhotoPath
        End Get
        Set(value As String)
            _PhotoPath = value
        End Set
    End Property
End Class
