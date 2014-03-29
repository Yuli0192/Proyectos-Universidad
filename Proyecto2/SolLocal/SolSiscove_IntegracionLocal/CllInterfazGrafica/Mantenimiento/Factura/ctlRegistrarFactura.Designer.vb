<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctlRegistrarFactura
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ctlRegistrarFactura))
        Me.gbxRegistrarFactura = New System.Windows.Forms.GroupBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.DgvDetalle = New System.Windows.Forms.DataGridView
        Me.txtMonto = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmbMoneda = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblFechaValidez = New System.Windows.Forms.Label
        Me.dtpValidez = New System.Windows.Forms.DateTimePicker
        Me.pbLimpiarForm = New System.Windows.Forms.PictureBox
        Me.gbxServicios = New System.Windows.Forms.GroupBox
        Me.pbRegistrar = New System.Windows.Forms.PictureBox
        Me.cmbServicios = New System.Windows.Forms.ComboBox
        Me.txtCantidad = New System.Windows.Forms.TextBox
        Me.lblCantidad = New System.Windows.Forms.Label
        Me.cmbCliente = New System.Windows.Forms.ComboBox
        Me.txtNumero = New System.Windows.Forms.TextBox
        Me.lblCliente = New System.Windows.Forms.Label
        Me.lblNum = New System.Windows.Forms.Label
        Me.help = New System.Windows.Forms.ToolTip(Me.components)
        Me.gbxRegistrarFactura.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DgvDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbLimpiarForm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxServicios.SuspendLayout()
        CType(Me.pbRegistrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbxRegistrarFactura
        '
        Me.gbxRegistrarFactura.Controls.Add(Me.GroupBox1)
        Me.gbxRegistrarFactura.Controls.Add(Me.cmbMoneda)
        Me.gbxRegistrarFactura.Controls.Add(Me.Label1)
        Me.gbxRegistrarFactura.Controls.Add(Me.lblFechaValidez)
        Me.gbxRegistrarFactura.Controls.Add(Me.dtpValidez)
        Me.gbxRegistrarFactura.Controls.Add(Me.pbLimpiarForm)
        Me.gbxRegistrarFactura.Controls.Add(Me.gbxServicios)
        Me.gbxRegistrarFactura.Controls.Add(Me.cmbCliente)
        Me.gbxRegistrarFactura.Controls.Add(Me.txtNumero)
        Me.gbxRegistrarFactura.Controls.Add(Me.lblCliente)
        Me.gbxRegistrarFactura.Controls.Add(Me.lblNum)
        Me.gbxRegistrarFactura.Font = New System.Drawing.Font("Tahoma", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxRegistrarFactura.Location = New System.Drawing.Point(250, 37)
        Me.gbxRegistrarFactura.Name = "gbxRegistrarFactura"
        Me.gbxRegistrarFactura.Size = New System.Drawing.Size(530, 491)
        Me.gbxRegistrarFactura.TabIndex = 2
        Me.gbxRegistrarFactura.TabStop = False
        Me.gbxRegistrarFactura.Text = "Registrar Factura"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DgvDetalle)
        Me.GroupBox1.Controls.Add(Me.txtMonto)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(25, 234)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(477, 208)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Detalle"
        '
        'DgvDetalle
        '
        Me.DgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvDetalle.Location = New System.Drawing.Point(20, 33)
        Me.DgvDetalle.Name = "DgvDetalle"
        Me.DgvDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvDetalle.Size = New System.Drawing.Size(433, 128)
        Me.DgvDetalle.TabIndex = 65
        '
        'txtMonto
        '
        Me.txtMonto.Location = New System.Drawing.Point(134, 170)
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.Size = New System.Drawing.Size(198, 26)
        Me.txtMonto.TabIndex = 67
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(17, 170)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 18)
        Me.Label2.TabIndex = 66
        Me.Label2.Text = "Monto Total:"
        '
        'cmbMoneda
        '
        Me.cmbMoneda.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbMoneda.FormattingEnabled = True
        Me.cmbMoneda.Items.AddRange(New Object() {"Colones", "Dolares"})
        Me.cmbMoneda.Location = New System.Drawing.Point(226, 133)
        Me.cmbMoneda.Name = "cmbMoneda"
        Me.cmbMoneda.Size = New System.Drawing.Size(276, 26)
        Me.cmbMoneda.TabIndex = 64
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(31, 133)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 18)
        Me.Label1.TabIndex = 63
        Me.Label1.Text = "Moneda:"
        '
        'lblFechaValidez
        '
        Me.lblFechaValidez.AutoSize = True
        Me.lblFechaValidez.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.lblFechaValidez.Location = New System.Drawing.Point(31, 105)
        Me.lblFechaValidez.Name = "lblFechaValidez"
        Me.lblFechaValidez.Size = New System.Drawing.Size(178, 18)
        Me.lblFechaValidez.TabIndex = 62
        Me.lblFechaValidez.Text = "Fecha Maxima de Validez:"
        '
        'dtpValidez
        '
        Me.dtpValidez.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.dtpValidez.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpValidez.Location = New System.Drawing.Point(226, 99)
        Me.dtpValidez.Name = "dtpValidez"
        Me.dtpValidez.Size = New System.Drawing.Size(104, 26)
        Me.dtpValidez.TabIndex = 61
        '
        'pbLimpiarForm
        '
        Me.pbLimpiarForm.BackgroundImage = CType(resources.GetObject("pbLimpiarForm.BackgroundImage"), System.Drawing.Image)
        Me.pbLimpiarForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbLimpiarForm.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbLimpiarForm.Location = New System.Drawing.Point(445, 448)
        Me.pbLimpiarForm.Name = "pbLimpiarForm"
        Me.pbLimpiarForm.Size = New System.Drawing.Size(33, 33)
        Me.pbLimpiarForm.TabIndex = 60
        Me.pbLimpiarForm.TabStop = False
        Me.help.SetToolTip(Me.pbLimpiarForm, "Limpiar")
        '
        'gbxServicios
        '
        Me.gbxServicios.Controls.Add(Me.pbRegistrar)
        Me.gbxServicios.Controls.Add(Me.cmbServicios)
        Me.gbxServicios.Controls.Add(Me.txtCantidad)
        Me.gbxServicios.Controls.Add(Me.lblCantidad)
        Me.gbxServicios.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxServicios.Location = New System.Drawing.Point(25, 165)
        Me.gbxServicios.Name = "gbxServicios"
        Me.gbxServicios.Size = New System.Drawing.Size(477, 63)
        Me.gbxServicios.TabIndex = 6
        Me.gbxServicios.TabStop = False
        Me.gbxServicios.Text = "Servicios"
        '
        'pbRegistrar
        '
        Me.pbRegistrar.BackgroundImage = CType(resources.GetObject("pbRegistrar.BackgroundImage"), System.Drawing.Image)
        Me.pbRegistrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbRegistrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbRegistrar.Location = New System.Drawing.Point(420, 17)
        Me.pbRegistrar.Name = "pbRegistrar"
        Me.pbRegistrar.Size = New System.Drawing.Size(33, 33)
        Me.pbRegistrar.TabIndex = 65
        Me.pbRegistrar.TabStop = False
        Me.help.SetToolTip(Me.pbRegistrar, "Registrar linea detalle")
        '
        'cmbServicios
        '
        Me.cmbServicios.FormattingEnabled = True
        Me.cmbServicios.Location = New System.Drawing.Point(20, 24)
        Me.cmbServicios.Name = "cmbServicios"
        Me.cmbServicios.Size = New System.Drawing.Size(225, 26)
        Me.cmbServicios.TabIndex = 66
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(347, 24)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(57, 26)
        Me.txtCantidad.TabIndex = 65
        Me.help.SetToolTip(Me.txtCantidad, "10")
        '
        'lblCantidad
        '
        Me.lblCantidad.AutoSize = True
        Me.lblCantidad.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantidad.Location = New System.Drawing.Point(263, 24)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(69, 18)
        Me.lblCantidad.TabIndex = 65
        Me.lblCantidad.Text = "Cantidad:"
        '
        'cmbCliente
        '
        Me.cmbCliente.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCliente.FormattingEnabled = True
        Me.cmbCliente.Location = New System.Drawing.Point(226, 62)
        Me.cmbCliente.Name = "cmbCliente"
        Me.cmbCliente.Size = New System.Drawing.Size(276, 26)
        Me.cmbCliente.TabIndex = 5
        '
        'txtNumero
        '
        Me.txtNumero.Location = New System.Drawing.Point(225, 24)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(277, 28)
        Me.txtNumero.TabIndex = 3
        Me.help.SetToolTip(Me.txtNumero, "001")
        '
        'lblCliente
        '
        Me.lblCliente.AutoSize = True
        Me.lblCliente.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCliente.Location = New System.Drawing.Point(31, 62)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(55, 18)
        Me.lblCliente.TabIndex = 2
        Me.lblCliente.Text = "Cliente:"
        '
        'lblNum
        '
        Me.lblNum.AutoSize = True
        Me.lblNum.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNum.Location = New System.Drawing.Point(31, 24)
        Me.lblNum.Name = "lblNum"
        Me.lblNum.Size = New System.Drawing.Size(65, 18)
        Me.lblNum.TabIndex = 0
        Me.lblNum.Text = "Numero:"
        '
        'ctlRegistrarFactura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Controls.Add(Me.gbxRegistrarFactura)
        Me.Name = "ctlRegistrarFactura"
        Me.Size = New System.Drawing.Size(1024, 700)
        Me.gbxRegistrarFactura.ResumeLayout(False)
        Me.gbxRegistrarFactura.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DgvDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbLimpiarForm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxServicios.ResumeLayout(False)
        Me.gbxServicios.PerformLayout()
        CType(Me.pbRegistrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbxRegistrarFactura As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DgvDetalle As System.Windows.Forms.DataGridView
    Friend WithEvents txtMonto As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbMoneda As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblFechaValidez As System.Windows.Forms.Label
    Friend WithEvents dtpValidez As System.Windows.Forms.DateTimePicker
    Friend WithEvents pbLimpiarForm As System.Windows.Forms.PictureBox
    Friend WithEvents gbxServicios As System.Windows.Forms.GroupBox
    Friend WithEvents pbRegistrar As System.Windows.Forms.PictureBox
    Friend WithEvents cmbServicios As System.Windows.Forms.ComboBox
    Friend WithEvents txtCantidad As System.Windows.Forms.TextBox
    Friend WithEvents lblCantidad As System.Windows.Forms.Label
    Friend WithEvents cmbCliente As System.Windows.Forms.ComboBox
    Friend WithEvents txtNumero As System.Windows.Forms.TextBox
    Friend WithEvents lblCliente As System.Windows.Forms.Label
    Friend WithEvents lblNum As System.Windows.Forms.Label
    Friend WithEvents help As System.Windows.Forms.ToolTip

End Class
