Public Class frmAgre_Libro
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        agregar_titulo(txtNombre, txtAnio, txtCant,
                       txtPrecio, txtIdAutor, txtIdIdioma, txtIdPais)
    End Sub

    Private Sub txtNombre_TextChanged(sender As Object, e As EventArgs) Handles txtNombre.TextChanged
        btn()
    End Sub
    Private Sub txtAnio_TextChanged(sender As Object, e As EventArgs) Handles txtAnio.TextChanged
        btn()
    End Sub

    Private Sub txtCant_TextChanged(sender As Object, e As EventArgs) Handles txtCant.TextChanged
        btn()
    End Sub

    Private Sub txtPrecio_TextChanged(sender As Object, e As EventArgs) Handles txtPrecio.TextChanged
        btn()
    End Sub

    Private Sub txtIdAutor_TextChanged(sender As Object, e As EventArgs) Handles txtIdAutor.TextChanged
        btn()
    End Sub

    Private Sub txtIdIdioma_TextChanged(sender As Object, e As EventArgs) Handles txtIdIdioma.TextChanged
        btn()
    End Sub

    Private Sub txtIdPais_TextChanged(sender As Object, e As EventArgs) Handles txtIdPais.TextChanged
        btn()
    End Sub
    Private Sub btn()
        If txtNombre.Text = "" Or txtAnio.Text = "" Or txtCant.Text = "" Or
        txtPrecio.Text = "" Or txtIdAutor.Text = "" Or txtIdIdioma.Text = "" Or
        txtIdPais.Text = "" Then

            btnAgregar.Enabled = False
        Else
            btnAgregar.Enabled = True
        End If
    End Sub
End Class