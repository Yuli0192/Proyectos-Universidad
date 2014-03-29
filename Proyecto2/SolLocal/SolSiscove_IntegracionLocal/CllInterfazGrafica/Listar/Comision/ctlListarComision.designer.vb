<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctlListarComision
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ctlListarComision))
        Me.dvgComision = New System.Windows.Forms.DataGridView
        Me.gpbUsuario = New System.Windows.Forms.GroupBox
        Me.pbVerComision = New System.Windows.Forms.PictureBox
        Me.cmbListar = New System.Windows.Forms.ComboBox
        Me.lblCedula = New System.Windows.Forms.Label
        Me.lblFechaInicio = New System.Windows.Forms.Label
        Me.dtpInicio = New System.Windows.Forms.DateTimePicker
        Me.dtpFin = New System.Windows.Forms.DateTimePicker
        Me.lblFechaFin = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.gpbVerComision = New System.Windows.Forms.GroupBox
        Me.help = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.dvgComision, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpbUsuario.SuspendLayout()
        CType(Me.pbVerComision, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.gpbVerComision.SuspendLayout()
        Me.SuspendLayout()
        '
        'dvgComision
        '
        Me.dvgComision.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dvgComision.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dvgComision.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dvgComision.Location = New System.Drawing.Point(21, 26)
        Me.dvgComision.Name = "dvgComision"
        Me.dvgComision.RowHeadersVisible = False
        Me.dvgComision.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dvgComision.Size = New System.Drawing.Size(513, 169)
        Me.dvgComision.TabIndex = 100
        '
        'gpbUsuario
        '
        Me.gpbUsuario.Controls.Add(Me.pbVerComision)
        Me.gpbUsuario.Controls.Add(Me.cmbListar)
        Me.gpbUsuario.Controls.Add(Me.lblCedula)
        Me.gpbUsuario.Controls.Add(Me.lblFechaInicio)
        Me.gpbUsuario.Controls.Add(Me.dtpInicio)
        Me.gpbUsuario.Controls.Add(Me.dtpFin)
        Me.gpbUsuario.Controls.Add(Me.lblFechaFin)
        Me.gpbUsuario.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpbUsuario.Location = New System.Drawing.Point(102, 42)
        Me.gpbUsuario.Name = "gpbUsuario"
        Me.gpbUsuario.Size = New System.Drawing.Size(534, 190)
        Me.gpbUsuario.TabIndex = 105
        Me.gpbUsuario.TabStop = False
        Me.gpbUsuario.Text = "Buscar Usuario"
        '
        'pbVerComision
        '
        Me.pbVerComision.BackgroundImage = CType(resources.GetObject("pbVerComision.BackgroundImage"), System.Drawing.Image)
        Me.pbVerComision.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pbVerComision.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbVerComision.Location = New System.Drawing.Point(444, 118)
        Me.pbVerComision.Name = "pbVerComision"
        Me.pbVerComision.Size = New System.Drawing.Size(30, 30)
        Me.pbVerComision.TabIndex = 108
        Me.pbVerComision.TabStop = False
        Me.help.SetToolTip(Me.pbVerComision, "Ver Comisión")
        '
        'cmbListar
        '
        Me.cmbListar.FormattingEnabled = True
        Me.cmbListar.Location = New System.Drawing.Point(128, 53)
        Me.cmbListar.Name = "cmbListar"
        Me.cmbListar.Size = New System.Drawing.Size(157, 27)
        Me.cmbListar.TabIndex = 92
        '
        'lblCedula
        '
        Me.lblCedula.AutoSize = True
        Me.lblCedula.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.lblCedula.Location = New System.Drawing.Point(18, 57)
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
        Me.dtpFin.Location = New System.Drawing.Point(303, 118)
        Me.dtpFin.Name = "dtpFin"
        Me.dtpFin.Size = New System.Drawing.Size(108, 27)
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
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel1.Controls.Add(Me.gpbUsuario)
        Me.Panel1.Controls.Add(Me.gpbVerComision)
        Me.Panel1.Location = New System.Drawing.Point(140, 52)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(714, 569)
        Me.Panel1.TabIndex = 106
        '
        'gpbVerComision
        '
        Me.gpbVerComision.Controls.Add(Me.dvgComision)
        Me.gpbVerComision.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpbVerComision.Location = New System.Drawing.Point(102, 274)
        Me.gpbVerComision.Name = "gpbVerComision"
        Me.gpbVerComision.Size = New System.Drawing.Size(551, 222)
        Me.gpbVerComision.TabIndex = 109
        Me.gpbVerComision.TabStop = False
        Me.gpbVerComision.Text = "Comisión"
        Me.gpbVerComision.Visible = False
        '
        'ctlListarComision
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Controls.Add(Me.Panel1)
        Me.Name = "ctlListarComision"
        Me.Size = New System.Drawing.Size(1024, 700)
        CType(Me.dvgComision, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpbUsuario.ResumeLayout(False)
        Me.gpbUsuario.PerformLayout()
        CType(Me.pbVerComision, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.gpbVerComision.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dvgComision As System.Windows.Forms.DataGridView
    Friend WithEvents gpbUsuario As System.Windows.Forms.GroupBox
    Friend WithEvents cmbListar As System.Windows.Forms.ComboBox
    Friend WithEvents lblCedula As System.Windows.Forms.Label
    Friend WithEvents lblFechaInicio As System.Windows.Forms.Label
    Friend WithEvents dtpInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblFechaFin As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents help As System.Windows.Forms.ToolTip
    Friend WithEvents pbVerComision As System.Windows.Forms.PictureBox
    Friend WithEvents gpbVerComision As System.Windows.Forms.GroupBox

End Class
