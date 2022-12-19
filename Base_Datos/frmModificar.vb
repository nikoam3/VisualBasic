Imports System.Data.OleDb
Public Class frmModificar
    Private Sub frmBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim nombre As String = buscar_idnombres("Idioma", txtCodigo.Text)
        If nombre <> "" Then
            btnGrabar.Enabled = True
            txtCodigo.Enabled = False
            txtNombre.Enabled = True
            txtNombre.Text = nombre
        Else
            btnGrabar.Enabled = False
            txtCodigo.Enabled = True
            txtNombre.Enabled = False
            MessageBox.Show("Codigo no existe!")
        End If
    End Sub
    Private Function buscar_idnombres(tabla As String, id As Integer) As String
        Dim nombre As String = ""

        Dim con As New OleDb.OleDbConnection
        Dim com As New OleDb.OleDbCommand
        Dim dr_buscar As OleDbDataReader

        con.ConnectionString = cadena_conexion
        con.Open()

        com.Connection = con
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

    Private Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        Try
            Dim SQL As String = ""
            SQL = "update idioma set Nombre = '" & txtNombre.Text & "' where IdIdioma = " & txtCodigo.Text
            conexion.ConnectionString = cadena_conexion
            conexion.Open()

            comando.Connection = conexion
            comando.CommandType = CommandType.Text
            comando.CommandText = SQL
            comando.ExecuteReader() 'trae datos por fila
            conexion.Close()
            MessageBox.Show("Dato Modificado Correctamente")
        Catch
            MessageBox.Show(ErrorToString)
        End Try
    End Sub
End Class