Imports CllLogicaNegocio.ClsGestor
Partial Public Class frmRegistrarCliente
    Inherits System.Web.UI.Page
    Dim _gestor As New CllLogicaNegocio.ClsGestor
    Dim emailExpression As New Regex("^[_a-z0-9-]+(.[a-z0-9-]+)@[a-z0-9-]+(.[a-z0-9-]+)*(.[a-z]{2,4})$")
    'Dim telefonoExpression As New Regex("/^2{1}(2|4|5|6|7){1}\d{2}\-?\d{4}$/")

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub
    Protected Sub bntRegistrar_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles bntRegistrar.Click
        If validarDatos() Then
            Try
                _gestor.registrarCliente(txtId.Text, txtNombre.Text, txtTelefono.Text, txtCorreo.Text, txtContacto.Text, txtDireccion.Text)
                MsgBox("El cliente se ha registrado correctamente.", MsgBoxStyle.Information, "Registrar Cliente")
                limpiar()
            Catch ex As Exception
                MsgBox("Los datos ingresados ya existen en la base de datos." & ex.Message, MsgBoxStyle.Information, "Registrar Cliente")
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
        Dim resul As Boolean = False
        If txtId.Text.Equals("") Then
            MsgBox("El identificador del cliente es un dato requerido", MsgBoxStyle.Information, "Registrar Cliente")
            Me.txtId.Focus()
        ElseIf txtNombre.Text.Equals("") Then
            MsgBox("El nombre del cliente es un dato requerido", MsgBoxStyle.Information, "Registrar Cliente")
            Me.txtNombre.Focus()
        ElseIf txtTelefono.Text.Equals("") Then
            MsgBox("El teléfono del cliente es un dato requerido", MsgBoxStyle.Information, "Registrar Cliente")
            Me.txtTelefono.Focus()
            'ElseIf Not telefonoExpression.IsMatch(txtTelefono.Text) Then
            '    MsgBox("El formato del telefono es incorrecto", MsgBoxStyle.Information, "Registrar Cliente")
        ElseIf txtCorreo.Text.Equals("") Then
            MsgBox("El correo del cliente es un dato requerido", MsgBoxStyle.Information, "Registrar Cliente")
            Me.txtCorreo.Focus()
        ElseIf Not emailExpression.IsMatch(txtCorreo.Text) Then
            MsgBox("El formato del correo electrónico es incorrecto", MsgBoxStyle.Information, "Registrar Cliente")
        ElseIf txtContacto.Text.Equals("") Then
            MsgBox("El correo del cliente es un dato requerido", MsgBoxStyle.Information, "Registrar Cliente")
            Me.txtCorreo.Focus()
        ElseIf txtDireccion.Text.Equals("") Then
            MsgBox("La dirección del cliente es un dato requerido", MsgBoxStyle.Information, "Registrar Cliente")
            Me.txtDireccion.Focus()
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
            .txtId.Text = ""
            .txtNombre.Text = ""
            .txtTelefono.Text = ""
            .txtCorreo.Text = ""
            .txtContacto.Text = ""
            .txtDireccion.Text = ""
        End With

    End Sub

    Protected Sub txtDireccion_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtDireccion.TextChanged
        If Me.txtContacto.Text = "" Then
            Me.txtContacto.Text = Me.txtNombre.Text 'Si deja este campo vacio se le asigna el nombre del cliente
        End If
    End Sub

    Protected Sub bntLimpiar_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles bntLimpiar.Click
        limpiar()
    End Sub
End Class