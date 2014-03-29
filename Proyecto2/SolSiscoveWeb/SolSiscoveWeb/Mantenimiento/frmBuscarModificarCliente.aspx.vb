Imports CllLogicaNegocio.ClsGestor
Partial Public Class frmBuscarModificarCliente
    Inherits System.Web.UI.Page
    Dim _gestor As New CllLogicaNegocio.ClsGestor
    Dim _criterio As String
    Dim emailExpression As New Regex("^[_a-z0-9-]+(.[a-z0-9-]+)@[a-z0-9-]+(.[a-z0-9-]+)*(.[a-z]{2,4})$")

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Me.txtCriterio.Focus()
            cargarClientes()
        End If
    End Sub

    Protected Sub txtCriterio_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtCriterio.TextChanged
        QuitarControles()
        If txtCriterio.Text.Equals("") Then
            cargarClientes()
        Else
            Me.gridCliente.DataSource = ""
        End If
        If _criterio = "Identificador" Then
            buscarClientePorId(Me.txtCriterio.Text)
        ElseIf _criterio = "Nombre" Then
            buscarClientePorNombre(Me.txtCriterio.Text)
        End If
    End Sub

    Protected Sub bntBuscar_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles bntBuscar.Click
        Dim _resul As Boolean = evaluar()
        If _resul Then
            If _criterio = "Identificador" Then
                buscarClientePorId(Me.txtCriterio.Text)
            ElseIf _criterio = "Nombre" Then
                buscarClientePorNombre(Me.txtCriterio.Text)
            End If
        End If
    End Sub
    Private Function evaluar() As Boolean
        Dim _resul As Boolean

        If rblCriterio.SelectedValue.ToString = "rbtId" Then
            _criterio = "Identificador"
        Else
            _criterio = "Nombre"
        End If

        If Me.txtCriterio.Text <> "" Then
            _resul = True
        Else
            MsgBox("El dato " & _criterio & " es un valor requerido", MsgBoxStyle.Information, "Buscar cliente")
            Me.txtCriterio.Focus()
        End If
        Return _resul
    End Function

    Public Sub limpiarForm()
        Me.gridCliente.DataSource = ""
        Me.txtCriterio.Text = ""
        cargarClientes()
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
            Me.gridCliente.DataSource = _listTemp 'asignar el fuente de dato para un control tipo DataGridView la lista genérica wrappeada

            Me.gridCliente.DataBind()
            'Vamos a probar si pondemos cambiar el nombre a las columnas..
            'gvCliente.Columns(1).ShowHeader = True
            'gvCliente.Columns(1).HeaderText = "Prueba para cambiar nombre"

            'Me.gvCliente.DataBind()
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
            Dim _listaCliente As List(Of Array) = New List(Of Array)() 'declarar una variable tipo lista genérica de Array
            'declarar una variable tipo Array
            Dim _tempArray As Array

            _listaCliente = _gestor.buscarClienteId(pidCliente) 'asignar el resultado de la búsqueda devuelto por un método del Gestor

            For i As Integer = 0 To _listaCliente.Count - 1 'estructura iterativa tipo matriz para recorrer y envolver por el tipo adecuado

                _tempArray = _listaCliente(i) 'clonar a un Array temporal la FILA (ROW) de la consulta
                ReDim _tempCast(_tempArray.Length() - 1) 'redimensionar el arreglo a un tamaño indicado

                For j As Integer = 0 To _tempArray.Length - 1 'recorrer la parte interna de la matriz, columna (COLUMN)
                    _tempCast(j) = _tempArray.GetValue(j).ToString() 'asignar el valor de cada celda 
                Next
                _listTemp.Add(New ClsCastCadenaCliente(_tempCast(0).ToString(), _tempCast(1).ToString(), _tempCast(2).ToString(), _tempCast(3).ToString(), _tempCast(4).ToString(), _tempCast(5).ToString())) 'agregar a la lista genérica una colección de la clase wrapper
            Next

            Me.gridCliente.DataSource = _listTemp 'asignar el fuente de dato para un control tipo datagridview la lista genérica wrappeada
            Me.gridCliente.DataBind()
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
            Dim _listaCliente As List(Of Array) = New List(Of Array)() 'declarar una variable tipo lista genérica de Array
            'declarar una variable tipo Array
            Dim _tempArray As Array

            _listaCliente = _gestor.buscarClientePorNombre(pnombre) 'asignar el resultado de la búsqueda devuelto por un método del Gestor

            For i As Integer = 0 To _listaCliente.Count - 1 'estructura iterativa tipo matriz para recorrer y envolver por el tipo adecuado

                _tempArray = _listaCliente(i) 'clonar a un Array temporal la FILA (ROW) de la consulta
                ReDim _tempCast(_tempArray.Length() - 1) 'redimensionar el arreglo a un tamaño indicado

                For j As Integer = 0 To _tempArray.Length - 1 'recorrer la parte interna de la matriz, columna (COLUMN)
                    _tempCast(j) = _tempArray.GetValue(j).ToString() 'asignar el valor de cada celda 
                Next

                _listTemp.Add(New ClsCastCadenaCliente(_tempCast(0).ToString(), _tempCast(1).ToString(), _tempCast(2).ToString(), _tempCast(3).ToString(), _tempCast(4).ToString(), _tempCast(5).ToString())) 'agregar a la lista genérica una colección de la clase wrapper

            Next

            Me.gridCliente.DataSource = _listTemp 'asignar el fuente de dato para un control tipo datagridview la lista genérica wrappeada
            Me.gridCliente.DataBind()
        Catch ex As Exception
            MsgBox("Error en la operación ... " & ex.Message, MsgBoxStyle.Information, "Buscar cliente")
        End Try

    End Sub

    '''' <summary>
    ''''Funcion que crea un DataTable con los datos que le pasemos por parametro.
    '''' </summary>
    '''' <remarks></remarks>
    'Function getDataTable(ByVal pdatos As List(Of ClsCastCadenaCliente)) As DataTable

    '    'Creamos el DataTable.
    '    Dim dt As New DataTable()

    '    'Definimos el nombre de las columnas.
    '    dt.Columns.Add(New DataColumn("Id", GetType(String)))
    '    dt.Columns.Add(New DataColumn("Nombre", GetType(String)))
    '    dt.Columns.Add(New DataColumn("Teléfono", GetType(String)))
    '    dt.Columns.Add(New DataColumn("Correo", GetType(String)))
    '    dt.Columns.Add(New DataColumn("Contacto", GetType(String)))
    '    dt.Columns.Add(New DataColumn("Dirección", GetType(String)))
    '    ' Create the four records
    '    For Each cliente As ClsCastCadenaCliente In pdatos
    '        Dim dr As DataRow = dt.NewRow()
    '        dr("Id") = cliente.idCliente
    '        dr("Nombre") = cliente.nombreCliente
    '        dr("Teléfono") = cliente.telefonoCliente
    '        dr("Correo") = cliente.correoCliente
    '        dr("Contacto") = cliente.contactoCliente
    '        dr("Dirección") = cliente.direccionCliente
    '        dt.Rows.Add(dr)
    '    Next
    '    Return dt
    'End Function


    Protected Sub rblCriterio_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles rblCriterio.SelectedIndexChanged
        limpiarForm()
        Me.txtCriterio.Focus()
    End Sub

    Protected Sub bntEliminar_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles bntEliminar.Click
        Dim _idCliente As String = gridCliente.Items(gridCliente.SelectedItemIndex).Cells("idCliente").Value
        'MsgBox("Se va a borrar al cliente con el id:" & _idCliente)

        Try
            _gestor.eliminarCliente(_idCliente) 'invocar el método indicado enviando los argumentos requeridos.
            MsgBox("Los datos del cliente se han eliminado.", MsgBoxStyle.Information, "Eliminar cliente")

        Catch ex As Exception
            MsgBox("Los datos del cliente no se pueden eliminar." & ex.Message, MsgBoxStyle.Information, "Eliminar cliente")
        End Try
        limpiarForm()
    End Sub

    Protected Sub bntModificar_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles bntModificar.Click
        visibleControl()
        Dim _idCliente As String = gridCliente.Items(gridCliente.SelectedItemIndex).Cells("idCliente").Value
        Dim _nombre As String = gridCliente.Items(gridCliente.SelectedItemIndex).Cells("nombreCliente").Value
        Dim _telefono As String = gridCliente.Items(gridCliente.SelectedItemIndex).Cells("telefonoCliente").Value
        Dim _correoCliente As String = gridCliente.Items(gridCliente.SelectedItemIndex).Cells("correoCliente").Value
        Dim _contacto As String = gridCliente.Items(gridCliente.SelectedItemIndex).Cells("contactoCliente").Value
        Dim _direccion As String = gridCliente.Items(gridCliente.SelectedItemIndex).Cells("direccionCliente").Value

        modificar(_idCliente, _nombre, _telefono, _correoCliente, _contacto, _direccion)
    End Sub

    ''' <summary>
    ''' Método d clase, encargado de hacer visible componentes
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub visibleControl()

        derecha.Visible = True

    End Sub

    ''' <summary>
    ''' Método d clase, encargado de hacer invisible componentes
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub QuitarControles()
        derecha.Visible = False
    End Sub

    ''' <summary>
    ''' Método de clase, encarga de evaluar que no queden espacios en blanco ningún componente
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Protected Function validarDatos() As Boolean
        Dim resul As Boolean = False
        If txtId.Text.Equals("") Then
            MsgBox("El identificador del cliente es un dato requerido", MsgBoxStyle.Information, "Modificar Cliente")
            Me.txtId.Focus()
        ElseIf txtNombre.Text.Equals("") Then
            MsgBox("El nombre del cliente es un dato requerido", MsgBoxStyle.Information, "Modificar Cliente")
            Me.txtNombre.Focus()
        ElseIf txtTelefono.Text.Equals("") Then
            MsgBox("El teléfono del cliente es un dato requerido", MsgBoxStyle.Information, "Modificar Cliente")
            Me.txtTelefono.Focus()
            'ElseIf Not telefonoExpression.IsMatch(txtTelefono.Text) Then
            '    MsgBox("El formato del telefono es incorrecto", MsgBoxStyle.Information, "Registrar Cliente")
        ElseIf txtCorreo.Text.Equals("") Then
            MsgBox("El correo del cliente es un dato requerido", MsgBoxStyle.Information, "Modificar Cliente")
            Me.txtCorreo.Focus()
        ElseIf Not emailExpression.IsMatch(txtCorreo.Text) Then
            MsgBox("El formato del correo electrónico es incorrecto", MsgBoxStyle.Information, "Modificar Cliente")
        ElseIf txtContacto.Text.Equals("") Then
            MsgBox("El correo del cliente es un dato requerido", MsgBoxStyle.Information, "Modificar Cliente")
            Me.txtCorreo.Focus()
        ElseIf txtDireccion.Text.Equals("") Then
            MsgBox("La dirección del cliente es un dato requerido", MsgBoxStyle.Information, "Modificar Cliente")
            Me.txtDireccion.Focus()
        Else
            Return True
        End If
    End Function

    ''' <summary>
    ''' Método de clase, encarga de asignarle los valores a cada componente
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub modificar(ByVal pidCliente As String, ByVal pnombre As String, ByVal ptelefono As String, ByVal pcorreoCliente As String, ByVal pcontacto As String, ByVal pdireccion As String)
        With Me
            .txtId.Text = pidCliente
            .txtNombre.Text = pnombre
            .txtTelefono.Text = ptelefono
            .txtCorreo.Text = pcorreoCliente
            .txtContacto.Text = pcontacto
            .txtDireccion.Text = pdireccion
        End With

    End Sub

    Protected Sub bntConfirmarModificacion_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles bntConfirmarModificacion.Click
        Dim _resul As Boolean = validarDatos()
        If _resul = True Then

            'asignar a cada variable los valores indicados
            Dim _idCliente As String = Me.txtId.Text
            Dim _nombre As String = Me.txtNombre.Text
            Dim _telefono As String = Me.txtTelefono.Text
            Dim _correoCliente As String = Me.txtCorreo.Text
            Dim _contacto As String = Me.txtContacto.Text
            Dim _direccion As String = Me.txtDireccion.Text
            
            Try
                _gestor.modificarCliente(_idCliente, _nombre, _telefono, _correoCliente, _contacto, _direccion) 'invocar el método indicado enviando los argumentos requeridos.
                MsgBox("Los datos del cliente son modificados.", MsgBoxStyle.Information, "Modificar cliente")
                QuitarControles()

            Catch ex As Exception
                MsgBox("Los datos ingresados ya existen en la base de datos.", MsgBoxStyle.Information, "Modificar cliente")
            End Try
        End If
        cargarClientes()
    End Sub

    Protected Sub txtDireccion_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtDireccion.TextChanged
        If Me.txtContacto.Text = "" Then
            Me.txtContacto.Text = Me.txtNombre.Text 'Si deja este campo vacio se le asigna el nombre del cliente
        End If
    End Sub
End Class