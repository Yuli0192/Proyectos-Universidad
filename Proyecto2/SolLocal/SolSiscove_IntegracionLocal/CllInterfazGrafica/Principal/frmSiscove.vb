Public Class frmSiscove

    Private _frmIniciar As frmIniciarSession

    Public Sub New(ByVal pfrmIniciar As frmIniciarSession)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _frmIniciar = pfrmIniciar

        'Informacion
        Me.Text = " Bienvenid@ " & DATOS_USUARIO(0) & " " & DATOS_USUARIO(1) & " " & DATOS_USUARIO(2) & " al Sistema Educativo S.A  |  Rol: " & DATOS_USUARIO(4)
    End Sub

    'Cargar un control
    Public Sub cargarUserControl(ByVal userControl As UserControl)
        userControl.Location = point
        quitarUserControl(userControl)
        Me.Controls.Add(userControl)
    End Sub

    'Quitar un control
    Public Sub quitarUserControl(ByVal p_uc As UserControl)
        For Each uc As Control In Me.Controls
            If TypeOf uc Is UserControl Then
                uc.Visible = False
            End If
        Next
        p_uc.Visible = True
    End Sub

    Private Sub registrarCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles registrarCliente.Click
        cargarUserControl(New ctlRegistrarCliente)
    End Sub

    Private Sub buscarCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buscarCliente.Click
        cargarUserControl(New ctlBuscarCliente)
    End Sub

    Private Sub registrarPlanVenta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles registrarPlanVenta.Click
        cargarUserControl(New ctlRegistrarPlanVenta)
    End Sub

    Private Sub buscarPlanVenta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buscarPlanVenta.Click
        cargarUserControl(New ctlBuscarPlanVenta)
    End Sub

    Private Sub listarVentasPorVendedor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles listarVentasPorVendedor.Click
        cargarUserControl(New ctlListarVentas())
    End Sub

    Private Sub listarComisionesPorVendedor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles listarComisionesPorVendedor.Click
        cargarUserControl(New ctlListarComision)
    End Sub

    Private Sub TotalComisionesPorPeriodoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TotalComisionesPorPeriodoToolStripMenuItem.Click
        cargarUserControl(New ctlReporteTotalComisionesPorPeriodo(Me))
    End Sub

    Private Sub TotalComisionesPorVendedorPorPeriodoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TotalComisionesPorVendedorPorPeriodoToolStripMenuItem.Click
        cargarUserControl(New ctlReporteTotalComisionesPorVendedorPorPeriodo)
    End Sub

    Private Sub frmSiscove_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        frmIniciarSession.Show()
        frmIniciarSession.txtContrasenna.Text = ""
        frmIniciarSession.txtusuario.Text = ""
        frmIniciarSession.txtusuario.Focus()
    End Sub

    Private Sub frmSiscove_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cargarUserControl(New ctlPrincipal)
    End Sub

    Private Sub FacturaToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FacturaToolStripMenuItem1.Click
        cargarUserControl(New ctlRegistrarFactura)
    End Sub

    Private Sub GrupoDeVentasToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GrupoDeVentasToolStripMenuItem1.Click
        cargarUserControl(New ctlRegistrarGrupo)
    End Sub

    Private Sub registarUsuario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles registarUsuario.Click
        cargarUserControl(New ctlRegistrarUsuario(Me))
    End Sub

    Private Sub registrarServicio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles registrarServicio.Click
        cargarUserControl(New ctlRegistrarServicio)
    End Sub

    Private Sub UsuarioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UsuarioToolStripMenuItem.Click
        cargarUserControl(New ctlBuscar(Me))
    End Sub

    Private Sub GrupoDeVentasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GrupoDeVentasToolStripMenuItem.Click
        cargarUserControl(New ctlBuscarGrupo(Me))
    End Sub

    Private Sub ServiciosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ServiciosToolStripMenuItem.Click
        cargarUserControl(New ctlBuscarServicio)
    End Sub

    Private Sub FacturaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FacturaToolStripMenuItem.Click
        cargarUserControl(New ctlBuscarFactura)
    End Sub

    Private Sub TotalComisionesPorGrupoDeVentasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TotalComisionesPorGrupoDeVentasToolStripMenuItem.Click
        cargarUserControl(New ctlReporteGrupoVentas(Me))
    End Sub

    Private Sub TotalComisionesPorVendedorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        cargarUserControl(New ctlReporte(Me))
    End Sub

    Private Sub CerrarSessiónToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CerrarSessiónToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub MenuStrip1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles MenuStrip1.Paint
        If ROL_USUARIO.Contains("Gerente General") Then
            RegistrarToolStripMenuItem.Visible = False 'Registrar
            listarVentasPorVendedor.Text = "Ventas Por Vendedor"
            listarComisionesPorVendedor.Text = "Comisiones Por Vendedor"

        ElseIf ROL_USUARIO.Contains("Gerente Ventas") Then
            listarVentasPorVendedor.Text = "Ventas Por Vendedor"
            listarComisionesPorVendedor.Text = "Comisiones Por Vendedor"

        ElseIf ROL_USUARIO.Contains("Vendedor") Then
            listarVentasPorVendedor.Text = "Mis Ventas"
            listarComisionesPorVendedor.Text = "Mis Comisiones"
            registrarPlanVenta.Visible = False
            registarUsuario.Visible = False
            registrarServicio.Visible = False
            GrupoDeVentasToolStripMenuItem1.Visible = False

        End If
    End Sub

    Private Sub AyudaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AyudaToolStripMenuItem.Click
        Dim frmAyuda As frmAyuda
        frmAyuda = New frmAyuda()
        frmAyuda.Show()
    End Sub

    Private Sub ComisionesEntre2PeriodosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComisionesEntre2PeriodosToolStripMenuItem.Click
        cargarUserControl(New ctlReporte(Me))
    End Sub

    Private Sub InicioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InicioToolStripMenuItem.Click
        cargarUserControl(New ctlPrincipal)
    End Sub
End Class