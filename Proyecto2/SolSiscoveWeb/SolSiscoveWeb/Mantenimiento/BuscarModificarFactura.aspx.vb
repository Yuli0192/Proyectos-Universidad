Imports CllLogicaNegocio
Imports System.Data.DataSet

Partial Public Class BuscarModificarFactura
    Inherits System.Web.UI.Page

    'Dim VentaDollar As New TipoCambioDollar.wsIndicadoresEconomicosSoapClient
    Dim _criterio As String
    Dim _gestor As New ClsGestor() 'declara e instancia de la clase Gestor
    Dim _listaFactura As List(Of Array) = New List(Of Array)
    Dim _tempArray As Array
    Dim _idFactura As String
    Dim _servicio(2) As String
    Dim _listaCliente As List(Of Array) = New List(Of Array)
    Dim _listaVendedor As List(Of Array) = New List(Of Array)
    Dim _cadena As ClsCastCadenaServicio

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            _gestor.invalidarFacturas()
            cargarFacturas()
            Me.txtCriterio.Focus()
            FacturaModificar.Visible = False
        End If
    End Sub

    Private Sub cargarFacturas()
        Try
            Dim _listTemp As New List(Of ClsCastCadenaFactura) 'declarar una variable tipo lista genérica tipo clsCastCadena (Wrapper)
            Dim _listaFactura As List(Of Array) = New List(Of Array)() 'declarar una variable tipo lista genérica de Array
            Dim _tempCast() As String 'declarar una variable tipo arreglo de String
            Dim _tempArray As Array 'declarar una variable tipo Array

            _listaFactura = _gestor.listarFacturas() 'asignar el resultado de la búsqueda devuelto por un método del Gestor

            For i As Integer = 0 To _listaFactura.Count - 1 'estructura iterativa tipo matriz para recorrer y envolver por el tipo adecuado

                _tempArray = _listaFactura(i) 'clonar a un Array temporal la FILA (ROW) de la consulta
                ReDim _tempCast(_tempArray.Length() - 1) 'redimensionar el arreglo a un tamaño indicado

                For j As Integer = 0 To _tempArray.Length - 1 'recorrer la parte interna de la matriz, columna (COLUMN)
                    _tempCast(j) = _tempArray.GetValue(j).ToString() 'asignar el valor de cada celda 
                Next

                _listTemp.Add(New ClsCastCadenaFactura(_tempCast(0).ToString(), _tempCast(1).ToString(), _tempCast(2).ToString(), _tempCast(3).ToString(), _tempCast(4).ToString(), _tempCast(5).ToString(), _tempCast(6).ToString(), _tempCast(7).ToString(), _tempCast(8).ToString(), _tempCast(9).ToString())) 'agregar a la lista genérica una colección de la clase wrapper

            Next

            Me.gridFactura.DataSource = _listTemp 'asignar el fuente de dato para un control tipo datagridview la lista genérica wrappeada
            Me.gridFactura.DataBind()

        Catch ex As Exception
            MsgBox("Error en la operación ... " & ex.Message)
        End Try

    End Sub

    Protected Sub btnBuscar_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btnBuscar.Click
        If Me.txtCriterio.Text = "" Then
            cargarFacturas()
        Else
            _criterio = Me.txtCriterio.Text
            buscarFactura(_criterio)
        End If
    End Sub

    Public Sub buscarFactura(ByVal _criterio)
        Try
            Dim _listTemp As New List(Of ClsCastCadenaFactura) 'declarar una variable tipo lista genérica tipo clsCastCadena (Wrapper)
            Dim _tempCast() As String 'declarar una variable tipo arreglo de String

            _listaFactura = _gestor.buscarFactura(_criterio) 'asignar el resultado de la búsqueda devuelto por un método del Gestor

            For i As Integer = 0 To _listaFactura.Count - 1 'estructura iterativa tipo matriz para recorrer y envolver por el tipo adecuado

                _tempArray = _listaFactura(i) 'clonar a un Array temporal la FILA (ROW) de la consulta
                ReDim _tempCast(_tempArray.Length() - 1) 'redimensionar el arreglo a un tamaño indicado

                For j As Integer = 0 To _tempArray.Length - 1 'recorrer la parte interna de la matriz, columna (COLUMN)
                    _tempCast(j) = _tempArray.GetValue(j).ToString() 'asignar el valor de cada celda 
                Next

                _listTemp.Add(New ClsCastCadenaFactura(_tempCast(0).ToString(), _tempCast(1).ToString(), _tempCast(2).ToString(), _tempCast(3).ToString(), _tempCast(4).ToString(), _tempCast(5).ToString(), _tempCast(6).ToString(), _tempCast(7).ToString(), _tempCast(8).ToString(), _tempCast(9).ToString())) 'agregar a la lista genérica una colección de la clase wrapper

            Next

            Me.gridFactura.DataSource = _listTemp 'asignar el fuente de dato para un control tipo datagridview la lista genérica wrappeada
            Me.gridFactura.DataBind()
        Catch ex As Exception
            MsgBox("Error en la operación ... " & ex.Message)
        End Try

    End Sub

    Protected Sub btnEliminar_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btnEliminar.Click
        _idFactura = (gridFactura.Items(gridFactura.SelectedItemIndex).Cells(0).Value)
        Try
            _gestor.eliminarFactura(_idFactura) 'invocar el método indicado enviando los argumentos requeridos.
            MsgBox("Los datos de la factura se han eliminado correctamente.", MsgBoxStyle.Information, "Eliminar factura")
            cargarFacturas()
        Catch ex As Exception
            MsgBox("Los datos de la factura no se pueden eliminar." & vbCrLf & ex.Message, MsgBoxStyle.Information, "Eliminar factura")
        End Try
    End Sub

    Protected Sub btnModify_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btnModify.Click
        FacturaModificar.Visible = True
        modificar()
    End Sub

    Private Sub CargarCliente(ByVal pidCliente As String)
        Try
            Dim _listTemp As New List(Of ClsCastCadenaCliente) 'declarar una variable tipo lista genérica tipo clsCastCadena (Wrapper)
            Dim _tempCast() As String 'declarar una variable tipo arreglo de String

            _listaCliente = _gestor.buscarClienteId(pidCliente) 'asignar el resultado de la búsqueda devuelto por un método del Gestor

            For i As Integer = 0 To _listaCliente.Count - 1 'estructura iterativa tipo matriz para recorrer y envolver por el tipo adecuado

                _tempArray = _listaCliente(i) 'clonar a un Array temporal la FILA (ROW) de la consulta
                ReDim _tempCast(_tempArray.Length() - 1) 'redimensionar el arreglo a un tamaño indicado

                For j As Integer = 0 To _tempArray.Length - 1 'recorrer la parte interna de la matriz, columna (COLUMN)
                    _tempCast(j) = _tempArray.GetValue(j).ToString() 'asignar el valor de cada celda 
                Next
                _listTemp.Add(New ClsCastCadenaCliente(_tempCast(0).ToString(), _tempCast(1).ToString(), _tempCast(2).ToString(), _tempCast(3).ToString(), _tempCast(4).ToString(), _tempCast(5).ToString())) 'agregar a la lista genérica una colección de la clase wrapper
            Next
            Me.txtCliente.Text = _listTemp(0).nombreCliente 'asignar el fuente de dato para un control tipo datagridview la lista genérica wrappeada

        Catch ex As Exception
            Response.Write("<Script>alert('Error en la operación: " & ex.Message & "');</Script>")
        End Try
    End Sub

    Private Sub CargarVendedor(ByVal pidVendedor As String)
        Try
            Dim _listTemp As New List(Of ClsCastCadenaUsuario) 'declarar una variable tipo lista genérica tipo clsCastCadena (Wrapper)
            Dim _tempCast() As String 'declarar una variable tipo arreglo de String

            _listaVendedor = _gestor.buscarUsuarioIdReturnArray(pidVendedor) 'asignar el resultado de la búsqueda devuelto por un método del Gestor

            For i As Integer = 0 To _listaVendedor.Count - 1 'estructura iterativa tipo matriz para recorrer y envolver por el tipo adecuado

                _tempArray = _listaVendedor(i) 'clonar a un Array temporal la FILA (ROW) de la consulta
                ReDim _tempCast(_tempArray.Length() - 1) 'redimensionar el arreglo a un tamaño indicado

                For j As Integer = 0 To _tempArray.Length - 1 'recorrer la parte interna de la matriz, columna (COLUMN)
                    _tempCast(j) = _tempArray.GetValue(j).ToString() 'asignar el valor de cada celda 
                Next
                _listTemp.Add(New ClsCastCadenaUsuario(_tempCast(0).ToString(), _tempCast(1).ToString(), _
                               _tempCast(2).ToString(), _tempCast(3).ToString(), _tempCast(4).ToString(), _
                               _tempCast(5).ToString(), _tempCast(6).ToString()))
            Next
            Me.txtVendedor.Text = _listTemp(0).nombreCompleto 'asignar el fuente de dato para un control tipo datagridview la lista genérica wrappeada

        Catch ex As Exception
            Response.Write("<Script>alert('Error en la operación: " & ex.Message & "');</Script>")
        End Try
    End Sub

    Public Sub modificar()
        If (gridFactura.Items(gridFactura.SelectedItemIndex).Cells("estado").Value) = "Proforma" Then
            With Me
                .TxtNum.Text = (gridFactura.Items(gridFactura.SelectedItemIndex).Cells("num").Value)
                .TxtNum.Enabled = False
                CargarCliente((gridFactura.Items(gridFactura.SelectedItemIndex).Cells("idCliente").Value))
                .txtCliente.Enabled = False
                CargarVendedor((gridFactura.Items(gridFactura.SelectedItemIndex).Cells("idUsuario").Value))
                .txtVendedor.Enabled = False
                lblFecFacturacion.Visible = False
                textFacturacion.Visible = False
                .textCreacion.Text = (gridFactura.Items(gridFactura.SelectedItemIndex).Cells("fechaCreacion").Value)
                .textCreacion.Enabled = False
                .txtValidez.Text = (gridFactura.Items(gridFactura.SelectedItemIndex).Cells("fechaValidez").Value)
                .txtValidez.Enabled = False
                .txtMoneda.Text = (gridFactura.Items(gridFactura.SelectedItemIndex).Cells("moneda").Value)
                .txtMoneda.Enabled = False

                .ddlEstado.Items.Clear()
                .ddlEstado.Items.Add("Proforma")
                .ddlEstado.Items.Add("Aprobada")
                .ddlEstado.Text = (gridFactura.Items(gridFactura.SelectedItemIndex).Cells("estado").Value)

                .ddlEstado.Enabled = True
                .txtMonto.Text = (gridFactura.Items(gridFactura.SelectedItemIndex).Cells("monto").Value)
                .txtMonto.Enabled = False

                .btnModificar.Visible = True
                .btnAgregarDetalle.Visible = True
                .btnEliminar.Visible = True
                .DdlServiciosDisp.Enabled = True
                .TxtCantidad.Enabled = True

            End With
            If IsPostBack Then
                cargarServicios()
                cargarLineasDetalle()
            End If
            
        Else
            With Me
                .TxtNum.Text = (gridFactura.Items(gridFactura.SelectedItemIndex).Cells("num").Value)
                .TxtNum.Enabled = False
                CargarCliente((gridFactura.Items(gridFactura.SelectedItemIndex).Cells("idCliente").Value))
                .txtCliente.Enabled = False
                CargarVendedor((gridFactura.Items(gridFactura.SelectedItemIndex).Cells("idUsuario").Value))
                .txtVendedor.Enabled = False
                If (gridFactura.Items(gridFactura.SelectedItemIndex).Cells("estado").Value) = "Aprobada" Then
                    .textFacturacion.Text = (gridFactura.Items(gridFactura.SelectedItemIndex).Cells("fechaFacturacion").Value)
                    .textFacturacion.Visible = True
                    .textFacturacion.Enabled = False

                Else
                    .textFacturacion.Visible = False
                    .textFacturacion.Enabled = False
                End If


                .textCreacion.Text = (gridFactura.Items(gridFactura.SelectedItemIndex).Cells("fechaCreacion").Value)
                .textCreacion.Enabled = False
                .textCreacion.Visible = True
                .txtValidez.Text = (gridFactura.Items(gridFactura.SelectedItemIndex).Cells("fechaValidez").Value)
                .txtValidez.Enabled = False
                .txtMoneda.Text = (gridFactura.Items(gridFactura.SelectedItemIndex).Cells("moneda").Value)
                .txtMoneda.Enabled = False

                .ddlEstado.Items.Clear()
                .ddlEstado.Items.Add("Proforma")
                .ddlEstado.Items.Add("Aprobada")
                .ddlEstado.Items.Add("Vencida")
                .ddlEstado.Text = (gridFactura.Items(gridFactura.SelectedItemIndex).Cells("estado").Value)

                .ddlEstado.Enabled = False
                .txtMonto.Text = (gridFactura.Items(gridFactura.SelectedItemIndex).Cells("monto").Value)
                .txtMonto.Enabled = False

                .btnModificar.Visible = False
                .btnAgregarDetalle.Visible = False
                .btnEliminarDetalle.Visible = False
                .DdlServiciosDisp.Enabled = False
                .TxtCantidad.Enabled = False

            End With

            If IsPostBack Then
                cargarServicios()
                cargarLineasDetalle()
                cargarFacturas()
            End If
        End If
    End Sub

    Public Sub cargarLineasDetalle()

        If IsPostBack Then
            Try
                Dim _lineasDetalle As List(Of Array) = New List(Of Array)() 'declarar una variable tipo lista genérica de Array

                _lineasDetalle = _gestor.buscarDetalleFactura(Me.TxtNum.Text) 'asignar el resultado de la búsqueda devuelto por un método del Gestor

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
                gridDetalle.DataBind()

            Catch ex As Exception
                Response.Write("<Script>alert('Error en la operación: " & ex.Message & "');</Script>")
            End Try
        End If
       
    End Sub

    Private Sub cargarServicios()

        If IsPostBack Then
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
                Me.DdlServiciosDisp.DataSource = _listTemp
                Me.DdlServiciosDisp.DataTextField = "nombre"
                Me.DdlServiciosDisp.DataValueField = "codServicio"
                Me.DdlServiciosDisp.DataBind()
                Me.DdlServiciosDisp.SelectedIndex = 0

            Catch ex As Exception
                Response.Write("<Script>alert('Error en la operación:');</Script>")
            End Try
        End If
       
    End Sub

    Protected Sub btnModificar_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btnModificar.Click
        If IsPostBack Then
            If ddlEstado.SelectedValue = "Aprobada" Then

                ''Dim data As DataSet = VentaDollar.ObtenerIndicadoresEconomicos("318", Now.Date.ToString.Substring(0, 10), Now.Date.ToString.Substring(0, 10), "Siscove", "n")
                Dim num As String = Me.TxtNum.Text
                ''Dim tipoDeCambio As Decimal = data.Tables(0).Rows(0).ItemArray(2)

                Try
                    _gestor.aceptarFactura(num, 503.1)
                    MsgBox("Los datos de la factura se han modificado correctamente.", MsgBoxStyle.Information, "Modificar factura")
                    cargarFacturas()
                    FacturaModificar.Visible = False
                Catch ex As Exception
                    MsgBox("Ha ocurrido un error en la operacion.", ex.Message)
                End Try
            Else
                MsgBox("El estado actual de la factura es " & Me.ddlEstado.SelectedValue)
            End If
        End If
    End Sub

    Protected Sub btnAgregarDetalle_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btnAgregarDetalle.Click
        Dim result As Boolean = evaluarEspacio()

        If result Then
            _servicio(0) = obtenerCadenaServicio(DdlServiciosDisp.SelectedValue.ToString).codServicio
            _servicio(1) = CStr(Me.TxtCantidad.Text)
            If Me.txtMoneda.Text = "Colones" Then
                _servicio(2) = obtenerCadenaServicio(DdlServiciosDisp.SelectedValue.ToString).precioColones
            Else
                _servicio(2) = obtenerCadenaServicio(DdlServiciosDisp.SelectedValue.ToString).precioDolares
            End If
            Try
                _gestor.agregarLineaDetalle(Me.TxtNum.Text, _servicio)
                MsgBox("Los datos de la linea de detalle se han agregado correctamente.", MsgBoxStyle.Information, "Agregar Linea de Detalle")
                cargarLineasDetalle()
                cargarMonto()
                'cargarDetalle()
            Catch ex As Exception
                MsgBox("Los datos de la linea de detalle no se han agregado correctamente." & vbCrLf & ex.Message, MsgBoxStyle.Information, "Agregar Linea de Detalle")
            End Try

        End If
    End Sub

    Private Function obtenerCadenaServicio(ByVal pcod As String) As ClsCastCadenaServicio

        Dim _listaServicio As List(Of Array) = New List(Of Array)
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

    Public Function evaluarEspacio() As Boolean
        Dim _resul As Boolean = False

        If Me.txtCantidad.Text = "" Then
            MsgBox("La cantidad a facturar del servicio selecionado es un dato requerido")
            Me.txtCantidad.Focus()
        Else
            _resul = True
        End If
        Return _resul
    End Function

    Public Sub cargarMonto()
        Try
            Dim _listTemp As New List(Of ClsCastCadenaFactura) 'declarar una variable tipo lista genérica tipo clsCastCadena (Wrapper)
            Dim _tempCast() As String 'declarar una variable tipo arreglo de String

            _listaFactura = _gestor.buscarFactura(Me.TxtNum.Text) 'asignar el resultado de la búsqueda devuelto por un método del Gestor

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

    Protected Sub btnEliminarDetalle_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btnEliminarDetalle.Click
        Dim codServicio As String = (gridDetalle.Items(gridDetalle.SelectedItemIndex).Cells("codServicio").Value)
        Dim _num As String = Me.TxtNum.Text
        If Me.gridDetalle.Items.Count > 1 Then
            Try
                _gestor.eliminarLineaDetalle(_num, codServicio)
                MsgBox("Los datos de la linea de detalle se han eliminado correctamente.", MsgBoxStyle.Information, "Eliminar Linea de Detalle")
                cargarLineasDetalle()
                cargarMonto()
            Catch ex As Exception
                MsgBox("Los datos de la linea de detalle no se han eliminado correctamente." & vbCrLf & ex.Message, MsgBoxStyle.Information, "Eliminar Linea de Detalle")
            End Try
        Else
            MsgBox("Proceso no completado. El detalle de la factura debe al menos contar con una linea de detalle.", MsgBoxStyle.Information, "Eliminar Linea de Detalle")
        End If
    End Sub
End Class