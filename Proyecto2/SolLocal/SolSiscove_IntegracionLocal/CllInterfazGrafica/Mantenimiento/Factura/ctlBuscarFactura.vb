Imports CllLogicaNegocio
Imports System.Data.DataSet

Public Class ctlBuscarFactura

    Dim VentaDollar As New TipoCambioDollar.wsIndicadoresEconomicosSoapClient("wsIndicadoresEconomicosSoap")
    Dim _criterio As String
    Dim _gestor As New ClsGestor() 'declara e instancia de la clase Gestor
    Dim _listaFactura As List(Of Array) = New List(Of Array)
    Dim _tempArray As Array
    Dim _idFactura As String
    Dim _servicio(2) As String
    Dim _listaCliente As List(Of Array) = New List(Of Array)
    Dim _listaVendedor As List(Of Array) = New List(Of Array)

    Private Sub ctlBuscarFactura_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        _gestor.invalidarFacturas()
        cargarFacturas()
        gbxModificarFactura.Visible = False
        Me.txtCriterio.Focus()
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

            Me.dvgFactura.DataSource = _listTemp 'asignar el fuente de dato para un control tipo datagridview la lista genérica wrappeada

            nombrarColumnas()
            invisible()

        Catch ex As Exception
            MessageBox.Show("Error en la operación ... " & ex.Message)
        End Try

    End Sub

    Public Sub nombrarColumnas()
        dvgFactura.Columns(0).HeaderText = "Número Factura"
        dvgFactura.Columns(7).HeaderText = "Estado"
    End Sub

    Public Sub invisible()
        dvgFactura.Columns(1).Visible = False
        dvgFactura.Columns(2).Visible = False
        dvgFactura.Columns(3).Visible = False
        dvgFactura.Columns(4).Visible = False
        dvgFactura.Columns(5).Visible = False
        dvgFactura.Columns(6).Visible = False
        dvgFactura.Columns(7).Visible = True
        dvgFactura.Columns(8).Visible = False
        dvgFactura.Columns(9).Visible = False
    End Sub

    Public Function evaluarCriterio() As Boolean
        Dim _resul As Boolean = False

        If Me.txtCriterio.Text = "" Then
            MessageBox.Show("El numero de factura es un dato requerido para la busqueda")
            Me.txtCriterio.Focus()
        Else
            _resul = True
        End If
        Return _resul
    End Function

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

            Me.dvgFactura.DataSource = _listTemp 'asignar el fuente de dato para un control tipo datagridview la lista genérica wrappeada

        Catch ex As Exception
            MessageBox.Show("Error en la operación ... " & ex.Message)
        End Try

    End Sub

    Private Sub pbBuscarFactura_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim result As Boolean = evaluarCriterio()
        If result Then
            _criterio = Me.txtCriterio.Text
            buscarFactura(_criterio)
        End If
    End Sub

    Private Sub pbEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbEliminar.Click
        If Not dvgFactura.RowCount = 0 Then
            _idFactura = Me.dvgFactura.SelectedCells(0).Value
            Dim _result As DialogResult
            _result = MessageBox.Show("¿Está seguro que desea eliminar la factura seleccionada?", "Eliminar grupo de ventas", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, 0, False)
            Try

                If _result = Windows.Forms.DialogResult.Yes Then
                    _gestor.eliminarFactura(_idFactura) 'invocar el método indicado enviando los argumentos requeridos.
                    MsgBox("Los datos de la factura se han eliminado correctamente.", MsgBoxStyle.Information, "Eliminar factura")
                    cargarFacturas()
                End If
            Catch ex As Exception
                MsgBox("Los datos de la factura no se pueden eliminar." & vbCrLf & ex.Message, MsgBoxStyle.Information, "Eliminar factura")
            End Try
        End If
    End Sub

    Private Sub pbModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbModificar.Click
        If Not dvgFactura.RowCount = 0 Then
            modificar()
            validarRoles()
        End If
    End Sub

    Private Sub validarRoles()
        If ROL_USUARIO.Contains("Gerente General") Then
            pbEliminar.Visible = False
            pbModificar2.Visible = False
            pbAgregarDetalle.Visible = False
            pbEliminarDetalle.Visible = False
            gbxModificarFactura.Enabled = False

        ElseIf ROL_USUARIO.Contains("Vendedor") Then
            pbEliminar.Visible = False
            pbModificar2.Visible = False
            pbAgregarDetalle.Visible = False
            pbEliminarDetalle.Visible = False
            gbxModificarFactura.Enabled = False

        End If
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
            MessageBox.Show("Error en la operación ... " & ex.Message)
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
            MessageBox.Show("Error en la operación ... " & ex.Message)
        End Try
    End Sub

    Public Sub modificar()
        If Me.dvgFactura.SelectedCells(7).Value = "Proforma" Then
            With Me
                gbxModificarFactura.Visible = True
                .txtNumero.Text = Me.dvgFactura.SelectedCells(0).Value
                .txtNumero.Enabled = False
                CargarCliente(Me.dvgFactura.SelectedCells(1).Value)
                .txtCliente.Enabled = False
                CargarVendedor(Me.dvgFactura.SelectedCells(2).Value)
                .txtVendedor.Enabled = False
                .dtpFacturacion.Visible = False
                .dtpCreacion.Text = Me.dvgFactura.SelectedCells(4).Value
                .dtpCreacion.Enabled = False
                .dtpValidez.Text = Me.dvgFactura.SelectedCells(5).Value
                .dtpValidez.Enabled = False
                .txtMoneda.Text = Me.dvgFactura.SelectedCells(6).Value
                .txtMoneda.Enabled = False
                .cmbEstado.Items.Clear()
                .cmbEstado.Items.Add("Proforma")
                .cmbEstado.Items.Add("Aprobada")
                .cmbEstado.Text = Me.dvgFactura.SelectedCells(7).Value
                foramtearEstiloCmbEstado()
                .cmbEstado.Enabled = True
                .txtMonto.Text = Me.dvgFactura.SelectedCells(8).Value
                .txtMonto.Enabled = False
                .pbModificar2.Visible = True
                .pbAgregarDetalle.Visible = True
                .pbEliminarDetalle.Visible = True
                .cmbServicios.Enabled = True
                .txtCantidad.Enabled = True

            End With

            cargarServicios()
            cargarLineasDetalle()
        Else
            With Me
                gbxModificarFactura.Visible = True
                .txtNumero.Text = Me.dvgFactura.SelectedCells(0).Value
                .txtNumero.Enabled = False
                CargarCliente(Me.dvgFactura.SelectedCells(1).Value)
                .txtCliente.Enabled = False
                CargarVendedor(Me.dvgFactura.SelectedCells(2).Value)
                .txtVendedor.Enabled = False
                If dvgFactura.SelectedCells(7).Value = "Aprobada" Then
                    .dtpFacturacion.Visible = True
                    .dtpFacturacion.Enabled = False
                Else
                    .dtpFacturacion.Visible = False
                    .dtpFacturacion.Enabled = False
                End If

                .dtpCreacion.Text = Me.dvgFactura.SelectedCells(4).Value
                .dtpCreacion.Enabled = False
                .dtpCreacion.Visible = True
                .dtpValidez.Text = Me.dvgFactura.SelectedCells(5).Value
                .dtpValidez.Enabled = False
                .txtMoneda.Text = Me.dvgFactura.SelectedCells(6).Value
                .txtMoneda.Enabled = False
                .cmbEstado.Items.Clear()
                .cmbEstado.Items.Add("Proforma")
                .cmbEstado.Items.Add("Aprobada")
                .cmbEstado.Items.Add("Vencida")
                .cmbEstado.Text = Me.dvgFactura.SelectedCells(7).Value
                foramtearEstiloCmbEstado()
                .cmbEstado.Enabled = False
                .txtMonto.Text = Me.dvgFactura.SelectedCells(8).Value
                .txtMonto.Enabled = False
                .pbModificar2.Visible = True
                .txtCantidad.Enabled = False
                .cmbServicios.Enabled = False
                .pbAgregarDetalle.Visible = False
                .pbModificar2.Visible = False
                .pbEliminarDetalle.Visible = False
            End With
            cargarServicios()
            cargarLineasDetalle()
        End If
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
            Me.DgvDetalle.DataSource = _listTemp

            nombrarColumnasDevgFactura()
        Catch ex As Exception
            MessageBox.Show("Error en la operación ... " & ex.Message)
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
                _listTemp.Add(New ClsCastCadenaServicio(_tempCast(0).ToString(), _tempCast(1).ToString(), _tempCast(2).ToString(), _tempCast(3).ToString(), _tempCast(4).ToString(), _tempCast(5).ToString(), _tempCast(6).ToString(), _tempCast(7).ToString(), _tempCast(8).ToString(), _tempCast(9).ToString(), _tempCast(10).ToString())) 'agregar a la lista genérica una colección de la clase wrapper

            Next
            'asignar el fuente de dato para un control tipo listbox la lista genérica wrappeada
            Me.cmbServicios.DataSource = _listTemp
            Me.cmbServicios.DisplayMember = "nombreServicio"
            Me.cmbServicios.ValueMember = "codServicio"

            ' Formateando estilo del combo box 
            Me.cmbServicios.AutoCompleteSource = AutoCompleteSource.ListItems
            Me.cmbServicios.AutoCompleteMode = AutoCompleteMode.SuggestAppend
            Me.cmbServicios.DropDownStyle = ComboBoxStyle.DropDownList

        Catch ex As Exception
            MessageBox.Show("Error en la operación ... " & ex.Message)
        End Try
    End Sub

    Private Sub foramtearEstiloCmbEstado()
        ' Formateando estilo del combo box 
        Me.cmbEstado.AutoCompleteSource = AutoCompleteSource.ListItems
        Me.cmbEstado.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        Me.cmbEstado.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub


    Private Sub pbModificar2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbModificar2.Click
        Dim _result As DialogResult
        If cmbEstado.SelectedItem = "Aprobada" Then

            Dim data As DataSet = VentaDollar.ObtenerIndicadoresEconomicos("318", Now.Date.ToString.Substring(0, 10), Now.Date.ToString.Substring(0, 10), "Siscove", "n")
            Dim num As String = Me.txtNumero.Text
            Dim tipoDeCambio As Decimal = data.Tables(0).Rows(0).ItemArray(2)
            _result = MessageBox.Show("¿Está seguro que desea modificar la factura seleccionada?", "Modificar factura", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, 0, False)
            Try
                If _result = Windows.Forms.DialogResult.Yes Then
                    _gestor.aceptarFactura(num, tipoDeCambio)
                    MsgBox("Los datos de la factura se han modificado correctamente.", MsgBoxStyle.Information, "Modificar factura")
                    cargarFacturas()
                    Me.gbxModificarFactura.Visible = False
                End If
            Catch ex As Exception
                MessageBox.Show("Ha ocurrido un error en la operacion.", ex.Message)
            End Try
        Else
            MessageBox.Show("El estado actual de la factura es " & Me.cmbEstado.SelectedItem)
        End If
    End Sub

    Private Sub pbAgregarDetalle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbAgregarDetalle.Click
        Dim result As Boolean = evaluarEspacio()
        Dim _result As DialogResult

        If result Then
            _servicio(0) = CType(Me.cmbServicios.SelectedItem, ClsCastCadenaServicio).codServicio
            _servicio(1) = CStr(Me.txtCantidad.Text)
            If Me.txtMoneda.Text = "Colones" Then
                _servicio(2) = CType(Me.cmbServicios.SelectedItem, ClsCastCadenaServicio).precioColones
            Else
                _servicio(2) = CType(Me.cmbServicios.SelectedItem, ClsCastCadenaServicio).precioDolares
            End If
            _result = MessageBox.Show("¿Está seguro que desea agregar la linea de detalle seleccionada?", "Agregar Linea de Detalle", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, 0, False)
            Try
                If _result = Windows.Forms.DialogResult.Yes Then
                    _gestor.agregarLineaDetalle(Me.txtNumero.Text, _servicio)
                    MsgBox("Los datos de la linea de detalle se han agregado correctamente.", MsgBoxStyle.Information, "Agregar Linea de Detalle")
                    cargarLineasDetalle()
                    cargarMonto()
                    'cargarDetalle()
                End If
            Catch ex As Exception
                MsgBox("Los datos de la linea de detalle no se han agregado correctamente." & vbCrLf & ex.Message, MsgBoxStyle.Information, "Agregar Linea de Detalle")
            End Try

        End If
        
    End Sub

    Public Sub cargarMonto()
        Try
            Dim _listTemp As New List(Of ClsCastCadenaFactura) 'declarar una variable tipo lista genérica tipo clsCastCadena (Wrapper)
            Dim _tempCast() As String 'declarar una variable tipo arreglo de String

            _listaFactura = _gestor.buscarFactura(Me.txtNumero.Text) 'asignar el resultado de la búsqueda devuelto por un método del Gestor

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
            MessageBox.Show("Error en la operación ... " & ex.Message)
        End Try

    End Sub

    Public Function evaluarEspacio() As Boolean
        Dim _resul As Boolean = False

        If Me.txtCantidad.Text = "" Then
            MessageBox.Show("La cantidad a facturar del servicio selecionado es un dato requerido")
            Me.txtCantidad.Focus()
        Else
            _resul = True
        End If
        Return _resul
    End Function

    Private Sub pbEliminarDetalle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbEliminarDetalle.Click
        Dim codServicio As String = DgvDetalle.SelectedCells(0).Value
        Dim _num As String = Me.txtNumero.Text
        Dim _result As DialogResult
        If Me.DgvDetalle.Rows.Count() > 1 Then
            _result = MessageBox.Show("¿Está seguro que desea eliminar la linea de detalle seleccionada?", "Eliminar Linea de Detalle", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, 0, False)
            Try
                If _result = Windows.Forms.DialogResult.Yes Then
                    _gestor.eliminarLineaDetalle(_num, codServicio)
                    MsgBox("Los datos de la linea de detalle se han eliminado correctamente.", MsgBoxStyle.Information, "Eliminar Linea de Detalle")
                    cargarLineasDetalle()
                    cargarMonto()
                End If
            Catch ex As Exception
                MsgBox("Los datos de la linea de detalle no se han eliminado correctamente." & vbCrLf & ex.Message, MsgBoxStyle.Information, "Eliminar Linea de Detalle")
            End Try
        Else
            MsgBox("Proceso no completado. El detalle de la factura debe al menos contar con una linea de detalle.", MsgBoxStyle.Information, "Eliminar Linea de Detalle")
        End If
    End Sub

    Public Sub nombrarColumnasDevgFactura()
        Me.DgvDetalle.Columns(0).HeaderText = "Codigo"
        Me.DgvDetalle.Columns(1).HeaderText = "Nombre"
        Me.DgvDetalle.Columns(2).HeaderText = "Cantidad"
        Me.DgvDetalle.Columns(3).HeaderText = "Precio"
    End Sub

    Private Sub txtCriterio_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCriterio.TextChanged
        If Me.txtCriterio.Text = "" Then
            cargarFacturas()
        Else
            buscarFacturaAprox(Me.txtCriterio.Text)
        End If
        Me.gbxModificarFactura.Visible = False

    End Sub

    Private Sub buscarFacturaAprox(ByVal pnum As String)
        Try
            Dim _listTemp As New List(Of ClsCastCadenaFactura) 'declarar una variable tipo lista genérica tipo clsCastCadena (Wrapper)
            Dim _tempCast() As String 'declarar una variable tipo arreglo de String

            _listaFactura = _gestor.buscarFacturaPorAprox(pnum) 'asignar el resultado de la búsqueda devuelto por un método del Gestor

            For i As Integer = 0 To _listaFactura.Count - 1 'estructura iterativa tipo matriz para recorrer y envolver por el tipo adecuado

                _tempArray = _listaFactura(i) 'clonar a un Array temporal la FILA (ROW) de la consulta
                ReDim _tempCast(_tempArray.Length() - 1) 'redimensionar el arreglo a un tamaño indicado

                For j As Integer = 0 To _tempArray.Length - 1 'recorrer la parte interna de la matriz, columna (COLUMN)
                    _tempCast(j) = _tempArray.GetValue(j).ToString() 'asignar el valor de cada celda 
                Next

                _listTemp.Add(New ClsCastCadenaFactura(_tempCast(0).ToString(), _tempCast(1).ToString(), _tempCast(2).ToString(), _tempCast(3).ToString(), _tempCast(4).ToString(), _tempCast(5).ToString(), _tempCast(6).ToString(), _tempCast(7).ToString(), _tempCast(8).ToString(), _tempCast(9).ToString())) 'agregar a la lista genérica una colección de la clase wrapper

            Next

            Me.dvgFactura.DataSource = _listTemp 'asignar el fuente de dato para un control tipo datagridview la lista genérica wrappeada
            nombrarColumnas()
        Catch ex As Exception
            MsgBox("Error en la operación ... " & ex.Message, MsgBoxStyle.Information, "Buscar Factura")
        End Try

    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint
        validarRoles()
    End Sub
End Class
