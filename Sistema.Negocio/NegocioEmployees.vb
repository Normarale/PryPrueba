Imports Sistema.Entidades
Imports Sistema.Datos



Public Class NegocioEmployees
    Public Function Seleccionar() As DataTable

        Try
            Dim Datos As New DatosEmployees  'instancia
            Dim Tabla As DataTable
            Tabla = Datos.Seleccionar()
            Return Tabla
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
End Class
