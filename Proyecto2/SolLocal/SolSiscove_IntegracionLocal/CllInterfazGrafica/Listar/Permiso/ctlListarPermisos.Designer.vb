<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctlListarPermisos
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
        Me.dvgPermisos = New System.Windows.Forms.DataGridView
        Me.codigo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.nom = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.descp = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.gpListar = New System.Windows.Forms.GroupBox
        Me.ttListarPermiso = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.dvgPermisos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.gpListar.SuspendLayout()
        Me.SuspendLayout()
        '
        'dvgPermisos
        '
        Me.dvgPermisos.AllowUserToAddRows = False
        Me.dvgPermisos.AllowUserToDeleteRows = False
        Me.dvgPermisos.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dvgPermisos.ColumnHeadersHeight = 26
        Me.dvgPermisos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dvgPermisos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.codigo, Me.nom, Me.descp})
        Me.dvgPermisos.Location = New System.Drawing.Point(50, 55)
        Me.dvgPermisos.Name = "dvgPermisos"
        Me.dvgPermisos.ReadOnly = True
        Me.dvgPermisos.RowHeadersVisible = False
        Me.dvgPermisos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dvgPermisos.Size = New System.Drawing.Size(504, 176)
        Me.dvgPermisos.TabIndex = 10
        '
        'codigo
        '
        Me.codigo.HeaderText = "Cod"
        Me.codigo.MinimumWidth = 100
        Me.codigo.Name = "codigo"
        Me.codigo.ReadOnly = True
        '
        'nom
        '
        Me.nom.HeaderText = "Nombre"
        Me.nom.MinimumWidth = 100
        Me.nom.Name = "nom"
        Me.nom.ReadOnly = True
        '
        'descp
        '
        Me.descp.HeaderText = "Descripcion"
        Me.descp.MinimumWidth = 300
        Me.descp.Name = "descp"
        Me.descp.ReadOnly = True
        Me.descp.Width = 300
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel1.Controls.Add(Me.gpListar)
        Me.Panel1.Location = New System.Drawing.Point(201, 122)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(648, 362)
        Me.Panel1.TabIndex = 12
        '
        'gpListar
        '
        Me.gpListar.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.gpListar.Controls.Add(Me.dvgPermisos)
        Me.gpListar.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.gpListar.Location = New System.Drawing.Point(26, 51)
        Me.gpListar.Name = "gpListar"
        Me.gpListar.Size = New System.Drawing.Size(595, 252)
        Me.gpListar.TabIndex = 13
        Me.gpListar.TabStop = False
        Me.gpListar.Text = "Listar Permisos"
        '
        'ttListarPermiso
        '
        Me.ttListarPermiso.ToolTipTitle = "Regresar"
        '
        'ctlListarPermisos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Controls.Add(Me.Panel1)
        Me.Name = "ctlListarPermisos"
        Me.Size = New System.Drawing.Size(1024, 700)
        CType(Me.dvgPermisos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.gpListar.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dvgPermisos As System.Windows.Forms.DataGridView
    Friend WithEvents codigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nom As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents descp As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents gpListar As System.Windows.Forms.GroupBox
    Friend WithEvents ttListarPermiso As System.Windows.Forms.ToolTip

End Class
