Partial Public Class frmRptComisionesPor2Periodos
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    '''<summary>
    '''Método de clase, encarga de evaluar que la fecha inicio no sea mayor a la fecha fin ningun componente
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function evaluarFechas() As Boolean
        Dim _resul As Boolean

        If dtpFechaInicio.SelectedDate >= dtpFechaFin.SelectedDate Then
            MsgBox("La fecha inicio debe ser menor que la fecha fin ", MsgBoxStyle.Information, "Buscar Plan de Ventas")
        Else
            _resul = True
        End If
        Return _resul
    End Function

    Protected Sub bntReporte_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles bntReporte.Click
        Dim resul As Boolean = evaluarFechas()
        If resul Then
            crs1.Report.Parameters(0).DefaultValue = dtpFechaInicio.SelectedDate
            crs1.Report.Parameters(1).DefaultValue = dtpFechaFin.SelectedDate

            Dim fecha_inicio2 As Date
            Dim fecha_fin2 As Date

            Select Case rblCriterio.SelectedIndex

                Case 0

                    fecha_inicio2 = dtpFechaInicio.SelectedDate.AddMonths(1)
                    fecha_fin2 = dtpFechaFin.SelectedDate.AddMonths(1)

                Case 1
                    fecha_inicio2 = dtpFechaInicio.SelectedDate.AddMonths(3)
                    fecha_fin2 = dtpFechaInicio.SelectedDate.AddMonths(3)

                Case 2

                    fecha_inicio2 = dtpFechaInicio.SelectedDate.AddYears(1)
                    fecha_fin2 = dtpFechaInicio.SelectedDate.AddYears(1)


            End Select

            crs1.Report.Parameters(2).DefaultValue = fecha_inicio2
            crs1.Report.Parameters(3).DefaultValue = fecha_fin2

            crv1.RefreshReport()
            crv1.Visible = True
        End If
    End Sub
End Class