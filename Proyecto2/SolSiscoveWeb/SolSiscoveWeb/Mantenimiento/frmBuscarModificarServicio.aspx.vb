Imports CllLogicaNegocio.ClsGestor
Partial Public Class frmBuscarModificarServicio
    Inherits System.Web.UI.Page
    Dim _gestor As New CllLogicaNegocio.ClsGestor
    Dim _criterio As String
    ' Dim emailExpression As New Regex("^[_a-z0-9-]+(.[a-z0-9-]+)@[a-z0-9-]+(.[a-z0-9-]+)*(.[a-z]{2,4})$")

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.txtCriterio.Focus()
        cargarServicios()
    End Sub

    Protected Sub txtCriterio_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtCriterio.TextChanged
        QuitarControles()
        If txtCriterio.Text.Equals("") Then
            cargarServicios()
        Else
            Me.gvServicio.DataSource = "" 'AQUIIIIIII
        End If
        If _criterio = "Identificador" Then
            buscarServicioPorId(Me.txtCriterio.Text)
        ElseIf _criterio = "Nombre" Then
            buscarservicioPorNombre(Me.txtCriterio.Text)
        End If
    End Sub

    Protected Sub bntBuscar_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles bntBuscar.Click
        Dim _resul As Boolean = evaluar()
        If _resul Then
            If _criterio = "Identificador" Then
                buscarServicioPorId(Me.txtCriterio.Text)
            ElseIf _criterio = "Nombre" Then
                buscarservicioPorNombre(Me.txtCriterio.Text)
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
            Response.Write("<script language='javascript' type='text/javascript'> alert('Criterio de busqueda requerido');</script>")
            Me.txtCriterio.Focus()
        End If
        Return _resul
    End Function

    Public Sub limpiarForm()
        Me.gvServicio.DataSource = ""
        Me.txtCriterio.Text = ""
        cargarServicios()
    End Sub

    ''' <summary>
    ''' Método de clase, encargado de cargar todos los clientes existentes en la DB
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub cargarServicios()
        Try
            Dim _listaServicio As List(Of Array) = New List(Of Array)() 'declarar una variable tipo lista genérica de Array

            _listaServicio = _gestor.listarServicios() 'asignar el resultado de la búsqueda devuelto por un método del Gestor

            Dim _tempArray As Array 'declarar una variable tipo Array

            Dim _listTemp As New List(Of ClsCastCadenaServicio) 'declarar una variable tipo lista genérica tipo ClsCastCadenaServicio (Wrapper)

            Dim _tempCast() As String 'declarar una variable tipo arreglo de String

            'estructura iterativa tipo matriz para recorrer y envolver por el tipo adecuado
            For i As Integer = 0 To _listaServicio.Count - 1

                _tempArray = _listaServicio(i) 'clonar a un Array temporal la FILA (ROW) de la consulta

                ReDim _tempCast(_tempArray.Length() - 1) 'redimensionar el arreglo a un tamaño indicado

                'recorrer la parte interna de la matriz, columna (COLUMN)
                For j As Integer = 0 To _tempArray.Length - 1
                    'asignar el valor de cada celda 
                    _tempCast(j) = _tempArray.GetValue(j).ToString()
                Next
                _listTemp.Add(New ClsCastCadenaServicio(_tempCast(0).ToString(), _tempCast(1).ToString(), _tempCast(2).ToString(), _tempCast(3).ToString(), _tempCast(4).ToString(), _tempCast(5).ToString(), _tempCast(6).ToString(), _tempCast(7).ToString(), _tempCast(8).ToString(), _tempCast(9).ToString(), _tempCast(10).ToString())) 'agregar a la lista genérica una colección de la clase wrapper

            Next
            Me.gvServicio.DataSource = _listTemp 'asignar el fuente de dato para un control tipo DataGridView la lista genérica wrappeada

            gvServicio.CssClass = ""

            Me.gvServicio.DataBind()
            'Vamos a probar si pondemos cambiar el nombre a las columnas..
            'gvServicio.Columns(1).ShowHeader = True
            'gvServicio.Columns(1).HeaderText = "Prueba para cambiar nombre"

            'Me.gvServicio.DataBind()
        Catch ex As Exception
            Response.Write("<script language='javascript' type='text/javascript'> alert('Error - Funcion cargarServicios() en frmBuscarModificarServicio.aspx.vb');</script>")
        End Try
    End Sub


    ''' <summary>
    ''' Método de clase, encargado de cargar el cliente existente en la DB con el id suministado
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub buscarServicioPorId(ByVal pcodServicio As String)
        Try
            Dim _listTemp As New List(Of ClsCastCadenaServicio) 'declarar una variable tipo lista genérica tipo clsCastCadena (Wrapper)
            Dim _tempCast() As String 'declarar una variable tipo arreglo de String
            Dim _listaServicio As List(Of Array) = New List(Of Array)() 'declarar una variable tipo lista genérica de Array
            'declarar una variable tipo Array
            Dim _tempArray As Array

            _listaServicio = _gestor.buscarServicioCod(pcodServicio) 'asignar el resultado de la búsqueda devuelto por un método del Gestor

            For i As Integer = 0 To _listaServicio.Count - 1 'estructura iterativa tipo matriz para recorrer y envolver por el tipo adecuado

                _tempArray = _listaServicio(i) 'clonar a un Array temporal la FILA (ROW) de la consulta
                ReDim _tempCast(_tempArray.Length() - 1) 'redimensionar el arreglo a un tamaño indicado

                For j As Integer = 0 To _tempArray.Length - 1 'recorrer la parte interna de la matriz, columna (COLUMN)
                    _tempCast(j) = _tempArray.GetValue(j).ToString() 'asignar el valor de cada celda 
                Next
                _listTemp.Add(New ClsCastCadenaServicio(_tempCast(0).ToString(), _tempCast(1).ToString(), _tempCast(2).ToString(), _tempCast(3).ToString(), _tempCast(4).ToString(), _tempCast(5).ToString(), _tempCast(6).ToString(), _tempCast(7).ToString(), _tempCast(8).ToString(), _tempCast(9).ToString(), _tempCast(10).ToString())) 'agregar a la lista genérica una colección de la clase wrapper
            Next

            Me.gvServicio.DataSource = _listTemp 'asignar el fuente de dato para un control tipo datagridview la lista genérica wrappeada
            Me.gvServicio.DataBind()
        Catch ex As Exception
            Response.Write("<script language='javascript' type='text/javascript'> alert('Error - Funcion buscarServicioPorId() en frmBuscarModificarServicio.aspx.vb');</script>")
        End Try
    End Sub

    ''' <summary>
    ''' Método de clase, encargado de cargar los clientes existentes en la DB con el nombre suministado
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub buscarservicioPorNombre(ByVal pnombreServicio As String)
        Try
            Dim _listTemp As New List(Of ClsCastCadenaServicio) 'declarar una variable tipo lista genérica tipo clsCastCadena (Wrapper)
            Dim _tempCast() As String 'declarar una variable tipo arreglo de String
            Dim _listaServicio As List(Of Array) = New List(Of Array)() 'declarar una variable tipo lista genérica de Array
            'declarar una variable tipo Array
            Dim _tempArray As Array

            _listaServicio = _gestor.buscarservicioPorNombre(pnombreServicio) 'asignar el resultado de la búsqueda devuelto por un método del Gestor

            For i As Integer = 0 To _listaServicio.Count - 1 'estructura iterativa tipo matriz para recorrer y envolver por el tipo adecuado

                _tempArray = _listaServicio(i) 'clonar a un Array temporal la FILA (ROW) de la consulta
                ReDim _tempCast(_tempArray.Length() - 1) 'redimensionar el arreglo a un tamaño indicado

                For j As Integer = 0 To _tempArray.Length - 1 'recorrer la parte interna de la matriz, columna (COLUMN)
                    _tempCast(j) = _tempArray.GetValue(j).ToString() 'asignar el valor de cada celda 
                Next

                _listTemp.Add(New ClsCastCadenaServicio(_tempCast(0).ToString(), _tempCast(1).ToString(), _tempCast(2).ToString(), _tempCast(3).ToString(), _tempCast(4).ToString(), _tempCast(5).ToString(), _tempCast(6).ToString(), _tempCast(7).ToString(), _tempCast(8).ToString(), _tempCast(9).ToString(), _tempCast(10).ToString())) 'agregar a la lista genérica una colección de la clase wrapper

            Next

            Me.gvServicio.DataSource = _listTemp 'asignar el fuente de dato para un control tipo datagridview la lista genérica wrappeada
            Me.gvServicio.DataBind()
        Catch ex As Exception
            Response.Write("<script language='javascript' type='text/javascript'> alert('Error - Funcion buscarservicioPorNombre() en frmBuscarModificarServicio.aspx.vb');</script>")
        End Try

    End Sub




    Protected Sub rblCriterio_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles rblCriterio.SelectedIndexChanged
        limpiarForm()
        Me.txtCriterio.Focus()
    End Sub

    Protected Sub bntEliminar_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles bntEliminar.Click
        Dim _idServicio As String = Me.gvServicio.Items(Me.gvServicio.SelectedItemIndex).Cells(0).Value.ToString()
        'MsgBox("Se va a borrar al cliente con el id:" & _idCliente)

        Try
            _gestor.eliminarServicio(_idServicio) 'invocar el método indicado enviando los argumentos requeridos.
            Response.Write("<script language='javascript' type='text/javascript'> alert('Servicio Eliminado');</script>")

        Catch ex As Exception
            Response.Write("<script language='javascript' type='text/javascript'> alert('Error - Funcion btnEliminar_Click() en frmBuscarModificarServicio.aspx.vb');</script>")
        End Try
        limpiarForm()
    End Sub

    Protected Sub bntModificar_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles bntModificar.Click
        visibleControl()
        Me.txtId.Text = Me.gvServicio.Items(Me.gvServicio.SelectedItemIndex).Cells(0).Value.ToString()
        Me.txtNombre.Text = Me.gvServicio.Items(Me.gvServicio.SelectedItemIndex).Cells(1).Value.ToString()
        Me.txtDescripcion.Text = Me.gvServicio.Items(Me.gvServicio.SelectedItemIndex).Cells(2).Value.ToString()
        Me.txtPrecioColones.Text = Me.gvServicio.Items(Me.gvServicio.SelectedItemIndex).Cells(3).Value.ToString()
        Me.txtPrecioDolares.Text = Me.gvServicio.Items(Me.gvServicio.SelectedItemIndex).Cells(4).Value.ToString()
        Me.txtJuniorColones.Text = Me.gvServicio.Items(Me.gvServicio.SelectedItemIndex).Cells(5).Value.ToString()
        Me.txtJuniorDolares.Text = Me.gvServicio.Items(Me.gvServicio.SelectedItemIndex).Cells(6).Value.ToString()
        Me.txtSeniorColones.Text = Me.gvServicio.Items(Me.gvServicio.SelectedItemIndex).Cells(7).Value.ToString()
        Me.txtSeniorDolares.Text = Me.gvServicio.Items(Me.gvServicio.SelectedItemIndex).Cells(8).Value.ToString()
        Me.txtMasterColones.Text = Me.gvServicio.Items(Me.gvServicio.SelectedItemIndex).Cells(9).Value.ToString()
        Me.txtMasterDolares.Text = Me.gvServicio.Items(Me.gvServicio.SelectedItemIndex).Cells(10).Value.ToString()

    End Sub
    'AQUIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIISDFSDGFDASG
    ''' <summary>
    ''' Método d clase, encargado de hacer visible componentes
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub visibleControl()
        modificarServicio.Visible = True
    End Sub

    ''' <summary>
    ''' Método d clase, encargado de hacer invisible componentes
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub QuitarControles()
        modificarServicio.Visible = False
    End Sub

    ''' <summary>
    ''' Método de clase, encarga de evaluar que no queden espacios en blanco ningún componente
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Protected Function validarDatos() As Boolean
        If txtId.Text.Equals("") Then
            Response.Write("<script language='javascript' type='text/javascript'> alert('El identificador del servicio es un dato requerido');</script>")
            Me.txtId.Focus()
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

    

    Protected Sub bntConfirmarModificacion_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles bntConfirmarModificacion.Click
        Dim _resul As Boolean = validarDatos()
        If _resul Then

            Try
                _gestor.modificarservicio(Me.txtId.Text, Me.txtNombre.Text, Me.txtDescripcion.Text, CDbl(Me.txtPrecioColones.Text), CDbl(Me.txtPrecioDolares.Text), CDbl(Me.txtJuniorColones.Text), CDbl(Me.txtJuniorDolares.Text), CDbl(Me.txtSeniorColones.Text), CDbl(Me.txtSeniorDolares.Text), CDbl(Me.txtMasterColones.Text), CDbl(Me.txtMasterDolares.Text)) 'invocar el método indicado enviando los argumentos requeridos.
                Response.Write("<script language='javascript' type='text/javascript'> alert('Servicio Modificado');</script>")
                QuitarControles()

            Catch ex As Exception
                Response.Write("<script language='javascript' type='text/javascript'> alert('Error - Funcion btnConfirmarModificacion_Click() en frmBuscarModificarServicio.aspx.vb');</script>")
            End Try
        End If
        cargarServicios()
    End Sub



   
End Class