Public Class ctlListarVentasGenerales
    Private _idGrupo As String = ""

    Public Sub New(ByVal pidGrupo As String)
        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _idGrupo = pidGrupo

    End Sub

    Dim _gestor As New CllLogicaNegocio.ClsGestor() 'declaración e instanciación de la clase Gestor

    Private Sub ctlListarVentasGenerales_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblCod.Text = "Código Grupo: " & _idGrupo
        gpbVentasGeneral.Visible = False
    End Sub

    Private Sub cmbListar_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        limpiar()
    End Sub

    Private Sub dtpInicio_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpInicio.ValueChanged
        Me.gpbVentasGeneral.Visible = False
    End Sub

    Private Sub dtpFin_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpFin.ValueChanged
        Me.gpbVentasGeneral.Visible = False
    End Sub

    Private Sub pbVerVentas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbVerVentas.Click
        verVentas()
    End Sub

    Private Sub verVentas()
        Dim _resul As Boolean
        _resul = evaluarEspacio()
        Me.gpbVentasGeneral.Visible = False
        If _resul Then
            Dim _fechaInicio As Date = Me.dtpInicio.Value
            Dim _fechaFin As Date = Me.dtpFin.Value

            buscarFacturaPorGrupoVenta(_idGrupo, _fechaInicio, _fechaFin) 'invocar el método indicado enviando los argumentos requeridos.
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
            Me.dvgFactura.DataSource = _listTemp 'asignar el fuente de dato para un control tipo datagridview la lista genérica wrappeada

            nombrarColumnas()
            invisible()

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
                Me.gpbVentasGeneral.Visible = True
                txtCodGrupo.Text = _idGrupo
                txtMonto.Text = _montoTotal
            Else
                MsgBox("No se ha encontrado ningún dato con el criterio suministrado.", MsgBoxStyle.Information, "Aviso")
                limpiar()
            End If
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

        If dtpInicio.Value > dtpFin.Value Then
            MsgBox("La fecha inicio debe ser menor q la fecha fin ", MsgBoxStyle.Information, "Aviso")
        Else
            _resul = True
        End If
        Return _resul
    End Function

    ''' <summary>
    ''' Método de clase, encarga de renombrar los encabezados al datagridview
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub nombrarColumnas()
        dvgFactura.Columns(0).HeaderText = "Número Factura"
        dvgFactura.Columns(1).HeaderText = "Cliente"
        dvgFactura.Columns(2).HeaderText = "Usuario"
        dvgFactura.Columns(3).HeaderText = "Fecha Facturación"
        dvgFactura.Columns(8).HeaderText = "Monto"
    End Sub

    ''' <summary>
    ''' Método de clase, encarga de poner invisible algunas calumnas al datagridview
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub invisible()
        dvgFactura.Columns(4).Visible = False
        dvgFactura.Columns(5).Visible = False
        dvgFactura.Columns(6).Visible = False
        dvgFactura.Columns(7).Visible = False
        dvgFactura.Columns(9).Visible = False
    End Sub

    Public Sub limpiar()
        Me.gpbVentasGeneral.Visible = False
    End Sub

End Class
