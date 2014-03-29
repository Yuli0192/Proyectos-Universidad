Public Class ctlListarComision
    Dim _gestor As New CllLogicaNegocio.ClsGestor() 'declaración e instanciación de la clase Gestor

    Private Sub ctlListarComision_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cargarVendedores()
    End Sub

    Private Sub cmbListar_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbListar.SelectedIndexChanged
        limpiar()
    End Sub

    Private Sub dtpInicio_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpInicio.ValueChanged
        Me.gpbVerComision.Visible = False
    End Sub

    Private Sub dtpFin_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpFin.ValueChanged
        Me.gpbVerComision.Visible = False
    End Sub

    Private Sub pbVerComision_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbVerComision.Click
        Dim _resul As Boolean
        _resul = evaluarEspacio()
        Me.dvgComision.DataSource = ""
        If _resul Then
            Me.gpbVerComision.Visible = True
            Dim _fechaInicio As Date = Me.dtpInicio.Value
            Dim _fechaFin As Date = Me.dtpFin.Value
            Dim _idUsuario As String = ""

            If ROL_USUARIO.Contains("Gerente") Then
                _idUsuario = Me.cmbListar.SelectedValue.ToString()

            ElseIf ROL_USUARIO.Contains("Vendedor") Then
                _idUsuario = DATOS_USUARIO(3)

            End If

            listarComisionVendedor(_idUsuario, _fechaInicio, _fechaFin) 'invocar el método indicado enviando los argumentos requeridos.
        End If
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
            MsgBox("Error en la operación ... " & ex.Message, MsgBoxStyle.Information, "Aviso")
        End Try
    End Sub

    ''' <summary>
    ''' Método de clase, encargado de cargar todos las comisiones de un vendedor existentes en la DB suministrando un rango de fechas
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub listarComisionVendedor(ByVal pidUsuario As String, ByVal pfechaInicio As Date, ByVal pfechaFin As Date)
        Try
            Dim _listTemp As New List(Of ClsCastCadenaComision) 'declarar una variable tipo lista genérica tipo clsCastCadena (Wrapper)
            Dim _listaComision As List(Of Array) = New List(Of Array)() 'declarar una variable tipo lista genérica de Array
            Dim _tempCast() As String 'declarar una variable tipo arreglo de String
            Dim _tempArray As Array 'declarar una variable tipo Array

            _listaComision = _gestor.listarComisionPorVendedor(pidUsuario, pfechaInicio, pfechaFin) 'asignar el resultado de la búsqueda devuelto por un método del Gestor
            For i As Integer = 0 To _listaComision.Count - 1 'estructura iterativa tipo matriz para recorrer y envolver por el tipo adecuado

                _tempArray = _listaComision(i) 'clonar a un Array temporal la FILA (ROW) de la consulta
                ReDim _tempCast(_tempArray.Length() - 1) 'redimensionar el arreglo a un tamaño indicado

                For j As Integer = 0 To _tempArray.Length - 1 'recorrer la parte interna de la matriz, columna (COLUMN)
                    _tempCast(j) = _tempArray.GetValue(j).ToString() 'asignar el valor de cada celda 
                Next

                _listTemp.Add(New ClsCastCadenaComision(_tempCast(0).ToString(), _tempCast(1).ToString(), _tempCast(2).ToString(), _tempCast(3).ToString(), _
                                                        _tempCast(4).ToString(), _tempCast(5).ToString(), _tempCast(6).ToString(), _tempCast(7).ToString(), _
                                                        _tempCast(8).ToString(), _tempCast(9).ToString(), _tempCast(10).ToString(), _tempCast(11).ToString(), _
                                                        _tempCast(12).ToString(), _tempCast(13).ToString(), _tempCast(14).ToString(), _tempCast(15).ToString())) 'agregar a la lista genérica una colección de la clase wrapper
            Next

            Me.dvgComision.DataSource = _listTemp 'asignar el fuente de dato para un control tipo datagridview la lista genérica wrappeada
            nombrarColumnas()
            invisible()

        Catch ex As Exception
            MsgBox("Error en la operación ... " & ex.Message, MsgBoxStyle.Information, "Aviso")
        End Try

    End Sub

    ''' <summary>
    ''' Método de clase, encarga de renombrar los encabezados al datagridview
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub nombrarColumnas()
        dvgComision.Columns(1).HeaderText = "Tipo Comisión"
        dvgComision.Columns(11).HeaderText = "Monto Comisión"
        dvgComision.Columns(12).HeaderText = "Estado Comisión"
    End Sub

    ''' <summary>
    ''' Método de clase, encarga de poner invisible algunas calumnas al datagridview
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub invisible()
        dvgComision.Columns(0).Visible = False
        dvgComision.Columns(2).Visible = False
        dvgComision.Columns(3).Visible = False
        dvgComision.Columns(4).Visible = False
        dvgComision.Columns(5).Visible = False
        dvgComision.Columns(6).Visible = False
        dvgComision.Columns(7).Visible = False
        dvgComision.Columns(8).Visible = False
        dvgComision.Columns(9).Visible = False
        dvgComision.Columns(10).Visible = False
        dvgComision.Columns(13).Visible = False
        dvgComision.Columns(14).Visible = False
        dvgComision.Columns(15).Visible = False
    End Sub
    Public Sub limpiar()
        Me.gpbVerComision.Visible = False
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
