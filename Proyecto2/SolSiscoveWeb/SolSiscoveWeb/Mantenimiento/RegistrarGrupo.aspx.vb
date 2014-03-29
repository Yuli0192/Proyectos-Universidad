Imports CllLogicaNegocio

Partial Public Class RegistrarGrupo
    Inherits System.Web.UI.Page

    Dim _gestor As New ClsGestor() 'declara e instancia de la clase Gestor
    Dim _cod As String
    Dim _descripcion As String
    Dim _idEncargado As String
    Dim _listaServicios As ArrayList = New ArrayList()
    Dim _listaVendedores As ArrayList = New ArrayList()
    Dim _resul As Boolean

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        cargarEncargados()
        cargarVendedores()
        cargarServicios()
        Me.txtCodigo.Focus()
    End Sub

    Private Sub cargarServicios()
        Try
            Dim _listaServicios As List(Of Array) = New List(Of Array)() 'declarar una variable tipo lista genérica de Array

            _listaServicios = _gestor.listarServicios() 'asignar el resultado de la búsqueda devuelto por un método del Gestor

            Dim _tempArray As Array 'declarar una variable tipo Array

            Dim _listTemp As New List(Of ClsCastCadenaServicio) 'declarar una variable tipo lista genérica tipo clsCastCadenaServicio (Wrapper)

            Dim _tempCast() As String 'declarar una variable tipo arreglo de String

            'estructura iterativa tipo matriz para recorrer y envolver por el tipo adecuado
            For i As Integer = 0 To _listaServicios.Count - 1
                _tempArray = _listaServicios(i) 'clonar a un Array temporal la FILA (ROW) de la consulta

                ReDim _tempCast(_tempArray.Length() - 1) 'redimensionar el arreglo a un tamaño indicado

                For j As Integer = 0 To _tempArray.Length - 1 'recorrer la parte interna de la matriz, columna (COLUMN)

                    _tempCast(j) = _tempArray.GetValue(j).ToString() 'asignar el valor de cada celda 
                Next
                _listTemp.Add(New ClsCastCadenaServicio(_tempCast(0).ToString(), _tempCast(1).ToString(), _tempCast(2).ToString(), _tempCast(3).ToString(), _tempCast(4).ToString(), _tempCast(5).ToString(), _tempCast(6).ToString(), _tempCast(7).ToString(), _tempCast(8).ToString(), _tempCast(9).ToString(), _tempCast(10).ToString())) 'agregar a la lista genérica una colección de la clase wrapper

            Next
            'asignar el fuente de dato para un control tipo listbox la lista genérica wrappeada
            Me.gridServicioDisp.DataSource = _listTemp
            Me.gridServicioDisp.DataBind()
            Me.gridServicioDisp.SelectedItemIndex = 0  

        Catch ex As Exception
            MsgBox("Error en la operación ... " & ex.Message)
        End Try
    End Sub

    Private Sub cargarEncargados()
        Try
            Dim _listaVendedores As List(Of Array) = New List(Of Array)() 'declarar una variable tipo lista genérica de Array

            _listaVendedores = _gestor.listarmastersgerentesdisponibles() 'asignar el resultado de la búsqueda devuelto por un método del Gestor

            Dim _tempArray As Array 'declarar una variable tipo Array

            Dim _listTemp As New List(Of ClsCastCadenaUsuario) 'declarar una variable tipo lista genérica tipo clsCastCadenaServicio (Wrapper)

            Dim _tempCast() As String 'declarar una variable tipo arreglo de String

            'estructura iterativa tipo matriz para recorrer y envolver por el tipo adecuado
            For i As Integer = 0 To _listaVendedores.Count - 1
                _tempArray = _listaVendedores(i) 'clonar a un Array temporal la FILA (ROW) de la consulta

                ReDim _tempCast(_tempArray.Length() - 1) 'redimensionar el arreglo a un tamaño indicado

                For j As Integer = 0 To _tempArray.Length - 1 'recorrer la parte interna de la matriz, columna (COLUMN)

                    _tempCast(j) = _tempArray.GetValue(j).ToString() 'asignar el valor de cada celda 
                Next
                _listTemp.Add(New ClsCastCadenaUsuario(_tempCast(0).ToString(), _tempCast(1).ToString(), _
                                _tempCast(2).ToString(), _tempCast(3).ToString(), _tempCast(4).ToString()))
            Next
            'asignar el fuente de dato para un control tipo listbox la lista genérica wrappeada
            Me.ddlEncargado.DataSource = _listTemp
            Me.ddlEncargado.DataTextField = "nombreCompleto"
            Me.ddlEncargado.DataValueField = "cedula"
            Me.ddlEncargado.DataBind()
            Me.ddlEncargado.SelectedIndex = 0
        Catch ex As Exception
            MsgBox("Error en la operación ... " & ex.Message)
        End Try
    End Sub

    Private Sub cargarVendedores()
        Try
            Dim _listaVendedores As List(Of Array) = New List(Of Array)() 'declarar una variable tipo lista genérica de Array

            _listaVendedores = _gestor.listarVendedores() 'asignar el resultado de la búsqueda devuelto por un método del Gestor

            Dim _tempArray As Array 'declarar una variable tipo Array

            Dim _listTemp As New List(Of ClsCastCadenaUsuario) 'declarar una variable tipo lista genérica tipo clsCastCadenaServicio (Wrapper)

            Dim _tempCast() As String 'declarar una variable tipo arreglo de String

            'estructura iterativa tipo matriz para recorrer y envolver por el tipo adecuado
            For i As Integer = 0 To _listaVendedores.Count - 1
                _tempArray = _listaVendedores(i) 'clonar a un Array temporal la FILA (ROW) de la consulta

                ReDim _tempCast(_tempArray.Length() - 1) 'redimensionar el arreglo a un tamaño indicado

                For j As Integer = 0 To _tempArray.Length - 1 'recorrer la parte interna de la matriz, columna (COLUMN)

                    _tempCast(j) = _tempArray.GetValue(j).ToString() 'asignar el valor de cada celda 
                Next
                _listTemp.Add(New ClsCastCadenaUsuario(_tempCast(0).ToString(), _tempCast(1).ToString(), _
                                _tempCast(2).ToString(), _tempCast(3).ToString(), _tempCast(4).ToString(), _
                                _tempCast(5).ToString(), _tempCast(6).ToString()))
            Next
            'asignar el fuente de dato para un control tipo listbox la lista genérica wrappeada
            Me.gridVendedorDisp.DataSource = _listTemp
            Me.gridVendedorDisp.DataBind()
        Catch ex As Exception
            MsgBox("Error en la operación ... " & ex.Message)
        End Try
    End Sub

    Private Sub limpiarForm()
        With Me
            .txtCodigo.Text = ""
            .txtCodigo.Focus()
            .txtDescripcion.Text = ""
            .gridServicio.Items.Clear()
            .gridVendedor.Items.Clear()
            .ddlEncargado.SelectedIndex = 0
            cargarServicios()
            cargarVendedores()
        End With

    End Sub

    Public Function evaluarEspacio() As Boolean
        Dim _resul As Boolean = False

        If Me.txtCodigo.Text = "" Then
            MsgBox("El codigo del grupo de ventas es un dato requerido")
            Me.txtCodigo.Focus()
        ElseIf Me.txtDescripcion.Text = "" Then
            MsgBox("La descripción del grupo de ventas es un dato requerido")
            Me.txtDescripcion.Focus()
        ElseIf Me.gridServicio.Items.Count = 0  Then
            MsgBox("Debe asociar al menos un servicio al grupo de ventas")
        ElseIf Me.gridVendedor.Items.Count = 0 Then
            MsgBox("Debe asociar al menos un vendedor al grupo de ventas")
        Else
            _resul = True
        End If
        Return _resul
    End Function

    '''' <summary>
    ''''Funcion que crea un DataTable con los datos que le pasemos por parametro.
    '''' </summary>
    '''' <remarks></remarks>
    'Function getDataTable(ByVal pdatos As List(Of ClsCastCadenaUsuario)) As DataTable

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
    '    For Each cliente As ClsCastCadenaUsuario In pdatos
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

    Protected Sub btnLimpiar_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btnLimpiar.Click
        limpiarForm()
    End Sub


    Protected Sub btnRegistrar_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btnRegistrar.Click
        Dim result As Boolean = evaluarEspacio()
        If result Then
            _cod = Me.txtCodigo.Text
            _descripcion = Me.txtDescripcion.Text
            _idEncargado = Me.ddlEncargado.SelectedValue.ToString() 

            For i As Integer = 0 To gridServicio.Items.Count - 1
                Dim idServicio As String
                idServicio = (gridServicio.Items(i).Cells(0).Value) 'Agregamos el Id del servicio
            
            _listaServicios.Add(idServicio) 'Agregamos el servicio.
            Next

            For i As Integer = 0 To gridVendedor.Items.Count - 1
                Dim idVendedor As String
                idVendedor = (gridVendedor.Items(i).Cells(0).Value) 'Agregamos el Id del vendedor
                _listaVendedores.Add(idVendedor) 'Agregamos el vendedor.
            Next

            Try
                _gestor.registrarGrupoDeVenta(_cod, _descripcion, _idEncargado, _listaVendedores, _listaServicios)
                MsgBox("El grupo de ventas se ha registrado correctamente.", MsgBoxStyle.Information, "Registrar Grupo De Venta")
                limpiarForm()
            Catch ex As Exception
                MsgBox("Los datos ingresados ya existen en la base de datos." & ex.Message, MsgBoxStyle.Information, "Registrar Grupo De Ventas")
            End Try
        End If
    End Sub
End Class
