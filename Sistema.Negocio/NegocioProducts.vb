Imports Sistema.Datos
Imports Sistema.Entidades



Public Class NegocioProducts

    Public Function BuscarProducts(Valor As Integer) As Products
        Try
            Dim Datos As New DatosProducts  'instancia
            Dim Tabla As DataTable
            Dim Art As New Products
            Tabla = Datos.BuscarProducts(Valor)
            If (Tabla.Rows.Count > 0) Then
                Art.ProductID = Tabla.Rows(0).Item(0).ToString
                Art.ProductName = Tabla.Rows(0).Item(1).ToString
                Art.UnitPrice = Tabla.Rows(0).Item(2).ToString
                Art.UnitsInStock = Tabla.Rows(0).Item(3).ToString
                Return Art
            Else
                Return Nothing
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function BuscarProductsManual(Valor As String) As DataTable
        Try
            Dim Datos As New DatosProducts  'instancia
            Dim Tabla As DataTable
            Tabla = Datos.BuscarProductsManual(Valor)
            Return Tabla
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function




End Class
