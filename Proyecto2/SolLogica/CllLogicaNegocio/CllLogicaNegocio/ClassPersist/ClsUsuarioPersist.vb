Imports CllDataAccess.ClsDataAccess

Public Class ClsUsuarioPersist

    ''' <summary>
    ''' Método encargado de registrar los datos de un usuario
    ''' </summary>
    ''' <param name="pcedula"></param>
    ''' <param name="pnombre"></param>
    ''' <param name="papellido1"></param>
    ''' <param name="papellido2"></param>
    ''' <param name="pcorreoElectronico"></param>
    ''' <param name="pcontrasenna"></param>
    ''' <param name="prol"></param>
    ''' <param name="pdepartamento"></param>
    ''' <remarks></remarks>
    Public Sub registrar(ByVal pcedula As String, ByVal pnombre As String, ByVal papellido1 As String, ByVal papellido2 As String, _
                         ByVal pcorreoElectronico As String, ByVal pcontrasenna As String, ByVal prol As String, ByVal pdepartamento As String)
        Dim dataAccess As New CllDataAccess.ClsDataAccess
        Dim params() As CllDataAccess.Parameters 'Instancia a la clase de ClsParametro e indicar el tamaño del arreglo... (parámetros)
        ReDim params(7)
        Dim proc = My.Resources.procInsertUsuario.ToString() 'Busca de las propiedades del proyecto el nombre del StoreProcedure

        'Se asigna para cada posición del arreglo(objeto, nombre)
        params(0) = New CllDataAccess.Parameters(pcedula, "cedula")
        params(1) = New CllDataAccess.Parameters(pnombre, "nombre")
        params(2) = New CllDataAccess.Parameters(papellido1, "apellido1")
        params(3) = New CllDataAccess.Parameters(papellido2, "apellido2")
        params(4) = New CllDataAccess.Parameters(pcorreoElectronico, "correo")
        params(5) = New CllDataAccess.Parameters(pcontrasenna, "contrasenna")
        params(6) = New CllDataAccess.Parameters(prol, "rol")
        params(7) = New CllDataAccess.Parameters(pdepartamento, "coddepartamento")

        Try
            'Invocar y ejecutar...
            dataAccess.execute_proc(proc, params)
        Catch ex As Exception
            Throw New System.Exception(ex.Message)
        End Try
    End Sub

    Public Function buscarVendedoresDispGrupo(ByVal codGrupo As String) As List(Of ClsUsuario)
        Dim _proc = My.Resources.proc_buscarvendedoresdispparagrupo.ToString()
        Dim _drUsuario As IDataReader 'instanciar un lector de datos genérico
        Dim dataAccess As New CllDataAccess.ClsDataAccess()

        Dim _listaGenerica As New List(Of ClsUsuario) 'declarar e instanciar una lista genérica del tipo ClsServicio

        'instanciar a la clase de ClsParametro e indicar el tamaño del arreglo... (parámetros)
        Dim _params() As CllDataAccess.Parameters
        ReDim _params(0)

        _params(0) = New CllDataAccess.Parameters(codGrupo, "codgrupo") 'asignar para cada posición del arreglo(objeto, nombre)

        Try
            _drUsuario = dataAccess.execute_proc_return(_proc, _params) 'asignar al lector de datos el resultado de la consulta

            While _drUsuario.Read()
                _listaGenerica.Add(New ClsUsuario(CStr(_drUsuario.Item(0)), CStr(_drUsuario.Item(1)), CStr(_drUsuario.Item(2)), CStr(_drUsuario.Item(3)), CStr(_drUsuario.Item(4))))
            End While


            Return _listaGenerica 'retornar el resultado

        Catch ex As Exception
            Throw New Exception("Error en la persistencia de Servicio... " & ex.Message)
        End Try
    End Function

    ''' <summary>
    ''' Método encargado de modificar los datod de un usuario seleccionado
    ''' </summary>
    ''' <param name="pcedula"></param>
    ''' <param name="pnombre"></param>
    ''' <param name="papellido1"></param>
    ''' <param name="papellido2"></param>
    ''' <param name="pcorreoElectronico"></param>
    ''' <param name="prol"></param>
    ''' <param name="pdepartamento"></param>
    ''' <remarks></remarks>
    Public Sub modificar(ByVal pcedula As String, ByVal pnombre As String, ByVal papellido1 As String, ByVal papellido2 As String, _
                         ByVal pcorreoElectronico As String, ByVal prol As String, ByVal pdepartamento As String)
        Dim dataAccess As New CllDataAccess.ClsDataAccess
        Dim params() As CllDataAccess.Parameters 'Instancia a la clase de ClsParametro e indicar el tamaño del arreglo... (parámetros)
        ReDim params(6)
        Dim proc = My.Resources.procUpdateUsuario.ToString() 'Busca de las propiedades del proyecto el nombre del StoreProcedure

        'Se asigna para cada posición del arreglo(objeto, nombre)
        params(0) = New CllDataAccess.Parameters(pcedula, "cedula")
        params(1) = New CllDataAccess.Parameters(pnombre, "nombre")
        params(2) = New CllDataAccess.Parameters(papellido1, "apellido1")
        params(3) = New CllDataAccess.Parameters(papellido2, "apellido2")
        params(4) = New CllDataAccess.Parameters(pcorreoElectronico, "correo")
        params(5) = New CllDataAccess.Parameters(prol, "rol")
        params(6) = New CllDataAccess.Parameters(pdepartamento, "coddepartamento")

        Try
            'Invocar y ejecutar...
            dataAccess.execute_proc(proc, params)
        Catch ex As Exception
            Throw New System.Exception(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Función encargada de obtener un usuario por su identificación
    ''' </summary>
    ''' <param name="pcedula"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function buscarPorId(ByVal pcedula) As ClsUsuario

        Dim drUsuario As IDataReader
        Dim dataAccess As New CllDataAccess.ClsDataAccess
        Dim objUsuario As New ClsUsuario()
        Dim params() As CllDataAccess.Parameters
        ReDim params(0)
        Dim proc = My.Resources.proc_buscarusuarioid.ToString() 'Busca de las propiedades del proyecto el nombre del StoreProcedure

        params(0) = New CllDataAccess.Parameters(pcedula, "cedula")

        Try
            drUsuario = dataAccess.execute_proc_return(proc, params) 'Invocar y ejecutar...

            While drUsuario.Read() 'Carga a la lista genérica el resultado de la consulta.
                objUsuario = New ClsUsuario(drUsuario.GetString(0), drUsuario.GetString(1), drUsuario.GetString(2), drUsuario.GetString(3), drUsuario.GetString(4), drUsuario.GetString(5), drUsuario.GetString(6), drUsuario.GetString(7))
            End While

            Return objUsuario 'Se retorna el resultado
        Catch ex As Exception
            Throw New System.Exception(ex.Message)
        End Try
    End Function

    ''' <summary>
    ''' Función encargada de obtener un usuario por su identificación
    ''' </summary>
    ''' <param name="pcedula"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function buscarXId(ByVal pcedula) As List(Of ClsUsuario)
        Dim listaUsuarios As New List(Of ClsUsuario)
        Dim drUsuario As IDataReader
        Dim dataAccess As New CllDataAccess.ClsDataAccess
        Dim objUsuario As New ClsUsuario()
        Dim params() As CllDataAccess.Parameters
        ReDim params(0)
        Dim proc = My.Resources.procSelectUsuarioId.ToString() 'Busca de las propiedades del proyecto el nombre del StoreProcedure

        params(0) = New CllDataAccess.Parameters(pcedula, "cedula")

        Try
            drUsuario = dataAccess.execute_proc_return(proc, params) 'Invocar y ejecutar...
            While drUsuario.Read() 'Carga a la lista genérica el resultado de la consulta.
                listaUsuarios.Add(New ClsUsuario(drUsuario.GetString(0), drUsuario.GetString(1), drUsuario.GetString(2), drUsuario.GetString(3), drUsuario.GetString(4), "", drUsuario.GetString(5), drUsuario.GetString(6), drUsuario.GetString(7)))
            End While

            Return listaUsuarios 'Se retorna el resultado
        Catch ex As Exception
            Throw New System.Exception(ex.Message)
        End Try
    End Function

    ''' <summary>
    ''' Función encargada de obtener uno o una lista de usuarios con la aproximación del nombre recibido por parámetro
    ''' </summary>
    ''' <param name="pnombre"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function buscarPorNombre(ByVal pnombre As String) As List(Of ClsUsuario)
        Dim drUsuario As IDataReader
        Dim dataAccess As New CllDataAccess.ClsDataAccess
        Dim listaUsuarios As New List(Of ClsUsuario)
        Dim params() As CllDataAccess.Parameters
        ReDim params(0)
        Dim proc = My.Resources.procSelectUsuarioNombre.ToString() 'Busca de las propiedades del proyecto el nombre del StoreProcedure

        params(0) = New CllDataAccess.Parameters(pnombre, "nombre")

        Try
            drUsuario = dataAccess.execute_proc_return(proc, params) 'Invocar y ejecutar...
            While drUsuario.Read() 'Carga a la lista genérica el resultado de la consulta.
                listaUsuarios.Add(New ClsUsuario(drUsuario.GetString(0), drUsuario.GetString(1), drUsuario.GetString(2), drUsuario.GetString(3), drUsuario.GetString(4), "", drUsuario.GetString(5), drUsuario.GetString(6), drUsuario.GetString(7)))
            End While

            Return listaUsuarios 'Se retorna el resultado
        Catch ex As Exception
            Throw New System.Exception(ex.Message)
        End Try
    End Function

    Public Function buscarPorCorreoYContrasenna(ByVal pcorreo As String, ByVal pcontrasenna As String) As ClsUsuario

        Dim _proc = My.Resources.proc_buscarusuarioporcorreoycontrasenna.ToString()
        Dim drUsuario As IDataReader
        Dim dataAccess As New CllDataAccess.ClsDataAccess
        Dim objUsuario As ClsUsuario
        Dim params() As CllDataAccess.Parameters
        ReDim params(1)

        params(0) = New CllDataAccess.Parameters(pcorreo, "correo")
        params(1) = New CllDataAccess.Parameters(pcontrasenna, "contrasenna")

        Try
            drUsuario = dataAccess.execute_proc_return(_proc, params) 'Invocar y ejecutar...
            If drUsuario.Read() Then 'Carga a la lista genérica el resultado de la consulta.
                objUsuario = New ClsUsuario(drUsuario.GetString(0), drUsuario.GetString(1), _
                                            drUsuario.GetString(2), drUsuario.GetString(3), _
                                            drUsuario.GetString(4), drUsuario.GetString(5), _
                                            drUsuario.GetString(6), drUsuario.GetString(7))
            End If

            Return objUsuario 'Se retorna el resultado
        Catch ex As Exception
            Throw New System.Exception(ex.Message)
        End Try
    End Function

    Public Function buscarPorGrupoDeVentas(ByVal pcodigo As String) As List(Of ClsUsuario)

        Dim _proc = My.Resources.proc_buscarvendedoresdegrupoventas.ToString() 'instanciar variable con el nombre del sp a ejecutar.
        Dim drUsuario As IDataReader
        Dim dataAccess As New CllDataAccess.ClsDataAccess
        Dim listaUsuarios As New List(Of ClsUsuario)
        Dim params() As CllDataAccess.Parameters
        ReDim params(0)

        params(0) = New CllDataAccess.Parameters(pcodigo, "codGrupo")

        Try
            drUsuario = dataAccess.execute_proc_return(_proc, params) 'Invocar y ejecutar...
            While drUsuario.Read() 'Carga a la lista genérica el resultado de la consulta.
                listaUsuarios.Add(New ClsUsuario(drUsuario.GetString(0), drUsuario.GetString(1), drUsuario.GetString(2), _
                                                 drUsuario.GetString(3), drUsuario.GetString(4), drUsuario.GetString(5), _
                                                 drUsuario.GetString(6), drUsuario.GetString(7)))
            End While

            Return listaUsuarios 'Se retorna el resultado
        Catch ex As Exception
            Throw New System.Exception(ex.Message)
        End Try
    End Function

    ''' <summary>
    ''' Método encargado de eliminar un usuario seleccionado
    ''' </summary>
    ''' <param name="pcedula"></param>
    ''' <remarks></remarks>
    Public Sub eliminar(ByVal pcedula As String)
        Dim dataAccess As New CllDataAccess.ClsDataAccess()
        Dim params() As CllDataAccess.Parameters
        ReDim params(0)
        Dim proc = My.Resources.procDeleteCliente.ToString() 'Busca de las propiedades del proyecto el nombre del StoreProcedure

        params(0) = New CllDataAccess.Parameters(pcedula, "cedula")

        Try
            dataAccess.execute_proc(proc, params)
        Catch ex As Exception
            Throw New System.Exception(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Método encargado de cambiar la contraseña de un usuario seleccionado
    ''' </summary>
    ''' <param name="pcedula"></param>
    ''' <param name="pcontrasenna"></param>
    ''' <remarks></remarks>
    Public Sub cambiarContrasenna(ByVal pcedula As String, ByVal pcontrasenna As String)
        Dim dataAccess As New CllDataAccess.ClsDataAccess()
        Dim params() As CllDataAccess.Parameters
        ReDim params(1)
        Dim proc = My.Resources.procCambiarContrasenna.ToString() 'Busca de las propiedades del proyecto el nombre del StoreProcedure

        params(0) = New CllDataAccess.Parameters(pcedula, "cedula")
        params(1) = New CllDataAccess.Parameters(pcontrasenna, "contrasenna")

        Try
            dataAccess.execute_proc(proc, params)
        Catch ex As Exception
            Throw New System.Exception(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Método de la clase encargada de buscar todos los clientes en la DB
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function listarVendedores() As List(Of ClsUsuario)
        Dim _proc = My.Resources.proc_listarvendedores.ToString()
        Dim dataAccess As New CllDataAccess.ClsDataAccess()
        Dim _drUsuario As IDataReader 'instanciar un lector de datos genérico

        Dim _listaUsuario As New List(Of ClsUsuario) 'declarar e instanciar una lista genérica del tipo ClsCliente

        Try
            _drUsuario = dataAccess.ExecuteSQL(_proc) 'asignar al lector de datos el resultado de la consulta

            While _drUsuario.Read()
                _listaUsuario.Add(New ClsUsuario(_drUsuario.GetString(0), _drUsuario.GetString(1), _drUsuario.GetString(2), _drUsuario.GetString(3), _drUsuario.GetString(4), _drUsuario.GetString(5), _drUsuario.GetString(6), _drUsuario.GetString(7)))
            End While

            Return _listaUsuario 'retornar el resultado

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    ''' <summary>
    ''' Método de la clase encargada de listar todos los vendedores master y gg disponibles en la DB
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function listarmastersgerentesdisponibles(ByVal ppro As String) As List(Of ClsUsuario)
        'instanciar un lector de datos genérico
        Dim _drUsuario As IDataReader
        Dim _dataAccess As New CllDataAccess.ClsDataAccess()
        'declarar e instanciar una lista genérica del tipo ClsUsuario
        Dim _listaGenerica As New List(Of ClsUsuario)

        Try
            'asignar al lector de datos el resultado de la consulta
            _drUsuario = _dataAccess.ExecuteSQL(ppro)

            'cargar a la lista genérica el resultado de la consulta.
            While _drUsuario.Read()
                _listaGenerica.Add(New ClsUsuario(CStr(_drUsuario.Item(0)), CStr(_drUsuario.Item(1)), CStr(_drUsuario.Item(2)), CStr(_drUsuario.Item(3)), CStr(_drUsuario.Item(4))))
            End While

            'retornar el resultado
            Return _listaGenerica

        Catch ex As Exception
            Throw New Exception("Error en la persistencia de permiso... " & ex.Message)
        End Try
    End Function

    ''' <summary>
    ''' Función encargada de listar todos los usuarios registrados en el sistema
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function listar() As List(Of ClsUsuario)
        Dim drUsuario As IDataReader
        Dim listaUsuarios As New List(Of ClsUsuario)
        Dim dataAccess = New CllDataAccess.ClsDataAccess()
        Dim proc = My.Resources.procListarUsuarios.ToString() 'Busca de las propiedades del proyecto el nombre del StoreProcedure

        Try
            drUsuario = dataAccess.execute_proc_return(proc)
            While drUsuario.Read()
                listaUsuarios.Add(New ClsUsuario(drUsuario.GetString(0), drUsuario.GetString(1), drUsuario.GetString(2), drUsuario.GetString(3), drUsuario.GetString(4), "", drUsuario.GetString(5), drUsuario.GetString(6), drUsuario.GetString(7)))
            End While

            Return listaUsuarios
        Catch ex As Exception
            Throw New System.Exception(ex.Message)
        End Try
    End Function

End Class
