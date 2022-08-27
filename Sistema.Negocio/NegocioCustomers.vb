Imports Sistema.Datos
Imports Sistema.Entidades

Public Class NegocioCustomers

    Public Function Listar() As DataTable

        Try
            Dim Datos As New DatosCustomers  'instancia
            Dim Tabla As DataTable
            Tabla = Datos.Listar
            Return Tabla
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function Buscar(Valor As String) As DataTable
        Try
            Dim Datos As New DatosCustomers  'instancia
            Dim Tabla As DataTable
            Tabla = Datos.Buscar(Valor)
            Return Tabla
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function



    Public Function Seleccionar() As DataTable

        Try
            Dim Datos As New DatosCustomers  'instancia
            Dim Tabla As DataTable
            Tabla = Datos.Seleccionar()
            Return Tabla
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

End Class
