Imports CllLogicaNegocio
Partial Public Class RegistrarFactura
    Inherits System.Web.UI.Page

    Dim _gestor As New ClsGestor() 'declara e instancia de la clase Gestor
    Dim _num As String
    Dim _idCliente As String
    Dim _fechaValidez As Date
    Dim _moneda As String
    Dim _servicio(2) As String
    Dim _tempArray As Array
    Dim _listaFactura As List(Of Array) = New List(Of Array)
    Dim _listaServicio As List(Of Array) = New List(Of Array)()
    Dim _idServicio As String
    Dim _countLineasAgregadas = 0
    Dim _cadena As ClsCastCadenaServicio

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Not IsPostBack Then
            cargarServicios()
            cargarClientes()
            Me.txtNumero.Focus()
            Me.dpValidez.SelectedDate = Now
        End If
        
    End Sub

    Private Sub cargarClientes()
        Try

            Dim _listaClientes As List(Of Array) = New List(Of Array)() 'declarar una variable tipo lista genérica de Array

            _listaClientes = _gestor.listarClientes() 'asignar el resultado de la búsqueda devuelto por un método del Gestor

            Dim _tempArray As Array 'declarar una variable tipo Array

            Dim _listTemp As New List(Of ClsCastCadenaCliente) 'declarar una variable tipo lista genérica tipo clsCastCadenaServicio (Wrapper)

            Dim _tempCast() As String 'declarar una variable tipo arreglo de String

            'estructura iterativa tipo matriz para recorrer y envolver por el tipo adecuado
            For i As Integer = 0 To _listaClientes.Count - 1
                _tempArray = _listaClientes(i) 'clonar a un Array temporal la FILA (ROW) de la consulta

                ReDim _tempCast(_tempArray.Length() - 1) 'redimensionar el arreglo a un tamaño indicado

                For j As Integer = 0 To _tempArray.Length - 1 'recorrer la parte interna de la matriz, columna (COLUMN)

                    _tempCast(j) = _tempArray.GetValue(j).ToString() 'asignar el valor de cada celda 
                Next
                _listTemp.Add(New ClsCastCadenaCliente(_tempCast(0).ToString(), _tempCast(1).ToString(), _
                            _tempCast(2).ToString(), _tempCast(3).ToString(), _tempCast(4).ToString(), _tempCast(5).ToString()))
            Next
            'asignar el fuente de dato para un control tipo listbox la lista genérica wrappeada

            Me.DdlCliente.DataSource = _listTemp
            Me.DdlCliente.DataTextField = "nombreCliente"
            Me.DdlCliente.DataValueField = "idCliente"
            Me.DdlCliente.DataBind()
            Me.DdlCliente.SelectedIndex = 0
        Catch ex As Exception
            MsgBox("Error en la operación ... " & ex.Message)
        End Try
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
                _listTemp.Add(New ClsCastCadenaServicio(_tempCast(0).ToString(), _tempCast(1).ToString(), _
                                                        _tempCast(2).ToString(), _tempCast(3).ToString(), _
                                                        _tempCast(4).ToString(), _tempCast(5).ToString(), _
                                                        _tempCast(6).ToString(), _tempCast(7).ToString(), _
                                                        _tempCast(8).ToString(), _tempCast(9).ToString(), _
                                                        _tempCast(10).ToString())) 'agregar a la lista genérica una colección de la clase wrapper

            Next
            'asignar el fuente de dato para un control tipo listbox la lista genérica wrappeada
            Me.DdlServiciosDisp.DataSource = _listTemp
            Me.DdlServiciosDisp.DataTextField = "nombre"
            Me.DdlServiciosDisp.DataValueField = "codServicio"
            Me.DdlServiciosDisp.DataBind()
            Me.DdlServiciosDisp.SelectedIndex = 0

        Catch ex As Exception
            MsgBox("Error en la operación ... " & ex.Message)
        End Try
    End Sub

    Public Function evaluarEspacio() As Boolean
        Dim _resul As Boolean = False

        If Me.txtNumero.Text = "" Then
            MsgBox("El Numero de factura es un dato requerido")
            Me.txtNumero.Focus()
        ElseIf IsNumeric(Me.txtNumero.Text) = False Then
            MsgBox("El Numero de factura es debe ser solamente de caracteres numericos.")
            Me.txtNumero.Focus()
        ElseIf dpValidez.SelectedDate <= Now Then
            MsgBox("La Fecha maxima de validez debe ser posterior al dia de hoy")
            Me.dpValidez.Focus()
        ElseIf DdlMoneda.SelectedIndex = 0 Then
            MsgBox("La moneda es un dato requerido")
        ElseIf Me.TxtCantidad.Text = "" Then
            MsgBox("La cantidad a facturar del servicio selecionado es un dato requerido")
            Me.TxtCantidad.Focus()
        Else
            _resul = True
        End If
        Return _resul
    End Function

    Protected Sub btnRegistrar_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btnRegistrar.Click
        Dim result As Boolean = evaluarEspacio()
        If txtNumero.Enabled Then
            If result Then
                _num = Me.txtNumero.Text
                _idCliente = DdlCliente.SelectedValue.ToString
                _fechaValidez = dpValidez.SelectedDate
                _servicio(0) = DdlServiciosDisp.SelectedValue.ToString
                _servicio(1) = Me.TxtCantidad.Text
                If DdlMoneda.SelectedIndex = 1 Then
                    _servicio(2) = obtenerCadenaServicio(DdlServiciosDisp.SelectedValue.ToString).precioColones
                Else
                    _servicio(2) = obtenerCadenaServicio(DdlServiciosDisp.SelectedValue.ToString).precioDolares
                End If

                Try
                    _gestor.registrarFactura(txtNumero.Text, DdlCliente.SelectedValue.ToString, _fechaValidez, DdlMoneda.SelectedItem.ToString, _servicio)
                    inhabilitarContorles()
                    MsgBox("La factura se ha registrado correctamente, si desea puede agregarle otra linea de detalle")
                    cargarLineasDetalle()
                    cargarMonto()

                    'cargarDetalle()
                Catch ex As Exception
                    MsgBox("Ha ocurrido un error en el registro de la factura.", ex.Message)

                End Try
            End If
        Else
            _servicio(0) = obtenerCadenaServicio(DdlServiciosDisp.SelectedValue.ToString).codServicio
            _servicio(1) = Me.TxtCantidad.Text
            If DdlMoneda.SelectedIndex = 1 Then
                _servicio(2) = obtenerCadenaServicio(DdlServiciosDisp.SelectedValue.ToString).precioColones
            Else
                _servicio(2) = obtenerCadenaServicio(DdlServiciosDisp.SelectedValue.ToString).precioDolares
            End If

            Try
                _gestor.agregarLineaDetalle(txtNumero.Text, _servicio)
                MsgBox("La linea de detalle se ha registrado correctamente, si desea puede agregarle otra linea de detalle")
                cargarLineasDetalle()
                cargarMonto()

                'cargarDetalle()
            Catch ex As Exception
                MsgBox("Ha ocurrido un error en el registro de la factura.", ex.Message)
            End Try
        End If
    End Sub

    Private Function obtenerCadenaServicio(ByVal pcod As String) As ClsCastCadenaServicio

        Try

            'asignar el resultado de la búsqueda devuelto por un método del Gestor
            _listaServicio = _gestor.buscarServicioCod(pcod)

            _tempArray = _listaServicio(0)

            _cadena = New ClsCastCadenaServicio(_tempArray(0).ToString(), _tempArray(1).ToString(), _tempArray(2).ToString(), _tempArray(3).ToString(), _tempArray(4).ToString(), _tempArray(5).ToString(), _tempArray(6).ToString(), _tempArray(7).ToString(), _tempArray(8).ToString(), _tempArray(9).ToString(), _tempArray(10).ToString())

        Catch ex As Exception
            MsgBox("Error en la operación ... " & ex.Message)
        End Try
        Return _cadena
    End Function

    Private Sub inhabilitarContorles()
        Me.txtNumero.Enabled = False
        Me.DdlCliente.Enabled = False
        Me.dpValidez.Enabled = False
    End Sub

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
            Me.gridDetalle.DataSource = _listTemp
            Me.gridDetalle.DataBind()

        Catch ex As Exception
            MsgBox("Error en la operación ... " & ex.Message)
        End Try
    End Sub

    Public Sub cargarMonto()
        Try
            Dim _listTemp As New List(Of ClsCastCadenaFactura) 'declarar una variable tipo lista genérica tipo clsCastCadena (Wrapper)
            Dim _tempCast() As String 'declarar una variable tipo arreglo de String

            _listaFactura = _gestor.buscarFactura(txtNumero.Text) 'asignar el resultado de la búsqueda devuelto por un método del Gestor

            For i As Integer = 0 To _listaFactura.Count - 1 'estructura iterativa tipo matriz para recorrer y envolver por el tipo adecuado

                _tempArray = _listaFactura(i) 'clonar a un Array temporal la FILA (ROW) de la consulta
                ReDim _tempCast(_tempArray.Length() - 1) 'redimensionar el arreglo a un tamaño indicado

                For j As Integer = 0 To _tempArray.Length - 1 'recorrer la parte interna de la matriz, columna (COLUMN)
                    _tempCast(j) = _tempArray.GetValue(j).ToString() 'asignar el valor de cada celda 
                Next

                _listTemp.Add(New ClsCastCadenaFactura(_tempCast(0).ToString(), _tempCast(1).ToString(), _tempCast(2).ToString(), _tempCast(3).ToString(), _tempCast(4).ToString(), _tempCast(5).ToString(), _tempCast(6).ToString(), _tempCast(7).ToString(), _tempCast(8).ToString(), _tempCast(9).ToString())) 'agregar a la lista genérica una colección de la clase wrapper

            Next

            Me.txtMonto.Text = _listTemp(0).monto.ToString 'asignar el fuente de dato para un control tipo datagridview la lista genérica wrappeada

        Catch ex As Exception
            MsgBox("Error en la operación ... " & ex.Message)
        End Try

    End Sub

    Protected Sub DdlServiciosDisp_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles DdlServiciosDisp.SelectedIndexChanged
        _idServicio = obtenerCadenaServicio(DdlServiciosDisp.SelectedValue.ToString).codServicio
    End Sub

    Protected Sub btnLimpiar_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btnLimpiar.Click

            _num = ""
            _idServicio = ""
            _countLineasAgregadas = 0
            cargarServicios()
            cargarClientes()
            Me.txtNumero.Text = ""
            Me.txtNumero.Enabled = True
            Me.dpValidez.Enabled = True
            Me.DdlCliente.Enabled = True
            Me.txtMonto.Text = ""
            Me.TxtCantidad.Text = ""
            Me.DdlMoneda.Enabled = True
        Me.gridDetalle.Items.Clear()
            Me.txtNumero.Focus()
    End Sub

    Protected Sub DdlMoneda_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles DdlMoneda.SelectedIndexChanged
        _moneda = Me.DdlMoneda.SelectedItem.ToString()
        Me.DdlMoneda.Enabled = False
    End Sub
End Class