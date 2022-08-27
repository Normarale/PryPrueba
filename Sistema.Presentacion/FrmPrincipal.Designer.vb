<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPrincipal
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CRUDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ORDERSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LISTADOSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ENTREFECHASToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PORFECHASToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PORCUSTOMERSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.POREMPLOYEESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SALIRToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackgroundImage = Global.Sistema.Presentacion.My.Resources.Resources.Barco
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CRUDToolStripMenuItem, Me.LISTADOSToolStripMenuItem, Me.SALIRToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CRUDToolStripMenuItem
        '
        Me.CRUDToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ORDERSToolStripMenuItem})
        Me.CRUDToolStripMenuItem.Name = "CRUDToolStripMenuItem"
        Me.CRUDToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.CRUDToolStripMenuItem.Text = "GESTION "
        '
        'ORDERSToolStripMenuItem
        '
        Me.ORDERSToolStripMenuItem.Name = "ORDERSToolStripMenuItem"
        Me.ORDERSToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.ORDERSToolStripMenuItem.Text = "ORDERS"
        '
        'LISTADOSToolStripMenuItem
        '
        Me.LISTADOSToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ENTREFECHASToolStripMenuItem})
        Me.LISTADOSToolStripMenuItem.Name = "LISTADOSToolStripMenuItem"
        Me.LISTADOSToolStripMenuItem.Size = New System.Drawing.Size(73, 20)
        Me.LISTADOSToolStripMenuItem.Text = "LISTADOS "
        '
        'ENTREFECHASToolStripMenuItem
        '
        Me.ENTREFECHASToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PORFECHASToolStripMenuItem, Me.PORCUSTOMERSToolStripMenuItem, Me.POREMPLOYEESToolStripMenuItem})
        Me.ENTREFECHASToolStripMenuItem.Name = "ENTREFECHASToolStripMenuItem"
        Me.ENTREFECHASToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ENTREFECHASToolStripMenuItem.Text = "ORDERS"
        '
        'PORFECHASToolStripMenuItem
        '
        Me.PORFECHASToolStripMenuItem.Name = "PORFECHASToolStripMenuItem"
        Me.PORFECHASToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.PORFECHASToolStripMenuItem.Text = "POR FECHAS"
        '
        'PORCUSTOMERSToolStripMenuItem
        '
        Me.PORCUSTOMERSToolStripMenuItem.Name = "PORCUSTOMERSToolStripMenuItem"
        Me.PORCUSTOMERSToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.PORCUSTOMERSToolStripMenuItem.Text = "POR CUSTOMERS"
        '
        'POREMPLOYEESToolStripMenuItem
        '
        Me.POREMPLOYEESToolStripMenuItem.Name = "POREMPLOYEESToolStripMenuItem"
        Me.POREMPLOYEESToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.POREMPLOYEESToolStripMenuItem.Text = "POR EMPLOYEES"
        '
        'SALIRToolStripMenuItem
        '
        Me.SALIRToolStripMenuItem.Name = "SALIRToolStripMenuItem"
        Me.SALIRToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.SALIRToolStripMenuItem.Text = "SALIR"
        '
        'FrmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Sistema.Presentacion.My.Resources.Resources.Barco
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FrmPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CRUDToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LISTADOSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ENTREFECHASToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ORDERSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PORFECHASToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PORCUSTOMERSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents POREMPLOYEESToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SALIRToolStripMenuItem As ToolStripMenuItem
End Class
