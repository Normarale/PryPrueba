Public Class Categories
    Private _CategoryID As Integer
    Private _CategoryName As String
    Private _Description As String
    Private _Picture As Byte

    Public Property CategoryID As Integer
        Get
            Return _CategoryID
        End Get
        Set(value As Integer)
            _CategoryID = value
        End Set
    End Property

    Public Property CategoryName As String
        Get
            Return _CategoryName
        End Get
        Set(value As String)
            _CategoryName = value
        End Set
    End Property

    Public Property Description As String
        Get
            Return _Description
        End Get
        Set(value As String)
            _Description = value
        End Set
    End Property

    Public Property Picture As Byte
        Get
            Return _Picture
        End Get
        Set(value As Byte)
            _Picture = value
        End Set
    End Property
End Class
