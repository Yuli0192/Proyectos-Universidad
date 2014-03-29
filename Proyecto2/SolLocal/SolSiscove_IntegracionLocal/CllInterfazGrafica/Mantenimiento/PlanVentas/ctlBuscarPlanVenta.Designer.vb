<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctlBuscarPlanVenta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ctlBuscarPlanVenta))
        Me.txtFechaInicio = New System.Windows.Forms.TextBox
        Me.lblfechaI = New System.Windows.Forms.Label
        Me.txtDescripcion = New System.Windows.Forms.TextBox
        Me.lblDescripcion = New System.Windows.Forms.Label
        Me.txtId = New System.Windows.Forms.TextBox
        Me.lblId = New System.Windows.Forms.Label
        Me.dvgPlanVenta = New System.Windows.Forms.DataGridView
        Me.dtpFin = New System.Windows.Forms.DateTimePicker
        Me.lblFechaFin = New System.Windows.Forms.Label
        Me.lblFechaInicio = New System.Windows.Forms.Label
        Me.dtpInicio = New System.Windows.Forms.DateTimePicker
        Me.lblFechaF = New System.Windows.Forms.Label
        Me.txtFechaFin = New System.Windows.Forms.TextBox
        Me.ltbServicio = New System.Windows.Forms.ListBox
        Me.lblServicio = New System.Windows.Forms.Label
        Me.lblPlanServicio = New System.Windows.Forms.Label
        Me.ltbPlanServicio = New System.Windows.Forms.ListBox
        Me.lblVentasPlaneadas = New System.Windows.Forms.Label
        Me.txtCantPlaneada = New System.Windows.Forms.TextBox
        Me.lblVentas = New System.Windows.Forms.Label
        Me.txtCant = New System.Windows.Forms.TextBox
        Me.gpbModificarPlan = New System.Windows.Forms.GroupBox
        Me.gpbServiciosPlan = New System.Windows.Forms.GroupBox
        Me.pbAsignar = New System.Windows.Forms.PictureBox
        Me.pbQuitar = New System.Windows.Forms.PictureBox
        Me.gpbBuscarPlan = New System.Windows.Forms.GroupBox
        Me.pbBuscar = New System.Windows.Forms.PictureBox
        Me.pbEliminar = New System.Windows.Forms.PictureBox
        Me.pbModificar = New System.Windows.Forms.PictureBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.help = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.dvgPlanVenta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpbModificarPlan.SuspendLayout()
        Me.gpbServiciosPlan.SuspendLayout()
        CType(Me.pbAsignar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbQuitar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpbBuscarPlan.SuspendLayout()
        CType(Me.pbBuscar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbEliminar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbModificar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtFechaInicio
        '
        Me.txtFechaInicio.Enabled = False
        Me.txtFechaInicio.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.txtFechaInicio.Location = New System.Drawing.Point(125, 185)
        Me.txtFechaInicio.Name = "txtFechaInicio"
        Me.txtFechaInicio.ReadOnly = True
        Me.txtFechaInicio.Size = New System.Drawing.Size(86, 26)
        Me.txtFechaInicio.TabIndex = 78
        '
        'lblfechaI
        '
        Me.lblfechaI.AutoSize = True
        Me.lblfechaI.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfechaI.Location = New System.Drawing.Point(34, 188)
        Me.lblfechaI.Name = "lblfechaI"
        Me.lblfechaI.Size = New System.Drawing.Size(85, 18)
        Me.lblfechaI.TabIndex = 77
        Me.lblfechaI.Text = "Fecha Inicio"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Enabled = False
        Me.txtDescripcion.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.txtDescripcion.Location = New System.Drawing.Point(37, 96)
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.ReadOnly = True
        Me.txtDescripcion.Size = New System.Drawing.Size(374, 67)
        Me.txtDescripcion.TabIndex = 72
        '
        'lblDescripcion
        '
        Me.lblDescripcion.AutoSize = True
        Me.lblDescripcion.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescripcion.Location = New System.Drawing.Point(34, 73)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(80, 18)
        Me.lblDescripcion.TabIndex = 71
        Me.lblDescripcion.Text = "Descripción"
        '
        'txtId
        '
        Me.txtId.Enabled = False
        Me.txtId.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.txtId.Location = New System.Drawing.Point(150, 34)
        Me.txtId.Name = "txtId"
        Me.txtId.ReadOnly = True
        Me.txtId.Size = New System.Drawing.Size(261, 26)
        Me.txtId.TabIndex = 70
        '
        'lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblId.Location = New System.Drawing.Point(34, 34)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(88, 18)
        Me.lblId.TabIndex = 69
        Me.lblId.Text = "Identificador"
        '
        'dvgPlanVenta
        '
        Me.dvgPlanVenta.AllowUserToAddRows = False
        Me.dvgPlanVenta.AllowUserToDeleteRows = False
        Me.dvgPlanVenta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dvgPlanVenta.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dvgPlanVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dvgPlanVenta.Location = New System.Drawing.Point(22, 123)
        Me.dvgPlanVenta.Name = "dvgPlanVenta"
        Me.dvgPlanVenta.ReadOnly = True
        Me.dvgPlanVenta.RowHeadersVisible = False
        Me.dvgPlanVenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dvgPlanVenta.Size = New System.Drawing.Size(469, 226)
        Me.dvgPlanVenta.TabIndex = 65
        '
        'dtpFin
        '
        Me.dtpFin.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFin.Location = New System.Drawing.Point(322, 73)
        Me.dtpFin.Name = "dtpFin"
        Me.dtpFin.Size = New System.Drawing.Size(108, 25)
        Me.dtpFin.TabIndex = 87
        '
        'lblFechaFin
        '
        Me.lblFechaFin.AutoSize = True
        Me.lblFechaFin.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.lblFechaFin.Location = New System.Drawing.Point(245, 75)
        Me.lblFechaFin.Name = "lblFechaFin"
        Me.lblFechaFin.Size = New System.Drawing.Size(70, 18)
        Me.lblFechaFin.TabIndex = 86
        Me.lblFechaFin.Text = "Fecha Fin"
        '
        'lblFechaInicio
        '
        Me.lblFechaInicio.AutoSize = True
        Me.lblFechaInicio.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.lblFechaInicio.Location = New System.Drawing.Point(19, 75)
        Me.lblFechaInicio.Name = "lblFechaInicio"
        Me.lblFechaInicio.Size = New System.Drawing.Size(85, 18)
        Me.lblFechaInicio.TabIndex = 85
        Me.lblFechaInicio.Text = "Fecha Inicio"
        '
        'dtpInicio
        '
        Me.dtpInicio.CalendarFont = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpInicio.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpInicio.Location = New System.Drawing.Point(110, 73)
        Me.dtpInicio.Name = "dtpInicio"
        Me.dtpInicio.Size = New System.Drawing.Size(109, 25)
        Me.dtpInicio.TabIndex = 84
        '
        'lblFechaF
        '
        Me.lblFechaF.AutoSize = True
        Me.lblFechaF.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaF.Location = New System.Drawing.Point(247, 188)
        Me.lblFechaF.Name = "lblFechaF"
        Me.lblFechaF.Size = New System.Drawing.Size(70, 18)
        Me.lblFechaF.TabIndex = 88
        Me.lblFechaF.Text = "Fecha Fin"
        '
        'txtFechaFin
        '
        Me.txtFechaFin.Enabled = False
        Me.txtFechaFin.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.txtFechaFin.Location = New System.Drawing.Point(323, 185)
        Me.txtFechaFin.Name = "txtFechaFin"
        Me.txtFechaFin.ReadOnly = True
        Me.txtFechaFin.Size = New System.Drawing.Size(88, 26)
        Me.txtFechaFin.TabIndex = 89
        '
        'ltbServicio
        '
        Me.ltbServicio.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ltbServicio.FormattingEnabled = True
        Me.ltbServicio.ItemHeight = 18
        Me.ltbServicio.Location = New System.Drawing.Point(210, 67)
        Me.ltbServicio.Name = "ltbServicio"
        Me.ltbServicio.Size = New System.Drawing.Size(114, 112)
        Me.ltbServicio.TabIndex = 91
        '
        'lblServicio
        '
        Me.lblServicio.AutoSize = True
        Me.lblServicio.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.lblServicio.Location = New System.Drawing.Point(185, 36)
        Me.lblServicio.Name = "lblServicio"
        Me.lblServicio.Size = New System.Drawing.Size(156, 18)
        Me.lblServicio.TabIndex = 90
        Me.lblServicio.Text = "Servicios no están Plan"
        '
        'lblPlanServicio
        '
        Me.lblPlanServicio.AutoSize = True
        Me.lblPlanServicio.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.lblPlanServicio.Location = New System.Drawing.Point(6, 36)
        Me.lblPlanServicio.Name = "lblPlanServicio"
        Me.lblPlanServicio.Size = New System.Drawing.Size(135, 18)
        Me.lblPlanServicio.TabIndex = 93
        Me.lblPlanServicio.Text = "Servicios están Plan"
        '
        'ltbPlanServicio
        '
        Me.ltbPlanServicio.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.ltbPlanServicio.FormattingEnabled = True
        Me.ltbPlanServicio.ItemHeight = 18
        Me.ltbPlanServicio.Location = New System.Drawing.Point(9, 67)
        Me.ltbPlanServicio.Name = "ltbPlanServicio"
        Me.ltbPlanServicio.Size = New System.Drawing.Size(114, 112)
        Me.ltbPlanServicio.TabIndex = 92
        '
        'lblVentasPlaneadas
        '
        Me.lblVentasPlaneadas.AutoSize = True
        Me.lblVentasPlaneadas.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.lblVentasPlaneadas.Location = New System.Drawing.Point(6, 191)
        Me.lblVentasPlaneadas.Name = "lblVentasPlaneadas"
        Me.lblVentasPlaneadas.Size = New System.Drawing.Size(123, 18)
        Me.lblVentasPlaneadas.TabIndex = 96
        Me.lblVentasPlaneadas.Text = "Ventas Planeadas"
        '
        'txtCantPlaneada
        '
        Me.txtCantPlaneada.Location = New System.Drawing.Point(9, 212)
        Me.txtCantPlaneada.MaxLength = 50
        Me.txtCantPlaneada.Name = "txtCantPlaneada"
        Me.txtCantPlaneada.Size = New System.Drawing.Size(114, 26)
        Me.txtCantPlaneada.TabIndex = 97
        '
        'lblVentas
        '
        Me.lblVentas.AutoSize = True
        Me.lblVentas.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.lblVentas.Location = New System.Drawing.Point(199, 191)
        Me.lblVentas.Name = "lblVentas"
        Me.lblVentas.Size = New System.Drawing.Size(125, 18)
        Me.lblVentas.TabIndex = 98
        Me.lblVentas.Text = "Ventas Esperadas"
        '
        'txtCant
        '
        Me.txtCant.Location = New System.Drawing.Point(210, 212)
        Me.txtCant.MaxLength = 50
        Me.txtCant.Name = "txtCant"
        Me.txtCant.Size = New System.Drawing.Size(114, 26)
        Me.txtCant.TabIndex = 99
        Me.help.SetToolTip(Me.txtCant, "10.00")
        '
        'gpbModificarPlan
        '
        Me.gpbModificarPlan.Controls.Add(Me.lblFechaF)
        Me.gpbModificarPlan.Controls.Add(Me.txtFechaFin)
        Me.gpbModificarPlan.Controls.Add(Me.lblDescripcion)
        Me.gpbModificarPlan.Controls.Add(Me.lblfechaI)
        Me.gpbModificarPlan.Controls.Add(Me.txtFechaInicio)
        Me.gpbModificarPlan.Controls.Add(Me.lblId)
        Me.gpbModificarPlan.Controls.Add(Me.txtId)
        Me.gpbModificarPlan.Controls.Add(Me.txtDescripcion)
        Me.gpbModificarPlan.Controls.Add(Me.gpbServiciosPlan)
        Me.gpbModificarPlan.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpbModificarPlan.Location = New System.Drawing.Point(529, 25)
        Me.gpbModificarPlan.Name = "gpbModificarPlan"
        Me.gpbModificarPlan.Size = New System.Drawing.Size(447, 530)
        Me.gpbModificarPlan.TabIndex = 100
        Me.gpbModificarPlan.TabStop = False
        Me.gpbModificarPlan.Text = "Modificar Plan de Ventas"
        Me.gpbModificarPlan.Visible = False
        '
        'gpbServiciosPlan
        '
        Me.gpbServiciosPlan.Controls.Add(Me.pbAsignar)
        Me.gpbServiciosPlan.Controls.Add(Me.pbQuitar)
        Me.gpbServiciosPlan.Controls.Add(Me.txtCant)
        Me.gpbServiciosPlan.Controls.Add(Me.txtCantPlaneada)
        Me.gpbServiciosPlan.Controls.Add(Me.lblPlanServicio)
        Me.gpbServiciosPlan.Controls.Add(Me.lblVentasPlaneadas)
        Me.gpbServiciosPlan.Controls.Add(Me.lblServicio)
        Me.gpbServiciosPlan.Controls.Add(Me.lblVentas)
        Me.gpbServiciosPlan.Controls.Add(Me.ltbServicio)
        Me.gpbServiciosPlan.Controls.Add(Me.ltbPlanServicio)
        Me.gpbServiciosPlan.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpbServiciosPlan.Location = New System.Drawing.Point(37, 243)
        Me.gpbServiciosPlan.Name = "gpbServiciosPlan"
        Me.gpbServiciosPlan.Size = New System.Drawing.Size(374, 266)
        Me.gpbServiciosPlan.TabIndex = 101
        Me.gpbServiciosPlan.TabStop = False
        Me.gpbServiciosPlan.Text = "Modificar Servicios del Plan"
        '
        'pbAsignar
        '
        Me.pbAsignar.BackgroundImage = CType(resources.GetObject("pbAsignar.BackgroundImage"), System.Drawing.Image)
        Me.pbAsignar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pbAsignar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbAsignar.Location = New System.Drawing.Point(153, 130)
        Me.pbAsignar.Name = "pbAsignar"
        Me.pbAsignar.Size = New System.Drawing.Size(30, 30)
        Me.pbAsignar.TabIndex = 101
        Me.pbAsignar.TabStop = False
        Me.help.SetToolTip(Me.pbAsignar, "Asignar Servicio")
        '
        'pbQuitar
        '
        Me.pbQuitar.BackgroundImage = CType(resources.GetObject("pbQuitar.BackgroundImage"), System.Drawing.Image)
        Me.pbQuitar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pbQuitar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbQuitar.Location = New System.Drawing.Point(153, 94)
        Me.pbQuitar.Name = "pbQuitar"
        Me.pbQuitar.Size = New System.Drawing.Size(30, 30)
        Me.pbQuitar.TabIndex = 100
        Me.pbQuitar.TabStop = False
        Me.help.SetToolTip(Me.pbQuitar, "Quitar Servicio al Plan")
        '
        'gpbBuscarPlan
        '
        Me.gpbBuscarPlan.Controls.Add(Me.pbBuscar)
        Me.gpbBuscarPlan.Controls.Add(Me.pbEliminar)
        Me.gpbBuscarPlan.Controls.Add(Me.pbModificar)
        Me.gpbBuscarPlan.Controls.Add(Me.lblFechaInicio)
        Me.gpbBuscarPlan.Controls.Add(Me.lblFechaFin)
        Me.gpbBuscarPlan.Controls.Add(Me.dtpInicio)
        Me.gpbBuscarPlan.Controls.Add(Me.dtpFin)
        Me.gpbBuscarPlan.Controls.Add(Me.dvgPlanVenta)
        Me.gpbBuscarPlan.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpbBuscarPlan.Location = New System.Drawing.Point(18, 25)
        Me.gpbBuscarPlan.Name = "gpbBuscarPlan"
        Me.gpbBuscarPlan.Size = New System.Drawing.Size(505, 530)
        Me.gpbBuscarPlan.TabIndex = 101
        Me.gpbBuscarPlan.TabStop = False
        Me.gpbBuscarPlan.Text = "Buscar Plan de Ventas"
        '
        'pbBuscar
        '
        Me.pbBuscar.BackgroundImage = CType(resources.GetObject("pbBuscar.BackgroundImage"), System.Drawing.Image)
        Me.pbBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pbBuscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbBuscar.Location = New System.Drawing.Point(461, 71)
        Me.pbBuscar.Name = "pbBuscar"
        Me.pbBuscar.Size = New System.Drawing.Size(30, 30)
        Me.pbBuscar.TabIndex = 90
        Me.pbBuscar.TabStop = False
        Me.help.SetToolTip(Me.pbBuscar, "Buscar")
        '
        'pbEliminar
        '
        Me.pbEliminar.BackgroundImage = CType(resources.GetObject("pbEliminar.BackgroundImage"), System.Drawing.Image)
        Me.pbEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pbEliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbEliminar.Location = New System.Drawing.Point(462, 364)
        Me.pbEliminar.Name = "pbEliminar"
        Me.pbEliminar.Size = New System.Drawing.Size(30, 30)
        Me.pbEliminar.TabIndex = 89
        Me.pbEliminar.TabStop = False
        Me.help.SetToolTip(Me.pbEliminar, "Eliminar")
        '
        'pbModificar
        '
        Me.pbModificar.BackgroundImage = CType(resources.GetObject("pbModificar.BackgroundImage"), System.Drawing.Image)
        Me.pbModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pbModificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbModificar.Location = New System.Drawing.Point(412, 364)
        Me.pbModificar.Name = "pbModificar"
        Me.pbModificar.Size = New System.Drawing.Size(30, 30)
        Me.pbModificar.TabIndex = 88
        Me.pbModificar.TabStop = False
        Me.help.SetToolTip(Me.pbModificar, "Modificar")
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel1.Controls.Add(Me.gpbModificarPlan)
        Me.Panel1.Controls.Add(Me.gpbBuscarPlan)
        Me.Panel1.Location = New System.Drawing.Point(19, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(987, 621)
        Me.Panel1.TabIndex = 102
        '
        'ctlBuscarPlanVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Controls.Add(Me.Panel1)
        Me.Name = "ctlBuscarPlanVenta"
        Me.Size = New System.Drawing.Size(1024, 700)
        Me.help.SetToolTip(Me, "Buscar ")
        CType(Me.dvgPlanVenta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpbModificarPlan.ResumeLayout(False)
        Me.gpbModificarPlan.PerformLayout()
        Me.gpbServiciosPlan.ResumeLayout(False)
        Me.gpbServiciosPlan.PerformLayout()
        CType(Me.pbAsignar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbQuitar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpbBuscarPlan.ResumeLayout(False)
        Me.gpbBuscarPlan.PerformLayout()
        CType(Me.pbBuscar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbEliminar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbModificar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtFechaInicio As System.Windows.Forms.TextBox
    Friend WithEvents lblfechaI As System.Windows.Forms.Label
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents lblDescripcion As System.Windows.Forms.Label
    Friend WithEvents txtId As System.Windows.Forms.TextBox
    Friend WithEvents lblId As System.Windows.Forms.Label
    Friend WithEvents dvgPlanVenta As System.Windows.Forms.DataGridView
    Friend WithEvents dtpFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblFechaFin As System.Windows.Forms.Label
    Friend WithEvents lblFechaInicio As System.Windows.Forms.Label
    Friend WithEvents dtpInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblFechaF As System.Windows.Forms.Label
    Friend WithEvents txtFechaFin As System.Windows.Forms.TextBox
    Friend WithEvents ltbServicio As System.Windows.Forms.ListBox
    Friend WithEvents lblServicio As System.Windows.Forms.Label
    Friend WithEvents lblPlanServicio As System.Windows.Forms.Label
    Friend WithEvents ltbPlanServicio As System.Windows.Forms.ListBox
    Friend WithEvents lblVentasPlaneadas As System.Windows.Forms.Label
    Friend WithEvents txtCantPlaneada As System.Windows.Forms.TextBox
    Friend WithEvents lblVentas As System.Windows.Forms.Label
    Friend WithEvents txtCant As System.Windows.Forms.TextBox
    Friend WithEvents gpbModificarPlan As System.Windows.Forms.GroupBox
    Friend WithEvents gpbServiciosPlan As System.Windows.Forms.GroupBox
    Friend WithEvents gpbBuscarPlan As System.Windows.Forms.GroupBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents pbModificar As System.Windows.Forms.PictureBox
    Friend WithEvents help As System.Windows.Forms.ToolTip
    Friend WithEvents pbEliminar As System.Windows.Forms.PictureBox
    Friend WithEvents pbQuitar As System.Windows.Forms.PictureBox
    Friend WithEvents pbAsignar As System.Windows.Forms.PictureBox
    Friend WithEvents pbBuscar As System.Windows.Forms.PictureBox

End Class
