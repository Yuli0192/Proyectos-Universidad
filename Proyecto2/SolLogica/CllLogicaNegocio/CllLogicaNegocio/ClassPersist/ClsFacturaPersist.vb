'libreria requerida
Imports CllDataAccess.ClsDataAccess

Public Class ClsFacturaPersist

    Dim _dataAccess As New CllDataAccess.ClsDataAccess


    Public Sub invalidarFacturasVencidas()
        Dim _proc = My.Resources.proc_invalidarfactura.ToString()
        Try
            'invocar y ejecutar...
            _dataAccess.execute_proc(_proc)

        Catch ex As Exception
            Throw New System.Exception(ex.Message)
        End Try
    End Sub

    Public Sub registrar(ByVal pnum As String, ByVal pidCliente As String, ByVal pidUsuario As String, _
                   ByVal pfechaValidez As Date, ByVal pmoneda As String, ByVal plineaDetalle As String())
        'instanciar variable con el nombre del sp a ejecutar.
        Dim _proc = My.Resources.proc_registrarfactura.ToString()

        'instanciar a la clase de ClsParametro e indicar el tamaño del arreglo... (parámetros)
        Dim _params() As CllDataAccess.Parameters
        ReDim _params(4)

        'asignar para cada posición del arreglo(objeto, nombre)
        _params(0) = New CllDataAccess.Parameters(pnum, "num")
        _params(1) = New CllDataAccess.Parameters(pidCliente, "idcliente")
        _params(2) = New CllDataAccess.Parameters(pidUsuario, "idusuario")
        _params(3) = New CllDataAccess.Parameters(pfechaValidez, "fechavalidez")
        _params(4) = New CllDataAccess.Parameters(pmoneda, "moneda")

        Try
            'invocar y ejecutar...
            _dataAccess.execute_proc(_proc, _params)

            agregarLineaDeDetalle(pnum, plineaDetalle)

        Catch ex As Exception
            Throw New System.Exception(ex.Message)
        End Try
    End Sub

    Public Function buscar(ByVal pnum As String) As ClsFactura

        Dim _proc = My.Resources.proc_buscarfactura.ToString()
        'instanciar un lector de datos genérico
        Dim _drFactura As IDataReader
        'declarar e instanciar una variable del tipo ClsGrupoDeventa
        Dim _factura As New ClsFactura()
        'instanciar a la clase de ClsParametro e indicar el tamaño del arreglo... (parámetros)
        Dim _params() As CllDataAccess.Parameters
        ReDim _params(0)
        'asignar para cada posición del arreglo(objeto, nombre)
        _params(0) = New CllDataAccess.Parameters(pnum, "num")

        Try
            'invocar y ejecutar...
            _drFactura = _dataAccess.execute_proc_return(_proc, _params)

            While _drFactura.Read()
                _factura = New ClsFactura(_drFactura.GetString(0), _drFactura.GetString(1), _drFactura.GetString(2), _
                                      _drFactura.GetDateTime(3), _drFactura.GetDateTime(4), _drFactura.GetDateTime(5), _
                                      _drFactura.GetString(6), _drFactura.GetString(7), _drFactura.GetDecimal(8), _
                                      _drFactura.GetDecimal(9))
            End While
            'retornar el resultado
            Return _factura

        Catch ex As Exception
            Throw New System.Exception(ex.Message)
        End Try

    End Function

    Public Function buscarPorAprox(ByVal pnum As String) As List(Of ClsFactura)
        Dim _proc = My.Resources.proc_buscarfacturaaprox.ToString()
        Dim _drFactura As IDataReader 'instanciar un lector de datos genérico

        Dim _listaFactura As New List(Of ClsFactura) 'declarar e instanciar una lista genérica del tipo ClsCliente

        'instanciar a la clase de ClsParametro e indicar el tamaño del arreglo... (parámetros)
        Dim _params() As CllDataAccess.Parameters
        ReDim _params(0)

        _params(0) = New CllDataAccess.Parameters(pnum, "num") 'asignar para cada posición del arreglo(objeto, nombre)

        Try
            _drFactura = _dataAccess.execute_proc_return(_proc, _params) 'asignar al lector de datos el resultado de la consulta

            While _drFactura.Read()
                _listaFactura.Add(New ClsFactura(_drFactura.GetString(0), _drFactura.GetString(1), _drFactura.GetString(2), _
                                     _drFactura.GetDateTime(3), _drFactura.GetDateTime(4), _drFactura.GetDateTime(5), _
                                     _drFactura.GetString(6), _drFactura.GetString(7), _drFactura.GetDecimal(8), _
                                     _drFactura.GetDecimal(9)))
            End While


            Return _listaFactura 'retornar el resultado

        Catch ex As Exception
            Throw New Exception("Error en la persistencia de Factura... " & ex.Message)
        End Try
    End Function

    Public Function listar() As List(Of ClsFactura)

        Dim proc = My.Resources.proc_listarfacturas.ToString()
        Dim _drFactura As IDataReader
        Dim listaFacturas As New List(Of ClsFactura)
        Dim dataAccess = New CllDataAccess.ClsDataAccess()

        Try
            _drFactura = dataAccess.ExecuteSQL(proc)
            While _drFactura.Read()

                listaFacturas.Add(New ClsFactura(_drFactura.GetString(0), _drFactura.GetString(1), _drFactura.GetString(2), _
                                     _drFactura.GetDateTime(3), _drFactura.GetDateTime(4), _drFactura.GetDateTime(5), _
                                     _drFactura.GetString(6), _drFactura.GetString(7), _drFactura.GetDecimal(8), _
                                     _drFactura.GetDecimal(9)))
            End While

            Return listaFacturas
        Catch ex As Exception
            Throw New System.Exception(ex.Message)
        End Try
    End Function

    Public Function buscarPorCliente(ByVal pidCliente As String) As List(Of ClsFactura)
        Dim _proc = My.Resources.proc_buscarfacturasporcliente.ToString() 'instanciar variable con el nombre del sp a ejecutar.
        Dim _drFactura As IDataReader
        Dim listaFacturas As New List(Of ClsFactura)
        Dim params() As CllDataAccess.Parameters
        ReDim params(0)
        params(0) = New CllDataAccess.Parameters(pidCliente, "idCliente")

        Try
            _drFactura = _dataAccess.execute_proc_return(_proc, params) 'Invocar y ejecutar...
            While _drFactura.Read() 'Carga a la lista genérica el resultado de la consulta.
                listaFacturas.Add(New ClsFactura(_drFactura.GetString(0), _drFactura.GetString(1), _
                                                 _drFactura.GetString(2), _drFactura.GetDateTime(3), _
                                                 _drFactura.GetDateTime(4), _drFactura.GetDateTime(5), _
                                                 _drFactura.GetString(6), _drFactura.GetString(7), _
                                                 _drFactura.GetDecimal(8), _drFactura.GetDecimal(9)))
            End While

            Return listaFacturas 'Se retorna el resultado
        Catch ex As Exception
            Throw New System.Exception(ex.Message)
        End Try
    End Function

    Public Function buscarPorVendedor(ByVal pidUsuario As String) As List(Of ClsFactura)
        Dim _proc = My.Resources.proc_buscarfacturasporvendedor.ToString() 'instanciar variable con el nombre del sp a ejecutar.
        Dim _drFactura As IDataReader
        Dim listaFacturas As New List(Of ClsFactura)
        Dim params() As CllDataAccess.Parameters
        ReDim params(0)
        params(0) = New CllDataAccess.Parameters(pidUsuario, "idusuario")

        Try
            _drFactura = _dataAccess.execute_proc_return(_proc, params) 'Invocar y ejecutar...
            While _drFactura.Read() 'Carga a la lista genérica el resultado de la consulta.
                listaFacturas.Add(New ClsFactura(_drFactura.GetString(0), _drFactura.GetString(1), _
                                                 _drFactura.GetString(2), _drFactura.GetDateTime(3), _
                                                 _drFactura.GetDateTime(4), _drFactura.GetDateTime(5), _
                                                 _drFactura.GetString(6), _drFactura.GetString(7), _
                                                 _drFactura.GetDecimal(8), _drFactura.GetDecimal(9)))
            End While

            Return listaFacturas 'Se retorna el resultado
        Catch ex As Exception
            Throw New System.Exception(ex.Message)
        End Try
    End Function

    Public Function buscarDetalle(ByVal pnum As String) As List(Of Array)
        Dim _proc = My.Resources.proc_buscardetalle.ToString() 'instanciar variable con el nombre del sp a ejecutar.
        Dim _drDetalle As IDataReader
        'Dim dataAccess As New CllDataAccess.ClsDataAccess
        Dim _listaDetalle As New List(Of Array)
        Dim params() As CllDataAccess.Parameters
        ReDim params(0)
        params(0) = New CllDataAccess.Parameters(pnum, "num")

        Try
            _drDetalle = _dataAccess.execute_proc_return(_proc, params) 'Invocar y ejecutar...
            While _drDetalle.Read() 'Carga a la lista genérica el resultado de la consulta.
                Dim lineaDetalle As String() = {_drDetalle.GetString(0), _drDetalle.GetString(1), _
                                                CStr(_drDetalle.GetInt32(2)), CStr(_drDetalle.GetDecimal(3))}
                _listaDetalle.Add(lineaDetalle)
            End While

            Return _listaDetalle 'Se retorna el resultado
        Catch ex As Exception
            Throw New System.Exception(ex.Message)
        End Try
    End Function

    Public Sub aceptar(ByVal pnum As String, ByVal ptipoDeCambio As Decimal)

        Dim _proc = My.Resources.proc_aprobarfactura.ToString()
        'instanciar a la clase de ClsParametro e indicar el tamaño del arreglo... (parámetros)
        Dim _params() As CllDataAccess.Parameters
        ReDim _params(1)

        'asignar para cada posición del arreglo(objeto, nombre)
        _params(0) = New CllDataAccess.Parameters(pnum, "num")
        _params(1) = New CllDataAccess.Parameters(ptipoDeCambio, "tipodecambio")

        Try
            'invocar y ejecutar...
            _dataAccess.execute_proc(_proc, _params)

        Catch ex As Exception
            Throw New System.Exception(ex.Message)
        End Try
    End Sub

    Public Sub eliminar(ByVal pnum As String)

        Dim _proc = My.Resources.proc_eliminarfactura.ToString()

        Dim _params() As CllDataAccess.Parameters
        ReDim _params(0)

        _params(0) = New CllDataAccess.Parameters(pnum, "num")
        Try
            _dataAccess.execute_proc(_proc, _params) 'invocar y ejecutar...

        Catch ex As Exception
            Throw New System.Exception(ex.Message)
        End Try
    End Sub

    Public Sub agregarLineaDeDetalle(ByVal pnum As String, ByVal plineaDetalle As String())

        Dim _proc = My.Resources.proc_agregarlineadetalle.ToString()
        'instanciar a la clase de ClsParametro e indicar el tamaño del arreglo... (parámetros)
        Dim _params() As CllDataAccess.Parameters
        ReDim _params(3)

        _params(0) = New CllDataAccess.Parameters(pnum, "num")
        _params(1) = New CllDataAccess.Parameters(plineaDetalle(0), "codservicio")
        _params(2) = New CllDataAccess.Parameters(CInt(plineaDetalle(1)), "cantidad")
        _params(3) = New CllDataAccess.Parameters(CDec(plineaDetalle(2)), "precio")

        Try
            'invocar y ejecutar...
            _dataAccess.execute_proc(_proc, _params)

        Catch ex As Exception
            Throw New System.Exception(ex.Message)
        End Try
    End Sub

    Public Sub eliminarLineaDeDetalle(ByVal pnum As String, ByVal codServicio As String)

        Dim _proc = My.Resources.proc_eliminarlineadetalle.ToString()
        'instanciar a la clase de ClsParametro e indicar el tamaño del arreglo... (parámetros)
        Dim _params() As CllDataAccess.Parameters
        ReDim _params(1)

        _params(0) = New CllDataAccess.Parameters(pnum, "num")
        _params(1) = New CllDataAccess.Parameters(codServicio, "codservicio")

        Try
            'invocar y ejecutar...
            _dataAccess.execute_proc(_proc, _params)

        Catch ex As Exception
            Throw New System.Exception(ex.Message)
        End Try
    End Sub

    ''' <summary>
    '''  Método de la clase encargada de buscar un registro de las facturas a la DB por medio de un Stored Procedure
    ''' </summary>
    ''' <param name="pidUsuario"></param>
    ''' <param name="pfechaInicio"></param>
    ''' <param name="pfechaFin"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function buscarPorFecha(ByVal pidUsuario As String, ByVal pfechaInicio As Date, ByVal pfechaFin As Date) As List(Of ClsFactura)
        Dim _proc = My.Resources.proc_buscarfacturasporfechas.ToString()
        Dim _drFactura As IDataReader 'instanciar un lector de datos genérico

        Dim listaFacturas As New List(Of ClsFactura) 'declarar e instanciar una lista facturas del tipo ClsFactura

        'instanciar a la clase de ClsParametro e indicar el tamaño del arreglo... (parámetros)
        Dim _params() As CllDataAccess.Parameters
        ReDim _params(2)

        _params(0) = New CllDataAccess.Parameters(pidUsuario, "idusuario") 'asignar para cada posición del arreglo(objeto, nombre)
        _params(1) = New CllDataAccess.Parameters(pfechaInicio, "fechainicio") 'asignar para cada posición del arreglo(objeto, nombre)
        _params(2) = New CllDataAccess.Parameters(pfechaFin, "fechafin") 'asignar para cada posición del arreglo(objeto, nombre)

        Try
            _drFactura = _dataAccess.execute_proc_return(_proc, _params) 'asignar al lector de datos el resultado de la consulta

            While _drFactura.Read() 'Carga a la lista genérica el resultado de la consulta.
                listaFacturas.Add(New ClsFactura(_drFactura.GetString(0), _drFactura.GetString(1), _drFactura.GetString(2), _
                                                 _drFactura.GetDateTime(3), _drFactura.GetDateTime(4), _drFactura.GetDateTime(5), _
                                                 _drFactura.GetString(6), _drFactura.GetString(7), _drFactura.GetDecimal(8), _
                                                 _drFactura.GetDecimal(9)))
            End While

            Return listaFacturas 'Se retorna el resultado
        Catch ex As Exception
            Throw New System.Exception(ex.Message)
        End Try
    End Function

    ''' <summary>
    '''  Método de la clase encargada de buscar un registro de las facturas a la DB por medio de un Stored Procedure
    ''' </summary>
    ''' <param name="pcodGrupo"></param>
    ''' <param name="pfechaInicio"></param>
    ''' <param name="pfechaFin"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function buscarPorFechaPorGrupo(ByVal pcodGrupo As String, ByVal pfechaInicio As Date, ByVal pfechaFin As Date) As List(Of ClsFactura)
        Dim _proc = My.Resources.proc_buscarfacturasgrupoventasporfechas.ToString()
        Dim _drFactura As IDataReader 'instanciar un lector de datos genérico

        Dim listaFacturas As New List(Of ClsFactura) 'declarar e instanciar una lista plan de ventas del tipo ClsFactura

        'instanciar a la clase de ClsParametro e indicar el tamaño del arreglo... (parámetros)
        Dim _params() As CllDataAccess.Parameters
        ReDim _params(2)

        _params(0) = New CllDataAccess.Parameters(pcodGrupo, "codgrupo") 'asignar para cada posición del arreglo(objeto, nombre)
        _params(1) = New CllDataAccess.Parameters(pfechaInicio, "fechainicio") 'asignar para cada posición del arreglo(objeto, nombre)
        _params(2) = New CllDataAccess.Parameters(pfechaFin, "fechafin") 'asignar para cada posición del arreglo(objeto, nombre)

        Try
            _drFactura = _dataAccess.execute_proc_return(_proc, _params) 'asignar al lector de datos el resultado de la consulta

            While _drFactura.Read() 'Carga a la lista genérica el resultado de la consulta.
                listaFacturas.Add(New ClsFactura(_drFactura.GetString(0), _drFactura.GetString(1), _drFactura.GetString(2), _
                                                 _drFactura.GetDateTime(3), _drFactura.GetDateTime(4), _drFactura.GetDateTime(5), _
                                                 _drFactura.GetString(6), _drFactura.GetString(7), _drFactura.GetDecimal(8), _
                                                 _drFactura.GetDecimal(9)))
            End While

            Return listaFacturas 'Se retorna el resultado
        Catch ex As Exception
            Throw New System.Exception(ex.Message)
        End Try
    End Function

End Class