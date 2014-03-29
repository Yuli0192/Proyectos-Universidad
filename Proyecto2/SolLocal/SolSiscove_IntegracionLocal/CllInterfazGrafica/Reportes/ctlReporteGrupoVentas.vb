Public Class ctlReporteGrupoVentas
    Private _frmSiscove As frmSiscove

    Public Sub New(ByVal pfrmSiscove As frmSiscove)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _frmSiscove = pfrmSiscove
    End Sub

    Private Sub pbRegresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        _frmSiscove.cargarUserControl(New ctlPrincipal)
    End Sub

    Private Sub pbGenerar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbGenerar.Click
        If txtIdGrupo.Text = "" Then
            MessageBox.Show("No se ha ingresado ningún criterio de búsqueda")
            txtIdGrupo.Focus()
        Else
            Dim frmReporte As New frmReporteCCVentasRealizadas(txtIdGrupo.Text)
            frmReporte.Visible = True
        End If
    End Sub
End Class
