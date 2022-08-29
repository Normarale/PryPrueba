Imports Sistema.Entidades
Imports System.Data.SqlClient

Public Class DatosOrders
    Inherits Conexion 'heredamos la conexión

    Public Function Listar() As DataTable

        Try
            Dim Resultado As SqlDataReader
            Dim Tabla As New DataTable
            Dim cmd As New SqlCommand("Orders_listar", MyBase.conn)
            cmd.CommandType = CommandType.StoredProcedure
            MyBase.conn.Open()
            Resultado = cmd.ExecuteReader
            Tabla.Load(Resultado)
            MyBase.conn.Close()
            Return Tabla
        Catch ex As Exception
            Throw ex
            ex.StackTrace.Substring(ex.StackTrace.IndexOf("line"))
        End Try
    End Function

    Public Function Buscar(Valor As String) As DataTable

        Try
            Dim Resultado As SqlDataReader
            Dim Tabla As New DataTable
            Dim cmd As New SqlCommand("Orders_buscar", MyBase.conn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@Valor", SqlDbType.VarChar).Value = Valor 'cadena que se pasa para buscar
            MyBase.conn.Open()
            Resultado = cmd.ExecuteReader
            Tabla.Load(Resultado)
            MyBase.conn.Close()
            Return Tabla
        Catch ex As Exception
            Throw ex
        End Try
    End Function


    Public Function BuscarEntreFechas(FechaInicio As Date, FechaFin As Date) As DataTable

        Try
            Dim Resultado As SqlDataReader
            Dim Tabla As New DataTable
            Dim cmd As New SqlCommand("Orders_consulta_fechas", MyBase.conn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@fecha_inicio", SqlDbType.Date).Value = FechaInicio
            cmd.Parameters.Add("@fecha_fin", SqlDbType.Date).Value = FechaFin
            MyBase.conn.Open()
            Resultado = cmd.ExecuteReader
            Tabla.Load(Resultado)
            MyBase.conn.Close()
            Return Tabla

        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function BuscarCustomers(Valor As String) As DataTable

        Try
            Dim Resultado As SqlDataReader
            Dim Tabla As New DataTable
            Dim cmd As New SqlCommand("Orders_consulta_Customers", MyBase.conn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@valor", SqlDbType.VarChar).Value = Valor
            MyBase.conn.Open()
            Resultado = cmd.ExecuteReader
            Tabla.Load(Resultado)
            MyBase.conn.Close()
            Return Tabla

        Catch ex As Exception
            Throw ex
        End Try
    End Function


    Public Function BuscarEmployees(Valor As Integer) As DataTable

        Try
            Dim Resultado As SqlDataReader
            Dim Tabla As New DataTable
            Dim cmd As New SqlCommand("Orders_consulta_Employees", MyBase.conn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@valor", SqlDbType.VarChar).Value = Valor
            MyBase.conn.Open()
            Resultado = cmd.ExecuteReader
            Tabla.Load(Resultado)
            MyBase.conn.Close()
            Return Tabla

        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function BuscarEmployeeNombre(ValorEmployee As String) As DataTable

        Try
            Dim Resultado As SqlDataReader
            Dim Tabla As New DataTable
            Dim cmd As New SqlCommand("Orders_buscar_enombre", MyBase.conn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@Valor", SqlDbType.VarChar).Value = ValorEmployee 'cadena que se pasa para buscar
            MyBase.conn.Open()
            Resultado = cmd.ExecuteReader
            Tabla.Load(Resultado)
            MyBase.conn.Close()
            Return Tabla
        Catch ex As Exception
            Throw ex
        End Try
    End Function


    Public Function ListarDetalle(Id As Integer) As DataTable

        Try
            Dim Resultado As SqlDataReader
            Dim Tabla As New DataTable
            Dim cmd As New SqlCommand("Orders_listar_details", MyBase.conn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@orderid", SqlDbType.Int).Value = Id
            MyBase.conn.Open()
            Resultado = cmd.ExecuteReader
            Tabla.Load(Resultado)
            MyBase.conn.Close()
            Return Tabla
        Catch ex As Exception
            Throw ex
        End Try
    End Function


    Public Sub Insertar(Obj As Orders, Det As DataTable)
        Try

            Dim cmd As New SqlCommand("Orders_insertar", MyBase.conn)

            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@OrderID", SqlDbType.Int).Value = Obj.IdOrder
            cmd.Parameters("@OrderID").Direction = ParameterDirection.Output
            cmd.Parameters.Add("@CustomerID", SqlDbType.VarChar).Value = Obj.IdCustomer
            cmd.Parameters.Add("@EmployeeID", SqlDbType.Int).Value = Obj.IdEmployee
            cmd.Parameters.Add("@OrderDate", SqlDbType.Date).Value = Obj.OrdeDate
            cmd.Parameters.Add("@RequiredDate", SqlDbType.Date).Value = Obj.RequiredDate
            cmd.Parameters.Add("@ShippedDate", SqlDbType.Date).Value = Obj.ShippedDate
            cmd.Parameters.Add("@ShipVia", SqlDbType.Int).Value = Obj.ShipVia
            cmd.Parameters.Add("@Freigth", SqlDbType.Decimal).Value = Obj.Freight
            cmd.Parameters.Add("@ShipName", SqlDbType.VarChar).Value = Obj.ShipName
            cmd.Parameters.Add("@ShipAddress", SqlDbType.VarChar).Value = Obj.ShipAdress
            cmd.Parameters.Add("@ShipCity", SqlDbType.VarChar).Value = Obj.ShipCity
            cmd.Parameters.Add("@ShipRegion", SqlDbType.VarChar).Value = Obj.ShipRegion
            cmd.Parameters.Add("@ShipPostalCode", SqlDbType.VarChar).Value = Obj.ShipPostalCode
            cmd.Parameters.Add("@ShipCountry", SqlDbType.VarChar).Value = Obj.ShipCountry


            'datos del detalle

            cmd.Parameters.Add("@detalle", SqlDbType.Structured).Value = Det


            MyBase.conn.Open()
            cmd.ExecuteNonQuery()
            MyBase.conn.Close()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub Actualizar(Obj As Orders, Det As DataTable)
        Try

            Dim cmd As New SqlCommand("Orders_actualizar", MyBase.conn)

            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@OrderID", SqlDbType.Int).Value = Obj.IdOrder
            'cmd.Parameters("@OrderID").Direction = ParameterDirection.Output
            cmd.Parameters.Add("@CustomerID", SqlDbType.VarChar).Value = Obj.IdCustomer
            cmd.Parameters.Add("@EmployeeID", SqlDbType.Int).Value = Obj.IdEmployee
            cmd.Parameters.Add("@OrderDate", SqlDbType.Date).Value = Obj.OrdeDate
            cmd.Parameters.Add("@RequiredDate", SqlDbType.Date).Value = Obj.RequiredDate
            cmd.Parameters.Add("@ShippedDate", SqlDbType.Date).Value = Obj.ShippedDate
            cmd.Parameters.Add("@ShipVia", SqlDbType.Int).Value = Obj.ShipVia
            cmd.Parameters.Add("@Freigth", SqlDbType.Decimal).Value = Obj.Freight
            cmd.Parameters.Add("@ShipName", SqlDbType.VarChar).Value = Obj.ShipName
            cmd.Parameters.Add("@ShipAddress", SqlDbType.VarChar).Value = Obj.ShipAdress
            cmd.Parameters.Add("@ShipCity", SqlDbType.VarChar).Value = Obj.ShipCity
            cmd.Parameters.Add("@ShipRegion", SqlDbType.VarChar).Value = Obj.ShipRegion
            cmd.Parameters.Add("@ShipPostalCode", SqlDbType.VarChar).Value = Obj.ShipPostalCode
            cmd.Parameters.Add("@ShipCountry", SqlDbType.VarChar).Value = Obj.ShipCountry


            'datos del detalle

            cmd.Parameters.Add("@detalle", SqlDbType.Structured).Value = Det


            MyBase.conn.Open()
            cmd.ExecuteNonQuery()
            MyBase.conn.Close()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub


    Public Sub Anular(Id As Integer)
        Try

            Dim cmd As New SqlCommand("Orders_anular", MyBase.conn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@orderid", SqlDbType.Int).Value = Id
            MyBase.conn.Open()
            cmd.ExecuteNonQuery()
            MyBase.conn.Close()

        Catch ex As Exception
            Throw ex
        End Try
    End Sub



    Public Sub Eliminar(Id As Integer)
        Try

            Dim cmd As New SqlCommand("Orders_eliminar", MyBase.conn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@orderid", SqlDbType.Int).Value = Id
            MyBase.conn.Open()
            cmd.ExecuteNonQuery()
            MyBase.conn.Close()

        Catch ex As Exception
            Throw ex
        End Try
    End Sub



End Class
