Imports CllLogicaNegocio.ClsGestor
Partial Public Class frmBuscarPlanVenta
    Inherits System.Web.UI.Page
    Dim _gestor As New CllLogicaNegocio.ClsGestor() 'declaración e instanciación de la clase Gestor
    Dim _servicioVentasPlaneadas As New List(Of ArrayList)
    Dim _datosServiciosPlanes As New List(Of ArrayList)

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim request As String = Me.Request.Params("__EVENTTARGET") + ""
        If Not request = "" And request.Contains(",") Then

            Dim datos As String() = request.Split(",")

            Dim codServicio As String = datos(0)
            Dim accion As String = datos(1)

            If accion.Equals("remover") Then
                removerServicio(codServicio)
            Else
                Dim cantVentas As Integer = datos(2)
                agregarServicio(codServicio, cantVentas)
            End If

        End If
        If Not IsPostBack Then
            cargarPlanes()
        End If
    End Sub

    '''<summary>
    '''Método de clase, encarga de evaluar que la fecha inicio no sea mayor a la fecha fin ningun componente
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function evaluarFechas() As Boolean
        Dim _resul As Boolean

        If dtpInicio.SelectedDate >= dtpFechaFin.SelectedDate Then
            MsgBox("La fecha inicio debe ser menor que la fecha fin ", MsgBoxStyle.Information, "Buscar Plan de Ventas")
        Else
            _resul = True
        End If
        Return _resul
    End Function

    '''<summary>
    '''Método de clase, encarga de evaluar que no queden espacios en blanco ningun componente
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    'Public Function evaluarEspacio() As Boolean
    '    Dim _resul As Boolean
    '    If ltbServiciosSinPlan.Items.Count = 0 Then
    '        MsgBox("Debe de insertar un servicio al plan de ventas", MsgBoxStyle.Information, "Aviso")
    '    Else
    '        _resul = True
    '    End If
    '    Return _resul
    'End Function
    Protected Sub dtpInicio_SelectionChanged(ByVal sender As Object, ByVal e As EventArgs) Handles dtpInicio.SelectionChanged
        If dtpInicio.SelectedDate.Equals("") Then
            cargarPlanes()

        Else
            Me.gridPlanVenta.DataSource = ""
        End If

        modificarServicio.Visible = False
    End Sub

    Protected Sub dtpFechaFin_SelectionChanged(ByVal sender As Object, ByVal e As EventArgs) Handles dtpFechaFin.SelectionChanged
        If dtpInicio.SelectedDate.Equals("") Then
            cargarPlanes()
        Else
            Me.gridPlanVenta.DataSource = ""
        End If
        modificarServicio.Visible = False
    End Sub

   
    Protected Sub bntBuscar_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles bntBuscar.Click
        Dim _resul As Boolean = evaluarFechas()
        Dim _fechaInicio As Date
        Dim _fechaFin As Date
        If _resul Then
            _fechaInicio = dtpInicio.SelectedDate
            _fechaFin = dtpFechaFin.SelectedDate
            buscarPlanPorFecha(_fechaInicio, _fechaFin)
        End If
        modificarServicio.Visible = False
    End Sub

    ''' <summary>
    ''' Método de clase, encargado de cargar todos los planes existentes en la DB
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub cargarPlanes()
        Try
            Dim _listTemp As New List(Of ClsCastCadenaPlanVenta) 'declarar una variable tipo lista genérica tipo clsCastCadena (Wrapper)
            Dim _tempCast() As String 'declarar una variable tipo arreglo de String
            Dim _listaPlan As List(Of Array) = New List(Of Array)() 'declarar una variable tipo lista genérica de Array
            Dim _tempArray As Array 'declarar una variable tipo Array

            _listaPlan = _gestor.listarPlanes() 'asignar el resultado de la búsqueda devuelto por un método del Gestor

            For i As Integer = 0 To _listaPlan.Count - 1 'estructura iterativa tipo matriz para recorrer y envolver por el tipo adecuado

                _tempArray = _listaPlan(i) 'clonar a un Array temporal la FILA (ROW) de la consulta
                ReDim _tempCast(_tempArray.Length() - 1) 'redimensionar el arreglo a un tamaño indicado

                For j As Integer = 0 To _tempArray.Length - 1 'recorrer la parte interna de la matriz, columna (COLUMN)
                    _tempCast(j) = _tempArray.GetValue(j).ToString() 'asignar el valor de cada celda 
                Next

                _listTemp.Add(New ClsCastCadenaPlanVenta(_tempCast(0).ToString(), _tempCast(1).ToString(), _tempCast(2).ToString(), _tempCast(3).ToString())) 'agregar a la lista genérica una colección de la clase wrapper

            Next

            Me.gridPlanVenta.DataSource = _listTemp 'asignar el fuente de dato para un control tipo datagridview la lista genérica wrappeada
            Me.gridPlanVenta.DataBind()

        Catch ex As Exception
            MsgBox("Error en la operación ... " & ex.Message, MsgBoxStyle.Information, "Buscar Plan de Ventas")
        End Try
    End Sub


    '''' <summary>
    ''''Funcion que crea un DataTable con los datos que le pasemos por parametro.
    '''' </summary>
    '''' <remarks></remarks>
    'Function getDataTable(ByVal pdatos As List(Of ClsCastCadenaPlanVenta)) As DataTable

    '    'Creamos el DataTable.
    '    Dim dt As New DataTable()

    '    'Definimos el nombre de las columnas.
    '    dt.Columns.Add(New DataColumn("Id", GetType(String)))
    '    dt.Columns.Add(New DataColumn("Descripción", GetType(String)))
    '    dt.Columns.Add(New DataColumn("Fecha Inicio", GetType(Date)))
    '    dt.Columns.Add(New DataColumn("Fecha Fin", GetType(Date)))
    '    ' Create the four records
    '    For Each planVenta As ClsCastCadenaPlanVenta In pdatos
    '        Dim dr As DataRow = dt.NewRow()
    '        dr("Id") = planVenta.idPlanVenta
    '        dr("Descripción") = planVenta.descripcion
    '        dr("Fecha Inicio") = planVenta.fechaInicio
    '        dr("Fecha Fin") = planVenta.fechaFin
    '        dt.Rows.Add(dr)
    '    Next
    '    Return dt
    'End Function

    ''' <summary>
    ''' Método de clase, encargado de cargar todos los planes existentes en la DB suministrando un rango de fechas
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub buscarPlanPorFecha(ByVal pfechaInicio As Date, ByVal pfechaFin As Date)
        Try
            Dim _listTemp As New List(Of ClsCastCadenaPlanVenta) 'declarar una variable tipo lista genérica tipo clsCastCadena (Wrapper)
            Dim _tempCast() As String 'declarar una variable tipo arreglo de String
            Dim _listaPlan As List(Of Array) = New List(Of Array)() 'declarar una variable tipo lista genérica de Array
            Dim _tempArray As Array 'declarar una variable tipo Array

            _listaPlan = _gestor.buscarPlanVentaPorFecha(pfechaInicio, pfechaFin) 'asignar el resultado de la búsqueda devuelto por un método del Gestor

            For i As Integer = 0 To _listaPlan.Count - 1 'estructura iterativa tipo matriz para recorrer y envolver por el tipo adecuado

                _tempArray = _listaPlan(i) 'clonar a un Array temporal la FILA (ROW) de la consulta
                ReDim _tempCast(_tempArray.Length() - 1) 'redimensionar el arreglo a un tamaño indicado

                For j As Integer = 0 To _tempArray.Length - 1 'recorrer la parte interna de la matriz, columna (COLUMN)
                    _tempCast(j) = _tempArray.GetValue(j).ToString() 'asignar el valor de cada celda 
                Next

                _listTemp.Add(New ClsCastCadenaPlanVenta(_tempCast(0).ToString(), _tempCast(1).ToString(), _tempCast(2).ToString(), _tempCast(3).ToString())) 'agregar a la lista genérica una colección de la clase wrapper

            Next

            Me.gridPlanVenta.DataSource = _listTemp 'asignar el fuente de dato para un control tipo datagridview la lista genérica wrappeada
            Me.gridPlanVenta.DataBind()

        Catch ex As Exception
            MsgBox("Error en la operación ... " & ex.Message, MsgBoxStyle.Information, "Buscar Plan de Ventas")
        End Try

    End Sub

    ''' <summary>
    ''' Método de clase, encargado de cargar todos los servicios que tiene el plan existentes en la DB 
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub cargarPlanServicios()
        Try
            Dim _listaServicios As List(Of Array) = New List(Of Array)() 'declarar una variable tipo lista genérica de Array

            _listaServicios = _gestor.buscarPlanVentaServicio(Me.txtId.Text) 'asignar el resultado de la búsqueda devuelto por un método del Gestor

            'Limpiamos todos los elementos cada vez que carguemos un nuevo plan de venta.
            ltbserviciosPlan.Items.Clear()

            For i As Integer = 0 To _listaServicios.Count - 1
                Dim tempItem As EO.Web.GridItem = ltbserviciosPlan.CreateItem()
                tempItem.Cells("Id").Value = _listaServicios(i)(0)
                tempItem.Cells("Nombre").Value = _listaServicios(i)(1)
                tempItem.Cells("CantVentas").Value = CType(_listaServicios(i)(12), Integer)
                ltbserviciosPlan.Items.Add(tempItem)
            Next

            cargarServicioSinPlan(Me.txtId.Text)


        Catch ex As Exception
            MsgBox("Error en la operación ... " & ex.Message, MsgBoxStyle.Information, "Buscar Plan de Ventas")
        End Try
    End Sub
    ''' <summary>
    ''' Método de clase, encargado de cargar todos los servicios que no tiene el plan existentes en la DB 
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub cargarServicioSinPlan(ByRef pid As String)
        Try
            Dim _listaServicios As List(Of Array) = New List(Of Array)() 'declarar una variable tipo lista genérica de Array

            _listaServicios = _gestor.buscarServicioSinPlan(pid) 'asignar el resultado de la búsqueda devuelto por un método del Gestor

            For i As Integer = 0 To _listaServicios.Count - 1
                Dim tempItem As EO.Web.GridItem = ltbServicios.CreateItem()
                tempItem.Cells("Id").Value = _listaServicios(i)(0)
                tempItem.Cells("Nombre").Value = _listaServicios(i)(1)
                ltbServicios.Items.Add(tempItem)
            Next
        Catch ex As Exception
            MsgBox("Error en la operación ... " & ex.Message, MsgBoxStyle.Information, "Buscar Plan de Ventas")
        End Try
    End Sub

    Private Function obtenerServicioPlan(ByVal nomServicio As String) As Integer
        Dim contador As Integer = 0
        For Each i As ArrayList In _datosServiciosPlanes
            If CStr(i(2)).Equals(nomServicio) Then
                Return contador
            End If
            contador += 1
        Next
    End Function

    'Protected Sub ltbServicios_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ltbServicios.SelectedIndexChanged
    'Dim nomServicio As String = ltbServicios.SelectedItem.ToString
    'Dim dato As ArrayList = Me._datosServiciosPlanes(obtenerServicioPlan(nomServicio))
    'txtVentasPlaneadas.Text = dato(1)

    'End Sub

    Protected Sub bntEliminar_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles bntEliminar.Click
        Dim _idPlan As String = Me.gridPlanVenta.Items(gridPlanVenta.SelectedItemIndex).Cells("idPlanVenta").Value

        Try
            _gestor.eliminarPlanVenta(_idPlan) 'invocar el método indicado enviando los argumentos requeridos.
            MsgBox("Los datos del plan de ventas se han eliminado.", MsgBoxStyle.Information, "Eliminar plan de ventas")

        Catch ex As Exception
            MsgBox("Los datos del plan de ventas no se pueden eliminar." & ex.Message, MsgBoxStyle.Information, "Eliminar plan de ventas")
        End Try
        cargarPlanes()

    End Sub

    Protected Sub bntModificar_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles bntModificar.Click
        txtId.Text = Me.gridPlanVenta.Items(gridPlanVenta.SelectedItemIndex).Cells("idPlanVenta").Value
        txtDescripcion.InnerText = Me.gridPlanVenta.Items(gridPlanVenta.SelectedItemIndex).Cells("descripcion").Value
        txtFechaInicio.Text = Me.gridPlanVenta.Items(gridPlanVenta.SelectedItemIndex).Cells("fechaInicio").Value
        txtFechaFin.Text = Me.gridPlanVenta.Items(gridPlanVenta.SelectedItemIndex).Cells("fechaFin").Value
        cargarPlanServicios()
        modificarServicio.Visible = True
    End Sub


    Protected Sub agregarServicio(ByRef pcodServicio As String, ByRef pcantVentas As String)
        _gestor.modificarPlanVentaServicio(txtId.Text, pcodServicio, pcantVentas)
    End Sub


    Protected Sub removerServicio(ByRef pcodServicio As String)
        _gestor.eliminarPlanVentaServicio(txtId.Text, pcodServicio)
    End Sub



End Class