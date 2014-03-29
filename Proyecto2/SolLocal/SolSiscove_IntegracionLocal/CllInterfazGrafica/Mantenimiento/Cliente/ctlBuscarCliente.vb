Imports CllLogicaNegocio.ClsGestor
Imports System.Text.RegularExpressions
Public Class ctlBuscarCliente

    Dim _gestor As New CllLogicaNegocio.ClsGestor() 'declaración e instanciación de la clase Gestor
    Dim _listaCliente As List(Of Array) = New List(Of Array)() 'declarar una variable tipo lista genérica de Array
    Private emailExpression As New Regex("^[_a-z0-9-]+(.[a-z0-9-]+)@[a-z0-9-]+(.[a-z0-9-]+)*(.[a-z]{2,4})$")
    'declarar una variable tipo Array
    Dim _tempArray As Array
    'declarar variable globales tipo boolean
    Dim _resul As Boolean
    'declarar variables globales tipo String
    Dim _criterio As String
    Dim _idCliente As String
    Dim _nombre As String
    Dim _telefono As String
    Dim _correoCliente As String
    Dim _contacto As String
    Dim _direccion As String

    Private Sub ctlBuscarCliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.txtCriterioB.Focus()
        limpiarForm()
        nombrarColumnas()
    End Sub

    Private Sub rdbId_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbId.CheckedChanged
        limpiarForm()
        Me.txtCriterioB.Focus()
    End Sub
    Private Sub txtCriterioB_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCriterioB.TextChanged
        QuitarControles()
        evaluar()
        If txtCriterioB.Text = "" Then
            cargarClientes()
        ElseIf _criterio = "Identificador" Then
            buscarClientePorId(Me.txtCriterioB.Text)
        ElseIf _criterio = "Nombre" Then
            buscarClientePorNombre(Me.txtCriterioB.Text)
        End If
    End Sub

    Private Sub txtDireccion_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDireccion.TextChanged
        If Me.txtContacto.Text = "" Then
            Me.txtContacto.Text = Me.txtNombre.Text 'Si deja este campo vacio se le asigna el nombre del cliente
        End If
    End Sub

    Private Sub rdbNombre_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbNombre.CheckedChanged
        limpiarForm()
        Me.txtCriterioB.Focus()
    End Sub
    Private Sub limpiarForm()
        Me.dvgClientes.DataSource = ""
        Me.txtCriterioB.Text = ""
        cargarClientes()
    End Sub

    Private Sub evaluar()

        If txtCriterioB.Text.Equals("") Then
            cargarClientes()
        Else
            Me.dvgClientes.DataSource = ""
        End If

        If rdbId.Checked Then
            _criterio = "Identificador"
        Else
            _criterio = "Nombre"
        End If

    End Sub
    ''' <summary>
    ''' Método de clase, encarga de renombrar los encabezados al datagridview
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub nombrarColumnas()
        dvgClientes.Columns(0).HeaderText = "Identificación"
        dvgClientes.Columns(1).HeaderText = "Nombre"
        dvgClientes.Columns(2).HeaderText = "Teléfono"
        dvgClientes.Columns(3).HeaderText = "Correo Cliente"
        dvgClientes.Columns(4).HeaderText = "Contacto"
        dvgClientes.Columns(5).HeaderText = "Dirección"
    End Sub
    ''' <summary>
    ''' Método de clase, encargado de cargar todos los clientes existentes en la DB
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub cargarClientes()
        Try
            Dim _listaCliente As List(Of Array) = New List(Of Array)() 'declarar una variable tipo lista genérica de Array

            _listaCliente = _gestor.listarClientes() 'asignar el resultado de la búsqueda devuelto por un método del Gestor

            Dim _tempArray As Array 'declarar una variable tipo Array

            Dim _listTemp As New List(Of ClsCastCadenaCliente) 'declarar una variable tipo lista genérica tipo clsCastCadenaCliente (Wrapper)

            Dim _tempCast() As String 'declarar una variable tipo arreglo de String

            'estructura iterativa tipo matriz para recorrer y envolver por el tipo adecuado
            For i As Integer = 0 To _listaCliente.Count - 1

                _tempArray = _listaCliente(i) 'clonar a un Array temporal la FILA (ROW) de la consulta

                ReDim _tempCast(_tempArray.Length() - 1) 'redimensionar el arreglo a un tamaño indicado

                'recorrer la parte interna de la matriz, columna (COLUMN)
                For j As Integer = 0 To _tempArray.Length - 1
                    'asignar el valor de cada celda 
                    _tempCast(j) = _tempArray.GetValue(j).ToString()
                Next
                _listTemp.Add(New ClsCastCadenaCliente(_tempCast(0).ToString(), _tempCast(1).ToString(), _tempCast(2).ToString(), _tempCast(3).ToString(), _tempCast(4).ToString(), _tempCast(5).ToString())) 'agregar a la lista genérica una colección de la clase wrapper

            Next
            Me.dvgClientes.DataSource = _listTemp 'asignar el fuente de dato para un control tipo DataGridView la lista genérica wrappeada

        Catch ex As Exception
            MsgBox("Error en la operación ... " & ex.Message, MsgBoxStyle.Information, "Buscar cliente")
        End Try
    End Sub

    ''' <summary>
    ''' Método de clase, encargado de cargar el cliente existente en la DB con el id suministado
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub buscarClientePorId(ByVal pidCliente As String)
        Try
            Dim _listTemp As New List(Of ClsCastCadenaCliente) 'declarar una variable tipo lista genérica tipo clsCastCadena (Wrapper)
            Dim _tempCast() As String 'declarar una variable tipo arreglo de String

            _listaCliente = _gestor.buscarClienteId(pidCliente) 'asignar el resultado de la búsqueda devuelto por un método del Gestor

            For i As Integer = 0 To _listaCliente.Count - 1 'estructura iterativa tipo matriz para recorrer y envolver por el tipo adecuado

                _tempArray = _listaCliente(i) 'clonar a un Array temporal la FILA (ROW) de la consulta
                ReDim _tempCast(_tempArray.Length() - 1) 'redimensionar el arreglo a un tamaño indicado

                For j As Integer = 0 To _tempArray.Length - 1 'recorrer la parte interna de la matriz, columna (COLUMN)
                    _tempCast(j) = _tempArray.GetValue(j).ToString() 'asignar el valor de cada celda 
                Next
                _listTemp.Add(New ClsCastCadenaCliente(_tempCast(0).ToString(), _tempCast(1).ToString(), _tempCast(2).ToString(), _tempCast(3).ToString(), _tempCast(4).ToString(), _tempCast(5).ToString())) 'agregar a la lista genérica una colección de la clase wrapper
            Next
            Me.dvgClientes.DataSource = _listTemp 'asignar el fuente de dato para un control tipo datagridview la lista genérica wrappeada
            nombrarColumnas()
        Catch ex As Exception
            MsgBox("Error en la operación ... " & ex.Message, MsgBoxStyle.Information, "Buscar cliente")
        End Try
    End Sub

    ''' <summary>
    ''' Método de clase, encargado de cargar los clientes existentes en la DB con el nombre suministado
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub buscarClientePorNombre(ByVal pnombre As String)
        Try
            Dim _listTemp As New List(Of ClsCastCadenaCliente) 'declarar una variable tipo lista genérica tipo clsCastCadena (Wrapper)
            Dim _tempCast() As String 'declarar una variable tipo arreglo de String

            _listaCliente = _gestor.buscarClientePorNombre(pnombre) 'asignar el resultado de la búsqueda devuelto por un método del Gestor

            For i As Integer = 0 To _listaCliente.Count - 1 'estructura iterativa tipo matriz para recorrer y envolver por el tipo adecuado

                _tempArray = _listaCliente(i) 'clonar a un Array temporal la FILA (ROW) de la consulta
                ReDim _tempCast(_tempArray.Length() - 1) 'redimensionar el arreglo a un tamaño indicado

                For j As Integer = 0 To _tempArray.Length - 1 'recorrer la parte interna de la matriz, columna (COLUMN)
                    _tempCast(j) = _tempArray.GetValue(j).ToString() 'asignar el valor de cada celda 
                Next

                _listTemp.Add(New ClsCastCadenaCliente(_tempCast(0).ToString(), _tempCast(1).ToString(), _tempCast(2).ToString(), _tempCast(3).ToString(), _tempCast(4).ToString(), _tempCast(5).ToString())) 'agregar a la lista genérica una colección de la clase wrapper

            Next

            Me.dvgClientes.DataSource = _listTemp 'asignar el fuente de dato para un control tipo datagridview la lista genérica wrappeada
            nombrarColumnas()
        Catch ex As Exception
            MsgBox("Error en la operación ... " & ex.Message, MsgBoxStyle.Information, "Buscar cliente")
        End Try

    End Sub
    ''' <summary>
    ''' Método de clase, encargado de eliminar el cliente en la DB
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub pbEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbEliminar.Click
        If Not dvgClientes.RowCount = 0 Then
            _idCliente = Me.dvgClientes.SelectedCells(0).Value
            Dim _result As DialogResult
            _result = MessageBox.Show("¿Está seguro que desea eliminar el cliente?", "Eliminar cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, 0, False)
            Try
                If _result = Windows.Forms.DialogResult.Yes Then
                    _gestor.eliminarCliente(_idCliente) 'invocar el método indicado enviando los argumentos requeridos.
                    MsgBox("Los datos del cliente se han eliminado.", MsgBoxStyle.Information, "Eliminar cliente")
                Else
                    MsgBox("Los datos del cliente no se pueden eliminar.", MsgBoxStyle.Information, "Eliminar cliente")
                End If
            Catch ex As Exception
                MsgBox("Los datos del cliente no se pueden eliminar." & ex.Message, MsgBoxStyle.Information, "Eliminar cliente")
            End Try
            limpiarForm()
        End If
    End Sub

    Private Sub pbModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbModificar.Click
        If Not dvgClientes.RowCount = 0 Then
            visibleControl()
            _idCliente = Me.dvgClientes.SelectedCells(0).Value
            _nombre = Me.dvgClientes.SelectedCells(1).Value
            _telefono = Me.dvgClientes.SelectedCells(2).Value
            _correoCliente = Me.dvgClientes.SelectedCells(3).Value
            _contacto = Me.dvgClientes.SelectedCells(4).Value
            _direccion = Me.dvgClientes.SelectedCells(5).Value

            modificar(_idCliente, _nombre, _telefono, _correoCliente, _contacto, _direccion)
            validarRoles()
        End If
    End Sub

    Private Sub validarRoles()
        If ROL_USUARIO.Contains("Gerente General") Then
            pbEliminar.Visible = False
            pbConfirmarModificacion.Visible = False
            gpbModificarCliente.Enabled = False

        ElseIf ROL_USUARIO.Contains("Vendedor") Then
            pbEliminar.Visible = False
            pbConfirmarModificacion.Visible = False
            gpbModificarCliente.Enabled = False

        End If
    End Sub

    ''' <summary>
    ''' Método d clase, encargado de hacer visible componentes
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub visibleControl()
        Me.gpbModificarCliente.Visible = True
    End Sub

    ''' <summary>
    ''' Método d clase, encargado de hacer invisible componentes
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub QuitarControles()
        Me.gpbModificarCliente.Visible = False
    End Sub

    ''' <summary>
    ''' Método de clase, encarga de evaluar que no queden espacios en blanco ningún componente
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function evaluarEspacion() As Boolean
        Dim _resul = False

        If Me.txtId.Text = "" Then
            MsgBox("El identificador del cliente es un dato requerido", MsgBoxStyle.Information, "Modificar cliente")
            Me.txtId.Focus()

        ElseIf Me.txtNombre.Text = "" Then
            MsgBox("El nombre del cliente es un dato requerido", MsgBoxStyle.Information, "Modificar cliente")
            Me.txtNombre.Focus()

        ElseIf Me.txtTelefono.Text = "" Then
            MsgBox("El teléfono del cliente es un dato requerido", MsgBoxStyle.Information, "Modificar cliente")
            Me.txtTelefono.Focus()

        ElseIf Not emailExpression.IsMatch(txtCorreo.Text) Then
            MsgBox("El formato del correo electrónico es incorrecto", MsgBoxStyle.Information, "Modificar cliente")
            txtCorreo.SelectAll()

        ElseIf Me.txtCorreo.Text = "" Then
            MsgBox("El correo del cliente es un dato requerido", MsgBoxStyle.Information, "Modificar cliente")
            Me.txtCorreo.Focus()

        ElseIf Me.txtDireccion.Text = "" Then
            MsgBox("La dirección del cliente es un dato requerido", MsgBoxStyle.Information, "Modificar cliente")
            Me.txtDireccion.Focus()
        Else
            _resul = True
        End If
        Return _resul
    End Function

    ''' <summary>
    ''' Método de clase, encarga de asignarle los valores a cada componente
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub modificar(ByVal pidCliente As String, ByVal pnombre As String, ByVal ptelefono As String, ByVal pcorreoCliente As String, ByVal pcontacto As String, ByVal pdireccion As String)
        With Me
            .txtId.Text = pidCliente
            .txtId.ReadOnly = True
            .txtNombre.Text = pnombre
            .txtTelefono.Text = ptelefono
            .txtCorreo.Text = pcorreoCliente
            .txtContacto.Text = pcontacto
            .txtDireccion.Text = pdireccion
        End With

    End Sub

    ''' <summary>
    ''' Método de clase, encarga de modifcar los datos del cliente a la DB
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub pbConfirmarModificacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbConfirmarModificacion.Click
        Dim _result As DialogResult
        _resul = evaluarEspacion()
        '_numero = False
        If _resul = True Then

            'asignar a cada variable los valores indicados
            _idCliente = Me.txtId.Text
            _nombre = Me.txtNombre.Text
            _telefono = Me.txtTelefono.Text
            _correoCliente = Me.txtCorreo.Text
            _contacto = Me.txtContacto.Text
            _direccion = Me.txtDireccion.Text
            _result = MessageBox.Show("¿Está seguro que desea modificar los datos del cliente?", "Modificar cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, 0, False)

            Try
                If _result = Windows.Forms.DialogResult.Yes Then
                    _gestor.modificarCliente(_idCliente, _nombre, _telefono, _correoCliente, _contacto, _direccion) 'invocar el método indicado enviando los argumentos requeridos.
                    MsgBox("Los datos del cliente son modificados.", MsgBoxStyle.Information, "Modificar cliente")
                    QuitarControles()
                Else
                    MsgBox("Los datos del cliente no son modificados.", MsgBoxStyle.Information, "Modificar cliente")
                End If
            Catch ex As Exception
                MsgBox("Los datos ingresados ya existen en la base de datos.", MsgBoxStyle.Information, "Modificar cliente")
            End Try
        End If
        cargarClientes()
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint
        validarRoles()
    End Sub
End Class
