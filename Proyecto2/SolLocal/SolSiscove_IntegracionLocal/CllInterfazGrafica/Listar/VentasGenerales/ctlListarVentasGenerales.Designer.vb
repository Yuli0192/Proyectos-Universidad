<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctlListarVentasGenerales
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ctlListarVentasGenerales))
        Me.dtpFin = New System.Windows.Forms.DateTimePicker
        Me.lblFechaFin = New System.Windows.Forms.Label
        Me.lblFechaInicio = New System.Windows.Forms.Label
        Me.dtpInicio = New System.Windows.Forms.DateTimePicker
        Me.txtMonto = New System.Windows.Forms.TextBox
        Me.lblMonto = New System.Windows.Forms.Label
        Me.lblCod = New System.Windows.Forms.Label
        Me.lblCodGrupo = New System.Windows.Forms.Label
        Me.txtCodGrupo = New System.Windows.Forms.TextBox
        Me.dvgFactura = New System.Windows.Forms.DataGridView
        Me.lblFacturas = New System.Windows.Forms.Label
        Me.gpbGrupo = New System.Windows.Forms.GroupBox
        Me.pbVerVentas = New System.Windows.Forms.PictureBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.gpbVentasGeneral = New System.Windows.Forms.GroupBox
        Me.help = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.dvgFactura, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpbGrupo.SuspendLayout()
        CType(Me.pbVerVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.gpbVentasGeneral.SuspendLayout()
        Me.SuspendLayout()
        '
        'dtpFin
        '
        Me.dtpFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFin.Location = New System.Drawing.Point(294, 121)
        Me.dtpFin.Name = "dtpFin"
        Me.dtpFin.Size = New System.Drawing.Size(109, 27)
        Me.dtpFin.TabIndex = 95
        '
        'lblFechaFin
        '
        Me.lblFechaFin.AutoSize = True
        Me.lblFechaFin.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.lblFechaFin.Location = New System.Drawing.Point(224, 123)
        Me.lblFechaFin.Name = "lblFechaFin"
        Me.lblFechaFin.Size = New System.Drawing.Size(70, 18)
        Me.lblFechaFin.TabIndex = 94
        Me.lblFechaFin.Text = "Fecha Fin"
        '
        'lblFechaInicio
        '
        Me.lblFechaInicio.AutoSize = True
        Me.lblFechaInicio.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.lblFechaInicio.Location = New System.Drawing.Point(15, 123)
        Me.lblFechaInicio.Name = "lblFechaInicio"
        Me.lblFechaInicio.Size = New System.Drawing.Size(85, 18)
        Me.lblFechaInicio.TabIndex = 93
        Me.lblFechaInicio.Text = "Fecha Inicio"
        '
        'dtpInicio
        '
        Me.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpInicio.Location = New System.Drawing.Point(106, 121)
        Me.dtpInicio.Name = "dtpInicio"
        Me.dtpInicio.Size = New System.Drawing.Size(112, 27)
        Me.dtpInicio.TabIndex = 92
        '
        'txtMonto
        '
        Me.txtMonto.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.txtMonto.Location = New System.Drawing.Point(154, 87)
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.ReadOnly = True
        Me.txtMonto.Size = New System.Drawing.Size(131, 26)
        Me.txtMonto.TabIndex = 104
        '
        'lblMonto
        '
        Me.lblMonto.AutoSize = True
        Me.lblMonto.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblMonto.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.lblMonto.Location = New System.Drawing.Point(28, 95)
        Me.lblMonto.Name = "lblMonto"
        Me.lblMonto.Size = New System.Drawing.Size(87, 18)
        Me.lblMonto.TabIndex = 103
        Me.lblMonto.Text = "Monto Total"
        '
        'lblCod
        '
        Me.lblCod.AutoSize = True
        Me.lblCod.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.lblCod.Location = New System.Drawing.Point(15, 52)
        Me.lblCod.Name = "lblCod"
        Me.lblCod.Size = New System.Drawing.Size(95, 18)
        Me.lblCod.TabIndex = 4
        Me.lblCod.Text = "Código Grupo"
        '
        'lblCodGrupo
        '
        Me.lblCodGrupo.AutoSize = True
        Me.lblCodGrupo.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblCodGrupo.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.lblCodGrupo.Location = New System.Drawing.Point(28, 50)
        Me.lblCodGrupo.Name = "lblCodGrupo"
        Me.lblCodGrupo.Size = New System.Drawing.Size(95, 18)
        Me.lblCodGrupo.TabIndex = 106
        Me.lblCodGrupo.Text = "Código Grupo"
        '
        'txtCodGrupo
        '
        Me.txtCodGrupo.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.txtCodGrupo.Location = New System.Drawing.Point(154, 47)
        Me.txtCodGrupo.Name = "txtCodGrupo"
        Me.txtCodGrupo.ReadOnly = True
        Me.txtCodGrupo.Size = New System.Drawing.Size(131, 26)
        Me.txtCodGrupo.TabIndex = 105
        '
        'dvgFactura
        '
        Me.dvgFactura.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dvgFactura.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dvgFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dvgFactura.Location = New System.Drawing.Point(31, 175)
        Me.dvgFactura.Name = "dvgFactura"
        Me.dvgFactura.RowHeadersVisible = False
        Me.dvgFactura.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dvgFactura.Size = New System.Drawing.Size(450, 138)
        Me.dvgFactura.TabIndex = 108
        '
        'lblFacturas
        '
        Me.lblFacturas.AutoSize = True
        Me.lblFacturas.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblFacturas.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.lblFacturas.Location = New System.Drawing.Point(28, 136)
        Me.lblFacturas.Name = "lblFacturas"
        Me.lblFacturas.Size = New System.Drawing.Size(146, 18)
        Me.lblFacturas.TabIndex = 109
        Me.lblFacturas.Text = "Facturas Vendedores"
        '
        'gpbGrupo
        '
        Me.gpbGrupo.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.gpbGrupo.Controls.Add(Me.pbVerVentas)
        Me.gpbGrupo.Controls.Add(Me.lblCod)
        Me.gpbGrupo.Controls.Add(Me.dtpInicio)
        Me.gpbGrupo.Controls.Add(Me.lblFechaInicio)
        Me.gpbGrupo.Controls.Add(Me.lblFechaFin)
        Me.gpbGrupo.Controls.Add(Me.dtpFin)
        Me.gpbGrupo.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpbGrupo.Location = New System.Drawing.Point(22, 39)
        Me.gpbGrupo.Name = "gpbGrupo"
        Me.gpbGrupo.Size = New System.Drawing.Size(409, 331)
        Me.gpbGrupo.TabIndex = 110
        Me.gpbGrupo.TabStop = False
        Me.gpbGrupo.Text = "Buscar Grupo de Ventas"
        '
        'pbVerVentas
        '
        Me.pbVerVentas.BackgroundImage = CType(resources.GetObject("pbVerVentas.BackgroundImage"), System.Drawing.Image)
        Me.pbVerVentas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pbVerVentas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbVerVentas.Location = New System.Drawing.Point(373, 164)
        Me.pbVerVentas.Name = "pbVerVentas"
        Me.pbVerVentas.Size = New System.Drawing.Size(30, 30)
        Me.pbVerVentas.TabIndex = 114
        Me.pbVerVentas.TabStop = False
        Me.help.SetToolTip(Me.pbVerVentas, "Ver Ventas")
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel1.Controls.Add(Me.gpbGrupo)
        Me.Panel1.Controls.Add(Me.gpbVentasGeneral)
        Me.Panel1.Location = New System.Drawing.Point(31, 93)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(956, 454)
        Me.Panel1.TabIndex = 111
        '
        'gpbVentasGeneral
        '
        Me.gpbVentasGeneral.Controls.Add(Me.lblCodGrupo)
        Me.gpbVentasGeneral.Controls.Add(Me.dvgFactura)
        Me.gpbVentasGeneral.Controls.Add(Me.txtCodGrupo)
        Me.gpbVentasGeneral.Controls.Add(Me.lblFacturas)
        Me.gpbVentasGeneral.Controls.Add(Me.lblMonto)
        Me.gpbVentasGeneral.Controls.Add(Me.txtMonto)
        Me.gpbVentasGeneral.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpbVentasGeneral.Location = New System.Drawing.Point(437, 39)
        Me.gpbVentasGeneral.Name = "gpbVentasGeneral"
        Me.gpbVentasGeneral.Size = New System.Drawing.Size(497, 331)
        Me.gpbVentasGeneral.TabIndex = 111
        Me.gpbVentasGeneral.TabStop = False
        Me.gpbVentasGeneral.Text = "Ventas General"
        '
        'ctlListarVentasGenerales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Controls.Add(Me.Panel1)
        Me.Name = "ctlListarVentasGenerales"
        Me.Size = New System.Drawing.Size(1024, 700)
        CType(Me.dvgFactura, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpbGrupo.ResumeLayout(False)
        Me.gpbGrupo.PerformLayout()
        CType(Me.pbVerVentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.gpbVentasGeneral.ResumeLayout(False)
        Me.gpbVentasGeneral.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dtpFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblFechaFin As System.Windows.Forms.Label
    Friend WithEvents lblFechaInicio As System.Windows.Forms.Label
    Friend WithEvents dtpInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtMonto As System.Windows.Forms.TextBox
    Friend WithEvents lblMonto As System.Windows.Forms.Label
    Friend WithEvents lblCod As System.Windows.Forms.Label
    Friend WithEvents lblCodGrupo As System.Windows.Forms.Label
    Friend WithEvents txtCodGrupo As System.Windows.Forms.TextBox
    Friend WithEvents dvgFactura As System.Windows.Forms.DataGridView
    Friend WithEvents lblFacturas As System.Windows.Forms.Label
    Friend WithEvents gpbGrupo As System.Windows.Forms.GroupBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents gpbVentasGeneral As System.Windows.Forms.GroupBox
    Friend WithEvents help As System.Windows.Forms.ToolTip
    Friend WithEvents pbVerVentas As System.Windows.Forms.PictureBox

End Class
