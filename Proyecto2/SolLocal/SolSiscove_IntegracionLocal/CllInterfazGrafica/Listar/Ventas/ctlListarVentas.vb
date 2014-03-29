Public Class ctlListarVentas
    Dim _gestor As New CllLogicaNegocio.ClsGestor() 'declaración e instanciación de la clase Gestor
    Private _idGrupo As String = ""

    Public Sub New(ByVal pidGrupo As String)
        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _idGrupo = pidGrupo

    End Sub

    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
    End Sub

    Private Sub ctlListarVentas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Not _idGrupo.Equals("") Then
            cargarVendedoresPorIdGrupo()

        Else
            cargarVendedores()

        End If
    End Sub

    Private Sub cmbListar_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbListar.SelectedIndexChanged
        limpiar()
    End Sub

    Private Sub dtpInicio_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpInicio.ValueChanged
        Me.gpbVentas.Visible = False
        Me.gpbVentasVendedor.Visible = False
    End Sub

    Private Sub dtpFin_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpFin.ValueChanged
        Me.gpbVentas.Visible = False
        Me.gpbVentasVendedor.Visible = False
    End Sub

    Public Sub limpiar()
        Me.gpbVentasVendedor.Visible = False
        Me.pbVerVentas.Visible = False
        Me.gpbVentas.Visible = False
    End Sub

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
            Me.cmbListar.DataSource = _listTemp
            'Me.cmbListar.DisplayMember = "cedula"
            Me.cmbListar.ValueMember = "cedula"

        Catch ex As Exception
            MsgBox("Error en la operación ... " & ex.Message, MsgBoxStyle.Information, "Buscar Vendedores")
        End Try
    End Sub

    Private Function buscarEncargadoGrupo() As String()
        Dim datos(3) As String

        Dim _listaGrupo As List(Of Array)
        Dim _listaUsuario As List(Of Array)

        _listaGrupo = _gestor.buscarGrupoPorAprox(_idGrupo)

        'declarar una variable tipo Array
        Dim _tempArray As Array

        'clonar a un Array temporal la FILA (ROW) de la consulta
        _tempArray = _listaGrupo(0)

        'asignar el valor de cada celda 
        Dim codUsuario As String = _tempArray.GetValue(2).ToString()

        _listaUsuario = _gestor.buscarUsuarioId(codUsuario)
        _tempArray = _listaUsuario(0)

        'asignar el valor de cada celda 
        Dim nom As String = _tempArray.GetValue(1).ToString()
        Dim ape1 As String = _tempArray.GetValue(2).ToString()
        Dim ape2 As String = _tempArray.GetValue(3).ToString()

        datos(0) = codUsuario
        datos(1) = nom
        datos(2) = ape1
        datos(3) = ape2
        Return datos
    End Function
    ''' <summary>
    ''' Método de clase, encargado de cargar todos los vendedores existentes en la DB
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub cargarVendedoresPorIdGrupo()
        Try
            'declarar una variable tipo lista genérica de Array
            Dim _listaUsuario As List(Of Array)


            'asignar el resultado de la búsqueda devuelto por un método del Gestor
            _listaUsuario = _gestor.buscarUsuariosDeUnGrupoDeVentas(_idGrupo) 'asignar el resultado de la búsqueda devuelto por un método del Gestor
            Dim datosEnc As String() = buscarEncargadoGrupo()

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

            'Agregamos el encargado a la lista.
            _listTemp.Add(New ClsCastCadenaUsuario(datosEnc(0), datosEnc(1), datosEnc(2), datosEnc(3), "", "", ""))
            'asignar el fuente de dato para un control tipo ComboBox la lista genérica wrappeada
            Me.cmbListar.DataSource = _listTemp
            Me.cmbListar.DisplayMember = "nombreCompleto"
            Me.cmbListar.ValueMember = "cedula"

        Catch ex As Exception
            MsgBox("Error en la operación ... " & ex.Message, MsgBoxStyle.Information, "Buscar Vendedores")
        End Try
    End Sub

    Private Sub pbBuscarVentas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbBuscarVentas.Click
        Dim _resul As Boolean
        _resul = evaluarEspacio()
        If _resul Then
            Me.gpbVentasVendedor.Visible = True
            Me.pbVerVentas.Visible = True
            Dim _fechaInicio As Date = Me.dtpInicio.Value
            Dim _fechaFin As Date = Me.dtpFin.Value
            Dim _idUsuario As String = ""

            If ROL_USUARIO.Contains("Gerente") Then
                _idUsuario = Me.cmbListar.SelectedValue.ToString()

            ElseIf ROL_USUARIO.Contains("Vendedor") Then
                _idUsuario = DATOS_USUARIO(3)

            End If


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

            Me.dvgFactura.DataSource = _listTemp 'asignar el fuente de dato para un control tipo datagridview la lista genérica wrappeada

            nombrarColumnas()
            invisible()

        Catch ex As Exception
            MsgBox("Error en la operación ... " & ex.Message, MsgBoxStyle.Information, "Buscar Ventas")
        End Try

    End Sub
    ''' <summary>
    ''' Método de clase, encarga de renombrar los encabezados al datagridview
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub nombrarColumnas()
        dvgFactura.Columns(0).HeaderText = "Número Factura"
        dvgFactura.Columns(1).HeaderText = "Cliente"
    End Sub

    ''' <summary>
    ''' Método de clase, encarga de poner invisible algunas calumnas al datagridview
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub invisible()
        dvgFactura.Columns(2).Visible = False
        dvgFactura.Columns(3).Visible = False
        dvgFactura.Columns(4).Visible = False
        dvgFactura.Columns(5).Visible = False
        dvgFactura.Columns(6).Visible = False
        dvgFactura.Columns(7).Visible = False
        dvgFactura.Columns(8).Visible = False
        dvgFactura.Columns(9).Visible = False
    End Sub

    ''' <summary>
    ''' Método de clase, encarga de evaluar que no queden espacios en blanco ningún componente
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function evaluarEspacio() As Boolean
        Dim _resul As Boolean

        If dtpInicio.Value > dtpFin.Value Then
            MsgBox("La fecha inicio debe ser menor q la fecha fin ", MsgBoxStyle.Information, "Buscar Usuario")
        Else
            _resul = True
        End If
        Return _resul
    End Function

    Private Sub pbVerVentas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbVerVentas.Click
        If Not dvgFactura.RowCount = 0 Then
            Me.gpbVentas.Visible = True
            Dim _listaFactura As List(Of Array) = New List(Of Array)() 'declarar una variable tipo lista genérica de Array
            Dim _num As String = dvgFactura.SelectedCells(0).Value
            Dim _idCliente As String = dvgFactura.SelectedCells(1).Value
            Me.txtNum.Text = _num
            Me.txtCliente.Text = _idCliente
            Me.txtFechaFacturacion.Text = dvgFactura.SelectedCells(3).Value
            Me.txtMonto.Text = dvgFactura.SelectedCells(8).Value
            cargarLineasDetalle()
        End If
    End Sub

    ''' <summary>
    ''' Método de clase, encargado de cargar todos las lineas de detalle de la factura seleccionada 
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub cargarLineasDetalle()
        Try
            Dim _lineasDetalle As List(Of Array) = New List(Of Array)() 'declarar una variable tipo lista genérica de Array

            _lineasDetalle = _gestor.buscarDetalleFactura(Me.txtNum.Text) 'asignar el resultado de la búsqueda devuelto por un método del Gestor

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
            Me.dvgLineaDetalle.DataSource = _listTemp

        Catch ex As Exception
            MsgBox("Error en la operación ... " & ex.Message, MsgBoxStyle.Information, "Aviso")
        End Try
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint
        If ROL_USUARIO.Contains("Gerente") Then
            lblCedula.Text = "Cédula Usuario"
            cmbListar.Visible = True

        ElseIf ROL_USUARIO.Contains("Vendedor") Then
            lblCedula.Text = "Cédula Usuario: " & DATOS_USUARIO(3)
            cmbListar.Visible = False

        End If
    End Sub
End Class
