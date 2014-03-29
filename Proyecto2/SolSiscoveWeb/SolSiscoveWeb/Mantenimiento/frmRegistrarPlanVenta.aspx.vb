Imports CllLogicaNegocio.ClsGestor
Partial Public Class frmRegistrarPlanVenta
    Inherits System.Web.UI.Page
    Dim _servicioVentasPlaneadas As New List(Of ArrayList)
    Dim _gestor As New CllLogicaNegocio.ClsGestor

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.txtId.Focus()
        cargarServicios()
    End Sub

    ''' <summary>
    ''' Método de clase, encargado de cargar todos los servicios existentes en la DB
    ''' </summary>
    ''' <remarks></remarks>
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
            Me.ltbServicios.DataSource = getDataTable(_listTemp)
            Me.ltbServicios.DataBind()
        Catch ex As Exception
            MsgBox("Error en la operación ... " & ex.Message, MsgBoxStyle.Information, "Registrar Plan de Ventas")
        End Try
    End Sub

    'Funcion que crea un DataTable con los datos que le pasemos por parametro.
    Function getDataTable(ByVal pdatos As List(Of ClsCastCadenaServicio)) As DataTable

        'Creamos el DataTable.
        Dim dt As New DataTable()

        'Dim _id As String
        'Dim _nombre As String
        dt.Columns.Add(New DataColumn("Id", GetType(String)))
        dt.Columns.Add(New DataColumn("Nombre", GetType(String)))
        ' Create the four records
        For Each servicio As ClsCastCadenaServicio In pdatos
            Dim dr As DataRow = dt.NewRow()
            dr("Id") = servicio.codServicio
            dr("Nombre") = servicio.nombre
            dt.Rows.Add(dr)
        Next
        Return dt
    End Function

    ''' <summary>
    ''' Método de clase, encarga de limpiar los componentes 
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub limpiarForm()
        With Me
            .txtid.Text = ""
            .txtDescripcion.Text = ""
            .ltbserviciosPlan.Items.Clear()
        End With

    End Sub

    ''' <summary>
    ''' Método de clase, encarga de evaluar que no queden espacios en blanco ningun componente
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function evaluarEspacio() As Boolean
        Dim _resul As Boolean

        If Me.txtid.Text = "" Then
            MsgBox("El identificador del plan de ventas es un dato requerido", MsgBoxStyle.Information, "Registrar Plan de Ventas")
            Me.txtid.Focus()

        ElseIf Me.txtDescripcion.Text = "" Then
            MsgBox("La descripción del plan de ventas es un dato requerido", MsgBoxStyle.Information, "Registrar Plan de Ventas")
            Me.txtDescripcion.Focus()

        ElseIf dtpFechaInicio.SelectedDate >= dtpFechaFin.SelectedDate Then
            MsgBox("La fecha inicio debe ser menor que la fecha fin ", MsgBoxStyle.Information, "Registrar Plan de Ventas")

        ElseIf ltbserviciosPlan.Items.Count = 0 Then
            MsgBox("Debe de insertar un servicio al plan de ventas", MsgBoxStyle.Information, "Registrar Plan de Ventas")

        Else
            _resul = True
        End If
        Return _resul
    End Function

    ''' <summary>
    ''' Método de clase, encarga de obtener la catidad de ventas planeadas de cada servicio
    ''' </summary>
    ''' <remarks></remarks>
    Private Function obtenerServicioPlan(ByVal servicio As ClsCastCadenaServicio) As Integer
        Dim contador As Integer = 0
        For Each i As ArrayList In _servicioVentasPlaneadas
            If CStr(i(0)).Equals(servicio.codServicio) Then
                Return contador
            End If
            contador += 1
        Next
    End Function

    Protected Sub bntRegistrar_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles bntRegistrar.Click
        Dim _resul As Boolean = evaluarEspacio()

        If _resul Then

            Dim _idPlan As String = Me.txtId.Text
            Dim _descripcion As String = Me.txtDescripcion.Text
            Dim _fechaInicio As Date = Me.dtpFechaInicio.SelectedDate
            Dim _fechaFin As Date = Me.dtpFechaFin.SelectedDate

            'Ahora vamos a obtener los servicios que se seleccionaron
            For i As Integer = 0 To ltbserviciosPlan.Items.Count - 1
                Dim datosServicio As New ArrayList
                datosServicio.Add(ltbserviciosPlan.Items(i).Cells(0).Value) 'Agregamos el Id del servicio
                datosServicio.Add(ltbserviciosPlan.Items(i).Cells(2).Value) 'Agregamos la cantidad de ventas.

                _servicioVentasPlaneadas.Add(datosServicio) 'Agregamos el servicio.
            Next

            'MsgBox(_fechaInicio & _fechaFin)
            Try
                _gestor.registrarPlanVentas(_idPlan, _descripcion, _fechaInicio, _fechaFin, _servicioVentasPlaneadas) 'invocar el método indicado enviando los argumentos requeridos.
                MsgBox("Los datos del plan de ventas se han registrado correctamente.", MsgBoxStyle.Information, "Registrar Plan de Ventas")
                Me.limpiarForm() 'invocar a la subrutina dedicada a limpiar los controles indicados.

            Catch ex As Exception
                MsgBox("Los datos ingresados ya existen en la base de datos." & ex.Message, MsgBoxStyle.Information, "Registrar Plan de Ventas")
            End Try
        End If
    End Sub

    Protected Sub bntLimpiar_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles bntLimpiar.Click
        limpiarForm()
    End Sub
End Class