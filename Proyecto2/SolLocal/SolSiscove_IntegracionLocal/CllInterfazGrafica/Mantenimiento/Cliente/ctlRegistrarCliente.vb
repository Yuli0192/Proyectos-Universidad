Imports CllLogicaNegocio.ClsGestor
Imports System.Text.RegularExpressions
Public Class ctlRegistrarCliente

    Dim _gestor As New CllLogicaNegocio.ClsGestor() 'declara e instancia de la clase Gestor
    'declarar variable globales tipo boolean
    Dim _resul As Boolean
    Private emailExpression As New Regex("^[_a-z0-9-]+(.[a-z0-9-]+)@[a-z0-9-]+(.[a-z0-9-]+)*(.[a-z]{2,4})$")

    Private Sub ctlRegistrarCliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.txtId.Focus()
    End Sub

    ''' <summary>
    ''' Método de clase, encarga de evaluar que no queden espacios en blanco ningún componente
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function evaluarEspacion() As Boolean
        Dim _resul = False
        If Me.txtId.Text = "" Then
            MsgBox("El identificador del cliente es un dato requerido.", MsgBoxStyle.Information, "Registrar Cliente")
            Me.txtId.Focus()

        ElseIf Me.txtNombre.Text = "" Then
            MsgBox("El nombre del cliente es un dato requerido.", MsgBoxStyle.Information, "Registrar Cliente")
            Me.txtNombre.Focus()

        ElseIf Me.txtTelefono.Text = "    -" Then
            MsgBox("El teléfono del cliente es un dato requerido.", MsgBoxStyle.Information, "Registrar Cliente")
            Me.txtTelefono.Focus()

        ElseIf Me.txtCorreo.Text = "" Then
            MsgBox("El correo del cliente es un dato requerido.", MsgBoxStyle.Information, "Registrar Cliente")
            Me.txtCorreo.Focus()

        ElseIf Not emailExpression.IsMatch(txtCorreo.Text) Then
            MsgBox("El formato del correo electrónico es incorrecto.", MsgBoxStyle.Information, "Registrar Cliente")
            txtCorreo.SelectAll()

        ElseIf Me.txtDireccion.Text = "" Then
            MsgBox("La dirección del cliente es un dato requerido.", MsgBoxStyle.Information, "Registrar Cliente")
            Me.txtDireccion.Focus()

        Else
            _resul = True

        End If

        Return _resul
    End Function

    ''' <summary>
    ''' Método de clase, encarga de limpiar los componentes 
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub limpiarForm()
        With Me
            .txtId.Text = ""
            .txtNombre.Text = ""
            .txtTelefono.Text = ""
            .txtCorreo.Text = ""
            .txtContacto.Text = ""
            .txtDireccion.Text = ""
        End With

    End Sub

    ''' <summary>
    ''' Método, se encarga de llamar al método limpiar formulario
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub pbLimpiar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbLimpiar.Click
        limpiarForm()
    End Sub

    ''' <summary>
    ''' Método de clase, encargado de registrar los datos del cliente 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub pbRegistrar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbRegistrar.Click
        'declarar variables tipo String
        Dim _idCliente As String
        Dim _nombre As String
        Dim _telefono As String
        Dim _correoCliente As String
        Dim _contacto As String
        Dim _direccion As String
        Dim _numero As Boolean
        _resul = evaluarEspacion()
        _numero = False
        If _resul = True Then

            'asignar a cada variable los valores indicados
            _idCliente = Me.txtId.Text
            _nombre = Me.txtNombre.Text
            _telefono = Me.txtTelefono.Text
            _correoCliente = Me.txtCorreo.Text
            _contacto = Me.txtContacto.Text
            _direccion = Me.txtDireccion.Text
            Try
                _gestor.registrarCliente(_idCliente, _nombre, _telefono, _correoCliente, _contacto, _direccion) 'invocar el método indicado enviando los argumentos requeridos.
                _gestor.asignarCliente(_idCliente, DATOS_USUARIO(3))
                MsgBox("Los datos del cliente se ha registrado correctamente.", MsgBoxStyle.Information, "Registrar Cliente")
                Me.limpiarForm() 'invocar a la subrutina dedicada a limpiar los controles indicados.

            Catch ex As Exception
                MsgBox("Los datos ingresados ya existen en la base de datos." & ex.Message, MsgBoxStyle.Information, "Registrar Cliente")
            End Try
        End If
    End Sub

    Private Sub txtDireccion_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDireccion.TextChanged
        If Me.txtContacto.Text = "" Then
            Me.txtContacto.Text = Me.txtNombre.Text 'Si deja este campo vacio se le asigna el nombre del cliente
        End If
    End Sub
End Class
