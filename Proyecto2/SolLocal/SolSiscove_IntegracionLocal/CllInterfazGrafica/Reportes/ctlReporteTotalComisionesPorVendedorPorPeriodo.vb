Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports.Engine

Public Class ctlReporteTotalComisionesPorVendedorPorPeriodo
    Dim _gestor As New CllLogicaNegocio.ClsGestor()

    ''' <summary>
    ''' Método de clase, encarga de evaluar que no queden espacios en blanco ningun componente
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function evaluarEspacio() As Boolean
        Dim _resul As Boolean
        If dtpInicio.Value > dtpFin.Value Then
            MsgBox("la fecha inicio debe ser menor q la fecha fin ", MsgBoxStyle.Information, "Aviso")
        Else
            _resul = True
        End If
        Return _resul
    End Function

    Private Sub ctlReporteTotalComisionesPorVendedorPorPeriodo_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles MyBase.Paint
        If ROL_USUARIO.Contains("Gerente") Then
            lblCedula.Text = "Cédula Usuario"
            cmbListar.Visible = True

        ElseIf ROL_USUARIO.Contains("Vendedor") Then
            lblCedula.Text = "Cédula Usuario: " & DATOS_USUARIO(3)
            cmbListar.Visible = False

        End If

        cargarVendedores()
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

    Private Sub pbReporte_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbReporte.Click
        Dim resul As Boolean = evaluarEspacio()
        If resul Then
            Dim reporte As New ReporteTotalComisionesVededorPorPeriodo

            If ROL_USUARIO.Contains("Gerente") Then
                Dim idUsuario As String = Me.cmbListar.SelectedValue.ToString()
                reporte.SetParameterValue("idusuario", idUsuario)

            ElseIf ROL_USUARIO.Contains("Vendedor") Then
                reporte.SetParameterValue("idusuario", DATOS_USUARIO(3))

            End If


            reporte.SetParameterValue("fechainicio", dtpInicio.Value)
            reporte.SetParameterValue("fechafin", dtpFin.Value)
            rprtVwrTotalComisionesPorVendedor.ReportSource = reporte
            rprtVwrTotalComisionesPorVendedor.Refresh()
        End If
    End Sub
End Class
