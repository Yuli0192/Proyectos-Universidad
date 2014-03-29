<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAyuda
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Buscar Cliente")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Eliminar Cliente")
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Modificar Cliente")
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Registrar Cliente")
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Cliente", New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode2, TreeNode3, TreeNode4})
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Buscar Factura")
        Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Eliminar Factura")
        Dim TreeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Modificar Factura")
        Dim TreeNode9 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Registrar Factura")
        Dim TreeNode10 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Factura", New System.Windows.Forms.TreeNode() {TreeNode6, TreeNode7, TreeNode8, TreeNode9})
        Dim TreeNode11 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Buscar Grupo de Ventas")
        Dim TreeNode12 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Eliminar Grupo de Ventas")
        Dim TreeNode13 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Modificar Grupo de Ventas")
        Dim TreeNode14 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Registrar Grupo de Ventas")
        Dim TreeNode15 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Grupo de Ventas", New System.Windows.Forms.TreeNode() {TreeNode11, TreeNode12, TreeNode13, TreeNode14})
        Dim TreeNode16 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Buscar Plan de Ventas")
        Dim TreeNode17 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("ELiminar Plan de Ventas")
        Dim TreeNode18 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Modificar Plan de Ventas")
        Dim TreeNode19 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Registrar Plan de Ventas")
        Dim TreeNode20 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Plan de Ventas", New System.Windows.Forms.TreeNode() {TreeNode16, TreeNode17, TreeNode18, TreeNode19})
        Dim TreeNode21 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Buscar Servicio")
        Dim TreeNode22 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Eliminar Servicio")
        Dim TreeNode23 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Listar Servicios")
        Dim TreeNode24 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Modificar Servicio")
        Dim TreeNode25 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Registrar Servicio")
        Dim TreeNode26 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Servicio", New System.Windows.Forms.TreeNode() {TreeNode21, TreeNode22, TreeNode23, TreeNode24, TreeNode25})
        Dim TreeNode27 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Cerrar Sesión")
        Dim TreeNode28 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Iniciar Seción")
        Dim TreeNode29 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Sesión", New System.Windows.Forms.TreeNode() {TreeNode27, TreeNode28})
        Dim TreeNode30 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Buscar Usuario")
        Dim TreeNode31 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Eliminar Usuario")
        Dim TreeNode32 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Modificar Usuario")
        Dim TreeNode33 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Registrar Usuario")
        Dim TreeNode34 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Usuario", New System.Windows.Forms.TreeNode() {TreeNode30, TreeNode31, TreeNode32, TreeNode33})
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAyuda))
        Me.tvwAyuda = New System.Windows.Forms.TreeView
        Me.rchAyuda = New System.Windows.Forms.RichTextBox
        Me.SuspendLayout()
        '
        'tvwAyuda
        '
        Me.tvwAyuda.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tvwAyuda.Location = New System.Drawing.Point(12, 12)
        Me.tvwAyuda.Name = "tvwAyuda"
        TreeNode1.Name = "chdBC"
        TreeNode1.Text = "Buscar Cliente"
        TreeNode2.Name = "chdEC"
        TreeNode2.Text = "Eliminar Cliente"
        TreeNode3.Name = "chdMC"
        TreeNode3.Text = "Modificar Cliente"
        TreeNode4.Name = "chdRC"
        TreeNode4.Text = "Registrar Cliente"
        TreeNode5.Name = "ndCliente"
        TreeNode5.Text = "Cliente"
        TreeNode6.Name = "chdBFactura"
        TreeNode6.Text = "Buscar Factura"
        TreeNode7.Name = "chdEFactura"
        TreeNode7.Text = "Eliminar Factura"
        TreeNode8.Name = "chdMFactura"
        TreeNode8.Text = "Modificar Factura"
        TreeNode9.Name = "chdRFactura"
        TreeNode9.Text = "Registrar Factura"
        TreeNode10.Name = "ndFactura"
        TreeNode10.Text = "Factura"
        TreeNode11.Name = "chdBGrupo"
        TreeNode11.Text = "Buscar Grupo de Ventas"
        TreeNode12.Name = "chdEGrupo"
        TreeNode12.Text = "Eliminar Grupo de Ventas"
        TreeNode13.Name = "chdMGrupo"
        TreeNode13.Text = "Modificar Grupo de Ventas"
        TreeNode14.Name = "chdRGrupo"
        TreeNode14.Text = "Registrar Grupo de Ventas"
        TreeNode15.Name = "ndGrupoVentas"
        TreeNode15.Text = "Grupo de Ventas"
        TreeNode16.Name = "chdBPV"
        TreeNode16.Text = "Buscar Plan de Ventas"
        TreeNode17.Name = "chdEPV"
        TreeNode17.Text = "ELiminar Plan de Ventas"
        TreeNode18.Name = "chdMPV"
        TreeNode18.Text = "Modificar Plan de Ventas"
        TreeNode19.Name = "chdRPV"
        TreeNode19.Text = "Registrar Plan de Ventas"
        TreeNode20.Name = "ndPlanVenta"
        TreeNode20.Text = "Plan de Ventas"
        TreeNode21.Name = "chdBServicio"
        TreeNode21.Text = "Buscar Servicio"
        TreeNode22.Name = "chdEServicio"
        TreeNode22.Text = "Eliminar Servicio"
        TreeNode23.Name = "chdLServicio"
        TreeNode23.Text = "Listar Servicios"
        TreeNode24.Name = "chdMServicio"
        TreeNode24.Text = "Modificar Servicio"
        TreeNode25.Name = "chdRServicio"
        TreeNode25.Text = "Registrar Servicio"
        TreeNode26.Name = "ndServicio"
        TreeNode26.Text = "Servicio"
        TreeNode27.Name = "chdCSesion"
        TreeNode27.Text = "Cerrar Sesión"
        TreeNode28.Name = "chdISesion"
        TreeNode28.Text = "Iniciar Seción"
        TreeNode29.Name = "ndSesion"
        TreeNode29.Text = "Sesión"
        TreeNode30.Name = "chdBU"
        TreeNode30.Text = "Buscar Usuario"
        TreeNode31.Name = "chdEU"
        TreeNode31.Text = "Eliminar Usuario"
        TreeNode32.Name = "chdMU"
        TreeNode32.Text = "Modificar Usuario"
        TreeNode33.Name = "chdRU"
        TreeNode33.Text = "Registrar Usuario"
        TreeNode34.Name = "ndUsuario"
        TreeNode34.Text = "Usuario"
        Me.tvwAyuda.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode5, TreeNode10, TreeNode15, TreeNode20, TreeNode26, TreeNode29, TreeNode34})
        Me.tvwAyuda.Size = New System.Drawing.Size(176, 373)
        Me.tvwAyuda.TabIndex = 0
        '
        'rchAyuda
        '
        Me.rchAyuda.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.rchAyuda.Location = New System.Drawing.Point(194, 12)
        Me.rchAyuda.Name = "rchAyuda"
        Me.rchAyuda.ReadOnly = True
        Me.rchAyuda.Size = New System.Drawing.Size(420, 373)
        Me.rchAyuda.TabIndex = 1
        Me.rchAyuda.Text = ""
        '
        'frmAyuda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(626, 397)
        Me.Controls.Add(Me.rchAyuda)
        Me.Controls.Add(Me.tvwAyuda)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmAyuda"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ayuda"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tvwAyuda As System.Windows.Forms.TreeView
    Friend WithEvents rchAyuda As System.Windows.Forms.RichTextBox
End Class
