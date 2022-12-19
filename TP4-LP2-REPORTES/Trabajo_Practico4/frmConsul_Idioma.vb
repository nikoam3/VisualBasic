Public Class frmConsul_Idioma
    Private Sub frmConsul_Idioma_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Combo_Box(cmbConsulta, "IDioma", "IdIdioma")
    End Sub

    Private Sub btnListar_Click(sender As Object, e As EventArgs) Handles btnListar.Click
        listar_consultas(txtCant, dgvConsul, cmbConsulta, "Idioma", "IdIdioma")
    End Sub

    Private Sub btnExportar_Click(sender As Object, e As EventArgs) Handles btnExportar.Click
        exportar_consul(cmbConsulta, "IdIdioma")
    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        PrintDialog_consul.ShowDialog()
        PrintDocument_consul.PrinterSettings = PrintDialog_consul.PrinterSettings
        PrintDocument_consul.Print()
    End Sub

    Private Sub PrintDocument_consul_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument_consul.PrintPage
        Dim titulo As New Font("Arial", 18)
        Dim columna As New Font("Arial", 14)
        Dim letra As New Font("Arial", 12)
        Dim fila As Integer = 130
        Dim total As Integer = 0

        e.Graphics.DrawString("Consulta de Idiomas", titulo, Brushes.Black, 80, 50)
        e.Graphics.DrawString("ID Libro", columna, Brushes.Black, 50, 100)
        e.Graphics.DrawString("Titulo", columna, Brushes.Black, 150, 100)
        e.Graphics.DrawString("Año", columna, Brushes.Black, 600, 100)
        e.Graphics.DrawString("ID Idioma", columna, Brushes.Black, 700, 100)

        conexion.ConnectionString = base
        conexion.Open()
        comando.Connection = conexion
        comando.CommandType = CommandType.TableDirect
        comando.CommandText = "Libro"

        dr = comando.ExecuteReader
        If dr.HasRows Then
            Do While dr.Read
                If dr("IdIdioma") = cmbConsulta.SelectedValue Then
                    e.Graphics.DrawString(dr("IdLibro"), letra, Brushes.Black, 50, fila)
                    e.Graphics.DrawString(dr("Titulo"), letra, Brushes.Black, 150, fila)
                    e.Graphics.DrawString(dr("Año"), letra, Brushes.Black, 600, fila)
                    e.Graphics.DrawString(dr("IdIdioma"), letra, Brushes.Black, 700, fila)
                    fila += 20
                    total += 1
                End If
            Loop
        End If
        conexion.Close()
        fila += 20
        e.Graphics.DrawString("Total Consultados: " & total, columna, Brushes.Black, 50, 100)

    End Sub
End Class