Public Class FrmOrders_OrdersDetails


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
        DgvListado.Columns(14).Width = 100
        DgvListado.Columns(15).Width = 100
        DgvListado.Columns.Item("Seleccionar").Visible = False
        BtnAnular.Visible = False
        BtnEliminar.Visible = False

        ChkSeleccionar.CheckState = False
    End Sub
#End Region

    Private Sub Listar()
        Try
            Dim Neg As New Negocio.NegocioOrders
            DgvListado.DataSource = Neg.Listar()
            LblTotalregistros.Text = "Total de registros: " & DgvListado.DataSource.Rows.Count
            Me.Formato()
            Me.Limpiar()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Limpiar()
        BtnGrabar.Visible = True
        BtnActualizar.Visible = False
        TxtId.Text = ""
        TxtIdCustomer.Text = ""
        TxtFreight.Text = ""
        TxtShipName.Text = ""
        TxtAddress.Text = ""
        TxtShipCity.Text = ""
        TxtShipRegion.Text = ""
        TxtPostalCode.Text = ""
        TxtShipCountry.Text = ""
        TxtProducts.Text = ""
        TxtTotal.Text = 0
        DgvDetalle.DataSource = ""
        DtpOrderDate.Value = DateTime.Today
        DtpRequired.Value = DateTime.Today
        DtpShipped.Format = DateTimePickerFormat.Long
        DtpShipped.CustomFormat = Nothing
        CmbEmployee.DisplayMember = ""
        CmbShipVia.DisplayMember = ""


    End Sub

    Private Sub CargarEmployees()
        Try
            Dim Neg As New Negocio.NegocioEmployees
            CmbEmployee.DataSource = Neg.Seleccionar
            CmbEmployee.ValueMember = "EmployeeID"
            CmbEmployee.DisplayMember = "LastName"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub CargarShippers()
        Try
            Dim Neg As New Negocio.NegocioShippers
            CmbShipVia.DataSource = Neg.Seleccionar
            CmbShipVia.ValueMember = "ShipperID"
            CmbShipVia.DisplayMember = "CompanyName"

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub FrmOrders_OrdersDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Listar()
        Me.CargarEmployees()
        Me.CargarShippers()
        Me.CrearTablaDetalle()
        Me.DgvListado.CurrentCell = DgvListado.Rows(0).Cells(1)

    End Sub

    Private Sub BtnBuscarCliente_Click(sender As Object, e As EventArgs) Handles BtnBuscarCliente.Click
        FrmBuscaCustomer.ShowDialog()
        TxtIdCustomer.Text = Variables.CustomerId
        TxtShipName.Text = Variables.CompanyName
        TxtAddress.Text = Variables.Address
        TxtShipCity.Text = Variables.City
        TxtShipRegion.Text = Variables.Region
        TxtPostalCode.Text = Variables.PostalCode
        TxtShipCountry.Text = Variables.Country
    End Sub

    Private Sub TxtProducts_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtProducts.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            Try
                Dim Neg As New Negocio.NegocioProducts
                Dim Obj As New Entidades.Products
                Obj = Neg.BuscarProducts(TxtProducts.Text)
                If (Obj Is Nothing) Then
                    MsgBox("No Existe el Producto con ese Código ....", vbOKOnly + vbCritical, "Código No Existente")
                Else
                    Me.AgregarDetalle(Obj)
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If

    End Sub

    'CREAR GRILLA DE DETALLE
    Private Sub CrearTablaDetalle()
        Me.Detalle = New DataTable("Detalle")
        Me.Detalle.Columns.Add("ProductID", System.Type.GetType("System.Int32"))
        Me.Detalle.Columns.Add("ProductName", System.Type.GetType("System.String"))
        Me.Detalle.Columns.Add("UnitPrice", System.Type.GetType("System.Decimal"))
        Me.Detalle.Columns.Add("Quantity", System.Type.GetType("System.Int32"))
        Me.Detalle.Columns.Add("UnitInStock", System.Type.GetType("System.Int32"))
        Me.Detalle.Columns.Add("Discount", System.Type.GetType("System.Decimal"))
        Me.Detalle.Columns.Add("TotPrice", System.Type.GetType("System.Decimal"))


        DgvDetalle.DataSource = Me.Detalle
        Me.FormatoDetalle()

    End Sub

    'FORMATO TABLA DETALLE
    Public Sub FormatoDetalle()
        DgvDetalle.Columns(0).HeaderText = "ProductID"
        DgvDetalle.Columns(1).Width = 70
        DgvDetalle.Columns(1).HeaderText = "ProductName"
        DgvDetalle.Columns(1).Width = 100
        DgvDetalle.Columns(2).HeaderText = "UnitPrice"
        DgvDetalle.Columns(2).Width = 200
        DgvDetalle.Columns(3).HeaderText = "Quantity"
        DgvDetalle.Columns(3).Width = 100
        DgvDetalle.Columns(4).HeaderText = "UnitInStock"
        DgvDetalle.Columns(4).Width = 100
        DgvDetalle.Columns(5).HeaderText = "Discount"
        DgvDetalle.Columns(5).Width = 100
        DgvDetalle.Columns(6).HeaderText = "TotPrice"
        DgvDetalle.Columns(6).Width = 100


        DgvDetalle.Columns(0).ReadOnly = True
        DgvDetalle.Columns(1).ReadOnly = True
        DgvDetalle.Columns(2).ReadOnly = True
        DgvDetalle.Columns(4).ReadOnly = True
        DgvDetalle.Columns(6).ReadOnly = True
    End Sub


    Public Sub AgregarDetalle(Filas As Entidades.Products)
        Dim Agregar As Boolean = True

        For Each FilaTemp As DataGridViewRow In DgvDetalle.Rows
            If (Convert.ToInt32(FilaTemp.Cells("ProductID").Value = Convert.ToInt32(Filas.ProductID))) Then
                Agregar = False
                MsgBox("El artículo ya fue agregado", vbOKOnly + vbCritical, "Articulo Duplicado")
            End If
        Next

        If (Agregar) Then
            Dim Row As DataRow
            Row = Detalle.NewRow 'creamos una nueva fila de ese detalle
            Row("ProductID") = Convert.ToString(Filas.ProductID)
            Row("ProductName") = Convert.ToString(Filas.ProductName)
            Row("UnitPrice") = Convert.ToString(Filas.UnitPrice)
            Row("Quantity") = Convert.ToString(1)
            Row("UnitInStock") = Convert.ToString(Filas.UnitsInStock)
            Row("Discount") = Convert.ToString(0)
            Row("TotPrice") = Convert.ToString(Filas.UnitPrice)
            Me.Detalle.Rows.Add(Row)
            Me.CalcularTotales()
        End If
    End Sub

    Private Sub CalcularTotales()
        Dim Total As Decimal = 0

        For Each FilaTemp As DataGridViewRow In DgvDetalle.Rows
            Total = Total + CDec(FilaTemp.Cells("TotPrice").Value)

        Next

        TxtTotal.Text = Total

    End Sub

    Private Sub BtnGrabar_Click(sender As Object, e As EventArgs) Handles BtnGrabar.Click
        Try
            If (DgvDetalle.Rows.Count > 0) Then
                Dim ObjOrders As New Entidades.Orders
                Dim Neg As New Negocio.NegocioOrders

                ObjOrders.IdEmployee = CmbEmployee.SelectedValue
                ObjOrders.IdCustomer = TxtIdCustomer.Text
                ObjOrders.OrdeDate = DtpOrderDate.Value
                ObjOrders.RequiredDate = DtpRequired.Value
                ObjOrders.ShippedDate = DtpShipped.Value
                ObjOrders.ShipVia = CmbShipVia.SelectedValue
                ObjOrders.Freight = TxtFreight.Text
                ObjOrders.ShipName = TxtShipName.Text
                ObjOrders.ShipAdress = TxtAddress.Text
                ObjOrders.ShipCity = TxtShipCity.Text
                ObjOrders.ShipRegion = TxtShipRegion.Text
                ObjOrders.ShipPostalCode = TxtPostalCode.Text
                ObjOrders.ShipCountry = TxtShipCountry.Text


                If Neg.Insertar(ObjOrders, Detalle) Then
                    MsgBox("Los Orders se registraron correctamente", MsgBoxStyle.Information, "Registro Correcto")
                    Me.Listar()
                Else
                    MsgBox("No se han podrido registrar Los Ordes", MsgBoxStyle.Critical, "Error registración")
                End If
            Else
                MsgBox("Faltan de rellenar campos (*)... agregue al menos un detalle", MsgBoxStyle.Exclamation, "Completar Campos")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub DgvDetalle_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DgvDetalle.CellEndEdit
        Dim fila As DataGridViewRow = CType(DgvDetalle.Rows(e.RowIndex), DataGridViewRow)
        Dim Precio As Decimal = fila.Cells("UnitPrice").Value
        Dim Cantidad As Integer = fila.Cells("Quantity").Value
        Dim Stock As Integer = fila.Cells("UnitInStock").Value
        Dim Descuento As Decimal = fila.Cells("Discount").Value
        Dim Producto As Integer = fila.Cells("ProductID").Value


        If (Cantidad > Stock) Then
            MsgBox("La Cantidad a vender del Producto " & Producto & " supera la cantidad existente", MsgBoxStyle.Critical, "Error Cantidad")
            Cantidad = Stock
        End If

        fila.Cells("Quantity").Value = Cantidad
        fila.Cells("TotPrice").Value = (Precio * Cantidad) - ((Precio * Cantidad) * Descuento)

        Me.CalcularTotales()
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        Me.Buscar()
    End Sub


    Private Sub Buscar()
        Try
            Dim Neg As New Negocio.NegocioOrders
            Dim Valor As String
            Valor = TxtBusca.Text
            DgvListado.DataSource = Neg.Buscar(Valor)
            Me.Formato()
            LblTotalregistros.Text = "Total de registros: " & DgvListado.DataSource.Rows.Count

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub DgvListado_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvListado.CellDoubleClick
        Try


            If (DgvListado.Item("Estado", DgvListado.CurrentCell.RowIndex).Value) Is DBNull.Value Then


                Me.TabGeneral.TabPages(1).Enabled = True
                '
                TxtId.Text = DgvListado.Item("ID", DgvListado.CurrentRow.Index).Value
                CmbEmployee.Text = DgvListado.Item("LastName", DgvListado.CurrentRow.Index).Value
                CmbShipVia.Text = DgvListado.Item("ShipVia", DgvListado.CurrentRow.Index).Value
                TxtShipName.Text = DgvListado.Item("CompanyName", DgvListado.CurrentRow.Index).Value
                DtpOrderDate.Value = CDate(DgvListado.Item("OrderDate", DgvListado.CurrentRow.Index).Value)
                DtpRequired.Value = CDate(DgvListado.Item("RequiredDate", DgvListado.CurrentRow.Index).Value)
                If (DgvListado.Item("ShippedDate", DgvListado.CurrentRow.Index).Value) Is DBNull.Value Then
                    DtpShipped.Format = DateTimePickerFormat.Custom
                    DtpShipped.CustomFormat = " "
                Else
                    DtpShipped.Value = CDate((DgvListado.Item("ShippedDate", DgvListado.CurrentRow.Index).Value))
                End If
                TxtFreight.Text = DgvListado.Item("Freight", DgvListado.CurrentRow.Index).Value
                TxtAddress.Text = DgvListado.Item("Address", DgvListado.CurrentRow.Index).Value
                TxtShipCity.Text = DgvListado.Item("City", DgvListado.CurrentRow.Index).Value
                TxtIdCustomer.Text = DgvListado.Item("CustomerID", DgvListado.CurrentRow.Index).Value
                If (DgvListado.Item("Region", DgvListado.CurrentRow.Index).Value) Is DBNull.Value Then
                    TxtShipRegion.Text = ""
                Else
                    TxtShipRegion.Text = DgvListado.Item("Region", DgvListado.CurrentRow.Index).Value
                End If

                TxtPostalCode.Text = DgvListado.Item("PostalCode", DgvListado.CurrentRow.Index).Value
                TxtShipCountry.Text = DgvListado.Item("Country", DgvListado.CurrentRow.Index).Value

                GbDetalle.Enabled = True
                Dim Neg As New Negocio.NegocioOrders
                Me.CrearTablaDetalle()
                DgvDetalle.DataSource = Neg.ListarDetalle(DgvListado.Item("ID", DgvListado.CurrentRow.Index).Value)


                Dim Tot As Decimal = 0

                If DgvDetalle.DataSource.rows.count > 0 Then
                    'TxtMostrarTotal.Text = 0

                    Dim Descuento As Decimal = 0

                    For Each FilaTemp As DataGridViewRow In DgvDetalle.Rows

                        Descuento = (CDec(FilaTemp.Cells("UnitPrice").Value) * (FilaTemp.Cells("Quantity").Value)) * (FilaTemp.Cells("Discount").Value)
                        Tot = (CDec(FilaTemp.Cells("UnitPrice").Value) * (FilaTemp.Cells("Quantity").Value)) - Descuento
                        Total = Total + (CDec(FilaTemp.Cells("UnitPrice").Value) * (FilaTemp.Cells("Quantity").Value)) - Descuento



                    Next
                End If

                TxtTotal.Text = Total
                BtnActualizar.Visible = True
                GbDetalle.Enabled = False
                BtnGrabar.Visible = False
                TabGeneral.SelectedIndex = 1
                TabGeneral.Enabled = True

            Else
                TabGeneral.SelectedIndex = 1
                TabGeneral.TabPages(1).Enabled = False
                TxtId.Text = DgvListado.Item("ID", DgvListado.CurrentRow.Index).Value
                CmbEmployee.Text = DgvListado.Item("LastName", DgvListado.CurrentRow.Index).Value.ToString
                CmbShipVia.Text = DgvListado.Item("ShipVia", DgvListado.CurrentRow.Index).Value.ToString
                TxtShipName.Text = DgvListado.Item("CompanyName", DgvListado.CurrentRow.Index).Value
                DtpOrderDate.Value = DgvListado.Item("OrderDate", DgvListado.CurrentRow.Index).Value
                DtpRequired.Value = DgvListado.Item("RequiredDate", DgvListado.CurrentRow.Index).Value
                If (DgvListado.Item("ShippedDate", DgvListado.CurrentRow.Index).Value) Is DBNull.Value Then
                    DtpShipped.Format = DateTimePickerFormat.Custom
                    DtpShipped.CustomFormat = " "
                Else
                    DtpShipped.Value = DgvListado.Item("ShippedDate", DgvListado.CurrentRow.Index).Value
                End If
                TxtFreight.Text = DgvListado.Item("Freight", DgvListado.CurrentRow.Index).Value
                TxtAddress.Text = DgvListado.Item("Address", DgvListado.CurrentRow.Index).Value
                TxtShipCity.Text = DgvListado.Item("City", DgvListado.CurrentRow.Index).Value
                TxtIdCustomer.Text = DgvListado.Item("CustomerID", DgvListado.CurrentRow.Index).Value
                If (DgvListado.Item("Region", DgvListado.CurrentRow.Index).Value) Is DBNull.Value Then
                    TxtShipRegion.Text = ""
                Else
                    TxtShipRegion.Text = DgvListado.Item("Region", DgvListado.CurrentRow.Index).Value
                End If

                TxtPostalCode.Text = DgvListado.Item("PostalCode", DgvListado.CurrentRow.Index).Value
                TxtShipCountry.Text = DgvListado.Item("Country", DgvListado.CurrentRow.Index).Value

                Dim Neg As New Negocio.NegocioOrders
                DgvDetalle.DataSource = Neg.ListarDetalle(DgvListado.Item("ID", DgvListado.CurrentRow.Index).Value)


                Dim Tot As Decimal = 0

                If DgvDetalle.DataSource.rows.count > 0 Then
                    'TxtMostrarTotal.Text = 0
                    'Dim Total As Decimal = 0
                    Dim Descuento As Decimal = 0

                    For Each FilaTemp As DataGridViewRow In DgvDetalle.Rows
                        Descuento = (CDec(FilaTemp.Cells("UnitPrice").Value) * (FilaTemp.Cells("Quantity").Value)) * (FilaTemp.Cells("Discount").Value)
                        Total = Total + (CDec(FilaTemp.Cells("UnitPrice").Value) * (FilaTemp.Cells("Quantity").Value)) - Descuento


                    Next
                End If

                TxtTotal.Text = Total
                BtnActualizar.Visible = False
                DgvDetalle.Enabled = True
                BtnGrabar.Visible = True
                BtnCancelar.Enabled = True

            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try




    End Sub


    Private Sub ChkSeleccionar_CheckedChanged(sender As Object, e As EventArgs) Handles ChkSeleccionar.CheckedChanged
        If ChkSeleccionar.CheckState = CheckState.Checked Then
            DgvListado.Columns.Item("Seleccionar").Visible = True
            BtnAnular.Visible = True
            BtnEliminar.Visible = True
        Else
            DgvListado.Columns.Item("Seleccionar").Visible = False
            BtnAnular.Visible = False
            BtnEliminar.Visible = False
        End If

    End Sub

    Private Sub BtnAnular_Click(sender As Object, e As EventArgs) Handles BtnAnular.Click

        Dim filas As Integer = 0
        If (MsgBox("Está seguro de Anular los Registros seleccionados?...", vbYesNo + vbQuestion, "Acciones...") = vbYes) Then
            Try

                Dim Neg As New Negocio.NegocioOrders
                For Each row As DataGridViewRow In DgvListado.Rows
                    Dim Marcado As Boolean = Convert.ToBoolean(row.Cells("Seleccionar").Value)
                    If Marcado Then
                        Dim NumeroId As Integer = Convert.ToInt32(row.Cells("ID").Value)

                        Neg.Anular(NumeroId)
                        filas = filas + 1

                    End If

                Next
                If filas = 0 Then
                    MsgBox("Debe Seleccionar el/los Registros para Anular...")
                End If
                Me.Listar()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If




    End Sub



    Private Sub DgvListado_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvListado.CellContentClick
        If e.ColumnIndex = DgvListado.Columns.Item("Seleccionar").Index Then
            Dim checkcell As DataGridViewCheckBoxCell = DgvListado.Rows(e.RowIndex).Cells("Seleccionar")
            checkcell.Value = Not checkcell.Value
        End If
    End Sub

    Private Sub BtnEliminaProducto_Click(sender As Object, e As EventArgs) Handles BtnEliminaProducto.Click

        DgvDetalle.Rows.Remove(DgvDetalle.CurrentRow)

    End Sub




    Private Sub BtnCerrarMostrar_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Me.Limpiar()

        TabGeneral.SelectedIndex = 0

    End Sub

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        Try
            If (TxtId.Text <> "") Then


                Dim ObjOrders As New Entidades.Orders
                Dim Neg As New Negocio.NegocioOrders

                ObjOrders.IdEmployee = CmbEmployee.SelectedValue
                ObjOrders.IdOrder = TxtId.Text
                ObjOrders.IdCustomer = TxtIdCustomer.Text
                ObjOrders.OrdeDate = DtpOrderDate.Value
                ObjOrders.RequiredDate = DtpRequired.Value
                ObjOrders.ShippedDate = DtpShipped.Value
                ObjOrders.ShipVia = CmbShipVia.SelectedValue
                ObjOrders.Freight = TxtFreight.Text
                ObjOrders.ShipName = TxtShipName.Text
                ObjOrders.ShipAdress = TxtAddress.Text
                ObjOrders.ShipCity = TxtShipCity.Text
                ObjOrders.ShipRegion = TxtShipRegion.Text
                ObjOrders.ShipPostalCode = TxtPostalCode.Text
                ObjOrders.ShipCountry = TxtShipCountry.Text


                If Neg.Actualizar(ObjOrders) Then
                    MsgBox("Los Orders se Actualizaron correctamente", MsgBoxStyle.Information, "Registro Correcto")
                    Me.Listar()
                    TabGeneral.SelectedIndex = 0
                Else
                    MsgBox("No se han podrido actualizar Los Ordes", MsgBoxStyle.Critical, "Error registración")
                End If
            Else
                MsgBox("Faltan de rellenar campos (*)... agregue al menos un detalle", MsgBoxStyle.Exclamation, "Completar Campos")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        Dim filas As Integer = 0
        If (MsgBox("Está seguro de Eliminar los Registros seleccionados?...", vbYesNo + vbQuestion, "Acciones...") = vbYes) Then
            Try

                Dim Neg As New Negocio.NegocioOrders
                For Each row As DataGridViewRow In DgvListado.Rows
                    Dim Marcado As Boolean = Convert.ToBoolean(row.Cells("Seleccionar").Value)
                    If Marcado Then
                        Dim NumeroId As Integer = Convert.ToInt32(row.Cells("ID").Value)

                        Neg.Eliminar(NumeroId)
                        filas = filas + 1

                    End If

                Next
                If filas = 0 Then
                    MsgBox("Debe Seleccionar el/los Registros para Eliminar...")
                End If
                Me.Listar()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
        'Else

        'End If
    End Sub
End Class