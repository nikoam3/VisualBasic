Public Class frmGraf_Pais
    Private Sub frmGraf_Pais_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cantidad As Integer = 0
        Dim precio As Decimal = 0

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
                Chart1.Series("Cantidad").Points.AddXY(dr("Nombre"), cantidad)
                Chart1.Series("Precios").Points.AddXY(dr("Nombre"), precio)
            Loop
        End If
        conexion.Close()

    End Sub
End Class