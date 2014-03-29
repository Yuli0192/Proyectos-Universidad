Public Class ctlRegistrarServicio

    Dim _gestor As New CllLogicaNegocio.ClsGestor() 'declara e instancia de la clase Gestor
    'declarar variable globales tipo boolean
    Dim _resul As Boolean
    Dim _numero As Boolean
    'declarar variables globales 
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


    ''' <summary>
    ''' Método de clase, encarga de evaluar que no queden espacios en blanco ningun componente
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function evaluarEspacion() As Boolean
        Dim _resul = False

        If Me.txtCod.Text = "" Then
            MsgBox("El identificador del servicio es un dato requerido", MsgBoxStyle.Information, "Registrar Servicio")
            Me.txtCod.Focus()

        ElseIf Me.txtNombre.Text = "" Then
            MsgBox("El nombre del servicio es un dato requerido", MsgBoxStyle.Information, "Registrar Servicio")
            Me.txtNombre.Focus()

        ElseIf Me.txtDescripcion.Text = "" Then
            MsgBox("La descripcion del servicio es un dato requerido", MsgBoxStyle.Information, "Registrar Servicio")
            Me.txtDescripcion.Focus()

        ElseIf Me.txtPrecioColones.Text = "" Then
            MsgBox("El precio en colones del servicio es un dato requerido", MsgBoxStyle.Information, "Registrar Servicio")
            Me.txtPrecioColones.Focus()

        ElseIf Me.txtPrecioDolares.Text = "" Then
            MsgBox("El precio en dolares del servicio es un dato requerido", MsgBoxStyle.Information, "Registrar Servicio")
            Me.txtPrecioColones.Focus()

        ElseIf Me.txtJuniorColones.Text = "" Then
            MsgBox("La comision para el vendedor junior es un dato requerido", MsgBoxStyle.Information, "Registrar Servicio")
            Me.txtJuniorColones.Focus()

        ElseIf Me.txtJuniorDolares.Text = "" Then
            MsgBox("La comision para el vendedor junior es un dato requerido", MsgBoxStyle.Information, "Registrar Servicio")
            Me.txtJuniorColones.Focus()

        ElseIf Me.txtSeniorColones.Text = "" Then
            MsgBox("La comision para el vendedor senior es un dato requerido", MsgBoxStyle.Information, "Registrar Servicio")
            Me.txtJuniorColones.Focus()

        ElseIf Me.txtSeniorDolares.Text = "" Then
            MsgBox("La comision para el vendedor senior es un dato requerido", MsgBoxStyle.Information, "Registrar Servicio")
            Me.txtJuniorColones.Focus()

        ElseIf Me.txtMasterColones.Text = "" Then
            MsgBox("La comision para el vendedor master es un dato requerido", MsgBoxStyle.Information, "Registrar Servicio")
            Me.txtJuniorColones.Focus()

        ElseIf Me.txtMasterDolares.Text = "" Then
            MsgBox("La comision para el vendedor master es un dato requerido", MsgBoxStyle.Information, "Registrar Servicio")
            Me.txtJuniorColones.Focus()

        ElseIf Not evaluarNumeric(Me.txtPrecioColones.Text) Then 'Valida el formato de los campos de precio y porcentaje


            MsgBox("El precio en colones debe ser solo número", MsgBoxStyle.Information, "Registrar Servicio")
            Me.txtPrecioColones.Focus()

        ElseIf Not evaluarNumeric(Me.txtPrecioDolares.Text) Then 'Valida el formato de los campos de precio y porcentaje


            MsgBox("El precio en dólares debe ser solo número", MsgBoxStyle.Information, "Registrar Servicio")
            Me.txtPrecioDolares.Focus()

        ElseIf Not evaluarNumeric(Me.txtSeniorColones.Text) Then 'Valida el formato de los campos de precio y porcentaje


            MsgBox("La comisión senior en colones debe ser solo número", MsgBoxStyle.Information, "Registrar Servicio")
            Me.txtSeniorColones.Focus()

        ElseIf Not evaluarNumeric(Me.txtSeniorDolares.Text) Then 'Valida el formato de los campos de precio y porcentaje

            MsgBox("La comisión senior en dólares debe ser solo número", MsgBoxStyle.Information, "Registrar Servicio")
            Me.txtSeniorDolares.Focus()


        ElseIf Not evaluarNumeric(Me.txtJuniorColones.Text) Then 'Valida el formato de los campos de precio y porcentaje

            MsgBox("La comisión junior en colones debe ser solo número", MsgBoxStyle.Information, "Registrar Servicio")
            Me.txtJuniorColones.Focus()

        ElseIf Not evaluarNumeric(Me.txtJuniorDolares.Text) Then 'Valida el formato de los campos de precio y porcentaje

            MsgBox("La comisión junior en dólares debe ser solo número", MsgBoxStyle.Information, "Registrar Servicio")
            Me.txtJuniorDolares.Focus()

        ElseIf Not evaluarNumeric(Me.txtMasterColones.Text) Then 'Valida el formato de los campos de precio y porcentaje

            MsgBox("La comisión master en colones debe ser solo número", MsgBoxStyle.Information, "Registrar Servicio")
            Me.txtMasterColones.Focus()

        ElseIf Not evaluarNumeric(Me.txtMasterDolares.Text) Then 'Valida el formato de los campos de precio y porcentaje

            MsgBox("La comisión master en dólares debe ser solo número", MsgBoxStyle.Information, "Registrar Servicio")
            Me.txtMasterDolares.Focus()

        Else
            _resul = True

        End If

        Return _resul
    End Function
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

    Private Function evaluarNumeric(ByVal texto As String) As Boolean

        _numero = IsNumeric(texto)

        Return _numero
    End Function

    Private Sub pbLimpiar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbLimpiar.Click
        limpiarForm()
    End Sub


    Private Sub pbReg_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbReg.Click
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
           
            Try

                _gestor.registrarservicio(_cod, _nombre, _descripcion, _preciocolones, _preciodolares, _porcentcomisionjuniorcolones, _porcentcomisionjuniordolares, _porcentcomisionseniorcolones, _porcentcomisionseniordolares, _porcentcomisionmastercolones, _porcentcomisionmasterdolares) 'invocar el método indicado enviando los argumentos requeridos.
                MsgBox(" Los datos del servicio se han registrado correctamente.", MsgBoxStyle.Information, "Aviso")
                
                Me.limpiarForm() 'invocar a la subrutina dedicada a limpiar los controles indicados.

            Catch ex As Exception
                MessageBox.Show("Los datos ingresados ya existen en la base de datos.")
            End Try



        End If
    End Sub

End Class
