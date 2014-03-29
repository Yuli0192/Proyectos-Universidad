Imports CllLogicaNegocio

Public Class ctlBuscarGrupo

    Dim _gestor As New ClsGestor() 'declara e instancia de la clase Gestor
    Dim _listaGrupo As List(Of Array) = New List(Of Array)
    Dim _tempArray As Array 'declarar una variable tipo Array
    Dim _criterio As String
    Dim _idGrupo As String
    Dim _listaServicios As ArrayList = New ArrayList()
    Dim _listaVendedores As ArrayList = New ArrayList()
    Private _frmSiscove As frmSiscove

    Public Sub New(ByVal pfrmSiscove As frmSiscove)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _frmSiscove = pfrmSiscove
    End Sub

    Private Sub ctlBuscarGrupo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cargarGrupos()
        Me.txtCriterio.Focus()
        Me.gbxRegistrarGrupo.Visible = False
        Me.gbxServicios.Visible = False
        Me.gbxVendedores.Visible = False
    End Sub

    Public Sub cargarGrupos()
        Try
            Dim _listTemp As New List(Of ClsCastCadenaGrupo) 'declarar una variable tipo lista genérica tipo clsCastCadena (Wrapper)
            Dim _tempCast() As String 'declarar una variable tipo arreglo de String

            _listaGrupo = _gestor.listarGrupos() 'asignar el resultado de la búsqueda devuelto por un método del Gestor

            For i As Integer = 0 To _listaGrupo.Count - 1 'estructura iterativa tipo matriz para recorrer y envolver por el tipo adecuado

                _tempArray = _listaGrupo(i) 'clonar a un Array temporal la FILA (ROW) de la consulta
                ReDim _tempCast(_tempArray.Length() - 1) 'redimensionar el arreglo a un tamaño indicado

                For j As Integer = 0 To _tempArray.Length - 1 'recorrer la parte interna de la matriz, columna (COLUMN)
                    _tempCast(j) = _tempArray.GetValue(j).ToString() 'asignar el valor de cada celda 
                Next

                _listTemp.Add(New ClsCastCadenaGrupo(_tempCast(0).ToString(), _tempCast(1).ToString(), _tempCast(2).ToString())) 'agregar a la lista genérica una colección de la clase wrapper

            Next

            Me.dvgGrupo.DataSource = _listTemp 'asignar el fuente de dato para un control tipo datagridview la lista genérica wrappeada
            nombrarColumnas()
            invisible()

        Catch ex As Exception
            MessageBox.Show("Error en la operación ... " & ex.Message)
        End Try
    End Sub

    Public Sub nombrarColumnas()
        dvgGrupo.Columns(0).HeaderText = "Codigo del Grupo"
        dvgGrupo.Columns(1).HeaderText = "Descripcion"
    End Sub

    Public Sub invisible()
        dvgGrupo.Columns(2).Visible = False

    End Sub

    Private Sub pbBuscarGrupo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim result As Boolean = evaluarCriterio()
        If result Then
            _criterio = Me.txtCriterio.Text
            buscarGrupoXCod(_criterio)

        End If
    End Sub

    Public Function evaluarCriterio() As Boolean
        Dim _resul As Boolean = False

        If Me.txtCriterio.Text = "" Then
            MessageBox.Show("El codigo del grupo de ventas es un dato requerido para la busqueda")
            Me.txtCriterio.Focus()
        Else
            _resul = True
        End If
        Return _resul
    End Function

    Public Sub buscarGrupoXCod(ByVal pcod As String)
        Try
            Dim _listTemp As New List(Of ClsCastCadenaGrupo) 'declarar una variable tipo lista genérica tipo clsCastCadena (Wrapper)
            Dim _tempCast() As String 'declarar una variable tipo arreglo de String

            _listaGrupo = _gestor.buscarGrupoDeVentaReturnArray(pcod) 'asignar el resultado de la búsqueda devuelto por un método del Gestor

            For i As Integer = 0 To _listaGrupo.Count - 1 'estructura iterativa tipo matriz para recorrer y envolver por el tipo adecuado

                _tempArray = _listaGrupo(i) 'clonar a un Array temporal la FILA (ROW) de la consulta
                ReDim _tempCast(_tempArray.Length() - 1) 'redimensionar el arreglo a un tamaño indicado

                For j As Integer = 0 To _tempArray.Length - 1 'recorrer la parte interna de la matriz, columna (COLUMN)
                    _tempCast(j) = _tempArray.GetValue(j).ToString() 'asignar el valor de cada celda 
                Next

                _listTemp.Add(New ClsCastCadenaGrupo(_tempCast(0).ToString(), _tempCast(1).ToString(), _tempCast(2).ToString())) 'agregar a la lista genérica una colección de la clase wrapper

            Next

            Me.dvgGrupo.DataSource = _listTemp 'asignar el fuente de dato para un control tipo datagridview la lista genérica wrappeada

        Catch ex As Exception
            MessageBox.Show("Error en la operación ... " & ex.Message)
        End Try

    End Sub

    Private Sub pbEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbEliminar.Click
        _idGrupo = Me.dvgGrupo.SelectedCells(0).Value
        Dim _result As DialogResult
        _result = MessageBox.Show("¿Está seguro que desea eliminar el grupo de ventas seleccionado?", "Eliminar grupo de ventas", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, 0, False)
        Try
            If _result = Windows.Forms.DialogResult.Yes Then
                _gestor.eliminarGrupoDeVenta(_idGrupo) 'invocar el método indicado enviando los argumentos requeridos.
                MsgBox("Los datos del grupo de ventas se han eliminado correctamente.", MsgBoxStyle.Information, "Eliminar grupo de ventas")
                cargarGrupos()
            End If
        Catch ex As Exception
            MsgBox("Los datos del grupo de ventas no se pueden eliminar." & vbCrLf & ex.Message, MsgBoxStyle.Information, "Eliminar grupo de ventas")
        End Try
    End Sub

    Private Sub pbModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbModificar.Click
        If Not dvgGrupo.RowCount = 0 Then
            modificar()
            validarRoles()
        End If
    End Sub

    Private Sub validarRoles()
        If ROL_USUARIO.Contains("Gerente General") Then
            pbEliminar.Visible = False
            pbModificar2.Visible = False
            pbAddVendedor.Enabled = False
            pbDeleteVendedor.Enabled = False
            pbAddServicio.Enabled = False
            pbDeleteServicio.Enabled = False
            gbxRegistrarGrupo.Enabled = False

        ElseIf ROL_USUARIO.Contains("Gerente Ventas") Then
            pbVerVentasGrupo.Visible = True
            gbxRegistrarGrupo.Enabled = True

        ElseIf ROL_USUARIO.Contains("Vendedor") Then
            pbEliminar.Visible = False
            pbModificar2.Visible = False
            pbAddVendedor.Enabled = False
            pbDeleteVendedor.Enabled = False
            pbAddServicio.Enabled = False
            pbDeleteServicio.Enabled = False
            pbVerVentasGrupo.Visible = False
            gbxRegistrarGrupo.Enabled = False
        End If
    End Sub

    Public Sub modificar()
        With Me
            .gbxRegistrarGrupo.Visible = True
            .gbxServicios.Visible = True
            .gbxVendedores.Visible = True
            .txtCodigo.Text = Me.dvgGrupo.SelectedCells(0).Value
            .txtCodigo.Enabled = False
            .txtDescripcion.Text = Me.dvgGrupo.SelectedCells(1).Value
            cargarEncargados()
            cargarServicios()
            cargarVendedores()
            cargarServiciosDelGrupo()
            cargarVendedoresDelGrupo()
        End With
        Me.gbxRegistrarGrupo.Enabled = True
        Me.gbxServicios.Enabled = True
        Me.gbxVendedores.Enabled = True
    End Sub

    Private Sub cargarServiciosDelGrupo()
        Try
            Dim _listaServicios As List(Of Array) = New List(Of Array)() 'declarar una variable tipo lista genérica de Array

            _listaServicios = _gestor.buscarServiciosDeUnGrupoDeVentas(Me.dvgGrupo.SelectedCells(0).Value) 'asignar el resultado de la búsqueda devuelto por un método del Gestor

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
            Me.lbServicios.DataSource = _listTemp
            Me.lbServicios.DisplayMember = "nombreServicio"
            Me.lbServicios.ValueMember = "codServicio"

        Catch ex As Exception
            MessageBox.Show("Error en la operación ... " & ex.Message)
        End Try
    End Sub

    Private Sub cargarVendedoresDelGrupo()
        Try
            Dim _listaVendedores As List(Of Array) = New List(Of Array)() 'declarar una variable tipo lista genérica de Array

            _listaVendedores = _gestor.buscarUsuariosDeUnGrupoDeVentas(Me.dvgGrupo.SelectedCells(0).Value) 'asignar el resultado de la búsqueda devuelto por un método del Gestor

            Dim _tempArray As Array 'declarar una variable tipo Array

            Dim _listTemp As New List(Of ClsCastCadenaUsuario) 'declarar una variable tipo lista genérica tipo clsCastCadenaServicio (Wrapper)

            Dim _tempCast() As String 'declarar una variable tipo arreglo de String

            'estructura iterativa tipo matriz para recorrer y envolver por el tipo adecuado
            For i As Integer = 0 To _listaVendedores.Count - 1
                _tempArray = _listaVendedores(i) 'clonar a un Array temporal la FILA (ROW) de la consulta

                ReDim _tempCast(_tempArray.Length() - 1) 'redimensionar el arreglo a un tamaño indicado

                For j As Integer = 0 To _tempArray.Length - 1 'recorrer la parte interna de la matriz, columna (COLUMN)

                    _tempCast(j) = _tempArray.GetValue(j).ToString() 'asignar el valor de cada celda 
                Next
                _listTemp.Add(New ClsCastCadenaUsuario(_tempCast(0).ToString(), _tempCast(1).ToString(), _
                                _tempCast(2).ToString(), _tempCast(3).ToString(), _tempCast(4).ToString(), _
                                _tempCast(5).ToString(), _tempCast(6).ToString()))
            Next
            'asignar el fuente de dato para un control tipo listbox la lista genérica wrappeada
            Me.lbVendedores.DataSource = _listTemp
            Me.lbVendedores.DisplayMember = "nombreCompleto"
            Me.lbVendedores.ValueMember = "cedula"

        Catch ex As Exception
            MessageBox.Show("Error en la operación ... " & ex.Message)
        End Try
    End Sub

    Private Sub cargarEncargados()
        Try
            Dim _listaVendedores As List(Of Array) = New List(Of Array)() 'declarar una variable tipo lista genérica de Array

            _listaVendedores = _gestor.listarUsuarios() 'asignar el resultado de la búsqueda devuelto por un método del Gestor

            Dim _tempArray As Array 'declarar una variable tipo Array

            Dim _listTemp As New List(Of ClsCastCadenaUsuario) 'declarar una variable tipo lista genérica tipo clsCastCadenaServicio (Wrapper)

            Dim _tempCast() As String 'declarar una variable tipo arreglo de String

            'estructura iterativa tipo matriz para recorrer y envolver por el tipo adecuado
            For i As Integer = 0 To _listaVendedores.Count - 1
                _tempArray = _listaVendedores(i) 'clonar a un Array temporal la FILA (ROW) de la consulta

                ReDim _tempCast(_tempArray.Length() - 1) 'redimensionar el arreglo a un tamaño indicado

                For j As Integer = 0 To _tempArray.Length - 1 'recorrer la parte interna de la matriz, columna (COLUMN)

                    _tempCast(j) = _tempArray.GetValue(j).ToString() 'asignar el valor de cada celda 
                Next
                _listTemp.Add(New ClsCastCadenaUsuario(_tempCast(0).ToString(), _tempCast(1).ToString(), _
                                _tempCast(2).ToString(), _tempCast(3).ToString(), _tempCast(4).ToString(), _
                                _tempCast(5).ToString(), _tempCast(6).ToString()))
            Next
            'asignar el fuente de dato para un control tipo listbox la lista genérica wrappeada
            Me.cmbEncargado.DataSource = _listTemp
            Me.cmbEncargado.DisplayMember = "nombreCompleto"
            Me.cmbEncargado.ValueMember = "cedula"
            Me.cmbEncargado.AutoCompleteSource = AutoCompleteSource.ListItems
            Me.cmbEncargado.AutoCompleteMode = AutoCompleteMode.SuggestAppend
            Me.cmbEncargado.DropDownStyle = ComboBoxStyle.DropDownList
            Me.cmbEncargado.SelectedValue = Me.dvgGrupo.SelectedCells(2).Value

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
            Me.lbServiciosDisp.DataSource = _listTemp
            Me.lbServiciosDisp.DisplayMember = "nombreServicio"
            Me.lbServiciosDisp.ValueMember = "codServicio"

        Catch ex As Exception
            MessageBox.Show("Error en la operación ... " & ex.Message)
        End Try
    End Sub

    Private Sub cargarVendedores()
        Try
            Dim _listaVendedores As List(Of Array) = New List(Of Array)() 'declarar una variable tipo lista genérica de Array

            _listaVendedores = _gestor.listarUsuarios() 'asignar el resultado de la búsqueda devuelto por un método del Gestor

            Dim _tempArray As Array 'declarar una variable tipo Array

            Dim _listTemp As New List(Of ClsCastCadenaUsuario) 'declarar una variable tipo lista genérica tipo clsCastCadenaServicio (Wrapper)

            Dim _tempCast() As String 'declarar una variable tipo arreglo de String

            'estructura iterativa tipo matriz para recorrer y envolver por el tipo adecuado
            For i As Integer = 0 To _listaVendedores.Count - 1
                _tempArray = _listaVendedores(i) 'clonar a un Array temporal la FILA (ROW) de la consulta

                ReDim _tempCast(_tempArray.Length() - 1) 'redimensionar el arreglo a un tamaño indicado

                For j As Integer = 0 To _tempArray.Length - 1 'recorrer la parte interna de la matriz, columna (COLUMN)

                    _tempCast(j) = _tempArray.GetValue(j).ToString() 'asignar el valor de cada celda 
                Next
                _listTemp.Add(New ClsCastCadenaUsuario(_tempCast(0).ToString(), _tempCast(1).ToString(), _
                                _tempCast(2).ToString(), _tempCast(3).ToString(), _tempCast(4).ToString(), _
                                _tempCast(5).ToString(), _tempCast(6).ToString()))
            Next
            'asignar el fuente de dato para un control tipo listbox la lista genérica wrappeada
            Me.lbVendedoresDisp.DataSource = _listTemp
            Me.lbVendedoresDisp.DisplayMember = "nombreCompleto"
            Me.lbVendedoresDisp.ValueMember = "cedula"

        Catch ex As Exception
            MessageBox.Show("Error en la operación ... " & ex.Message)
        End Try
    End Sub

    Private Sub pbModificar2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbModificar2.Click
        Dim result As Boolean = evaluarEspacio()
        Dim _result As DialogResult

        If result Then
            Dim _codigo As String = Me.txtCodigo.Text
            Dim _descipcion As String = Me.txtDescripcion.Text
            Dim _idEncargago As String = CType(Me.cmbEncargado.SelectedItem, ClsCastCadenaUsuario).cedula
            _result = MessageBox.Show("¿Está seguro que desea modificar el grupo de ventas seleccionado?", "Modificar grupo de ventas", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, 0, False)

            Try
                If _result = Windows.Forms.DialogResult.Yes Then
                    _gestor.modificarGrupoDeVenta(_codigo, _descipcion, _idEncargago)
                    MsgBox("Los datos del grupo de ventas se han modificado correctamente.", MsgBoxStyle.Information, "Modificar grupo de ventas")
                    cargarGrupos()
                    ocultar()
                End If
            Catch ex As Exception
                MsgBox("Los datos del grupo de ventas no se pueden modificar." & vbCrLf & ex.Message, MsgBoxStyle.Information, "Modificar grupo de ventas")
            End Try
        End If
    End Sub

    Public Function evaluarEspacio() As Boolean
        Dim _resul As Boolean = False

        If  Me.txtDescripcion.Text = "" Then
            MessageBox.Show("La descripción del grupo de ventas es un dato requerido")
            Me.txtDescripcion.Focus()
        Else
            _resul = True
        End If
        Return _resul
    End Function

    Private Sub pbVerVentasGenerales_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim codGrupo As String = Me.dvgGrupo.SelectedCells(0).Value

        Me.Visible = False
        _frmSiscove.cargarUserControl(New ctlListarVentasGenerales(codGrupo))
    End Sub

    Private Sub pbVerVentas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Visible = False
        Dim codGrupo As String = Me.dvgGrupo.SelectedCells(0).Value
        _frmSiscove.cargarUserControl(New ctlListarVentas(codGrupo))
    End Sub

    Private Sub pbVerComisiones_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Visible = False
        _frmSiscove.cargarUserControl(New ctlListarComision())
    End Sub


    Private Sub ocultar()
        Me.gbxRegistrarGrupo.Enabled = False
        Me.gbxServicios.Enabled = False
        Me.gbxVendedores.Enabled = False

    End Sub

    Private Sub pbAddVendedor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbAddVendedor.Click
        Dim _idVendedorParaAgregar As String
        Dim _result As DialogResult
        _result = MessageBox.Show("¿Está seguro que desea agregar el vendedor seleccionado al grupo de ventas " & Me.txtCodigo.Text & "?", "Agregar vendedor a grupo de ventas", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, 0, False)
        For Each i In lbVendedoresDisp.SelectedIndices
            _idVendedorParaAgregar = CType(lbVendedoresDisp.Items(i), ClsCastCadenaUsuario).cedula  'Agregamos el código del servicio.
            Try
                If _result = Windows.Forms.DialogResult.Yes Then
                    _gestor.agregarVendedorAGrupoDeVenta(Me.txtCodigo.Text, _idVendedorParaAgregar)
                    MsgBox("Los datos del vendedor se han agregado al grupo de ventas correctamente.", MsgBoxStyle.Information, "Agregar vendedor a grupo de ventas")
                    cargarVendedores()
                    cargarVendedoresDelGrupo()
                End If
            Catch ex As Exception
                MsgBox("Los datos del vendedor no se han agregado al grupo de ventas." & vbCrLf & ex.Message, MsgBoxStyle.Information, "Agregar vendedor a grupo de ventas")
            End Try
        Next
    End Sub

    Private Sub pbDeleteVendedor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbDeleteVendedor.Click
        Dim _idVendedorParaQuitar As String
        Dim _result As DialogResult
        _result = MessageBox.Show("¿Está seguro que desea eliminar el servicio seleccionado al grupo de ventas" & Me.txtCodigo.Text & "?", "Agregar servicio a grupo de ventas", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, 0, False)
        If lbVendedores.Items.Count() > 1 Then
            For Each i In lbVendedores.SelectedIndices
                _idVendedorParaQuitar = CType(lbVendedores.Items(i), ClsCastCadenaUsuario).cedula  'Agregamos el código del servicio.

                Try
                    If _result = Windows.Forms.DialogResult.Yes Then
                        _gestor.eliminarVendedorDeUnGrupoDeVenta(Me.txtCodigo.Text, _idVendedorParaQuitar)
                        MsgBox("Los datos del vendedor se han eliminado del grupo de ventas correctamente.", MsgBoxStyle.Information, "Eliminar vendedor de grupo de ventas")
                        cargarVendedores()
                        cargarVendedoresDelGrupo()
                    End If
                Catch ex As Exception
                    MsgBox("Los datos del vendedor no se han eliminado del grupo de ventas." & vbCrLf & ex.Message, MsgBoxStyle.Information, "Eliminar vendedor de grupo de ventas")
                End Try
            Next
        End If
    End Sub

    Private Sub pbAddServicio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbAddServicio.Click
        Dim _idServicioParaAgregar As String
        Dim _result As DialogResult
        _result = MessageBox.Show("¿Está seguro que desea agregar el servicio seleccionado al grupo de ventas " & Me.txtCodigo.Text & "?", "Agregar servicio a grupo de ventas", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, 0, False)
        For Each i In lbServiciosDisp.SelectedIndices
            _idServicioParaAgregar = CType(lbServiciosDisp.Items(i), ClsCastCadenaServicio).codServicio  'Agregamos el código del servicio.

            Try
                If _result = Windows.Forms.DialogResult.Yes Then
                    _gestor.agregarServicioAGrupoDeVenta(Me.txtCodigo.Text, _idServicioParaAgregar)
                    MsgBox("Los datos del servicio se han agregado al grupo de ventas correctamente.", MsgBoxStyle.Information, "Agregar servicio a grupo de ventas")
                    cargarServicios()
                    cargarServiciosDelGrupo()
                End If
            Catch ex As Exception
                MsgBox("Los datos del servicio no se han agregado al grupo de ventas." & vbCrLf & ex.Message, MsgBoxStyle.Information, "Agregar servicio a grupo de ventas")
            End Try
        Next
    End Sub

    Private Sub pbDeleteServicio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbDeleteServicio.Click
        Dim _idServicioParaQuitar As String
        Dim _result As DialogResult
        _result = MessageBox.Show("¿Está seguro que desea eliminar el servicio seleccionado al grupo de ventas " & Me.txtCodigo.Text & "?", "Agregar servicio a grupo de ventas", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, 0, False)
        If lbServicios.Items.Count() > 1 Then
            For Each i In lbServicios.SelectedIndices
                _idServicioParaQuitar = CType(lbServicios.Items(i), ClsCastCadenaServicio).codServicio  'Agregamos el código del servicio.

                Try
                    If _result = Windows.Forms.DialogResult.Yes Then
                        _gestor.eliminarServicioDeUnGrupoDeVenta(Me.txtCodigo.Text, _idServicioParaQuitar)
                        MsgBox("Los datos del servicio se han eliminado del grupo de ventas correctamente.", MsgBoxStyle.Information, "Eliminar servicio a grupo de ventas")
                        cargarServicios()
                        cargarServiciosDelGrupo()
                    End If
                Catch ex As Exception
                    MsgBox("Los datos del servicio no se han eliminado del grupo de ventas." & vbCrLf & ex.Message, MsgBoxStyle.Information, "Eliminar servicio a grupo de ventas")
                End Try
            Next
        End If
    End Sub

    Private Sub txtCriterio_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCriterio.TextChanged
        If Me.txtCriterio.Text = "" Then
            cargarGrupos()
        Else
            buscarGrupoAprox(Me.txtCriterio.Text)
        End If
        Me.gbxVendedores.Visible = False
        Me.gbxServicios.Visible = False
        Me.gbxRegistrarGrupo.Visible = False
    End Sub

    Private Sub buscarGrupoAprox(ByVal pcodGrupo As String)
        Try
            Dim _listTemp As New List(Of ClsCastCadenaGrupo) 'declarar una variable tipo lista genérica tipo clsCastCadena (Wrapper)
            Dim _tempCast() As String 'declarar una variable tipo arreglo de String

            _listaGrupo = _gestor.buscarGrupoPorAprox(pcodGrupo) 'asignar el resultado de la búsqueda devuelto por un método del Gestor

            For i As Integer = 0 To _listaGrupo.Count - 1 'estructura iterativa tipo matriz para recorrer y envolver por el tipo adecuado

                _tempArray = _listaGrupo(i) 'clonar a un Array temporal la FILA (ROW) de la consulta
                ReDim _tempCast(_tempArray.Length() - 1) 'redimensionar el arreglo a un tamaño indicado

                For j As Integer = 0 To _tempArray.Length - 1 'recorrer la parte interna de la matriz, columna (COLUMN)
                    _tempCast(j) = _tempArray.GetValue(j).ToString() 'asignar el valor de cada celda 
                Next

                _listTemp.Add(New ClsCastCadenaGrupo(_tempCast(0).ToString(), _tempCast(1).ToString(), _tempCast(2).ToString())) 'agregar a la lista genérica una colección de la clase wrapper

            Next

            Me.dvgGrupo.DataSource = _listTemp 'asignar el fuente de dato para un control tipo datagridview la lista genérica wrappeada
            nombrarColumnas()
        Catch ex As Exception
            MsgBox("Error en la operación ... " & ex.Message, MsgBoxStyle.Information, "Buscar Grupo de Ventas")
        End Try

    End Sub

    Private Sub pbVerVentasGenerales_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbVerVentasGenerales.Click
        If Not dvgGrupo.RowCount = 0 Then
            Dim idGrupo As String = Me.dvgGrupo.SelectedCells(0).Value
            _frmSiscove.cargarUserControl(New ctlListarVentasGenerales(idGrupo))
        End If
    End Sub

    Private Sub pbVerVentas_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbVerVentasGrupo.Click
        If Not dvgGrupo.RowCount = 0 Then
            Dim idGrupo As String = Me.dvgGrupo.SelectedCells(0).Value
            _frmSiscove.cargarUserControl(New ctlListarVentas(idGrupo))
        End If
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint
        validarRoles()
    End Sub
End Class
