Public Class FrmBuscaCustomer
    Private Sub FrmBuscaCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

#Region "Formato gridView"
    Public Sub Formato()
        DgvListado.Columns(0).Visible = False
        DgvListado.Columns(1).Width = 70
        DgvListado.Columns(2).Width = 120
        DgvListado.Columns(3).Width = 120
        DgvListado.Columns(4).Width = 100
        DgvListado.Columns(5).Width = 100
        DgvListado.Columns(6).Width = 70
        DgvListado.Columns(7).Width = 100
        DgvListado.Columns(8).Width = 80
        DgvListado.Columns(9).Width = 80
        DgvListado.Columns(10).Width = 80
        DgvListado.Columns(11).Width = 80

        DgvListado.Columns.Item("Seleccionar").Visible = False

    End Sub
#End Region

    Private Sub Listar()
        Try
            Dim Neg As New Negocio.NegocioCustomers

            DgvListado.DataSource = Neg.Listar()
            LblTotalregistros.Text = "Total de registros: " & DgvListado.DataSource.Rows.Count
            Me.Formato()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BuscarCliente()
        Try
            Dim Neg As New Negocio.NegocioCustomers
            Dim Valor As String
            Valor = TxtBusca.Text
            DgvListado.DataSource = Neg.Buscar(Valor)
            Me.Formato()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        Me.BuscarCliente()
    End Sub

    Private Sub DgvListado_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvListado.CellDoubleClick
        Variables.CustomerId = DgvListado.Item("ID", DgvListado.CurrentRow.Index).Value
        Variables.CompanyName = DgvListado.Item("CompanyName", DgvListado.CurrentRow.Index).Value

        If (DgvListado.Item("Name", DgvListado.CurrentRow.Index).Value) Is DBNull.Value Then
            Variables.ContactName = ""
        Else
            Variables.ContactName = DgvListado.Item("Name", DgvListado.CurrentRow.Index).Value

        End If
        If (DgvListado.Item("Title", DgvListado.CurrentRow.Index).Value) Is DBNull.Value Then
            Variables.ContacTitle = ""
        Else
            Variables.ContacTitle = DgvListado.Item("Title", DgvListado.CurrentRow.Index).Value
        End If
        If (DgvListado.Item("Address", DgvListado.CurrentRow.Index).Value) Is DBNull.Value Then
            Variables.Address = ""
        Else
            Variables.Address = DgvListado.Item("Address", DgvListado.CurrentRow.Index).Value

        End If
        If (DgvListado.Item("City", DgvListado.CurrentRow.Index).Value) Is DBNull.Value Then
            Variables.City = ""
        Else
            Variables.City = DgvListado.Item("City", DgvListado.CurrentRow.Index).Value
        End If

        If (DgvListado.Item("Region", DgvListado.CurrentRow.Index).Value) Is DBNull.Value Then
            Variables.Region = ""
        Else
            Variables.Region = DgvListado.Item("Region", DgvListado.CurrentRow.Index).Value
        End If
        If (DgvListado.Item("PostalCode", DgvListado.CurrentRow.Index).Value) Is DBNull.Value Then
            Variables.PostalCode = ""
        Else
            Variables.PostalCode = DgvListado.Item("PostalCode", DgvListado.CurrentRow.Index).Value
        End If
        If (DgvListado.Item("Country", DgvListado.CurrentRow.Index).Value) Is DBNull.Value Then
            Variables.Country = ""
        Else
            Variables.Country = DgvListado.Item("Country", DgvListado.CurrentRow.Index).Value
        End If

        Me.Close()

    End Sub




End Class