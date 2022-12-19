Imports System.Data.OleDb
Module Datos_Globales
    'objetos para trabajar con la base de datos
    Public conexion As New OleDb.OleDbConnection 'a la base de datos
    Public comando As New OleDb.OleDbCommand 'detallamos que queremos obtener de la base de datos
    Public adaptador As New OleDb.OleDbDataAdapter 'adapta los datos del archivo a visual basic
    Public cadena_conexion As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Libreria_2.mdb"

    Public ds As DataSet
    Public dr As OleDbDataReader


End Module
