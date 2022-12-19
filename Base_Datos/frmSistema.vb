Public Class frmSistema
    Private Sub ListarCompletoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListarCompletoToolStripMenuItem.Click
        frmDGV.Show()
    End Sub

    Private Sub ListarPaisToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListarPaisToolStripMenuItem.Click
        frmListarPais.Show()
    End Sub

    Private Sub AgregarNuevoClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarNuevoClienteToolStripMenuItem.Click
        frmNuevo_Cliente.Show()
    End Sub

    Private Sub EliminarClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarClienteToolStripMenuItem.Click
        frmEliminarCliente.Show()
    End Sub

    Private Sub ModificarDatosClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModificarDatosClienteToolStripMenuItem.Click
        frmModificar.Show()
    End Sub
End Class