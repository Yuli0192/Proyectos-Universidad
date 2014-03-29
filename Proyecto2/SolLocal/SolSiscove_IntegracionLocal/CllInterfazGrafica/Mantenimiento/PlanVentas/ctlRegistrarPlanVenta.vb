Imports CllLogicaNegocio.ClsGestor
Public Class ctlRegistrarPlanVenta
    Dim _gestor As New CllLogicaNegocio.ClsGestor() 'declara e instancia de la clase Gestor
    'declarar variables globales
    Dim _resul As Boolean
    Dim _servicioVentasPlaneadas As New List(Of ArrayList)

    Private Sub frmRegistrarPlan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.txtid.Focus()
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
            Me.ltbServicio.DataSource = _listTemp
            Me.ltbServicio.DisplayMember = "nombre"
            Me.ltbServicio.ValueMember = "codServicio"

        Catch ex As Exception
            MsgBox("Error en la operación ... " & ex.Message, MsgBoxStyle.Information, "Registrar Plan de Ventas")
        End Try
    End Sub
    ''' <summary>
    ''' Método de clase, encarga de limpiar los componentes 
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub limpiarForm()
        With Me
            .txtid.Text = ""
            .txtDescripcion.Text = ""
            .ltbPlanServicio.Items.Clear()
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

        ElseIf dtpInicio.Value > dtpFin.Value Then
            MsgBox("La fecha inicio debe ser menor q la fecha fin ", MsgBoxStyle.Information, "Registrar Plan de Ventas")

        ElseIf ltbPlanServicio.Items.Count = 0 Then
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

    ''' <summary>
    ''' Método de clase, encarga de evaluar que la cantidad ventas  tenga el formato correcto
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function evaluarVenta() As Boolean
        Dim _numero As Boolean
        _numero = IsNumeric(txtVentasPlaneadas.Text)
        Return _numero
    End Function

    Private Sub pbInsertar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbInsertar.Click
        Dim _numero As Boolean
        Dim _datosServicioPlan As New ArrayList
        If Not txtVentasPlaneadas.Text.Equals("") Then
            If _numero = evaluarVenta() Then 'Valida el formato 

                MsgBox("La cantidad venta planeada debe ser solo número", MsgBoxStyle.Information, "Modificar cliente")
                Me.txtVentasPlaneadas.SelectAll()

            Else
                For Each i In ltbServicio.SelectedIndices
                    _datosServicioPlan.Add(CType(ltbServicio.Items(i), ClsCastCadenaServicio).codServicio) 'Agregamos el código del servicio.
                    _datosServicioPlan.Add(txtVentasPlaneadas.Text) 'Agregamos las ventas planeadas del servicio.

                    _servicioVentasPlaneadas.Add(_datosServicioPlan) 'Agregamos el servicio con sus datos.

                    ltbPlanServicio.Items.Add(ltbServicio.Items(i))
                    ltbPlanServicio.DisplayMember = "nombre"
                    ltbPlanServicio.ValueMember = "codServicio"

                    Dim _listTemp As List(Of ClsCastCadenaServicio) = CType(ltbServicio.DataSource, List(Of ClsCastCadenaServicio))
                    _listTemp.RemoveAt(i)

                    Dim _listTemp2 As New List(Of ClsCastCadenaServicio)
                    For x As Integer = 0 To _listTemp.Count - 1
                        _listTemp2.Add(_listTemp.Item(x))
                    Next

                    ltbServicio.DataSource = _listTemp2
                    ltbServicio.DisplayMember = "Nombre"
                    ltbServicio.ValueMember = "codServicio"
                    ltbServicio.Refresh()

                    txtVentasPlaneadas.Text = ""
                Next
            End If
        ElseIf txtVentasPlaneadas.Text = "" Then
            MsgBox("Debe ingresar la cantidad de ventas planeadas para agregar el servicio al plan.", MsgBoxStyle.Information, "Registrar Plan de Ventas")
            txtVentasPlaneadas.Focus()
        End If
    End Sub

    Private Sub pbRegresarServicio_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbRegresarServicio.Click
        For Each i In ltbPlanServicio.SelectedIndices

            Dim _listTemp As List(Of ClsCastCadenaServicio) = CType(ltbServicio.DataSource, List(Of ClsCastCadenaServicio))
            _listTemp.Add(ltbPlanServicio.Items(i))

            Dim _listTemp2 As New List(Of ClsCastCadenaServicio)

            For x As Integer = 0 To _listTemp.Count - 1
                _listTemp2.Add(_listTemp.Item(x))
            Next

            ltbServicio.DataSource = _listTemp2
            ltbServicio.DisplayMember = "nombre"
            ltbServicio.ValueMember = "codServicio"
            'Removemos el servicio de la lista
            _servicioVentasPlaneadas.RemoveAt(obtenerServicioPlan(CType(ltbPlanServicio.Items(i), ClsCastCadenaServicio)))

            ltbPlanServicio.Items.RemoveAt(i)

        Next
    End Sub
    ''' <summary>
    ''' Método de clase, encargado de registrar los datos del plan de ventas 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub pbRegistrar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbRegistrar.Click
        _resul = evaluarEspacio()

        If _resul Then

            Dim _idPlan As String = Me.txtid.Text
            Dim _descripcion As String = Me.txtDescripcion.Text
            Dim _fechaInicio As Date = Me.dtpInicio.Value
            Dim _fechaFin As Date = Me.dtpFin.Value

            Try
                _gestor.registrarPlanVentas(_idPlan, _descripcion, _fechaInicio, _fechaFin, _servicioVentasPlaneadas) 'invocar el método indicado enviando los argumentos requeridos.
                MsgBox("Los datos del plan de ventas se han registrado correctamente.", MsgBoxStyle.Information, "Registrar Plan de Ventas")
                Me.limpiarForm() 'invocar a la subrutina dedicada a limpiar los controles indicados.

            Catch ex As Exception
                MsgBox("Los datos ingresados ya existen en la base de datos." & ex.Message, MsgBoxStyle.Information, "Registrar Plan de Ventas")
            End Try
        End If
    End Sub

    Private Sub pbLimpiar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbLimpiar.Click
        limpiarForm()
    End Sub
End Class
