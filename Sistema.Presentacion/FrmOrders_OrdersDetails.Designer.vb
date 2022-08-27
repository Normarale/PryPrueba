<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmOrders_OrdersDetails
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.LblShipRegion = New System.Windows.Forms.Label()
        Me.LblShipName = New System.Windows.Forms.Label()
        Me.TxtPostalCode = New System.Windows.Forms.TextBox()
        Me.BtnBuscarCliente = New System.Windows.Forms.Button()
        Me.LblPostaCode = New System.Windows.Forms.Label()
        Me.TxtShipCountry = New System.Windows.Forms.TextBox()
        Me.PanelProductos = New System.Windows.Forms.Panel()
        Me.BtnCerrar = New System.Windows.Forms.Button()
        Me.LblTotalesManual = New System.Windows.Forms.Label()
        Me.DgvArticuloManual = New System.Windows.Forms.DataGridView()
        Me.BtnBuscarManual = New System.Windows.Forms.Button()
        Me.TxtBuscarManual = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtTotal = New System.Windows.Forms.TextBox()
        Me.TxtProducts = New System.Windows.Forms.TextBox()
        Me.BtnBuscarArticulo = New System.Windows.Forms.Button()
        Me.LblArticulo = New System.Windows.Forms.Label()
        Me.TxtShipRegion = New System.Windows.Forms.TextBox()
        Me.LblShipCity = New System.Windows.Forms.Label()
        Me.TxtAddress = New System.Windows.Forms.TextBox()
        Me.LblCountry = New System.Windows.Forms.Label()
        Me.TxtShipCity = New System.Windows.Forms.TextBox()
        Me.TabGeneral = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnAnular = New System.Windows.Forms.Button()
        Me.ChkSeleccionar = New System.Windows.Forms.CheckBox()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.LblTotalregistros = New System.Windows.Forms.Label()
        Me.TxtBusca = New System.Windows.Forms.TextBox()
        Me.DgvListado = New System.Windows.Forms.DataGridView()
        Me.Seleccionar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.TxtFreight = New System.Windows.Forms.TextBox()
        Me.LblFreight = New System.Windows.Forms.Label()
        Me.CmbShipVia = New System.Windows.Forms.ComboBox()
        Me.LblShipVia = New System.Windows.Forms.Label()
        Me.CmbEmployee = New System.Windows.Forms.ComboBox()
        Me.LblIdEmployee = New System.Windows.Forms.Label()
        Me.LblShippedDate = New System.Windows.Forms.Label()
        Me.LblRequiredDate = New System.Windows.Forms.Label()
        Me.DtpRequired = New System.Windows.Forms.DateTimePicker()
        Me.BtnActualizar = New System.Windows.Forms.Button()
        Me.BtnGrabar = New System.Windows.Forms.Button()
        Me.LblOrderdate = New System.Windows.Forms.Label()
        Me.DtpOrderDate = New System.Windows.Forms.DateTimePicker()
        Me.GbDetalle = New System.Windows.Forms.GroupBox()
        Me.BtnEliminaProducto = New System.Windows.Forms.Button()
        Me.DgvDetalle = New System.Windows.Forms.DataGridView()
        Me.GBCabecera = New System.Windows.Forms.GroupBox()
        Me.LblAddress = New System.Windows.Forms.Label()
        Me.TxtShipName = New System.Windows.Forms.TextBox()
        Me.TxtIdCustomer = New System.Windows.Forms.TextBox()
        Me.LblCliente = New System.Windows.Forms.Label()
        Me.LblId = New System.Windows.Forms.Label()
        Me.TxtId = New System.Windows.Forms.TextBox()
        Me.DtpShipped = New System.Windows.Forms.DateTimePicker()
        Me.PanelProductos.SuspendLayout()
        CType(Me.DgvArticuloManual, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabGeneral.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DgvListado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.GbDetalle.SuspendLayout()
        CType(Me.DgvDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBCabecera.SuspendLayout()
        Me.SuspendLayout()
        '
        'LblShipRegion
        '
        Me.LblShipRegion.AutoSize = True
        Me.LblShipRegion.Location = New System.Drawing.Point(614, 95)
        Me.LblShipRegion.Name = "LblShipRegion"
        Me.LblShipRegion.Size = New System.Drawing.Size(62, 13)
        Me.LblShipRegion.TabIndex = 14
        Me.LblShipRegion.Text = "ShipRegion"
        '
        'LblShipName
        '
        Me.LblShipName.AutoSize = True
        Me.LblShipName.Location = New System.Drawing.Point(253, 43)
        Me.LblShipName.Name = "LblShipName"
        Me.LblShipName.Size = New System.Drawing.Size(56, 13)
        Me.LblShipName.TabIndex = 10
        Me.LblShipName.Text = "ShipName"
        '
        'TxtPostalCode
        '
        Me.TxtPostalCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPostalCode.Location = New System.Drawing.Point(112, 132)
        Me.TxtPostalCode.Name = "TxtPostalCode"
        Me.TxtPostalCode.Size = New System.Drawing.Size(115, 20)
        Me.TxtPostalCode.TabIndex = 9
        '
        'BtnBuscarCliente
        '
        Me.BtnBuscarCliente.BackgroundImage = Global.Sistema.Presentacion.My.Resources.Resources.buscar
        Me.BtnBuscarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnBuscarCliente.Location = New System.Drawing.Point(715, 19)
        Me.BtnBuscarCliente.Name = "BtnBuscarCliente"
        Me.BtnBuscarCliente.Size = New System.Drawing.Size(38, 41)
        Me.BtnBuscarCliente.TabIndex = 7
        Me.BtnBuscarCliente.UseVisualStyleBackColor = True
        '
        'LblPostaCode
        '
        Me.LblPostaCode.AutoSize = True
        Me.LblPostaCode.Location = New System.Drawing.Point(22, 139)
        Me.LblPostaCode.Name = "LblPostaCode"
        Me.LblPostaCode.Size = New System.Drawing.Size(64, 13)
        Me.LblPostaCode.TabIndex = 8
        Me.LblPostaCode.Text = "Postal Code"
        '
        'TxtShipCountry
        '
        Me.TxtShipCountry.Location = New System.Drawing.Point(415, 136)
        Me.TxtShipCountry.Name = "TxtShipCountry"
        Me.TxtShipCountry.Size = New System.Drawing.Size(189, 20)
        Me.TxtShipCountry.TabIndex = 6
        '
        'PanelProductos
        '
        Me.PanelProductos.BackColor = System.Drawing.Color.PowderBlue
        Me.PanelProductos.Controls.Add(Me.BtnCerrar)
        Me.PanelProductos.Controls.Add(Me.LblTotalesManual)
        Me.PanelProductos.Controls.Add(Me.DgvArticuloManual)
        Me.PanelProductos.Controls.Add(Me.BtnBuscarManual)
        Me.PanelProductos.Controls.Add(Me.TxtBuscarManual)
        Me.PanelProductos.Controls.Add(Me.Label1)
        Me.PanelProductos.Location = New System.Drawing.Point(95, 55)
        Me.PanelProductos.Name = "PanelProductos"
        Me.PanelProductos.Size = New System.Drawing.Size(699, 211)
        Me.PanelProductos.TabIndex = 13
        Me.PanelProductos.Visible = False
        '
        'BtnCerrar
        '
        Me.BtnCerrar.Location = New System.Drawing.Point(650, 17)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(49, 21)
        Me.BtnCerrar.TabIndex = 19
        Me.BtnCerrar.Text = "Cerrar"
        Me.BtnCerrar.UseVisualStyleBackColor = True
        '
        'LblTotalesManual
        '
        Me.LblTotalesManual.AutoSize = True
        Me.LblTotalesManual.Location = New System.Drawing.Point(449, 244)
        Me.LblTotalesManual.Name = "LblTotalesManual"
        Me.LblTotalesManual.Size = New System.Drawing.Size(31, 13)
        Me.LblTotalesManual.TabIndex = 18
        Me.LblTotalesManual.Text = "Total"
        '
        'DgvArticuloManual
        '
        Me.DgvArticuloManual.AllowUserToAddRows = False
        Me.DgvArticuloManual.AllowUserToDeleteRows = False
        Me.DgvArticuloManual.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvArticuloManual.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvArticuloManual.Location = New System.Drawing.Point(19, 63)
        Me.DgvArticuloManual.Name = "DgvArticuloManual"
        Me.DgvArticuloManual.ReadOnly = True
        Me.DgvArticuloManual.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvArticuloManual.Size = New System.Drawing.Size(625, 110)
        Me.DgvArticuloManual.TabIndex = 17
        '
        'BtnBuscarManual
        '
        Me.BtnBuscarManual.Location = New System.Drawing.Point(595, 16)
        Me.BtnBuscarManual.Name = "BtnBuscarManual"
        Me.BtnBuscarManual.Size = New System.Drawing.Size(49, 21)
        Me.BtnBuscarManual.TabIndex = 16
        Me.BtnBuscarManual.Text = "Buscar"
        Me.BtnBuscarManual.UseVisualStyleBackColor = True
        '
        'TxtBuscarManual
        '
        Me.TxtBuscarManual.Location = New System.Drawing.Point(115, 17)
        Me.TxtBuscarManual.Name = "TxtBuscarManual"
        Me.TxtBuscarManual.Size = New System.Drawing.Size(460, 20)
        Me.TxtBuscarManual.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Producto"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(561, 231)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Total"
        '
        'TxtTotal
        '
        Me.TxtTotal.Location = New System.Drawing.Point(615, 225)
        Me.TxtTotal.Name = "TxtTotal"
        Me.TxtTotal.Size = New System.Drawing.Size(136, 20)
        Me.TxtTotal.TabIndex = 17
        '
        'TxtProducts
        '
        Me.TxtProducts.Location = New System.Drawing.Point(134, 16)
        Me.TxtProducts.Name = "TxtProducts"
        Me.TxtProducts.Size = New System.Drawing.Size(203, 20)
        Me.TxtProducts.TabIndex = 14
        '
        'BtnBuscarArticulo
        '
        Me.BtnBuscarArticulo.Location = New System.Drawing.Point(479, 19)
        Me.BtnBuscarArticulo.Name = "BtnBuscarArticulo"
        Me.BtnBuscarArticulo.Size = New System.Drawing.Size(49, 21)
        Me.BtnBuscarArticulo.TabIndex = 12
        Me.BtnBuscarArticulo.Text = "Buscar"
        Me.BtnBuscarArticulo.UseVisualStyleBackColor = True
        '
        'LblArticulo
        '
        Me.LblArticulo.AutoSize = True
        Me.LblArticulo.Location = New System.Drawing.Point(42, 21)
        Me.LblArticulo.Name = "LblArticulo"
        Me.LblArticulo.Size = New System.Drawing.Size(53, 13)
        Me.LblArticulo.TabIndex = 10
        Me.LblArticulo.Text = "Produc Id"
        '
        'TxtShipRegion
        '
        Me.TxtShipRegion.Location = New System.Drawing.Point(682, 88)
        Me.TxtShipRegion.Name = "TxtShipRegion"
        Me.TxtShipRegion.Size = New System.Drawing.Size(113, 20)
        Me.TxtShipRegion.TabIndex = 13
        '
        'LblShipCity
        '
        Me.LblShipCity.AutoSize = True
        Me.LblShipCity.Location = New System.Drawing.Point(352, 95)
        Me.LblShipCity.Name = "LblShipCity"
        Me.LblShipCity.Size = New System.Drawing.Size(45, 13)
        Me.LblShipCity.TabIndex = 12
        Me.LblShipCity.Text = "ShipCity"
        '
        'TxtAddress
        '
        Me.TxtAddress.Location = New System.Drawing.Point(110, 88)
        Me.TxtAddress.Name = "TxtAddress"
        Me.TxtAddress.Size = New System.Drawing.Size(199, 20)
        Me.TxtAddress.TabIndex = 11
        '
        'LblCountry
        '
        Me.LblCountry.AutoSize = True
        Me.LblCountry.Location = New System.Drawing.Point(350, 139)
        Me.LblCountry.Name = "LblCountry"
        Me.LblCountry.Size = New System.Drawing.Size(64, 13)
        Me.LblCountry.TabIndex = 15
        Me.LblCountry.Text = "ShipCountry"
        '
        'TxtShipCity
        '
        Me.TxtShipCity.Location = New System.Drawing.Point(415, 88)
        Me.TxtShipCity.Name = "TxtShipCity"
        Me.TxtShipCity.Size = New System.Drawing.Size(191, 20)
        Me.TxtShipCity.TabIndex = 5
        '
        'TabGeneral
        '
        Me.TabGeneral.Controls.Add(Me.TabPage1)
        Me.TabGeneral.Controls.Add(Me.TabPage2)
        Me.TabGeneral.Location = New System.Drawing.Point(1, 12)
        Me.TabGeneral.Name = "TabGeneral"
        Me.TabGeneral.SelectedIndex = 0
        Me.TabGeneral.Size = New System.Drawing.Size(930, 738)
        Me.TabGeneral.TabIndex = 5
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.BtnEliminar)
        Me.TabPage1.Controls.Add(Me.BtnAnular)
        Me.TabPage1.Controls.Add(Me.ChkSeleccionar)
        Me.TabPage1.Controls.Add(Me.BtnBuscar)
        Me.TabPage1.Controls.Add(Me.LblTotalregistros)
        Me.TabPage1.Controls.Add(Me.TxtBusca)
        Me.TabPage1.Controls.Add(Me.DgvListado)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(922, 712)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "LISTADO"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Location = New System.Drawing.Point(272, 484)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(76, 35)
        Me.BtnEliminar.TabIndex = 8
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'BtnAnular
        '
        Me.BtnAnular.Location = New System.Drawing.Point(161, 484)
        Me.BtnAnular.Name = "BtnAnular"
        Me.BtnAnular.Size = New System.Drawing.Size(76, 35)
        Me.BtnAnular.TabIndex = 7
        Me.BtnAnular.Text = "Anular"
        Me.BtnAnular.UseVisualStyleBackColor = True
        '
        'ChkSeleccionar
        '
        Me.ChkSeleccionar.AutoSize = True
        Me.ChkSeleccionar.Location = New System.Drawing.Point(26, 494)
        Me.ChkSeleccionar.Name = "ChkSeleccionar"
        Me.ChkSeleccionar.Size = New System.Drawing.Size(82, 17)
        Me.ChkSeleccionar.TabIndex = 3
        Me.ChkSeleccionar.Text = "Seleccionar"
        Me.ChkSeleccionar.UseVisualStyleBackColor = True
        '
        'BtnBuscar
        '
        Me.BtnBuscar.BackColor = System.Drawing.Color.PowderBlue
        Me.BtnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBuscar.Location = New System.Drawing.Point(584, 39)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(126, 37)
        Me.BtnBuscar.TabIndex = 2
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = False
        '
        'LblTotalregistros
        '
        Me.LblTotalregistros.AutoSize = True
        Me.LblTotalregistros.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotalregistros.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LblTotalregistros.Location = New System.Drawing.Point(622, 485)
        Me.LblTotalregistros.Name = "LblTotalregistros"
        Me.LblTotalregistros.Size = New System.Drawing.Size(43, 16)
        Me.LblTotalregistros.TabIndex = 1
        Me.LblTotalregistros.Text = "Total"
        '
        'TxtBusca
        '
        Me.TxtBusca.Location = New System.Drawing.Point(69, 49)
        Me.TxtBusca.Name = "TxtBusca"
        Me.TxtBusca.Size = New System.Drawing.Size(452, 20)
        Me.TxtBusca.TabIndex = 1
        '
        'DgvListado
        '
        Me.DgvListado.AllowUserToAddRows = False
        Me.DgvListado.AllowUserToDeleteRows = False
        Me.DgvListado.AllowUserToOrderColumns = True
        Me.DgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvListado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Seleccionar})
        Me.DgvListado.Location = New System.Drawing.Point(9, 124)
        Me.DgvListado.Name = "DgvListado"
        Me.DgvListado.ReadOnly = True
        Me.DgvListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvListado.Size = New System.Drawing.Size(906, 323)
        Me.DgvListado.TabIndex = 0
        '
        'Seleccionar
        '
        Me.Seleccionar.HeaderText = "Seleccionar"
        Me.Seleccionar.Name = "Seleccionar"
        Me.Seleccionar.ReadOnly = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.DtpShipped)
        Me.TabPage2.Controls.Add(Me.BtnCancelar)
        Me.TabPage2.Controls.Add(Me.TxtFreight)
        Me.TabPage2.Controls.Add(Me.LblFreight)
        Me.TabPage2.Controls.Add(Me.CmbShipVia)
        Me.TabPage2.Controls.Add(Me.LblShipVia)
        Me.TabPage2.Controls.Add(Me.CmbEmployee)
        Me.TabPage2.Controls.Add(Me.LblIdEmployee)
        Me.TabPage2.Controls.Add(Me.LblShippedDate)
        Me.TabPage2.Controls.Add(Me.LblRequiredDate)
        Me.TabPage2.Controls.Add(Me.DtpRequired)
        Me.TabPage2.Controls.Add(Me.BtnActualizar)
        Me.TabPage2.Controls.Add(Me.BtnGrabar)
        Me.TabPage2.Controls.Add(Me.LblOrderdate)
        Me.TabPage2.Controls.Add(Me.DtpOrderDate)
        Me.TabPage2.Controls.Add(Me.GbDetalle)
        Me.TabPage2.Controls.Add(Me.GBCabecera)
        Me.TabPage2.Controls.Add(Me.LblId)
        Me.TabPage2.Controls.Add(Me.TxtId)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(922, 712)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "GESTION ABM"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'BtnCancelar
        '
        Me.BtnCancelar.BackColor = System.Drawing.Color.PaleGreen
        Me.BtnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelar.Location = New System.Drawing.Point(497, 575)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(120, 43)
        Me.BtnCancelar.TabIndex = 5
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = False
        '
        'TxtFreight
        '
        Me.TxtFreight.Location = New System.Drawing.Point(630, 49)
        Me.TxtFreight.Name = "TxtFreight"
        Me.TxtFreight.Size = New System.Drawing.Size(142, 20)
        Me.TxtFreight.TabIndex = 22
        '
        'LblFreight
        '
        Me.LblFreight.AutoSize = True
        Me.LblFreight.Location = New System.Drawing.Point(552, 55)
        Me.LblFreight.Name = "LblFreight"
        Me.LblFreight.Size = New System.Drawing.Size(39, 13)
        Me.LblFreight.TabIndex = 21
        Me.LblFreight.Text = "Freigth"
        '
        'CmbShipVia
        '
        Me.CmbShipVia.FormattingEnabled = True
        Me.CmbShipVia.Location = New System.Drawing.Point(108, 90)
        Me.CmbShipVia.Name = "CmbShipVia"
        Me.CmbShipVia.Size = New System.Drawing.Size(114, 21)
        Me.CmbShipVia.TabIndex = 20
        '
        'LblShipVia
        '
        Me.LblShipVia.AutoSize = True
        Me.LblShipVia.Location = New System.Drawing.Point(37, 93)
        Me.LblShipVia.Name = "LblShipVia"
        Me.LblShipVia.Size = New System.Drawing.Size(44, 13)
        Me.LblShipVia.TabIndex = 19
        Me.LblShipVia.Text = "Shp Via"
        '
        'CmbEmployee
        '
        Me.CmbEmployee.FormattingEnabled = True
        Me.CmbEmployee.Location = New System.Drawing.Point(108, 49)
        Me.CmbEmployee.Name = "CmbEmployee"
        Me.CmbEmployee.Size = New System.Drawing.Size(114, 21)
        Me.CmbEmployee.TabIndex = 18
        '
        'LblIdEmployee
        '
        Me.LblIdEmployee.AutoSize = True
        Me.LblIdEmployee.Location = New System.Drawing.Point(37, 55)
        Me.LblIdEmployee.Name = "LblIdEmployee"
        Me.LblIdEmployee.Size = New System.Drawing.Size(65, 13)
        Me.LblIdEmployee.TabIndex = 17
        Me.LblIdEmployee.Text = "Id Employee"
        '
        'LblShippedDate
        '
        Me.LblShippedDate.AutoSize = True
        Me.LblShippedDate.Location = New System.Drawing.Point(253, 57)
        Me.LblShippedDate.Name = "LblShippedDate"
        Me.LblShippedDate.Size = New System.Drawing.Size(75, 13)
        Me.LblShippedDate.TabIndex = 16
        Me.LblShippedDate.Text = "Shipped  Date"
        '
        'LblRequiredDate
        '
        Me.LblRequiredDate.AutoSize = True
        Me.LblRequiredDate.Location = New System.Drawing.Point(541, 19)
        Me.LblRequiredDate.Name = "LblRequiredDate"
        Me.LblRequiredDate.Size = New System.Drawing.Size(76, 13)
        Me.LblRequiredDate.TabIndex = 14
        Me.LblRequiredDate.Text = "Required Date"
        '
        'DtpRequired
        '
        Me.DtpRequired.Location = New System.Drawing.Point(630, 13)
        Me.DtpRequired.Name = "DtpRequired"
        Me.DtpRequired.Size = New System.Drawing.Size(197, 20)
        Me.DtpRequired.TabIndex = 13
        '
        'BtnActualizar
        '
        Me.BtnActualizar.BackColor = System.Drawing.Color.LightSteelBlue
        Me.BtnActualizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnActualizar.Location = New System.Drawing.Point(326, 575)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.Size = New System.Drawing.Size(120, 43)
        Me.BtnActualizar.TabIndex = 7
        Me.BtnActualizar.Text = "Actualizar"
        Me.BtnActualizar.UseVisualStyleBackColor = False
        '
        'BtnGrabar
        '
        Me.BtnGrabar.BackColor = System.Drawing.Color.LightSkyBlue
        Me.BtnGrabar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGrabar.Location = New System.Drawing.Point(326, 575)
        Me.BtnGrabar.Name = "BtnGrabar"
        Me.BtnGrabar.Size = New System.Drawing.Size(120, 43)
        Me.BtnGrabar.TabIndex = 4
        Me.BtnGrabar.Text = "Grabar"
        Me.BtnGrabar.UseVisualStyleBackColor = False
        '
        'LblOrderdate
        '
        Me.LblOrderdate.AutoSize = True
        Me.LblOrderdate.Location = New System.Drawing.Point(253, 19)
        Me.LblOrderdate.Name = "LblOrderdate"
        Me.LblOrderdate.Size = New System.Drawing.Size(59, 13)
        Me.LblOrderdate.TabIndex = 12
        Me.LblOrderdate.Text = "Order Date"
        '
        'DtpOrderDate
        '
        Me.DtpOrderDate.Location = New System.Drawing.Point(329, 16)
        Me.DtpOrderDate.Name = "DtpOrderDate"
        Me.DtpOrderDate.Size = New System.Drawing.Size(199, 20)
        Me.DtpOrderDate.TabIndex = 11
        '
        'GbDetalle
        '
        Me.GbDetalle.Controls.Add(Me.PanelProductos)
        Me.GbDetalle.Controls.Add(Me.BtnEliminaProducto)
        Me.GbDetalle.Controls.Add(Me.Label2)
        Me.GbDetalle.Controls.Add(Me.TxtTotal)
        Me.GbDetalle.Controls.Add(Me.TxtProducts)
        Me.GbDetalle.Controls.Add(Me.BtnBuscarArticulo)
        Me.GbDetalle.Controls.Add(Me.LblArticulo)
        Me.GbDetalle.Controls.Add(Me.DgvDetalle)
        Me.GbDetalle.Location = New System.Drawing.Point(33, 302)
        Me.GbDetalle.Name = "GbDetalle"
        Me.GbDetalle.Size = New System.Drawing.Size(799, 267)
        Me.GbDetalle.TabIndex = 10
        Me.GbDetalle.TabStop = False
        Me.GbDetalle.Text = "Orders Details"
        '
        'BtnEliminaProducto
        '
        Me.BtnEliminaProducto.Location = New System.Drawing.Point(657, 21)
        Me.BtnEliminaProducto.Name = "BtnEliminaProducto"
        Me.BtnEliminaProducto.Size = New System.Drawing.Size(112, 21)
        Me.BtnEliminaProducto.TabIndex = 19
        Me.BtnEliminaProducto.Text = "Eliminar Producto"
        Me.BtnEliminaProducto.UseVisualStyleBackColor = True
        '
        'DgvDetalle
        '
        Me.DgvDetalle.AllowUserToAddRows = False
        Me.DgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvDetalle.Location = New System.Drawing.Point(45, 56)
        Me.DgvDetalle.Name = "DgvDetalle"
        Me.DgvDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvDetalle.Size = New System.Drawing.Size(706, 160)
        Me.DgvDetalle.TabIndex = 0
        '
        'GBCabecera
        '
        Me.GBCabecera.Controls.Add(Me.LblCountry)
        Me.GBCabecera.Controls.Add(Me.LblShipRegion)
        Me.GBCabecera.Controls.Add(Me.TxtShipRegion)
        Me.GBCabecera.Controls.Add(Me.LblShipCity)
        Me.GBCabecera.Controls.Add(Me.TxtAddress)
        Me.GBCabecera.Controls.Add(Me.LblShipName)
        Me.GBCabecera.Controls.Add(Me.TxtPostalCode)
        Me.GBCabecera.Controls.Add(Me.BtnBuscarCliente)
        Me.GBCabecera.Controls.Add(Me.LblPostaCode)
        Me.GBCabecera.Controls.Add(Me.TxtShipCountry)
        Me.GBCabecera.Controls.Add(Me.TxtShipCity)
        Me.GBCabecera.Controls.Add(Me.LblAddress)
        Me.GBCabecera.Controls.Add(Me.TxtShipName)
        Me.GBCabecera.Controls.Add(Me.TxtIdCustomer)
        Me.GBCabecera.Controls.Add(Me.LblCliente)
        Me.GBCabecera.Location = New System.Drawing.Point(32, 120)
        Me.GBCabecera.Name = "GBCabecera"
        Me.GBCabecera.Size = New System.Drawing.Size(801, 178)
        Me.GBCabecera.TabIndex = 9
        Me.GBCabecera.TabStop = False
        Me.GBCabecera.Text = "Customer"
        '
        'LblAddress
        '
        Me.LblAddress.AutoSize = True
        Me.LblAddress.Location = New System.Drawing.Point(22, 95)
        Me.LblAddress.Name = "LblAddress"
        Me.LblAddress.Size = New System.Drawing.Size(45, 13)
        Me.LblAddress.TabIndex = 3
        Me.LblAddress.Text = "Address"
        '
        'TxtShipName
        '
        Me.TxtShipName.Location = New System.Drawing.Point(330, 40)
        Me.TxtShipName.Name = "TxtShipName"
        Me.TxtShipName.Size = New System.Drawing.Size(276, 20)
        Me.TxtShipName.TabIndex = 2
        '
        'TxtIdCustomer
        '
        Me.TxtIdCustomer.Location = New System.Drawing.Point(112, 40)
        Me.TxtIdCustomer.Name = "TxtIdCustomer"
        Me.TxtIdCustomer.Size = New System.Drawing.Size(115, 20)
        Me.TxtIdCustomer.TabIndex = 1
        '
        'LblCliente
        '
        Me.LblCliente.AutoSize = True
        Me.LblCliente.Location = New System.Drawing.Point(22, 42)
        Me.LblCliente.Name = "LblCliente"
        Me.LblCliente.Size = New System.Drawing.Size(51, 13)
        Me.LblCliente.TabIndex = 0
        Me.LblCliente.Text = "Customer"
        '
        'LblId
        '
        Me.LblId.AutoSize = True
        Me.LblId.Location = New System.Drawing.Point(37, 16)
        Me.LblId.Name = "LblId"
        Me.LblId.Size = New System.Drawing.Size(50, 13)
        Me.LblId.TabIndex = 8
        Me.LblId.Text = "Id Orders"
        '
        'TxtId
        '
        Me.TxtId.Enabled = False
        Me.TxtId.Location = New System.Drawing.Point(109, 16)
        Me.TxtId.Name = "TxtId"
        Me.TxtId.Size = New System.Drawing.Size(113, 20)
        Me.TxtId.TabIndex = 6
        '
        'DtpShipped
        '
        Me.DtpShipped.Location = New System.Drawing.Point(329, 51)
        Me.DtpShipped.Name = "DtpShipped"
        Me.DtpShipped.Size = New System.Drawing.Size(199, 20)
        Me.DtpShipped.TabIndex = 23
        '
        'FrmOrders_OrdersDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(933, 705)
        Me.Controls.Add(Me.TabGeneral)
        Me.Name = "FrmOrders_OrdersDetails"
        Me.Text = "Gestión de Orders"
        Me.PanelProductos.ResumeLayout(False)
        Me.PanelProductos.PerformLayout()
        CType(Me.DgvArticuloManual, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabGeneral.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.DgvListado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.GbDetalle.ResumeLayout(False)
        Me.GbDetalle.PerformLayout()
        CType(Me.DgvDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBCabecera.ResumeLayout(False)
        Me.GBCabecera.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LblShipRegion As Label
    Friend WithEvents LblShipName As Label
    Friend WithEvents TxtPostalCode As TextBox
    Friend WithEvents BtnBuscarCliente As Button
    Friend WithEvents LblPostaCode As Label
    Friend WithEvents TxtShipCountry As TextBox
    Friend WithEvents PanelProductos As Panel
    Friend WithEvents BtnCerrar As Button
    Friend WithEvents LblTotalesManual As Label
    Friend WithEvents DgvArticuloManual As DataGridView
    Friend WithEvents BtnBuscarManual As Button
    Friend WithEvents TxtBuscarManual As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtTotal As TextBox
    Friend WithEvents TxtProducts As TextBox
    Friend WithEvents BtnBuscarArticulo As Button
    Friend WithEvents LblArticulo As Label
    Friend WithEvents TxtShipRegion As TextBox
    Friend WithEvents LblShipCity As Label
    Friend WithEvents TxtAddress As TextBox
    Friend WithEvents LblCountry As Label
    Friend WithEvents TxtShipCity As TextBox
    Friend WithEvents TabGeneral As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents BtnAnular As Button
    Friend WithEvents ChkSeleccionar As CheckBox
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents LblTotalregistros As Label
    Friend WithEvents TxtBusca As TextBox
    Friend WithEvents DgvListado As DataGridView
    Friend WithEvents Seleccionar As DataGridViewCheckBoxColumn
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TxtFreight As TextBox
    Friend WithEvents LblFreight As Label
    Friend WithEvents CmbShipVia As ComboBox
    Friend WithEvents LblShipVia As Label
    Friend WithEvents CmbEmployee As ComboBox
    Friend WithEvents LblIdEmployee As Label
    Friend WithEvents LblShippedDate As Label
    Friend WithEvents LblRequiredDate As Label
    Friend WithEvents DtpRequired As DateTimePicker
    Friend WithEvents LblOrderdate As Label
    Friend WithEvents DtpOrderDate As DateTimePicker
    Friend WithEvents GbDetalle As GroupBox
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents DgvDetalle As DataGridView
    Friend WithEvents BtnGrabar As Button
    Friend WithEvents BtnActualizar As Button
    Friend WithEvents GBCabecera As GroupBox
    Friend WithEvents LblAddress As Label
    Friend WithEvents TxtShipName As TextBox
    Friend WithEvents TxtIdCustomer As TextBox
    Friend WithEvents LblCliente As Label
    Friend WithEvents LblId As Label
    Friend WithEvents TxtId As TextBox
    Friend WithEvents BtnEliminaProducto As Button
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents DtpShipped As DateTimePicker
End Class
