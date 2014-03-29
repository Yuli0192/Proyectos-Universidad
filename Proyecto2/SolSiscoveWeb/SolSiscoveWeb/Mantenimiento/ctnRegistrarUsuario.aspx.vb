Imports CllLogicaNegocio.ClsGestor

Partial Public Class ctnRegistrarUsuario
    Inherits System.Web.UI.Page

    Private _gestor As New CllLogicaNegocio.ClsGestor()
    Dim emailExpression As New Regex("^([\w-]+\.)*?[\w-]+@[\w-]+\.([\w-]+\.)*?[\w]+$")

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim tempComboRol As List(Of Array)
        Dim tempComboDep As List(Of Array)

        dlbDepartamento.Items.Clear()
        dlbRol.Items.Clear()

        Try
            tempComboRol = _gestor.listarRol()
            tempComboDep = _gestor.listarDepartamento()

            For i As Integer = 0 To tempComboDep.Count - 1
                dlbDepartamento.Items.Add(tempComboDep(i).GetValue(1).ToString)
            Next

            For i As Integer = 0 To tempComboRol.Count - 1
                dlbRol.Items.Add(tempComboRol(i).GetValue(0).ToString)
            Next

            With Me
                .dlbDepartamento.SelectedIndex = 0
                .dlbRol.SelectedIndex = 0
            End With
        Catch ex As Exception

        End Try
    End Sub


    Private Function evaluarNumeric(ByVal texto As String) As Boolean
        Dim _numero As Integer

        _numero = IsNumeric(texto)
        Return _numero
    End Function

    Protected Sub bntLimpiar_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles bntLimpiar.Click
        limpiarForm()
    End Sub

    Public Sub limpiarForm()
        With Me
            .txtCedula.Text = ""
            .txtNombre.Text = ""
            .txtApellido1.Text = ""
            .txtApellido2.Text = ""
            .txtCorreo.Text = ""
            .txtContrasenna.Text = ""
            .dlbRol.SelectedIndex = 0
            .dlbDepartamento.SelectedIndex = 0
        End With
    End Sub

    Public Function validarEspacios() As Boolean
        Dim result As Boolean = False

        If txtCedula.Text = "" Then
            MsgBox("La cédula del usuario es un dato requerido", MsgBoxStyle.Information, "Registrar Usuario")
            txtCedula.Focus()
        ElseIf Not evaluarNumeric(txtCedula.Text) Then
            MsgBox("La cédula solo debe contener caracteres numéricos", MsgBoxStyle.Information, "Registrar Usuario")
            txtCedula.Focus()
        ElseIf txtNombre.Text = "" Then
            MsgBox("El nombre del usuario es un dato requerido", MsgBoxStyle.Information, "Registrar Usuario")
            txtNombre.Focus()
        ElseIf txtApellido1.Text = "" Then
            MsgBox("El primer apellido del usuario es un dato requerido", MsgBoxStyle.Information, "Registrar Usuario")
            txtApellido1.Focus()
        ElseIf txtApellido2.Text = "" Then
            MsgBox("El segundo apellido del usuario es un dato requerido", MsgBoxStyle.Information, "Registrar Usuario")
            txtApellido2.Focus()
        ElseIf txtCorreo.Text = "" Then
            MsgBox("El correo electrónico del usuario es un dato requerido", MsgBoxStyle.Information, "Registrar Usuario")
            txtCorreo.Focus()
        ElseIf Not emailExpression.IsMatch(txtCorreo.Text) Then
            MsgBox("El correo electrónico se encuentra en un formato incorrecto", MsgBoxStyle.Information, "Registrar Usuario")
            txtCorreo.Focus()
        ElseIf txtContrasenna.Text = "" Then
            MsgBox("La contraseña es un dato requerido", MsgBoxStyle.Information, "Registrar Usuario")
            txtContrasenna.Focus()
        Else
            Return True
        End If
    End Function

    Protected Sub bntRegistrar_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles bntRegistrar.Click
        If validarEspacios() Then
            Try
                _gestor.registrarUsuario(txtCedula.Text, txtNombre.Text, txtApellido1.Text, txtApellido2.Text, txtCorreo.Text, txtContrasenna.Text, dlbRol.SelectedItem.ToString, System.Convert.ToString(CInt(dlbDepartamento.SelectedIndex.ToString) + 1))
                MsgBox("El usuario se ha registrado correctamente")
                limpiarForm()
            Catch ex As Exception
                MsgBox("Los datos ingresados ya existen" & ex.Message, MsgBoxStyle.Information, "Registrar Usuario")
            End Try
        End If
    End Sub
End Class