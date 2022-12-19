Public Class frmAgre_Pais
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        agregar_nombre("Pais", txtNombre)
    End Sub

    Private Sub txtNombre_TextChanged(sender As Object, e As EventArgs) Handles txtNombre.TextChanged
        If txtNombre.Text = "" Then
            btnAgregar.Enabled = False
        Else
            btnAgregar.Enabled = True
        End If
    End Sub
End Class