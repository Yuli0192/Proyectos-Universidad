Public Partial Class ctnBuscarUsuario
    Inherits System.Web.UI.Page

    Dim _gestor As New CllLogicaNegocio.ClsGestor() 'declaración e instanciación de la clase Gestor
    'declarar una variable tipo lista genérica de Array
    Dim _resul As Boolean
    Dim _listaUsuario As List(Of Array) = New List(Of Array)()
    Dim _tempArray As Array 'declarar una variable tipo Array
    Dim _criterio As String
    Dim _ced As String
    Dim _nombre As String
    Dim _apellido1 As String
    Dim _apellido2 As String
    Dim _correo As String
    Dim _contrasenna As String
    Dim _rol As String
    Dim _departamento As String

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        llenarUsuarios()
        txtCriterio.Focus()
        deshabilitarForm()
    End Sub

    Private Sub evaluar()

        If rbtIdentificacion.Checked Then
            _criterio = "Identificador"
        Else
            _criterio = "Nombre"
        End If

    End Sub

    Private Sub llenarUsuarios()
        Dim _tempCast() As String 'declarar una variable tipo arreglo de String
        Dim _listTemp As New List(Of ClsCastCadenaUsuario) 'declarar una variable tipo lista genérica tipo clsCastCadena (Wrapper)

        Try
            _listaUsuario = _gestor.listarUsuarios()

            For i As Integer = 0 To _listaUsuario.Count - 1
                _tempArray = _listaUsuario(i)
                ReDim _tempCast(_tempArray.Length - 1)
                For j As Integer = 0 To _tempArray.Length - 1 'recorrer la parte interna de la matriz, columna (COLUMN)
                    _tempCast(j) = _tempArray.GetValue(j).ToString() 'asignar el valor de cada celda 
                Next
                _listTemp.Add(New ClsCastCadenaUsuario(_tempCast(0).ToString(), _tempCast(1).ToString(), _tempCast(2).ToString(), _tempCast(3).ToString(), _tempCast(4).ToString(), _tempCast(5).ToString(), _tempCast(6).ToString()))
            Next
            Me.gridListaUsuarios.DataSource = _listTemp
            gridListaUsuarios.DataBind()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Protected Sub rbtIdentificacion_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles rbtIdentificacion.CheckedChanged
        Me.llenarUsuarios()
    End Sub

    Public Sub limpiarGrid()
        gridListaUsuarios.Items.Clear()
    End Sub

    Private Sub buscarUsuarioCod(ByVal pcod As String)
        Dim _listTemp As New List(Of ClsCastCadenaUsuario) 'declarar una variable tipo lista genérica tipo clsCastCadena (Wrapper)
        Dim _tempCast() As String 'declarar una variable tipo arreglo de String

        Try
            _listaUsuario = _gestor.buscarUsuarioId(pcod)
            gridListaUsuarios.Items.Clear()

            'estructura iterativa tipo matriz para recorrer y envolver por el tipo adecuado
            For i As Integer = 0 To _listaUsuario.Count - 1
                'clonar a un Array temporal la FILA (ROW) de la consulta
                _tempArray = _listaUsuario(i)

                'redimensionar el arreglo a un tamaño indicado
                ReDim _tempCast(_tempArray.Length() - 1)

                'recorrer la parte interna de la matriz, columna (COLUMN)
                For j As Integer = 0 To _tempArray.Length - 1
                    'asignar el valor de cada celda 
                    _tempCast(j) = _tempArray.GetValue(j).ToString()
                Next

                _listTemp.Add(New ClsCastCadenaUsuario(_tempCast(0).ToString(), _tempCast(1).ToString(), _tempCast(2).ToString(), _tempCast(3).ToString(), _tempCast(4).ToString(), _tempCast(5).ToString(), _tempCast(6).ToString()))
            Next

            gridListaUsuarios.DataSource = _listTemp
            gridListaUsuarios.DataBind()
        Catch ex As Exception
            MsgBox("Error en la operación ... " & ex.Message)
        End Try
    End Sub

    Private Sub buscarUsuarioNombre(ByVal pnombre As String)
        Dim _listTemp As New List(Of ClsCastCadenaUsuario) 'declarar una variable tipo lista genérica tipo clsCastCadena (Wrapper)
        Dim _tempCast() As String 'declarar una variable tipo arreglo de String

        Try

            'asignar el resultado de la búsqueda devuelto por un método del Gestor
            _listaUsuario = _gestor.buscarUsuarioPorNombre(pnombre)

            gridListaUsuarios.Items.Clear()

            'estructura iterativa tipo matriz para recorrer y envolver por el tipo adecuado
            For i As Integer = 0 To _listaUsuario.Count - 1
                'clonar a un Array temporal la FILA (ROW) de la consulta
                _tempArray = _listaUsuario(i)

                'redimensionar el arreglo a un tamaño indicado
                ReDim _tempCast(_tempArray.Length() - 1)

                'recorrer la parte interna de la matriz, columna (COLUMN)
                For j As Integer = 0 To _tempArray.Length - 1
                    'asignar el valor de cada celda 
                    _tempCast(j) = _tempArray.GetValue(j).ToString()
                Next
                _listTemp.Add(New ClsCastCadenaUsuario(_tempCast(0).ToString(), _tempCast(1).ToString(), _tempCast(2).ToString(), _tempCast(3).ToString(), _tempCast(4).ToString(), _tempCast(5).ToString(), _tempCast(6).ToString()))
            Next
            gridListaUsuarios.DataSource = _listTemp
            gridListaUsuarios.DataBind()
        Catch ex As Exception
            MsgBox("Error en la operación ... " & ex.Message)
        End Try

    End Sub

    Protected Sub btnBuscar_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btnBuscar.Click
        evaluar()
        deshabilitarForm()
        If txtCriterio.Text = "" Then
            MsgBox("Ingrese el criterio de búsqueda", MsgBoxStyle.Information, "Aviso")
        Else
            If _criterio = "Identificador" Then
                buscarUsuarioCod(txtCriterio.Text)
            Else
                buscarUsuarioNombre(txtCriterio.Text)
            End If
        End If
    End Sub

    Protected Sub rbtNombre_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles rbtNombre.CheckedChanged
        Me.llenarUsuarios()
    End Sub

    Protected Sub btnEliminar_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btnEliminar.Click
        _ced = Me.gridListaUsuarios.Items(gridListaUsuarios.SelectedItemIndex).Cells("cedula").Value
        Dim _result As MsgBoxResult
        Dim objGestor As CllLogicaNegocio.ClsGestor

        objGestor = New CllLogicaNegocio.ClsGestor()
        _result = MsgBox("¿Desea eliminar el usuario?", MsgBoxStyle.YesNo)
        Try
            If _result = MsgBoxResult.Yes Then
                'invocar el método indicado enviando los argumentos requeridos.
                objGestor.eliminarUsuario(_ced)

                evaluar()
                llenarUsuarios()
                txtCriterio.Text = ""
                txtCriterio.Focus()
                MsgBox("El usuario fue eliminado exitosamente.")
            Else
                MsgBox("El usuario no fue eliminado.")
            End If
        Catch ex As Exception
            MsgBox("El usuario no se pudo eliminar.")
        End Try
    End Sub

    Protected Sub btnLlenarModificar_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btnLlenarModificar.Click
        If gridListaUsuarios.SelectedItemIndex >= 0 Then
            Dim id As String = gridListaUsuarios.Items(gridListaUsuarios.SelectedItemIndex).Cells("cedula").Value
            llenarCamporModificar(id)
            habilitarForm()
        Else
            MsgBox("No se ha seleccionado ningún usuario")
        End If
    End Sub

    Public Sub llenarCamporModificar(ByVal pid As String)
        Try
            Dim tempComboDep As List(Of Array)
            Dim tempComboRol As List(Of Array)
            Dim eval As Boolean = False

            tempComboRol = _gestor.listarRol()

            ddlDepartamento.Items.Clear()
            ddlRol.Items.Clear()

            tempComboDep = _gestor.listarDepartamento()
            _listaUsuario = _gestor.buscarUsuarioId(pid)

            _tempArray = _listaUsuario(0)

            For i As Integer = 0 To tempComboDep.Count - 1
                ddlDepartamento.Items.Add(tempComboDep(i).GetValue(1).ToString)
            Next

            For i As Integer = 0 To tempComboRol.Count - 1
                ddlRol.Items.Add(tempComboRol(i).GetValue(0).ToString)
            Next

            With Me
                .txtCedula.Text = _tempArray.GetValue(0).ToString
                .txtNombre.Text = _tempArray.GetValue(1).ToString
                .txtApellido1.Text = _tempArray.GetValue(2).ToString
                .txtApellido2.Text = _tempArray.GetValue(3).ToString
                .txtCorreo.Text = _tempArray.GetValue(4).ToString
                If _tempArray.GetValue(5).ToString = "Gerente Ventas" Then
                    .ddlRol.Items.Add("Gerente Ventas")
                    .ddlRol.SelectedValue = "Gerente Ventas"
                    eval = True
                End If
                If _tempArray.GetValue(5).ToString = "Gerente General" Then
                    .ddlRol.Items.Add("Gerente General")
                    .ddlRol.SelectedValue = "Gerente General"
                    eval = True
                End If
                If eval = False Then
                    .ddlRol.SelectedValue = _tempArray.GetValue(5).ToString
                End If
                .ddlDepartamento.SelectedValue = _tempArray.GetValue(7).ToString
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Protected Sub btnModificar_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btnModificar.Click
        _resul = evaluarEspacios()
        Dim num As Integer

        num = CInt(ddlDepartamento.SelectedIndex.ToString)
        num = num + 1

        If _resul = True Then

            Dim _result As MsgBoxResult

            'asignar a cada variable los valores indicados
            _ced = txtCedula.Text
            _nombre = txtNombre.Text
            _apellido1 = txtApellido1.Text
            _apellido2 = txtApellido2.Text
            _correo = txtCorreo.Text
            _rol = ddlRol.SelectedItem.ToString
            _departamento = System.Convert.ToString(num)

            _result = MsgBox("¿Desesa modificar los datos  del usuario?", MsgBoxStyle.YesNo)

            Try
                If _result = MsgBoxResult.Yes Then
                    _gestor.modificarUsuario(_ced, _nombre, _apellido1, _apellido2, _correo, _rol, _departamento) 'invocar el método indicado enviando los argumentos requeridos.
                    MsgBox("Los datos del usuario fueron  modificados.")
                    deshabilitarForm()
                    limpiarTabla()

                Else
                    MsgBox("Los datos del usuario no fueron modificados.")
                End If

            Catch ex As Exception
                MsgBox("Los datos ingresados ya existen en la base de datos.")
            End Try
        End If

    End Sub

    Private Sub deshabilitarForm()
        With Me
            .txtCedula.Visible = False
            .txtNombre.Visible = False
            .txtApellido1.Visible = False
            .txtApellido2.Visible = False
            .txtCorreo.Visible = False
            .ddlDepartamento.Visible = False
            .ddlRol.Visible = False
            .btnModificar.Visible = False
            .lblApellido1.Visible = False
            .lblApellido2.Visible = False
            .lblCedula.Visible = False
            .lblCorreo.Visible = False
            .lblNombre.Visible = False
            .lblDepartamento.Visible = False
            .lblRol.Visible = False
            .lblTituloModificar.Visible = False
        End With
    End Sub

    Private Sub habilitarForm()
        With Me
            .txtCedula.Visible = True
            .txtNombre.Visible = True
            .txtApellido1.Visible = True
            .txtApellido2.Visible = True
            .txtCorreo.Visible = True
            .ddlDepartamento.Visible = True
            .ddlRol.Visible = True
            .btnModificar.Visible = True
            .lblApellido1.Visible = True
            .lblApellido2.Visible = True
            .lblCedula.Visible = True
            .lblCorreo.Visible = True
            .lblNombre.Visible = True
            .lblDepartamento.Visible = True
            .lblRol.Visible = True
            .lblTituloModificar.Visible = True
        End With
    End Sub

    Private Function evaluarEspacios() As Boolean
        Dim _resul = False
        Dim emailExpression As New Regex("^([\w-]+\.)*?[\w-]+@[\w-]+\.([\w-]+\.)*?[\w]+$")

        If Me.txtCedula.Text = "" Then
            MsgBox("La cédula del usuario es un dato requerido")
            Me.txtCedula.Focus()

        ElseIf Me.txtNombre.Text = "" Then
            MsgBox("El nombre del usuario es un dato requerido")
            Me.txtNombre.Focus()

        ElseIf Me.txtApellido1.Text = "" Then
            MsgBox("El primer apellido del usuario es un dato requerido")
            Me.txtApellido1.Focus()

        ElseIf Me.txtApellido2.Text = "" Then
            MsgBox("El segundo apellido del usuario es un dato requerido")
            Me.txtApellido2.Focus()

        ElseIf Me.txtCorreo.Text = "" Then
            MsgBox("El correo electrónico del usuario es un dato requerido")
            Me.txtCorreo.Focus()

        ElseIf Not emailExpression.IsMatch(txtCorreo.Text) Then
            MsgBox("El correo electrónico se encuentra en un formato incorrecto")
            Me.txtCorreo.Focus()

        Else
            _resul = True

        End If

        Return _resul
    End Function

    Private Sub limpiarTabla()

        Me.txtCriterio.Text = ""
        Me.txtCriterio.Focus()
        Me.llenarUsuarios()

    End Sub

End Class