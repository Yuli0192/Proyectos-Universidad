'libreria requerida
Imports CllDataAccess.ClsDataAccess

Public Class ClsServicioPersist

    Dim _dataAccess As New CllDataAccess.ClsDataAccess

    ''' <summary>
    '''  ''' Método de la clase encargada de insertar un nuevo registro de servicio a la DB por medio de un Stored Procedure
    ''' </summary>
    ''' <param name="pcod"></param>
    ''' <param name="pnombre"></param>
    ''' <param name="pdescripcion"></param>
    ''' <param name="ppreciocolones"></param>
    ''' <param name="ppreciodolares"></param>
    ''' <param name="pporcentcomisionjuniorcolones"></param>
    ''' <param name="pporcentcomisionjuniordolares"></param>
    ''' <param name="pporcentcomisionseniorcolones"></param>
    ''' <param name="pporcentcomisionseniordolares"></param>
    ''' <param name="pporcentcomisionmastercolones"></param>
    ''' <param name="pporcentcomisionmasterdolares"></param>
    ''' <remarks></remarks>
    Public Sub registrar(ByVal pcod As String, ByVal pnombre As String, ByVal pdescripcion As String, ByVal ppreciocolones As Decimal, _
         ByVal ppreciodolares As Decimal, ByVal pporcentcomisionjuniorcolones As Decimal, _
         ByVal pporcentcomisionjuniordolares As Decimal, ByVal pporcentcomisionseniorcolones As Decimal, _
         ByVal pporcentcomisionseniordolares As Decimal, ByVal pporcentcomisionmastercolones As Decimal, _
         ByVal pporcentcomisionmasterdolares As Decimal)

        Dim _proc = My.Resources.proc_insertservicio.ToString()
        'instanciar a la clase de ClsParametro e indicar el tamaño del arreglo... (parámetros)
        Dim _params() As CllDataAccess.Parameters
        ReDim _params(10)

        'asignar para cada posición del arreglo(objeto, nombre)
        _params(0) = New CllDataAccess.Parameters(pcod, "cod")
        _params(1) = New CllDataAccess.Parameters(pnombre, "nombre")
        _params(2) = New CllDataAccess.Parameters(pdescripcion, "descripcion")
        _params(3) = New CllDataAccess.Parameters(ppreciocolones, "precio_colones")
        _params(4) = New CllDataAccess.Parameters(ppreciodolares, "precio_dolares")
        _params(5) = New CllDataAccess.Parameters(pporcentcomisionjuniorcolones, "porcentcomisionjuniorcolones")
        _params(6) = New CllDataAccess.Parameters(pporcentcomisionjuniordolares, "porcentcomisionjuniordolares")
        _params(7) = New CllDataAccess.Parameters(pporcentcomisionseniorcolones, "porcentcomisionseniorcolones")
        _params(8) = New CllDataAccess.Parameters(pporcentcomisionseniordolares, "porcentcomisionseniordolares")
        _params(9) = New CllDataAccess.Parameters(pporcentcomisionmastercolones, "porcentcomisionmastercolones")
        _params(10) = New CllDataAccess.Parameters(pporcentcomisionmasterdolares, "porcentcomisionmasterdolares")

        Try
            'invocar y ejecutar...
            _dataAccess.execute_proc(_proc, _params)

        Catch ex As Exception
            Throw New System.Exception(ex.Message)
        End Try
    End Sub

    ''' <summary>
    '''  ''' Método de la clase encargada de insertar un nuevo registro de servicio a la DB por medio de un Stored Procedure
    ''' </summary>
    ''' <param name="pcod"></param>
    ''' <param name="pnombre"></param>
    ''' <param name="pdescripcion"></param>
    ''' <param name="ppreciocolones"></param>
    ''' <param name="ppreciodolares"></param>
    ''' <param name="pporcentcomisionjuniorcolones"></param>
    ''' <param name="pporcentcomisionjuniordolares"></param>
    ''' <param name="pporcentcomisionseniorcolones"></param>
    ''' <param name="pporcentcomisionseniordolares"></param>
    ''' <param name="pporcentcomisionmastercolones"></param>
    ''' <param name="pporcentcomisionmasterdolares"></param>
    ''' <remarks></remarks>
    Public Sub registrar(ByVal pcod As String, ByVal pnombre As String, ByVal pdescripcion As String, ByVal ppreciocolones As Decimal, _
         ByVal ppreciodolares As Decimal, ByVal pporcentcomisionjuniorcolones As Decimal, _
         ByVal pporcentcomisionjuniordolares As Decimal, ByVal pporcentcomisionseniorcolones As Decimal, _
         ByVal pporcentcomisionseniordolares As Decimal, ByVal pporcentcomisionmastercolones As Decimal, _
         ByVal pporcentcomisionmasterdolares As Decimal, ByVal ppro As String)

        'instanciar a la clase de ClsParametro e indicar el tamaño del arreglo... (parámetros)
        Dim _params() As CllDataAccess.Parameters
        ReDim _params(10)

        'asignar para cada posición del arreglo(objeto, nombre)
        _params(0) = New CllDataAccess.Parameters(pcod, "cod")
        _params(1) = New CllDataAccess.Parameters(pnombre, "nombre")
        _params(2) = New CllDataAccess.Parameters(pdescripcion, "descripcion")
        _params(3) = New CllDataAccess.Parameters(ppreciocolones, "precio_colones")
        _params(4) = New CllDataAccess.Parameters(ppreciodolares, "precio_dolares")
        _params(5) = New CllDataAccess.Parameters(pporcentcomisionjuniorcolones, "porcentcomisionjuniorcolones")
        _params(6) = New CllDataAccess.Parameters(pporcentcomisionjuniordolares, "porcentcomisionjuniordolares")
        _params(7) = New CllDataAccess.Parameters(pporcentcomisionseniorcolones, "porcentcomisionseniorcolones")
        _params(8) = New CllDataAccess.Parameters(pporcentcomisionseniordolares, "porcentcomisionseniordolares")
        _params(9) = New CllDataAccess.Parameters(pporcentcomisionmastercolones, "porcentcomisionmastercolones")
        _params(10) = New CllDataAccess.Parameters(pporcentcomisionmasterdolares, "porcentcomisionmasterdolares")


        Try
            'invocar y ejecutar...
            _dataAccess.execute_proc(ppro, _params)

        Catch ex As Exception
            Throw New System.Exception(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Método de la clase encargada de buscar un registro de servicio a la DB por medio de un Stored Procedure
    ''' </summary>
    ''' <param name="pcod"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function buscarPorCod(ByVal pcod As String) As ClsServicio
        'instanciar un lector de datos genérico
        Dim _drServicio As IDataReader
        'declarar e instanciar una atributo del tipo ClsServicio
        Dim _servicio As ClsServicio = Nothing

        Dim _proc = My.Resources.proc_selectserviciocod.ToString()

        'instanciar a la clase de ClsParametro e indicar el tamaño del arreglo... (parámetros)
        Dim _params() As CllDataAccess.Parameters
        ReDim _params(0)

        'asignar para cada posición del arreglo(objeto, nombre)
        _params(0) = New CllDataAccess.Parameters(pcod, "cod")

        Try
            'invocar y ejecutar...
            _drServicio = _dataAccess.execute_proc_return(_proc, _params)
            'cargar a la lista genérica el resultado de la consulta.
            While _drServicio.Read()

                _servicio = New ClsServicio(CStr(_drServicio.Item(0)), CStr(_drServicio.Item(1)), CStr(_drServicio.Item(2)), _
                                            CDec(_drServicio.Item(3)), CDec(_drServicio.Item(4)), CDec(_drServicio.Item(5)), _
                                            CDec(_drServicio.Item(6)), CDec(_drServicio.Item(7)), CDec(_drServicio.Item(8)), _
                                            CDec(_drServicio.Item(9)), CDec(_drServicio.Item(10)))
            End While

            'retornar el resultado
            Return _servicio

        Catch ex As Exception
            Throw New System.Exception(ex.Message)
        End Try

    End Function

    ''' <summary>
    ''' Método de la clase encargada de buscar un registro de servicio a la DB por medio de un Stored Procedure
    ''' </summary>
    ''' <param name="pcod"></param>
    ''' <param name="ppro"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function buscarPorCod(ByVal pcod As String, ByVal ppro As String) As List(Of ClsServicio)
        'instanciar un lector de datos genérico
        Dim _drServicio As IDataReader

        'declarar e instanciar una lista genérica del tipo ClsServicio
        Dim _listaGenerica As New List(Of ClsServicio)

        'instanciar a la clase de ClsParametro e indicar el tamaño del arreglo... (parámetros)
        Dim _params() As CllDataAccess.Parameters
        ReDim _params(0)

        'asignar para cada posición del arreglo(objeto, nombre)
        _params(0) = New CllDataAccess.Parameters(pcod, "cod")

        Try
            'asignar al lector de datos el resultado de la consulta
            _drServicio = _dataAccess.execute_proc_return(ppro, _params)

            'cargar a la lista genérica el resultado de la consulta.
            While _drServicio.Read()
                _listaGenerica.Add(New ClsServicio(CStr(_drServicio.Item(0)), CStr(_drServicio.Item(1)), CStr(_drServicio.Item(2)), CDbl(_drServicio.Item(3)), CDbl(_drServicio.Item(4)), CDbl(_drServicio.Item(5)), CDbl(_drServicio.Item(6)), CDbl(_drServicio.Item(7)), CDbl(_drServicio.Item(8)), CDbl(_drServicio.Item(9)), CDbl(_drServicio.Item(10))))
            End While

            'retornar el resultado
            Return _listaGenerica

        Catch ex As Exception
            Throw New System.Exception(ex.Message)
        End Try

    End Function

    ''' <summary>
    '''  Método de la clase encargada de buscar un registro de servicio a la DB por medio de un Stored Procedure
    ''' </summary>
    ''' <param name="pnombre"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function buscarPorNombre(ByVal pnombre As String) As List(Of ClsServicio)

        Dim _proc = My.Resources.proc_selectservicionombre.ToString()
        'instanciar un lector de datos genérico
        Dim _drServicio As IDataReader
        'declarar e instanciar una lista genérica del tipo ClsServicio
        Dim _listaGenerica As New List(Of ClsServicio)
        'instanciar a la clase de ClsParametro e indicar el tamaño del arreglo... (parámetros)
        Dim _params() As CllDataAccess.Parameters
        ReDim _params(0)
        'asignar para cada posición del arreglo(objeto, nombre)
        _params(0) = New CllDataAccess.Parameters(pnombre, "nombre")

        Try
            'asignar al lector de datos el resultado de la consulta
            _drServicio = _dataAccess.execute_proc_return(_proc, _params)

            'cargar a la lista genérica el resultado de la consulta.
            While _drServicio.Read()
                _listaGenerica.Add(New ClsServicio(CStr(_drServicio.Item(0)), CStr(_drServicio.Item(1)), _
                                                   CStr(_drServicio.Item(2)), CDec(_drServicio.Item(3)), _
                                                   CDec(_drServicio.Item(4)), CDec(_drServicio.Item(5)), _
                                                   CDec(_drServicio.Item(6)), CDec(_drServicio.Item(7)), _
                                                   CDec(_drServicio.Item(8)), CDec(_drServicio.Item(9)), _
                                                   CDec(_drServicio.Item(10))))
            End While

            'retornar el resultado
            Return _listaGenerica

        Catch ex As Exception
            Throw New Exception("Error en la persistencia de Servicio... " & ex.Message)
        End Try
    End Function

    ''' <summary>
    ''' Método de la clase encargada de buscar todos los servicio en la DB
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function listar() As List(Of ClsServicio)

        Dim _proc = My.Resources.proc_listarservicios.ToString()
        'instanciar un lector de datos genérico
        Dim _drServicio As IDataReader
        'declarar e instanciar una lista genérica del tipo ClsServicio
        Dim _listaGenerica As New List(Of ClsServicio)

        Try
            'asignar al lector de datos el resultado de la consulta
            _drServicio = _dataAccess.ExecuteSQL(_proc)

            'cargar a la lista genérica el resultado de la consulta.
            While _drServicio.Read()
                _listaGenerica.Add(New ClsServicio(CStr(_drServicio.Item(0)), CStr(_drServicio.Item(1)), _
                                                   CStr(_drServicio.Item(2)), CDec(_drServicio.Item(3)), _
                                                   CDec(_drServicio.Item(4)), CDec(_drServicio.Item(5)), _
                                                   CDec(_drServicio.Item(6)), CDec(_drServicio.Item(7)), _
                                                   CDec(_drServicio.Item(8)), CDec(_drServicio.Item(9)), _
                                                   CDec(_drServicio.Item(10))))
            End While

            'retornar el resultado
            Return _listaGenerica

        Catch ex As Exception
            Throw New Exception("Error en la persistencia de Servicio... " & ex.Message)
        End Try
    End Function

    ''' <summary>
    ''' Método de la clase encargada de modificar un registro de servicio a la DB por medio de un Stored Procedure
    ''' </summary>
    ''' <param name="pcod"></param>
    ''' <param name="pnombre"></param>
    ''' <param name="pdescripcion"></param>
    ''' <param name="ppreciocolones"></param>
    ''' <param name="ppreciodolares"></param>
    ''' <param name="pporcentcomisionjuniorcolones"></param>
    ''' <param name="pporcentcomisionjuniordolares"></param>
    ''' <param name="pporcentcomisionseniorcolones"></param>
    ''' <param name="pporcentcomisionseniordolares"></param>
    ''' <param name="pporcentcomisionmastercolones"></param>
    ''' <param name="pporcentcomisionmasterdolares"></param>
    ''' <remarks></remarks>
    Public Sub modificar(ByVal pcod As String, ByVal pnombre As String, ByVal pdescripcion As String, ByVal ppreciocolones As Decimal, _
         ByVal ppreciodolares As Decimal, ByVal pporcentcomisionjuniorcolones As Decimal, _
         ByVal pporcentcomisionjuniordolares As Decimal, ByVal pporcentcomisionseniorcolones As Decimal, _
         ByVal pporcentcomisionseniordolares As Decimal, ByVal pporcentcomisionmastercolones As Decimal, _
         ByVal pporcentcomisionmasterdolares As Decimal)

        Dim _proc = My.Resources.proc_updateservicio.ToString()
        'instanciar a la clase de ClsParametro e indicar el tamaño del arreglo... (parámetros)
        Dim _params() As CllDataAccess.Parameters
        ReDim _params(10)

        'asignar para cada posición del arreglo(objeto, nombre)
        _params(0) = New CllDataAccess.Parameters(pcod, "cod")
        _params(1) = New CllDataAccess.Parameters(pnombre, "nombre")
        _params(2) = New CllDataAccess.Parameters(pdescripcion, "descripcion")
        _params(3) = New CllDataAccess.Parameters(ppreciocolones, "precio_colones")
        _params(4) = New CllDataAccess.Parameters(ppreciodolares, "precio_dolares")
        _params(5) = New CllDataAccess.Parameters(pporcentcomisionjuniorcolones, "porcentcomisionjuniorcolones")
        _params(6) = New CllDataAccess.Parameters(pporcentcomisionjuniordolares, "porcentcomisionjuniordolares")
        _params(7) = New CllDataAccess.Parameters(pporcentcomisionseniorcolones, "porcentcomisionseniorcolones")
        _params(8) = New CllDataAccess.Parameters(pporcentcomisionseniordolares, "porcentcomisionseniordolares")
        _params(9) = New CllDataAccess.Parameters(pporcentcomisionmastercolones, "porcentcomisionmastercolones")
        _params(10) = New CllDataAccess.Parameters(pporcentcomisionmasterdolares, "porcentcomisionmasterdolares")

        Try
            'invocar y ejecutar...
            _dataAccess.execute_proc(_proc, _params)

        Catch ex As Exception
            Throw New System.Exception(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Método de la clase encargada de modificar un registro de servicio a la DB por medio de un Stored Procedure
    ''' </summary>
    ''' <param name="pcod"></param>
    ''' <param name="pnombre"></param>
    ''' <param name="pdescripcion"></param>
    ''' <param name="ppreciocolones"></param>
    ''' <param name="ppreciodolares"></param>
    ''' <param name="pporcentcomisionjuniorcolones"></param>
    ''' <param name="pporcentcomisionjuniordolares"></param>
    ''' <param name="pporcentcomisionseniorcolones"></param>
    ''' <param name="pporcentcomisionseniordolares"></param>
    ''' <param name="pporcentcomisionmastercolones"></param>
    ''' <param name="pporcentcomisionmasterdolares"></param>
    ''' <remarks></remarks>
    Public Sub modificar(ByVal pcod As String, ByVal pnombre As String, ByVal pdescripcion As String, ByVal ppreciocolones As Decimal, _
         ByVal ppreciodolares As Decimal, ByVal pporcentcomisionjuniorcolones As Decimal, _
         ByVal pporcentcomisionjuniordolares As Decimal, ByVal pporcentcomisionseniorcolones As Decimal, _
         ByVal pporcentcomisionseniordolares As Decimal, ByVal pporcentcomisionmastercolones As Decimal, _
         ByVal pporcentcomisionmasterdolares As Decimal, ByVal ppro As String)

        'instanciar a la clase de ClsParametro e indicar el tamaño del arreglo... (parámetros)
        Dim _params() As CllDataAccess.Parameters
        ReDim _params(10)

        'asignar para cada posición del arreglo(objeto, nombre)
        _params(0) = New CllDataAccess.Parameters(pcod, "cod")
        _params(1) = New CllDataAccess.Parameters(pnombre, "nombre")
        _params(2) = New CllDataAccess.Parameters(pdescripcion, "descripcion")
        _params(3) = New CllDataAccess.Parameters(ppreciocolones, "precio_colones")
        _params(4) = New CllDataAccess.Parameters(ppreciodolares, "precio_dolares")
        _params(5) = New CllDataAccess.Parameters(pporcentcomisionjuniorcolones, "porcentcomisionjuniorcolones")
        _params(6) = New CllDataAccess.Parameters(pporcentcomisionjuniordolares, "porcentcomisionjuniordolares")
        _params(7) = New CllDataAccess.Parameters(pporcentcomisionseniorcolones, "porcentcomisionseniorcolones")
        _params(8) = New CllDataAccess.Parameters(pporcentcomisionseniordolares, "porcentcomisionseniordolares")
        _params(9) = New CllDataAccess.Parameters(pporcentcomisionmastercolones, "porcentcomisionmastercolones")
        _params(10) = New CllDataAccess.Parameters(pporcentcomisionmasterdolares, "porcentcomisionmasterdolares")

        Try
            'invocar y ejecutar...
            _dataAccess.execute_proc(ppro, _params)

        Catch ex As Exception
            Throw New System.Exception(ex.Message)
        End Try
    End Sub


    ''' <summary>
    ''' Método de la clase encargada de eliminar un registro de servicio a la DB por medio de un Stored Procedure
    ''' </summary>
    ''' <param name="pcod"></param>
    ''' <remarks></remarks>
    Public Sub eliminar(ByVal pcod As String)

        Dim _proc = My.Resources.proc_deleteservicio.ToString()
        'instanciar a la clase de ClsParametro e indicar el tamaño del arreglo... (parámetros)
        Dim _params() As CllDataAccess.Parameters
        ReDim _params(0)

        'asignar para cada posición del arreglo(objeto, nombre)
        _params(0) = New CllDataAccess.Parameters(pcod, "cod")

        Try
            'invocar y ejecutar...
            _dataAccess.execute_proc(_proc, _params)

        Catch ex As Exception
            Throw New System.Exception(ex.Message)
        End Try
    End Sub

    Public Function buscarPorGrupoDeVentas(ByVal pcodigo As String) As List(Of ClsServicio)

        Dim _proc = My.Resources.proc_buscarserviciosdegrupoventas.ToString() 'instanciar variable con el nombre del sp a ejecutar.
        Dim drServicio As IDataReader
        Dim listaServicios As New List(Of ClsServicio)
        Dim params() As CllDataAccess.Parameters
        ReDim params(0)
        params(0) = New CllDataAccess.Parameters(pcodigo, "codGrupo")

        Try
            drServicio = _dataAccess.execute_proc_return(_proc, params) 'Invocar y ejecutar...

            While drServicio.Read() 'Carga a la lista genérica el resultado de la consulta.
                listaServicios.Add(New ClsServicio(drServicio.GetString(0), drServicio.GetString(1), _
                                    drServicio.GetString(2), drServicio.GetDecimal(3), drServicio.GetDecimal(4), _
                                    drServicio.GetDecimal(5), drServicio.GetDecimal(6), drServicio.GetDecimal(7), _
                                    drServicio.GetDecimal(8), drServicio.GetDecimal(9), drServicio.GetDecimal(10)))
            End While

            Return listaServicios 'Se retorna el resultado
        Catch ex As Exception
            Throw New System.Exception(ex.Message)
        End Try
    End Function

    Public Function buscarServiciosPorPlanVentas(ByVal pidPlan As String) As List(Of ClsServicio)
        Dim _proc = My.Resources.proc_selectplanservicio.ToString()
        Dim _drServicio As IDataReader 'instanciar un lector de datos genérico

        Dim _listaGenerica As New List(Of ClsServicio) 'declarar e instanciar una lista genérica del tipo ClsServicio

        'instanciar a la clase de ClsParametro e indicar el tamaño del arreglo... (parámetros)
        Dim _params() As CllDataAccess.Parameters
        ReDim _params(0)

        _params(0) = New CllDataAccess.Parameters(pidPlan, "idplan") 'asignar para cada posición del arreglo(objeto, nombre)

        Try
            _drServicio = _dataAccess.execute_proc_return(_proc, _params) 'asignar al lector de datos el resultado de la consulta

            While _drServicio.Read()
                _listaGenerica.Add(New ClsServicio(_drServicio.GetString(0), _drServicio.GetString(1), _drServicio.GetString(2), _drServicio.GetDecimal(3), _drServicio.GetDecimal(4), _drServicio.GetDecimal(5), _drServicio.GetDecimal(6), _drServicio.GetDecimal(7), _drServicio.GetDecimal(8), _drServicio.GetDecimal(9), _drServicio.GetDecimal(10), _drServicio.GetDecimal(11))) 'cargar a la lista genérica el resultado de la consulta.
            End While


            Return _listaGenerica 'retornar el resultado

        Catch ex As Exception
            Throw New Exception("Error en la persistencia de Servicio... " & ex.Message)
        End Try
    End Function
    ''' <summary>
    '''  Método de la clase encargada de buscar un registro de servicio que no esten en ese plan de ventas que tenga la DB por medio de un Stored Procedure
    ''' </summary>
    ''' <param name="pidPlan"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function buscarServiciosSinPlan(ByVal pidPlan As String) As List(Of ClsServicio)
        Dim _proc = My.Resources.proc_selectserviciosinplan.ToString()
        Dim _drServicio As IDataReader 'instanciar un lector de datos genérico

        Dim _listaGenerica As New List(Of ClsServicio) 'declarar e instanciar una lista genérica del tipo ClsServicio

        'instanciar a la clase de ClsParametro e indicar el tamaño del arreglo... (parámetros)
        Dim _params() As CllDataAccess.Parameters
        ReDim _params(0)

        _params(0) = New CllDataAccess.Parameters(pidPlan, "idplan") 'asignar para cada posición del arreglo(objeto, nombre)

        Try
            _drServicio = _dataAccess.execute_proc_return(_proc, _params) 'asignar al lector de datos el resultado de la consulta

            While _drServicio.Read()
                _listaGenerica.Add(New ClsServicio(_drServicio.GetString(0), _drServicio.GetString(1), _drServicio.GetString(2), _drServicio.GetDecimal(3), _drServicio.GetDecimal(4), _drServicio.GetDecimal(5), _drServicio.GetDecimal(6), _drServicio.GetDecimal(7), _drServicio.GetDecimal(8), _drServicio.GetDecimal(9), _drServicio.GetDecimal(10))) 'cargar a la lista genérica el resultado de la consulta.
            End While


            Return _listaGenerica 'retornar el resultado

        Catch ex As Exception
            Throw New Exception("Error en la persistencia de Servicio... " & ex.Message)
        End Try
    End Function

    ''' <summary>
    ''' Método de la clase encargada de eliminar un registro de servicio a la DB por medio de un Stored Procedure
    ''' </summary>
    ''' <param name="pcod"></param>
    ''' <param name="ppro"></param>
    ''' <remarks></remarks>
    Public Sub eliminar(ByVal pcod As String, ByVal ppro As String)

        'instanciar a la clase de ClsParametro e indicar el tamaño del arreglo... (parámetros)
        Dim _params() As CllDataAccess.Parameters
        ReDim _params(0)

        'asignar para cada posición del arreglo(objeto, nombre)
        _params(0) = New CllDataAccess.Parameters(pcod, "cod")

        Try
            'invocar y ejecutar...
            _dataAccess.execute_proc(ppro, _params)

        Catch ex As Exception
            Throw New System.Exception(ex.Message)
        End Try
    End Sub

    ''' <summary>
    '''  Método de la clase encargada de buscar un registro de servicio a la DB por medio de un Stored Procedure
    ''' </summary>
    ''' <param name="pnombre"></param>
    ''' <param name="ppro"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function buscarPorNombre(ByVal pnombre As String, ByVal ppro As String) As List(Of ClsServicio)
        'instanciar un lector de datos genérico
        Dim _drServicio As IDataReader

        'declarar e instanciar una lista genérica del tipo ClsServicio
        Dim _listaGenerica As New List(Of ClsServicio)

        'instanciar a la clase de ClsParametro e indicar el tamaño del arreglo... (parámetros)
        Dim _params() As CllDataAccess.Parameters
        ReDim _params(0)

        'asignar para cada posición del arreglo(objeto, nombre)
        _params(0) = New CllDataAccess.Parameters(pnombre, "nombre")

        Try
            'asignar al lector de datos el resultado de la consulta
            _drServicio = _dataAccess.execute_proc_return(ppro, _params)

            'cargar a la lista genérica el resultado de la consulta.
            While _drServicio.Read()
                _listaGenerica.Add(New ClsServicio(CStr(_drServicio.Item(0)), CStr(_drServicio.Item(1)), CStr(_drServicio.Item(2)), CDbl(_drServicio.Item(3)), CDbl(_drServicio.Item(4)), CDbl(_drServicio.Item(5)), CDbl(_drServicio.Item(6)), CDbl(_drServicio.Item(7)), CDbl(_drServicio.Item(8)), CDbl(_drServicio.Item(9)), CDbl(_drServicio.Item(10))))
            End While

            'retornar el resultado
            Return _listaGenerica

        Catch ex As Exception
            Throw New Exception("Error en la persistencia de Servicio... " & ex.Message)
        End Try
    End Function

    ''' <summary>
    ''' Método de la clase encargada de buscar todos los servicio en la DB
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function listar(ByVal ppro As String) As List(Of ClsServicio)
        'instanciar un lector de datos genérico
        Dim _drServicio As IDataReader
        'declarar e instanciar una lista genérica del tipo ClsServicio
        Dim _listaGenerica As New List(Of ClsServicio)

        Try
            'asignar al lector de datos el resultado de la consulta
            _drServicio = _dataAccess.execute_proc_return(ppro)

            'cargar a la lista genérica el resultado de la consulta.
            While _drServicio.Read()
                _listaGenerica.Add(New ClsServicio(CStr(_drServicio.Item(0)), CStr(_drServicio.Item(1)), CStr(_drServicio.Item(2)), CDbl(_drServicio.Item(3)), CDbl(_drServicio.Item(4)), CDbl(_drServicio.Item(5)), CDbl(_drServicio.Item(6)), CDbl(_drServicio.Item(7)), CDbl(_drServicio.Item(8)), CDbl(_drServicio.Item(9)), CDbl(_drServicio.Item(10))))
            End While

            'retornar el resultado
            Return _listaGenerica

        Catch ex As Exception
            Throw New Exception("Error en la persistencia de Servicio... " & ex.Message)
        End Try
    End Function

    Public Function buscarServiciosDispGrupo(ByVal codGrupo As String) As List(Of ClsServicio)
        Dim _proc = My.Resources.proc_buscarserviciosdispparagrupo.ToString()
        Dim _drServicio As IDataReader 'instanciar un lector de datos genérico

        Dim _listaGenerica As New List(Of ClsServicio) 'declarar e instanciar una lista genérica del tipo ClsServicio

        'instanciar a la clase de ClsParametro e indicar el tamaño del arreglo... (parámetros)
        Dim _params() As CllDataAccess.Parameters
        ReDim _params(0)

        _params(0) = New CllDataAccess.Parameters(codGrupo, "codgrupo") 'asignar para cada posición del arreglo(objeto, nombre)

        Try
            _drServicio = _dataAccess.execute_proc_return(_proc, _params) 'asignar al lector de datos el resultado de la consulta

            While _drServicio.Read()
                _listaGenerica.Add(New ClsServicio(_drServicio.GetString(0), _drServicio.GetString(1), _drServicio.GetString(2), _drServicio.GetDecimal(3), _drServicio.GetDecimal(4), _drServicio.GetDecimal(5), _drServicio.GetDecimal(6), _drServicio.GetDecimal(7), _drServicio.GetDecimal(8), _drServicio.GetDecimal(9), _drServicio.GetDecimal(10))) 'cargar a la lista genérica el resultado de la consulta.
            End While


            Return _listaGenerica 'retornar el resultado

        Catch ex As Exception
            Throw New Exception("Error en la persistencia de Servicio... " & ex.Message)
        End Try
    End Function
End Class
