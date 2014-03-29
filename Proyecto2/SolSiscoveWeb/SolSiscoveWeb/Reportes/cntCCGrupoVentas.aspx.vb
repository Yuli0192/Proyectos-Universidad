Public Partial Class cntCCGrupoVentas
    Inherits System.Web.UI.Page

    Private Function evaluar() As Boolean
        Dim bool As Boolean = False

        If txtCriterio.Text = "" Then
            MsgBox("El criterio de búsqueda es un dato requerido")
        Else
            bool = True
        End If

        Return bool
    End Function

    Protected Sub btnGenerarReporte_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btnGenerarReporte.Click
        Dim bool As Boolean = evaluar()
        Dim text As String = txtCriterio.Text

        If evaluar() = True Then

            Dim report As New CrystalDecisions.CrystalReports.Engine.ReportDocument
            report.Load(Server.MapPath("./rptComisionGrupoVentas.rpt"))
            report.SetParameterValue("id", text)
            Me.crvGrupo.ReportSource = report
            Me.crvGrupo.Visible = True

        End If
    End Sub
End Class