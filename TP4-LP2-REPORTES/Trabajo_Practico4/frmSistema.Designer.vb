﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSistema
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SistemaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcercaDeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AutoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IdiomasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LibrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PaísesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LibrosDeUnAutorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LibrosDeUnIdiomaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LibrosDeUnPaísToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EstadísticasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LibrosPorAutorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LibrosPorIdiomaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LibrosPorPaísToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AutorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IdiomaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LibrosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PaísToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AutorToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.IdiomaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.LibrosToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PaisToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SistemaToolStripMenuItem, Me.ListadosToolStripMenuItem, Me.ConToolStripMenuItem, Me.EstadísticasToolStripMenuItem, Me.AgregarToolStripMenuItem, Me.ModificarToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SistemaToolStripMenuItem
        '
        Me.SistemaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AcercaDeToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.SistemaToolStripMenuItem.Name = "SistemaToolStripMenuItem"
        Me.SistemaToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.SistemaToolStripMenuItem.Text = "Sistema"
        '
        'AcercaDeToolStripMenuItem
        '
        Me.AcercaDeToolStripMenuItem.Name = "AcercaDeToolStripMenuItem"
        Me.AcercaDeToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.AcercaDeToolStripMenuItem.Text = "Acerca de..."
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'ListadosToolStripMenuItem
        '
        Me.ListadosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AutoresToolStripMenuItem, Me.IdiomasToolStripMenuItem, Me.LibrosToolStripMenuItem, Me.PaísesToolStripMenuItem})
        Me.ListadosToolStripMenuItem.Name = "ListadosToolStripMenuItem"
        Me.ListadosToolStripMenuItem.Size = New System.Drawing.Size(58, 20)
        Me.ListadosToolStripMenuItem.Text = "Listados"
        '
        'AutoresToolStripMenuItem
        '
        Me.AutoresToolStripMenuItem.Name = "AutoresToolStripMenuItem"
        Me.AutoresToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.AutoresToolStripMenuItem.Text = "Autores..."
        '
        'IdiomasToolStripMenuItem
        '
        Me.IdiomasToolStripMenuItem.Name = "IdiomasToolStripMenuItem"
        Me.IdiomasToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.IdiomasToolStripMenuItem.Text = "Idiomas..."
        '
        'LibrosToolStripMenuItem
        '
        Me.LibrosToolStripMenuItem.Name = "LibrosToolStripMenuItem"
        Me.LibrosToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.LibrosToolStripMenuItem.Text = "Libros..."
        '
        'PaísesToolStripMenuItem
        '
        Me.PaísesToolStripMenuItem.Name = "PaísesToolStripMenuItem"
        Me.PaísesToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.PaísesToolStripMenuItem.Text = "Países..."
        '
        'ConToolStripMenuItem
        '
        Me.ConToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LibrosDeUnAutorToolStripMenuItem, Me.LibrosDeUnIdiomaToolStripMenuItem, Me.LibrosDeUnPaísToolStripMenuItem})
        Me.ConToolStripMenuItem.Name = "ConToolStripMenuItem"
        Me.ConToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.ConToolStripMenuItem.Text = "Consultas"
        '
        'LibrosDeUnAutorToolStripMenuItem
        '
        Me.LibrosDeUnAutorToolStripMenuItem.Name = "LibrosDeUnAutorToolStripMenuItem"
        Me.LibrosDeUnAutorToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.LibrosDeUnAutorToolStripMenuItem.Text = "Libros de un autor..."
        '
        'LibrosDeUnIdiomaToolStripMenuItem
        '
        Me.LibrosDeUnIdiomaToolStripMenuItem.Name = "LibrosDeUnIdiomaToolStripMenuItem"
        Me.LibrosDeUnIdiomaToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.LibrosDeUnIdiomaToolStripMenuItem.Text = "Libros de un idioma..."
        '
        'LibrosDeUnPaísToolStripMenuItem
        '
        Me.LibrosDeUnPaísToolStripMenuItem.Name = "LibrosDeUnPaísToolStripMenuItem"
        Me.LibrosDeUnPaísToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.LibrosDeUnPaísToolStripMenuItem.Text = "Libros de un país..."
        '
        'EstadísticasToolStripMenuItem
        '
        Me.EstadísticasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LibrosPorAutorToolStripMenuItem, Me.LibrosPorIdiomaToolStripMenuItem, Me.LibrosPorPaísToolStripMenuItem})
        Me.EstadísticasToolStripMenuItem.Name = "EstadísticasToolStripMenuItem"
        Me.EstadísticasToolStripMenuItem.Size = New System.Drawing.Size(75, 20)
        Me.EstadísticasToolStripMenuItem.Text = "Estadísticas"
        '
        'LibrosPorAutorToolStripMenuItem
        '
        Me.LibrosPorAutorToolStripMenuItem.Name = "LibrosPorAutorToolStripMenuItem"
        Me.LibrosPorAutorToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.LibrosPorAutorToolStripMenuItem.Text = "Libros por autor..."
        '
        'LibrosPorIdiomaToolStripMenuItem
        '
        Me.LibrosPorIdiomaToolStripMenuItem.Name = "LibrosPorIdiomaToolStripMenuItem"
        Me.LibrosPorIdiomaToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.LibrosPorIdiomaToolStripMenuItem.Text = "Libros por idioma..."
        '
        'LibrosPorPaísToolStripMenuItem
        '
        Me.LibrosPorPaísToolStripMenuItem.Name = "LibrosPorPaísToolStripMenuItem"
        Me.LibrosPorPaísToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.LibrosPorPaísToolStripMenuItem.Text = "Libros por país..."
        '
        'AgregarToolStripMenuItem
        '
        Me.AgregarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AutorToolStripMenuItem, Me.IdiomaToolStripMenuItem, Me.LibrosToolStripMenuItem1, Me.PaísToolStripMenuItem})
        Me.AgregarToolStripMenuItem.Name = "AgregarToolStripMenuItem"
        Me.AgregarToolStripMenuItem.Size = New System.Drawing.Size(58, 20)
        Me.AgregarToolStripMenuItem.Text = "Agregar"
        '
        'AutorToolStripMenuItem
        '
        Me.AutorToolStripMenuItem.Name = "AutorToolStripMenuItem"
        Me.AutorToolStripMenuItem.Size = New System.Drawing.Size(118, 22)
        Me.AutorToolStripMenuItem.Text = "Autor..."
        '
        'IdiomaToolStripMenuItem
        '
        Me.IdiomaToolStripMenuItem.Name = "IdiomaToolStripMenuItem"
        Me.IdiomaToolStripMenuItem.Size = New System.Drawing.Size(118, 22)
        Me.IdiomaToolStripMenuItem.Text = "Idioma..."
        '
        'LibrosToolStripMenuItem1
        '
        Me.LibrosToolStripMenuItem1.Name = "LibrosToolStripMenuItem1"
        Me.LibrosToolStripMenuItem1.Size = New System.Drawing.Size(118, 22)
        Me.LibrosToolStripMenuItem1.Text = "Libro..."
        '
        'PaísToolStripMenuItem
        '
        Me.PaísToolStripMenuItem.Name = "PaísToolStripMenuItem"
        Me.PaísToolStripMenuItem.Size = New System.Drawing.Size(118, 22)
        Me.PaísToolStripMenuItem.Text = "País..."
        '
        'ModificarToolStripMenuItem
        '
        Me.ModificarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AutorToolStripMenuItem1, Me.IdiomaToolStripMenuItem1, Me.LibrosToolStripMenuItem2, Me.PaisToolStripMenuItem})
        Me.ModificarToolStripMenuItem.Name = "ModificarToolStripMenuItem"
        Me.ModificarToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.ModificarToolStripMenuItem.Text = "Modificar"
        '
        'AutorToolStripMenuItem1
        '
        Me.AutorToolStripMenuItem1.Name = "AutorToolStripMenuItem1"
        Me.AutorToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.AutorToolStripMenuItem1.Text = "Autor..."
        '
        'IdiomaToolStripMenuItem1
        '
        Me.IdiomaToolStripMenuItem1.Name = "IdiomaToolStripMenuItem1"
        Me.IdiomaToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.IdiomaToolStripMenuItem1.Text = "Idioma..."
        '
        'LibrosToolStripMenuItem2
        '
        Me.LibrosToolStripMenuItem2.Name = "LibrosToolStripMenuItem2"
        Me.LibrosToolStripMenuItem2.Size = New System.Drawing.Size(180, 22)
        Me.LibrosToolStripMenuItem2.Text = "Libros..."
        '
        'PaisToolStripMenuItem
        '
        Me.PaisToolStripMenuItem.Name = "PaisToolStripMenuItem"
        Me.PaisToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.PaisToolStripMenuItem.Text = "Pais..."
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.Trabajo_Practico3.My.Resources.Resources.logo_libreria_logos_glow
        Me.PictureBox1.Location = New System.Drawing.Point(0, 24)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(800, 426)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'frmSistema
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmSistema"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sistema Principal"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents SistemaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AcercaDeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListadosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LibrosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AutoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IdiomasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PaísesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LibrosDeUnPaísToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LibrosDeUnAutorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LibrosDeUnIdiomaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EstadísticasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LibrosPorAutorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LibrosPorPaísToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LibrosPorIdiomaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AgregarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LibrosToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents PaísToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AutorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IdiomaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModificarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LibrosToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents PaisToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AutorToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents IdiomaToolStripMenuItem1 As ToolStripMenuItem
End Class
