Public Class frmSistema
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub
    Private Sub AcercaDeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcercaDeToolStripMenuItem.Click
        frmAcerca.Show()
    End Sub

    Private Sub LibrosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LibrosToolStripMenuItem.Click
        frmList_Libros.Show()
    End Sub

    Private Sub AutoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AutoresToolStripMenuItem.Click
        frmList_Autores.Show()
    End Sub

    Private Sub IdiomasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IdiomasToolStripMenuItem.Click
        frmList_Idiomas.Show()
    End Sub

    Private Sub PaísesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PaísesToolStripMenuItem.Click
        frmList_Paises.Show()
    End Sub

    Private Sub LibrosDeUnAutorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LibrosDeUnAutorToolStripMenuItem.Click
        frmConsul_Autor.Show()
    End Sub

    Private Sub LibrosDeUnIdiomaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LibrosDeUnIdiomaToolStripMenuItem.Click
        frmConsul_Idioma.Show()
    End Sub

    Private Sub LibrosDeUnPaísToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LibrosDeUnPaísToolStripMenuItem.Click
        frmConsul_Pais.Show()
    End Sub

    Private Sub LibrosPorAutorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LibrosPorAutorToolStripMenuItem.Click
        frmEstad_Autor.Show()
    End Sub

    Private Sub LibrosPorIdiomaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LibrosPorIdiomaToolStripMenuItem.Click
        frmEstad_Idioma.Show()
    End Sub

    Private Sub LibrosPorPaísToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LibrosPorPaísToolStripMenuItem.Click
        frmEstad_Pais.Show()
    End Sub

    Private Sub AutorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AutorToolStripMenuItem.Click
        frmAgre_Autor.Show()
    End Sub

    Private Sub IdiomaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IdiomaToolStripMenuItem.Click
        frmAgre_Idioma.Show()
    End Sub

    Private Sub LibrosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles LibrosToolStripMenuItem1.Click
        frmAgre_Libro.Show()
    End Sub

    Private Sub PaísToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PaísToolStripMenuItem.Click
        frmAgre_Pais.Show()
    End Sub

    Private Sub AutorToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AutorToolStripMenuItem1.Click
        frmMod_Autor.Show()
    End Sub

    Private Sub IdiomaToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles IdiomaToolStripMenuItem1.Click
        frmMod_Idioma.Show()
    End Sub

    Private Sub LibrosToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles LibrosToolStripMenuItem2.Click
        frmMod_Libro.Show()
    End Sub

    Private Sub PaisToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PaisToolStripMenuItem.Click
        frmMod_Pais.Show()
    End Sub
End Class
