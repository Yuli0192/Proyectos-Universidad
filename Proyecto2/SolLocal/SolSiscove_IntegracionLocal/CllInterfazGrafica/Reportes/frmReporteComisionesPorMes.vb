
Public Class frmReporteComisionesPorMes

    Dim fecha1 As Date
    Dim fecha2 As Date
    Dim rango As Integer

    Public Sub New(ByVal pFecha1 As Date, ByVal pfecha2 As Date, ByVal prango As Integer)
        InitializeComponent()

        fecha1 = pFecha1
        fecha2 = pfecha2
        rango = prango
    End Sub

    
    Private Sub frmReporteComisionesPorMes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim _reporte As New rptComisionesPorMes()

        _reporte.SetParameterValue("fecha_inicio1", fecha1.Year.ToString() & "/" & fecha1.Month.ToString() & "/" & fecha1.Day.ToString())
        _reporte.SetParameterValue("fecha_inicio2", fecha2.Year.ToString() & "/" & fecha2.Month.ToString() & "/" & fecha2.Day.ToString())


        Dim fecha_final1 As Date = fecha1.Year.ToString() & "/" & (fecha1.Month).ToString() & "/" & fecha1.Day.ToString()
        Dim fecha_final2 As Date = fecha2.Year.ToString() & "/" & (fecha2.Month).ToString() & "/" & fecha2.Day.ToString()


        Select Case rango

            Case 1
                fecha_final1 = fecha_final1.AddMonths(1)
                fecha_final2 = fecha_final2.AddMonths(1)
            Case 2
                fecha_final1 = fecha_final1.AddMonths(3)
                fecha_final2 = fecha_final2.AddMonths(3)
            Case 3
                fecha_final1 = fecha_final1.AddYears(1)
                fecha_final2 = fecha_final2.AddYears(1)
        End Select

        _reporte.SetParameterValue("fecha_final1", fecha_final1.Year.ToString() & "/" & (fecha_final1.Month).ToString() & "/" & fecha_final1.Day.ToString())
        _reporte.SetParameterValue("fecha_final2", fecha_final2.Year.ToString() & "/" & (fecha_final2.Month).ToString() & "/" & fecha_final2.Day.ToString())
        Me.crvReporte.ReportSource = _reporte


    End Sub
End Class