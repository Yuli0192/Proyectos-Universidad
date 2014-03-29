Imports CllLogicaNegocio.ClsGestor
Partial Public Class frmRegistrarServicio
    Inherits System.Web.UI.Page
    Dim _gestor As New CllLogicaNegocio.ClsGestor
    

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub
    Protected Sub bntRegistrar_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles bntRegistrar.Click
        If validarDatos() Then
            Try
                _gestor.registrarservicio(txtCodigo.Text, txtNombre.Text, txtDescripcion.Text, txtPrecioColones.Text, txtPrecioDolares.Text, txtJuniorColones.Text, txtJuniorDolares.Text, txtSeniorColones.Text, txtSeniorDolares.Text, txtMasterColones.Text, txtMasterDolares.Text)

                Response.Write("<script language='javascript' type='text/javascript'> alert('Servicio Registrado');</script>")
                limpiar()
            Catch ex As Exception
                Response.Write("<script language='javascript' type='text/javascript'> alert('Error - Funcion btnRegistrar_Click en frmRegistrarServicio');</script>")
                txtNombre.Focus()
            End Try
        End If
    End Sub

    ''' <summary>
    ''' Método de clase, encarga de evaluar que no queden espacios en blanco ningún componente
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Protected Function validarDatos() As Boolean
        If txtCodigo.Text.Equals("") Then
            Response.Write("<script language='javascript' type='text/javascript'> alert('El identificador del servicio es un dato requerido');</script>")
            Me.txtCodigo.Focus()
            Return False
        ElseIf txtNombre.Text.Equals("") Then
            Response.Write("<script language='javascript' type='text/javascript'> alert('El nombre del servicio es un dato requerido');</script>")
            Me.txtNombre.Focus()
            Return False
        ElseIf txtDescripcion.Text.Equals("") Then
            Response.Write("<script language='javascript' type='text/javascript'> alert('La descripcion del servicio es un dato requerido');</script>")
            Me.txtDescripcion.Focus()
            Return False
        ElseIf txtPrecioColones.Text.Equals("") Then
            Response.Write("<script language='javascript' type='text/javascript'> alert('El precio en colones del servicio es un dato requerido');</script>")
            Me.txtPrecioColones.Focus()
            Return False
        ElseIf Not IsNumeric(txtPrecioColones.Text) Then
            Response.Write("<script language='javascript' type='text/javascript'> alert('El precio en colones deber ser un numero');</script>")
            Me.txtPrecioColones.Focus()
            Return False
        ElseIf txtPrecioDolares.Text.Equals("") Then
            Response.Write("<script language='javascript' type='text/javascript'> alert('El precio en dolares del servicio es un dato requerido');</script>")
            Me.txtPrecioDolares.Focus()
            Return False
        ElseIf Not IsNumeric(txtPrecioDolares.Text) Then
            Response.Write("<script language='javascript' type='text/javascript'> alert('El precio en dolares deber ser un numero');</script>")
            Me.txtPrecioDolares.Focus()
            Return False
        ElseIf txtJuniorColones.Text.Equals("") Then
            Response.Write("<script language='javascript' type='text/javascript'> alert('La comision junior en colones es un dato requerido');</script>")
            Me.txtJuniorColones.Focus()
            Return False
        ElseIf Not IsNumeric(txtJuniorColones.Text) Then
            Response.Write("<script language='javascript' type='text/javascript'> alert('La comison junior en colones deber ser un numero');</script>")
            Me.txtJuniorColones.Focus()
            Return False
        ElseIf txtJuniorDolares.Text.Equals("") Then
            Response.Write("<script language='javascript' type='text/javascript'> alert('La comision junior en dolares es un dato requerido');</script>")
            Me.txtJuniorDolares.Focus()
            Return False
        ElseIf Not IsNumeric(txtJuniorDolares.Text) Then
            Response.Write("<script language='javascript' type='text/javascript'> alert('La comison junior en dolares deber ser un numero');</script>")
            Me.txtJuniorDolares.Focus()
            Return False
        ElseIf txtSeniorColones.Text.Equals("") Then
            Response.Write("<script language='javascript' type='text/javascript'> alert('La comision senior en colones es un dato requerido');</script>")
            Me.txtSeniorColones.Focus()
            Return False
        ElseIf Not IsNumeric(txtSeniorColones.Text) Then
            Response.Write("<script language='javascript' type='text/javascript'> alert('La comison senior en colones deber ser un numero');</script>")
            Me.txtSeniorColones.Focus()
            Return False
        ElseIf txtSeniorDolares.Text.Equals("") Then
            Response.Write("<script language='javascript' type='text/javascript'> alert('La comision senior en dolares es un dato requerido');</script>")
            Me.txtSeniorDolares.Focus()
            Return False
        ElseIf Not IsNumeric(txtSeniorDolares.Text) Then
            Response.Write("<script language='javascript' type='text/javascript'> alert('La comison senior en dolares deber ser un numero');</script>")
            Me.txtSeniorDolares.Focus()
            Return False
        ElseIf txtMasterColones.Text.Equals("") Then
            Response.Write("<script language='javascript' type='text/javascript'> alert('La comision master en colones es un dato requerido');</script>")
            Me.txtMasterColones.Focus()
        ElseIf Not IsNumeric(txtMasterColones.Text) Then
            Response.Write("<script language='javascript' type='text/javascript'> alert('La comison master en colones deber ser un numero');</script>")
            Me.txtMasterColones.Focus()
            Return False
        ElseIf txtMasterDolares.Text.Equals("") Then
            Response.Write("<script language='javascript' type='text/javascript'> alert('La comision master en dolares es un dato requerido');</script>")
            Me.txtMasterDolares.Focus()
            Return False
        ElseIf Not IsNumeric(txtMasterDolares.Text) Then
            Response.Write("<script language='javascript' type='text/javascript'> alert('La comison master en dolares deber ser un numero');</script>")
            Me.txtMasterDolares.Focus()
            Return False
        Else
            Return True
        End If
    End Function

    ''' <summary>
    ''' Método de clase, encarga de limpiar los componentes 
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub limpiar()
        With Me
            .txtCodigo.Text = ""
            .txtNombre.Text = ""
            .txtDescripcion.Text = ""
            .txtPrecioColones.Text = ""
            .txtPrecioDolares.Text = ""
            .txtJuniorColones.Text = ""
            .txtJuniorColones.Text = ""
            .txtSeniorColones.Text = ""
            .txtSeniorDolares.Text = ""
            .txtMasterColones.Text = ""
            .txtMasterDolares.Text = ""

        End With

    End Sub

    Protected Sub bntLimpiar_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles bntLimpiar.Click
        limpiar()
    End Sub

End Class