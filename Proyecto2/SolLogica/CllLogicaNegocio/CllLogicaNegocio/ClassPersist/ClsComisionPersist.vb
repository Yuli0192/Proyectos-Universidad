'libreria requerida
Imports CllDataAccess.ClsDataAccess
Imports CllDataAccess.Parameters

Public Class ClsComisionPersist
    Dim _dataAccess As New CllDataAccess.ClsDataAccess
    ''' <summary>
    '''  Método de la clase encargada de buscar un registro de las comisiones a la DB por medio de un Stored Procedure
    ''' </summary>
    ''' <param name="pidUsuario"></param>
    ''' <param name="pfechaInicio"></param>
    ''' <param name="pfechaFin"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function listarComisionPorVendedor(ByVal pidUsuario As String, ByVal pfechaInicio As Date, ByVal pfechaFin As Date) As List(Of ClsComision)
        Dim _proc = My.Resources.proc_listarcomisionesporvendedor.ToString()
        Dim _drComision As IDataReader 'instanciar un lector de datos genérico

        Dim listaComisiones As New List(Of ClsComision) 'declarar e instanciar una lista comisiones del tipo ClsComision

        'instanciar a la clase de ClsParametro e indicar el tamaño del arreglo... (parámetros)
        Dim _params() As CllDataAccess.Parameters
        ReDim _params(2)

        _params(0) = New CllDataAccess.Parameters(pidUsuario, "idusuario") 'asignar para cada posición del arreglo(objeto, nombre)
        _params(1) = New CllDataAccess.Parameters(pfechaInicio, "fechainicio") 'asignar para cada posición del arreglo(objeto, nombre)
        _params(2) = New CllDataAccess.Parameters(pfechaFin, "fechafin") 'asignar para cada posición del arreglo(objeto, nombre)

        Try
            _drComision = _dataAccess.execute_proc_return(_proc, _params) 'asignar al lector de datos el resultado de la consulta

            While _drComision.Read() 'Carga a la lista genérica el resultado de la consulta.
                listaComisiones.Add(New ClsComision(_drComision.GetInt32(0), _drComision.GetString(1), _drComision.GetDateTime(2), _
                                                    _drComision.GetDateTime(3), _drComision.GetDateTime(4), _drComision.GetDateTime(5), _
                                                    _drComision.GetDecimal(6), _drComision.GetDecimal(7), _drComision.GetDecimal(8), _
                                                    _drComision.GetDecimal(9), _drComision.GetDecimal(10), _drComision.GetDecimal(11), _
                                                   _drComision.GetString(12), _drComision.GetString(13), _drComision.GetString(14), _
                                                   _drComision.GetString(15)))
            End While

            Return listaComisiones 'Se retorna el resultado
        Catch ex As Exception
            Throw New System.Exception(ex.Message)
        End Try
    End Function

    ''' <summary>
    ''' Método que se encarga de cancelar las comisiones que cumplan con las condiciones establecidas
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub cancelar()
        Dim _dataAccess As New CllDataAccess.ClsDataAccess
        Dim proc = My.Resources.procCancelarComision.ToString 'Busca de las propiedades del proyecto el nombre del StoreProcedure

        Try
            'Invocar y ejecutar...
            _dataAccess.execute_proc(proc)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub
    ''' <summary>
    ''' Sub encargado de calcular comisiones por cantidad de ventas realizadas
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub cCVentasRealizadas()
        Dim _dataAccess As New CllDataAccess.ClsDataAccess
        Dim proc = My.Resources.procCCVentasRealizadas.ToString 'Busca de las propiedades del proyecto el nombre del StoreProcedure

        Try
            'Invocar y ejecutar...
            _dataAccess.execute_proc(proc)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub
End Class
