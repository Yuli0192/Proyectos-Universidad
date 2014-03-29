Public Class ctlListarGerentes


    Dim _gestor As New CllLogicaNegocio.ClsGestor() 'declaración e instanciación de la clase Gestor
    'declarar una variable tipo lista genérica de Array
    Dim _listaUsuario As List(Of Array) = New List(Of Array)()
    'declarar una variable tipo Array
    Dim _tempArray As Array
    'declarar una variable tipo lista genérica tipo clsCastCadena (Wrapper)
    Dim _cadena As ClsCastCadenaUsuario
    'declarar una variable tipo arreglo de String
    Dim _tempCast() As String
    'declarar variable globales tipo boolean
    Dim _resul As Boolean
    Dim _result As DialogResult
    'declarar variables globales 



    Private Sub frmBuscar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.listarUsuariosDisponibles()

    End Sub

    Private Sub listarUsuariosDisponibles()

        Try


            'asignar el resultado de la búsqueda devuelto por un método del Gestor
            _listaUsuario = _gestor.listarmastersgerentesdisponibles()

            Me.dvgUsuarios.Rows.Clear()

            'estructura iterativa tipo matriz para recorrer y envolver por el tipo adecuado
            For i As Integer = 0 To _listaUsuario.Count - 1
                'clonar a un Array temporal la FILA (ROW) de la consulta
                _tempArray = _listaUsuario(i)

                'agregar a la lista genérica una colección de la clase wrapper
                _cadena = New ClsCastCadenaUsuario(_tempArray(0).ToString(), _tempArray(1).ToString(), _tempArray(2).ToString(), _tempArray(3).ToString(), _tempArray(4).ToString())

                dvgUsuarios.Rows.Add()
                dvgUsuarios.Rows.Item(dvgUsuarios.Rows.Count - 1).Cells.Item(0).Value = _cadena.cedula
                dvgUsuarios.Rows.Item(dvgUsuarios.Rows.Count - 1).Cells.Item(1).Value = _cadena.nombre
                dvgUsuarios.Rows.Item(dvgUsuarios.Rows.Count - 1).Cells.Item(2).Value = _cadena.apellido1
                dvgUsuarios.Rows.Item(dvgUsuarios.Rows.Count - 1).Cells.Item(3).Value = _cadena.apellido2
                dvgUsuarios.Rows.Item(dvgUsuarios.Rows.Count - 1).Cells.Item(4).Value = _cadena.rol

            Next

            'asignar el fuente de dato para un control tipo ComboBox la lista genérica wrappeada


        Catch ex As Exception
            MessageBox.Show("Error en la operación ... " & ex.Message)
        End Try

    End Sub

End Class
