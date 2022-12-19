Imports System.Data.OleDb
Public Class frmEliminarCliente
    Private Sub frmEliminarCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Listar_Combo()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            conexion.ConnectionString = cadena_conexion
            conexion.Open()

            comando.Connection = conexion
            comando.CommandType = CommandType.Text
            comando.CommandText = "Delete * from autor where IdAutor = " & cmbNombre.SelectedValue
            comando.ExecuteReader()

            conexion.Close()
            MessageBox.Show("Nombre Eliminado Correctamente")
            Listar_Combo()
        Catch
            MessageBox.Show(ErrorToString)
        End Try
    End Sub
    Private Sub Listar_Combo()
        Try
            conexion.ConnectionString = cadena_conexion
            conexion.Open()

            comando.Connection = conexion
            comando.CommandType = CommandType.TableDirect
            comando.CommandText = "Autor"

            adaptador = New OleDbDataAdapter(comando)
            ds = New DataSet 'pasamos los datos a la memoria RAM
            adaptador.Fill(ds)

            'llenamos el combobox
            cmbNombre.DataSource = ds.Tables(0)
            cmbNombre.ValueMember = "IdAutor" 'dato que esta pero no se ve
            cmbNombre.DisplayMember = "Nombre" 'este dato si se ve 
            conexion.Close()
        Catch
            MessageBox.Show(ErrorToString)
        End Try
    End Sub
End Class