Public Partial Class ctnAyuda
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Private Sub cargarXML(ByVal pnomXML As String, ByVal pnomEtiqueta As String)
        Dim _datos As XDocument = XDocument.Load(pnomXML)
        For Each element As XElement In _datos.Descendants(pnomEtiqueta)
            Me.txtAtuda.Text = element.Value
        Next
    End Sub

    Protected Sub tvAyuda_SelectedNodeChanged(ByVal sender As Object, ByVal e As EventArgs) Handles tvAyuda.SelectedNodeChanged
        If tvAyuda.SelectedNode.Text = "Registrar Grupo de Ventas" Then
            cargarXML("ayuda_gv.xml", "RGV")
        End If
        If tvAyuda.SelectedNode.Text = "Buscar Grupo de Ventas" Then
            cargarXML("ayuda_gv.xml", "BGV")
        End If
        If tvAyuda.SelectedNode.Text = "Modificar Grupo de Ventas" Then
            cargarXML("ayuda_gv.xml", "MGV")
        End If
        If tvAyuda.SelectedNode.Text = "Eliminar Grupo de Ventas" Then
            cargarXML("ayuda_gv.xml", "EGV")
        End If
        If tvAyuda.SelectedNode.Text = "Registrar Factura" Then
            cargarXML("ayuda_fac.xml", "RF")
        End If
        If tvAyuda.SelectedNode.Text = "Buscar Factura" Then
            cargarXML("ayuda_fac.xml", "BF")
        End If
        If tvAyuda.SelectedNode.Text = "Modificar Factura" Then
            cargarXML("ayuda_fac.xml", "MF")
        End If
        If tvAyuda.SelectedNode.Text = "Eliminar Factura" Then
            cargarXML("ayuda_fac.xml", "EF")
        End If
        If tvAyuda.SelectedNode.Text = "Cerrar Sesión" Then
            cargarXML("ayuda_ses.xml", "CS")
        End If
        If tvAyuda.SelectedNode.Text = "Iniciar Sesión" Then
            cargarXML("ayuda_ses.xml", "IS")
        End If
        If tvAyuda.SelectedNode.Text = "Buscar Servicio" Then
            cargarXML("ayuda_serv.xml", "BS")
        End If
        If tvAyuda.SelectedNode.Text = "Eliminar Servicio" Then
            cargarXML("ayuda_serv.xml", "ES")
        End If
        If tvAyuda.SelectedNode.Text = "Modificar Servicio" Then
            cargarXML("ayuda_serv.xml", "MS")
        End If
        If tvAyuda.SelectedNode.Text = "Registrar Servicio" Then
            cargarXML("ayuda_serv.xml", "RS")
        End If
        If tvAyuda.SelectedNode.Text = "Registrar Grupo de Ventas" Then
            cargarXML("ayuda_pv.xml", "RPV")
        End If
        If tvAyuda.SelectedNode.Text = "Eliminar Grupo de Ventas" Then
            cargarXML("ayuda_pv.xml", "EPV")
        End If
        If tvAyuda.SelectedNode.Text = "Modificar Grupo de Ventas" Then
            cargarXML("ayuda_pv.xml", "MPV")
        End If
        If tvAyuda.SelectedNode.Text = "Buscar Grupo de Ventas" Then
            cargarXML("ayuda_pv.xml", "BPV")
        End If
        If tvAyuda.SelectedNode.Text = "Buscar Cliente" Then
            cargarXML("ayuda_cli.xml", "BC")
        End If
        If tvAyuda.SelectedNode.Text = "Eliminar Cliente" Then
            cargarXML("ayuda_cli.xml", "EC")
        End If
        If tvAyuda.SelectedNode.Text = "Modificar Cliente" Then
            cargarXML("ayuda_cli.xml", "MC")
        End If
        If tvAyuda.SelectedNode.Text = "Registrar Cliente" Then
            cargarXML("ayuda_cli.xml", "RC")
        End If
        If tvAyuda.SelectedNode.Text = "Eliminar Usuario" Then
            cargarXML("ayuda_usuario.xml", "EU")
        End If
        If tvAyuda.SelectedNode.Text = "Modificar Usuario" Then
            cargarXML("ayuda_usuario.xml", "MU")
        End If
        If tvAyuda.SelectedNode.Text = "Buscar Usuario" Then
            cargarXML("ayuda_usuario.xml", "BU")
        End If
        If tvAyuda.SelectedNode.Text = "Registrar Usuario" Then
            cargarXML("ayuda_usuario.xml", "RU")
        End If
    End Sub
End Class