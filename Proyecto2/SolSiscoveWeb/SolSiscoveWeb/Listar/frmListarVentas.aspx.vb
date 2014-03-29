Imports CllLogicaNegocio.ClsGestor
Partial Public Class frmListarVentas
    Inherits System.Web.UI.Page
    Dim _gestor As New CllLogicaNegocio.ClsGestor
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            cargarVendedores()
        End If

    End Sub

    Protected Sub dpdlCedula_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles dpdlCedula.SelectedIndexChanged
        limpiar()

    End Sub

    Protected Sub dtpFechaInicio_SelectionChanged(ByVal sender As Object, ByVal e As EventArgs) Handles dtpFechaInicio.SelectionChanged
        limpiar()

    End Sub

    Protected Sub dtpFechaFin_SelectionChanged(ByVal sender As Object, ByVal e As EventArgs) Handles dtpFechaFin.SelectionChanged
        limpiar()

    End Sub

    Public Sub limpiar()
        lblVentas.Visible = False
        lblVerVentas.Visible = False
        lblVentas.Visible = False
        lblNumero.Visible = False
        lblCliente.Visible = False
        lblFechaFacturacion.Visible = False
        lblMonto.Visible = False
        txtNumero.Visible = False
        txtCliente.Visible = False
        txtFechaFacturacion.Visible = False
        txtMonto.Visible = False
        txtNumero.Visible = False
        gridLineasDetalle.Visible = False
        gVerVentas.Visible = False
        bntVerVentas.Visible = False
    End Sub

    ''' <summary>
    ''' Método de clase, encarga de evaluar que no queden espacios en blanco ningún componente
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function evaluarEspacio() As Boolean
        Dim _resul As Boolean

        If dtpFechaInicio.SelectedDate > dtpFechaFin.SelectedDate Then
            MsgBox("La fecha inicio debe ser menor que la fecha fin ", MsgBoxStyle.Information, "Buscar Usuario")
        Else
            _resul = True
        End If
        Return _resul
    End Function

    ''' <summary>
    ''' Método de clase, encargado de cargar todos los vendedores existentes en la DB
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub cargarVendedores()
        Try
            'declarar una variable tipo lista genérica de Array
            Dim _listaUsuario As List(Of Array) = New List(Of Array)()

            'asignar el resultado de la búsqueda devuelto por un método del Gestor
            _listaUsuario = _gestor.listarVendedores()
            'declarar una variable tipo Array
            Dim _tempArray As Array
            'declarar una variable tipo lista genérica tipo clsCastCadena (Wrapper)
            Dim _listTemp As New List(Of ClsCastCadenaUsuario)

            'declarar una variable tipo arreglo de String
            Dim _tempCast() As String

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

                'agregar a la lista genérica una colección de la clase wrapper
                _listTemp.Add(New ClsCastCadenaUsuario(_tempCast(0).ToString(), _tempCast(1).ToString(), _tempCast(2).ToString(), _tempCast(3).ToString(), _tempCast(4).ToString(), _tempCast(5).ToString(), _tempCast(6).ToString()))

            Next

            'asignar el fuente de dato para un control tipo ComboBox la lista genérica wrappeada
            Me.dpdlCedula.DataSource = _listTemp
            Me.dpdlCedula.DataTextField = "cedula"
            Me.dpdlCedula.DataBind()

        Catch ex As Exception
            MsgBox("Error en la operación ... " & ex.Message, MsgBoxStyle.Information, "Buscar Vendedores")
        End Try
    End Sub

    Protected Sub bntBuscarVentas_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles bntBuscarVentas.Click
        Dim _resul As Boolean
        _resul = evaluarEspacio()
        If _resul Then
            lblVerVentas.Visible = True
            gVerVentas.Visible = True
            bntVerVentas.Visible = True
            Dim _fechaInicio As Date = dtpFechaInicio.SelectedDate
            Dim _fechaFin As Date = dtpFechaFin.SelectedDate
            Dim _idUsuario As String = dpdlCedula.SelectedValue.ToString
            buscarFacturaPorFecha(_idUsuario, _fechaInicio, _fechaFin) 'invocar el método indicado enviando los argumentos requeridos.
        End If
    End Sub

    ''' <summary>
    ''' Método de clase, encargado de cargar todos las facturas existentes en la DB suministrando un rango de fechas
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub buscarFacturaPorFecha(ByVal pidUsuario As String, ByVal pfechaInicio As Date, ByVal pfechaFin As Date)
        Try
            Dim _listTemp As New List(Of ClsCastCadenaFactura) 'declarar una variable tipo lista genérica tipo clsCastCadena (Wrapper)
            Dim _listaFactura As List(Of Array) = New List(Of Array)() 'declarar una variable tipo lista genérica de Array
            Dim _tempCast() As String 'declarar una variable tipo arreglo de String
            Dim _tempArray As Array 'declarar una variable tipo Array

            _listaFactura = _gestor.buscarFacturasPorFecha(pidUsuario, pfechaInicio, pfechaFin) 'asignar el resultado de la búsqueda devuelto por un método del Gestor

            For i As Integer = 0 To _listaFactura.Count - 1 'estructura iterativa tipo matriz para recorrer y envolver por el tipo adecuado

                _tempArray = _listaFactura(i) 'clonar a un Array temporal la FILA (ROW) de la consulta
                ReDim _tempCast(_tempArray.Length() - 1) 'redimensionar el arreglo a un tamaño indicado

                For j As Integer = 0 To _tempArray.Length - 1 'recorrer la parte interna de la matriz, columna (COLUMN)
                    _tempCast(j) = _tempArray.GetValue(j).ToString() 'asignar el valor de cada celda 
                Next

                _listTemp.Add(New ClsCastCadenaFactura(_tempCast(0).ToString(), _tempCast(1).ToString(), _tempCast(2).ToString(), _tempCast(3).ToString(), _tempCast(4).ToString(), _tempCast(5).ToString(), _tempCast(6).ToString(), _tempCast(7).ToString(), _tempCast(8).ToString(), _tempCast(9).ToString())) 'agregar a la lista genérica una colección de la clase wrapper

            Next

            Me.gVerVentas.DataSource = _listTemp 'asignar el fuente de dato para un control tipo datagridview la lista genérica wrappeada
            Me.gVerVentas.DataBind()
        Catch ex As Exception
            MsgBox("Error en la operación ... " & ex.Message, MsgBoxStyle.Information, "Buscar Ventas")
        End Try

    End Sub

    Protected Sub bntVerVentas_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles bntVerVentas.Click
        lblVentas.Visible = True
        lblNumero.Visible = True
        lblCliente.Visible = True
        lblFechaFacturacion.Visible = True
        lblMonto.Visible = True
        txtNumero.Visible = True
        txtCliente.Visible = True
        txtFechaFacturacion.Visible = True
        txtMonto.Visible = True
        txtNumero.Visible = True
        gridLineasDetalle.Visible = True
        Dim _listaFactura As List(Of Array) = New List(Of Array)() 'declarar una variable tipo lista genérica de Array
        Dim _num As String = gVerVentas.Items(gVerVentas.SelectedItemIndex).Cells("num").Value
        Dim _idCliente As String = gVerVentas.Items(gVerVentas.SelectedItemIndex).Cells("idCliente").Value
        Me.txtNumero.Text = _num
        Me.txtCliente.Text = _idCliente
        Me.txtFechaFacturacion.Text = gVerVentas.Items(gVerVentas.SelectedItemIndex).Cells("fechaFacturacion").Value
        Me.txtMonto.Text = gVerVentas.Items(gVerVentas.SelectedItemIndex).Cells("monto").Value
        cargarLineasDetalle()
    End Sub


    ''' <summary>
    ''' Método de clase, encargado de cargar todos las lineas de detalle de la factura seleccionada 
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub cargarLineasDetalle()
        Try
            Dim _lineasDetalle As List(Of Array) = New List(Of Array)() 'declarar una variable tipo lista genérica de Array

            _lineasDetalle = _gestor.buscarDetalleFactura(Me.txtNumero.Text) 'asignar el resultado de la búsqueda devuelto por un método del Gestor

            Dim _tempArray As Array 'declarar una variable tipo Array

            Dim _listTemp As New List(Of ClsCastCadenaLineasDetalle) 'declarar una variable tipo lista genérica tipo clsCastCadenaServicio (Wrapper)

            Dim _tempCast() As String 'declarar una variable tipo arreglo de String

            'estructura iterativa tipo matriz para recorrer y envolver por el tipo adecuado
            For i As Integer = 0 To _lineasDetalle.Count - 1
                _tempArray = _lineasDetalle(i) 'clonar a un Array temporal la FILA (ROW) de la consulta

                ReDim _tempCast(_tempArray.Length() - 1) 'redimensionar el arreglo a un tamaño indicado

                'recorrer la parte interna de la matriz, columna (COLUMN)
                For j As Integer = 0 To _tempArray.Length - 1
                    _tempCast(j) = _tempArray.GetValue(j).ToString() 'asignar el valor de cada celda 
                Next
                _listTemp.Add(New ClsCastCadenaLineasDetalle(_tempCast(0).ToString(), _tempCast(1).ToString(), _tempCast(2).ToString(), _tempCast(3).ToString())) 'agregar a la lista genérica una colección de la clase wrapper
            Next

            'asignar el fuente de dato para un control tipo datagridview la lista genérica wrappeada
            Me.gridLineasDetalle.DataSource = _listTemp
            Me.gridLineasDetalle.DataBind()

        Catch ex As Exception
            MsgBox("Error en la operación ... " & ex.Message, MsgBoxStyle.Information, "Aviso")
        End Try
    End Sub
End Class