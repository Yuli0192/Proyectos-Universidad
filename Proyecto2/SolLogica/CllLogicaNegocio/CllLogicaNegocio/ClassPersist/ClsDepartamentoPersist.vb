'libreria requerida
Imports CllDataAccess.ClsDataAccess
Public Class ClsDepartamentoPersist
    Dim _dataAccess As New CllDataAccess.ClsDataAccess

    ''' <summary>
    ''' Método de la clase encargada de buscar todos los clientes en la DB
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function listar() As List(Of ClsDepartamento)

        'instanciar un lector de datos genérico
        Dim _drCliente As IDataReader
        'declarar e instanciar una lista genérica del tipo ClsPermiso
        Dim _listaGenerica As New List(Of ClsDepartamento)
        Dim _pro = My.Resources.proc_SelectAllDepartamento.ToString()
        Try
            'asignar al lector de datos el resultado de la consulta
            _drCliente = _dataAccess.ExecuteSQL(_pro)

            'cargar a la lista genérica el resultado de la consulta.
            While _drCliente.Read()
                _listaGenerica.Add(New ClsDepartamento(_drCliente.GetString(0), _drCliente.GetString(1)))
            End While

            'retornar el resultado
            Return _listaGenerica

        Catch ex As Exception
            Throw New Exception("Error en la persistencia de Cliente... " & ex.Message)
        End Try
    End Function

End Class