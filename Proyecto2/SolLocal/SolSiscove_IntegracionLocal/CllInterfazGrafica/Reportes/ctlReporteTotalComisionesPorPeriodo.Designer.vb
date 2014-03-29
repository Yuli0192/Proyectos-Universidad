<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctlReporteTotalComisionesPorPeriodo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ctlReporteTotalComisionesPorPeriodo))
        Me.lblReporteComisiones = New System.Windows.Forms.Label
        Me.rprtVwrTotalComisiones = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.dtpFin = New System.Windows.Forms.DateTimePicker
        Me.lblFechaFin = New System.Windows.Forms.Label
        Me.lblFechaInicio = New System.Windows.Forms.Label
        Me.dtpInicio = New System.Windows.Forms.DateTimePicker
        Me.reporteTotalComisionesPorPeriodo1 = New CllInterfazGrafica.ReporteTotalComisionesPorPeriodo
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.pbReporte = New System.Windows.Forms.PictureBox
        Me.help = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.pbReporte, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblReporteComisiones
        '
        Me.lblReporteComisiones.AutoSize = True
        Me.lblReporteComisiones.Font = New System.Drawing.Font("Tahoma", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReporteComisiones.Location = New System.Drawing.Point(362, 28)
        Me.lblReporteComisiones.Name = "lblReporteComisiones"
        Me.lblReporteComisiones.Size = New System.Drawing.Size(218, 22)
        Me.lblReporteComisiones.TabIndex = 1
        Me.lblReporteComisiones.Text = "Reporte Total Comisiones "
        '
        'rprtVwrTotalComisiones
        '
        Me.rprtVwrTotalComisiones.ActiveViewIndex = -1
        Me.rprtVwrTotalComisiones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.rprtVwrTotalComisiones.Location = New System.Drawing.Point(16, 124)
        Me.rprtVwrTotalComisiones.Name = "rprtVwrTotalComisiones"
        Me.rprtVwrTotalComisiones.SelectionFormula = ""
        Me.rprtVwrTotalComisiones.Size = New System.Drawing.Size(952, 425)
        Me.rprtVwrTotalComisiones.TabIndex = 2
        Me.rprtVwrTotalComisiones.ViewTimeSelectionFormula = ""
        '
        'dtpFin
        '
        Me.dtpFin.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.dtpFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFin.Location = New System.Drawing.Point(550, 80)
        Me.dtpFin.Name = "dtpFin"
        Me.dtpFin.Size = New System.Drawing.Size(119, 26)
        Me.dtpFin.TabIndex = 31
        '
        'lblFechaFin
        '
        Me.lblFechaFin.AutoSize = True
        Me.lblFechaFin.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.lblFechaFin.Location = New System.Drawing.Point(462, 84)
        Me.lblFechaFin.Name = "lblFechaFin"
        Me.lblFechaFin.Size = New System.Drawing.Size(70, 18)
        Me.lblFechaFin.TabIndex = 30
        Me.lblFechaFin.Text = "Fecha Fin"
        '
        'lblFechaInicio
        '
        Me.lblFechaInicio.AutoSize = True
        Me.lblFechaInicio.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.lblFechaInicio.Location = New System.Drawing.Point(202, 86)
        Me.lblFechaInicio.Name = "lblFechaInicio"
        Me.lblFechaInicio.Size = New System.Drawing.Size(85, 18)
        Me.lblFechaInicio.TabIndex = 29
        Me.lblFechaInicio.Text = "Fecha Inicio"
        '
        'dtpInicio
        '
        Me.dtpInicio.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpInicio.Location = New System.Drawing.Point(305, 82)
        Me.dtpInicio.Name = "dtpInicio"
        Me.dtpInicio.Size = New System.Drawing.Size(117, 26)
        Me.dtpInicio.TabIndex = 28
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel1.Controls.Add(Me.pbReporte)
        Me.Panel1.Controls.Add(Me.rprtVwrTotalComisiones)
        Me.Panel1.Controls.Add(Me.lblFechaInicio)
        Me.Panel1.Controls.Add(Me.lblFechaFin)
        Me.Panel1.Controls.Add(Me.dtpInicio)
        Me.Panel1.Controls.Add(Me.dtpFin)
        Me.Panel1.Controls.Add(Me.lblReporteComisiones)
        Me.Panel1.Location = New System.Drawing.Point(19, 38)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(983, 615)
        Me.Panel1.TabIndex = 33
        '
        'pbReporte
        '
        Me.pbReporte.BackgroundImage = CType(resources.GetObject("pbReporte.BackgroundImage"), System.Drawing.Image)
        Me.pbReporte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pbReporte.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbReporte.Location = New System.Drawing.Point(687, 76)
        Me.pbReporte.Name = "pbReporte"
        Me.pbReporte.Size = New System.Drawing.Size(30, 30)
        Me.pbReporte.TabIndex = 33
        Me.pbReporte.TabStop = False
        Me.help.SetToolTip(Me.pbReporte, "Generar Reporte")
        '
        'ctlReporteTotalComisionesPorPeriodo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.Panel1)
        Me.Name = "ctlReporteTotalComisionesPorPeriodo"
        Me.Size = New System.Drawing.Size(1024, 700)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.pbReporte, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblReporteComisiones As System.Windows.Forms.Label
    Friend WithEvents rprtVwrTotalComisiones As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents reporteTotalComisionesPorPeriodo1 As CllInterfazGrafica.ReporteTotalComisionesPorPeriodo
    Friend WithEvents dtpFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblFechaFin As System.Windows.Forms.Label
    Friend WithEvents lblFechaInicio As System.Windows.Forms.Label
    Friend WithEvents dtpInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents pbReporte As System.Windows.Forms.PictureBox
    Friend WithEvents help As System.Windows.Forms.ToolTip

End Class
