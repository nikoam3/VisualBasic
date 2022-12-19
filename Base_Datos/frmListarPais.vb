Imports System.Data.OleDb
Public Class frmListarPais
    Private Sub frmSistema_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conexion.ConnectionString = cadena_conexion
            conexion.Open()

            comando.Connection = conexion
            comando.CommandType = CommandType.TableDirect
            comando.CommandText = "Pais"

            adaptador = New OleDbDataAdapter(comando)
            ds = New DataSet 'pasamos los datos a la memoria RAM
            adaptador.Fill(ds)

            'llenamos el combobox
            cmbPais.DataSource = ds.Tables(0)
            cmbPais.ValueMember = "IdPais" 'dato que esta pero no se ve
            cmbPais.DisplayMember = "Nombre" 'este dato si se ve 
            conexion.Close()
        Catch
            MessageBox.Show(ErrorToString)
        End Try
    End Sub
    Private Sub btnListar_Click(sender As Object, e As EventArgs) Handles btnListar.Click
        Dim total As Decimal = 0
        Dim suma_total As Decimal = 0

        dgvDatos.Rows.Clear()
        Try
            conexion.ConnectionString = cadena_conexion
            conexion.Open()

            comando.Connection = conexion
            comando.CommandType = CommandType.TableDirect
            comando.CommandText = "Libro"

            dr = comando.ExecuteReader 'trae datos por fila

            If dr.HasRows Then 'devuelve booleano dependiendo de si tiene filas

                Do While dr.Read 'avanza en uno el registro de datos
                    If dr("IdPais") = cmbPais.SelectedValue Then
                        total = dr("Cantidad") * dr("Precio")
                        dgvDatos.Rows.Add(dr("Titulo"), dr("Cantidad"),
                                          dr("Precio"), total)
                        suma_total += total
                    End If
                Loop
            End If

            conexion.Close()
            txtSumaTotal.Text = FormatCurrency(suma_total, 2)
        Catch
            MessageBox.Show(ErrorToString)
        End Try
    End Sub

    Private Sub btnExportar_Click(sender As Object, e As EventArgs) Handles btnExportar.Click
        Try
            conexion.ConnectionString = cadena_conexion
            conexion.Open()

            comando.Connection = conexion
            comando.CommandType = CommandType.TableDirect
            comando.CommandText = "Libro"

            dr = comando.ExecuteReader 'trae datos por fila

            If dr.HasRows Then 'devuelve booleano dependiendo de si tiene filas
                FileOpen(1, "Datos Exportados.txt", OpenMode.Output)
                Do While dr.Read 'avanza en uno el registro de datos
                    If dr("IdPais") = cmbPais.SelectedValue Then
                        Write(1, dr("Titulo"))
                        Write(1, dr("Cantidad"))
                        WriteLine(1, dr("Precio"))
                    End If
                Loop
            End If
            FileClose(1)
            conexion.Close()
            MessageBox.Show("Datos Exportados Correctamente!")
        Catch
            MessageBox.Show(ErrorToString)
        End Try
    End Sub
End Class
