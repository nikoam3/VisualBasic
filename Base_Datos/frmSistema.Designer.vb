<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.DatosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarNuevoClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListarCompletoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListarPaisToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarDatosClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DatosToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DatosToolStripMenuItem
        '
        Me.DatosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarNuevoClienteToolStripMenuItem, Me.ModificarDatosClienteToolStripMenuItem, Me.EliminarClienteToolStripMenuItem, Me.ListarCompletoToolStripMenuItem, Me.ListarPaisToolStripMenuItem})
        Me.DatosToolStripMenuItem.Name = "DatosToolStripMenuItem"
        Me.DatosToolStripMenuItem.Size = New System.Drawing.Size(47, 20)
        Me.DatosToolStripMenuItem.Text = "Datos"
        '
        'AgregarNuevoClienteToolStripMenuItem
        '
        Me.AgregarNuevoClienteToolStripMenuItem.Name = "AgregarNuevoClienteToolStripMenuItem"
        Me.AgregarNuevoClienteToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.AgregarNuevoClienteToolStripMenuItem.Text = "Agregar Nuevo Cliente"
        '
        'EliminarClienteToolStripMenuItem
        '
        Me.EliminarClienteToolStripMenuItem.Name = "EliminarClienteToolStripMenuItem"
        Me.EliminarClienteToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.EliminarClienteToolStripMenuItem.Text = "Eliminar Cliente"
        '
        'ListarCompletoToolStripMenuItem
        '
        Me.ListarCompletoToolStripMenuItem.Name = "ListarCompletoToolStripMenuItem"
        Me.ListarCompletoToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.ListarCompletoToolStripMenuItem.Text = "Listar Completo"
        '
        'ListarPaisToolStripMenuItem
        '
        Me.ListarPaisToolStripMenuItem.Name = "ListarPaisToolStripMenuItem"
        Me.ListarPaisToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.ListarPaisToolStripMenuItem.Text = "Listar Pais"
        '
        'ModificarDatosClienteToolStripMenuItem
        '
        Me.ModificarDatosClienteToolStripMenuItem.Name = "ModificarDatosClienteToolStripMenuItem"
        Me.ModificarDatosClienteToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.ModificarDatosClienteToolStripMenuItem.Text = "Modificar Datos Cliente"
        '
        'frmSistema
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmSistema"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sistema"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents DatosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListarCompletoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListarPaisToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AgregarNuevoClienteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarClienteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModificarDatosClienteToolStripMenuItem As ToolStripMenuItem
End Class
