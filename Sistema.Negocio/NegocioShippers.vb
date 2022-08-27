Imports Sistema.Datos
Imports Sistema.Entidades

Public Class NegocioShippers
    Public Function Seleccionar() As DataTable

        Try
            Dim Datos As New DatosShippers  'instancia
            Dim Tabla As DataTable
            Tabla = Datos.Seleccionar()
            Return Tabla
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
End Class
