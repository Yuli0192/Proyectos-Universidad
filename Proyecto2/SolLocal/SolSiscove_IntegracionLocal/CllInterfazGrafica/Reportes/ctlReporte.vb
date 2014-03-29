Public Class ctlReporte
    Private _frmSiscove As frmSiscove

    Public Sub New(ByVal pfrmSiscove As frmSiscove)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _frmSiscove = pfrmSiscove
    End Sub

    Private Sub ctlReporte_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.rbtMensual.Checked = True

    End Sub


    Private Sub pbGenerar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbGenerar.Click


        Dim rango As Integer

        If rbtMensual.Checked Then

            rango = 1

        ElseIf rbtTrimestral.Checked Then

            rango = 2

        Else

            rango = 3

        End If

        Dim reporte As New frmReporteComisionesPorMes(dtpFecha1.Value, dtpFecha2.Value, rango)
        reporte.Visible = True

    End Sub

    Private Sub pbRegresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        _frmSiscove.cargarUserControl(New ctlPrincipal)
    End Sub
End Class
