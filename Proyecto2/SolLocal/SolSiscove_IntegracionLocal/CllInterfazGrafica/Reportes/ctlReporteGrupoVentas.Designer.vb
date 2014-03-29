<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctlReporteGrupoVentas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ctlReporteGrupoVentas))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.gbxGenerarReporte = New System.Windows.Forms.GroupBox
        Me.pbGenerar = New System.Windows.Forms.PictureBox
        Me.txtIdGrupo = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel1.SuspendLayout()
        Me.gbxGenerarReporte.SuspendLayout()
        CType(Me.pbGenerar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel1.Controls.Add(Me.gbxGenerarReporte)
        Me.Panel1.Location = New System.Drawing.Point(184, 122)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(635, 327)
        Me.Panel1.TabIndex = 0
        '
        'gbxGenerarReporte
        '
        Me.gbxGenerarReporte.Controls.Add(Me.pbGenerar)
        Me.gbxGenerarReporte.Controls.Add(Me.txtIdGrupo)
        Me.gbxGenerarReporte.Controls.Add(Me.Label1)
        Me.gbxGenerarReporte.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxGenerarReporte.Location = New System.Drawing.Point(75, 98)
        Me.gbxGenerarReporte.Name = "gbxGenerarReporte"
        Me.gbxGenerarReporte.Size = New System.Drawing.Size(483, 140)
        Me.gbxGenerarReporte.TabIndex = 0
        Me.gbxGenerarReporte.TabStop = False
        Me.gbxGenerarReporte.Text = "Generar Reporte por Grupo de Ventas"
        '
        'pbGenerar
        '
        Me.pbGenerar.BackgroundImage = CType(resources.GetObject("pbGenerar.BackgroundImage"), System.Drawing.Image)
        Me.pbGenerar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbGenerar.Location = New System.Drawing.Point(423, 74)
        Me.pbGenerar.Name = "pbGenerar"
        Me.pbGenerar.Size = New System.Drawing.Size(30, 30)
        Me.pbGenerar.TabIndex = 6
        Me.pbGenerar.TabStop = False
        '
        'txtIdGrupo
        '
        Me.txtIdGrupo.Location = New System.Drawing.Point(196, 77)
        Me.txtIdGrupo.Name = "txtIdGrupo"
        Me.txtIdGrupo.Size = New System.Drawing.Size(200, 27)
        Me.txtIdGrupo.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(178, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Id del Grupo de Ventas "
        '
        'ctlReporteGrupoVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.Panel1)
        Me.Name = "ctlReporteGrupoVentas"
        Me.Size = New System.Drawing.Size(1024, 700)
        Me.Panel1.ResumeLayout(False)
        Me.gbxGenerarReporte.ResumeLayout(False)
        Me.gbxGenerarReporte.PerformLayout()
        CType(Me.pbGenerar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents gbxGenerarReporte As System.Windows.Forms.GroupBox
    Friend WithEvents txtIdGrupo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents pbGenerar As System.Windows.Forms.PictureBox

End Class
