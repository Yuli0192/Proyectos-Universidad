<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctlReporteTotalComisionesPorVendedorPorPeriodo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ctlReporteTotalComisionesPorVendedorPorPeriodo))
        Me.reporteTotalComisionesVededorPorPeriodo1 = New CllInterfazGrafica.ReporteTotalComisionesVededorPorPeriodo
        Me.lblReporteComisionesVendedor = New System.Windows.Forms.Label
        Me.rprtVwrTotalComisionesPorVendedor = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.dtpFin = New System.Windows.Forms.DateTimePicker
        Me.lblFechaFin = New System.Windows.Forms.Label
        Me.lblFechaInicio = New System.Windows.Forms.Label
        Me.dtpInicio = New System.Windows.Forms.DateTimePicker
        Me.lblCedula = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.cmbListar = New System.Windows.Forms.ComboBox
        Me.help = New System.Windows.Forms.ToolTip(Me.components)
        Me.pbReporte = New System.Windows.Forms.PictureBox
        Me.Panel1.SuspendLayout()
        CType(Me.pbReporte, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblReporteComisionesVendedor
        '
        Me.lblReporteComisionesVendedor.AutoSize = True
        Me.lblReporteComisionesVendedor.Font = New System.Drawing.Font("Tahoma", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReporteComisionesVendedor.Location = New System.Drawing.Point(314, 17)
        Me.lblReporteComisionesVendedor.Name = "lblReporteComisionesVendedor"
        Me.lblReporteComisionesVendedor.Size = New System.Drawing.Size(325, 22)
        Me.lblReporteComisionesVendedor.TabIndex = 0
        Me.lblReporteComisionesVendedor.Text = "Reporte Total Comisiones Por Vendedor"
        '
        'rprtVwrTotalComisionesPorVendedor
        '
        Me.rprtVwrTotalComisionesPorVendedor.ActiveViewIndex = -1
        Me.rprtVwrTotalComisionesPorVendedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.rprtVwrTotalComisionesPorVendedor.Location = New System.Drawing.Point(16, 134)
        Me.rprtVwrTotalComisionesPorVendedor.Name = "rprtVwrTotalComisionesPorVendedor"
        Me.rprtVwrTotalComisionesPorVendedor.SelectionFormula = ""
        Me.rprtVwrTotalComisionesPorVendedor.Size = New System.Drawing.Size(949, 423)
        Me.rprtVwrTotalComisionesPorVendedor.TabIndex = 1
        Me.rprtVwrTotalComisionesPorVendedor.ViewTimeSelectionFormula = ""
        '
        'dtpFin
        '
        Me.dtpFin.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.dtpFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFin.Location = New System.Drawing.Point(536, 93)
        Me.dtpFin.Name = "dtpFin"
        Me.dtpFin.Size = New System.Drawing.Size(119, 26)
        Me.dtpFin.TabIndex = 36
        '
        'lblFechaFin
        '
        Me.lblFechaFin.AutoSize = True
        Me.lblFechaFin.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.lblFechaFin.Location = New System.Drawing.Point(450, 99)
        Me.lblFechaFin.Name = "lblFechaFin"
        Me.lblFechaFin.Size = New System.Drawing.Size(70, 18)
        Me.lblFechaFin.TabIndex = 35
        Me.lblFechaFin.Text = "Fecha Fin"
        '
        'lblFechaInicio
        '
        Me.lblFechaInicio.AutoSize = True
        Me.lblFechaInicio.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.lblFechaInicio.Location = New System.Drawing.Point(216, 99)
        Me.lblFechaInicio.Name = "lblFechaInicio"
        Me.lblFechaInicio.Size = New System.Drawing.Size(85, 18)
        Me.lblFechaInicio.TabIndex = 34
        Me.lblFechaInicio.Text = "Fecha Inicio"
        '
        'dtpInicio
        '
        Me.dtpInicio.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpInicio.Location = New System.Drawing.Point(318, 93)
        Me.dtpInicio.Name = "dtpInicio"
        Me.dtpInicio.Size = New System.Drawing.Size(117, 26)
        Me.dtpInicio.TabIndex = 33
        '
        'lblCedula
        '
        Me.lblCedula.AutoSize = True
        Me.lblCedula.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.lblCedula.Location = New System.Drawing.Point(216, 56)
        Me.lblCedula.Name = "lblCedula"
        Me.lblCedula.Size = New System.Drawing.Size(104, 18)
        Me.lblCedula.TabIndex = 39
        Me.lblCedula.Text = "Cédula Usuario"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel1.Controls.Add(Me.pbReporte)
        Me.Panel1.Controls.Add(Me.cmbListar)
        Me.Panel1.Controls.Add(Me.rprtVwrTotalComisionesPorVendedor)
        Me.Panel1.Controls.Add(Me.lblCedula)
        Me.Panel1.Controls.Add(Me.lblReporteComisionesVendedor)
        Me.Panel1.Controls.Add(Me.lblFechaInicio)
        Me.Panel1.Controls.Add(Me.lblFechaFin)
        Me.Panel1.Controls.Add(Me.dtpInicio)
        Me.Panel1.Controls.Add(Me.dtpFin)
        Me.Panel1.Location = New System.Drawing.Point(17, 31)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(986, 617)
        Me.Panel1.TabIndex = 40
        '
        'cmbListar
        '
        Me.cmbListar.FormattingEnabled = True
        Me.cmbListar.Location = New System.Drawing.Point(318, 56)
        Me.cmbListar.Name = "cmbListar"
        Me.cmbListar.Size = New System.Drawing.Size(157, 21)
        Me.cmbListar.TabIndex = 93
        '
        'pbReporte
        '
        Me.pbReporte.BackgroundImage = CType(resources.GetObject("pbReporte.BackgroundImage"), System.Drawing.Image)
        Me.pbReporte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pbReporte.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbReporte.Location = New System.Drawing.Point(675, 87)
        Me.pbReporte.Name = "pbReporte"
        Me.pbReporte.Size = New System.Drawing.Size(30, 30)
        Me.pbReporte.TabIndex = 94
        Me.pbReporte.TabStop = False
        Me.help.SetToolTip(Me.pbReporte, "Generar Reporte")
        '
        'ctlReporteTotalComisionesPorVendedorPorPeriodo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.Panel1)
        Me.Name = "ctlReporteTotalComisionesPorVendedorPorPeriodo"
        Me.Size = New System.Drawing.Size(1024, 700)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.pbReporte, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents reporteTotalComisionesVededorPorPeriodo1 As CllInterfazGrafica.ReporteTotalComisionesVededorPorPeriodo
    Friend WithEvents lblReporteComisionesVendedor As System.Windows.Forms.Label
    Friend WithEvents rprtVwrTotalComisionesPorVendedor As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents dtpFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblFechaFin As System.Windows.Forms.Label
    Friend WithEvents lblFechaInicio As System.Windows.Forms.Label
    Friend WithEvents dtpInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblCedula As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents help As System.Windows.Forms.ToolTip
    Friend WithEvents cmbListar As System.Windows.Forms.ComboBox
    Friend WithEvents pbReporte As System.Windows.Forms.PictureBox

End Class
