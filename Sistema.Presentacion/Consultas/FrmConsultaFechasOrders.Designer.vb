<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConsultaFechasOrders
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
        Me.TabGeneral = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DtpHasta = New System.Windows.Forms.DateTimePicker()
        Me.LblDesde = New System.Windows.Forms.Label()
        Me.DtpDesde = New System.Windows.Forms.DateTimePicker()
        Me.PanelMostrar = New System.Windows.Forms.Panel()
        Me.BtnCerrarMostrar = New System.Windows.Forms.Button()
        Me.TxtMostrarTotal = New System.Windows.Forms.TextBox()
        Me.LblMostrarTotal = New System.Windows.Forms.Label()
        Me.DgvMostrar = New System.Windows.Forms.DataGridView()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.LblTotalregistros = New System.Windows.Forms.Label()
        Me.DgvListado = New System.Windows.Forms.DataGridView()
        Me.Seleccionar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.TabGeneral.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.PanelMostrar.SuspendLayout()
        CType(Me.DgvMostrar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvListado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabGeneral
        '
        Me.TabGeneral.Controls.Add(Me.TabPage1)
        Me.TabGeneral.Location = New System.Drawing.Point(12, 12)
        Me.TabGeneral.Name = "TabGeneral"
        Me.TabGeneral.SelectedIndex = 0
        Me.TabGeneral.Size = New System.Drawing.Size(930, 738)
        Me.TabGeneral.TabIndex = 5
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.DtpHasta)
        Me.TabPage1.Controls.Add(Me.LblDesde)
        Me.TabPage1.Controls.Add(Me.DtpDesde)
        Me.TabPage1.Controls.Add(Me.PanelMostrar)
        Me.TabPage1.Controls.Add(Me.BtnBuscar)
        Me.TabPage1.Controls.Add(Me.LblTotalregistros)
        Me.TabPage1.Controls.Add(Me.DgvListado)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(922, 712)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "LISTADO"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(362, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Fecha Hasta"
        '
        'DtpHasta
        '
        Me.DtpHasta.Location = New System.Drawing.Point(439, 45)
        Me.DtpHasta.Name = "DtpHasta"
        Me.DtpHasta.Size = New System.Drawing.Size(217, 20)
        Me.DtpHasta.TabIndex = 9
        '
        'LblDesde
        '
        Me.LblDesde.AutoSize = True
        Me.LblDesde.Location = New System.Drawing.Point(29, 52)
        Me.LblDesde.Name = "LblDesde"
        Me.LblDesde.Size = New System.Drawing.Size(71, 13)
        Me.LblDesde.TabIndex = 8
        Me.LblDesde.Text = "Fecha Desde"
        '
        'DtpDesde
        '
        Me.DtpDesde.Location = New System.Drawing.Point(106, 46)
        Me.DtpDesde.Name = "DtpDesde"
        Me.DtpDesde.Size = New System.Drawing.Size(217, 20)
        Me.DtpDesde.TabIndex = 7
        '
        'PanelMostrar
        '
        Me.PanelMostrar.BackColor = System.Drawing.Color.AntiqueWhite
        Me.PanelMostrar.Controls.Add(Me.BtnCerrarMostrar)
        Me.PanelMostrar.Controls.Add(Me.TxtMostrarTotal)
        Me.PanelMostrar.Controls.Add(Me.LblMostrarTotal)
        Me.PanelMostrar.Controls.Add(Me.DgvMostrar)
        Me.PanelMostrar.Location = New System.Drawing.Point(235, 167)
        Me.PanelMostrar.Name = "PanelMostrar"
        Me.PanelMostrar.Size = New System.Drawing.Size(680, 312)
        Me.PanelMostrar.TabIndex = 4
        Me.PanelMostrar.Visible = False
        '
        'BtnCerrarMostrar
        '
        Me.BtnCerrarMostrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCerrarMostrar.ForeColor = System.Drawing.Color.Red
        Me.BtnCerrarMostrar.Location = New System.Drawing.Point(604, 15)
        Me.BtnCerrarMostrar.Name = "BtnCerrarMostrar"
        Me.BtnCerrarMostrar.Size = New System.Drawing.Size(54, 31)
        Me.BtnCerrarMostrar.TabIndex = 7
        Me.BtnCerrarMostrar.Text = "X"
        Me.BtnCerrarMostrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BtnCerrarMostrar.UseVisualStyleBackColor = True
        '
        'TxtMostrarTotal
        '
        Me.TxtMostrarTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMostrarTotal.Location = New System.Drawing.Point(453, 259)
        Me.TxtMostrarTotal.Name = "TxtMostrarTotal"
        Me.TxtMostrarTotal.Size = New System.Drawing.Size(161, 21)
        Me.TxtMostrarTotal.TabIndex = 6
        Me.TxtMostrarTotal.Text = "0"
        '
        'LblMostrarTotal
        '
        Me.LblMostrarTotal.AutoSize = True
        Me.LblMostrarTotal.Location = New System.Drawing.Point(387, 267)
        Me.LblMostrarTotal.Name = "LblMostrarTotal"
        Me.LblMostrarTotal.Size = New System.Drawing.Size(34, 13)
        Me.LblMostrarTotal.TabIndex = 3
        Me.LblMostrarTotal.Text = "Total "
        '
        'DgvMostrar
        '
        Me.DgvMostrar.AllowUserToAddRows = False
        Me.DgvMostrar.AllowUserToDeleteRows = False
        Me.DgvMostrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvMostrar.Location = New System.Drawing.Point(25, 52)
        Me.DgvMostrar.Name = "DgvMostrar"
        Me.DgvMostrar.ReadOnly = True
        Me.DgvMostrar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvMostrar.Size = New System.Drawing.Size(633, 172)
        Me.DgvMostrar.TabIndex = 0
        '
        'BtnBuscar
        '
        Me.BtnBuscar.BackColor = System.Drawing.Color.DodgerBlue
        Me.BtnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBuscar.Location = New System.Drawing.Point(737, 39)
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
        Me.LblTotalregistros.Location = New System.Drawing.Point(623, 503)
        Me.LblTotalregistros.Name = "LblTotalregistros"
        Me.LblTotalregistros.Size = New System.Drawing.Size(43, 16)
        Me.LblTotalregistros.TabIndex = 1
        Me.LblTotalregistros.Text = "Total"
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
        'FrmConsultaFechasOrders
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(921, 653)
        Me.Controls.Add(Me.TabGeneral)
        Me.Name = "FrmConsultaFechasOrders"
        Me.Text = "Orders por Fecha"
        Me.TabGeneral.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.PanelMostrar.ResumeLayout(False)
        Me.PanelMostrar.PerformLayout()
        CType(Me.DgvMostrar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvListado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabGeneral As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Label1 As Label
    Friend WithEvents DtpHasta As DateTimePicker
    Friend WithEvents LblDesde As Label
    Friend WithEvents DtpDesde As DateTimePicker
    Friend WithEvents PanelMostrar As Panel
    Friend WithEvents BtnCerrarMostrar As Button
    Friend WithEvents TxtMostrarTotal As TextBox
    Friend WithEvents LblMostrarTotal As Label
    Friend WithEvents DgvMostrar As DataGridView
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents LblTotalregistros As Label
    Friend WithEvents DgvListado As DataGridView
    Friend WithEvents Seleccionar As DataGridViewCheckBoxColumn
End Class
