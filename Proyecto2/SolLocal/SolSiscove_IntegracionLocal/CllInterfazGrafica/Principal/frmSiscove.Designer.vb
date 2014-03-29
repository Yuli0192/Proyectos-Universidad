<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSiscove
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSiscove))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.banner = New System.Windows.Forms.PictureBox
        Me.RegistrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.registrarCliente = New System.Windows.Forms.ToolStripMenuItem
        Me.registrarPlanVenta = New System.Windows.Forms.ToolStripMenuItem
        Me.registarUsuario = New System.Windows.Forms.ToolStripMenuItem
        Me.registrarServicio = New System.Windows.Forms.ToolStripMenuItem
        Me.GrupoDeVentasToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.FacturaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.BuscarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.buscarCliente = New System.Windows.Forms.ToolStripMenuItem
        Me.buscarPlanVenta = New System.Windows.Forms.ToolStripMenuItem
        Me.UsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GrupoDeVentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ServiciosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.FacturaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ListarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.listarVentasPorVendedor = New System.Windows.Forms.ToolStripMenuItem
        Me.listarComisionesPorVendedor = New System.Windows.Forms.ToolStripMenuItem
        Me.ReporteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TotalComisionesPorPeriodoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TotalComisionesPorVendedorPorPeriodoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ComisionesEntre2PeriodosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TotalComisionesPorGrupoDeVentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CerrarSessiónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.InicioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.banner, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(2, 614)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(995, 50)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'banner
        '
        Me.banner.BackColor = System.Drawing.Color.Transparent
        Me.banner.ErrorImage = CType(resources.GetObject("banner.ErrorImage"), System.Drawing.Image)
        Me.banner.Image = CType(resources.GetObject("banner.Image"), System.Drawing.Image)
        Me.banner.InitialImage = CType(resources.GetObject("banner.InitialImage"), System.Drawing.Image)
        Me.banner.Location = New System.Drawing.Point(2, -1)
        Me.banner.Name = "banner"
        Me.banner.Size = New System.Drawing.Size(1016, 61)
        Me.banner.TabIndex = 2
        Me.banner.TabStop = False
        '
        'RegistrarToolStripMenuItem
        '
        Me.RegistrarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.registrarCliente, Me.registrarPlanVenta, Me.registarUsuario, Me.registrarServicio, Me.GrupoDeVentasToolStripMenuItem1, Me.FacturaToolStripMenuItem1})
        Me.RegistrarToolStripMenuItem.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RegistrarToolStripMenuItem.Name = "RegistrarToolStripMenuItem"
        Me.RegistrarToolStripMenuItem.Size = New System.Drawing.Size(84, 23)
        Me.RegistrarToolStripMenuItem.Text = "Registrar"
        '
        'registrarCliente
        '
        Me.registrarCliente.Name = "registrarCliente"
        Me.registrarCliente.Size = New System.Drawing.Size(194, 24)
        Me.registrarCliente.Text = "Cliente"
        '
        'registrarPlanVenta
        '
        Me.registrarPlanVenta.Name = "registrarPlanVenta"
        Me.registrarPlanVenta.Size = New System.Drawing.Size(194, 24)
        Me.registrarPlanVenta.Text = "Plan de ventas"
        '
        'registarUsuario
        '
        Me.registarUsuario.Name = "registarUsuario"
        Me.registarUsuario.Size = New System.Drawing.Size(194, 24)
        Me.registarUsuario.Text = "Usuario"
        '
        'registrarServicio
        '
        Me.registrarServicio.Name = "registrarServicio"
        Me.registrarServicio.Size = New System.Drawing.Size(194, 24)
        Me.registrarServicio.Text = "Servicio"
        '
        'GrupoDeVentasToolStripMenuItem1
        '
        Me.GrupoDeVentasToolStripMenuItem1.Name = "GrupoDeVentasToolStripMenuItem1"
        Me.GrupoDeVentasToolStripMenuItem1.Size = New System.Drawing.Size(194, 24)
        Me.GrupoDeVentasToolStripMenuItem1.Text = "Grupo de ventas"
        '
        'FacturaToolStripMenuItem1
        '
        Me.FacturaToolStripMenuItem1.Name = "FacturaToolStripMenuItem1"
        Me.FacturaToolStripMenuItem1.Size = New System.Drawing.Size(194, 24)
        Me.FacturaToolStripMenuItem1.Text = "Factura"
        '
        'BuscarToolStripMenuItem
        '
        Me.BuscarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.buscarCliente, Me.buscarPlanVenta, Me.UsuarioToolStripMenuItem, Me.GrupoDeVentasToolStripMenuItem, Me.ServiciosToolStripMenuItem, Me.FacturaToolStripMenuItem})
        Me.BuscarToolStripMenuItem.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.BuscarToolStripMenuItem.Name = "BuscarToolStripMenuItem"
        Me.BuscarToolStripMenuItem.Size = New System.Drawing.Size(67, 23)
        Me.BuscarToolStripMenuItem.Text = "Buscar"
        '
        'buscarCliente
        '
        Me.buscarCliente.Name = "buscarCliente"
        Me.buscarCliente.Size = New System.Drawing.Size(194, 24)
        Me.buscarCliente.Text = "Cliente"
        '
        'buscarPlanVenta
        '
        Me.buscarPlanVenta.Name = "buscarPlanVenta"
        Me.buscarPlanVenta.Size = New System.Drawing.Size(194, 24)
        Me.buscarPlanVenta.Text = "Plan de ventas"
        '
        'UsuarioToolStripMenuItem
        '
        Me.UsuarioToolStripMenuItem.Name = "UsuarioToolStripMenuItem"
        Me.UsuarioToolStripMenuItem.Size = New System.Drawing.Size(194, 24)
        Me.UsuarioToolStripMenuItem.Text = "Usuario"
        '
        'GrupoDeVentasToolStripMenuItem
        '
        Me.GrupoDeVentasToolStripMenuItem.Name = "GrupoDeVentasToolStripMenuItem"
        Me.GrupoDeVentasToolStripMenuItem.Size = New System.Drawing.Size(194, 24)
        Me.GrupoDeVentasToolStripMenuItem.Text = "Grupo de ventas"
        '
        'ServiciosToolStripMenuItem
        '
        Me.ServiciosToolStripMenuItem.Name = "ServiciosToolStripMenuItem"
        Me.ServiciosToolStripMenuItem.Size = New System.Drawing.Size(194, 24)
        Me.ServiciosToolStripMenuItem.Text = "Servicios"
        '
        'FacturaToolStripMenuItem
        '
        Me.FacturaToolStripMenuItem.Name = "FacturaToolStripMenuItem"
        Me.FacturaToolStripMenuItem.Size = New System.Drawing.Size(194, 24)
        Me.FacturaToolStripMenuItem.Text = "Factura"
        '
        'ListarToolStripMenuItem
        '
        Me.ListarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.listarVentasPorVendedor, Me.listarComisionesPorVendedor})
        Me.ListarToolStripMenuItem.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.ListarToolStripMenuItem.Name = "ListarToolStripMenuItem"
        Me.ListarToolStripMenuItem.Size = New System.Drawing.Size(59, 23)
        Me.ListarToolStripMenuItem.Text = "Listar"
        '
        'listarVentasPorVendedor
        '
        Me.listarVentasPorVendedor.Name = "listarVentasPorVendedor"
        Me.listarVentasPorVendedor.Size = New System.Drawing.Size(259, 24)
        Me.listarVentasPorVendedor.Text = "Ventas por vendedor"
        '
        'listarComisionesPorVendedor
        '
        Me.listarComisionesPorVendedor.Name = "listarComisionesPorVendedor"
        Me.listarComisionesPorVendedor.Size = New System.Drawing.Size(259, 24)
        Me.listarComisionesPorVendedor.Text = "Comisiones por vendedor"
        '
        'ReporteToolStripMenuItem
        '
        Me.ReporteToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TotalComisionesPorPeriodoToolStripMenuItem, Me.TotalComisionesPorVendedorPorPeriodoToolStripMenuItem, Me.ComisionesEntre2PeriodosToolStripMenuItem, Me.TotalComisionesPorGrupoDeVentasToolStripMenuItem})
        Me.ReporteToolStripMenuItem.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReporteToolStripMenuItem.Name = "ReporteToolStripMenuItem"
        Me.ReporteToolStripMenuItem.Size = New System.Drawing.Size(76, 23)
        Me.ReporteToolStripMenuItem.Text = "Reporte"
        '
        'TotalComisionesPorPeriodoToolStripMenuItem
        '
        Me.TotalComisionesPorPeriodoToolStripMenuItem.Name = "TotalComisionesPorPeriodoToolStripMenuItem"
        Me.TotalComisionesPorPeriodoToolStripMenuItem.Size = New System.Drawing.Size(385, 24)
        Me.TotalComisionesPorPeriodoToolStripMenuItem.Text = "Total comisiones por periodo"
        '
        'TotalComisionesPorVendedorPorPeriodoToolStripMenuItem
        '
        Me.TotalComisionesPorVendedorPorPeriodoToolStripMenuItem.Name = "TotalComisionesPorVendedorPorPeriodoToolStripMenuItem"
        Me.TotalComisionesPorVendedorPorPeriodoToolStripMenuItem.Size = New System.Drawing.Size(385, 24)
        Me.TotalComisionesPorVendedorPorPeriodoToolStripMenuItem.Text = "Total comisiones por vendedor por periodo"
        '
        'ComisionesEntre2PeriodosToolStripMenuItem
        '
        Me.ComisionesEntre2PeriodosToolStripMenuItem.Name = "ComisionesEntre2PeriodosToolStripMenuItem"
        Me.ComisionesEntre2PeriodosToolStripMenuItem.Size = New System.Drawing.Size(385, 24)
        Me.ComisionesEntre2PeriodosToolStripMenuItem.Text = "Comisiones entre 2 periodos diferentes "
        '
        'TotalComisionesPorGrupoDeVentasToolStripMenuItem
        '
        Me.TotalComisionesPorGrupoDeVentasToolStripMenuItem.Name = "TotalComisionesPorGrupoDeVentasToolStripMenuItem"
        Me.TotalComisionesPorGrupoDeVentasToolStripMenuItem.Size = New System.Drawing.Size(385, 24)
        Me.TotalComisionesPorGrupoDeVentasToolStripMenuItem.Text = "Total comisiones por grupo de ventas"
        '
        'CerrarSessiónToolStripMenuItem
        '
        Me.CerrarSessiónToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.CerrarSessiónToolStripMenuItem.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.CerrarSessiónToolStripMenuItem.Name = "CerrarSessiónToolStripMenuItem"
        Me.CerrarSessiónToolStripMenuItem.Size = New System.Drawing.Size(116, 23)
        Me.CerrarSessiónToolStripMenuItem.Text = "Cerrar Sesión"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.AliceBlue
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InicioToolStripMenuItem, Me.RegistrarToolStripMenuItem, Me.BuscarToolStripMenuItem, Me.ListarToolStripMenuItem, Me.ReporteToolStripMenuItem, Me.AyudaToolStripMenuItem, Me.CerrarSessiónToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 62)
        Me.MenuStrip1.MinimumSize = New System.Drawing.Size(1016, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(0, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1016, 27)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'InicioToolStripMenuItem
        '
        Me.InicioToolStripMenuItem.Name = "InicioToolStripMenuItem"
        Me.InicioToolStripMenuItem.Size = New System.Drawing.Size(60, 23)
        Me.InicioToolStripMenuItem.Text = "Inicio"
        '
        'AyudaToolStripMenuItem
        '
        Me.AyudaToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.AyudaToolStripMenuItem.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        Me.AyudaToolStripMenuItem.Size = New System.Drawing.Size(66, 23)
        Me.AyudaToolStripMenuItem.Text = "Ayuda"
        '
        'frmSiscove
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(1014, 664)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.banner)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmSiscove"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.banner, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents banner As System.Windows.Forms.PictureBox
    Friend WithEvents RegistrarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents registrarCliente As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents registrarPlanVenta As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents registarUsuario As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents registrarServicio As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GrupoDeVentasToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FacturaToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BuscarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents buscarCliente As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents buscarPlanVenta As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UsuarioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GrupoDeVentasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ServiciosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FacturaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents listarVentasPorVendedor As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents listarComisionesPorVendedor As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReporteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TotalComisionesPorPeriodoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TotalComisionesPorVendedorPorPeriodoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ComisionesEntre2PeriodosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TotalComisionesPorGrupoDeVentasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CerrarSessiónToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents AyudaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InicioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
