Public Class ctlBuscarPlanVenta
    Dim _gestor As New CllLogicaNegocio.ClsGestor() 'declaración e instanciación de la clase Gestor
    Dim _listaPlan As List(Of Array) = New List(Of Array)() 'declarar una variable tipo lista genérica de Array
    Dim _result As DialogResult
    Dim _tempArray As Array 'declarar una variable tipo Array
    Dim _idPlan As String
    Dim _descripcion As String
    Dim _fechaInicio As Date
    Dim _fechaFin As Date
    Dim _idServicio As String
    Dim _cantPlaneada As Decimal
    Dim _servicioVentasPlaneadas As New List(Of ArrayList)

    Private Sub ctlBuscarPlanVenta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cargarPlanes()
    End Sub

    '''<summary>
    '''Método de clase, encarga de evaluar que la fecha inicio no sea mayor a la fecha fin ningun componente
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function evaluarFechas() As Boolean
        Dim _resul As Boolean

        If dtpInicio.Value > dtpFin.Value Then
            MsgBox("La fecha inicio debe ser menor q la fecha fin ", MsgBoxStyle.Information, "Buscar Plan de Ventas")
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
    Public Function evaluarEspacio() As Boolean
        Dim _resul As Boolean
        If ltbPlanServicio.Items.Count = 0 Then
            MsgBox("Debe de insertar un servicio al plan de ventas", MsgBoxStyle.Information, "Aviso")
        Else
            _resul = True
        End If
        Return _resul
    End Function
    Private Sub dtpInicio_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpInicio.ValueChanged
        gpbModificarPlan.Visible = False
        If dtpInicio.Text.Equals("") Then
            cargarPlanes()
        Else
            Me.dvgPlanVenta.DataSource = ""
        End If
    End Sub

    Private Sub dtpFin_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpFin.ValueChanged
        gpbModificarPlan.Visible = False
        If dtpFin.Text.Equals("") Then
            cargarPlanes()
        Else
            Me.dvgPlanVenta.DataSource = ""
        End If
    End Sub

    Private Sub pbBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbBuscar.Click
        Dim _resul As Boolean = evaluarFechas()

        If _resul Then
            _fechaInicio = dtpInicio.Text
            _fechaFin = dtpFin.Text
            buscarPlanPorFecha(_fechaInicio, _fechaFin)
        End If
    End Sub

    ''' <summary>
    ''' Método de clase, encargado de cargar todos los planes existentes en la DB
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub cargarPlanes()
        Try
            Dim _listTemp As New List(Of ClsCastCadenaPlanVenta) 'declarar una variable tipo lista genérica tipo clsCastCadena (Wrapper)
            Dim _tempCast() As String 'declarar una variable tipo arreglo de String

            _listaPlan = _gestor.listarPlanes() 'asignar el resultado de la búsqueda devuelto por un método del Gestor

            For i As Integer = 0 To _listaPlan.Count - 1 'estructura iterativa tipo matriz para recorrer y envolver por el tipo adecuado

                _tempArray = _listaPlan(i) 'clonar a un Array temporal la FILA (ROW) de la consulta
                ReDim _tempCast(_tempArray.Length() - 1) 'redimensionar el arreglo a un tamaño indicado

                For j As Integer = 0 To _tempArray.Length - 1 'recorrer la parte interna de la matriz, columna (COLUMN)
                    _tempCast(j) = _tempArray.GetValue(j).ToString() 'asignar el valor de cada celda 
                Next

                _listTemp.Add(New ClsCastCadenaPlanVenta(_tempCast(0).ToString(), _tempCast(1).ToString(), _tempCast(2).ToString(), _tempCast(3).ToString())) 'agregar a la lista genérica una colección de la clase wrapper

            Next

            Me.dvgPlanVenta.DataSource = _listTemp 'asignar el fuente de dato para un control tipo datagridview la lista genérica wrappeada

        Catch ex As Exception
            MsgBox("Error en la operación ... " & ex.Message, MsgBoxStyle.Information, "Buscar Plan de Ventas")
        End Try
    End Sub
    ''' <summary>
    ''' Método de clase, encargado de cargar todos los planes existentes en la DB suministrando un rango de fechas
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub buscarPlanPorFecha(ByVal pfechaInicio As Date, ByVal pfechaFin As Date)
        Try
            Dim _listTemp As New List(Of ClsCastCadenaPlanVenta) 'declarar una variable tipo lista genérica tipo clsCastCadena (Wrapper)
            Dim _tempCast() As String 'declarar una variable tipo arreglo de String

            _listaPlan = _gestor.buscarPlanVentaPorFecha(pfechaInicio, pfechaFin) 'asignar el resultado de la búsqueda devuelto por un método del Gestor

            For i As Integer = 0 To _listaPlan.Count - 1 'estructura iterativa tipo matriz para recorrer y envolver por el tipo adecuado

                _tempArray = _listaPlan(i) 'clonar a un Array temporal la FILA (ROW) de la consulta
                ReDim _tempCast(_tempArray.Length() - 1) 'redimensionar el arreglo a un tamaño indicado

                For j As Integer = 0 To _tempArray.Length - 1 'recorrer la parte interna de la matriz, columna (COLUMN)
                    _tempCast(j) = _tempArray.GetValue(j).ToString() 'asignar el valor de cada celda 
                Next

                _listTemp.Add(New ClsCastCadenaPlanVenta(_tempCast(0).ToString(), _tempCast(1).ToString(), _tempCast(2).ToString(), _tempCast(3).ToString())) 'agregar a la lista genérica una colección de la clase wrapper

            Next

            Me.dvgPlanVenta.DataSource = _listTemp 'asignar el fuente de dato para un control tipo datagridview la lista genérica wrappeada

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
            _servicioVentasPlaneadas.Clear()

            For i As Integer = 0 To _listaServicios.Count - 1
                Dim temArray As New ArrayList
                temArray.Add(_listaServicios(i)(0)) 'En la posicion 0 se encuaentra el codigo del servicio
                temArray.Add(_listaServicios(i)(12)) 'En la posicion 12 se encuentran la cantidad de ventas planeadas del servicio

                _servicioVentasPlaneadas.Add(temArray)
            Next
            Dim _tempArray As Array 'declarar una variable tipo Array

            Dim _listTemp As New List(Of ClsCastCadenaServicio) 'declarar una variable tipo lista genérica tipo clsCastCadenaServicio (Wrapper)

            Dim _tempCast() As String 'declarar una variable tipo arreglo de String

            'estructura iterativa tipo matriz para recorrer y envolver por el tipo adecuado
            For i As Integer = 0 To _listaServicios.Count - 1
                _tempArray = _listaServicios(i) 'clonar a un Array temporal la FILA (ROW) de la consulta

                ReDim _tempCast(_tempArray.Length() - 1) 'redimensionar el arreglo a un tamaño indicado

                'recorrer la parte interna de la matriz, columna (COLUMN)
                For j As Integer = 0 To _tempArray.Length - 1
                    _tempCast(j) = _tempArray.GetValue(j).ToString() 'asignar el valor de cada celda 
                Next
                _listTemp.Add(New ClsCastCadenaServicio(_tempCast(0).ToString(), _tempCast(1).ToString(), _tempCast(2).ToString(), _tempCast(3).ToString(), _tempCast(4).ToString(), _tempCast(5).ToString(), _tempCast(6).ToString(), _tempCast(7).ToString(), _tempCast(8).ToString(), _tempCast(9).ToString(), _tempCast(10).ToString(), _tempCast(11).ToString())) 'agregar a la lista genérica una colección de la clase wrapper
            Next

            'asignar el fuente de dato para un control tipo listbox la lista genérica wrappeada
            Me.ltbPlanServicio.DataSource = _listTemp
            Me.ltbPlanServicio.DisplayMember = "nombre"
            Me.ltbPlanServicio.ValueMember = "codServicio"

        Catch ex As Exception
            MsgBox("Error en la operación ... " & ex.Message, MsgBoxStyle.Information, "Buscar Plan de Ventas")
        End Try
    End Sub
    ''' <summary>
    ''' Método de clase, encargado de cargar todos los servicios que no tiene el plan existentes en la DB 
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub cargarServicioSinPlan()
        Try
            Dim _listaServicios As List(Of Array) = New List(Of Array)() 'declarar una variable tipo lista genérica de Array

            _listaServicios = _gestor.buscarServicioSinPlan(Me.txtId.Text) 'asignar el resultado de la búsqueda devuelto por un método del Gestor

            Dim _tempArray As Array 'declarar una variable tipo Array

            Dim _listTemp As New List(Of ClsCastCadenaServicio) 'declarar una variable tipo lista genérica tipo clsCastCadenaServicio (Wrapper)

            Dim _tempCast() As String 'declarar una variable tipo arreglo de String

            'estructura iterativa tipo matriz para recorrer y envolver por el tipo adecuado
            For i As Integer = 0 To _listaServicios.Count - 1
                _tempArray = _listaServicios(i) 'clonar a un Array temporal la FILA (ROW) de la consulta

                ReDim _tempCast(_tempArray.Length() - 1) 'redimensionar el arreglo a un tamaño indicado

                'recorrer la parte interna de la matriz, columna (COLUMN)
                For j As Integer = 0 To _tempArray.Length - 1
                    _tempCast(j) = _tempArray.GetValue(j).ToString() 'asignar el valor de cada celda 
                Next
                _listTemp.Add(New ClsCastCadenaServicio(_tempCast(0).ToString(), _tempCast(1).ToString(), _tempCast(2).ToString(), _tempCast(3).ToString(), _tempCast(4).ToString(), _tempCast(5).ToString(), _tempCast(6).ToString(), _tempCast(7).ToString(), _tempCast(8).ToString(), _tempCast(9).ToString(), _tempCast(10).ToString())) 'agregar a la lista genérica una colección de la clase wrapper
            Next

            'asignar el fuente de dato para un control tipo listbox la lista genérica wrappeada
            Me.ltbServicio.DataSource = _listTemp
            Me.ltbServicio.DisplayMember = "nombre"
            Me.ltbServicio.ValueMember = "codServicio"

        Catch ex As Exception
            MsgBox("Error en la operación ... " & ex.Message, MsgBoxStyle.Information, "Buscar Plan de Ventas")
        End Try
    End Sub

    Private Function obtenerServicioPlan(ByVal servicio As ClsCastCadenaServicio) As Integer
        Dim contador As Integer = 0
        For Each i As ArrayList In _servicioVentasPlaneadas
            If CStr(i(0)).Equals(servicio.codServicio) Then
                Return contador
            End If
            contador += 1
        Next
    End Function

    Private Sub ltbPlanServicio_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ltbPlanServicio.SelectedIndexChanged
        For Each i In ltbPlanServicio.SelectedIndices
            Dim dato As ArrayList = _servicioVentasPlaneadas(obtenerServicioPlan(CType(ltbPlanServicio.Items(i), ClsCastCadenaServicio)))
            txtCantPlaneada.Text = dato(1)
        Next
    End Sub

    Private Sub pbModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbModificar.Click
        If Not dvgPlanVenta.RowCount = 0 Then
            visibleControl()
            txtId.Text = Me.dvgPlanVenta.SelectedCells(0).Value
            txtDescripcion.Text = Me.dvgPlanVenta.SelectedCells(1).Value
            txtFechaInicio.Text = Me.dvgPlanVenta.SelectedCells(2).Value
            txtFechaFin.Text = Me.dvgPlanVenta.SelectedCells(3).Value
            cargarPlanServicios()
            cargarServicioSinPlan()
            validarRoles()
        End If
        
    End Sub

    Private Sub validarRoles()
        If ROL_USUARIO.Contains("Gerente General") Then
            pbEliminar.Visible = False
            pbQuitar.Enabled = False
            pbAsignar.Enabled = False
            gpbModificarPlan.Enabled = False

        ElseIf ROL_USUARIO.Contains("Vendedor") Then
            pbEliminar.Visible = False
            pbQuitar.Enabled = False
            pbAsignar.Enabled = False
            gpbModificarPlan.Enabled = False

        End If
    End Sub

    ''' <summary>
    ''' Método de clase, encargado de eliminar el plan de ventas en la DB
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub pbEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbEliminar.Click
        If Not dvgPlanVenta.RowCount = 0 Then
            _idPlan = Me.dvgPlanVenta.SelectedCells(0).Value
            Dim _result As DialogResult
            _result = MessageBox.Show("¿Está seguro que desea eliminar el plan de ventas?", "Eliminar plan de ventas", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, 0, False)
            Try
                If _result = Windows.Forms.DialogResult.Yes Then
                    _gestor.eliminarPlanVenta(_idPlan) 'invocar el método indicado enviando los argumentos requeridos.
                    MsgBox("Los datos del plan de ventas se han eliminado.", MsgBoxStyle.Information, "Eliminar plan de ventas")
                Else
                    MsgBox("Los datos del plan de ventas no se pueden eliminar.", MsgBoxStyle.Information, "Eliminar plan de ventas")
                End If
            Catch ex As Exception
                MsgBox("Los datos del plan de ventas no se pueden eliminar." & ex.Message, MsgBoxStyle.Information, "Eliminar plan de ventas")
            End Try
            cargarPlanes()
        End If
    End Sub
    ''' <summary>
    ''' Método d clase, encargado de hacer visible componentes
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub visibleControl()
        Me.gpbModificarPlan.Visible = True
    End Sub

    Private Sub pbQuitar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbQuitar.Click
        _idServicio = Me.ltbPlanServicio.SelectedValue
        _idPlan = Me.txtId.Text
        _gestor.eliminarPlanVentaServicio(_idPlan, _idServicio)
        cargarPlanServicios()
        cargarServicioSinPlan()
        If ltbPlanServicio.Items.Count = 0 Then
            txtCantPlaneada.Text = ""
        End If
    End Sub

    ''' <summary>
    ''' Método de clase, encarga de evaluar que la cantidad ventas  tenga el formato correcto
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function evaluarVenta() As Boolean
        Dim _numero As Boolean
        _numero = IsNumeric(txtCant.Text)
        Return _numero
    End Function
    Private Sub pbAsignar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbAsignar.Click
        Dim _numero As Boolean
        If Not txtCant.Text.Equals("") Then
            If _numero = evaluarVenta() Then 'Valida el formato del teléfono

                MsgBox("La cantidad venta planeada debe ser solo número", MsgBoxStyle.Information, "Modificar cliente")
                Me.txtCant.SelectAll()

            Else
                _idServicio = Me.ltbServicio.SelectedValue
                _idPlan = Me.txtId.Text
                _cantPlaneada = Me.txtCant.Text
                _gestor.modificarPlanVentaServicio(_idPlan, _idServicio, _cantPlaneada)
                txtCant.Text = ""
                cargarPlanServicios()
                cargarServicioSinPlan()
            End If
        ElseIf txtCant.Text = "" Then
            MsgBox("Debe ingresar la cantidad de ventas planeadas para agregar el servicio al plan.", MsgBoxStyle.Information, "Aviso")
            txtCant.Focus()
        End If
    End Sub


    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint
        validarRoles()
    End Sub
End Class
