Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports.Engine

Public Class ctlReporteTotalComisionesPorPeriodo
    Private _frmSiscove As frmSiscove

    Public Sub New(ByVal pfrmSiscove As frmSiscove)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _frmSiscove = pfrmSiscove
    End Sub

    Private Sub pbReporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbReporte.Click
        Dim resul As Boolean = evaluarEspacio()
        If resul Then
            Dim reporte As New ReporteTotalComisionesPorPeriodo
            reporte.SetParameterValue("fechainicio", dtpInicio.Value)
            reporte.SetParameterValue("fechafin", dtpFin.Value)
            rprtVwrTotalComisiones.ReportSource = reporte
            rprtVwrTotalComisiones.Refresh()
        End If
    End Sub

    ''' <summary>
    ''' Método de clase, encarga de evaluar que no queden espacios en blanco ningun componente
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function evaluarEspacio() As Boolean
        Dim _resul As Boolean

        If dtpInicio.Value > dtpFin.Value Then
            MsgBox("la fecha inicio debe ser menor q la fecha fin ", MsgBoxStyle.Information, "Aviso")

        Else
            _resul = True
        End If
        Return _resul
    End Function

    Private Sub pbRegresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        _frmSiscove.cargarUserControl(New ctlPrincipal)
    End Sub
End Class
