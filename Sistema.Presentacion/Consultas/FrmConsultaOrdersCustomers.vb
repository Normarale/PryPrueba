Public Class FrmConsultaOrdersCustomers
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


    Private Sub Buscar()
        Try
            Dim Neg As New Negocio.NegocioOrders
            Dim customerid As String
            customerid = CmbCustomers.SelectedValue
            DgvListado.DataSource = Neg.BuscarCustomers(customerid)
            Me.Formato()
            LblTotalregistros.Text = "Total de registros: " & DgvListado.DataSource.Rows.Count

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub



    Private Sub CargarCustomers()
        Try
            Dim Neg As New Negocio.NegocioCustomers
            CmbCustomers.DataSource = Neg.Seleccionar
            CmbCustomers.ValueMember = "CustomerID"
            CmbCustomers.DisplayMember = "CompanyName"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        Me.Buscar()
    End Sub

    Private Sub FrmConsultaOrdersCustomers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CargarCustomers()
    End Sub
End Class