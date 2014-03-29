'libreria requerida
Imports CllDataAccess.ClsDataAccess
Public Class ClsClientePersist
    Dim _dataAccess As New CllDataAccess.ClsDataAccess

    ''' <summary>
    ''' Método de la clase encargada de insertar un nuevo registro de cliente a la DB por medio de un Stored Procedure
    ''' </summary>
    ''' <param name="pidCliente"></param>
    ''' <param name="pnombre"></param>
    ''' <param name="ptelefono"></param>
    ''' <param name="pcorreoCliente"></param>
    ''' <param name="pcontacto"></param>
    ''' <param name="pdireccion"></param>
    ''' <remarks></remarks>
    Public Sub registrar(ByVal pidCliente As String, ByVal pnombre As String, ByVal ptelefono As String, _
                         ByVal pcorreoCliente As String, ByVal pcontacto As String, ByVal pdireccion As String)

        Dim _proc = My.Resources.proc_insertcliente.ToString()

        'instanciar a la clase de ClsParametro e indicar el tamaño del arreglo... (parámetros)
        Dim _params() As CllDataAccess.Parameters
        ReDim _params(5)

        'asignar para cada posición del arreglo(objeto, nombre)
        _params(0) = New CllDataAccess.Parameters(pidCliente, "id")
        _params(1) = New CllDataAccess.Parameters(pnombre, "nombre")
        _params(2) = New CllDataAccess.Parameters(ptelefono, "telefono")
        _params(3) = New CllDataAccess.Parameters(pcorreoCliente, "correo")
        _params(4) = New CllDataAccess.Parameters(pcontacto, "contacto")
        _params(5) = New CllDataAccess.Parameters(pdireccion, "direccion")

        Try
            _dataAccess.execute_proc(_proc, _params) 'invocar y ejecutar...
        Catch ex As Exception
            Throw New System.Exception(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Método de la clase encargada de asignar un nuevo cliente a un usuario a la DB por medio de un Stored Procedure
    ''' </summary>
    ''' <param name="pidCliente"></param>
    ''' <param name="pidUsuario"></param>
    ''' <remarks></remarks>
    Public Sub asignarClienteUsuario(ByVal pidCliente As String, ByVal pidUsuario As String)
        Dim _proc = My.Resources.proc_asignarclienteusuario.ToString()
        'instanciar a la clase de ClsParametro e indicar el tamaño del arreglo... (parámetros)
        Dim _params() As CllDataAccess.Parameters
        ReDim _params(1)

        'asignar para cada posición del arreglo(objeto, nombre)
        _params(0) = New CllDataAccess.Parameters(pidCliente, "idcliente")
        _params(1) = New CllDataAccess.Parameters(pidUsuario, "idusuario")

        Try
            _dataAccess.execute_proc(_proc, _params) 'invocar y ejecutar...

        Catch ex As Exception
            Throw New System.Exception(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Método de la clase encargada de buscar un registro de cliente a la DB por medio de un Stored Procedure
    ''' </summary>
    ''' <param name="pidCliente"></param>
    ''' <remarks></remarks>
    Public Function buscarPorId(ByVal pidCliente As String) As ClsCliente

        Dim _proc = My.Resources.proc_selectclienteid.ToString()
        Dim _drCliente As IDataReader 'instanciar un lector de datos genérico
        Dim _cliente As ClsCliente = Nothing 'declarar e instanciar una atributo del tipo ClsCliente

        'instanciar a la clase de ClsParametro e indicar el tamaño del arreglo... (parámetros)
        Dim _params() As CllDataAccess.Parameters
        ReDim _params(0)

        _params(0) = New CllDataAccess.Parameters(pidCliente, "id") 'asignar para cada posición del arreglo(objeto, nombre)

        Try
            'invocar y ejecutar...
            _drCliente = _dataAccess.execute_proc_return(_proc, _params)
            'cargar a la lista genérica el resultado de la consulta.
            While _drCliente.Read()

                _cliente = New ClsCliente(_drCliente.GetString(0), _drCliente.GetString(1), _drCliente.GetString(2), _drCliente.GetString(3), _drCliente.GetString(4), _drCliente.GetString(5))

            End While

            Return _cliente 'retornar el resultado

        Catch ex As Exception
            Throw New System.Exception(ex.Message)
        End Try

    End Function

    ''' <summary>
    '''  Método de la clase encargada de buscar un registro de cliente a la DB por medio de un Stored Procedure
    ''' </summary>
    ''' <param name="pnombre"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function buscarPorNombre(ByVal pnombre As String) As List(Of ClsCliente)

        Dim _proc = My.Resources.proc_selectclientenombre.ToString()
        Dim _drCliente As IDataReader 'instanciar un lector de datos genérico

        Dim _listaGenerica As New List(Of ClsCliente) 'declarar e instanciar una lista genérica del tipo ClsCliente

        'instanciar a la clase de ClsParametro e indicar el tamaño del arreglo... (parámetros)
        Dim _params() As CllDataAccess.Parameters
        ReDim _params(0)

        _params(0) = New CllDataAccess.Parameters(pnombre, "nombre") 'asignar para cada posición del arreglo(objeto, nombre)

        Try
            _drCliente = _dataAccess.execute_proc_return(_proc, _params) 'asignar al lector de datos el resultado de la consulta

            While _drCliente.Read()
                _listaGenerica.Add(New ClsCliente(_drCliente.GetString(0), _drCliente.GetString(1), _drCliente.GetString(2), _drCliente.GetString(3), _drCliente.GetString(4), _drCliente.GetString(5))) 'cargar a la lista genérica el resultado de la consulta.
            End While


            Return _listaGenerica 'retornar el resultado

        Catch ex As Exception
            Throw New Exception("Error en la persistencia de Cliente... " & ex.Message)
        End Try
    End Function


    ''' <summary>
    ''' Método de la clase encargada de buscar todos los clientes en la DB
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function listar() As List(Of ClsCliente)
        Dim _proc = My.Resources.proc_listarclientes.ToString()

        Dim _drCliente As IDataReader 'instanciar un lector de datos genérico

        Dim _listaGenerica As New List(Of ClsCliente) 'declarar e instanciar una lista genérica del tipo ClsCliente

        Try
            _drCliente = _dataAccess.ExecuteSQL(_proc) 'asignar al lector de datos el resultado de la consulta

            While _drCliente.Read()
                _listaGenerica.Add(New ClsCliente(_drCliente.GetString(0), _drCliente.GetString(1), _drCliente.GetString(2), _drCliente.GetString(3), _drCliente.GetString(4), _drCliente.GetString(5))) 'cargar a la lista genérica el resultado de la consulta.
            End While

            Return _listaGenerica 'retornar el resultado

        Catch ex As Exception
            Throw New Exception("Error en la persistencia de Cliente... " & ex.Message)
        End Try
    End Function

    ''' <summary>
    ''' Método de la clase encargada de modificar un registro de cliente a la DB por medio de un Stored Procedure
    ''' </summary>
    ''' <param name="pidCliente"></param>
    ''' <param name="pnombre"></param>
    ''' <param name="ptelefono"></param>
    ''' <param name="pcorreoCliente"></param>
    ''' <param name="pcontacto"></param>
    ''' <param name="pdireccion"></param>
    ''' <remarks></remarks>
    Public Sub modificar(ByVal pidCliente As String, ByVal pnombre As String, ByVal ptelefono As String, _
                         ByVal pcorreoCliente As String, ByVal pcontacto As String, ByVal pdireccion As String)

        Dim _proc = My.Resources.proc_updatecliente.ToString()
        Dim _params() As CllDataAccess.Parameters 'instanciar a la clase de ClsParametro e indicar el tamaño del arreglo... (parámetros)
        ReDim _params(5)

        'asignar para cada posición del arreglo(objeto, nombre)
        _params(0) = New CllDataAccess.Parameters(pidCliente, "id")
        _params(1) = New CllDataAccess.Parameters(pnombre, "nombre")
        _params(2) = New CllDataAccess.Parameters(ptelefono, "telefono")
        _params(3) = New CllDataAccess.Parameters(pcorreoCliente, "correo")
        _params(4) = New CllDataAccess.Parameters(pcontacto, "contacto")
        _params(5) = New CllDataAccess.Parameters(pdireccion, "direccion")

        Try
            _dataAccess.execute_proc(_proc, _params) 'invocar y ejecutar...

        Catch ex As Exception
            Throw New System.Exception(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Método de la clase encargada de eliminar un registro de cliente a la DB por medio de un Stored Procedure
    ''' </summary>
    ''' <param name="pidCliente"></param>
    ''' <remarks></remarks>
    Public Sub eliminar(ByVal pidCliente As String)
        Dim _proc = My.Resources.proc_deletecliente.ToString()
        'instanciar a la clase de ClsParametro e indicar el tamaño del arreglo... (parámetros)
        Dim _params() As CllDataAccess.Parameters
        ReDim _params(0)

        _params(0) = New CllDataAccess.Parameters(pidCliente, "id") 'asignar para cada posición del arreglo(objeto, nombre)

        Try
            _dataAccess.execute_proc(_proc, _params) 'invocar y ejecutar...

        Catch ex As Exception
            Throw New System.Exception(ex.Message)
        End Try
    End Sub
End Class