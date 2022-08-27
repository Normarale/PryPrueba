Imports Sistema.Datos
Imports Sistema.Entidades


Public Class NegocioOrders

    Public Function Listar() As DataTable

        Try
            Dim Datos As New DatosOrders  'instancia
            Dim Tabla As DataTable
            Tabla = Datos.Listar()
            Return Tabla
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function Buscar(Valor As String) As DataTable
        Try
            Dim Datos As New DatosOrders  'instancia
            Dim Tabla As DataTable
            Tabla = Datos.Buscar(Valor)
            Return Tabla
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function BuscarEntreFechas(FechaInicio As Date, FechaFin As Date) As DataTable
        Try
            Dim Datos As New DatosOrders  'instancia
            Dim Tabla As DataTable
            Tabla = Datos.BuscarEntreFechas(FechaInicio, FechaFin)
            Return Tabla
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function


    Public Function BuscarCustomers(Valor As String) As DataTable
        Try
            Dim Datos As New DatosOrders  'instancia
            Dim Tabla As DataTable
            Tabla = Datos.BuscarCustomers(Valor)
            Return Tabla
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function BuscarEmployees(Valor As Integer) As DataTable
        Try
            Dim Datos As New DatosOrders  'instancia
            Dim Tabla As DataTable
            Tabla = Datos.BuscarEmployees(Valor)
            Return Tabla
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function ListarDetalle(Id As Integer) As DataTable
        Try
            Dim Datos As New DatosOrders 'instancia
            Dim Tabla As DataTable
            Tabla = Datos.ListarDetalle(Id)
            Return Tabla
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function


    Public Function Insertar(Obj As Orders, Det As DataTable) As Boolean
        Try
            Dim Datos As New DatosOrders
            Datos.Insertar(Obj, Det)
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function


    Public Function Actualizar(Obj As Orders) As Boolean
        Try
            Dim Datos As New DatosOrders
            Datos.Actualizar(Obj)
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function


    Public Function Anular(Id As Integer) As Boolean
        Try
            Dim Datos As New DatosOrders
            Datos.Anular(Id)
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Public Function Eliminar(Id As Integer) As Boolean
        Try
            Dim Datos As New DatosOrders
            Datos.Eliminar(Id)
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

End Class
