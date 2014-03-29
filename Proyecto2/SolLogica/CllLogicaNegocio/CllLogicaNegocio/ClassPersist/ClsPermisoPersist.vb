'libreria requerida
Imports CllDataAccess.ClsDataAccess

Public Class ClsPermisoPersist

    Dim _dataAccess As New CllDataAccess.ClsDataAccess

    ''' <summary>
    ''' Método de la clase encargada de listar todos los permisos en la DB
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function listar() As List(Of ClsPermiso)

        Dim _proc = My.Resources.proc_listarpermisos.ToString()
        'instanciar un lector de datos genérico
        Dim _drPermiso As IDataReader
        'declarar e instanciar una lista genérica del tipo ClsPermiso
        Dim _listaGenerica As New List(Of ClsPermiso)

        Try
            'asignar al lector de datos el resultado de la consulta
            _drPermiso = _dataAccess.ExecuteSQL(_proc)

            'cargar a la lista genérica el resultado de la consulta.
            While _drPermiso.Read()
                _listaGenerica.Add(New ClsPermiso(CStr(_drPermiso.Item(0)), CStr(_drPermiso.Item(1)), _
                                                  CStr(_drPermiso.Item(2))))
            End While

            'retornar el resultado
            Return _listaGenerica

        Catch ex As Exception
            Throw New Exception("Error en la persistencia de permiso... " & ex.Message)
        End Try
    End Function


    Public Function buscarPorRol(ByVal prol As String) As List(Of ClsPermiso)

        Dim _proc = My.Resources.proc_buscarpermisosxrol.ToString() 'instanciar variable con el nombre del sp a ejecutar.
        Dim _drPermiso As IDataReader
        Dim listaPermisos As New List(Of ClsPermiso)
        Dim params() As CllDataAccess.Parameters
        ReDim params(0)
        params(0) = New CllDataAccess.Parameters(prol, "nombrerol")

        Try
            _drPermiso = _dataAccess.execute_proc_return(_proc, params) 'Invocar y ejecutar...
            While _drPermiso.Read() 'Carga a la lista genérica el resultado de la consulta.
                listaPermisos.Add(New ClsPermiso(_drPermiso.GetString(0), _drPermiso.GetString(1), _drPermiso.GetString(2)))
            End While

            Return listaPermisos 'Se retorna el resultado
        Catch ex As Exception
            Throw New System.Exception("No se encontraron permisos")
        End Try
    End Function

End Class
