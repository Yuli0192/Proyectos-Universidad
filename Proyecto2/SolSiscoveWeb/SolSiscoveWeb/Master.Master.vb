Public Partial Class Master
    Inherits System.Web.UI.MasterPage

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        Dim rolUsuario As String = Session("ROL_USUARIO")
        If rolUsuario.Equals("Gerente Ventas") Then
            MenuGerenteVentas.Visible = True
            MenuGerenteGeneral.Visible = False
            MenuVendedor.Visible = False

        ElseIf rolUsuario.Equals("Gerente General") Then
            MenuGerenteVentas.Visible = False
            MenuGerenteGeneral.Visible = True
            MenuVendedor.Visible = False

        ElseIf rolUsuario.Contains("Vendedor") Then
            MenuGerenteVentas.Visible = False
            MenuGerenteGeneral.Visible = False
            MenuVendedor.Visible = True

        End If


    End Sub

   
End Class