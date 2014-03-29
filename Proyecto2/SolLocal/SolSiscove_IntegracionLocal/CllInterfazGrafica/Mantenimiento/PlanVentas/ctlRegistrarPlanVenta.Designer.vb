<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctlRegistrarPlanVenta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ctlRegistrarPlanVenta))
        Me.help = New System.Windows.Forms.ToolTip(Me.components)
        Me.pbRegistrar = New System.Windows.Forms.PictureBox
        Me.pbLimpiar = New System.Windows.Forms.PictureBox
        Me.txtid = New System.Windows.Forms.TextBox
        Me.txtDescripcion = New System.Windows.Forms.TextBox
        Me.pbRegresarServicio = New System.Windows.Forms.PictureBox
        Me.pbInsertar = New System.Windows.Forms.PictureBox
        Me.txtVentasPlaneadas = New System.Windows.Forms.TextBox
        Me.gpbRegistrarPlan = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.gpbServicios = New System.Windows.Forms.GroupBox
        Me.lblVentasPlaneadas = New System.Windows.Forms.Label
        Me.lblServicio = New System.Windows.Forms.Label
        Me.ltbServicio = New System.Windows.Forms.ListBox
        Me.ltbPlanServicio = New System.Windows.Forms.ListBox
        Me.lblPlanServicio = New System.Windows.Forms.Label
        Me.lblDescripcion = New System.Windows.Forms.Label
        Me.dtpFin = New System.Windows.Forms.DateTimePicker
        Me.lblFechaFin = New System.Windows.Forms.Label
        Me.lblFechaInicio = New System.Windows.Forms.Label
        Me.dtpInicio = New System.Windows.Forms.DateTimePicker
        CType(Me.pbRegistrar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbLimpiar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbRegresarServicio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbInsertar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpbRegistrarPlan.SuspendLayout()
        Me.gpbServicios.SuspendLayout()
        Me.SuspendLayout()
        '
        'pbRegistrar
        '
        Me.pbRegistrar.BackgroundImage = CType(resources.GetObject("pbRegistrar.BackgroundImage"), System.Drawing.Image)
        Me.pbRegistrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pbRegistrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbRegistrar.Location = New System.Drawing.Point(438, 465)
        Me.pbRegistrar.Name = "pbRegistrar"
        Me.pbRegistrar.Size = New System.Drawing.Size(30, 30)
        Me.pbRegistrar.TabIndex = 41
        Me.pbRegistrar.TabStop = False
        Me.help.SetToolTip(Me.pbRegistrar, "Registrar")
        '
        'pbLimpiar
        '
        Me.pbLimpiar.BackgroundImage = CType(resources.GetObject("pbLimpiar.BackgroundImage"), System.Drawing.Image)
        Me.pbLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pbLimpiar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbLimpiar.Location = New System.Drawing.Point(484, 465)
        Me.pbLimpiar.Name = "pbLimpiar"
        Me.pbLimpiar.Size = New System.Drawing.Size(30, 30)
        Me.pbLimpiar.TabIndex = 42
        Me.pbLimpiar.TabStop = False
        Me.help.SetToolTip(Me.pbLimpiar, "Limpiar")
        '
        'txtid
        '
        Me.txtid.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.txtid.Location = New System.Drawing.Point(156, 33)
        Me.txtid.MaxLength = 50
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(213, 26)
        Me.txtid.TabIndex = 22
        Me.help.SetToolTip(Me.txtid, "Ej.: 234567")
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.txtDescripcion.Location = New System.Drawing.Point(50, 87)
        Me.txtDescripcion.MaxLength = 256
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(464, 76)
        Me.txtDescripcion.TabIndex = 24
        Me.help.SetToolTip(Me.txtDescripcion, "Ej.:Vender mucho")
        '
        'pbRegresarServicio
        '
        Me.pbRegresarServicio.BackgroundImage = CType(resources.GetObject("pbRegresarServicio.BackgroundImage"), System.Drawing.Image)
        Me.pbRegresarServicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pbRegresarServicio.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbRegresarServicio.Location = New System.Drawing.Point(223, 138)
        Me.pbRegresarServicio.Name = "pbRegresarServicio"
        Me.pbRegresarServicio.Size = New System.Drawing.Size(30, 30)
        Me.pbRegresarServicio.TabIndex = 37
        Me.pbRegresarServicio.TabStop = False
        Me.help.SetToolTip(Me.pbRegresarServicio, "Quitar Servicio del Plan")
        '
        'pbInsertar
        '
        Me.pbInsertar.BackgroundImage = CType(resources.GetObject("pbInsertar.BackgroundImage"), System.Drawing.Image)
        Me.pbInsertar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pbInsertar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbInsertar.Location = New System.Drawing.Point(223, 90)
        Me.pbInsertar.Name = "pbInsertar"
        Me.pbInsertar.Size = New System.Drawing.Size(30, 30)
        Me.pbInsertar.TabIndex = 36
        Me.pbInsertar.TabStop = False
        Me.help.SetToolTip(Me.pbInsertar, "Asignar Servicio al Plan")
        '
        'txtVentasPlaneadas
        '
        Me.txtVentasPlaneadas.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.txtVentasPlaneadas.Location = New System.Drawing.Point(148, 217)
        Me.txtVentasPlaneadas.MaxLength = 50
        Me.txtVentasPlaneadas.Name = "txtVentasPlaneadas"
        Me.txtVentasPlaneadas.Size = New System.Drawing.Size(87, 26)
        Me.txtVentasPlaneadas.TabIndex = 35
        Me.help.SetToolTip(Me.txtVentasPlaneadas, "Ej.: 50.000")
        '
        'gpbRegistrarPlan
        '
        Me.gpbRegistrarPlan.Controls.Add(Me.pbRegistrar)
        Me.gpbRegistrarPlan.Controls.Add(Me.Label1)
        Me.gpbRegistrarPlan.Controls.Add(Me.pbLimpiar)
        Me.gpbRegistrarPlan.Controls.Add(Me.txtid)
        Me.gpbRegistrarPlan.Controls.Add(Me.txtDescripcion)
        Me.gpbRegistrarPlan.Controls.Add(Me.gpbServicios)
        Me.gpbRegistrarPlan.Controls.Add(Me.lblDescripcion)
        Me.gpbRegistrarPlan.Controls.Add(Me.dtpFin)
        Me.gpbRegistrarPlan.Controls.Add(Me.lblFechaFin)
        Me.gpbRegistrarPlan.Controls.Add(Me.lblFechaInicio)
        Me.gpbRegistrarPlan.Controls.Add(Me.dtpInicio)
        Me.gpbRegistrarPlan.Font = New System.Drawing.Font("Tahoma", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpbRegistrarPlan.Location = New System.Drawing.Point(222, 29)
        Me.gpbRegistrarPlan.Name = "gpbRegistrarPlan"
        Me.gpbRegistrarPlan.Size = New System.Drawing.Size(560, 509)
        Me.gpbRegistrarPlan.TabIndex = 40
        Me.gpbRegistrarPlan.TabStop = False
        Me.gpbRegistrarPlan.Text = "Registrar Plan Ventas"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.Label1.Location = New System.Drawing.Point(47, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 18)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Identificador"
        '
        'gpbServicios
        '
        Me.gpbServicios.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.gpbServicios.Controls.Add(Me.pbRegresarServicio)
        Me.gpbServicios.Controls.Add(Me.pbInsertar)
        Me.gpbServicios.Controls.Add(Me.txtVentasPlaneadas)
        Me.gpbServicios.Controls.Add(Me.lblVentasPlaneadas)
        Me.gpbServicios.Controls.Add(Me.lblServicio)
        Me.gpbServicios.Controls.Add(Me.ltbServicio)
        Me.gpbServicios.Controls.Add(Me.ltbPlanServicio)
        Me.gpbServicios.Controls.Add(Me.lblPlanServicio)
        Me.gpbServicios.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.gpbServicios.Location = New System.Drawing.Point(50, 201)
        Me.gpbServicios.Name = "gpbServicios"
        Me.gpbServicios.Size = New System.Drawing.Size(464, 258)
        Me.gpbServicios.TabIndex = 37
        Me.gpbServicios.TabStop = False
        Me.gpbServicios.Text = "Registrar Servicios al Plan"
        '
        'lblVentasPlaneadas
        '
        Me.lblVentasPlaneadas.AutoSize = True
        Me.lblVentasPlaneadas.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.lblVentasPlaneadas.Location = New System.Drawing.Point(19, 220)
        Me.lblVentasPlaneadas.Name = "lblVentasPlaneadas"
        Me.lblVentasPlaneadas.Size = New System.Drawing.Size(123, 18)
        Me.lblVentasPlaneadas.TabIndex = 34
        Me.lblVentasPlaneadas.Text = "Ventas Planeadas"
        '
        'lblServicio
        '
        Me.lblServicio.AutoSize = True
        Me.lblServicio.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.lblServicio.Location = New System.Drawing.Point(57, 22)
        Me.lblServicio.Name = "lblServicio"
        Me.lblServicio.Size = New System.Drawing.Size(56, 18)
        Me.lblServicio.TabIndex = 28
        Me.lblServicio.Text = "Servicio"
        '
        'ltbServicio
        '
        Me.ltbServicio.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.ltbServicio.FormattingEnabled = True
        Me.ltbServicio.ItemHeight = 18
        Me.ltbServicio.Location = New System.Drawing.Point(22, 54)
        Me.ltbServicio.Name = "ltbServicio"
        Me.ltbServicio.Size = New System.Drawing.Size(139, 148)
        Me.ltbServicio.TabIndex = 29
        '
        'ltbPlanServicio
        '
        Me.ltbPlanServicio.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.ltbPlanServicio.FormattingEnabled = True
        Me.ltbPlanServicio.ItemHeight = 18
        Me.ltbPlanServicio.Location = New System.Drawing.Point(297, 54)
        Me.ltbPlanServicio.Name = "ltbPlanServicio"
        Me.ltbPlanServicio.Size = New System.Drawing.Size(141, 148)
        Me.ltbPlanServicio.TabIndex = 30
        '
        'lblPlanServicio
        '
        Me.lblPlanServicio.AutoSize = True
        Me.lblPlanServicio.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.lblPlanServicio.Location = New System.Drawing.Point(321, 22)
        Me.lblPlanServicio.Name = "lblPlanServicio"
        Me.lblPlanServicio.Size = New System.Drawing.Size(87, 18)
        Me.lblPlanServicio.TabIndex = 31
        Me.lblPlanServicio.Text = "Plan Servicio"
        '
        'lblDescripcion
        '
        Me.lblDescripcion.AutoSize = True
        Me.lblDescripcion.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.lblDescripcion.Location = New System.Drawing.Point(47, 67)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(80, 18)
        Me.lblDescripcion.TabIndex = 23
        Me.lblDescripcion.Text = "Descripción"
        '
        'dtpFin
        '
        Me.dtpFin.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.dtpFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFin.Location = New System.Drawing.Point(395, 171)
        Me.dtpFin.Name = "dtpFin"
        Me.dtpFin.Size = New System.Drawing.Size(119, 26)
        Me.dtpFin.TabIndex = 27
        '
        'lblFechaFin
        '
        Me.lblFechaFin.AutoSize = True
        Me.lblFechaFin.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.lblFechaFin.Location = New System.Drawing.Point(299, 179)
        Me.lblFechaFin.Name = "lblFechaFin"
        Me.lblFechaFin.Size = New System.Drawing.Size(70, 18)
        Me.lblFechaFin.TabIndex = 26
        Me.lblFechaFin.Text = "Fecha Fin"
        '
        'lblFechaInicio
        '
        Me.lblFechaInicio.AutoSize = True
        Me.lblFechaInicio.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.lblFechaInicio.Location = New System.Drawing.Point(47, 179)
        Me.lblFechaInicio.Name = "lblFechaInicio"
        Me.lblFechaInicio.Size = New System.Drawing.Size(85, 18)
        Me.lblFechaInicio.TabIndex = 25
        Me.lblFechaInicio.Text = "Fecha Inicio"
        '
        'dtpInicio
        '
        Me.dtpInicio.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpInicio.Location = New System.Drawing.Point(147, 171)
        Me.dtpInicio.Name = "dtpInicio"
        Me.dtpInicio.Size = New System.Drawing.Size(117, 26)
        Me.dtpInicio.TabIndex = 19
        '
        'ctlRegistrarPlanVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Controls.Add(Me.gpbRegistrarPlan)
        Me.Name = "ctlRegistrarPlanVenta"
        Me.Size = New System.Drawing.Size(1024, 700)
        CType(Me.pbRegistrar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbLimpiar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbRegresarServicio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbInsertar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpbRegistrarPlan.ResumeLayout(False)
        Me.gpbRegistrarPlan.PerformLayout()
        Me.gpbServicios.ResumeLayout(False)
        Me.gpbServicios.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents help As System.Windows.Forms.ToolTip
    Friend WithEvents pbRegistrar As System.Windows.Forms.PictureBox
    Friend WithEvents pbLimpiar As System.Windows.Forms.PictureBox
    Friend WithEvents gpbRegistrarPlan As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtid As System.Windows.Forms.TextBox
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents gpbServicios As System.Windows.Forms.GroupBox
    Friend WithEvents pbRegresarServicio As System.Windows.Forms.PictureBox
    Friend WithEvents pbInsertar As System.Windows.Forms.PictureBox
    Friend WithEvents txtVentasPlaneadas As System.Windows.Forms.TextBox
    Friend WithEvents lblVentasPlaneadas As System.Windows.Forms.Label
    Friend WithEvents lblServicio As System.Windows.Forms.Label
    Friend WithEvents ltbServicio As System.Windows.Forms.ListBox
    Friend WithEvents ltbPlanServicio As System.Windows.Forms.ListBox
    Friend WithEvents lblPlanServicio As System.Windows.Forms.Label
    Friend WithEvents lblDescripcion As System.Windows.Forms.Label
    Friend WithEvents dtpFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblFechaFin As System.Windows.Forms.Label
    Friend WithEvents lblFechaInicio As System.Windows.Forms.Label
    Friend WithEvents dtpInicio As System.Windows.Forms.DateTimePicker

End Class
