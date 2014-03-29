'libreria requerida
Imports CllDataAccess.ClsDataAccess
Public Class ClsPlanVentaPersist
    Dim _dataAccess As New CllDataAccess.ClsDataAccess

    ''' <summary>
    ''' Método de la clase encargada de insertar un nuevo registro de plan de ventas a la DB por medio de un Stored Procedure
    ''' </summary>
    ''' <param name="pidPlanVenta"></param>
    ''' <param name="pdescripcion"></param>
    ''' <param name="pfechaInicio"></param>
    ''' <param name="pfechaFin"></param>
    ''' <param name="pplanServicios"></param>
    ''' <remarks></remarks>
    Public Sub registrar(ByVal pidPlanVenta As String, ByVal pdescripcion As String, ByVal pfechaInicio As Date, ByVal pfechaFin As Date, ByVal pplanServicios As List(Of ArrayList))
        Dim _proc = My.Resources.proc_insertplanventa.ToString()
        'instanciar a la clase de ClsParametro e indicar el tamaño del arreglo... (parámetros)
        Dim _params() As CllDataAccess.Parameters
        ReDim _params(3)

        'asignar para cada posición del arreglo(objeto, nombre)
        _params(0) = New CllDataAccess.Parameters(pidPlanVenta, "id")
        _params(1) = New CllDataAccess.Parameters(pdescripcion, "descripcion")
        _params(2) = New CllDataAccess.Parameters(pfechaInicio, "fechainicio")
        _params(3) = New CllDataAccess.Parameters(pfechaFin, "fechafin")

        Try
            'invocar y ejecutar...
            _dataAccess.execute_proc(_proc, _params)

            'For Each datosPlanServicio As ArrayList In pplanServicios
            agregarServicioPlan(pidPlanVenta, pplanServicios)
            'Next

        Catch ex As Exception
            Throw New System.Exception(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Método de la clase encargada de insertar el servicio del plan de ventas a la DB por medio de un Stored Procedure
    ''' </summary>
    ''' <param name="pidPlanVenta"></param>
    ''' <param name="pplanServicios"></param>
    ''' <remarks></remarks>
    Public Sub agregarServicioPlan(ByVal pidPlanVenta As String, ByVal pplanServicios As List(Of ArrayList))
        Dim _proc = My.Resources.proc_insertplanservicio.ToString()
        'instanciar a la clase de ClsParametro e indicar el tamaño del arreglo... (parámetros)
        Dim _params() As CllDataAccess.Parameters
        ReDim _params(2)
        'Como son varios productos los que tiene que registrar tiene que hacer un for.
        For Each datosProductoPlan As ArrayList In pplanServicios

            'Hay que cambiar el id en el parametro, dentro del for.
            _params(0) = New CllDataAccess.Parameters(pidPlanVenta, "idplan")
            _params(1) = New CllDataAccess.Parameters(datosProductoPlan(0), "codservicio")
            _params(2) = New CllDataAccess.Parameters(datosProductoPlan(1), "cantplaneada")
            Try
                'invocar y ejecutar...
                _dataAccess.execute_proc(_proc, _params)

            Catch ex As Exception
                Throw New System.Exception(ex.Message)
            End Try
        Next
    End Sub

    ''' <summary>
    ''' Método de la clase encargada de insertar el servicio del plan de ventas a la DB por medio de un Stored Procedure
    ''' </summary>
    ''' <param name="pidPlanVenta"></param>
    ''' <param name="pcodServicio"></param>
    ''' <param name="pcantPlaneada"></param>
    ''' <remarks></remarks>
    Public Sub modificarServicioPlan(ByVal pidPlanVenta As String, ByVal pcodServicio As String, ByVal pcantPlaneada As Decimal)
        Dim _proc = My.Resources.proc_insertplanservicio.ToString()
        'instanciar a la clase de ClsParametro e indicar el tamaño del arreglo... (parámetros)
        Dim _params() As CllDataAccess.Parameters
        ReDim _params(2)

        'Hay que cambiar el id en el parametro, dentro del for.
        _params(0) = New CllDataAccess.Parameters(pidPlanVenta, "idplan")
        _params(1) = New CllDataAccess.Parameters(pcodServicio, "codservicio")
        _params(2) = New CllDataAccess.Parameters(pcantPlaneada, "cantplaneada")
        Try
            'invocar y ejecutar...
            _dataAccess.execute_proc(_proc, _params)

        Catch ex As Exception
            Throw New System.Exception(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Método de la clase encargada de buscar todos los planes de ventas en la DB
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function listar() As List(Of ClsPlanVenta)
        Dim _proc = My.Resources.proc_listarplanes.ToString()

        Dim _drPlanVenta As IDataReader 'instanciar un lector de datos genérico

        Dim _listaPlanVentas As New List(Of ClsPlanVenta) 'declarar e instanciar una lista genérica del tipo ClsPlanVenta

        Try
            _drPlanVenta = _dataAccess.ExecuteSQL(_proc) 'asignar al lector de datos el resultado de la consulta

            While _drPlanVenta.Read()
                _listaPlanVentas.Add(New ClsPlanVenta(_drPlanVenta.GetString(0), _drPlanVenta.GetString(1), _drPlanVenta.GetDateTime(2), _drPlanVenta.GetDateTime(3))) 'cargar a la lista genérica el resultado de la consulta.
            End While


            Return _listaPlanVentas 'retornar el resultado

        Catch ex As Exception
            Throw New Exception("Error en la persistencia de Plan de ventas... " & ex.Message)
        End Try
    End Function

    ''' <summary>
    '''  Método de la clase encargada de buscar un registro de plan de ventas a la DB por medio de un Stored Procedure
    ''' </summary>
    ''' <param name="pfechaInicio"></param>
    ''' <param name="pfechaFin"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function buscarPorFecha(ByVal pfechaInicio As Date, ByVal pfechaFin As Date) As List(Of ClsPlanVenta)
        Dim _proc = My.Resources.proc_selectplanventa.ToString()
        Dim _drPlanVenta As IDataReader 'instanciar un lector de datos genérico

        Dim _listaPlanVentas As New List(Of ClsPlanVenta) 'declarar e instanciar una lista plan de ventas del tipo ClsPlanVenta

        'instanciar a la clase de ClsParametro e indicar el tamaño del arreglo... (parámetros)
        Dim _params() As CllDataAccess.Parameters
        ReDim _params(1)

        _params(0) = New CllDataAccess.Parameters(pfechaInicio, "fechainicio") 'asignar para cada posición del arreglo(objeto, nombre)
        _params(1) = New CllDataAccess.Parameters(pfechaFin, "fechafin") 'asignar para cada posición del arreglo(objeto, nombre)

        Try
            _drPlanVenta = _dataAccess.execute_proc_return(_proc, _params) 'asignar al lector de datos el resultado de la consulta

            While _drPlanVenta.Read()
                _listaPlanVentas.Add(New ClsPlanVenta(_drPlanVenta.GetString(0), _drPlanVenta.GetString(1), _drPlanVenta.GetDateTime(2), _drPlanVenta.GetDateTime(3))) 'cargar a la lista genérica el resultado de la consulta.
            End While


            Return _listaPlanVentas 'retornar el resultado

        Catch ex As Exception
            Throw New Exception("Error en la persistencia de Plan de ventas... " & ex.Message)
        End Try
    End Function

    ''' <summary>
    ''' Método de la clase encargada de eliminar un registro de plan de ventas a la DB por medio de un Stored Procedure
    ''' </summary>
    ''' <param name="pidPlan"></param>
    ''' <remarks></remarks>
    Public Sub eliminar(ByVal pidPlan As String)
        Dim _proc = My.Resources.proc_deleteplanventa.ToString()
        'instanciar a la clase de ClsParametro e indicar el tamaño del arreglo... (parámetros)
        Dim _params() As CllDataAccess.Parameters
        ReDim _params(0)

        _params(0) = New CllDataAccess.Parameters(pidPlan, "idplan") 'asignar para cada posición del arreglo(objeto, nombre)

        Try
            _dataAccess.execute_proc(_proc, _params) 'invocar y ejecutar...

        Catch ex As Exception
            Throw New System.Exception(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Método de la clase encargada de eliminar un registro de servicio en plan de ventas a la DB por medio de un Stored Procedure
    ''' </summary>
    ''' <param name="pidPlanVenta"></param>
    ''' <param name="pcodServicio"></param>
    ''' <remarks></remarks>
    Public Sub eliminarPlanServicio(ByVal pidPlanVenta As String, ByVal pcodServicio As String)
        Dim _proc = My.Resources.procdeleteplanservicio.ToString()
        'instanciar a la clase de ClsParametro e indicar el tamaño del arreglo... (parámetros)
        Dim _params() As CllDataAccess.Parameters
        ReDim _params(1)

        _params(0) = New CllDataAccess.Parameters(pidPlanVenta, "idplan") 'asignar para cada posición del arreglo(objeto, nombre)
        _params(1) = New CllDataAccess.Parameters(pcodServicio, "codservicio") 'asignar para cada posición del arreglo(objeto, nombre)

        Try
            _dataAccess.execute_proc(_proc, _params) 'invocar y ejecutar...

        Catch ex As Exception
            Throw New System.Exception(ex.Message)
        End Try
    End Sub

End Class