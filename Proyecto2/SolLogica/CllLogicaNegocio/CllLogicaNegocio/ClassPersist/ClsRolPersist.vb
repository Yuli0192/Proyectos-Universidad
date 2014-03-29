Public Class ClsRolPersist

    '''<summary>
    ''' Método de la clase encargada de buscar todos los roles en la DB
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function listar() As List(Of ClsRol)
        Dim _pro = My.Resources.proc_SelectAllRol.ToString()
        'instanciar un lector de datos genérico
        Dim _drRol As IDataReader
        Dim dataAccess As New CllDataAccess.ClsDataAccess
        'declarar e instanciar una lista genérica del tipo ClsPermiso
        Dim _listaGenerica As New List(Of ClsRol)

        Try
            'asignar al lector de datos el resultado de la consulta
            _drRol = dataAccess.ExecuteSQL(_pro)

            'cargar a la lista genérica el resultado de la consulta.
            While _drRol.Read()
                _listaGenerica.Add(New ClsRol(_drRol.GetString(0), _drRol.GetString(1)))
            End While

            'retornar el resultado
            Return _listaGenerica

        Catch ex As Exception
            Throw New Exception("Error en la persistencia de Cliente... " & ex.Message)
        End Try
    End Function
End Class



