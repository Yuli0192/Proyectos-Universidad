'libreria requerida
Imports CllDataAccess.ClsDataAccess

Public Class ClsGrupoDeventaPersist

    Dim _dataAccess As New CllDataAccess.ClsDataAccess

    Public Sub registrar(ByVal pcodigo As String, ByVal pdescripcion As String, ByVal pidEncargado As String, _
                         ByVal pidVendedores As ArrayList, ByVal pidServicios As ArrayList)
        'instanciar variable con el nombre del sp a ejecutar.
        Dim _proc = My.Resources.proc_registrargrupodeventa.ToString()
        'instanciar a la clase de ClsParametro e indicar el tamaño del arreglo... (parámetros)
        Dim _params() As CllDataAccess.Parameters
        ReDim _params(2)

        'asignar para cada posición del arreglo(objeto, nombre)
        _params(0) = New CllDataAccess.Parameters(pcodigo, "codigo")
        _params(1) = New CllDataAccess.Parameters(pdescripcion, "descripcion")
        _params(2) = New CllDataAccess.Parameters(pidEncargado, "idencargado")

        Try
            'invocar y ejecutar...
            _dataAccess.execute_proc(_proc, _params)

            For Each idVendedor In pidVendedores
                agregarVendedorAGrupoDeVenta(pcodigo, idVendedor)
            Next

            For Each idServicio In pidServicios
                agregarServicioAGrupoDeVenta(pcodigo, idServicio)
            Next

        Catch ex As Exception
            Throw New System.Exception(ex.Message)
        End Try
    End Sub

    Public Function buscar(ByVal pcodigo As String) As ClsGrupoDeVenta

        Dim _proc = My.Resources.proc_buscargrupodeventa.ToString()
        'instanciar un lector de datos genérico
        Dim _drGrupo As IDataReader
        'declarar e instanciar una variable del tipo ClsGrupoDeventa
        Dim _grupo As New ClsGrupoDeVenta
        'instanciar a la clase de ClsParametro e indicar el tamaño del arreglo... (parámetros)
        Dim _params() As CllDataAccess.Parameters
        ReDim _params(0)
        'asignar para cada posición del arreglo(objeto, nombre)
        _params(0) = New CllDataAccess.Parameters(pcodigo, "cod")

        Try
            'invocar y ejecutar...
            _drGrupo = _dataAccess.execute_proc_return(_proc, _params)

            While _drGrupo.Read()
                _grupo = New ClsGrupoDeVenta(_drGrupo.GetString(0), _drGrupo.GetString(1), _drGrupo.GetString(2))
            End While
            'retornar el resultado
            Return _grupo

        Catch ex As Exception
            Throw New System.Exception(ex.Message)
        End Try

    End Function

    Public Function listar() As List(Of ClsGrupoDeVenta)

        Dim proc = My.Resources.proc_listargrupos.ToString()
        Dim drGrupo As IDataReader
        Dim listaGrupos As New List(Of ClsGrupoDeVenta)
        Dim dataAccess = New CllDataAccess.ClsDataAccess()

        Try
            drGrupo = dataAccess.ExecuteSQL(proc)
            While drGrupo.Read()
                listaGrupos.Add(New ClsGrupoDeVenta(drGrupo.GetString(0), drGrupo.GetString(1), drGrupo.GetString(2)))
            End While

            Return listaGrupos
        Catch ex As Exception
            Throw New System.Exception(ex.Message)
        End Try
    End Function

    Public Function buscarPorAprox(ByVal pcodGrupo As String) As List(Of ClsGrupoDeVenta)
        Dim _proc = My.Resources.proc_buscargrupodeventaaprox.ToString()
        Dim _drGrupo As IDataReader 'instanciar un lector de datos genérico

        Dim _listaGrupo As New List(Of ClsGrupoDeVenta) 'declarar e instanciar una lista genérica del tipo ClsCliente

        'instanciar a la clase de ClsParametro e indicar el tamaño del arreglo... (parámetros)
        Dim _params() As CllDataAccess.Parameters
        ReDim _params(0)

        _params(0) = New CllDataAccess.Parameters(pcodGrupo, "cod") 'asignar para cada posición del arreglo(objeto, nombre)

        Try
            _drGrupo = _dataAccess.execute_proc_return(_proc, _params) 'asignar al lector de datos el resultado de la consulta

            While _drGrupo.Read()
                _listaGrupo.Add(New ClsGrupoDeVenta(_drGrupo.GetString(0), _drGrupo.GetString(1), _drGrupo.GetString(2)))
            End While


            Return _listaGrupo 'retornar el resultado

        Catch ex As Exception
            Throw New Exception("Error en la persistencia de Grupo de Ventas... " & ex.Message)
        End Try
    End Function

    Public Sub modificar(ByVal pcodigo As String, ByVal pdescripcion As String, ByVal pidEncargado As String)

        Dim _proc = My.Resources.proc_modificargrupodeventa.ToString()
        'instanciar a la clase de ClsParametro e indicar el tamaño del arreglo... (parámetros)
        Dim _params() As CllDataAccess.Parameters
        ReDim _params(2)

        'asignar para cada posición del arreglo(objeto, nombre)
        _params(0) = New CllDataAccess.Parameters(pcodigo, "codigo")
        _params(1) = New CllDataAccess.Parameters(pdescripcion, "descripcion")
        _params(2) = New CllDataAccess.Parameters(pidEncargado, "idencargado")

        Try
            'invocar y ejecutar...
            _dataAccess.execute_proc(_proc, _params)

        Catch ex As Exception
            Throw New System.Exception(ex.Message)
        End Try
    End Sub

    Public Sub eliminar(ByVal pcodigo As String)

        Dim _proc = My.Resources.proc_eliminargrupodeventa.ToString()
        'instanciar a la clase de ClsParametro e indicar el tamaño del arreglo... (parámetros)
        Dim _params() As CllDataAccess.Parameters
        ReDim _params(0)

        'asignar para cada posición del arreglo(objeto, nombre)
        _params(0) = New CllDataAccess.Parameters(pcodigo, "codigo")

        Try
            'invocar y ejecutar...
            _dataAccess.execute_proc(_proc, _params)

        Catch ex As Exception
            Throw New System.Exception(ex.Message)
        End Try
    End Sub

    Public Sub agregarVendedorAGrupoDeVenta(ByVal pcodigo As String, ByVal pidVendedor As String)

        Dim _proc = My.Resources.proc_agregarvendedoragrupodeventa.ToString()
        'instanciar a la clase de ClsParametro e indicar el tamaño del arreglo... (parámetros)
        Dim _params() As CllDataAccess.Parameters
        ReDim _params(1)

        _params(0) = New CllDataAccess.Parameters(pcodigo, "codgrupo")
        _params(1) = New CllDataAccess.Parameters(pidVendedor, "idusuario")

        Try
            'invocar y ejecutar...
            _dataAccess.execute_proc(_proc, _params)

        Catch ex As Exception
            Throw New System.Exception(ex.Message)
        End Try
    End Sub

    Public Sub agregarServicioAGrupoDeVenta(ByVal pcodigo As String, ByVal pidServicio As String)

        Dim _proc = My.Resources.proc_agregarservicioagrupodeventa.ToString()
        'instanciar a la clase de ClsParametro e indicar el tamaño del arreglo... (parámetros)
        Dim _params() As CllDataAccess.Parameters
        ReDim _params(1)

        _params(0) = New CllDataAccess.Parameters(pcodigo, "codgrupo")
        _params(1) = New CllDataAccess.Parameters(pidServicio, "codservicio")

        Try
            'invocar y ejecutar...
            _dataAccess.execute_proc(_proc, _params)

        Catch ex As Exception
            Throw New System.Exception(ex.Message)
        End Try
    End Sub

    Public Sub eliminarVendedorDeGrupoDeVenta(ByVal pcodigo As String, ByVal pidVendedor As String)

        Dim _proc = My.Resources.proc_eliminarvendedordegrupodeventa.ToString()
        'instanciar a la clase de ClsParametro e indicar el tamaño del arreglo... (parámetros)
        Dim _params() As CllDataAccess.Parameters
        ReDim _params(1)

        _params(0) = New CllDataAccess.Parameters(pcodigo, "codgrupo")
        _params(1) = New CllDataAccess.Parameters(pidVendedor, "idusuario")

        Try
            'invocar y ejecutar...
            _dataAccess.execute_proc(_proc, _params)

        Catch ex As Exception
            Throw New System.Exception(ex.Message)
        End Try
    End Sub

    Public Sub eliminarServicioDeGrupoDeVenta(ByVal pcodigo As String, ByVal pidServicio As String)

        Dim _proc = My.Resources.proc_eliminarserviciodegrupodeventa.ToString()
        'instanciar a la clase de ClsParametro e indicar el tamaño del arreglo... (parámetros)
        Dim _params() As CllDataAccess.Parameters
        ReDim _params(1)

        _params(0) = New CllDataAccess.Parameters(pcodigo, "codgrupo")
        _params(1) = New CllDataAccess.Parameters(pidServicio, "codservicio")

        Try
            'invocar y ejecutar...
            _dataAccess.execute_proc(_proc, _params)

        Catch ex As Exception
            Throw New System.Exception(ex.Message)
        End Try
    End Sub
End Class