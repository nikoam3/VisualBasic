Public Class frmGraf_Idioma
    Private Sub frmGraf_Idioma_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cantidad As Integer = 0
        Dim precio As Decimal = 0

        conexion.ConnectionString = base
        conexion.Open()
        comando.Connection = conexion
        comando.CommandType = CommandType.TableDirect
        comando.CommandText = "Idioma"
        dr = comando.ExecuteReader

        If dr.HasRows Then
            Do While dr.Read
                cantidad = buscar_idcantidad("Libro", "IdIdioma", dr("IdIdioma"))
                precio = buscar_idprecio("Libro", "IdIdioma", dr("IdIdioma"))
                Chart1.Series("Cantidad").Points.AddXY(dr("Nombre"), cantidad)
                Chart1.Series("Precios").Points.AddXY(dr("Nombre"), precio)
            Loop
        End If
        conexion.Close()
    End Sub
End Class