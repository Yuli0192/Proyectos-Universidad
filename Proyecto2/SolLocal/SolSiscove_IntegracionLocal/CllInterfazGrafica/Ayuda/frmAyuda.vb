Public Class frmAyuda

    ''' <summary>
    ''' Se encarga de obtener la informacion de un archivo xml para mostrar los textos de ayuda
    ''' </summary>
    ''' <param name="pnomXML"></param>
    ''' <param name="pnomEtiqueta"></param>
    ''' <remarks></remarks>
    Private Sub cargarXML(ByVal pnomXML As String, ByVal pnomEtiqueta As String)
        Dim _datos As XDocument = XDocument.Load(pnomXML)
        For Each element As XElement In _datos.Descendants(pnomEtiqueta)
            Me.rchAyuda.Text = element.Value
        Next
    End Sub

    Private Sub tvwAyuda_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles tvwAyuda.AfterSelect
        rchAyuda.BackColor = System.Drawing.SystemColors.Control
        rchAyuda.Text = ""
        If tvwAyuda.SelectedNode.Name = "chdRGrupo" Then
            cargarXML("ayuda_gv.xml", "RGV")
            rchAyuda.BackColor = Color.White
        End If
        If tvwAyuda.SelectedNode.Name = "chdBGrupo" Then
            cargarXML("ayuda_gv.xml", "BGV")
            rchAyuda.BackColor = Color.White
        End If
        If tvwAyuda.SelectedNode.Name = "chdMGrupo" Then
            cargarXML("ayuda_gv.xml", "MGV")
            rchAyuda.BackColor = Color.White
        End If
        If tvwAyuda.SelectedNode.Name = "chdEGrupo" Then
            cargarXML("ayuda_gv.xml", "EGV")
            rchAyuda.BackColor = Color.White
        End If
        If tvwAyuda.SelectedNode.Name = "chdRFactura" Then
            cargarXML("ayuda_fac.xml", "RF")
        End If
        If tvwAyuda.SelectedNode.Name = "chdBFactura" Then
            cargarXML("ayuda_fac.xml", "BF")
            rchAyuda.BackColor = Color.White
        End If
        If tvwAyuda.SelectedNode.Name = "chdMFactura" Then
            cargarXML("ayuda_fac.xml", "MF")
            rchAyuda.BackColor = Color.White
        End If
        If tvwAyuda.SelectedNode.Name = "chdEFactura" Then
            cargarXML("ayuda_fac.xml", "EF")
            rchAyuda.BackColor = Color.White
        End If
        If tvwAyuda.SelectedNode.Name = "chdCSesion" Then
            cargarXML("ayuda_ses.xml", "CS")
            rchAyuda.BackColor = Color.White
        End If
        If tvwAyuda.SelectedNode.Name = "chdISesion" Then
            cargarXML("ayuda_ses.xml", "IS")
            rchAyuda.BackColor = Color.White
        End If
        If tvwAyuda.SelectedNode.Name = "chdBServicio" Then
            cargarXML("ayuda_serv.xml", "BS")
            rchAyuda.BackColor = Color.White
        End If
        If tvwAyuda.SelectedNode.Name = "chdEServicio" Then
            cargarXML("ayuda_serv.xml", "ES")
            rchAyuda.BackColor = Color.White
        End If
        If tvwAyuda.SelectedNode.Name = "chdLServicio" Then
            cargarXML("ayuda_serv.xml", "LS")
            rchAyuda.BackColor = Color.White
        End If
        If tvwAyuda.SelectedNode.Name = "chdMServicio" Then
            cargarXML("ayuda_serv.xml", "MS")
            rchAyuda.BackColor = Color.White
        End If
        If tvwAyuda.SelectedNode.Name = "chdRServicio" Then
            cargarXML("ayuda_serv.xml", "RS")
            rchAyuda.BackColor = Color.White
        End If
        If tvwAyuda.SelectedNode.Name = "chdRPV" Then
            cargarXML("ayuda_pv.xml", "RPV")
            rchAyuda.BackColor = Color.White
        End If
        If tvwAyuda.SelectedNode.Name = "chdEPV" Then
            cargarXML("ayuda_pv.xml", "EPV")
            rchAyuda.BackColor = Color.White
        End If
        If tvwAyuda.SelectedNode.Name = "chdMPV" Then
            cargarXML("ayuda_pv.xml", "MPV")
            rchAyuda.BackColor = Color.White
        End If
        If tvwAyuda.SelectedNode.Name = "chdBPV" Then
            cargarXML("ayuda_pv.xml", "BPV")
            rchAyuda.BackColor = Color.White
        End If
        If tvwAyuda.SelectedNode.Name = "chdBC" Then
            cargarXML("ayuda_cli.xml", "BC")
            rchAyuda.BackColor = Color.White
        End If
        If tvwAyuda.SelectedNode.Name = "chdEC" Then
            cargarXML("ayuda_cli.xml", "EC")
            rchAyuda.BackColor = Color.White
        End If
        If tvwAyuda.SelectedNode.Name = "chdMC" Then
            cargarXML("ayuda_cli.xml", "MC")
            rchAyuda.BackColor = Color.White
        End If
        If tvwAyuda.SelectedNode.Name = "chdRC" Then
            cargarXML("ayuda_cli.xml", "RC")
            rchAyuda.BackColor = Color.White
        End If
        If tvwAyuda.SelectedNode.Name = "chdEU" Then
            cargarXML("ayuda_usuario.xml", "EU")
            rchAyuda.BackColor = Color.White
        End If
        If tvwAyuda.SelectedNode.Name = "chdMU" Then
            cargarXML("ayuda_usuario.xml", "MU")
            rchAyuda.BackColor = Color.White
        End If
        If tvwAyuda.SelectedNode.Name = "chdBU" Then
            cargarXML("ayuda_usuario.xml", "BU")
            rchAyuda.BackColor = Color.White
        End If
        If tvwAyuda.SelectedNode.Name = "chdRU" Then
            cargarXML("ayuda_usuario.xml", "RU")
            rchAyuda.BackColor = Color.White
        End If
    End Sub
End Class