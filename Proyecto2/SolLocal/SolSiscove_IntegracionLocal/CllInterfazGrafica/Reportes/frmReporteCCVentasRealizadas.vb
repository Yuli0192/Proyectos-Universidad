Imports CrystalDecisions.CrystalReports.Engine

Public Class frmReporteCCVentasRealizadas
    Private _idgrupo As String
    Private _reporte As New rptCCVentasRealizadas()

    Public Sub New(ByVal pidgrupo As String)
        InitializeComponent()

        _idgrupo = pidgrupo
    End Sub

    Private Sub frmReporteCCVentasRealizadas_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        _reporte.SetParameterValue("idgrupo", "'" & _idgrupo & "'")
        Me.CrystalReportViewer1.ReportSource = _reporte
    End Sub
End Class