Public Class ctlListarPermisos


    Dim _gestor As New CllLogicaNegocio.ClsGestor() 'declaración e instanciación de la clase Gestor
    'declarar una variable tipo lista genérica de Array
    Dim _listaPermiso As List(Of Array) = New List(Of Array)()
    'declarar una variable tipo Array
    Dim _tempArray As Array
    'declarar una variable tipo lista genérica tipo clsCastCadena (Wrapper)
    Dim _cadena As ClsCastCadenaPermiso
    'declarar una variable tipo arreglo de String
    Dim _tempCast() As String
    'declarar variable globales tipo boolean
    Dim _resul As Boolean
    Dim _result As DialogResult
    'declarar variables globales 
    Dim _criterio As String
    Dim _cod As String
    Dim _nombre As String
    Dim _descripcion As String


    Private Sub frmBuscar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.listarPermisos()

    End Sub

    Private Sub listarPermisos()

        Try


            'asignar el resultado de la búsqueda devuelto por un método del Gestor
            _listaPermiso = _gestor.listarPermiso()

            Me.dvgPermisos.Rows.Clear()

            'estructura iterativa tipo matriz para recorrer y envolver por el tipo adecuado
            For i As Integer = 0 To _listaPermiso.Count - 1
                'clonar a un Array temporal la FILA (ROW) de la consulta
                _tempArray = _listaPermiso(i)

                'agregar a la lista genérica una colección de la clase wrapper
                _cadena = New ClsCastCadenaPermiso(_tempArray(0).ToString(), _tempArray(1).ToString(), _tempArray(2).ToString())

                dvgPermisos.Rows.Add()
                dvgPermisos.Rows.Item(dvgPermisos.Rows.Count - 1).Cells.Item(0).Value = _cadena.codPermiso
                dvgPermisos.Rows.Item(dvgPermisos.Rows.Count - 1).Cells.Item(1).Value = _cadena.nombrePermiso
                dvgPermisos.Rows.Item(dvgPermisos.Rows.Count - 1).Cells.Item(2).Value = _cadena.descripcionPermiso

            Next

            'asignar el fuente de dato para un control tipo ComboBox la lista genérica wrappeada


        Catch ex As Exception
            MessageBox.Show("Error en la operación ... " & ex.Message)
        End Try

    End Sub


   
End Class
