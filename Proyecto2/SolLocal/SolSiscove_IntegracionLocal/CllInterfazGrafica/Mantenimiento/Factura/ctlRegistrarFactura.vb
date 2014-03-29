Imports CllLogicaNegocio

Public Class ctlRegistrarFactura

    Dim _gestor As New ClsGestor() 'declara e instancia de la clase Gestor
    Dim _num As String
    Dim _idCliente As String
    Dim _fechaValidez As Date
    Dim _moneda As String
    Dim _servicio(2) As String
    Dim _tempArray As Array
    Dim _listaFactura As List(Of Array) = New List(Of Array)
    Dim _idServicio As String
    Dim _countLineasAgregadas = 0

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
            MsgBox("Error en la operación: " & ex.Message, MsgBoxStyle.Information, "Error")
        End Try
    End Sub

    Private Sub ctlRegistrarFactura_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cargarServicios()
        cargarClientes()
        Me.txtNumero.Focus()
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
            Me.cmbCliente.DataSource = _listTemp
            Me.cmbCliente.DisplayMember = "nombreCliente"
            Me.cmbCliente.ValueMember = "idCliente"
            Me.cmbCliente.AutoCompleteSource = AutoCompleteSource.ListItems
            Me.cmbCliente.AutoCompleteMode = AutoCompleteMode.SuggestAppend
            Me.cmbCliente.DropDownStyle = ComboBoxStyle.DropDownList
            Me.cmbCliente.SelectedIndex = 0

            ' Formateando estilo del combo box moneda 
            Me.cmbMoneda.AutoCompleteSource = AutoCompleteSource.ListItems
            Me.cmbMoneda.AutoCompleteMode = AutoCompleteMode.SuggestAppend
            Me.cmbMoneda.DropDownStyle = ComboBoxStyle.DropDownList
            'Me.cmbMoneda.SelectedIndex = 0
        Catch ex As Exception
            MsgBox("Error en la operación: " & ex.Message, MsgBoxStyle.Information, "Error")

        End Try
    End Sub

    Public Function evaluarEspacio() As Boolean
        Dim _resul As Boolean = False

        If Me.txtNumero.Text = "" Then
            MsgBox("El número de factura es un dato requerido.", MsgBoxStyle.Information, "Error al registrar")
            Me.txtNumero.Focus()
        ElseIf IsNumeric(Me.txtNumero.Text) = False Then
            MsgBox("El número de factura es debe ser solamente de caracteres numericos.", MsgBoxStyle.Information, "Error al registrar")
            Me.txtNumero.Focus()
        ElseIf DateDiff(DateInterval.Day, Now.Date, Me.dtpValidez.Value) <= 0 Then
            MsgBox("La fecha máxima de válidez debe ser posterior al día de hoy.", MsgBoxStyle.Information, "Error al registrar")
            Me.dtpValidez.Focus()
        ElseIf _moneda Is Nothing Or _moneda.Equals("") Then
            MsgBox("La moneda es un dato requerido.", MsgBoxStyle.Information, "Error al registrar")
        ElseIf Me.txtCantidad.Text = "" Then
            MsgBox("La cantidad a facturar del servicio seleccionado es un dato requerido.", MsgBoxStyle.Information, "Error al registrar")
            Me.txtCantidad.Focus()
        Else
            _resul = True
        End If
        Return _resul
    End Function

    Private Sub inhabilitarContorles()
        Me.txtNumero.Enabled = False
        Me.cmbCliente.Enabled = False
        Me.dtpValidez.Enabled = False
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

        Catch ex As Exception
            MsgBox("Error en la operación: " & ex.Message, MsgBoxStyle.Information, "Error")
        End Try
    End Sub

    Public Sub cargarMonto()
        Try
            Dim _listTemp As New List(Of ClsCastCadenaFactura) 'declarar una variable tipo lista genérica tipo clsCastCadena (Wrapper)
            Dim _tempCast() As String 'declarar una variable tipo arreglo de String

            _listaFactura = _gestor.buscarFactura(_num) 'asignar el resultado de la búsqueda devuelto por un método del Gestor

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
            MsgBox("Error en la operación: " & ex.Message, MsgBoxStyle.Information, "Error")

        End Try

    End Sub

    Private Sub cmbServicios_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        _idServicio = CType(Me.cmbServicios.SelectedItem, ClsCastCadenaServicio).codServicio
    End Sub

    Private Sub pbRegistrar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbRegistrar.Click

        Dim result As Boolean = evaluarEspacio()
        If _countLineasAgregadas = 0 Then
            If result Then
                _num = Me.txtNumero.Text
                _idCliente = CType(Me.cmbCliente.SelectedItem, ClsCastCadenaCliente).idCliente
                _fechaValidez = dtpValidez.Value
                _moneda = cmbMoneda.Text
                _servicio(0) = CType(Me.cmbServicios.SelectedItem, ClsCastCadenaServicio).codServicio
                _servicio(1) = Me.txtCantidad.Text
                If _moneda = "Colones" Then
                    _servicio(2) = CType(Me.cmbServicios.SelectedItem, ClsCastCadenaServicio).precioColones
                Else
                    _servicio(2) = CType(Me.cmbServicios.SelectedItem, ClsCastCadenaServicio).precioDolares
                End If

                Try
                    _gestor.registrarFactura(_num, _idCliente, _fechaValidez, _moneda, _servicio)
                    inhabilitarContorles()
                    MsgBox("La factura se ha registrado correctamente, si desea puede agregarle otra linea de detalle", MsgBoxStyle.Information)
                    cargarLineasDetalle()
                    cargarMonto()
                    _countLineasAgregadas = _countLineasAgregadas + 1

                    'cargarDetalle()
                Catch ex As Exception
                    If ex.Message.Contains("dbo.tfactura") Then
                        MsgBox("El número de factura ya existe.", "Error al tratar de registrar la factura.", MessageBoxIcon.Error)

                    Else
                        MsgBox("Error en la operación: " & ex.Message, MsgBoxStyle.Information, "Error")
                    End If
                End Try
            End If
        Else
            _servicio(0) = CType(Me.cmbServicios.SelectedItem, ClsCastCadenaServicio).codServicio
            _servicio(1) = Me.txtCantidad.Text
            If _moneda = "Colones" Then
                _servicio(2) = CType(Me.cmbServicios.SelectedItem, ClsCastCadenaServicio).precioColones
            Else
                _servicio(2) = CType(Me.cmbServicios.SelectedItem, ClsCastCadenaServicio).precioDolares
            End If

            Try
                _gestor.agregarLineaDetalle(_num, _servicio)
                MsgBox("La linea de detalle se ha registrado correctamente, si desea puede agregarle otra linea de detalle", MsgBoxStyle.Information, "Información")
                cargarLineasDetalle()
                cargarMonto()

                'cargarDetalle()
            Catch ex As Exception
                MsgBox("Error en la operación: " & ex.Message, MsgBoxStyle.Information, "Error")
            End Try
        End If

    End Sub

    Private Sub cmbMoneda_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbMoneda.SelectedIndexChanged
        _moneda = cmbMoneda.SelectedItem.ToString
        cmbMoneda.Enabled = False
    End Sub

    Private Sub pbLimpiarForm_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbLimpiarForm.Click
        _num = ""
        _idServicio = ""
        _countLineasAgregadas = 0
        cargarServicios()
        cargarClientes()
        Me.txtNumero.Text = ""
        Me.txtNumero.Enabled = True
        Me.dtpValidez.Enabled = True
        Me.cmbCliente.Enabled = True
        Me.txtMonto.Text = ""
        Me.txtCantidad.Text = ""
        Me.cmbMoneda.Enabled = True
        Me.DgvDetalle.DataSource = ""
        Me.txtNumero.Focus()
    End Sub
End Class
