Imports CllLogicaNegocio

Partial Public Class BuscarModificarGrupo
    Inherits System.Web.UI.Page

    Dim _gestor As New ClsGestor() 'declara e instancia de la clase Gestor
    Dim _listaGrupo As List(Of Array) = New List(Of Array)
    Dim _tempArray As Array 'declarar una variable tipo Array
    Dim _criterio As String
    Dim _idGrupo As String
    Dim _listaServicios As ArrayList = New ArrayList()
    Dim _listaVendedores As ArrayList = New ArrayList()

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.txtCriterio.Focus()
        If Not IsPostBack Then
            Me.txtCriterio.Focus()
            cargarGrupos()
            Derecha.Visible = False
        End If
    End Sub

    Public Sub cargarGrupos()
        Try
            Dim _listTemp As New List(Of ClsCastCadenaGrupo) 'declarar una variable tipo lista genérica tipo clsCastCadena (Wrapper)
            Dim _tempCast() As String 'declarar una variable tipo arreglo de String

            _listaGrupo = _gestor.listarGrupos() 'asignar el resultado de la búsqueda devuelto por un método del Gestor

            For i As Integer = 0 To _listaGrupo.Count - 1 'estructura iterativa tipo matriz para recorrer y envolver por el tipo adecuado

                _tempArray = _listaGrupo(i) 'clonar a un Array temporal la FILA (ROW) de la consulta
                ReDim _tempCast(_tempArray.Length() - 1) 'redimensionar el arreglo a un tamaño indicado

                For j As Integer = 0 To _tempArray.Length - 1 'recorrer la parte interna de la matriz, columna (COLUMN)
                    _tempCast(j) = _tempArray.GetValue(j).ToString() 'asignar el valor de cada celda 
                Next

                _listTemp.Add(New ClsCastCadenaGrupo(_tempCast(0).ToString(), _tempCast(1).ToString(), _tempCast(2).ToString())) 'agregar a la lista genérica una colección de la clase wrapper

            Next

            Me.gridGrupo.DataSource = _listTemp 'asignar el fuente de dato para un control tipo datagridview la lista genérica wrappeada
            Me.gridGrupo.DataBind()
            Me.gridGrupo.SelectedItemIndex = 0
        Catch ex As Exception
            MsgBox("Error en la operación ... " & ex.Message)
        End Try
    End Sub

    Protected Sub btnBuscar_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btnBuscar.Click

        If Me.txtCriterio.Text = "" Then
            cargarGrupos()
        Else
            _criterio = Me.txtCriterio.Text
            buscarGrupoXCod(_criterio)
        End If
    End Sub

    Public Sub buscarGrupoXCod(ByVal pcod As String)
        Try
            Dim _listTemp As New List(Of ClsCastCadenaGrupo) 'declarar una variable tipo lista genérica tipo clsCastCadena (Wrapper)
            Dim _tempCast() As String 'declarar una variable tipo arreglo de String

            _listaGrupo = _gestor.buscarGrupoDeVentaReturnArray(pcod) 'asignar el resultado de la búsqueda devuelto por un método del Gestor

            For i As Integer = 0 To _listaGrupo.Count - 1 'estructura iterativa tipo matriz para recorrer y envolver por el tipo adecuado

                _tempArray = _listaGrupo(i) 'clonar a un Array temporal la FILA (ROW) de la consulta
                ReDim _tempCast(_tempArray.Length() - 1) 'redimensionar el arreglo a un tamaño indicado

                For j As Integer = 0 To _tempArray.Length - 1 'recorrer la parte interna de la matriz, columna (COLUMN)
                    _tempCast(j) = _tempArray.GetValue(j).ToString() 'asignar el valor de cada celda 
                Next

                _listTemp.Add(New ClsCastCadenaGrupo(_tempCast(0).ToString(), _tempCast(1).ToString(), _tempCast(2).ToString())) 'agregar a la lista genérica una colección de la clase wrapper

            Next

            Me.gridGrupo.DataSource = _listTemp 'asignar el fuente de dato para un control tipo datagridview la lista genérica wrappeada
            Me.gridGrupo.DataBind()

        Catch ex As Exception
            MsgBox("Error en la operación ... " & ex.Message)
        End Try

    End Sub

    Protected Sub btnEliminar_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btnEliminar.Click
        _idGrupo = (gridGrupo.Items(gridGrupo.SelectedItemIndex).Cells(0).Value)
        Try
            _gestor.eliminarGrupoDeVenta(_idGrupo) 'invocar el método indicado enviando los argumentos requeridos.
            MsgBox("Los datos del grupo de ventas se han eliminado correctamente.", MsgBoxStyle.Information, "Eliminar grupo de ventas")
            cargarGrupos()
        Catch ex As Exception
            MsgBox("Los datos del grupo de ventas no se pueden eliminar." & vbCrLf & ex.Message, MsgBoxStyle.Information, "Eliminar grupo de ventas")
        End Try
    End Sub

    Protected Sub btnModificar_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btnModificar.Click
        modificar()
    End Sub

    Public Sub modificar()

        Derecha.Visible = True

        With Me
            .txtCodigo.Text = (gridGrupo.Items(gridGrupo.SelectedItemIndex).Cells(0).Value)
            .txtCodigo.Enabled = False
            .txtDescripcion.Text = (gridGrupo.Items(gridGrupo.SelectedItemIndex).Cells(1).Value)
            .txtDescripcion.Enabled = False
            cargarEncargados()
            cargarServicios()
            cargarVendedores()
            cargarServiciosDelGrupo()
            cargarVendedoresDelGrupo()
        End With
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
            Me.DdlEncargado.DataSource = _listTemp
            Me.DdlEncargado.DataTextField = "nombreCompleto"
            Me.DdlEncargado.DataValueField = "cedula"
            Me.DdlEncargado.DataBind()
            Me.DdlEncargado.SelectedValue = (gridGrupo.Items(gridGrupo.SelectedItemIndex).Cells(2).Value)

        Catch ex As Exception
            MsgBox("Error en la operación ... " & ex.Message)
        End Try
    End Sub

    Private Sub cargarServicios()
        Try
            Dim _listaServicios As List(Of Array) = New List(Of Array)() 'declarar una variable tipo lista genérica de Array

            _listaServicios = _gestor.buscarServicioDispParaGrupo((gridGrupo.Items(gridGrupo.SelectedItemIndex).Cells(0).Value)) 'asignar el resultado de la búsqueda devuelto por un método del Gestor

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
            Me.GridServicioDisp.DataSource = _listTemp
            Me.GridServicioDisp.DataBind()

        Catch ex As Exception
            MsgBox("Error en la operación ... " & ex.Message)
        End Try
    End Sub

    Private Sub cargarVendedores()
        Try
            Dim _listaVendedores As List(Of Array) = New List(Of Array)() 'declarar una variable tipo lista genérica de Array

            _listaVendedores = _gestor.buscarVendedorDispParaGrupo((gridGrupo.Items(gridGrupo.SelectedItemIndex).Cells(0).Value)) 'asignar el resultado de la búsqueda devuelto por un método del Gestor

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
            Me.gridVendedorDisp.DataSource = _listTemp
            Me.gridVendedorDisp.DataBind()

        Catch ex As Exception
            MsgBox("Error en la operación ... " & ex.Message)
        End Try
    End Sub

    Private Sub cargarServiciosDelGrupo()
        Try
            Dim _listaServicios As List(Of Array) = New List(Of Array)() 'declarar una variable tipo lista genérica de Array

            _listaServicios = _gestor.buscarServiciosDeUnGrupoDeVentas(gridGrupo.Items(gridGrupo.SelectedItemIndex).Cells(0).Value) 'asignar el resultado de la búsqueda devuelto por un método del Gestor

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
            Me.gridServicio.DataSource = _listTemp
            Me.gridServicio.DataBind()

        Catch ex As Exception
            MsgBox("Error en la operación ... " & ex.Message)
        End Try
    End Sub

    Private Sub cargarVendedoresDelGrupo()
        Try
            Dim _listaVendedores As List(Of Array) = New List(Of Array)() 'declarar una variable tipo lista genérica de Array

            _listaVendedores = _gestor.buscarUsuariosDeUnGrupoDeVentas(gridGrupo.Items(gridGrupo.SelectedItemIndex).Cells(0).Value) 'asignar el resultado de la búsqueda devuelto por un método del Gestor

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
            Me.gridVendedor.DataSource = _listTemp
            Me.gridVendedor.DataBind()

        Catch ex As Exception
            MsgBox("Error en la operación ... " & ex.Message)
        End Try
    End Sub

    Protected Sub btnmodificar2_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btnmodificar2.Click
        Dim result As Boolean = evaluarEspacio()

        If result Then
            Dim _codigo As String = Me.txtCodigo.Text
            Dim _descipcion As String = Me.txtDescripcion.Text
            Dim _idEncargago As String = DdlEncargado.SelectedValue.ToString()

            Try

                _gestor.modificarGrupoDeVenta(_codigo, _descipcion, _idEncargago)
                MsgBox("Los datos del grupo de ventas se han modificado correctamente.", MsgBoxStyle.Information, "Modificar grupo de ventas")
                cargarGrupos()
                Derecha.Visible = False
            Catch ex As Exception
                MsgBox("Los datos del grupo de ventas no se pueden modificar." & vbCrLf & ex.Message, MsgBoxStyle.Information, "Modificar grupo de ventas")
            End Try
        End If
    End Sub

    Public Function evaluarEspacio() As Boolean
        Dim _resul As Boolean = False

        If Me.txtDescripcion.Text = "" Then
            MsgBox("La descripción del grupo de ventas es un dato requerido")
            Me.txtDescripcion.Focus()
        Else
            _resul = True
        End If
        Return _resul
    End Function

    Protected Sub btnAgregarServicio_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btnAgregarServicio.Click

        Try
            _gestor.agregarServicioAGrupoDeVenta(gridGrupo.Items(gridGrupo.SelectedItemIndex).Cells(0).Value, GridServicioDisp.Items(GridServicioDisp.SelectedItemIndex).Cells(0).Value)
            MsgBox("Los datos del servicio se han agregado al grupo de ventas correctamente.", MsgBoxStyle.Information, "Agregar servicio a grupo de ventas")
            cargarServicios()
            cargarServiciosDelGrupo()
        Catch ex As Exception
            MsgBox("Los datos del servicio no se han agregado al grupo de ventas." & vbCrLf & ex.Message, MsgBoxStyle.Information, "Agregar servicio a grupo de ventas")
        End Try
    End Sub

    Protected Sub btnRemoverServicio_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btnRemoverServicio.Click

        If gridServicio.Items.Count > 1 Then

            Try
                _gestor.eliminarServicioDeUnGrupoDeVenta(Me.txtCodigo.Text, gridServicio.Items(gridServicio.SelectedItemIndex).Cells(0).Value)
                MsgBox("Los datos del servicio se han eliminado del grupo de ventas correctamente.", MsgBoxStyle.Information, "Eliminar servicio a grupo de ventas")
                cargarServicios()
                cargarServiciosDelGrupo()
            Catch ex As Exception
                MsgBox("Los datos del servicio no se han eliminado del grupo de ventas." & vbCrLf & ex.Message, MsgBoxStyle.Information, "Eliminar servicio a grupo de ventas")
            End Try
        End If
    End Sub

    Protected Sub btnAgregarVendedor_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btnAgregarVendedor.Click
        Try
            _gestor.agregarVendedorAGrupoDeVenta(gridGrupo.Items(gridGrupo.SelectedItemIndex).Cells(0).Value, gridVendedorDisp.Items(gridVendedorDisp.SelectedItemIndex).Cells(0).Value)
            MsgBox("Los datos del vendedor se han agregado al grupo de ventas correctamente.", MsgBoxStyle.Information, "Agregar vendedor a grupo de ventas")
            cargarVendedores()
            cargarVendedoresDelGrupo()
        Catch ex As Exception
            MsgBox("Los datos del vendedor no se han agregado al grupo de ventas." & vbCrLf & ex.Message, MsgBoxStyle.Information, "Agregar vendedor a grupo de ventas")
        End Try
    End Sub

    Protected Sub btnRemoverVendedor_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btnRemoverVendedor.Click
        If gridVendedor.Items.Count > 1 Then

            Try
                _gestor.eliminarVendedorDeUnGrupoDeVenta(gridGrupo.Items(gridGrupo.SelectedItemIndex).Cells(0).Value, gridVendedor.Items(gridVendedor.SelectedItemIndex).Cells(0).Value)
                MsgBox("Los datos del vendedor se han eliminado del grupo de ventas correctamente.", MsgBoxStyle.Information, "Eliminar vendedor a grupo de ventas")
                cargarVendedoresDelGrupo()
                cargarVendedores()
            Catch ex As Exception
                MsgBox("Los datos del vendedor no se han eliminado del grupo de ventas." & vbCrLf & ex.Message, MsgBoxStyle.Information, "Eliminar vendedor a grupo de ventas")
            End Try
        End If
    End Sub
End Class