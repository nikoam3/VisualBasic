Imports System.Data.OleDb
Imports System.IO
Public Class frmPrincipal

    Public conexion As New OleDb.OleDbConnection
    Public comando As New OleDb.OleDbCommand
    Public adaptador As New OleDb.OleDbDataAdapter
    Public base As String = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source=Libreria_2.mdb"

    Public ds As DataSet
    Public dr As OleDbDataReader

    Private Sub frmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conexion.ConnectionString = base
            conexion.Open()

            comando.Connection = conexion
            comando.CommandType = CommandType.TableDirect
            comando.CommandText = "Idioma"

            adaptador = New OleDbDataAdapter(comando)
            ds = New DataSet
            adaptador.Fill(ds)

            cmbNombre.DataSource = ds.Tables(0)
            cmbNombre.ValueMember = "IdIdioma"
            cmbNombre.DisplayMember = "Nombre"
            conexion.Close()
        Catch
            MessageBox.Show(ErrorToString)
        End Try
    End Sub

    Private Sub btnListar_Click(sender As Object, e As EventArgs) Handles btnListar.Click
        Try
            Dim cant As Integer = 0
            Dim precio_total As Decimal = 0
            Dim total As Decimal = 0

            dgvDatos.Rows.Clear()

            conexion.ConnectionString = base
            conexion.Open()
            comando.Connection = conexion
            comando.CommandType = CommandType.TableDirect
            comando.CommandText = "Libro"

            dr = comando.ExecuteReader
            If dr.HasRows Then
                Do While dr.Read
                    If cmbNombre.SelectedValue = dr("IdIdioma") Then
                        precio_total = dr("Cantidad") * dr("Precio")

                        dgvDatos.Rows.Add(dr("Titulo"), dr("Cantidad"), dr("Año"),
                                              dr("Precio"), precio_total)
                        cant += 1
                        total += precio_total
                    End If
                Loop
            End If
            conexion.Close()
            txtCant.Text = cant
            txtTotal.Text = total
        Catch
            MessageBox.Show(ErrorToString)
        End Try
    End Sub

    Private Sub btnExportar_Click_1(sender As Object, e As EventArgs) Handles btnExportar.Click
        Try
            Dim cant As Integer = 0
            Dim precio_total As Decimal = 0
            Dim total As Decimal = 0

            conexion.ConnectionString = base
            conexion.Open()

            comando.Connection = conexion
            comando.CommandType = CommandType.TableDirect
            comando.CommandText = "Libro"

            dr = comando.ExecuteReader

            Dim ExporCSV = New StreamWriter("Exportar_Idiomas_CSV.csv", False, System.Text.Encoding.UTF8)
            ExporCSV.WriteLine("Titulo;Año;Stock;Precio Unitario;Precio Total")
            If dr.HasRows Then
                Do While dr.Read
                    If cmbNombre.SelectedValue = dr("IdIdioma") Then
                        precio_total = dr("Cantidad") * dr("Precio")

                        ExporCSV.Write(dr("Titulo"))
                        ExporCSV.Write(";")
                        ExporCSV.Write(dr("Año"))
                        ExporCSV.Write(";")
                        ExporCSV.Write(dr("Cantidad"))
                        ExporCSV.Write(";")
                        ExporCSV.Write(dr("Precio"))
                        ExporCSV.Write(";")
                        ExporCSV.WriteLine(precio_total)
                        cant += 1
                        total += precio_total
                    End If
                Loop
                ExporCSV.WriteLine("")
                ExporCSV.Write("Cantidad de libros:")
                ExporCSV.Write(";")
                ExporCSV.WriteLine(cant)
                ExporCSV.Write("Total Importes:")
                ExporCSV.Write(";")
                ExporCSV.WriteLine(total)
            End If
            ExporCSV.WriteLine("")
            ExporCSV.Close()
            conexion.Close()
            MessageBox.Show("Datos Exportados Correctamente!")
        Catch
            MessageBox.Show(ErrorToString)
        End Try
    End Sub
    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        PrintDialog1.ShowDialog() 'muestra la ventana de windows para imprimir
        PrintDocument1.PrinterSettings = PrintDialog1.PrinterSettings 'el documento toma la impresora que seleccionamos en la ventada de windows
        PrintDocument1.Print() 'imprime documento

    End Sub
    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim titulo As New Font("Arial", 18)
        Dim columna As New Font("Arial", 14)
        Dim letra As New Font("Arial", 12)
        Dim fila As Integer = 115
        Dim cant As Integer = 0
        Dim precio_total As Decimal = 0
        Dim total As Decimal = 0


        e.Graphics.DrawString(("Listado por Idioma: " & cmbNombre.Text), titulo, Brushes.Black, 80, 50) 'con esa funcion escribo en la impresion
        e.Graphics.DrawString("Titulo", columna, Brushes.Black, 30, 50) 'con esa funcion escribo en la impresion
        e.Graphics.DrawString("Año", columna, Brushes.Black, 180, 100) 'con esa funcion escribo en la impresion
        e.Graphics.DrawString("Cantidad", columna, Brushes.Black, 320, 100) 'con esa funcion escribo en la impresion
        e.Graphics.DrawString("Precio", columna, Brushes.Black, 480, 100) 'con esa funcion escribo en la impresion
        e.Graphics.DrawString("Precio Total", columna, Brushes.Black, 630, 100) 'con esa funcion escribo en la impresion

        conexion.ConnectionString = base
        conexion.Open()
        comando.Connection = conexion
        comando.CommandType = CommandType.TableDirect
        comando.CommandText = "Libro"

        dr = comando.ExecuteReader
        If dr.HasRows Then
            Do While dr.Read
                If cmbNombre.SelectedValue = dr("IdIdioma") Then
                    precio_total = dr("Cantidad") * dr("Precio")
                    e.Graphics.DrawString(dr("Titulo"), letra, Brushes.Black, 50, fila) 'con esa funcion escribo en la impresion
                    e.Graphics.DrawString(dr("Año"), letra, Brushes.Black, 200, fila) 'con esa funcion escribo en la impresion
                    e.Graphics.DrawString(dr("Cantidad"), letra, Brushes.Black, 350, fila) 'con esa funcion escribo en la impresion
                    e.Graphics.DrawString(dr("Precio"), letra, Brushes.Black, 500, fila) 'con esa funcion escribo en la impresion
                    e.Graphics.DrawString(precio_total, letra, Brushes.Black, 650, fila) 'con esa funcion escribo en la impresion
                    total += precio_total
                    fila += 15
                    cant += 1
                End If
            Loop
        End If
        conexion.Close()
        e.Graphics.DrawString("Total Stock: " & cant, columna, Brushes.Black, 50, fila) 'con esa funcion escribo en la impresion
        fila += 15
        e.Graphics.DrawString("Total Importes" & total, columna, Brushes.Black, 50, fila) 'con esa funcion escribo en la impresion
    End Sub
End Class



