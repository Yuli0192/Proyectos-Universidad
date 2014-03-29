<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctlBuscarFactura
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ctlBuscarFactura))
        Me.gbxBuscarFactura = New System.Windows.Forms.GroupBox
        Me.pbEliminar = New System.Windows.Forms.PictureBox
        Me.pbModificar = New System.Windows.Forms.PictureBox
        Me.dvgFactura = New System.Windows.Forms.DataGridView
        Me.txtCriterio = New System.Windows.Forms.TextBox
        Me.lblBuscar = New System.Windows.Forms.Label
        Me.gbxModificarFactura = New System.Windows.Forms.GroupBox
        Me.cmbEstado = New System.Windows.Forms.ComboBox
        Me.pbModificar2 = New System.Windows.Forms.PictureBox
        Me.dtpFacturacion = New System.Windows.Forms.DateTimePicker
        Me.dtpValidez = New System.Windows.Forms.DateTimePicker
        Me.dtpCreacion = New System.Windows.Forms.DateTimePicker
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtVendedor = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtMoneda = New System.Windows.Forms.TextBox
        Me.txtCliente = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.pbEliminarDetalle = New System.Windows.Forms.PictureBox
        Me.DgvDetalle = New System.Windows.Forms.DataGridView
        Me.txtMonto = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblFechaValidez = New System.Windows.Forms.Label
        Me.gbxServicios = New System.Windows.Forms.GroupBox
        Me.pbAgregarDetalle = New System.Windows.Forms.PictureBox
        Me.cmbServicios = New System.Windows.Forms.ComboBox
        Me.txtCantidad = New System.Windows.Forms.TextBox
        Me.lblCantidad = New System.Windows.Forms.Label
        Me.txtNumero = New System.Windows.Forms.TextBox
        Me.lblCliente = New System.Windows.Forms.Label
        Me.lblNum = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.gbxBuscarFactura.SuspendLayout()
        CType(Me.pbEliminar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbModificar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dvgFactura, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxModificarFactura.SuspendLayout()
        CType(Me.pbModificar2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.pbEliminarDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxServicios.SuspendLayout()
        CType(Me.pbAgregarDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbxBuscarFactura
        '
        Me.gbxBuscarFactura.Controls.Add(Me.pbEliminar)
        Me.gbxBuscarFactura.Controls.Add(Me.pbModificar)
        Me.gbxBuscarFactura.Controls.Add(Me.dvgFactura)
        Me.gbxBuscarFactura.Controls.Add(Me.txtCriterio)
        Me.gbxBuscarFactura.Controls.Add(Me.lblBuscar)
        Me.gbxBuscarFactura.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxBuscarFactura.Location = New System.Drawing.Point(28, 3)
        Me.gbxBuscarFactura.Name = "gbxBuscarFactura"
        Me.gbxBuscarFactura.Size = New System.Drawing.Size(459, 534)
        Me.gbxBuscarFactura.TabIndex = 9
        Me.gbxBuscarFactura.TabStop = False
        Me.gbxBuscarFactura.Text = "Buscar Factura"
        '
        'pbEliminar
        '
        Me.pbEliminar.BackgroundImage = CType(resources.GetObject("pbEliminar.BackgroundImage"), System.Drawing.Image)
        Me.pbEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbEliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbEliminar.Location = New System.Drawing.Point(404, 363)
        Me.pbEliminar.Name = "pbEliminar"
        Me.pbEliminar.Size = New System.Drawing.Size(30, 30)
        Me.pbEliminar.TabIndex = 57
        Me.pbEliminar.TabStop = False
        '
        'pbModificar
        '
        Me.pbModificar.AccessibleDescription = ""
        Me.pbModificar.BackgroundImage = CType(resources.GetObject("pbModificar.BackgroundImage"), System.Drawing.Image)
        Me.pbModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbModificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbModificar.Location = New System.Drawing.Point(348, 363)
        Me.pbModificar.Name = "pbModificar"
        Me.pbModificar.Size = New System.Drawing.Size(30, 30)
        Me.pbModificar.TabIndex = 56
        Me.pbModificar.TabStop = False
        '
        'dvgFactura
        '
        Me.dvgFactura.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dvgFactura.BackgroundColor = System.Drawing.Color.White
        Me.dvgFactura.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dvgFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dvgFactura.Location = New System.Drawing.Point(20, 91)
        Me.dvgFactura.Name = "dvgFactura"
        Me.dvgFactura.RowHeadersVisible = False
        Me.dvgFactura.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dvgFactura.Size = New System.Drawing.Size(414, 251)
        Me.dvgFactura.TabIndex = 10
        '
        'txtCriterio
        '
        Me.txtCriterio.Location = New System.Drawing.Point(68, 39)
        Me.txtCriterio.Name = "txtCriterio"
        Me.txtCriterio.Size = New System.Drawing.Size(366, 26)
        Me.txtCriterio.TabIndex = 1
        '
        'lblBuscar
        '
        Me.lblBuscar.AutoSize = True
        Me.lblBuscar.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBuscar.Location = New System.Drawing.Point(6, 39)
        Me.lblBuscar.Name = "lblBuscar"
        Me.lblBuscar.Size = New System.Drawing.Size(56, 18)
        Me.lblBuscar.TabIndex = 8
        Me.lblBuscar.Text = "Codigo:"
        '
        'gbxModificarFactura
        '
        Me.gbxModificarFactura.Controls.Add(Me.cmbEstado)
        Me.gbxModificarFactura.Controls.Add(Me.pbModificar2)
        Me.gbxModificarFactura.Controls.Add(Me.dtpFacturacion)
        Me.gbxModificarFactura.Controls.Add(Me.dtpValidez)
        Me.gbxModificarFactura.Controls.Add(Me.dtpCreacion)
        Me.gbxModificarFactura.Controls.Add(Me.Label5)
        Me.gbxModificarFactura.Controls.Add(Me.Label6)
        Me.gbxModificarFactura.Controls.Add(Me.Label4)
        Me.gbxModificarFactura.Controls.Add(Me.txtVendedor)
        Me.gbxModificarFactura.Controls.Add(Me.Label3)
        Me.gbxModificarFactura.Controls.Add(Me.txtMoneda)
        Me.gbxModificarFactura.Controls.Add(Me.txtCliente)
        Me.gbxModificarFactura.Controls.Add(Me.GroupBox1)
        Me.gbxModificarFactura.Controls.Add(Me.Label1)
        Me.gbxModificarFactura.Controls.Add(Me.lblFechaValidez)
        Me.gbxModificarFactura.Controls.Add(Me.gbxServicios)
        Me.gbxModificarFactura.Controls.Add(Me.txtNumero)
        Me.gbxModificarFactura.Controls.Add(Me.lblCliente)
        Me.gbxModificarFactura.Controls.Add(Me.lblNum)
        Me.gbxModificarFactura.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxModificarFactura.Location = New System.Drawing.Point(506, 4)
        Me.gbxModificarFactura.Name = "gbxModificarFactura"
        Me.gbxModificarFactura.Size = New System.Drawing.Size(427, 533)
        Me.gbxModificarFactura.TabIndex = 61
        Me.gbxModificarFactura.TabStop = False
        Me.gbxModificarFactura.Text = "Datos Principales"
        '
        'cmbEstado
        '
        Me.cmbEstado.FormattingEnabled = True
        Me.cmbEstado.Location = New System.Drawing.Point(206, 228)
        Me.cmbEstado.Name = "cmbEstado"
        Me.cmbEstado.Size = New System.Drawing.Size(206, 26)
        Me.cmbEstado.TabIndex = 67
        '
        'pbModificar2
        '
        Me.pbModificar2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.pbModificar2.BackgroundImage = CType(resources.GetObject("pbModificar2.BackgroundImage"), System.Drawing.Image)
        Me.pbModificar2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbModificar2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbModificar2.Location = New System.Drawing.Point(365, 260)
        Me.pbModificar2.Name = "pbModificar2"
        Me.pbModificar2.Size = New System.Drawing.Size(30, 30)
        Me.pbModificar2.TabIndex = 82
        Me.pbModificar2.TabStop = False
        '
        'dtpFacturacion
        '
        Me.dtpFacturacion.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.dtpFacturacion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFacturacion.Location = New System.Drawing.Point(206, 170)
        Me.dtpFacturacion.Name = "dtpFacturacion"
        Me.dtpFacturacion.Size = New System.Drawing.Size(206, 26)
        Me.dtpFacturacion.TabIndex = 79
        '
        'dtpValidez
        '
        Me.dtpValidez.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.dtpValidez.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpValidez.Location = New System.Drawing.Point(206, 140)
        Me.dtpValidez.Name = "dtpValidez"
        Me.dtpValidez.Size = New System.Drawing.Size(206, 26)
        Me.dtpValidez.TabIndex = 78
        '
        'dtpCreacion
        '
        Me.dtpCreacion.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.dtpCreacion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpCreacion.Location = New System.Drawing.Point(206, 110)
        Me.dtpCreacion.Name = "dtpCreacion"
        Me.dtpCreacion.Size = New System.Drawing.Size(206, 26)
        Me.dtpCreacion.TabIndex = 77
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(7, 241)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 18)
        Me.Label5.TabIndex = 75
        Me.Label5.Text = "Estado:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.Label6.Location = New System.Drawing.Point(7, 178)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(131, 18)
        Me.Label6.TabIndex = 73
        Me.Label6.Text = "Fecha Facturacion:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.Label4.Location = New System.Drawing.Point(7, 148)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(178, 18)
        Me.Label4.TabIndex = 71
        Me.Label4.Text = "Fecha Maxima de Validez:"
        '
        'txtVendedor
        '
        Me.txtVendedor.Location = New System.Drawing.Point(206, 81)
        Me.txtVendedor.Name = "txtVendedor"
        Me.txtVendedor.Size = New System.Drawing.Size(206, 26)
        Me.txtVendedor.TabIndex = 70
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(7, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 18)
        Me.Label3.TabIndex = 69
        Me.Label3.Text = "Vendedor:"
        '
        'txtMoneda
        '
        Me.txtMoneda.Location = New System.Drawing.Point(206, 199)
        Me.txtMoneda.Name = "txtMoneda"
        Me.txtMoneda.Size = New System.Drawing.Size(206, 26)
        Me.txtMoneda.TabIndex = 66
        '
        'txtCliente
        '
        Me.txtCliente.Location = New System.Drawing.Point(206, 52)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Size = New System.Drawing.Size(206, 26)
        Me.txtCliente.TabIndex = 65
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.pbEliminarDetalle)
        Me.GroupBox1.Controls.Add(Me.DgvDetalle)
        Me.GroupBox1.Controls.Add(Me.txtMonto)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(10, 362)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(402, 161)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Detalle"
        '
        'pbEliminarDetalle
        '
        Me.pbEliminarDetalle.BackgroundImage = CType(resources.GetObject("pbEliminarDetalle.BackgroundImage"), System.Drawing.Image)
        Me.pbEliminarDetalle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbEliminarDetalle.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbEliminarDetalle.Location = New System.Drawing.Point(353, 120)
        Me.pbEliminarDetalle.Name = "pbEliminarDetalle"
        Me.pbEliminarDetalle.Size = New System.Drawing.Size(30, 30)
        Me.pbEliminarDetalle.TabIndex = 61
        Me.pbEliminarDetalle.TabStop = False
        '
        'DgvDetalle
        '
        Me.DgvDetalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvDetalle.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvDetalle.Location = New System.Drawing.Point(18, 27)
        Me.DgvDetalle.Name = "DgvDetalle"
        Me.DgvDetalle.RowHeadersVisible = False
        Me.DgvDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvDetalle.Size = New System.Drawing.Size(365, 87)
        Me.DgvDetalle.TabIndex = 65
        '
        'txtMonto
        '
        Me.txtMonto.Location = New System.Drawing.Point(113, 124)
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.Size = New System.Drawing.Size(198, 26)
        Me.txtMonto.TabIndex = 67
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(15, 127)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 18)
        Me.Label2.TabIndex = 66
        Me.Label2.Text = "Monto Total:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 212)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 18)
        Me.Label1.TabIndex = 63
        Me.Label1.Text = "Moneda:"
        '
        'lblFechaValidez
        '
        Me.lblFechaValidez.AutoSize = True
        Me.lblFechaValidez.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.lblFechaValidez.Location = New System.Drawing.Point(7, 118)
        Me.lblFechaValidez.Name = "lblFechaValidez"
        Me.lblFechaValidez.Size = New System.Drawing.Size(133, 18)
        Me.lblFechaValidez.TabIndex = 62
        Me.lblFechaValidez.Text = "Fecha de Creacion:"
        '
        'gbxServicios
        '
        Me.gbxServicios.Controls.Add(Me.pbAgregarDetalle)
        Me.gbxServicios.Controls.Add(Me.cmbServicios)
        Me.gbxServicios.Controls.Add(Me.txtCantidad)
        Me.gbxServicios.Controls.Add(Me.lblCantidad)
        Me.gbxServicios.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxServicios.Location = New System.Drawing.Point(12, 290)
        Me.gbxServicios.Name = "gbxServicios"
        Me.gbxServicios.Size = New System.Drawing.Size(402, 63)
        Me.gbxServicios.TabIndex = 6
        Me.gbxServicios.TabStop = False
        Me.gbxServicios.Text = "Servicios"
        '
        'pbAgregarDetalle
        '
        Me.pbAgregarDetalle.BackgroundImage = CType(resources.GetObject("pbAgregarDetalle.BackgroundImage"), System.Drawing.Image)
        Me.pbAgregarDetalle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbAgregarDetalle.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbAgregarDetalle.Location = New System.Drawing.Point(350, 18)
        Me.pbAgregarDetalle.Name = "pbAgregarDetalle"
        Me.pbAgregarDetalle.Size = New System.Drawing.Size(33, 33)
        Me.pbAgregarDetalle.TabIndex = 65
        Me.pbAgregarDetalle.TabStop = False
        '
        'cmbServicios
        '
        Me.cmbServicios.FormattingEnabled = True
        Me.cmbServicios.Location = New System.Drawing.Point(18, 25)
        Me.cmbServicios.Name = "cmbServicios"
        Me.cmbServicios.Size = New System.Drawing.Size(181, 26)
        Me.cmbServicios.TabIndex = 66
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(280, 25)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(39, 26)
        Me.txtCantidad.TabIndex = 65
        '
        'lblCantidad
        '
        Me.lblCantidad.AutoSize = True
        Me.lblCantidad.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantidad.Location = New System.Drawing.Point(205, 25)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(69, 18)
        Me.lblCantidad.TabIndex = 65
        Me.lblCantidad.Text = "Cantidad:"
        '
        'txtNumero
        '
        Me.txtNumero.Location = New System.Drawing.Point(206, 23)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(206, 26)
        Me.txtNumero.TabIndex = 3
        '
        'lblCliente
        '
        Me.lblCliente.AutoSize = True
        Me.lblCliente.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCliente.Location = New System.Drawing.Point(9, 62)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(55, 18)
        Me.lblCliente.TabIndex = 2
        Me.lblCliente.Text = "Cliente:"
        '
        'lblNum
        '
        Me.lblNum.AutoSize = True
        Me.lblNum.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNum.Location = New System.Drawing.Point(9, 33)
        Me.lblNum.Name = "lblNum"
        Me.lblNum.Size = New System.Drawing.Size(65, 18)
        Me.lblNum.TabIndex = 0
        Me.lblNum.Text = "Numero:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.gbxModificarFactura)
        Me.Panel1.Controls.Add(Me.gbxBuscarFactura)
        Me.Panel1.Location = New System.Drawing.Point(21, 18)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(971, 652)
        Me.Panel1.TabIndex = 80
        '
        'ctlBuscarFactura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Controls.Add(Me.Panel1)
        Me.Name = "ctlBuscarFactura"
        Me.Size = New System.Drawing.Size(1024, 700)
        Me.gbxBuscarFactura.ResumeLayout(False)
        Me.gbxBuscarFactura.PerformLayout()
        CType(Me.pbEliminar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbModificar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dvgFactura, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxModificarFactura.ResumeLayout(False)
        Me.gbxModificarFactura.PerformLayout()
        CType(Me.pbModificar2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.pbEliminarDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxServicios.ResumeLayout(False)
        Me.gbxServicios.PerformLayout()
        CType(Me.pbAgregarDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbxBuscarFactura As System.Windows.Forms.GroupBox
    Friend WithEvents pbEliminar As System.Windows.Forms.PictureBox
    Friend WithEvents pbModificar As System.Windows.Forms.PictureBox
    Friend WithEvents dvgFactura As System.Windows.Forms.DataGridView
    Friend WithEvents txtCriterio As System.Windows.Forms.TextBox
    Friend WithEvents lblBuscar As System.Windows.Forms.Label
    Friend WithEvents gbxModificarFactura As System.Windows.Forms.GroupBox
    Friend WithEvents txtCliente As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DgvDetalle As System.Windows.Forms.DataGridView
    Friend WithEvents txtMonto As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblFechaValidez As System.Windows.Forms.Label
    Friend WithEvents gbxServicios As System.Windows.Forms.GroupBox
    Friend WithEvents pbAgregarDetalle As System.Windows.Forms.PictureBox
    Friend WithEvents cmbServicios As System.Windows.Forms.ComboBox
    Friend WithEvents txtCantidad As System.Windows.Forms.TextBox
    Friend WithEvents lblCantidad As System.Windows.Forms.Label
    Friend WithEvents txtNumero As System.Windows.Forms.TextBox
    Friend WithEvents lblCliente As System.Windows.Forms.Label
    Friend WithEvents lblNum As System.Windows.Forms.Label
    Friend WithEvents txtMoneda As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtVendedor As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dtpFacturacion As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpValidez As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpCreacion As System.Windows.Forms.DateTimePicker
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents pbEliminarDetalle As System.Windows.Forms.PictureBox
    Friend WithEvents pbModificar2 As System.Windows.Forms.PictureBox
    Friend WithEvents cmbEstado As System.Windows.Forms.ComboBox

End Class
