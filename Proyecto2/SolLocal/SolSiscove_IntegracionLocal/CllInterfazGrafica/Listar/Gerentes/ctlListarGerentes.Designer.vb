<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctlListarGerentes
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.dvgUsuarios = New System.Windows.Forms.DataGridView
        Me.codigo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.nom = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.primerApellido = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.segundoApellido = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.rolUsuario = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.pbRegresar = New System.Windows.Forms.PictureBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.gbListarGerentesDisponibles = New System.Windows.Forms.GroupBox
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.dvgUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbRegresar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.gbListarGerentesDisponibles.SuspendLayout()
        Me.SuspendLayout()
        '
        'dvgUsuarios
        '
        Me.dvgUsuarios.AllowUserToAddRows = False
        Me.dvgUsuarios.AllowUserToDeleteRows = False
        Me.dvgUsuarios.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dvgUsuarios.ColumnHeadersHeight = 26
        Me.dvgUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dvgUsuarios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.codigo, Me.nom, Me.primerApellido, Me.segundoApellido, Me.rolUsuario})
        Me.dvgUsuarios.Location = New System.Drawing.Point(24, 41)
        Me.dvgUsuarios.Name = "dvgUsuarios"
        Me.dvgUsuarios.ReadOnly = True
        Me.dvgUsuarios.RowHeadersVisible = False
        Me.dvgUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dvgUsuarios.Size = New System.Drawing.Size(504, 176)
        Me.dvgUsuarios.TabIndex = 10
        '
        'codigo
        '
        Me.codigo.HeaderText = "Cedula"
        Me.codigo.MinimumWidth = 100
        Me.codigo.Name = "codigo"
        Me.codigo.ReadOnly = True
        Me.codigo.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'nom
        '
        Me.nom.HeaderText = "Nombre"
        Me.nom.MinimumWidth = 100
        Me.nom.Name = "nom"
        Me.nom.ReadOnly = True
        Me.nom.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'primerApellido
        '
        Me.primerApellido.HeaderText = "Primer Apellido"
        Me.primerApellido.MinimumWidth = 100
        Me.primerApellido.Name = "primerApellido"
        Me.primerApellido.ReadOnly = True
        Me.primerApellido.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'segundoApellido
        '
        Me.segundoApellido.HeaderText = "Segundo Apellido"
        Me.segundoApellido.MinimumWidth = 100
        Me.segundoApellido.Name = "segundoApellido"
        Me.segundoApellido.ReadOnly = True
        Me.segundoApellido.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'rolUsuario
        '
        Me.rolUsuario.HeaderText = "Rol"
        Me.rolUsuario.MinimumWidth = 100
        Me.rolUsuario.Name = "rolUsuario"
        Me.rolUsuario.ReadOnly = True
        Me.rolUsuario.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'pbRegresar
        '
        Me.pbRegresar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbRegresar.Location = New System.Drawing.Point(614, 3)
        Me.pbRegresar.Name = "pbRegresar"
        Me.pbRegresar.Size = New System.Drawing.Size(30, 30)
        Me.pbRegresar.TabIndex = 12
        Me.pbRegresar.TabStop = False
        Me.ToolTip1.SetToolTip(Me.pbRegresar, "Regresar")
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel1.Controls.Add(Me.gbListarGerentesDisponibles)
        Me.Panel1.Controls.Add(Me.pbRegresar)
        Me.Panel1.Location = New System.Drawing.Point(184, 166)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(648, 362)
        Me.Panel1.TabIndex = 13
        '
        'gbListarGerentesDisponibles
        '
        Me.gbListarGerentesDisponibles.Controls.Add(Me.dvgUsuarios)
        Me.gbListarGerentesDisponibles.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.gbListarGerentesDisponibles.Location = New System.Drawing.Point(36, 51)
        Me.gbListarGerentesDisponibles.Name = "gbListarGerentesDisponibles"
        Me.gbListarGerentesDisponibles.Size = New System.Drawing.Size(552, 252)
        Me.gbListarGerentesDisponibles.TabIndex = 13
        Me.gbListarGerentesDisponibles.TabStop = False
        Me.gbListarGerentesDisponibles.Text = "Listar Disponible"
        '
        'ctlListarGerentes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Controls.Add(Me.Panel1)
        Me.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Name = "ctlListarGerentes"
        Me.Size = New System.Drawing.Size(1024, 700)
        CType(Me.dvgUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbRegresar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.gbListarGerentesDisponibles.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dvgUsuarios As System.Windows.Forms.DataGridView
    Friend WithEvents codigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nom As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents primerApellido As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents segundoApellido As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents rolUsuario As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pbRegresar As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents gbListarGerentesDisponibles As System.Windows.Forms.GroupBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip

End Class
