<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctlReporte
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ctlReporte))
        Me.lblFecha1 = New System.Windows.Forms.Label
        Me.lblFecha2 = New System.Windows.Forms.Label
        Me.dtpFecha1 = New System.Windows.Forms.DateTimePicker
        Me.dtpFecha2 = New System.Windows.Forms.DateTimePicker
        Me.lblPeriodo = New System.Windows.Forms.Label
        Me.rbtAnual = New System.Windows.Forms.RadioButton
        Me.rbtMensual = New System.Windows.Forms.RadioButton
        Me.rbtTrimestral = New System.Windows.Forms.RadioButton
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.gpReporte = New System.Windows.Forms.GroupBox
        Me.pbGenerar = New System.Windows.Forms.PictureBox
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel1.SuspendLayout()
        Me.gpReporte.SuspendLayout()
        CType(Me.pbGenerar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblFecha1
        '
        Me.lblFecha1.AutoSize = True
        Me.lblFecha1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblFecha1.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.lblFecha1.Location = New System.Drawing.Point(37, 113)
        Me.lblFecha1.Name = "lblFecha1"
        Me.lblFecha1.Size = New System.Drawing.Size(118, 18)
        Me.lblFecha1.TabIndex = 0
        Me.lblFecha1.Text = "Comparar fecha:"
        '
        'lblFecha2
        '
        Me.lblFecha2.AutoSize = True
        Me.lblFecha2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblFecha2.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.lblFecha2.Location = New System.Drawing.Point(334, 113)
        Me.lblFecha2.Name = "lblFecha2"
        Me.lblFecha2.Size = New System.Drawing.Size(36, 18)
        Me.lblFecha2.TabIndex = 1
        Me.lblFecha2.Text = "con:"
        '
        'dtpFecha1
        '
        Me.dtpFecha1.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.dtpFecha1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha1.Location = New System.Drawing.Point(170, 107)
        Me.dtpFecha1.Name = "dtpFecha1"
        Me.dtpFecha1.Size = New System.Drawing.Size(121, 26)
        Me.dtpFecha1.TabIndex = 2
        '
        'dtpFecha2
        '
        Me.dtpFecha2.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.dtpFecha2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha2.Location = New System.Drawing.Point(376, 105)
        Me.dtpFecha2.Name = "dtpFecha2"
        Me.dtpFecha2.Size = New System.Drawing.Size(120, 26)
        Me.dtpFecha2.TabIndex = 3
        '
        'lblPeriodo
        '
        Me.lblPeriodo.AutoSize = True
        Me.lblPeriodo.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblPeriodo.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.lblPeriodo.Location = New System.Drawing.Point(37, 62)
        Me.lblPeriodo.Name = "lblPeriodo"
        Me.lblPeriodo.Size = New System.Drawing.Size(60, 18)
        Me.lblPeriodo.TabIndex = 5
        Me.lblPeriodo.Text = "Período:"
        '
        'rbtAnual
        '
        Me.rbtAnual.AutoSize = True
        Me.rbtAnual.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.rbtAnual.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.rbtAnual.Location = New System.Drawing.Point(337, 60)
        Me.rbtAnual.Name = "rbtAnual"
        Me.rbtAnual.Size = New System.Drawing.Size(61, 22)
        Me.rbtAnual.TabIndex = 6
        Me.rbtAnual.TabStop = True
        Me.rbtAnual.Text = "Anual"
        Me.rbtAnual.UseVisualStyleBackColor = False
        '
        'rbtMensual
        '
        Me.rbtMensual.AutoSize = True
        Me.rbtMensual.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.rbtMensual.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.rbtMensual.Location = New System.Drawing.Point(122, 58)
        Me.rbtMensual.Name = "rbtMensual"
        Me.rbtMensual.Size = New System.Drawing.Size(79, 22)
        Me.rbtMensual.TabIndex = 7
        Me.rbtMensual.TabStop = True
        Me.rbtMensual.Text = "Mensual"
        Me.rbtMensual.UseVisualStyleBackColor = False
        '
        'rbtTrimestral
        '
        Me.rbtTrimestral.AutoSize = True
        Me.rbtTrimestral.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.rbtTrimestral.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.rbtTrimestral.Location = New System.Drawing.Point(225, 58)
        Me.rbtTrimestral.Name = "rbtTrimestral"
        Me.rbtTrimestral.Size = New System.Drawing.Size(91, 22)
        Me.rbtTrimestral.TabIndex = 8
        Me.rbtTrimestral.TabStop = True
        Me.rbtTrimestral.Text = "Trimestral"
        Me.rbtTrimestral.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel1.Controls.Add(Me.gpReporte)
        Me.Panel1.Location = New System.Drawing.Point(139, 156)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(764, 288)
        Me.Panel1.TabIndex = 10
        '
        'gpReporte
        '
        Me.gpReporte.Controls.Add(Me.rbtTrimestral)
        Me.gpReporte.Controls.Add(Me.pbGenerar)
        Me.gpReporte.Controls.Add(Me.rbtMensual)
        Me.gpReporte.Controls.Add(Me.lblPeriodo)
        Me.gpReporte.Controls.Add(Me.rbtAnual)
        Me.gpReporte.Controls.Add(Me.lblFecha1)
        Me.gpReporte.Controls.Add(Me.lblFecha2)
        Me.gpReporte.Controls.Add(Me.dtpFecha2)
        Me.gpReporte.Controls.Add(Me.dtpFecha1)
        Me.gpReporte.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.gpReporte.Location = New System.Drawing.Point(96, 59)
        Me.gpReporte.Name = "gpReporte"
        Me.gpReporte.Size = New System.Drawing.Size(584, 167)
        Me.gpReporte.TabIndex = 6
        Me.gpReporte.TabStop = False
        Me.gpReporte.Text = "Reporte comparativo de comisiones entre dos periodos de tiempo"
        '
        'pbGenerar
        '
        Me.pbGenerar.BackgroundImage = CType(resources.GetObject("pbGenerar.BackgroundImage"), System.Drawing.Image)
        Me.pbGenerar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbGenerar.Location = New System.Drawing.Point(514, 103)
        Me.pbGenerar.Name = "pbGenerar"
        Me.pbGenerar.Size = New System.Drawing.Size(30, 30)
        Me.pbGenerar.TabIndex = 5
        Me.pbGenerar.TabStop = False
        Me.ToolTip1.SetToolTip(Me.pbGenerar, "Generar Reporte")
        '
        'ToolTip1
        '
        Me.ToolTip1.ToolTipTitle = "Regreso"
        '
        'ctlReporte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.Panel1)
        Me.Name = "ctlReporte"
        Me.Size = New System.Drawing.Size(1024, 700)
        Me.Panel1.ResumeLayout(False)
        Me.gpReporte.ResumeLayout(False)
        Me.gpReporte.PerformLayout()
        CType(Me.pbGenerar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblFecha1 As System.Windows.Forms.Label
    Friend WithEvents lblFecha2 As System.Windows.Forms.Label
    Friend WithEvents dtpFecha1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFecha2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblPeriodo As System.Windows.Forms.Label
    Friend WithEvents rbtAnual As System.Windows.Forms.RadioButton
    Friend WithEvents rbtMensual As System.Windows.Forms.RadioButton
    Friend WithEvents rbtTrimestral As System.Windows.Forms.RadioButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents pbGenerar As System.Windows.Forms.PictureBox
    Friend WithEvents gpReporte As System.Windows.Forms.GroupBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip

End Class
