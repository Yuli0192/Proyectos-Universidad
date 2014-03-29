<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctlRegistrarCliente
    Inherits System.Windows.Forms.UserControl

    'UserControl1 overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ctlRegistrarCliente))
        Me.help = New System.Windows.Forms.ToolTip(Me.components)
        Me.txtTelefono = New System.Windows.Forms.MaskedTextBox
        Me.txtId = New System.Windows.Forms.TextBox
        Me.pbRegistrar = New System.Windows.Forms.PictureBox
        Me.pbLimpiar = New System.Windows.Forms.PictureBox
        Me.txtNombre = New System.Windows.Forms.TextBox
        Me.txtDireccion = New System.Windows.Forms.TextBox
        Me.txtContacto = New System.Windows.Forms.TextBox
        Me.txtCorreo = New System.Windows.Forms.TextBox
        Me.gpbRegistrar = New System.Windows.Forms.GroupBox
        Me.lblIdCliente = New System.Windows.Forms.Label
        Me.lblNombre = New System.Windows.Forms.Label
        Me.lblDireccion = New System.Windows.Forms.Label
        Me.lblTelefono = New System.Windows.Forms.Label
        Me.lblContacto = New System.Windows.Forms.Label
        Me.lblCorreo = New System.Windows.Forms.Label
        CType(Me.pbRegistrar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbLimpiar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpbRegistrar.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtTelefono
        '
        Me.txtTelefono.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.txtTelefono.Location = New System.Drawing.Point(152, 151)
        Me.txtTelefono.Mask = "0000-0000"
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(201, 25)
        Me.txtTelefono.TabIndex = 3
        Me.help.SetToolTip(Me.txtTelefono, "2222-2222")
        '
        'txtId
        '
        Me.txtId.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.txtId.Location = New System.Drawing.Point(152, 65)
        Me.txtId.MaxLength = 50
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(201, 26)
        Me.txtId.TabIndex = 1
        Me.help.SetToolTip(Me.txtId, "Ej.: 3224307")
        '
        'pbRegistrar
        '
        Me.pbRegistrar.BackgroundImage = CType(resources.GetObject("pbRegistrar.BackgroundImage"), System.Drawing.Image)
        Me.pbRegistrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbRegistrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbRegistrar.Location = New System.Drawing.Point(266, 342)
        Me.pbRegistrar.Name = "pbRegistrar"
        Me.pbRegistrar.Size = New System.Drawing.Size(30, 30)
        Me.pbRegistrar.TabIndex = 28
        Me.pbRegistrar.TabStop = False
        Me.help.SetToolTip(Me.pbRegistrar, "Registrar")
        '
        'pbLimpiar
        '
        Me.pbLimpiar.BackgroundImage = CType(resources.GetObject("pbLimpiar.BackgroundImage"), System.Drawing.Image)
        Me.pbLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbLimpiar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbLimpiar.Location = New System.Drawing.Point(323, 342)
        Me.pbLimpiar.Name = "pbLimpiar"
        Me.pbLimpiar.Size = New System.Drawing.Size(30, 30)
        Me.pbLimpiar.TabIndex = 29
        Me.pbLimpiar.TabStop = False
        Me.help.SetToolTip(Me.pbLimpiar, "Limpiar")
        '
        'txtNombre
        '
        Me.txtNombre.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.txtNombre.Location = New System.Drawing.Point(153, 109)
        Me.txtNombre.MaxLength = 50
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(201, 26)
        Me.txtNombre.TabIndex = 2
        Me.help.SetToolTip(Me.txtNombre, "Ej.: INA o Eduardo Solano Mate")
        '
        'txtDireccion
        '
        Me.txtDireccion.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.txtDireccion.Location = New System.Drawing.Point(152, 296)
        Me.txtDireccion.MaxLength = 256
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(201, 26)
        Me.txtDireccion.TabIndex = 6
        Me.help.SetToolTip(Me.txtDireccion, "San Jose")
        '
        'txtContacto
        '
        Me.txtContacto.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.txtContacto.Location = New System.Drawing.Point(152, 247)
        Me.txtContacto.MaxLength = 50
        Me.txtContacto.Name = "txtContacto"
        Me.txtContacto.Size = New System.Drawing.Size(201, 26)
        Me.txtContacto.TabIndex = 5
        Me.help.SetToolTip(Me.txtContacto, "Ej.: Manuel Quesada Mate")
        '
        'txtCorreo
        '
        Me.txtCorreo.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.txtCorreo.Location = New System.Drawing.Point(152, 202)
        Me.txtCorreo.MaxLength = 50
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.Size = New System.Drawing.Size(201, 26)
        Me.txtCorreo.TabIndex = 4
        Me.help.SetToolTip(Me.txtCorreo, "Ej.: cliente@argus.com")
        '
        'gpbRegistrar
        '
        Me.gpbRegistrar.Controls.Add(Me.txtTelefono)
        Me.gpbRegistrar.Controls.Add(Me.txtId)
        Me.gpbRegistrar.Controls.Add(Me.lblIdCliente)
        Me.gpbRegistrar.Controls.Add(Me.pbRegistrar)
        Me.gpbRegistrar.Controls.Add(Me.pbLimpiar)
        Me.gpbRegistrar.Controls.Add(Me.txtNombre)
        Me.gpbRegistrar.Controls.Add(Me.lblNombre)
        Me.gpbRegistrar.Controls.Add(Me.txtDireccion)
        Me.gpbRegistrar.Controls.Add(Me.lblDireccion)
        Me.gpbRegistrar.Controls.Add(Me.lblTelefono)
        Me.gpbRegistrar.Controls.Add(Me.txtContacto)
        Me.gpbRegistrar.Controls.Add(Me.lblContacto)
        Me.gpbRegistrar.Controls.Add(Me.txtCorreo)
        Me.gpbRegistrar.Controls.Add(Me.lblCorreo)
        Me.gpbRegistrar.Font = New System.Drawing.Font("Tahoma", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpbRegistrar.Location = New System.Drawing.Point(295, 76)
        Me.gpbRegistrar.Name = "gpbRegistrar"
        Me.gpbRegistrar.Size = New System.Drawing.Size(402, 407)
        Me.gpbRegistrar.TabIndex = 32
        Me.gpbRegistrar.TabStop = False
        Me.gpbRegistrar.Text = "Registrar Cliente"
        '
        'lblIdCliente
        '
        Me.lblIdCliente.AutoSize = True
        Me.lblIdCliente.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIdCliente.Location = New System.Drawing.Point(38, 73)
        Me.lblIdCliente.Name = "lblIdCliente"
        Me.lblIdCliente.Size = New System.Drawing.Size(88, 18)
        Me.lblIdCliente.TabIndex = 13
        Me.lblIdCliente.Text = "Identificador"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(39, 117)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(60, 18)
        Me.lblNombre.TabIndex = 15
        Me.lblNombre.Text = "Nombre"
        '
        'lblDireccion
        '
        Me.lblDireccion.AutoSize = True
        Me.lblDireccion.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDireccion.Location = New System.Drawing.Point(39, 296)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Size = New System.Drawing.Size(65, 18)
        Me.lblDireccion.TabIndex = 23
        Me.lblDireccion.Text = "Dirección"
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefono.Location = New System.Drawing.Point(38, 161)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(65, 18)
        Me.lblTelefono.TabIndex = 19
        Me.lblTelefono.Text = "Teléfono"
        '
        'lblContacto
        '
        Me.lblContacto.AutoSize = True
        Me.lblContacto.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContacto.Location = New System.Drawing.Point(39, 250)
        Me.lblContacto.Name = "lblContacto"
        Me.lblContacto.Size = New System.Drawing.Size(66, 18)
        Me.lblContacto.TabIndex = 17
        Me.lblContacto.Text = "Contacto"
        '
        'lblCorreo
        '
        Me.lblCorreo.AutoSize = True
        Me.lblCorreo.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCorreo.Location = New System.Drawing.Point(38, 210)
        Me.lblCorreo.Name = "lblCorreo"
        Me.lblCorreo.Size = New System.Drawing.Size(98, 18)
        Me.lblCorreo.TabIndex = 21
        Me.lblCorreo.Text = "Correo Cliente"
        '
        'ctlRegistrarCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Controls.Add(Me.gpbRegistrar)
        Me.Name = "ctlRegistrarCliente"
        Me.Size = New System.Drawing.Size(1024, 700)
        CType(Me.pbRegistrar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbLimpiar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpbRegistrar.ResumeLayout(False)
        Me.gpbRegistrar.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents help As System.Windows.Forms.ToolTip
    Friend WithEvents gpbRegistrar As System.Windows.Forms.GroupBox
    Friend WithEvents txtTelefono As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtId As System.Windows.Forms.TextBox
    Friend WithEvents lblIdCliente As System.Windows.Forms.Label
    Friend WithEvents pbRegistrar As System.Windows.Forms.PictureBox
    Friend WithEvents pbLimpiar As System.Windows.Forms.PictureBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents lblDireccion As System.Windows.Forms.Label
    Friend WithEvents lblTelefono As System.Windows.Forms.Label
    Friend WithEvents txtContacto As System.Windows.Forms.TextBox
    Friend WithEvents lblContacto As System.Windows.Forms.Label
    Friend WithEvents txtCorreo As System.Windows.Forms.TextBox
    Friend WithEvents lblCorreo As System.Windows.Forms.Label

End Class
