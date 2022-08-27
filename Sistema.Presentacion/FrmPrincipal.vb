Public Class FrmPrincipal
    Private Sub CRUDToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CRUDToolStripMenuItem.Click

    End Sub


    Private Sub ORDERSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ORDERSToolStripMenuItem.Click
        FrmOrders_OrdersDetails.Show()
    End Sub

    Private Sub PORFECHASToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PORFECHASToolStripMenuItem.Click
        FrmConsultaFechasOrders.ShowDialog()
    End Sub

    Private Sub PORCUSTOMERSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PORCUSTOMERSToolStripMenuItem.Click
        FrmConsultaOrdersCustomers.ShowDialog()
    End Sub

    Private Sub POREMPLOYEESToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles POREMPLOYEESToolStripMenuItem.Click
        FrmConsultaOrdersEmployees.ShowDialog()
    End Sub

    Private Sub SALIRToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SALIRToolStripMenuItem.Click
        Close()

    End Sub
End Class