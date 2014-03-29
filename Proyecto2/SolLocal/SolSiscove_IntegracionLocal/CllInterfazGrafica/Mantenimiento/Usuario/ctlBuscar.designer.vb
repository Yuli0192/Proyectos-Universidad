<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctlBuscar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ctlBuscar))
        Me.lblNombre = New System.Windows.Forms.Label
        Me.txtCod = New System.Windows.Forms.TextBox
        Me.pbModificar2 = New System.Windows.Forms.PictureBox
        Me.txtNombre = New System.Windows.Forms.TextBox
        Me.txtApellido1 = New System.Windows.Forms.TextBox
        Me.lblApellido1 = New System.Windows.Forms.Label
        Me.lblApellido2 = New System.Windows.Forms.Label
        Me.lblCedula = New System.Windows.Forms.Label
        Me.txtApellido2 = New System.Windows.Forms.TextBox
        Me.txtCorreo = New System.Windows.Forms.TextBox
        Me.lblRol = New System.Windows.Forms.Label
        Me.lblDepartamento = New System.Windows.Forms.Label
        Me.lblCorreo = New System.Windows.Forms.Label
        Me.cbxDepartamento = New System.Windows.Forms.ComboBox
        Me.cbxRol = New System.Windows.Forms.ComboBox
        Me.pbEliminar = New System.Windows.Forms.PictureBox
        Me.pbModificar = New System.Windows.Forms.PictureBox
        Me.txtCriterio = New System.Windows.Forms.TextBox
        Me.rdbNombre = New System.Windows.Forms.RadioButton
        Me.rdbId = New System.Windows.Forms.RadioButton
        Me.dvgUsuario = New System.Windows.Forms.DataGridView
        Me.cedula = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.nom = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ap1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ap2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.gbModificarUsuario = New System.Windows.Forms.GroupBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.pbModificar2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbEliminar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbModificar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dvgUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.gbModificarUsuario.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.lblNombre.Location = New System.Drawing.Point(69, 92)
        Me.lblNombre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(60, 18)
        Me.lblNombre.TabIndex = 29
        Me.lblNombre.Text = "Nombre"
        '
        'txtCod
        '
        Me.txtCod.Enabled = False
        Me.txtCod.Location = New System.Drawing.Point(140, 48)
        Me.txtCod.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCod.MaxLength = 15
        Me.txtCod.Name = "txtCod"
        Me.txtCod.ReadOnly = True
        Me.txtCod.Size = New System.Drawing.Size(240, 27)
        Me.txtCod.TabIndex = 28
        '
        'pbModificar2
        '
        Me.pbModificar2.BackgroundImage = CType(resources.GetObject("pbModificar2.BackgroundImage"), System.Drawing.Image)
        Me.pbModificar2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbModificar2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbModificar2.Location = New System.Drawing.Point(350, 334)
        Me.pbModificar2.Name = "pbModificar2"
        Me.pbModificar2.Size = New System.Drawing.Size(30, 30)
        Me.pbModificar2.TabIndex = 55
        Me.pbModificar2.TabStop = False
        Me.ToolTip1.SetToolTip(Me.pbModificar2, "Confirmar Modificación")
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(140, 89)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(240, 27)
        Me.txtNombre.TabIndex = 56
        Me.ToolTip1.SetToolTip(Me.txtNombre, "Ej: Juan")
        '
        'txtApellido1
        '
        Me.txtApellido1.Location = New System.Drawing.Point(140, 132)
        Me.txtApellido1.Name = "txtApellido1"
        Me.txtApellido1.Size = New System.Drawing.Size(240, 27)
        Me.txtApellido1.TabIndex = 57
        Me.ToolTip1.SetToolTip(Me.txtApellido1, "Ej: Gonzales")
        '
        'lblApellido1
        '
        Me.lblApellido1.AutoSize = True
        Me.lblApellido1.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.lblApellido1.Location = New System.Drawing.Point(28, 132)
        Me.lblApellido1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblApellido1.Name = "lblApellido1"
        Me.lblApellido1.Size = New System.Drawing.Size(101, 18)
        Me.lblApellido1.TabIndex = 58
        Me.lblApellido1.Text = "Primer Apellido"
        '
        'lblApellido2
        '
        Me.lblApellido2.AutoSize = True
        Me.lblApellido2.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.lblApellido2.Location = New System.Drawing.Point(13, 174)
        Me.lblApellido2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblApellido2.Name = "lblApellido2"
        Me.lblApellido2.Size = New System.Drawing.Size(116, 18)
        Me.lblApellido2.TabIndex = 59
        Me.lblApellido2.Text = "Segundo Apellido"
        '
        'lblCedula
        '
        Me.lblCedula.AutoSize = True
        Me.lblCedula.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.lblCedula.Location = New System.Drawing.Point(78, 47)
        Me.lblCedula.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCedula.Name = "lblCedula"
        Me.lblCedula.Size = New System.Drawing.Size(51, 18)
        Me.lblCedula.TabIndex = 60
        Me.lblCedula.Text = "Cédula"
        '
        'txtApellido2
        '
        Me.txtApellido2.Location = New System.Drawing.Point(140, 175)
        Me.txtApellido2.Name = "txtApellido2"
        Me.txtApellido2.Size = New System.Drawing.Size(240, 27)
        Me.txtApellido2.TabIndex = 62
        Me.ToolTip1.SetToolTip(Me.txtApellido2, "Ej: Gonzales")
        '
        'txtCorreo
        '
        Me.txtCorreo.Location = New System.Drawing.Point(140, 215)
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.Size = New System.Drawing.Size(240, 27)
        Me.txtCorreo.TabIndex = 63
        Me.ToolTip1.SetToolTip(Me.txtCorreo, "text@text.text")
        '
        'lblRol
        '
        Me.lblRol.AutoSize = True
        Me.lblRol.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.lblRol.Location = New System.Drawing.Point(102, 304)
        Me.lblRol.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRol.Name = "lblRol"
        Me.lblRol.Size = New System.Drawing.Size(27, 18)
        Me.lblRol.TabIndex = 65
        Me.lblRol.Text = "Rol"
        '
        'lblDepartamento
        '
        Me.lblDepartamento.AutoSize = True
        Me.lblDepartamento.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.lblDepartamento.Location = New System.Drawing.Point(27, 263)
        Me.lblDepartamento.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDepartamento.Name = "lblDepartamento"
        Me.lblDepartamento.Size = New System.Drawing.Size(102, 18)
        Me.lblDepartamento.TabIndex = 66
        Me.lblDepartamento.Text = "Departamento"
        '
        'lblCorreo
        '
        Me.lblCorreo.AutoSize = True
        Me.lblCorreo.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.lblCorreo.Location = New System.Drawing.Point(5, 214)
        Me.lblCorreo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCorreo.Name = "lblCorreo"
        Me.lblCorreo.Size = New System.Drawing.Size(124, 18)
        Me.lblCorreo.TabIndex = 67
        Me.lblCorreo.Text = "Correo Electrónico"
        '
        'cbxDepartamento
        '
        Me.cbxDepartamento.FormattingEnabled = True
        Me.cbxDepartamento.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cbxDepartamento.Location = New System.Drawing.Point(140, 259)
        Me.cbxDepartamento.Name = "cbxDepartamento"
        Me.cbxDepartamento.Size = New System.Drawing.Size(240, 27)
        Me.cbxDepartamento.TabIndex = 68
        Me.ToolTip1.SetToolTip(Me.cbxDepartamento, "Departamento al que pretenece el usuario")
        '
        'cbxRol
        '
        Me.cbxRol.FormattingEnabled = True
        Me.cbxRol.Location = New System.Drawing.Point(140, 301)
        Me.cbxRol.Name = "cbxRol"
        Me.cbxRol.Size = New System.Drawing.Size(240, 27)
        Me.cbxRol.TabIndex = 69
        Me.ToolTip1.SetToolTip(Me.cbxRol, "Rol que ejerce el usuario")
        '
        'pbEliminar
        '
        Me.pbEliminar.BackgroundImage = CType(resources.GetObject("pbEliminar.BackgroundImage"), System.Drawing.Image)
        Me.pbEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbEliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbEliminar.Location = New System.Drawing.Point(428, 302)
        Me.pbEliminar.Name = "pbEliminar"
        Me.pbEliminar.Size = New System.Drawing.Size(30, 30)
        Me.pbEliminar.TabIndex = 53
        Me.pbEliminar.TabStop = False
        Me.ToolTip1.SetToolTip(Me.pbEliminar, "Eliminar ")
        '
        'pbModificar
        '
        Me.pbModificar.BackgroundImage = CType(resources.GetObject("pbModificar.BackgroundImage"), System.Drawing.Image)
        Me.pbModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbModificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbModificar.Location = New System.Drawing.Point(372, 302)
        Me.pbModificar.Name = "pbModificar"
        Me.pbModificar.Size = New System.Drawing.Size(30, 30)
        Me.pbModificar.TabIndex = 52
        Me.pbModificar.TabStop = False
        Me.ToolTip1.SetToolTip(Me.pbModificar, "Modificar")
        '
        'txtCriterio
        '
        Me.txtCriterio.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txtCriterio.Location = New System.Drawing.Point(279, 66)
        Me.txtCriterio.Name = "txtCriterio"
        Me.txtCriterio.Size = New System.Drawing.Size(179, 27)
        Me.txtCriterio.TabIndex = 12
        '
        'rdbNombre
        '
        Me.rdbNombre.AutoSize = True
        Me.rdbNombre.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.rdbNombre.Location = New System.Drawing.Point(23, 72)
        Me.rdbNombre.Name = "rdbNombre"
        Me.rdbNombre.Size = New System.Drawing.Size(78, 22)
        Me.rdbNombre.TabIndex = 11
        Me.rdbNombre.Text = "Nombre"
        Me.rdbNombre.UseVisualStyleBackColor = True
        '
        'rdbId
        '
        Me.rdbId.AutoSize = True
        Me.rdbId.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.rdbId.Location = New System.Drawing.Point(134, 71)
        Me.rdbId.Name = "rdbId"
        Me.rdbId.Size = New System.Drawing.Size(69, 22)
        Me.rdbId.TabIndex = 10
        Me.rdbId.Text = "Cédula"
        Me.rdbId.UseVisualStyleBackColor = True
        '
        'dvgUsuario
        '
        Me.dvgUsuario.AllowUserToAddRows = False
        Me.dvgUsuario.AllowUserToDeleteRows = False
        Me.dvgUsuario.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dvgUsuario.ColumnHeadersHeight = 26
        Me.dvgUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dvgUsuario.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cedula, Me.nom, Me.ap1, Me.ap2})
        Me.dvgUsuario.Location = New System.Drawing.Point(23, 111)
        Me.dvgUsuario.Name = "dvgUsuario"
        Me.dvgUsuario.ReadOnly = True
        Me.dvgUsuario.RowHeadersVisible = False
        Me.dvgUsuario.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dvgUsuario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dvgUsuario.Size = New System.Drawing.Size(435, 176)
        Me.dvgUsuario.TabIndex = 13
        '
        'cedula
        '
        Me.cedula.HeaderText = "Cédula"
        Me.cedula.MinimumWidth = 100
        Me.cedula.Name = "cedula"
        Me.cedula.ReadOnly = True
        Me.cedula.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'nom
        '
        Me.nom.HeaderText = "Nombre"
        Me.nom.MinimumWidth = 100
        Me.nom.Name = "nom"
        Me.nom.ReadOnly = True
        Me.nom.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'ap1
        '
        Me.ap1.HeaderText = " Primer Apellido"
        Me.ap1.MinimumWidth = 120
        Me.ap1.Name = "ap1"
        Me.ap1.ReadOnly = True
        Me.ap1.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ap1.Width = 120
        '
        'ap2
        '
        Me.ap2.HeaderText = "Segundo Apellido"
        Me.ap2.MinimumWidth = 123
        Me.ap2.Name = "ap2"
        Me.ap2.ReadOnly = True
        Me.ap2.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ap2.Width = 123
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel1.Controls.Add(Me.gbModificarUsuario)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Location = New System.Drawing.Point(32, -4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(940, 581)
        Me.Panel1.TabIndex = 74
        '
        'gbModificarUsuario
        '
        Me.gbModificarUsuario.Controls.Add(Me.cbxRol)
        Me.gbModificarUsuario.Controls.Add(Me.cbxDepartamento)
        Me.gbModificarUsuario.Controls.Add(Me.lblCorreo)
        Me.gbModificarUsuario.Controls.Add(Me.lblDepartamento)
        Me.gbModificarUsuario.Controls.Add(Me.lblRol)
        Me.gbModificarUsuario.Controls.Add(Me.txtCod)
        Me.gbModificarUsuario.Controls.Add(Me.txtCorreo)
        Me.gbModificarUsuario.Controls.Add(Me.lblNombre)
        Me.gbModificarUsuario.Controls.Add(Me.txtApellido2)
        Me.gbModificarUsuario.Controls.Add(Me.pbModificar2)
        Me.gbModificarUsuario.Controls.Add(Me.lblCedula)
        Me.gbModificarUsuario.Controls.Add(Me.txtNombre)
        Me.gbModificarUsuario.Controls.Add(Me.lblApellido2)
        Me.gbModificarUsuario.Controls.Add(Me.txtApellido1)
        Me.gbModificarUsuario.Controls.Add(Me.lblApellido1)
        Me.gbModificarUsuario.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbModificarUsuario.Location = New System.Drawing.Point(513, 26)
        Me.gbModificarUsuario.Name = "gbModificarUsuario"
        Me.gbModificarUsuario.Size = New System.Drawing.Size(399, 385)
        Me.gbModificarUsuario.TabIndex = 75
        Me.gbModificarUsuario.TabStop = False
        Me.gbModificarUsuario.Text = "Modificar Usuario"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dvgUsuario)
        Me.GroupBox1.Controls.Add(Me.rdbId)
        Me.GroupBox1.Controls.Add(Me.rdbNombre)
        Me.GroupBox1.Controls.Add(Me.txtCriterio)
        Me.GroupBox1.Controls.Add(Me.pbModificar)
        Me.GroupBox1.Controls.Add(Me.pbEliminar)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(3, 25)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(484, 386)
        Me.GroupBox1.TabIndex = 74
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Buscar Usuario"
        '
        'ctlBuscar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Controls.Add(Me.Panel1)
        Me.Name = "ctlBuscar"
        Me.Size = New System.Drawing.Size(1024, 700)
        CType(Me.pbModificar2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbEliminar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbModificar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dvgUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.gbModificarUsuario.ResumeLayout(False)
        Me.gbModificarUsuario.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents txtCod As System.Windows.Forms.TextBox
    Friend WithEvents pbModificar2 As System.Windows.Forms.PictureBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtApellido1 As System.Windows.Forms.TextBox
    Friend WithEvents lblApellido1 As System.Windows.Forms.Label
    Friend WithEvents lblApellido2 As System.Windows.Forms.Label
    Friend WithEvents lblCedula As System.Windows.Forms.Label
    Friend WithEvents txtApellido2 As System.Windows.Forms.TextBox
    Friend WithEvents txtCorreo As System.Windows.Forms.TextBox
    Friend WithEvents lblRol As System.Windows.Forms.Label
    Friend WithEvents lblDepartamento As System.Windows.Forms.Label
    Friend WithEvents lblCorreo As System.Windows.Forms.Label
    Friend WithEvents cbxDepartamento As System.Windows.Forms.ComboBox
    Friend WithEvents cbxRol As System.Windows.Forms.ComboBox
    Friend WithEvents dvgUsuario As System.Windows.Forms.DataGridView
    Friend WithEvents rdbId As System.Windows.Forms.RadioButton
    Friend WithEvents rdbNombre As System.Windows.Forms.RadioButton
    Friend WithEvents txtCriterio As System.Windows.Forms.TextBox
    Friend WithEvents pbModificar As System.Windows.Forms.PictureBox
    Friend WithEvents pbEliminar As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents gbModificarUsuario As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents cedula As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nom As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ap1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ap2 As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
