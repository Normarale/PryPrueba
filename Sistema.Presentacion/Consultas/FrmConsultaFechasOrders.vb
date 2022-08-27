Public Class FrmConsultaFechasOrders

    Private Detalle As New DataTable
    Private Total As Decimal = 0

#Region "Formato gridView"
    Public Sub Formato()
        DgvListado.Columns(0).Visible = False
        DgvListado.Columns(0).Width = 100
        DgvListado.Columns(1).Width = 60
        DgvListado.Columns(2).Width = 100
        DgvListado.Columns(3).Width = 100
        DgvListado.Columns(4).Width = 100
        DgvListado.Columns(5).Width = 100
        DgvListado.Columns(6).Width = 80
        DgvListado.Columns(7).Width = 80
        DgvListado.Columns(8).Width = 60
        DgvListado.Columns(9).Width = 100
        DgvListado.Columns(10).Width = 100
        DgvListado.Columns(11).Width = 100
        DgvListado.Columns(12).Width = 100
        DgvListado.Columns(13).Width = 100



        DgvListado.Columns.Item("Seleccionar").Visible = False

    End Sub
#End Region

    Private Sub CrearTablaDetalle()
        Me.Detalle = New DataTable("Detalle")
        Me.Detalle.Columns.Add("ProductID", System.Type.GetType("System.Int32"))
        Me.Detalle.Columns.Add("ProductName", System.Type.GetType("System.String"))
        Me.Detalle.Columns.Add("UnitPrice", System.Type.GetType("System.Decimal"))
        Me.Detalle.Columns.Add("Quantity", System.Type.GetType("System.Int32"))
        Me.Detalle.Columns.Add("UnitInStock", System.Type.GetType("System.Int32"))
        Me.Detalle.Columns.Add("Discount", System.Type.GetType("System.Decimal"))
        Me.Detalle.Columns.Add("TotPrice", System.Type.GetType("System.Decimal"))


        DgvMostrar.DataSource = Me.Detalle
        Me.FormatoDetalle()

    End Sub

    'FORMATO TABLA DETALLE
    Public Sub FormatoDetalle()
        DgvMostrar.Columns(0).HeaderText = "ProductID"
        DgvMostrar.Columns(1).Width = 70
        DgvMostrar.Columns(1).HeaderText = "ProductName"
        DgvMostrar.Columns(1).Width = 100
        DgvMostrar.Columns(2).HeaderText = "UnitPrice"
        DgvMostrar.Columns(2).Width = 200
        DgvMostrar.Columns(3).HeaderText = "Quantity"
        DgvMostrar.Columns(3).Width = 100
        DgvMostrar.Columns(4).HeaderText = "UnitInStock"
        DgvMostrar.Columns(4).Width = 100
        DgvMostrar.Columns(5).HeaderText = "Discount"
        DgvMostrar.Columns(5).Width = 100
        DgvMostrar.Columns(6).HeaderText = "TotPrice"
        DgvMostrar.Columns(6).Width = 100


        DgvMostrar.Columns(0).ReadOnly = True
        DgvMostrar.Columns(1).ReadOnly = True
        DgvMostrar.Columns(2).ReadOnly = True
        DgvMostrar.Columns(4).ReadOnly = True
        DgvMostrar.Columns(6).ReadOnly = True
    End Sub


    Private Sub Buscar()
        Try
            Dim Neg As New Negocio.NegocioOrders
            Dim FechaInicio As Date
            Dim FechaFin As Date
            FechaInicio = DtpDesde.Value
            FechaFin = DtpHasta.Value
            DgvListado.DataSource = Neg.BuscarEntreFechas(FechaInicio, FechaFin)
            Me.Formato()
            LblTotalregistros.Text = "Total de registros: " & DgvListado.DataSource.Rows.Count

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Listar()
        Try
            Dim Neg As New Negocio.NegocioOrders
            DgvListado.DataSource = Neg.Listar()
            LblTotalregistros.Text = "Total de registros: " & DgvListado.DataSource.Rows.Count
            Me.Formato()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub FrmConsultaFechasOrders_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Listar()
        PanelMostrar.Visible = False
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        Me.Buscar()
    End Sub


    Private Sub BtnCerrarMostrar_Click(sender As Object, e As EventArgs) Handles BtnCerrarMostrar.Click
        PanelMostrar.Visible = False
        TxtMostrarTotal.Text = 0
    End Sub

    Private Sub DgvListado_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvListado.CellDoubleClick

        Try
            Dim Neg As New Negocio.NegocioOrders
            Me.CrearTablaDetalle()
            Total = 0
            DgvMostrar.DataSource = Neg.ListarDetalle(DgvListado.Item("ID", DgvListado.CurrentRow.Index).Value)


            Dim Tot As Decimal = 0

            If DgvMostrar.DataSource.rows.count > 0 Then
                'TxtMostrarTotal.Text = 0

                Dim Descuento As Decimal = 0

                For Each FilaTemp As DataGridViewRow In DgvMostrar.Rows

                    Descuento = (CDec(FilaTemp.Cells("UnitPrice").Value) * (FilaTemp.Cells("Quantity").Value)) * (FilaTemp.Cells("Discount").Value)
                    Tot = (CDec(FilaTemp.Cells("UnitPrice").Value) * (FilaTemp.Cells("Quantity").Value)) - Descuento
                    Total = Total + (CDec(FilaTemp.Cells("UnitPrice").Value) * (FilaTemp.Cells("Quantity").Value)) - Descuento



                Next
            End If



            TxtMostrarTotal.Text = Total

            PanelMostrar.Visible = True



        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


End Class