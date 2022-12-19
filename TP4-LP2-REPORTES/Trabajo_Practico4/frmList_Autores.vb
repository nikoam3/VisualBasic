Imports System.Data.OleDb
Imports System.IO
Public Class frmList_Autores
    Private Sub btnListar_Click(sender As Object, e As EventArgs) Handles btnListar.Click
        listar(dgvDatos, "Autor", "IdAutor")
    End Sub

    Private Sub btnExportar_Click(sender As Object, e As EventArgs) Handles btnExportar.Click
        exportar("Autor", "IdAutor")
    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        PrintDialog_lista.ShowDialog()
        PrintDocument_lista.PrinterSettings = PrintDialog_lista.PrinterSettings
        PrintDocument_lista.Print()
    End Sub

    Private Sub PrintDocument_lista_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument_lista.PrintPage
        Dim titulo As New Font("Arial", 18)
        Dim columna As New Font("Arial", 14)
        Dim letra As New Font("Arial", 12)
        Dim fila As Integer = 130


        e.Graphics.DrawString(("Listado por Autores"), titulo, Brushes.Black, 80, 50)
        e.Graphics.DrawString("Autor", columna, Brushes.Black, 50, 100)
        e.Graphics.DrawString("ID", columna, Brushes.Black, 300, 100)

        conexion.ConnectionString = base
        conexion.Open()
        comando.Connection = conexion
        comando.CommandType = CommandType.TableDirect
        comando.CommandText = "Autor"

        dr = comando.ExecuteReader
        If dr.HasRows Then
            Do While dr.Read
                e.Graphics.DrawString(dr("Nombre"), letra, Brushes.Black, 50, fila)
                e.Graphics.DrawString(dr("IdAutor"), letra, Brushes.Black, 300, fila)
                fila += 20
            Loop
        End If
        conexion.Close()
    End Sub
End Class