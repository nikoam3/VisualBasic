Imports System.Data.OleDb
Public Class frmNuevo_Cliente
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Try
            conexion.ConnectionString = cadena_conexion
            conexion.Open()

            comando.Connection = conexion
            comando.CommandType = CommandType.TableDirect
            comando.CommandText = "Autor"

            adaptador = New OleDbDataAdapter(comando)
            ds = New DataSet 'pasamos los datos a la memoria RAM
            adaptador.Fill(ds) 'fill = rellanar

            Dim tabla As DataTable = ds.Tables(0)
            Dim fila As DataRow = tabla.NewRow()
            fila("Nombre") = txtNombre.Text
            tabla.Rows.Add(fila)

            Dim comando_grabar As New OleDbCommandBuilder(adaptador)
            adaptador.Update(ds)
            conexion.Close()
            MessageBox.Show("Carga Completa")
        Catch
            MessageBox.Show(ErrorToString)
        End Try
    End Sub
End Class