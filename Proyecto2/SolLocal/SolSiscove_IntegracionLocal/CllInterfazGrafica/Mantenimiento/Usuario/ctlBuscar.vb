Imports CllLogicaNegocio.ClsGestor

Public Class ctlBuscar

    Dim _gestor As New CllLogicaNegocio.ClsGestor() 'declaración e instanciación de la clase Gestor
    'declarar una variable tipo lista genérica de Array
    Dim _listaUsuario As List(Of Array) = New List(Of Array)()
    'declarar una variable tipo Array
    Dim _tempArray As Array
    'declarar una variable tipo lista genérica tipo clsCastCadena (Wrapper)
    Dim _cadena As ClsCastCadenaUsuario
    'declarar una variable tipo arreglo de String
    Dim _tempCast() As String
    'declarar variable globales tipo boolean
    Dim _resul As Boolean
    Dim _result As DialogResult
    'declarar variables globales 
    Dim _numero As Boolean
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

    Public Sub llenarCamposModificar(ByVal pid As String)
        Try
            Dim tempComboDep As List(Of Array)
            Dim tempComboRol As List(Of Array)
            Dim gg As Boolean = False

            tempComboRol = _gestor.listarRol()

            cbxDepartamento.Items.Clear()
            cbxRol.Items.Clear()

            tempComboDep = _gestor.listarDepartamento()
            _listaUsuario = _gestor.buscarUsuarioId(pid)

            _tempArray = _listaUsuario(0)

            For i As Integer = 0 To tempComboDep.Count - 1
                cbxDepartamento.Items.Add(tempComboDep(i).GetValue(1).ToString)
            Next

            For i As Integer = 0 To tempComboRol.Count - 1
                cbxRol.Items.Add(tempComboRol(i).GetValue(0).ToString)
            Next

            With Me
                .txtCod.Text = _tempArray.GetValue(0).ToString
                .txtNombre.Text = _tempArray.GetValue(1).ToString
                .txtApellido1.Text = _tempArray.GetValue(2).ToString
                .txtApellido2.Text = _tempArray.GetValue(3).ToString
                .txtCorreo.Text = _tempArray.GetValue(4).ToString
                If _tempArray.GetValue(5).ToString = "Gerente Ventas" Then
                    .cbxRol.Items.Add("Gerente Ventas")
                    .cbxRol.SelectedItem = "Gerente Ventas"
                    gg = True
                End If
                If _tempArray.GetValue(5).ToString = "Gerente General" Then
                    .cbxRol.Items.Add("Gerente General")
                    .cbxRol.SelectedItem = "Gerente General"
                    gg = True
                End If
                If gg = False Then
                    .cbxRol.SelectedItem = _tempArray.GetValue(5).ToString
                End If
                .cbxDepartamento.SelectedItem = _tempArray.GetValue(7).ToString
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    ''' <summary>
    ''' Método de clase, encarga de evaluar que no queden espacios en blanco ningun componente
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function evaluarEspacios() As Boolean
        Dim _resul = False

        If Me.txtCod.Text = "" Then
            MsgBox("La cédula del usuario es un dato requerido", MsgBoxStyle.Information, "Modificar Usuario")

            Me.txtCod.Focus()

        ElseIf Me.txtNombre.Text = "" Then
            MsgBox("El nombre del usuario es un dato requerido", MsgBoxStyle.Information, "Modificar Usuario")

            Me.txtNombre.Focus()

        ElseIf Me.txtApellido1.Text = "" Then
            MsgBox("El primer apellido del usuario es un dato requerido", MsgBoxStyle.Information, "Modificar Usuario")

            Me.txtApellido1.Focus()

        ElseIf Me.txtApellido2.Text = "" Then
            MsgBox("El segundo apellido del usuario es un dato requerido", MsgBoxStyle.Information, "Modificar Usuario")
            Me.txtApellido2.Focus()

        ElseIf Me.txtCorreo.Text = "" Then
            MsgBox("El correo electrónico del usuario es un dato requerido", MsgBoxStyle.Information, "Modificar Usuario")
            Me.txtCorreo.Focus()

        Else
            _resul = True

        End If

        Return _resul
    End Function

    Private Sub limpiarTabla()

        Me.txtCriterio.Text = ""
        Me.txtCriterio.Focus()
        Me.listarUsuarios()

    End Sub

    ''' <summary>
    ''' Método de clase, encarga de limpiar los componentes 
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub limpiarForm()
        With Me
            .txtCod.Text = ""
            .txtNombre.Text = ""
            .txtApellido1.Text = ""
            .txtApellido2.Text = ""
            .txtCorreo.Text = ""
            .cbxDepartamento.Items.Clear()
            .cbxRol.Items.Clear()
            .cbxRol.Text = ""
            .cbxDepartamento.Text = ""
        End With

    End Sub

    Private Sub ctlBuscar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.listarUsuarios()
        Me.txtCriterio.Focus()
        Me.gbModificarUsuario.Visible = False
        Me.rdbId.Checked = True
    End Sub

    Private Sub rdbId_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbId.CheckedChanged
        limpiarTabla()
        Me.txtCriterio.Focus()
    End Sub

    Private Sub evaluar()

        If rdbId.Checked Then
            _criterio = "Identificador"
        Else
            _criterio = "Nombre"
        End If

    End Sub

    Private Sub listarUsuarios()

        Try
            _listaUsuario = _gestor.listarUsuarios()

            Me.txtCriterio.Focus()
            'asignar el resultado de la búsqueda devuelto por un método del Gestor

            Me.dvgUsuario.Rows.Clear()

            Dim _tempCast() As String 'declarar una variable tipo arreglo de String

            'estructura iterativa tipo matriz para recorrer y envolver por el tipo adecuado
            For i As Integer = 0 To _listaUsuario.Count - 1
                'clonar a un Array temporal la FILA (ROW) de la consulta
                _tempArray = _listaUsuario(i)


                ReDim _tempCast(_tempArray(0).Length() - 1) 'redimensionar el arreglo a un tamaño indicado

                'recorrer la parte interna de la matriz, columna (COLUMN)
                For j As Integer = 0 To _tempArray.Length - 1
                    'asignar el valor de cada celda 
                    _tempCast(j) = _tempArray.GetValue(j).ToString()
                Next

                'agregar a la lista genérica una colección de la clase wrapper
                _cadena = New ClsCastCadenaUsuario(_tempCast(0).ToString(), _tempCast(1).ToString(), _tempCast(2).ToString(), _tempCast(3).ToString(), _tempCast(4).ToString(), _tempCast(5).ToString(), _tempCast(6).ToString())

                dvgUsuario.Rows.Add()
                dvgUsuario.Rows.Item(dvgUsuario.Rows.Count - 1).Cells.Item(0).Value = _cadena.cedula
                dvgUsuario.Rows.Item(dvgUsuario.Rows.Count - 1).Cells.Item(1).Value = _cadena.nombre
                dvgUsuario.Rows.Item(dvgUsuario.Rows.Count - 1).Cells.Item(2).Value = _cadena.apellido1
                dvgUsuario.Rows.Item(dvgUsuario.Rows.Count - 1).Cells.Item(3).Value = _cadena.apellido2

            Next

            'asignar el fuente de dato para un control tipo ComboBox la lista genérica wrappeada

        Catch ex As Exception
            MessageBox.Show("Error en la operación ... " & ex.Message)
        End Try

    End Sub

    Private Sub buscarUsuarioCod(ByVal pcod As String)
        Try

            _listaUsuario = _gestor.buscarUsuarioId(pcod)

            dvgUsuario.Rows.Clear()

            Dim _tempCast() As String 'declarar una variable tipo arreglo de String

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

                _cadena = New ClsCastCadenaUsuario(_tempCast(0).ToString(), _tempCast(1).ToString(), _tempCast(2).ToString(), _tempCast(3).ToString(), _tempCast(4).ToString(), _tempCast(5).ToString(), _tempCast(6).ToString())

                dvgUsuario.Rows.Add()
                dvgUsuario.Rows.Item(dvgUsuario.Rows.Count - 1).Cells.Item(0).Value = _cadena.cedula
                dvgUsuario.Rows.Item(dvgUsuario.Rows.Count - 1).Cells.Item(1).Value = _cadena.nombre
                dvgUsuario.Rows.Item(dvgUsuario.Rows.Count - 1).Cells.Item(2).Value = _cadena.apellido1
                dvgUsuario.Rows.Item(dvgUsuario.Rows.Count - 1).Cells.Item(3).Value = _cadena.apellido2

            Next
        Catch ex As Exception
            MessageBox.Show("Error en la operación ... " & ex.Message)
        End Try

    End Sub

    Private Sub buscarUsuarioNombre(ByVal pnombre As String)
        Try

            'asignar el resultado de la búsqueda devuelto por un método del Gestor
            _listaUsuario = _gestor.buscarUsuarioPorNombre(pnombre)

            dvgUsuario.Rows.Clear()

            Dim _tempCast() As String 'declarar una variable tipo arreglo de String

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

                _cadena = New ClsCastCadenaUsuario(_tempCast(0).ToString(), _tempCast(1).ToString(), _tempCast(2).ToString(), _tempCast(3).ToString(), _tempCast(4).ToString(), _tempCast(5).ToString(), _tempCast(6).ToString())

                dvgUsuario.Rows.Add()
                dvgUsuario.Rows.Item(dvgUsuario.Rows.Count - 1).Cells.Item(0).Value = _cadena.cedula
                dvgUsuario.Rows.Item(dvgUsuario.Rows.Count - 1).Cells.Item(1).Value = _cadena.nombre
                dvgUsuario.Rows.Item(dvgUsuario.Rows.Count - 1).Cells.Item(2).Value = _cadena.apellido1
                dvgUsuario.Rows.Item(dvgUsuario.Rows.Count - 1).Cells.Item(3).Value = _cadena.apellido2

            Next

        Catch ex As Exception
            MessageBox.Show("Error en la operación ... " & ex.Message)
        End Try

    End Sub

    Private Sub txtCriterio_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCriterio.TextChanged
        evaluar()

        If _criterio = "Identificador" Then
            buscarUsuarioCod(Me.txtCriterio.Text)
        ElseIf _criterio = "Nombre" Then
            buscarUsuarioNombre(Me.txtCriterio.Text)
        End If

    End Sub

    Private Sub pbRegresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        _frmSiscove.cargarUserControl(New ctlPrincipal)
    End Sub

    Private Sub pbModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbModificar.Click
        Me.gbModificarUsuario.Visible = True
        If Not dvgUsuario.RowCount = 0 Then
            Dim id = dvgUsuario.SelectedCells(0).Value
            Me.llenarCamposModificar(System.Convert.ToString(id))
            validarRoles()
        End If
    End Sub

    Private Sub validarRoles()
        If ROL_USUARIO.Contains("Gerente General") Then
            pbEliminar.Visible = False
            pbModificar2.Visible = False
            gbModificarUsuario.Enabled = False

        ElseIf ROL_USUARIO.Contains("Vendedor") Then
            pbEliminar.Visible = False
            pbModificar2.Visible = False
            gbModificarUsuario.Enabled = False

        End If
    End Sub

    Private Sub pbEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbEliminar.Click
        If Not dvgUsuario.RowCount = 0 Then
            _ced = Me.dvgUsuario.SelectedCells(0).Value
            _result = MessageBox.Show("¿Desea eliminar el usuario?", "Eliminar Usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, 0, False)
            Try
                If _result = Windows.Forms.DialogResult.Yes Then
                    'invocar el método indicado enviando los argumentos requeridos.
                    _gestor.eliminarUsuario(_ced)

                    evaluar()
                    limpiarTabla()
                    listarUsuarios()

                    MsgBox("El usuario fue eliminado exitosamente.", MsgBoxStyle.Information, "Eliminar Usuario")
                Else
                    MsgBox("El usuario no fue eliminado.", MsgBoxStyle.Information, "Eliminar Usuario")

                End If
            Catch ex As Exception
                MsgBox("El usuario no se pudo eliminar.", MsgBoxStyle.Information, "Eliminar Usuario")
            End Try
        End If
    End Sub

    Private Sub pbModificar2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbModificar2.Click
        _resul = evaluarEspacios()
        _numero = False
        Dim num As Integer

        num = CInt(cbxDepartamento.SelectedIndex.ToString)
        num = num + 1

        If _resul = True Then

            'asignar a cada variable los valores indicados
            _ced = txtCod.Text
            _nombre = txtNombre.Text
            _apellido1 = txtApellido1.Text
            _apellido2 = txtApellido2.Text
            _correo = txtCorreo.Text
            _rol = cbxRol.SelectedItem.ToString
            _departamento = System.Convert.ToString(num)

            _result = MessageBox.Show("¿Desesa modificar los datos  del usuario?", "Modificar Usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, 0, False)

            Try
                If _result = Windows.Forms.DialogResult.Yes Then
                    _gestor.modificarUsuario(_ced, _nombre, _apellido1, _apellido2, _correo, _rol, _departamento) 'invocar el método indicado enviando los argumentos requeridos.
                    MsgBox("Los datos del usuario fueron  modificados.", MsgBoxStyle.Information, "Modificar Usuario")

                    limpiarForm()
                    limpiarTabla()

                Else
                    MsgBox("Los datos del usuario no fueron modificados.", MsgBoxStyle.Information, "Modificar Usuario")

                End If

            Catch ex As Exception
                MsgBox("Los datos ingresados ya existen en la base de datos.", MsgBoxStyle.Information, "Modificar Usuario")

            End Try
        End If

    End Sub

    Private Sub pbAyuda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim _form As frmAyuda
        _form = New frmAyuda()
        _form.Show()
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint
        validarRoles()
    End Sub
End Class
