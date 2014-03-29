Imports CllLogicaNegocio.ClsGestor
Imports System.Text.RegularExpressions

Public Class ctlRegistrarUsuario

    'Dim _formularioBuscar As New frmBuscar() 'Constructor
    Dim _gestor As New CllLogicaNegocio.ClsGestor() 'declara e instancia de la clase Gestor
    'declarar variable globales tipo boolean
    Dim _resul As Boolean
    Dim _numero As Boolean
    'declarar variables globales 
    Dim _criterio As String
    Dim _ced As String
    Dim _nombre As String
    Dim _apellido1 As String
    Dim _apellido2 As String
    Dim _correo As String
    Dim _contrasenna As String
    Dim _rol As String
    Dim _departamento As String
    Private _frmSiscove As frmSiscove

    Public Sub New(ByVal pfrmSiscove As frmSiscove)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _frmSiscove = pfrmSiscove
    End Sub

    Private Function evaluarNumeric(ByVal texto As String) As Boolean

        _numero = IsNumeric(texto)
        Return _numero
    End Function

    ''' <summary>
    ''' Método de clase, encarga de evaluar que no queden espacios en blanco ningun componente
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function evaluarEspacion() As Boolean
        Dim _resul = False
        Dim emailExpression As New Regex("^([\w-]+\.)*?[\w-]+@[\w-]+\.([\w-]+\.)*?[\w]+$")

        If Me.txtCed.Text = "" Then
            MsgBox("El número de cédula del usuario es un dato requerido.", MsgBoxStyle.Information, "Registrar Usuario")
            Me.txtCed.Focus()
        ElseIf Me.evaluarNumeric(txtCed.Text) = False Then
            MsgBox("El campo de la cédula debe contener únicanente campos numéricos.", MsgBoxStyle.Information, "Registrar Usuario")
            Me.txtCed.Focus()
        ElseIf Me.txtNombre.Text = "" Then
            MsgBox("El nombre del usuario es un dato requerido.", MsgBoxStyle.Information, "Registrar Usuario")
            Me.txtNombre.Focus()

        ElseIf Me.txtApellido1.Text = "" Then
            MsgBox("El primer apellido del usuario es un dato requerido.", MsgBoxStyle.Information, "Registrar Usuario")
            Me.txtApellido1.Focus()

        ElseIf Me.txtApellido2.Text = "" Then
            MsgBox("El segundo apellido del usuario es un dato requerido.", MsgBoxStyle.Information, "Registrar Usuario")
            Me.txtApellido2.Focus()

        ElseIf Me.txtCorreo.Text = "" Then
            MsgBox("El correo electrónico del usuario es un dato requerido.", MsgBoxStyle.Information, "Registrar Usuario")
            Me.txtCorreo.Focus()

        ElseIf Not emailExpression.IsMatch(txtCorreo.Text) Then
            MsgBox("El correo electrónico se encuentra en un formato incorrecto.", MsgBoxStyle.Information, "Registrar Usuario")
            Me.txtCorreo.Focus()

        ElseIf Me.txtContrasenna.Text = "" Then
            MsgBox("La contraseña del usuario es un dato requerido.", MsgBoxStyle.Information, "Registrar Usuario")
            Me.txtContrasenna.Focus()
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
            .txtCed.Text = ""
            .txtNombre.Text = ""
            .txtApellido1.Text = ""
            .txtApellido2.Text = ""
            .txtCorreo.Text = ""
            .txtContrasenna.Text = ""
            .cbxDepartamento.SelectedIndex = 0
            .cbxRol.SelectedIndex = 0
        End With

    End Sub

    Private Sub bntCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MsgBox("Se ha cancelado el registro de los datos y el usuario no fue registrado.", MsgBoxStyle.Information, "Registrar Usuario")

    End Sub

    Private Sub pbReg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbReg.Click
        _resul = evaluarEspacion()
        _numero = False
        Dim num As Integer

        num = CInt(cbxDepartamento.SelectedIndex.ToString)
        num = num + 1

        If _resul = True Then

            'asignar a cada variable los valores indicados
            _ced = Me.txtCed.Text
            _nombre = Me.txtNombre.Text
            _apellido1 = Me.txtApellido1.Text
            _apellido2 = Me.txtApellido2.Text
            _correo = Me.txtCorreo.Text
            _contrasenna = Me.txtContrasenna.Text
            _rol = Me.cbxRol.Text
            _departamento = System.Convert.ToString(num)

            Try

                _gestor.registrarUsuario(_ced, _nombre, _apellido1, _apellido2, _correo, _contrasenna, _rol, _departamento) 'invocar el método indicado enviando los argumentos requeridos.
                MsgBox("Los datos del usuario se ha registrado correctamente.", MsgBoxStyle.Information, "Registrar Usuario")
                
                Me.limpiarForm() 'invocar a la subrutina dedicada a limpiar los controles indicados.

            Catch ex As Exception
                MsgBox("Los datos ingresados ya existen en la base de datos.", MsgBoxStyle.Information, "Registrar Usuario")
            End Try

        End If

    End Sub

    Private Sub pbLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbLimpiar.Click
        limpiarForm()
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint
        Dim tempComboRol As List(Of Array)
        Dim tempComboDep As List(Of Array)

        Try
            cbxDepartamento.Items.Clear()
            cbxRol.Items.Clear()
            tempComboRol = _gestor.listarRol()
            tempComboDep = _gestor.listarDepartamento()

            For i As Integer = 0 To tempComboDep.Count - 1
                cbxDepartamento.Items.Add(tempComboDep(i).GetValue(1).ToString)
            Next

            For i As Integer = 0 To tempComboRol.Count - 1
                cbxRol.Items.Add(tempComboRol(i).GetValue(0).ToString)
            Next

            With Me
                .cbxDepartamento.SelectedIndex = 0
                .cbxRol.SelectedIndex = 0
            End With
        Catch ex As Exception

        End Try

    End Sub

End Class
