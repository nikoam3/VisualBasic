Imports System.Data.OleDb
Public Class frmDGV
    Private Sub btnListar_Click(sender As Object, e As EventArgs) Handles btnListar.Click
        Try
            Dim nom_autor As String = ""
            Dim nom_pais As String = ""
            Dim nom_idioma As String = ""
            Dim total As Decimal = 0

            dgvDatos.Rows.Clear()

            conexion.ConnectionString = cadena_conexion
            conexion.Open()

            comando.Connection = conexion
            comando.CommandType = CommandType.TableDirect
            comando.CommandText = "Libro"

            dr = comando.ExecuteReader 'trae datos por fila

            If dr.HasRows Then 'devuelve booleano dependiendo de si tiene filas
                Do While dr.Read 'avanza en uno el registro de datos
                    nom_autor = buscar_idnombres("Autor", dr("IdAutor"))
                    nom_pais = buscar_idnombres("Pais", dr("IdPais"))
                    nom_idioma = buscar_idnombres("Idioma", dr("IdIdioma"))

                    total = dr("Cantidad") * dr("Precio")

                    dgvDatos.Rows.Add(dr("Titulo"), nom_autor, nom_pais, nom_idioma,
                                       dr("Precio"), total)
                Loop
            End If

            conexion.Close()
        Catch
            MessageBox.Show(ErrorToString)
        End Try
    End Sub

    Private Function buscar_idnombres(tabla As String, id As Integer) As String
        Dim nombre As String = ""

        Dim con As New OleDb.OleDbConnection
        Dim com As New OleDb.OleDbCommand
        Dim dr_buscar As OleDbDataReader

        con.ConnectionString = cadena_conexion
        con.Open()

        com.Connection = conexion
        com.CommandType = CommandType.TableDirect
        com.CommandText = tabla
        dr_buscar = com.ExecuteReader 'trae datos por fila

        Select Case tabla
            Case "Autor"
                If dr_buscar.HasRows Then
                    Do While dr_buscar.Read
                        If dr_buscar("IdAutor") = id Then
                            nombre = dr_buscar("Nombre")
                        End If
                    Loop
                End If
            Case "Idioma"
                If dr_buscar.HasRows Then
                    Do While dr_buscar.Read
                        If dr_buscar("IdIdioma") = id Then
                            nombre = dr_buscar("Nombre")
                        End If
                    Loop
                End If
            Case "Pais"
                If dr_buscar.HasRows Then
                    Do While dr_buscar.Read
                        If dr_buscar("IdPais") = id Then
                            nombre = dr_buscar("Nombre")
                        End If
                    Loop
                End If
        End Select

        con.Close()
        Return nombre
    End Function

End Class