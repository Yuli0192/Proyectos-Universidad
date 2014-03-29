<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctlListarVentas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ctlListarVentas))
        Me.dvgFactura = New System.Windows.Forms.DataGridView
        Me.lblNum = New System.Windows.Forms.Label
        Me.txtNum = New System.Windows.Forms.TextBox
        Me.lblCliente = New System.Windows.Forms.Label
        Me.txtCliente = New System.Windows.Forms.TextBox
        Me.lblFechaFacturacion = New System.Windows.Forms.Label
        Me.txtFechaFacturacion = New System.Windows.Forms.TextBox
        Me.lblMonto = New System.Windows.Forms.Label
        Me.txtMonto = New System.Windows.Forms.TextBox
        Me.dvgLineaDetalle = New System.Windows.Forms.DataGridView
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.gpbUsuario = New System.Windows.Forms.GroupBox
        Me.cmbListar = New System.Windows.Forms.ComboBox
        Me.pbBuscarVentas = New System.Windows.Forms.PictureBox
        Me.lblCedula = New System.Windows.Forms.Label
        Me.lblFechaInicio = New System.Windows.Forms.Label
        Me.dtpInicio = New System.Windows.Forms.DateTimePicker
        Me.dtpFin = New System.Windows.Forms.DateTimePicker
        Me.lblFechaFin = New System.Windows.Forms.Label
        Me.gpbVentas = New System.Windows.Forms.GroupBox
        Me.gpbVentasVendedor = New System.Windows.Forms.GroupBox
        Me.pbVerVentas = New System.Windows.Forms.PictureBox
        Me.help = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.dvgFactura, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dvgLineaDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.gpbUsuario.SuspendLayout()
        CType(Me.pbBuscarVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpbVentas.SuspendLayout()
        Me.gpbVentasVendedor.SuspendLayout()
        CType(Me.pbVerVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dvgFactura
        '
        Me.dvgFactura.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dvgFactura.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dvgFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dvgFactura.Location = New System.Drawing.Point(80, 42)
        Me.dvgFactura.Name = "dvgFactura"
        Me.dvgFactura.RowHeadersVisible = False
        Me.dvgFactura.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dvgFactura.Size = New System.Drawing.Size(251, 105)
        Me.dvgFactura.TabIndex = 92
        '
        'lblNum
        '
        Me.lblNum.AutoSize = True
        Me.lblNum.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.lblNum.Location = New System.Drawing.Point(21, 53)
        Me.lblNum.Name = "lblNum"
        Me.lblNum.Size = New System.Drawing.Size(114, 18)
        Me.lblNum.TabIndex = 95
        Me.lblNum.Text = "Número Factura"
        '
        'txtNum
        '
        Me.txtNum.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.txtNum.Location = New System.Drawing.Point(157, 50)
        Me.txtNum.Name = "txtNum"
        Me.txtNum.ReadOnly = True
        Me.txtNum.Size = New System.Drawing.Size(206, 26)
        Me.txtNum.TabIndex = 96
        '
        'lblCliente
        '
        Me.lblCliente.AutoSize = True
        Me.lblCliente.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.lblCliente.Location = New System.Drawing.Point(21, 103)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(50, 18)
        Me.lblCliente.TabIndex = 97
        Me.lblCliente.Text = "Cliente"
        '
        'txtCliente
        '
        Me.txtCliente.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.txtCliente.Location = New System.Drawing.Point(157, 95)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.ReadOnly = True
        Me.txtCliente.Size = New System.Drawing.Size(206, 26)
        Me.txtCliente.TabIndex = 98
        '
        'lblFechaFacturacion
        '
        Me.lblFechaFacturacion.AutoSize = True
        Me.lblFechaFacturacion.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.lblFechaFacturacion.Location = New System.Drawing.Point(21, 148)
        Me.lblFechaFacturacion.Name = "lblFechaFacturacion"
        Me.lblFechaFacturacion.Size = New System.Drawing.Size(126, 18)
        Me.lblFechaFacturacion.TabIndex = 99
        Me.lblFechaFacturacion.Text = "Fecha Facturación"
        '
        'txtFechaFacturacion
        '
        Me.txtFechaFacturacion.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.txtFechaFacturacion.Location = New System.Drawing.Point(157, 140)
        Me.txtFechaFacturacion.Name = "txtFechaFacturacion"
        Me.txtFechaFacturacion.ReadOnly = True
        Me.txtFechaFacturacion.Size = New System.Drawing.Size(206, 26)
        Me.txtFechaFacturacion.TabIndex = 100
        '
        'lblMonto
        '
        Me.lblMonto.AutoSize = True
        Me.lblMonto.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.lblMonto.Location = New System.Drawing.Point(21, 191)
        Me.lblMonto.Name = "lblMonto"
        Me.lblMonto.Size = New System.Drawing.Size(49, 18)
        Me.lblMonto.TabIndex = 101
        Me.lblMonto.Text = "Monto"
        '
        'txtMonto
        '
        Me.txtMonto.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.txtMonto.Location = New System.Drawing.Point(157, 183)
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.ReadOnly = True
        Me.txtMonto.Size = New System.Drawing.Size(206, 26)
        Me.txtMonto.TabIndex = 102
        '
        'dvgLineaDetalle
        '
        Me.dvgLineaDetalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dvgLineaDetalle.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dvgLineaDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dvgLineaDetalle.Location = New System.Drawing.Point(24, 236)
        Me.dvgLineaDetalle.Name = "dvgLineaDetalle"
        Me.dvgLineaDetalle.RowHeadersVisible = False
        Me.dvgLineaDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dvgLineaDetalle.Size = New System.Drawing.Size(417, 161)
        Me.dvgLineaDetalle.TabIndex = 103
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel1.Controls.Add(Me.gpbUsuario)
        Me.Panel1.Controls.Add(Me.gpbVentas)
        Me.Panel1.Controls.Add(Me.gpbVentasVendedor)
        Me.Panel1.Location = New System.Drawing.Point(17, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(967, 542)
        Me.Panel1.TabIndex = 105
        '
        'gpbUsuario
        '
        Me.gpbUsuario.Controls.Add(Me.cmbListar)
        Me.gpbUsuario.Controls.Add(Me.pbBuscarVentas)
        Me.gpbUsuario.Controls.Add(Me.lblCedula)
        Me.gpbUsuario.Controls.Add(Me.lblFechaInicio)
        Me.gpbUsuario.Controls.Add(Me.dtpInicio)
        Me.gpbUsuario.Controls.Add(Me.dtpFin)
        Me.gpbUsuario.Controls.Add(Me.lblFechaFin)
        Me.gpbUsuario.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpbUsuario.Location = New System.Drawing.Point(19, 45)
        Me.gpbUsuario.Name = "gpbUsuario"
        Me.gpbUsuario.Size = New System.Drawing.Size(425, 195)
        Me.gpbUsuario.TabIndex = 104
        Me.gpbUsuario.TabStop = False
        Me.gpbUsuario.Text = "Buscar Usuario"
        '
        'cmbListar
        '
        Me.cmbListar.FormattingEnabled = True
        Me.cmbListar.Location = New System.Drawing.Point(128, 53)
        Me.cmbListar.Name = "cmbListar"
        Me.cmbListar.Size = New System.Drawing.Size(157, 27)
        Me.cmbListar.TabIndex = 92
        '
        'pbBuscarVentas
        '
        Me.pbBuscarVentas.BackgroundImage = CType(resources.GetObject("pbBuscarVentas.BackgroundImage"), System.Drawing.Image)
        Me.pbBuscarVentas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pbBuscarVentas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbBuscarVentas.Location = New System.Drawing.Point(389, 159)
        Me.pbBuscarVentas.Name = "pbBuscarVentas"
        Me.pbBuscarVentas.Size = New System.Drawing.Size(30, 30)
        Me.pbBuscarVentas.TabIndex = 108
        Me.pbBuscarVentas.TabStop = False
        Me.help.SetToolTip(Me.pbBuscarVentas, "Buscar Ventas")
        '
        'lblCedula
        '
        Me.lblCedula.AutoSize = True
        Me.lblCedula.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.lblCedula.Location = New System.Drawing.Point(18, 53)
        Me.lblCedula.Name = "lblCedula"
        Me.lblCedula.Size = New System.Drawing.Size(104, 18)
        Me.lblCedula.TabIndex = 1
        Me.lblCedula.Text = "Cédula Usuario"
        '
        'lblFechaInicio
        '
        Me.lblFechaInicio.AutoSize = True
        Me.lblFechaInicio.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.lblFechaInicio.Location = New System.Drawing.Point(18, 118)
        Me.lblFechaInicio.Name = "lblFechaInicio"
        Me.lblFechaInicio.Size = New System.Drawing.Size(85, 18)
        Me.lblFechaInicio.TabIndex = 89
        Me.lblFechaInicio.Text = "Fecha Inicio"
        '
        'dtpInicio
        '
        Me.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpInicio.Location = New System.Drawing.Point(109, 118)
        Me.dtpInicio.Name = "dtpInicio"
        Me.dtpInicio.Size = New System.Drawing.Size(112, 27)
        Me.dtpInicio.TabIndex = 88
        '
        'dtpFin
        '
        Me.dtpFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFin.Location = New System.Drawing.Point(303, 116)
        Me.dtpFin.Name = "dtpFin"
        Me.dtpFin.Size = New System.Drawing.Size(116, 27)
        Me.dtpFin.TabIndex = 91
        '
        'lblFechaFin
        '
        Me.lblFechaFin.AutoSize = True
        Me.lblFechaFin.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.lblFechaFin.Location = New System.Drawing.Point(227, 118)
        Me.lblFechaFin.Name = "lblFechaFin"
        Me.lblFechaFin.Size = New System.Drawing.Size(70, 18)
        Me.lblFechaFin.TabIndex = 90
        Me.lblFechaFin.Text = "Fecha Fin"
        '
        'gpbVentas
        '
        Me.gpbVentas.Controls.Add(Me.txtFechaFacturacion)
        Me.gpbVentas.Controls.Add(Me.lblFechaFacturacion)
        Me.gpbVentas.Controls.Add(Me.dvgLineaDetalle)
        Me.gpbVentas.Controls.Add(Me.txtMonto)
        Me.gpbVentas.Controls.Add(Me.lblMonto)
        Me.gpbVentas.Controls.Add(Me.txtCliente)
        Me.gpbVentas.Controls.Add(Me.txtNum)
        Me.gpbVentas.Controls.Add(Me.lblNum)
        Me.gpbVentas.Controls.Add(Me.lblCliente)
        Me.gpbVentas.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpbVentas.Location = New System.Drawing.Point(471, 45)
        Me.gpbVentas.Name = "gpbVentas"
        Me.gpbVentas.Size = New System.Drawing.Size(461, 422)
        Me.gpbVentas.TabIndex = 105
        Me.gpbVentas.TabStop = False
        Me.gpbVentas.Text = "Ventas"
        Me.gpbVentas.Visible = False
        '
        'gpbVentasVendedor
        '
        Me.gpbVentasVendedor.Controls.Add(Me.pbVerVentas)
        Me.gpbVentasVendedor.Controls.Add(Me.dvgFactura)
        Me.gpbVentasVendedor.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpbVentasVendedor.Location = New System.Drawing.Point(19, 264)
        Me.gpbVentasVendedor.Name = "gpbVentasVendedor"
        Me.gpbVentasVendedor.Size = New System.Drawing.Size(419, 203)
        Me.gpbVentasVendedor.TabIndex = 110
        Me.gpbVentasVendedor.TabStop = False
        Me.gpbVentasVendedor.Text = "Ventas del Vendedor"
        Me.gpbVentasVendedor.Visible = False
        '
        'pbVerVentas
        '
        Me.pbVerVentas.BackgroundImage = CType(resources.GetObject("pbVerVentas.BackgroundImage"), System.Drawing.Image)
        Me.pbVerVentas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pbVerVentas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbVerVentas.Location = New System.Drawing.Point(301, 159)
        Me.pbVerVentas.Name = "pbVerVentas"
        Me.pbVerVentas.Size = New System.Drawing.Size(30, 30)
        Me.pbVerVentas.TabIndex = 109
        Me.pbVerVentas.TabStop = False
        Me.help.SetToolTip(Me.pbVerVentas, "Ver Ventas")
        '
        'ctlListarVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Controls.Add(Me.Panel1)
        Me.Name = "ctlListarVentas"
        Me.Size = New System.Drawing.Size(1024, 700)
        CType(Me.dvgFactura, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dvgLineaDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.gpbUsuario.ResumeLayout(False)
        Me.gpbUsuario.PerformLayout()
        CType(Me.pbBuscarVentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpbVentas.ResumeLayout(False)
        Me.gpbVentas.PerformLayout()
        Me.gpbVentasVendedor.ResumeLayout(False)
        CType(Me.pbVerVentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dvgFactura As System.Windows.Forms.DataGridView
    Friend WithEvents lblNum As System.Windows.Forms.Label
    Friend WithEvents txtNum As System.Windows.Forms.TextBox
    Friend WithEvents lblCliente As System.Windows.Forms.Label
    Friend WithEvents txtCliente As System.Windows.Forms.TextBox
    Friend WithEvents lblFechaFacturacion As System.Windows.Forms.Label
    Friend WithEvents txtFechaFacturacion As System.Windows.Forms.TextBox
    Friend WithEvents lblMonto As System.Windows.Forms.Label
    Friend WithEvents txtMonto As System.Windows.Forms.TextBox
    Friend WithEvents dvgLineaDetalle As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents gpbUsuario As System.Windows.Forms.GroupBox
    Friend WithEvents cmbListar As System.Windows.Forms.ComboBox
    Friend WithEvents lblCedula As System.Windows.Forms.Label
    Friend WithEvents lblFechaInicio As System.Windows.Forms.Label
    Friend WithEvents dtpInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblFechaFin As System.Windows.Forms.Label
    Friend WithEvents gpbVentas As System.Windows.Forms.GroupBox
    Friend WithEvents help As System.Windows.Forms.ToolTip
    Friend WithEvents pbBuscarVentas As System.Windows.Forms.PictureBox
    Friend WithEvents pbVerVentas As System.Windows.Forms.PictureBox
    Friend WithEvents gpbVentasVendedor As System.Windows.Forms.GroupBox

End Class
