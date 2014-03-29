<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctlBuscarCliente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ctlBuscarCliente))
        Me.help = New System.Windows.Forms.ToolTip(Me.components)
        Me.pbModificar = New System.Windows.Forms.PictureBox
        Me.pbEliminar = New System.Windows.Forms.PictureBox
        Me.txtCorreo = New System.Windows.Forms.TextBox
        Me.txtContacto = New System.Windows.Forms.TextBox
        Me.txtNombre = New System.Windows.Forms.TextBox
        Me.txtDireccion = New System.Windows.Forms.TextBox
        Me.pbConfirmarModificacion = New System.Windows.Forms.PictureBox
        Me.txtTelefono = New System.Windows.Forms.MaskedTextBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.gpbModificarCliente = New System.Windows.Forms.GroupBox
        Me.txtId = New System.Windows.Forms.TextBox
        Me.lblIdCliente = New System.Windows.Forms.Label
        Me.lblNombre = New System.Windows.Forms.Label
        Me.lblDireccion = New System.Windows.Forms.Label
        Me.lblTelefono = New System.Windows.Forms.Label
        Me.lblCorreo = New System.Windows.Forms.Label
        Me.lblContacto = New System.Windows.Forms.Label
        Me.gpbBuscarCliente = New System.Windows.Forms.GroupBox
        Me.dvgClientes = New System.Windows.Forms.DataGridView
        Me.txtCriterioB = New System.Windows.Forms.TextBox
        Me.rdbId = New System.Windows.Forms.RadioButton
        Me.rdbNombre = New System.Windows.Forms.RadioButton
        CType(Me.pbModificar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbEliminar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbConfirmarModificacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.gpbModificarCliente.SuspendLayout()
        Me.gpbBuscarCliente.SuspendLayout()
        CType(Me.dvgClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbModificar
        '
        Me.pbModificar.BackgroundImage = CType(resources.GetObject("pbModificar.BackgroundImage"), System.Drawing.Image)
        Me.pbModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pbModificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbModificar.Location = New System.Drawing.Point(472, 335)
        Me.pbModificar.Name = "pbModificar"
        Me.pbModificar.Size = New System.Drawing.Size(30, 30)
        Me.pbModificar.TabIndex = 17
        Me.pbModificar.TabStop = False
        Me.help.SetToolTip(Me.pbModificar, "Modificar")
        '
        'pbEliminar
        '
        Me.pbEliminar.BackgroundImage = CType(resources.GetObject("pbEliminar.BackgroundImage"), System.Drawing.Image)
        Me.pbEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pbEliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbEliminar.Location = New System.Drawing.Point(529, 335)
        Me.pbEliminar.Name = "pbEliminar"
        Me.pbEliminar.Size = New System.Drawing.Size(30, 30)
        Me.pbEliminar.TabIndex = 18
        Me.pbEliminar.TabStop = False
        Me.help.SetToolTip(Me.pbEliminar, "Eliminar")
        '
        'txtCorreo
        '
        Me.txtCorreo.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.txtCorreo.Location = New System.Drawing.Point(129, 220)
        Me.txtCorreo.MaxLength = 50
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.Size = New System.Drawing.Size(201, 26)
        Me.txtCorreo.TabIndex = 4
        Me.help.SetToolTip(Me.txtCorreo, "Ej.: cliente@argus.com")
        '
        'txtContacto
        '
        Me.txtContacto.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.txtContacto.Location = New System.Drawing.Point(129, 267)
        Me.txtContacto.MaxLength = 50
        Me.txtContacto.Name = "txtContacto"
        Me.txtContacto.Size = New System.Drawing.Size(201, 26)
        Me.txtContacto.TabIndex = 5
        Me.help.SetToolTip(Me.txtContacto, "Ej.: Manuel Quesada Mate")
        '
        'txtNombre
        '
        Me.txtNombre.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.txtNombre.Location = New System.Drawing.Point(129, 108)
        Me.txtNombre.MaxLength = 50
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(201, 26)
        Me.txtNombre.TabIndex = 2
        Me.help.SetToolTip(Me.txtNombre, "Ej.: INA o Eduardo Solano Mate")
        '
        'txtDireccion
        '
        Me.txtDireccion.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.txtDireccion.Location = New System.Drawing.Point(129, 323)
        Me.txtDireccion.MaxLength = 50
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(201, 26)
        Me.txtDireccion.TabIndex = 6
        Me.help.SetToolTip(Me.txtDireccion, "San Jose")
        '
        'pbConfirmarModificacion
        '
        Me.pbConfirmarModificacion.BackgroundImage = CType(resources.GetObject("pbConfirmarModificacion.BackgroundImage"), System.Drawing.Image)
        Me.pbConfirmarModificacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pbConfirmarModificacion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbConfirmarModificacion.Location = New System.Drawing.Point(301, 355)
        Me.pbConfirmarModificacion.Name = "pbConfirmarModificacion"
        Me.pbConfirmarModificacion.Size = New System.Drawing.Size(30, 30)
        Me.pbConfirmarModificacion.TabIndex = 59
        Me.pbConfirmarModificacion.TabStop = False
        Me.help.SetToolTip(Me.pbConfirmarModificacion, "Cofirmar Modificación")
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(129, 163)
        Me.txtTelefono.Mask = "0000-0000"
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(202, 26)
        Me.txtTelefono.TabIndex = 3
        Me.help.SetToolTip(Me.txtTelefono, "2555-5555")
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel1.Controls.Add(Me.gpbModificarCliente)
        Me.Panel1.Controls.Add(Me.gpbBuscarCliente)
        Me.Panel1.Location = New System.Drawing.Point(14, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(990, 532)
        Me.Panel1.TabIndex = 61
        '
        'gpbModificarCliente
        '
        Me.gpbModificarCliente.Controls.Add(Me.txtTelefono)
        Me.gpbModificarCliente.Controls.Add(Me.pbConfirmarModificacion)
        Me.gpbModificarCliente.Controls.Add(Me.txtId)
        Me.gpbModificarCliente.Controls.Add(Me.lblIdCliente)
        Me.gpbModificarCliente.Controls.Add(Me.lblNombre)
        Me.gpbModificarCliente.Controls.Add(Me.txtDireccion)
        Me.gpbModificarCliente.Controls.Add(Me.txtNombre)
        Me.gpbModificarCliente.Controls.Add(Me.lblDireccion)
        Me.gpbModificarCliente.Controls.Add(Me.lblTelefono)
        Me.gpbModificarCliente.Controls.Add(Me.txtContacto)
        Me.gpbModificarCliente.Controls.Add(Me.lblCorreo)
        Me.gpbModificarCliente.Controls.Add(Me.lblContacto)
        Me.gpbModificarCliente.Controls.Add(Me.txtCorreo)
        Me.gpbModificarCliente.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpbModificarCliente.Location = New System.Drawing.Point(604, 35)
        Me.gpbModificarCliente.Name = "gpbModificarCliente"
        Me.gpbModificarCliente.Size = New System.Drawing.Size(365, 407)
        Me.gpbModificarCliente.TabIndex = 60
        Me.gpbModificarCliente.TabStop = False
        Me.gpbModificarCliente.Text = "Modificar Cliente"
        Me.gpbModificarCliente.Visible = False
        '
        'txtId
        '
        Me.txtId.Enabled = False
        Me.txtId.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.txtId.Location = New System.Drawing.Point(129, 56)
        Me.txtId.Name = "txtId"
        Me.txtId.ReadOnly = True
        Me.txtId.Size = New System.Drawing.Size(201, 26)
        Me.txtId.TabIndex = 46
        '
        'lblIdCliente
        '
        Me.lblIdCliente.AutoSize = True
        Me.lblIdCliente.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIdCliente.Location = New System.Drawing.Point(16, 61)
        Me.lblIdCliente.Name = "lblIdCliente"
        Me.lblIdCliente.Size = New System.Drawing.Size(88, 18)
        Me.lblIdCliente.TabIndex = 45
        Me.lblIdCliente.Text = "Identificador"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(16, 116)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(60, 18)
        Me.lblNombre.TabIndex = 47
        Me.lblNombre.Text = "Nombre"
        '
        'lblDireccion
        '
        Me.lblDireccion.AutoSize = True
        Me.lblDireccion.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDireccion.Location = New System.Drawing.Point(17, 326)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Size = New System.Drawing.Size(65, 18)
        Me.lblDireccion.TabIndex = 55
        Me.lblDireccion.Text = "Dirección"
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefono.Location = New System.Drawing.Point(17, 163)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(65, 18)
        Me.lblTelefono.TabIndex = 51
        Me.lblTelefono.Text = "Teléfono"
        '
        'lblCorreo
        '
        Me.lblCorreo.AutoSize = True
        Me.lblCorreo.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCorreo.Location = New System.Drawing.Point(16, 223)
        Me.lblCorreo.Name = "lblCorreo"
        Me.lblCorreo.Size = New System.Drawing.Size(98, 18)
        Me.lblCorreo.TabIndex = 53
        Me.lblCorreo.Text = "Correo Cliente"
        '
        'lblContacto
        '
        Me.lblContacto.AutoSize = True
        Me.lblContacto.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContacto.Location = New System.Drawing.Point(16, 270)
        Me.lblContacto.Name = "lblContacto"
        Me.lblContacto.Size = New System.Drawing.Size(66, 18)
        Me.lblContacto.TabIndex = 49
        Me.lblContacto.Text = "Contacto"
        '
        'gpbBuscarCliente
        '
        Me.gpbBuscarCliente.Controls.Add(Me.pbEliminar)
        Me.gpbBuscarCliente.Controls.Add(Me.pbModificar)
        Me.gpbBuscarCliente.Controls.Add(Me.dvgClientes)
        Me.gpbBuscarCliente.Controls.Add(Me.txtCriterioB)
        Me.gpbBuscarCliente.Controls.Add(Me.rdbId)
        Me.gpbBuscarCliente.Controls.Add(Me.rdbNombre)
        Me.gpbBuscarCliente.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpbBuscarCliente.Location = New System.Drawing.Point(13, 35)
        Me.gpbBuscarCliente.Name = "gpbBuscarCliente"
        Me.gpbBuscarCliente.Size = New System.Drawing.Size(585, 407)
        Me.gpbBuscarCliente.TabIndex = 61
        Me.gpbBuscarCliente.TabStop = False
        Me.gpbBuscarCliente.Text = "Buscar Cliente"
        '
        'dvgClientes
        '
        Me.dvgClientes.AllowUserToAddRows = False
        Me.dvgClientes.AllowUserToDeleteRows = False
        Me.dvgClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dvgClientes.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dvgClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dvgClientes.Location = New System.Drawing.Point(20, 143)
        Me.dvgClientes.Name = "dvgClientes"
        Me.dvgClientes.ReadOnly = True
        Me.dvgClientes.RowHeadersVisible = False
        Me.dvgClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dvgClientes.Size = New System.Drawing.Size(539, 176)
        Me.dvgClientes.TabIndex = 14
        '
        'txtCriterioB
        '
        Me.txtCriterioB.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txtCriterioB.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.txtCriterioB.Location = New System.Drawing.Point(152, 64)
        Me.txtCriterioB.MaxLength = 50
        Me.txtCriterioB.Name = "txtCriterioB"
        Me.txtCriterioB.Size = New System.Drawing.Size(201, 26)
        Me.txtCriterioB.TabIndex = 1
        '
        'rdbId
        '
        Me.rdbId.AutoSize = True
        Me.rdbId.Checked = True
        Me.rdbId.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.rdbId.Location = New System.Drawing.Point(30, 57)
        Me.rdbId.Name = "rdbId"
        Me.rdbId.Size = New System.Drawing.Size(106, 22)
        Me.rdbId.TabIndex = 10
        Me.rdbId.TabStop = True
        Me.rdbId.Text = "Identificador"
        Me.rdbId.UseVisualStyleBackColor = True
        '
        'rdbNombre
        '
        Me.rdbNombre.AutoSize = True
        Me.rdbNombre.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.rdbNombre.Location = New System.Drawing.Point(30, 84)
        Me.rdbNombre.Name = "rdbNombre"
        Me.rdbNombre.Size = New System.Drawing.Size(78, 22)
        Me.rdbNombre.TabIndex = 11
        Me.rdbNombre.Text = "Nombre"
        Me.rdbNombre.UseVisualStyleBackColor = True
        '
        'ctlBuscarCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Controls.Add(Me.Panel1)
        Me.Name = "ctlBuscarCliente"
        Me.Size = New System.Drawing.Size(1024, 700)
        CType(Me.pbModificar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbEliminar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbConfirmarModificacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.gpbModificarCliente.ResumeLayout(False)
        Me.gpbModificarCliente.PerformLayout()
        Me.gpbBuscarCliente.ResumeLayout(False)
        Me.gpbBuscarCliente.PerformLayout()
        CType(Me.dvgClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents help As System.Windows.Forms.ToolTip
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents gpbModificarCliente As System.Windows.Forms.GroupBox
    Friend WithEvents txtTelefono As System.Windows.Forms.MaskedTextBox
    Friend WithEvents pbConfirmarModificacion As System.Windows.Forms.PictureBox
    Friend WithEvents txtId As System.Windows.Forms.TextBox
    Friend WithEvents lblIdCliente As System.Windows.Forms.Label
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents lblDireccion As System.Windows.Forms.Label
    Friend WithEvents lblTelefono As System.Windows.Forms.Label
    Friend WithEvents txtContacto As System.Windows.Forms.TextBox
    Friend WithEvents lblCorreo As System.Windows.Forms.Label
    Friend WithEvents lblContacto As System.Windows.Forms.Label
    Friend WithEvents txtCorreo As System.Windows.Forms.TextBox
    Friend WithEvents gpbBuscarCliente As System.Windows.Forms.GroupBox
    Friend WithEvents pbEliminar As System.Windows.Forms.PictureBox
    Friend WithEvents pbModificar As System.Windows.Forms.PictureBox
    Friend WithEvents dvgClientes As System.Windows.Forms.DataGridView
    Friend WithEvents txtCriterioB As System.Windows.Forms.TextBox
    Friend WithEvents rdbId As System.Windows.Forms.RadioButton
    Friend WithEvents rdbNombre As System.Windows.Forms.RadioButton

End Class
