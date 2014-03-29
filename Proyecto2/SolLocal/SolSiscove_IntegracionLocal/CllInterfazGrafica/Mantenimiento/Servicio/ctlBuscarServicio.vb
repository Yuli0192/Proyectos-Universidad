Public Class ctlBuscarServicio



    Dim _gestor As New CllLogicaNegocio.ClsGestor() 'declaración e instanciación de la clase Gestor
    'declarar una variable tipo lista genérica de Array
    Dim _listaServicio As List(Of Array) = New List(Of Array)()
    'declarar una variable tipo Array
    Dim _tempArray As Array
    'declarar una variable tipo lista genérica tipo clsCastCadena (Wrapper)
    Dim _cadena As ClsCastCadenaServicio
    'declarar una variable tipo arreglo de String
    Dim _tempCast() As String
    'declarar variable globales tipo boolean
    Dim _resul As Boolean
    Dim _result As DialogResult
    'declarar variables globales 
    Dim _numero As Boolean
    Dim _criterio As String
    Dim _cod As String
    Dim _nombre As String
    Dim _descripcion As String
    Dim _preciocolones As Double
    Dim _preciodolares As Double
    Dim _porcentcomisionjuniorcolones As Double
    Dim _porcentcomisionjuniordolares As Double
    Dim _porcentcomisionseniorcolones As Double
    Dim _porcentcomisionseniordolares As Double
    Dim _porcentcomisionmastercolones As Double
    Dim _porcentcomisionmasterdolares As Double

    Public Sub modificar(ByVal pcod As String, ByVal pnombre As String, ByVal pdescripcion As String, ByVal ppreciocolones As Double, _
         ByVal ppreciodolares As Double, ByVal pporcentcomisionjuniorcolones As Double, _
         ByVal pporcentcomisionjuniordolares As Double, ByVal pporcentcomisionseniorcolones As Double, _
         ByVal pporcentcomisionseniordolares As Double, ByVal pporcentcomisionmastercolones As Double, _
         ByVal pporcentcomisionmasterdolares As Double)
        With Me
            .txtCod.Text = pcod
            .txtNombre.Text = pnombre
            .txtDescripcion.Text = pdescripcion
            .txtPrecioColones.Text = ppreciocolones
            .txtPrecioDolares.Text = ppreciodolares
            .txtJuniorColones.Text = pporcentcomisionjuniorcolones
            .txtJuniorDolares.Text = pporcentcomisionjuniordolares
            .txtSeniorColones.Text = pporcentcomisionseniorcolones
            .txtSeniorDolares.Text = pporcentcomisionseniordolares
            .txtMasterColones.Text = pporcentcomisionmastercolones
            .txtMasterDolares.Text = pporcentcomisionmasterdolares
        End With

    End Sub


    ''' <summary>
    ''' Método de clase, encarga de evaluar que no queden espacios en blanco ningun componente
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function evaluarEspacion() As Boolean
        Dim _resul = False

        If Me.txtCod.Text = "" Then
            MsgBox("El identificador del servicio es un dato requerido", MsgBoxStyle.Information, "Modificar Servicio")
            Me.txtCod.Focus()

        ElseIf Me.txtNombre.Text = "" Then
            MsgBox("El nombre del servicio es un dato requerido", MsgBoxStyle.Information, "Modificar Servicio")
            Me.txtNombre.Focus()

        ElseIf Me.txtDescripcion.Text = "" Then
            MsgBox("La descripcion del servicio es un dato requerido", MsgBoxStyle.Information, "Modificar Servicio")
            Me.txtDescripcion.Focus()

        ElseIf Me.txtPrecioColones.Text = "" Then
            MsgBox("El precio en colones del servicio es un dato requerido", MsgBoxStyle.Information, "Modificar Servicio")
            Me.txtPrecioColones.Focus()

        ElseIf Me.txtPrecioDolares.Text = "" Then
            MsgBox("El precio en dolares del servicio es un dato requerido", MsgBoxStyle.Information, "Modificar Servicio")
            Me.txtPrecioColones.Focus()

        ElseIf Me.txtJuniorColones.Text = "" Then
            MsgBox("La comision para el vendedor junior es un dato requerido", MsgBoxStyle.Information, "Modificar Servicio")
            Me.txtJuniorColones.Focus()

        ElseIf Me.txtJuniorDolares.Text = "" Then
            MsgBox("La comision para el vendedor junior es un dato requerido", MsgBoxStyle.Information, "Modificar Servicio")
            Me.txtJuniorColones.Focus()

        ElseIf Me.txtSeniorColones.Text = "" Then
            MsgBox("La comision para el vendedor senior es un dato requerido", MsgBoxStyle.Information, "Modificar Servicio")
            Me.txtJuniorColones.Focus()

        ElseIf Me.txtSeniorDolares.Text = "" Then
            MsgBox("La comision para el vendedor senior es un dato requerido", MsgBoxStyle.Information, "Modificar Servicio")
            Me.txtJuniorColones.Focus()

        ElseIf Me.txtMasterColones.Text = "" Then
            MsgBox("La comision para el vendedor master es un dato requerido", MsgBoxStyle.Information, "Modificar Servicio")
            Me.txtJuniorColones.Focus()

        ElseIf Me.txtMasterDolares.Text = "" Then
            MsgBox("La comision para el vendedor master es un dato requerido", MsgBoxStyle.Information, "Modificar Servicio")
            Me.txtJuniorColones.Focus()

        ElseIf Not evaluarNumeric(Me.txtPrecioColones.Text) Then 'Valida el formato de los campos de precio y porcentaje


            MsgBox("El precio en colones debe ser solo número", MsgBoxStyle.Information, "Modificar Servicio")
            Me.txtPrecioColones.Focus()

        ElseIf Not evaluarNumeric(Me.txtPrecioDolares.Text) Then 'Valida el formato de los campos de precio y porcentaje


            MsgBox("El precio en dólares debe ser solo número", MsgBoxStyle.Information, "Modificar Servicio")
            Me.txtPrecioDolares.Focus()

        ElseIf Not evaluarNumeric(Me.txtSeniorColones.Text) Then 'Valida el formato de los campos de precio y porcentaje


            MsgBox("La comisión senior en colones debe ser solo número", MsgBoxStyle.Information, "Modificar Servicio")
            Me.txtSeniorColones.Focus()

        ElseIf Not evaluarNumeric(Me.txtSeniorDolares.Text) Then 'Valida el formato de los campos de precio y porcentaje

            MsgBox("La comisión senior en dólares debe ser solo número", MsgBoxStyle.Information, "Modificar Servicio")
            Me.txtSeniorDolares.Focus()


        ElseIf Not evaluarNumeric(Me.txtJuniorColones.Text) Then 'Valida el formato de los campos de precio y porcentaje

            MsgBox("La comisión junior en colones debe ser solo número", MsgBoxStyle.Information, "Modificar Servicio")
            Me.txtJuniorColones.Focus()

        ElseIf Not evaluarNumeric(Me.txtJuniorDolares.Text) Then 'Valida el formato de los campos de precio y porcentaje

            MsgBox("La comisión junior en dólares debe ser solo número", MsgBoxStyle.Information, "Modificar Servicio")
            Me.txtJuniorDolares.Focus()

        ElseIf Not evaluarNumeric(Me.txtMasterColones.Text) Then 'Valida el formato de los campos de precio y porcentaje

            MsgBox("La comisión master en colones debe ser solo número", MsgBoxStyle.Information, "Modificar Servicio")
            Me.txtMasterColones.Focus()

        ElseIf Not evaluarNumeric(Me.txtMasterDolares.Text) Then 'Valida el formato de los campos de precio y porcentaje

            MsgBox("La comisión master en dólares debe ser solo número", MsgBoxStyle.Information, "Modificar Servicio")
            Me.txtMasterDolares.Focus()

        Else
            _resul = True

        End If

        Return _resul
    End Function


    Private Function evaluarNumeric(ByVal texto As String) As Boolean

        _numero = IsNumeric(texto)


        Return _numero
    End Function

    Private Sub limpiarTabla()

        Me.txtCriterio.Text = ""
        Me.txtCriterio.Focus()
        Me.listarServicios()

    End Sub

    ''' <summary>
    ''' Método de clase, encarga de limpiar los componentes 
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub limpiarForm()
        With Me
            .txtCod.Text = ""
            .txtNombre.Text = ""
            .txtDescripcion.Text = ""
            .txtPrecioColones.Text = ""
            .txtPrecioDolares.Text = ""
            .txtJuniorColones.Text = ""
            .txtJuniorDolares.Text = ""
            .txtSeniorColones.Text = ""
            .txtSeniorDolares.Text = ""
            .txtMasterColones.Text = ""
            .txtMasterDolares.Text = ""
        End With

    End Sub

    Private Sub ctlBuscar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.listarServicios()
        Me.txtCriterio.Focus()
        Me.rdbId.Checked = True

    End Sub

    Private Sub rdbId_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbId.CheckedChanged
        limpiarTabla()
        Me.txtCriterio.Focus()
    End Sub

    Private Sub evaluar()
        '_resul = False

        If rdbId.Checked Then
            _criterio = "Identificador"
        Else
            _criterio = "Nombre"
        End If

        'If Me.txtCriterio.Text <> "" Then
        '    _resul = True
        'Else
        '    MessageBox.Show("El dato " & _criterio & " es un valor requerido")
        '    Me.txtCriterio.Focus()
        'End If
        'Return _resul
    End Sub

    Private Sub listarServicios()

        Try

            Me.txtCriterio.Focus()
            'asignar el resultado de la búsqueda devuelto por un método del Gestor
            _listaServicio = _gestor.listarServicio()

            Me.dvgServicios.Rows.Clear()

            'estructura iterativa tipo matriz para recorrer y envolver por el tipo adecuado
            For i As Integer = 0 To _listaServicio.Count - 1
                'clonar a un Array temporal la FILA (ROW) de la consulta
                _tempArray = _listaServicio(i)

                'agregar a la lista genérica una colección de la clase wrapper
                _cadena = New ClsCastCadenaServicio(_tempArray(0).ToString(), _tempArray(1).ToString(), _tempArray(2).ToString(), _tempArray(3).ToString(), _tempArray(4).ToString(), _tempArray(5).ToString(), _tempArray(6).ToString(), _tempArray(7).ToString(), _tempArray(8).ToString(), _tempArray(9).ToString(), _tempArray(10).ToString())

                dvgServicios.Rows.Add()
                dvgServicios.Rows.Item(dvgServicios.Rows.Count - 1).Cells.Item(0).Value = _cadena.codServicio
                dvgServicios.Rows.Item(dvgServicios.Rows.Count - 1).Cells.Item(1).Value = _cadena.nombre
                dvgServicios.Rows.Item(dvgServicios.Rows.Count - 1).Cells.Item(2).Value = _cadena.descripcion
                dvgServicios.Rows.Item(dvgServicios.Rows.Count - 1).Cells.Item(3).Value = _cadena.precioColones
                dvgServicios.Rows.Item(dvgServicios.Rows.Count - 1).Cells.Item(4).Value = _cadena.precioDolares
                dvgServicios.Rows.Item(dvgServicios.Rows.Count - 1).Cells.Item(5).Value = _cadena.porcentComisionJuniorColones
                dvgServicios.Rows.Item(dvgServicios.Rows.Count - 1).Cells.Item(6).Value = _cadena.porcentComisionJuniorDolares
                dvgServicios.Rows.Item(dvgServicios.Rows.Count - 1).Cells.Item(7).Value = _cadena.porcentComisionSeniorColones
                dvgServicios.Rows.Item(dvgServicios.Rows.Count - 1).Cells.Item(8).Value = _cadena.porcentComisionSeniorDolares
                dvgServicios.Rows.Item(dvgServicios.Rows.Count - 1).Cells.Item(9).Value = _cadena.porcentComisionMasterColones
                dvgServicios.Rows.Item(dvgServicios.Rows.Count - 1).Cells.Item(10).Value = _cadena.porcentComisionMasterDolares

            Next

            'asignar el fuente de dato para un control tipo ComboBox la lista genérica wrappeada


        Catch ex As Exception
            MessageBox.Show("Error en la operación ... " & ex.Message, "Error")
        End Try

    End Sub

    Private Sub buscarServicioCod(ByVal pcod As String)
        Try

            'asignar el resultado de la búsqueda devuelto por un método del Gestor
            _listaServicio = _gestor.buscarServicioCod(pcod)

            dvgServicios.Rows.Clear()

            'estructura iterativa tipo matriz para recorrer y envolver por el tipo adecuado
            For i As Integer = 0 To _listaServicio.Count - 1
                'clonar a un Array temporal la FILA (ROW) de la consulta
                _tempArray = _listaServicio(i)

                _cadena = New ClsCastCadenaServicio(_tempArray(0).ToString(), _tempArray(1).ToString(), _tempArray(2).ToString(), _tempArray(3).ToString(), _tempArray(4).ToString(), _tempArray(5).ToString(), _tempArray(6).ToString(), _tempArray(7).ToString(), _tempArray(8).ToString(), _tempArray(9).ToString(), _tempArray(10).ToString())

                dvgServicios.Rows.Add()
                dvgServicios.Rows.Item(dvgServicios.Rows.Count - 1).Cells.Item(0).Value = _cadena.codServicio
                dvgServicios.Rows.Item(dvgServicios.Rows.Count - 1).Cells.Item(1).Value = _cadena.nombre
                dvgServicios.Rows.Item(dvgServicios.Rows.Count - 1).Cells.Item(2).Value = _cadena.descripcion
                dvgServicios.Rows.Item(dvgServicios.Rows.Count - 1).Cells.Item(3).Value = _cadena.precioColones
                dvgServicios.Rows.Item(dvgServicios.Rows.Count - 1).Cells.Item(4).Value = _cadena.precioDolares
                dvgServicios.Rows.Item(dvgServicios.Rows.Count - 1).Cells.Item(5).Value = _cadena.porcentComisionJuniorColones
                dvgServicios.Rows.Item(dvgServicios.Rows.Count - 1).Cells.Item(6).Value = _cadena.porcentComisionJuniorDolares
                dvgServicios.Rows.Item(dvgServicios.Rows.Count - 1).Cells.Item(7).Value = _cadena.porcentComisionSeniorColones
                dvgServicios.Rows.Item(dvgServicios.Rows.Count - 1).Cells.Item(8).Value = _cadena.porcentComisionSeniorDolares
                dvgServicios.Rows.Item(dvgServicios.Rows.Count - 1).Cells.Item(9).Value = _cadena.porcentComisionMasterColones
                dvgServicios.Rows.Item(dvgServicios.Rows.Count - 1).Cells.Item(10).Value = _cadena.porcentComisionMasterDolares


            Next


        Catch ex As Exception
            MessageBox.Show("Error en la operación ... " & ex.Message)
        End Try

    End Sub

    Private Sub buscarServicioNombre(ByVal pnombre As String)
        Try

            'asignar el resultado de la búsqueda devuelto por un método del Gestor
            _listaServicio = _gestor.buscarservicioPorNombre(pnombre)

            dvgServicios.Rows.Clear()

            'estructura iterativa tipo matriz para recorrer y envolver por el tipo adecuado
            For i As Integer = 0 To _listaServicio.Count - 1
                'clonar a un Array temporal la FILA (ROW) de la consulta
                _tempArray = _listaServicio(i)
                ''redimensionar el arreglo a un tamaño indicado
                'ReDim _tempCast(_tempArray.Length() - 1)

                ''recorrer la parte interna de la matriz, columna (COLUMN)
                'For j As Integer = 0 To _tempArray.Length - 1
                '    'asignar el valor de cada celda 
                '    _tempCast(j) = _tempArray.GetValue(j).ToString()
                'Next

                _cadena = New ClsCastCadenaServicio(_tempArray(0).ToString(), _tempArray(1).ToString(), _tempArray(2).ToString(), _tempArray(3).ToString(), _tempArray(4).ToString(), _tempArray(5).ToString(), _tempArray(6).ToString(), _tempArray(7).ToString(), _tempArray(8).ToString(), _tempArray(9).ToString(), _tempArray(10).ToString())

                dvgServicios.Rows.Add()
                dvgServicios.Rows.Item(dvgServicios.Rows.Count - 1).Cells.Item(0).Value = _cadena.codServicio
                dvgServicios.Rows.Item(dvgServicios.Rows.Count - 1).Cells.Item(1).Value = _cadena.nombre
                dvgServicios.Rows.Item(dvgServicios.Rows.Count - 1).Cells.Item(2).Value = _cadena.descripcion
                dvgServicios.Rows.Item(dvgServicios.Rows.Count - 1).Cells.Item(3).Value = _cadena.precioColones
                dvgServicios.Rows.Item(dvgServicios.Rows.Count - 1).Cells.Item(4).Value = _cadena.precioDolares
                dvgServicios.Rows.Item(dvgServicios.Rows.Count - 1).Cells.Item(5).Value = _cadena.porcentComisionJuniorColones
                dvgServicios.Rows.Item(dvgServicios.Rows.Count - 1).Cells.Item(6).Value = _cadena.porcentComisionJuniorDolares
                dvgServicios.Rows.Item(dvgServicios.Rows.Count - 1).Cells.Item(7).Value = _cadena.porcentComisionSeniorColones
                dvgServicios.Rows.Item(dvgServicios.Rows.Count - 1).Cells.Item(8).Value = _cadena.porcentComisionSeniorDolares
                dvgServicios.Rows.Item(dvgServicios.Rows.Count - 1).Cells.Item(9).Value = _cadena.porcentComisionMasterColones
                dvgServicios.Rows.Item(dvgServicios.Rows.Count - 1).Cells.Item(10).Value = _cadena.porcentComisionMasterDolares


            Next

        Catch ex As Exception
            MessageBox.Show("Error en la operación ... " & ex.Message)
        End Try

    End Sub

    Private Sub txtCriterio_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCriterio.TextChanged
        evaluar()
        If txtCriterio.Text = "" Then
            Me.listarServicios()
        ElseIf _criterio = "Identificador" Then
            buscarServicioCod(Me.txtCriterio.Text)
        ElseIf _criterio = "Nombre" Then
            buscarServicioNombre(Me.txtCriterio.Text)
        End If

    End Sub



    Private Sub pbModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbModificar.Click
        Me.gpModificarServicio.Visible = True
        If dvgServicios.SelectedRows.Count > 0 Then

            Dim row = dvgServicios.SelectedRows.Item(0)

            Me.modificar(row.Cells("codigo").Value, row.Cells("nom").Value, row.Cells("descp").Value, row.Cells("precioencolones").Value, row.Cells("precioendolares").Value, row.Cells("comisionjuniorc").Value, _
                         row.Cells("comisionjuniord").Value, row.Cells("comisionserniorc").Value, _
                         row.Cells("comisionseniord").Value, row.Cells("comisionmasterc").Value, _
                         row.Cells("comisionmasterd").Value)
            validarRoles()

        Else

            MessageBox.Show("No hay un servicio seleccionado", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        End If
    End Sub

    Private Sub validarRoles()
        If ROL_USUARIO.Contains("Gerente General") Then
            pbEliminar.Visible = False
            pbModificar2.Visible = False
            gpModificarServicio.Enabled = False

        ElseIf ROL_USUARIO.Contains("Vendedor") Then
            pbEliminar.Visible = False
            pbModificar2.Visible = False
            gpModificarServicio.Enabled = False

        End If
    End Sub

    Private Sub pbEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbEliminar.Click
        If Not dvgServicios.RowCount = 0 Then
            _cod = Me.dvgServicios.SelectedCells(0).Value
            _result = MessageBox.Show("¿Esta seguro que desea eliminar el servicio?", "Aviso de Salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3, MessageBoxOptions.DefaultDesktopOnly, False)
            Try
                If _result = Windows.Forms.DialogResult.Yes Then
                    'invocar el método indicado enviando los argumentos requeridos.
                    _gestor.eliminarServicio(_cod)

                    ''If Me.txtCriterio.Text <> "" Then

                    evaluar()
                    limpiarTabla()

                    ''Else

                    '' dvgServicios.DataSource = ""

                    '' End If


                    MsgBox("Los datos de el servicio se han eliminado correctamente.", MsgBoxStyle.Information, "Eliminar Servicio")
                Else
                    MsgBox("El servicio no es eliminado.", MsgBoxStyle.Information, "Eliminar Servicio")
                End If
            Catch ex As Exception
                MsgBox("El servicio no se pudo eliminar.", MsgBoxStyle.Information, "Eliminar Servicio")
            End Try
        End If
    End Sub

    Private Sub pbModificar2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbModificar2.Click
        _resul = evaluarEspacion()
        _numero = False
        If _resul = True Then

            'asignar a cada variable los valores indicados
            _cod = Me.txtCod.Text
            _nombre = Me.txtNombre.Text
            _descripcion = Me.txtDescripcion.Text
            _preciocolones = Me.txtPrecioColones.Text
            _preciodolares = Me.txtPrecioDolares.Text
            _porcentcomisionjuniorcolones = Me.txtJuniorColones.Text
            _porcentcomisionjuniordolares = Me.txtJuniorDolares.Text
            _porcentcomisionseniorcolones = Me.txtSeniorColones.Text
            _porcentcomisionseniordolares = Me.txtSeniorColones.Text
            _porcentcomisionmastercolones = Me.txtMasterDolares.Text
            _porcentcomisionmasterdolares = Me.txtMasterDolares.Text


            _result = MessageBox.Show("¿Desesa modificar los datos  del servicio?", "Aviso de Salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3, MessageBoxOptions.DefaultDesktopOnly, False)

            Try
                If _result = Windows.Forms.DialogResult.Yes Then
                    _gestor.modificarservicio(_cod, _nombre, _descripcion, _preciocolones, _preciodolares, _porcentcomisionjuniorcolones, _porcentcomisionjuniordolares, _porcentcomisionseniorcolones, _porcentcomisionseniordolares, _porcentcomisionmastercolones, _porcentcomisionmasterdolares) 'invocar el método indicado enviando los argumentos requeridos.
                    MessageBox.Show("Los datos del servicio se han modificado correctamente.")
                    limpiarForm()
                    limpiarTabla()

                Else
                    MessageBox.Show("Los datos del servicion no fueron modificados.")
                End If

            Catch ex As Exception
                MessageBox.Show("Los datos ingresados ya existen en la base de datos.")
            End Try
        End If

    End Sub


    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint
        validarRoles()
    End Sub
End Class
