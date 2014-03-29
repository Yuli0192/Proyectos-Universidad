Imports CllLogicaNegocio

Public Class ctlRegistrarGrupo

    Dim _gestor As New ClsGestor() 'declara e instancia de la clase Gestor
    Dim _cod As String
    Dim _descripcion As String
    Dim _idEncargado As String
    Dim _listaServicios As ArrayList = New ArrayList()
    Dim _listaVendedores As ArrayList = New ArrayList()
    Dim _resul As Boolean
    Dim _result As DialogResult


    Private Sub ctlRegistrarUsuario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cargarEncargados()
        cargarVendedores()
        cargarServicios()
        Me.txtCodigo.Focus()

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

            _listaVendedores = _gestor.listarVendedores() 'asignar el resultado de la búsqueda devuelto por un método del Gestor

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

    Private Sub cargarEncargados()
        Try
            Dim _listaVendedores As List(Of Array) = New List(Of Array)() 'declarar una variable tipo lista genérica de Array

            _listaVendedores = _gestor.listarmastersgerentesdisponibles() 'asignar el resultado de la búsqueda devuelto por un método del Gestor

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
                                _tempCast(2).ToString(), _tempCast(3).ToString(), _tempCast(4).ToString()))
            Next
            'asignar el fuente de dato para un control tipo listbox la lista genérica wrappeada
            Me.cmbEncargado.DataSource = _listTemp
            Me.cmbEncargado.DisplayMember = "nombreCompleto"
            Me.cmbEncargado.ValueMember = "cedula"
            Me.cmbEncargado.AutoCompleteSource = AutoCompleteSource.ListItems
            Me.cmbEncargado.AutoCompleteMode = AutoCompleteMode.SuggestAppend
            Me.cmbEncargado.DropDownStyle = ComboBoxStyle.DropDownList
            Me.cmbEncargado.SelectedIndex = 0
        Catch ex As Exception
            MessageBox.Show("Error en la operación ... " & ex.Message)
        End Try
    End Sub

    Private Sub limpiarForm()
        With Me
            .txtCodigo.Text = ""
            .txtDescripcion.Text = ""
            .lbVendedores.Items.Clear()
            .lbServicios.Items.Clear()
            .cmbEncargado.SelectedIndex = 0
            cargarServicios()
            cargarVendedores()
        End With

    End Sub

    Private Sub pbLimpiarForm_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbLimpiarForm.Click
        limpiarForm()
    End Sub

    Public Function evaluarEspacio() As Boolean
        Dim _resul As Boolean = False

        If Me.txtCodigo.Text = "" Then
            MessageBox.Show("El codigo del grupo de ventas es un dato requerido")
            Me.txtCodigo.Focus()
        ElseIf Me.txtDescripcion.Text = "" Then
            MessageBox.Show("La descripción del grupo de ventas es un dato requerido")
            Me.txtDescripcion.Focus()
        ElseIf Me._listaServicios.Count <= 0 Then
            MessageBox.Show("Debe asociar al menos un servicio al grupo de ventas")
            Me.lbServiciosDisp.SelectedIndex = 0
        ElseIf Me._listaVendedores.Count <= 0 Then
            MessageBox.Show("Debe asociar al menos un vendedor al grupo de ventas")
            Me.lbVendedoresDisp.SelectedIndex = 0
        Else
            _resul = True
        End If
        Return _resul
    End Function

    Private Sub pbRegistrarGrupo_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbRegistrarGrupo.Click
        Dim result As Boolean = evaluarEspacio()
        If result Then
            _cod = Me.txtCodigo.Text
            _descripcion = Me.txtDescripcion.Text
            _idEncargado = CType(Me.cmbEncargado.SelectedItem, ClsCastCadenaUsuario).cedula
            Try
                _gestor.registrarGrupoDeVenta(_cod, _descripcion, _idEncargado, _listaVendedores, _listaServicios)
                MsgBox("El grupo de ventas se ha registrado correctamente.", MsgBoxStyle.Information, "Registrar Grupo De Venta")
                limpiarForm()
            Catch ex As Exception
                MsgBox("Los datos ingresados ya existen en la base de datos." & ex.Message, MsgBoxStyle.Information, "Registrar Grupo De Ventas")
            End Try

        End If
    End Sub

    Private Function obtenerServicioAgregado(ByVal servicio As ClsCastCadenaServicio) As Integer
        Dim contador As Integer = 0
        For Each i As String In _listaServicios
            If i.Equals(servicio.codServicio) Then
                Return contador
            End If
            contador += 1
        Next
    End Function

    Private Function obtenerVendedorAgregado(ByVal vendedor As ClsCastCadenaUsuario) As Integer
        Dim contador As Integer = 0
        For Each i As String In _listaVendedores
            If i.Equals(vendedor.cedula) Then
                Return contador
            End If
            contador += 1
        Next
    End Function

    Private Sub pbAddServicio_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbAddServicio.Click
        Dim _idServicioParaAgregar As String

        For Each i In lbServiciosDisp.SelectedIndices
            _idServicioParaAgregar = CType(lbServiciosDisp.Items(i), ClsCastCadenaServicio).codServicio 'Agregamos el código del servicio.
            _listaServicios.Add(_idServicioParaAgregar) 'Agregamos el servicio con sus datos.

            lbServicios.Items.Add(lbServiciosDisp.Items(i))
            lbServicios.DisplayMember = "nombre"
            lbServicios.ValueMember = "codServicio"

            Dim _listTemp As List(Of ClsCastCadenaServicio) = CType(lbServiciosDisp.DataSource, List(Of ClsCastCadenaServicio))
            _listTemp.RemoveAt(i)

            Dim _listTemp2 As New List(Of ClsCastCadenaServicio)
            For x As Integer = 0 To _listTemp.Count - 1
                _listTemp2.Add(_listTemp.Item(x))
            Next

            lbServiciosDisp.DataSource = _listTemp2
            lbServiciosDisp.DisplayMember = "nombre"
            lbServiciosDisp.ValueMember = "codServicio"
            lbServiciosDisp.Refresh()
        Next
    End Sub

    Private Sub pbDeleteServicio_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbDeleteServicio.Click
        For Each i In lbServicios.SelectedIndices

            Dim _listTemp As List(Of ClsCastCadenaServicio) = CType(lbServiciosDisp.DataSource, List(Of ClsCastCadenaServicio))
            _listTemp.Add(lbServicios.Items(i))

            Dim _listTemp2 As New List(Of ClsCastCadenaServicio)

            For x As Integer = 0 To _listTemp.Count - 1
                _listTemp2.Add(_listTemp.Item(x))
            Next

            lbServiciosDisp.DataSource = _listTemp2
            lbServiciosDisp.DisplayMember = "nombre"
            lbServiciosDisp.ValueMember = "codServicio"
            'Removemos el servicio de la lista
            _listaServicios.RemoveAt(obtenerServicioAgregado(CType(lbServicios.Items(i), ClsCastCadenaServicio)))
            lbServicios.Items.RemoveAt(i)
        Next
    End Sub

    Private Sub pbAddVendedor_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbAddVendedor.Click
        Dim _idVendedorParaAgregar As String

        For Each i In lbVendedoresDisp.SelectedIndices
            _idVendedorParaAgregar = CType(lbVendedoresDisp.Items(i), ClsCastCadenaUsuario).cedula  'Agregamos el código del servicio.
            _listaVendedores.Add(_idVendedorParaAgregar) 'Agregamos el servicio con sus datos.

            lbVendedores.Items.Add(lbVendedoresDisp.Items(i))
            lbVendedores.DisplayMember = "nombreCompleto"
            lbVendedores.ValueMember = "cedula"

            Dim _listTemp As List(Of ClsCastCadenaUsuario) = CType(lbVendedoresDisp.DataSource, List(Of ClsCastCadenaUsuario))
            _listTemp.RemoveAt(i)

            Dim _listTemp2 As New List(Of ClsCastCadenaUsuario)
            For x As Integer = 0 To _listTemp.Count - 1
                _listTemp2.Add(_listTemp.Item(x))
            Next

            lbVendedoresDisp.DataSource = _listTemp2
            lbVendedoresDisp.DisplayMember = "nombreCompleto"
            lbVendedoresDisp.ValueMember = "cedula"
            lbVendedoresDisp.Refresh()
        Next
    End Sub

    Private Sub pbDeleteVendedor_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbDeleteVendedor.Click
        For Each i In lbVendedores.SelectedIndices

            Dim _listTemp As List(Of ClsCastCadenaUsuario) = CType(lbVendedoresDisp.DataSource, List(Of ClsCastCadenaUsuario))
            _listTemp.Add(lbVendedores.Items(i))

            Dim _listTemp2 As New List(Of ClsCastCadenaUsuario)

            For x As Integer = 0 To _listTemp.Count - 1
                _listTemp2.Add(_listTemp.Item(x))
            Next

            lbVendedoresDisp.DataSource = _listTemp2
            lbVendedoresDisp.DisplayMember = "nombreServicio"
            lbVendedoresDisp.ValueMember = "cedula"
            'Removemos el servicio de la lista
            _listaVendedores.RemoveAt(obtenerVendedorAgregado(CType(lbVendedores.Items(i), ClsCastCadenaUsuario)))
            lbVendedores.Items.RemoveAt(i)
        Next
    End Sub
End Class

