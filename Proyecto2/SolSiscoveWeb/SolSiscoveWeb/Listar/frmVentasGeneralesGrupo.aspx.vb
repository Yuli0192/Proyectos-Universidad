Public Partial Class frmVentasGeneralesGrupo
    Inherits System.Web.UI.Page
    Dim _gestor As New CllLogicaNegocio.ClsGestor

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            cargarGrupoDeVenta()
        End If
    End Sub

    Public Sub limpiar()
        gridGrupo.Visible = False
        lblVentasGenerales.Visible = False
        lblFacturas.Visible = False
        lblCodigoGrupo.Visible = False
        lblMontoTotal.Visible = False
        txtCodigoGrupo.Visible = False
        txtMontoTotal.Visible = False

    End Sub

    ''' <summary>
    ''' Método de clase, encargado de cargar todos los grupo de ventas existentes en la DB
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub cargarGrupoDeVenta()
        Try
            'declarar una variable tipo lista genérica de Array
            Dim _listaGrupo As List(Of Array) = New List(Of Array)()

            'asignar el resultado de la búsqueda devuelto por un método del Gestor
            _listaGrupo = _gestor.listarGrupoDeVenta()
            'declarar una variable tipo Array
            Dim _tempArray As Array
            'declarar una variable tipo lista genérica tipo clsCastCadena (Wrapper)
            Dim _listTemp As New List(Of ClsCastCadenaGrupoDeVenta)

            'declarar una variable tipo arreglo de String
            Dim _tempCast() As String

            'estructura iterativa tipo matriz para recorrer y envolver por el tipo adecuado
            For i As Integer = 0 To _listaGrupo.Count - 1
                'clonar a un Array temporal la FILA (ROW) de la consulta
                _tempArray = _listaGrupo(i)
                'redimensionar el arreglo a un tamaño indicado
                ReDim _tempCast(_tempArray.Length() - 1)

                'recorrer la parte interna de la matriz, columna (COLUMN)
                For j As Integer = 0 To _tempArray.Length - 1
                    'asignar el valor de cada celda 
                    _tempCast(j) = _tempArray.GetValue(j).ToString()
                Next

                'agregar a la lista genérica una colección de la clase wrapper
                _listTemp.Add(New ClsCastCadenaGrupoDeVenta(_tempCast(0).ToString(), _tempCast(1).ToString(), _tempCast(2).ToString()))

            Next

            'asignar el fuente de dato para un control tipo ComboBox la lista genérica wrappeada
            Me.cmbListar.DataSource = _listTemp
            Me.cmbListar.DataTextField = "codigo"
            cmbListar.DataBind()

        Catch ex As Exception
            MsgBox("Error en la operación ... " & ex.Message, MsgBoxStyle.Information, "Aviso")
        End Try
    End Sub

    ''' <summary>
    ''' Método de clase, encarga de evaluar que no queden espacios en blanco ningún componente
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function evaluarEspacio() As Boolean
        Dim _resul As Boolean

        If dtpFechaInicio.SelectedDate >= dtpFechaFin.SelectedDate Then
            MsgBox("La fecha inicio debe ser menor que la fecha fin ", MsgBoxStyle.Information, "Buscar Usuario")
        Else
            _resul = True
        End If
        Return _resul
    End Function

    Protected Sub dpdlCedula_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cmbListar.SelectedIndexChanged
        limpiar()

    End Sub

    Protected Sub bntBuscarGrupos_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles bntBuscarGrupos.Click
        Dim _resul As Boolean
        _resul = evaluarEspacio()
        limpiar()
        If _resul Then
            Dim _fechaInicio As Date = Me.dtpFechaInicio.SelectedDate
            Dim _fechaFin As Date = Me.dtpFechaFin.SelectedDate
            Dim _codGrupo As String = Me.cmbListar.SelectedValue.ToString

            buscarFacturaPorGrupoVenta(_codGrupo, _fechaInicio, _fechaFin) 'invocar el método indicado enviando los argumentos requeridos.
        End If
    End Sub

    ''' <summary>
    ''' Método de clase, encargado de cargar todos las facturas existentes en la DB suministrando un rango de fechas
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub buscarFacturaPorGrupoVenta(ByVal pcodGrupo As String, ByVal pfechaInicio As Date, ByVal pfechaFin As Date)
        Try
            Dim _listTemp As New List(Of ClsCastCadenaFactura) 'declarar una variable tipo lista genérica tipo clsCastCadena (Wrapper)
            Dim _listaFactura As List(Of Array) = New List(Of Array)() 'declarar una variable tipo lista genérica de Array
            Dim _tempCast() As String 'declarar una variable tipo arreglo de String
            Dim _tempArray As Array 'declarar una variable tipo Array

            _listaFactura = _gestor.obtenerVentasGeneralesGrupo(pcodGrupo, pfechaInicio, pfechaFin) 'asignar el resultado de la búsqueda devuelto por un método del Gestor

            For i As Integer = 0 To _listaFactura.Count - 1 'estructura iterativa tipo matriz para recorrer y envolver por el tipo adecuado

                _tempArray = _listaFactura(i) 'clonar a un Array temporal la FILA (ROW) de la consulta
                ReDim _tempCast(_tempArray.Length() - 1) 'redimensionar el arreglo a un tamaño indicado

                For j As Integer = 0 To _tempArray.Length - 1 'recorrer la parte interna de la matriz, columna (COLUMN)
                    _tempCast(j) = _tempArray.GetValue(j).ToString() 'asignar el valor de cada celda 
                Next

                _listTemp.Add(New ClsCastCadenaFactura(_tempCast(0).ToString(), _tempCast(1).ToString(), _tempCast(2).ToString(), _tempCast(3).ToString(), _tempCast(4).ToString(), _tempCast(5).ToString(), _tempCast(6).ToString(), _tempCast(7).ToString(), _tempCast(8).ToString(), _tempCast(9).ToString())) 'agregar a la lista genérica una colección de la clase wrapper
            Next
            obtenerMontoTotal()
            Me.gridGrupo.DataSource = _listTemp 'asignar el fuente de dato para un control tipo datagridview la lista genérica wrappeada
            Me.gridGrupo.DataBind()

        Catch ex As Exception
            MsgBox("Error en la operación ... " & ex.Message, MsgBoxStyle.Information, "Aviso")
        End Try

    End Sub

    ''' <summary>
    ''' Método de clase, encargado de obtener  el monto total de todos las facturas existentes en la DB suministrando un rango de fechas
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub obtenerMontoTotal()
        Dim _montoTotal As Decimal
        Try

            _montoTotal = _gestor.obtenerMontoTotalVentasGeneralesGrupo() 'asignar el resultado de la búsqueda devuelto por un método del Gestor
            If Not _montoTotal = 0 Then
                lblCodigoGrupo.Visible = True
                lblFacturas.Visible = True
                lblVentasGenerales.Visible = True
                lblMontoTotal.Visible = True
                txtCodigoGrupo.Visible = True
                txtMontoTotal.Visible = True
                gridGrupo.Visible = True
                txtCodigoGrupo.Text = Me.cmbListar.SelectedValue.ToString
                txtMontoTotal.Text = _montoTotal
            Else
                MsgBox("No se ha encontrado ningún dato con el criterio suministrado.", MsgBoxStyle.Information, "Aviso")

            End If
        Catch ex As Exception
            MsgBox("Error en la operación ... " & ex.Message, MsgBoxStyle.Information, "Aviso")
        End Try

    End Sub

End Class