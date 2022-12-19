Imports System.Data.OleDb
Imports System.IO
Module Datos_Globales

    Public conexion As New OleDb.OleDbConnection
    Public comando As New OleDb.OleDbCommand
    Public adaptador As New OleDb.OleDbDataAdapter
    Public base As String = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source=Libreria.accdb"

    Public ds As DataSet
    Public dr As OleDbDataReader

    Public Sub Combo_Box(combo As ComboBox, tabla As String, id As String)
        Try
            conexion.ConnectionString = base
            conexion.Open()

            comando.Connection = conexion
            comando.CommandType = CommandType.TableDirect
            comando.CommandText = tabla

            adaptador = New OleDbDataAdapter(comando)
            ds = New DataSet
            adaptador.Fill(ds)

            combo.DataSource = ds.Tables(0)
            combo.ValueMember = id
            combo.DisplayMember = "Nombre"
            conexion.Close()
        Catch
            MessageBox.Show(ErrorToString)
        End Try
    End Sub
    Public Sub listar(dgv As DataGridView, tabla As String, colum As String)
        Try
            dgv.Rows.Clear()

            conexion.ConnectionString = base
            conexion.Open()
            comando.Connection = conexion
            comando.CommandType = CommandType.TableDirect
            comando.CommandText = tabla

            dr = comando.ExecuteReader
            If tabla = "Libro" Then
                If dr.HasRows Then
                    Do While dr.Read
                        dgv.Rows.Add(dr("Titulo"), dr("Año"), dr(colum))
                    Loop
                End If
            Else
                If dr.HasRows Then
                    Do While dr.Read
                        dgv.Rows.Add(dr("Nombre"), dr(colum))
                    Loop
                End If
            End If

            conexion.Close()
        Catch
            MessageBox.Show(ErrorToString)
        End Try
    End Sub
    Public Sub exportar(tabla As String, col As String)
        Try
            Dim nombre_exp As String = ""
            conexion.ConnectionString = base
            conexion.Open()

            comando.Connection = conexion
            comando.CommandType = CommandType.TableDirect
            comando.CommandText = tabla

            dr = comando.ExecuteReader

            Dim ExporCSV = New StreamWriter(tabla & "_Listado_CSV.csv", False, System.Text.Encoding.UTF8)
            If tabla = "Libro" Then
                ExporCSV.WriteLine(tabla & ";Año;" & col)
                If dr.HasRows Then
                    Do While dr.Read
                        ExporCSV.Write(dr("Titulo"))
                        ExporCSV.Write(";")
                        ExporCSV.Write(dr("Año"))
                        ExporCSV.Write(";")
                        ExporCSV.WriteLine(dr(col))
                    Loop
                End If
            Else
                ExporCSV.WriteLine(tabla & ";" & col)
                If dr.HasRows Then
                    Do While dr.Read
                        ExporCSV.Write(dr("Nombre"))
                        ExporCSV.Write(";")
                        ExporCSV.WriteLine(dr(col))
                    Loop
                End If
            End If
            ExporCSV.WriteLine("")
            ExporCSV.Close()
            conexion.Close()
            MessageBox.Show("Datos Exportados Correctamente!")
        Catch
            MessageBox.Show(ErrorToString)
        End Try
    End Sub
    Public Sub listar_consultas(txt As TextBox, dgv As DataGridView, cmb As ComboBox, tabla As String, colum As String)
        Try
            Dim cod_id As Integer = 0
            Dim cant As Decimal = 0

            dgv.Rows.Clear()

            conexion.ConnectionString = base
            conexion.Open()
            comando.Connection = conexion
            comando.CommandType = CommandType.TableDirect
            comando.CommandText = "Libro"

            dr = comando.ExecuteReader

            If dr.HasRows Then
                Do While dr.Read
                    If cmb.SelectedValue = dr(colum) Then
                        cod_id = buscar_id(tabla, colum, dr(colum))
                        cant += 1
                        dgv.Rows.Add(dr("IdLibro"), dr("Titulo"), dr("Año"), cod_id)
                    End If
                Loop
            End If
            txt.Text = cant
            conexion.Close()
        Catch
            MessageBox.Show(ErrorToString)
        End Try
    End Sub
    Public Sub exportar_consul(cmb As ComboBox, colum As String)
        Try
            conexion.ConnectionString = base
            conexion.Open()

            comando.Connection = conexion
            comando.CommandType = CommandType.TableDirect
            comando.CommandText = "Libro"

            dr = comando.ExecuteReader

            Dim ExporCSV = New StreamWriter(colum & "_Consulta.csv", True, System.Text.Encoding.UTF8)
            ExporCSV.WriteLine(cmb.Text)
            ExporCSV.WriteLine("Id Libro;Titulo;Año;" & colum)

            If dr.HasRows Then
                Do While dr.Read
                    If cmb.SelectedValue = dr(colum) Then
                        ExporCSV.Write(dr("IdLibro"))
                        ExporCSV.Write(";")
                        ExporCSV.Write(dr("Titulo"))
                        ExporCSV.Write(";")
                        ExporCSV.Write(dr("Año"))
                        ExporCSV.Write(";")
                        ExporCSV.WriteLine(dr(colum))
                    End If
                Loop
            End If
            ExporCSV.WriteLine("")
            ExporCSV.Close()
            conexion.Close()
            MessageBox.Show("Datos Exportados Correctamente!")
        Catch
            MessageBox.Show(ErrorToString)
        End Try
    End Sub
    Public Sub listar_estad(tabla As String, colum As String, dgv As DataGridView, txtlist As TextBox, txtcant As TextBox, txttotal_precios As TextBox)
        Try
            Dim listados As Decimal = 0
            Dim suma_cant As Decimal = 0
            Dim total As Decimal = 0
            Dim suma_total As Decimal = 0
            Dim cantidad As Integer = 0
            Dim precio As Decimal = 0

            dgv.Rows.Clear()

            conexion.ConnectionString = base
            conexion.Open()
            comando.Connection = conexion
            comando.CommandType = CommandType.TableDirect
            comando.CommandText = tabla

            dr = comando.ExecuteReader

            If dr.HasRows Then
                Do While dr.Read
                    cantidad = buscar_idcantidad("Libro", colum, dr(colum))
                    precio = buscar_idprecio("Libro", colum, dr(colum))
                    total = cantidad * precio
                    dgv.Rows.Add(dr("Nombre"), cantidad, precio, total)
                    listados += 1
                    suma_cant += cantidad
                    suma_total += total
                Loop
            End If
            txtlist.Text = listados
            txtcant.Text = suma_cant
            txttotal_precios.Text = Format(suma_total, "$ #,##0.00")
            conexion.Close()
        Catch
            MessageBox.Show(ErrorToString)
        End Try
    End Sub
    Public Sub exportar_estad(tabla As String, colum As String)
        Try
            Dim listados As Decimal = 0
            Dim suma_cant As Decimal = 0
            Dim suma_total As Decimal = 0
            Dim total As Decimal = 0
            Dim cantidad As Integer = 0
            Dim precio As Decimal = 0

            conexion.ConnectionString = base
            conexion.Open()

            comando.Connection = conexion
            comando.CommandType = CommandType.TableDirect
            comando.CommandText = tabla

            dr = comando.ExecuteReader

            Dim ExporCSV = New StreamWriter(tabla & "_Estadísticas.csv", True, System.Text.Encoding.UTF8)
            ExporCSV.WriteLine("Autor; Cantidad; Precio; Total $ Stock")

            If dr.HasRows Then
                Do While dr.Read
                    cantidad = buscar_idcantidad("Libro", colum, dr(colum))
                    precio = buscar_idprecio("Libro", colum, dr(colum))
                    total = cantidad * precio
                    listados += 1
                    suma_cant += cantidad
                    suma_total += total
                    ExporCSV.Write(dr("Nombre"))
                    ExporCSV.Write(";")
                    ExporCSV.Write(cantidad)
                    ExporCSV.Write(";")
                    ExporCSV.Write(precio)
                    ExporCSV.Write(";")
                    ExporCSV.WriteLine(total)
                Loop
            End If
            ExporCSV.WriteLine("")
            ExporCSV.Write("Listados:")
            ExporCSV.Write(";")
            ExporCSV.WriteLine(listados)
            ExporCSV.Write("Total Cantidad:")
            ExporCSV.Write(";")
            ExporCSV.WriteLine(suma_cant)
            ExporCSV.Write("Total $:")
            ExporCSV.Write(";")
            ExporCSV.WriteLine(suma_total)
            ExporCSV.WriteLine("")
            ExporCSV.Close()
            conexion.Close()
            MessageBox.Show("Datos Exportados Correctamente!")
        Catch
            MessageBox.Show(ErrorToString)
        End Try
    End Sub
    Public Function buscar_id(tabla As String, colum As String, id As String)
        Dim cod_id As Integer = 0
        Try
            Dim con As New OleDb.OleDbConnection
            Dim com As New OleDb.OleDbCommand
            Dim dr_buscar As OleDbDataReader

            con.ConnectionString = base
            con.Open()

            com.Connection = conexion
            com.CommandType = CommandType.TableDirect
            com.CommandText = tabla
            dr_buscar = com.ExecuteReader 'trae datos por fila


            If dr_buscar.HasRows Then
                Do While dr_buscar.Read
                    If dr_buscar(colum) = id Then
                        cod_id = dr_buscar(colum)
                    End If
                Loop
            End If
            con.Close()
        Catch
            MessageBox.Show(ErrorToString)
        End Try
        Return cod_id
    End Function
    Public Function buscar_idnombres(tabla As String, colum As String, id As Integer) As String
        Dim nombre As String = ""
        Try
            Dim con As New OleDb.OleDbConnection
            Dim com As New OleDb.OleDbCommand
            Dim dr_buscar As OleDbDataReader

            con.ConnectionString = base
            con.Open()

            com.Connection = con
            com.CommandType = CommandType.TableDirect
            com.CommandText = tabla
            dr_buscar = com.ExecuteReader 'trae datos por fila

            If tabla = "Libro" Then
                If dr_buscar.HasRows Then
                    Do While dr_buscar.Read
                        If dr_buscar(colum) = id Then
                            nombre = dr_buscar("Titulo")
                        End If
                    Loop
                End If
            Else
                If dr_buscar.HasRows Then
                    Do While dr_buscar.Read
                        If dr_buscar(colum) = id Then
                            nombre = dr_buscar("Nombre")
                        End If
                    Loop
                End If
            End If
            con.Close()
        Catch
            MessageBox.Show(ErrorToString)
        End Try
        Return nombre
    End Function
    Public Function buscar_idcantidad(tabla As String, colum As String, id As String)
        Dim cantidad As Integer
        Try
            Dim con As New OleDb.OleDbConnection
            Dim com As New OleDb.OleDbCommand
            Dim dr_buscar As OleDbDataReader

            con.ConnectionString = base
            con.Open()

            com.Connection = conexion
            com.CommandType = CommandType.TableDirect
            com.CommandText = tabla
            dr_buscar = com.ExecuteReader 'trae datos por fila


            If dr_buscar.HasRows Then
                Do While dr_buscar.Read
                    If dr_buscar(colum) = id Then
                        cantidad += dr_buscar("Cantidad")
                    End If
                Loop
            End If
            con.Close()
        Catch
            MessageBox.Show(ErrorToString)
        End Try
        Return cantidad
    End Function
    Public Function buscar_idprecio(tabla As String, colum As String, id As String)
        Dim precio As Decimal
        Try
            Dim con As New OleDb.OleDbConnection
            Dim com As New OleDb.OleDbCommand
            Dim dr_buscar As OleDbDataReader

            con.ConnectionString = base
            con.Open()

            com.Connection = conexion
            com.CommandType = CommandType.TableDirect
            com.CommandText = tabla
            dr_buscar = com.ExecuteReader 'trae datos por fila


            If dr_buscar.HasRows Then
                Do While dr_buscar.Read
                    If dr_buscar(colum) = id Then
                        precio += dr_buscar("Precio")
                    End If
                Loop
            End If
            con.Close()
        Catch
            MessageBox.Show(ErrorToString)
        End Try
        Return precio
    End Function
    Public Sub agregar_nombre(tabla As String, txt_nom As TextBox)
        Try
            conexion.ConnectionString = base
            conexion.Open()

            comando.Connection = conexion
            comando.CommandType = CommandType.TableDirect
            comando.CommandText = tabla

            adaptador = New OleDbDataAdapter(comando)
            ds = New DataSet
            adaptador.Fill(ds)

            Dim data_tabla As DataTable = ds.Tables(0)
            Dim fila As DataRow = data_tabla.NewRow()

            fila("Nombre") = txt_nom.Text
            data_tabla.Rows.Add(fila)

            Dim comando_grabar As New OleDbCommandBuilder(adaptador)
            adaptador.Update(ds)
            conexion.Close()
            MessageBox.Show("Carga completa")
        Catch
            MessageBox.Show(ErrorToString)
        End Try
    End Sub
    Public Sub agregar_titulo(txt_nom As TextBox, txt_anio As TextBox,
                              txt_cant As TextBox, txt_prec As TextBox,
                              txt_idautor As TextBox, txt_ididioma As TextBox,
                              txt_idpais As TextBox)
        Try
            conexion.ConnectionString = base
            conexion.Open()

            comando.Connection = conexion
            comando.CommandType = CommandType.TableDirect
            comando.CommandText = "Libro"

            adaptador = New OleDbDataAdapter(comando)
            ds = New DataSet
            adaptador.Fill(ds)

            Dim data_tabla As DataTable = ds.Tables(0)
            Dim fila As DataRow = data_tabla.NewRow()

            fila("Titulo") = txt_nom.Text
            fila("Año") = txt_anio.Text
            fila("Cantidad") = txt_cant.Text
            fila("Precio") = txt_prec.Text
            fila("IdAutor") = txt_idautor.Text
            fila("IdIdioma") = txt_ididioma.Text
            fila("IdPais") = txt_idpais.Text
            data_tabla.Rows.Add(fila)

            Dim comando_grabar As New OleDbCommandBuilder(adaptador)
            adaptador.Update(ds)
            conexion.Close()
            txt_nom.Text = ""
            txt_anio.Text = ""
            txt_cant.Text = ""
            txt_prec.Text = ""
            txt_idautor.Text = ""
            txt_ididioma.Text = ""
            txt_idpais.Text = ""
            MessageBox.Show("Carga Completa")
        Catch
            MessageBox.Show(ErrorToString)
        End Try
    End Sub
    Public Sub buscar(txt_cod As TextBox, txt_nom As TextBox, tabla As String, colum As String, btn As Button)
        Try
            Dim nombre As String = ""
            Dim cod As Integer = txt_cod.Text
            nombre = buscar_idnombres(tabla, colum, cod)

            If nombre <> "" Then
                txt_nom.Enabled = True
                txt_nom.Text = nombre
            Else
                btn.Enabled = True
                txt_cod.Enabled = True
                txt_nom.Enabled = False
                MessageBox.Show("Codigo no existe!")
            End If
        Catch
            MessageBox.Show(ErrorToString)
        End Try
    End Sub
    Public Sub grabar(tabla As String, colum As String, txt_cod As TextBox, txt_nom As TextBox)
        Try
            Dim SQL As String = ""

            If tabla = "Libro" Then
                SQL = "update " & tabla & " set Titulo = '" & txt_nom.Text & "' where " & colum & " = " & txt_cod.Text
            Else
                SQL = "update " & tabla & " set Nombre = '" & txt_nom.Text & "' where " & colum & " = " & txt_cod.Text
            End If

            conexion.ConnectionString = base
            conexion.Open()

            comando.Connection = conexion
            comando.CommandType = CommandType.Text
            comando.CommandText = SQL
            comando.ExecuteReader()
            conexion.Close()

            MessageBox.Show("Dato Modificado Correctamente")
            txt_cod.Text = ""
            txt_nom.Text = ""
        Catch
            MessageBox.Show(ErrorToString)
        End Try
    End Sub
End Module
