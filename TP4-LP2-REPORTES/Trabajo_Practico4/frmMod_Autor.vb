Public Class frmMod_Autor
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        buscar(txtCodigo, txtNombre, "Autor", "IdAutor", btnBuscar)
    End Sub

    Private Sub txtCodigo_TextChanged(sender As Object, e As EventArgs) Handles txtCodigo.TextChanged
        If txtCodigo.Text = "" Then
            btnBuscar.Enabled = False
        Else
            btnBuscar.Enabled = True
        End If
    End Sub

    Private Sub txtNombre_TextChanged(sender As Object, e As EventArgs) Handles txtNombre.TextChanged
        If txtNombre.Text = "" Then
            btnGrabar.Enabled = False
        Else
            btnGrabar.Enabled = True
        End If
    End Sub

    Private Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        grabar("Autor", "IdAutor", txtCodigo, txtNombre)
    End Sub
End Class