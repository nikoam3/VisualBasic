﻿Imports System.Data.OleDb
Imports System.IO

Public Class frmConsul_Autor
    Private Sub frmConsul_Autor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Combo_Box(cmbConsulta, "Autor", "IdAutor")
    End Sub

    Private Sub btnListar_Click(sender As Object, e As EventArgs) Handles btnListar.Click
        listar_consultas(txtCant, dgvConsul, cmbConsulta, "Autor", "IdAutor")
    End Sub

    Private Sub btnExportar_Click(sender As Object, e As EventArgs) Handles btnExportar.Click
        exportar_consul(cmbConsulta, "IdAutor")
    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        PrintDialog_consul.ShowDialog()
        PrintDocument_consul.PrinterSettings = PrintDialog_consul.PrinterSettings
        PrintDocument_consul.Print()
    End Sub

    Private Sub PrintDocument_consul_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument_consul.PrintPage
        Dim titulo As New Font("Arial", 18)
        Dim columna As New Font("Arial", 14)
        Dim letra As New Font("Arial", 12)
        Dim fila As Integer = 130
        Dim total As Integer = 0

        e.Graphics.DrawString("Consulta de Autores", titulo, Brushes.Black, 80, 50)
        e.Graphics.DrawString("ID Libro", columna, Brushes.Black, 50, 100)
        e.Graphics.DrawString("Titulo", columna, Brushes.Black, 150, 100)
        e.Graphics.DrawString("Año", columna, Brushes.Black, 600, 100)
        e.Graphics.DrawString("ID Autor", columna, Brushes.Black, 700, 100)

        conexion.ConnectionString = base
        conexion.Open()
        comando.Connection = conexion
        comando.CommandType = CommandType.TableDirect
        comando.CommandText = "Libro"

        dr = comando.ExecuteReader
        If dr.HasRows Then
            Do While dr.Read
                If dr("IdAutor") = cmbConsulta.SelectedValue Then
                    e.Graphics.DrawString(dr("IdLibro"), letra, Brushes.Black, 50, fila)
                    e.Graphics.DrawString(dr("Titulo"), letra, Brushes.Black, 150, fila)
                    e.Graphics.DrawString(dr("Año"), letra, Brushes.Black, 600, fila)
                    e.Graphics.DrawString(dr("IdAutor"), letra, Brushes.Black, 700, fila)
                    fila += 20
                    total += 1
                End If
            Loop
        End If
        fila += 20
        e.Graphics.DrawString("Total Consultados: " & total, columna, Brushes.Black, 50, 100)

        conexion.Close()
    End Sub
End Class