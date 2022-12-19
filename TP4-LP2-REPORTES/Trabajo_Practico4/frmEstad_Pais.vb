Public Class frmEstad_Pais
    Private Sub btnListar_Click(sender As Object, e As EventArgs) Handles btnListar.Click
        listar_estad("Pais", "IdPais", dgvEstad, txtListados, txtTotalCant, txtTotalPrecios)
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        frmGraf_Pais.Show()
    End Sub

    Private Sub btnExportar_Click(sender As Object, e As EventArgs) Handles btnExportar.Click
        exportar_estad("Pais", "IdPais")
    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        PrintDialog_estad.ShowDialog()
        PrintDocument_estad.PrinterSettings = PrintDialog_estad.PrinterSettings
        PrintDocument_estad.Print()
    End Sub

    Private Sub PrintDocument_estad_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument_estad.PrintPage
        Dim titulo As New Font("Arial", 18)
        Dim columna As New Font("Arial", 14)
        Dim letra As New Font("Arial", 12)
        Dim fila As Integer = 130
        Dim cantidad As Integer = 0
        Dim precio As Decimal = 0
        Dim total As Decimal = 0
        Dim listados As Integer = 0
        Dim total_cant As Integer = 0
        Dim total_precio As Decimal = 0

        e.Graphics.DrawString("Estadisticas de Paises", titulo, Brushes.Black, 80, 50)
        e.Graphics.DrawString("Pais", columna, Brushes.Black, 50, 100)
        e.Graphics.DrawString("Cantidad", columna, Brushes.Black, 400, 100)
        e.Graphics.DrawString("Precio", columna, Brushes.Black, 500, 100)
        e.Graphics.DrawString("Total $ Stock", columna, Brushes.Black, 600, 100)

        conexion.ConnectionString = base
        conexion.Open()
        comando.Connection = conexion
        comando.CommandType = CommandType.TableDirect
        comando.CommandText = "Pais"

        dr = comando.ExecuteReader
        If dr.HasRows Then
            Do While dr.Read
                cantidad = buscar_idcantidad("Libro", "IdPais", dr("IdPais"))
                precio = buscar_idprecio("Libro", "IdPais", dr("IdPais"))
                total = cantidad * precio

                e.Graphics.DrawString(dr("Nombre"), letra, Brushes.Black, 50, fila)
                e.Graphics.DrawString(cantidad, letra, Brushes.Black, 400, fila)
                e.Graphics.DrawString(precio, letra, Brushes.Black, 500, fila)
                e.Graphics.DrawString(total, letra, Brushes.Black, 600, fila)
                fila += 20
                listados += 1
                total_cant += cantidad
                total_precio += total
            Loop
        End If
        fila += 20
        e.Graphics.DrawString("Listados: " & listados, letra, Brushes.Black, 50, fila)
        fila += 20
        e.Graphics.DrawString("Total Cantidad: " & total_cant, letra, Brushes.Black, 50, fila)
        fila += 20
        e.Graphics.DrawString("Total Precios: $" & total_precio, letra, Brushes.Black, 50, fila)

        conexion.Close()
    End Sub
End Class