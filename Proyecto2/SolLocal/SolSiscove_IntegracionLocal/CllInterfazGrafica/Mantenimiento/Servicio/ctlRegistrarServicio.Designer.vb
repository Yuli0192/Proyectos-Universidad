<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctlRegistrarServicio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ctlRegistrarServicio))
        Me.ttRegistrar = New System.Windows.Forms.ToolTip(Me.components)
        Me.txtJuniorDolares = New System.Windows.Forms.TextBox
        Me.txtJuniorColones = New System.Windows.Forms.TextBox
        Me.txtMasterDolares = New System.Windows.Forms.TextBox
        Me.txtMasterColones = New System.Windows.Forms.TextBox
        Me.txtSeniorDolares = New System.Windows.Forms.TextBox
        Me.txtSeniorColones = New System.Windows.Forms.TextBox
        Me.pbLimpiar = New System.Windows.Forms.PictureBox
        Me.pbReg = New System.Windows.Forms.PictureBox
        Me.txtCod = New System.Windows.Forms.TextBox
        Me.txtNombre = New System.Windows.Forms.TextBox
        Me.txtPrecioDolares = New System.Windows.Forms.TextBox
        Me.txtDescripcion = New System.Windows.Forms.TextBox
        Me.txtPrecioColones = New System.Windows.Forms.TextBox
        Me.gpRegistrarServicio = New System.Windows.Forms.GroupBox
        Me.Porcentajes = New System.Windows.Forms.GroupBox
        Me.lblJuniorColones = New System.Windows.Forms.Label
        Me.lblJuniorDolares = New System.Windows.Forms.Label
        Me.lblSeniorColones = New System.Windows.Forms.Label
        Me.lblSeniorDolares = New System.Windows.Forms.Label
        Me.lblMasterColones = New System.Windows.Forms.Label
        Me.lblMasterDolares = New System.Windows.Forms.Label
        Me.lbldentificador = New System.Windows.Forms.Label
        Me.lblNombre = New System.Windows.Forms.Label
        Me.lblPrecioDolares = New System.Windows.Forms.Label
        Me.lblDescripcion = New System.Windows.Forms.Label
        Me.lblPrecioColones = New System.Windows.Forms.Label
        CType(Me.pbLimpiar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbReg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpRegistrarServicio.SuspendLayout()
        Me.Porcentajes.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtJuniorDolares
        '
        Me.txtJuniorDolares.Location = New System.Drawing.Point(238, 58)
        Me.txtJuniorDolares.MaxLength = 13
        Me.txtJuniorDolares.Name = "txtJuniorDolares"
        Me.txtJuniorDolares.Size = New System.Drawing.Size(87, 27)
        Me.txtJuniorDolares.TabIndex = 7
        Me.ttRegistrar.SetToolTip(Me.txtJuniorDolares, "14000")
        '
        'txtJuniorColones
        '
        Me.txtJuniorColones.Location = New System.Drawing.Point(238, 29)
        Me.txtJuniorColones.MaxLength = 13
        Me.txtJuniorColones.Name = "txtJuniorColones"
        Me.txtJuniorColones.Size = New System.Drawing.Size(87, 27)
        Me.txtJuniorColones.TabIndex = 6
        Me.ttRegistrar.SetToolTip(Me.txtJuniorColones, "14000")
        '
        'txtMasterDolares
        '
        Me.txtMasterDolares.Location = New System.Drawing.Point(238, 174)
        Me.txtMasterDolares.MaxLength = 13
        Me.txtMasterDolares.Name = "txtMasterDolares"
        Me.txtMasterDolares.Size = New System.Drawing.Size(87, 27)
        Me.txtMasterDolares.TabIndex = 11
        Me.ttRegistrar.SetToolTip(Me.txtMasterDolares, "14000")
        '
        'txtMasterColones
        '
        Me.txtMasterColones.Location = New System.Drawing.Point(238, 145)
        Me.txtMasterColones.MaxLength = 13
        Me.txtMasterColones.Name = "txtMasterColones"
        Me.txtMasterColones.Size = New System.Drawing.Size(87, 27)
        Me.txtMasterColones.TabIndex = 10
        Me.ttRegistrar.SetToolTip(Me.txtMasterColones, "14000")
        '
        'txtSeniorDolares
        '
        Me.txtSeniorDolares.Location = New System.Drawing.Point(238, 116)
        Me.txtSeniorDolares.MaxLength = 13
        Me.txtSeniorDolares.Name = "txtSeniorDolares"
        Me.txtSeniorDolares.Size = New System.Drawing.Size(87, 27)
        Me.txtSeniorDolares.TabIndex = 9
        Me.ttRegistrar.SetToolTip(Me.txtSeniorDolares, "14000")
        '
        'txtSeniorColones
        '
        Me.txtSeniorColones.Location = New System.Drawing.Point(238, 87)
        Me.txtSeniorColones.MaxLength = 13
        Me.txtSeniorColones.Name = "txtSeniorColones"
        Me.txtSeniorColones.Size = New System.Drawing.Size(87, 27)
        Me.txtSeniorColones.TabIndex = 8
        Me.ttRegistrar.SetToolTip(Me.txtSeniorColones, "14000")
        '
        'pbLimpiar
        '
        Me.pbLimpiar.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.pbLimpiar.BackgroundImage = CType(resources.GetObject("pbLimpiar.BackgroundImage"), System.Drawing.Image)
        Me.pbLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbLimpiar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbLimpiar.Location = New System.Drawing.Point(377, 458)
        Me.pbLimpiar.Name = "pbLimpiar"
        Me.pbLimpiar.Size = New System.Drawing.Size(33, 33)
        Me.pbLimpiar.TabIndex = 55
        Me.pbLimpiar.TabStop = False
        Me.ttRegistrar.SetToolTip(Me.pbLimpiar, "Limpiar")
        '
        'pbReg
        '
        Me.pbReg.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.pbReg.BackgroundImage = CType(resources.GetObject("pbReg.BackgroundImage"), System.Drawing.Image)
        Me.pbReg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbReg.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbReg.Location = New System.Drawing.Point(319, 458)
        Me.pbReg.Name = "pbReg"
        Me.pbReg.Size = New System.Drawing.Size(33, 33)
        Me.pbReg.TabIndex = 54
        Me.pbReg.TabStop = False
        Me.ttRegistrar.SetToolTip(Me.pbReg, "Registrar")
        '
        'txtCod
        '
        Me.txtCod.BackColor = System.Drawing.Color.White
        Me.txtCod.Location = New System.Drawing.Point(182, 28)
        Me.txtCod.MaxLength = 15
        Me.txtCod.Name = "txtCod"
        Me.txtCod.Size = New System.Drawing.Size(228, 27)
        Me.txtCod.TabIndex = 1
        Me.ttRegistrar.SetToolTip(Me.txtCod, "Ej: PP-098")
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(182, 58)
        Me.txtNombre.MaxLength = 30
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(228, 27)
        Me.txtNombre.TabIndex = 2
        Me.ttRegistrar.SetToolTip(Me.txtNombre, "Ej: Power Point")
        '
        'txtPrecioDolares
        '
        Me.txtPrecioDolares.Location = New System.Drawing.Point(182, 180)
        Me.txtPrecioDolares.MaxLength = 13
        Me.txtPrecioDolares.Name = "txtPrecioDolares"
        Me.txtPrecioDolares.Size = New System.Drawing.Size(228, 27)
        Me.txtPrecioDolares.TabIndex = 5
        Me.ttRegistrar.SetToolTip(Me.txtPrecioDolares, "1000")
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(182, 88)
        Me.txtDescripcion.MaxLength = 256
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(228, 59)
        Me.txtDescripcion.TabIndex = 3
        Me.ttRegistrar.SetToolTip(Me.txtDescripcion, "Curso avanzado")
        '
        'txtPrecioColones
        '
        Me.txtPrecioColones.Location = New System.Drawing.Point(182, 150)
        Me.txtPrecioColones.MaxLength = 13
        Me.txtPrecioColones.Name = "txtPrecioColones"
        Me.txtPrecioColones.Size = New System.Drawing.Size(228, 27)
        Me.txtPrecioColones.TabIndex = 4
        Me.ttRegistrar.SetToolTip(Me.txtPrecioColones, "15000")
        '
        'gpRegistrarServicio
        '
        Me.gpRegistrarServicio.Controls.Add(Me.Porcentajes)
        Me.gpRegistrarServicio.Controls.Add(Me.pbLimpiar)
        Me.gpRegistrarServicio.Controls.Add(Me.pbReg)
        Me.gpRegistrarServicio.Controls.Add(Me.lbldentificador)
        Me.gpRegistrarServicio.Controls.Add(Me.txtCod)
        Me.gpRegistrarServicio.Controls.Add(Me.lblNombre)
        Me.gpRegistrarServicio.Controls.Add(Me.txtNombre)
        Me.gpRegistrarServicio.Controls.Add(Me.lblPrecioDolares)
        Me.gpRegistrarServicio.Controls.Add(Me.txtPrecioDolares)
        Me.gpRegistrarServicio.Controls.Add(Me.lblDescripcion)
        Me.gpRegistrarServicio.Controls.Add(Me.txtDescripcion)
        Me.gpRegistrarServicio.Controls.Add(Me.lblPrecioColones)
        Me.gpRegistrarServicio.Controls.Add(Me.txtPrecioColones)
        Me.gpRegistrarServicio.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.gpRegistrarServicio.Location = New System.Drawing.Point(273, 34)
        Me.gpRegistrarServicio.Name = "gpRegistrarServicio"
        Me.gpRegistrarServicio.Size = New System.Drawing.Size(465, 505)
        Me.gpRegistrarServicio.TabIndex = 60
        Me.gpRegistrarServicio.TabStop = False
        Me.gpRegistrarServicio.Text = "Registrar Servicio"
        '
        'Porcentajes
        '
        Me.Porcentajes.Controls.Add(Me.lblJuniorColones)
        Me.Porcentajes.Controls.Add(Me.txtJuniorDolares)
        Me.Porcentajes.Controls.Add(Me.txtJuniorColones)
        Me.Porcentajes.Controls.Add(Me.txtMasterDolares)
        Me.Porcentajes.Controls.Add(Me.lblJuniorDolares)
        Me.Porcentajes.Controls.Add(Me.txtMasterColones)
        Me.Porcentajes.Controls.Add(Me.lblSeniorColones)
        Me.Porcentajes.Controls.Add(Me.txtSeniorDolares)
        Me.Porcentajes.Controls.Add(Me.lblSeniorDolares)
        Me.Porcentajes.Controls.Add(Me.txtSeniorColones)
        Me.Porcentajes.Controls.Add(Me.lblMasterColones)
        Me.Porcentajes.Controls.Add(Me.lblMasterDolares)
        Me.Porcentajes.Location = New System.Drawing.Point(48, 209)
        Me.Porcentajes.Name = "Porcentajes"
        Me.Porcentajes.Size = New System.Drawing.Size(362, 231)
        Me.Porcentajes.TabIndex = 56
        Me.Porcentajes.TabStop = False
        Me.Porcentajes.Text = "Porcentajes"
        '
        'lblJuniorColones
        '
        Me.lblJuniorColones.AutoSize = True
        Me.lblJuniorColones.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblJuniorColones.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.lblJuniorColones.Location = New System.Drawing.Point(28, 38)
        Me.lblJuniorColones.Name = "lblJuniorColones"
        Me.lblJuniorColones.Size = New System.Drawing.Size(181, 18)
        Me.lblJuniorColones.TabIndex = 38
        Me.lblJuniorColones.Text = "Comision Junior en colones"
        '
        'lblJuniorDolares
        '
        Me.lblJuniorDolares.AutoSize = True
        Me.lblJuniorDolares.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblJuniorDolares.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.lblJuniorDolares.Location = New System.Drawing.Point(28, 67)
        Me.lblJuniorDolares.Name = "lblJuniorDolares"
        Me.lblJuniorDolares.Size = New System.Drawing.Size(179, 18)
        Me.lblJuniorDolares.TabIndex = 43
        Me.lblJuniorDolares.Text = "Comision Junior en dolares"
        '
        'lblSeniorColones
        '
        Me.lblSeniorColones.AutoSize = True
        Me.lblSeniorColones.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblSeniorColones.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.lblSeniorColones.Location = New System.Drawing.Point(28, 96)
        Me.lblSeniorColones.Name = "lblSeniorColones"
        Me.lblSeniorColones.Size = New System.Drawing.Size(183, 18)
        Me.lblSeniorColones.TabIndex = 44
        Me.lblSeniorColones.Text = "Comision Senior en colones"
        '
        'lblSeniorDolares
        '
        Me.lblSeniorDolares.AutoSize = True
        Me.lblSeniorDolares.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblSeniorDolares.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.lblSeniorDolares.Location = New System.Drawing.Point(28, 125)
        Me.lblSeniorDolares.Name = "lblSeniorDolares"
        Me.lblSeniorDolares.Size = New System.Drawing.Size(181, 18)
        Me.lblSeniorDolares.TabIndex = 45
        Me.lblSeniorDolares.Text = "Comision Senior en dolares"
        '
        'lblMasterColones
        '
        Me.lblMasterColones.AutoSize = True
        Me.lblMasterColones.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblMasterColones.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.lblMasterColones.Location = New System.Drawing.Point(28, 153)
        Me.lblMasterColones.Name = "lblMasterColones"
        Me.lblMasterColones.Size = New System.Drawing.Size(189, 18)
        Me.lblMasterColones.TabIndex = 46
        Me.lblMasterColones.Text = "Comision Master en colones"
        '
        'lblMasterDolares
        '
        Me.lblMasterDolares.AutoSize = True
        Me.lblMasterDolares.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblMasterDolares.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.lblMasterDolares.Location = New System.Drawing.Point(28, 183)
        Me.lblMasterDolares.Name = "lblMasterDolares"
        Me.lblMasterDolares.Size = New System.Drawing.Size(192, 18)
        Me.lblMasterDolares.TabIndex = 47
        Me.lblMasterDolares.Text = "Comision Master en dolares "
        '
        'lbldentificador
        '
        Me.lbldentificador.AutoSize = True
        Me.lbldentificador.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbldentificador.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.lbldentificador.Location = New System.Drawing.Point(45, 28)
        Me.lbldentificador.Name = "lbldentificador"
        Me.lbldentificador.Size = New System.Drawing.Size(88, 18)
        Me.lbldentificador.TabIndex = 27
        Me.lbldentificador.Text = "Identificador"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblNombre.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.lblNombre.Location = New System.Drawing.Point(45, 58)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(60, 18)
        Me.lblNombre.TabIndex = 30
        Me.lblNombre.Text = "Nombre"
        '
        'lblPrecioDolares
        '
        Me.lblPrecioDolares.AutoSize = True
        Me.lblPrecioDolares.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblPrecioDolares.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.lblPrecioDolares.Location = New System.Drawing.Point(45, 180)
        Me.lblPrecioDolares.Name = "lblPrecioDolares"
        Me.lblPrecioDolares.Size = New System.Drawing.Size(123, 18)
        Me.lblPrecioDolares.TabIndex = 32
        Me.lblPrecioDolares.Text = "Precio en dolares "
        '
        'lblDescripcion
        '
        Me.lblDescripcion.AutoSize = True
        Me.lblDescripcion.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblDescripcion.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.lblDescripcion.Location = New System.Drawing.Point(45, 88)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(80, 18)
        Me.lblDescripcion.TabIndex = 34
        Me.lblDescripcion.Text = "Descripcion"
        '
        'lblPrecioColones
        '
        Me.lblPrecioColones.AutoSize = True
        Me.lblPrecioColones.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblPrecioColones.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.lblPrecioColones.Location = New System.Drawing.Point(45, 150)
        Me.lblPrecioColones.Name = "lblPrecioColones"
        Me.lblPrecioColones.Size = New System.Drawing.Size(120, 18)
        Me.lblPrecioColones.TabIndex = 36
        Me.lblPrecioColones.Text = "Precio en colones"
        '
        'ctlRegistrarServicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Controls.Add(Me.gpRegistrarServicio)
        Me.Name = "ctlRegistrarServicio"
        Me.Size = New System.Drawing.Size(1024, 700)
        CType(Me.pbLimpiar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbReg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpRegistrarServicio.ResumeLayout(False)
        Me.gpRegistrarServicio.PerformLayout()
        Me.Porcentajes.ResumeLayout(False)
        Me.Porcentajes.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ttRegistrar As System.Windows.Forms.ToolTip
    Friend WithEvents gpRegistrarServicio As System.Windows.Forms.GroupBox
    Friend WithEvents Porcentajes As System.Windows.Forms.GroupBox
    Friend WithEvents lblJuniorColones As System.Windows.Forms.Label
    Friend WithEvents txtJuniorDolares As System.Windows.Forms.TextBox
    Friend WithEvents txtJuniorColones As System.Windows.Forms.TextBox
    Friend WithEvents txtMasterDolares As System.Windows.Forms.TextBox
    Friend WithEvents lblJuniorDolares As System.Windows.Forms.Label
    Friend WithEvents txtMasterColones As System.Windows.Forms.TextBox
    Friend WithEvents lblSeniorColones As System.Windows.Forms.Label
    Friend WithEvents txtSeniorDolares As System.Windows.Forms.TextBox
    Friend WithEvents lblSeniorDolares As System.Windows.Forms.Label
    Friend WithEvents txtSeniorColones As System.Windows.Forms.TextBox
    Friend WithEvents lblMasterColones As System.Windows.Forms.Label
    Friend WithEvents lblMasterDolares As System.Windows.Forms.Label
    Friend WithEvents pbLimpiar As System.Windows.Forms.PictureBox
    Friend WithEvents pbReg As System.Windows.Forms.PictureBox
    Friend WithEvents lbldentificador As System.Windows.Forms.Label
    Friend WithEvents txtCod As System.Windows.Forms.TextBox
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents lblPrecioDolares As System.Windows.Forms.Label
    Friend WithEvents txtPrecioDolares As System.Windows.Forms.TextBox
    Friend WithEvents lblDescripcion As System.Windows.Forms.Label
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents lblPrecioColones As System.Windows.Forms.Label
    Friend WithEvents txtPrecioColones As System.Windows.Forms.TextBox

End Class
