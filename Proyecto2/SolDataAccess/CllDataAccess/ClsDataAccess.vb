'librerias requeridas
Imports System.Data.SqlClient
Imports System.Configuration.ConfigurationManager
Public Class ClsDataAccess
#Region "atributos privados de la clase"
    Private _cadena As String = ""
#End Region

#Region "propiedad pública de la clase"
    Public ReadOnly Property Cadena() As String
        Get
            'Retorna la cadena de conexión
            _cadena = My.Settings.te.ToString()
            Return _cadena
        End Get
    End Property
#End Region

    ''' <summary>
    ''' Método de la clase que ejecuta una inserción invocando un Strored Procedure
    ''' </summary>
    ''' <param name="pproc"></param>
    ''' <param name="pParameters"></param>
    ''' <remarks></remarks>
    Public Sub execute_proc(ByVal pproc As String, ByVal ParamArray pParameters() As Parameters)
        Dim _cmd As SqlCommand
        Dim _nombre As String

        _cmd = New SqlCommand()
        _cmd.Connection = Me.GetConnection()

        'transformar la colección de parámetros en SqlParameter...
        For Each _element As Parameters In pParameters
            _nombre = "@" & _element.Nombre
            _cmd.Parameters.AddWithValue(_nombre, _element.Dato)
        Next

        Try
            'se indica que se va a ejecutar un store procedure...
            _cmd.CommandType = CommandType.StoredProcedure

            'se asigna el usp a ejecutar
            _cmd.CommandText = pproc

            'se abre la conexion...
            _cmd.Connection.Open()

            'ejecución del comando...
            _cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception("Error en la consulta a DB... " & ex.Message)
        Finally
            'cierre de la conexion...
            _cmd.Connection.Close()
        End Try
    End Sub

    ''' <summary>
    ''' Método encargado en retornar una conexión a la DB
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetConnection() As IDbConnection
        Return New SqlConnection(Cadena)
    End Function
    ''' <summary>
    ''' Método de la clase, encargada de ejecutar un comando tipo SQL sin valor de retorno explícito
    ''' </summary>
    ''' <param name="pSQL">Consulta (Query) SQL a la DB</param>
    ''' <param name="parameters">Colección de parámetros requeridos</param>
    ''' <remarks></remarks>
    Public Sub ExecuteSQL(ByVal pSQL As String, ByVal ParamArray parameters() As Parameters)
        'declarar una variable tipo SqlCommand
        Dim cmd As SqlCommand

        'declarar una variable tipo clase Parameters
        Dim objParameter As Parameters

        'declarar una variable tipo String
        Dim nombre As String

        'inicializar la variable SqlCommand
        cmd = New SqlCommand

        'asignar y obtener una conexión
        cmd.Connection = GetConnection()

        'recorrer la colección de parámetros
        For Each objParameter In parameters
            'transformar el nombre para el servidor
            nombre = "@" & objParameter.Nombre
            'agregar a la colección de parámetros del comando SQL
            cmd.Parameters.AddWithValue(nombre, objParameter.Dato)
            'acomodar los valores requeridos
            pSQL = pSQL.Replace(objParameter.Nombre, nombre)
        Next

        'asignar el texto de la consulta
        cmd.CommandText = pSQL

        'abrir la conexión a la DB
        cmd.Connection.Open()

        'ejecutar la consulta
        cmd.ExecuteNonQuery()

        'cerrar la conexión
        cmd.Connection.Close()

        '*** L@s estudiantes DEBEN implementar el manejo de excepción ***

    End Sub

    ''' <summary>
    ''' Método de la clase, encargada de ejecutar un comando tipo SQL con valor de retorno explícito
    ''' </summary>
    ''' <param name="pSQL"></param>
    ''' <param name="parameters"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ExecuteSQLReturn(ByVal pSQL As String, ByVal ParamArray parameters() As Parameters) As IDataReader
        Dim cmd As SqlCommand
        Dim objParameter As Parameters
        Dim nombre As String

        cmd = New SqlCommand
        cmd.Connection = GetConnection()

        If Not parameters Is Nothing Then
            For Each objParameter In parameters
                nombre = String.Format("@{0}", objParameter.Nombre)
                cmd.Parameters.AddWithValue(nombre, objParameter.Dato)
                pSQL = pSQL.Replace(objParameter.Nombre, nombre)
            Next
        End If
        Try
            cmd.CommandText = pSQL
            If cmd.Connection.State = ConnectionState.Closed Then
                cmd.Connection.Open()
            End If
        Catch ex As Exception
        End Try
        Return cmd.ExecuteReader
    End Function

    'Retorna un IDataReader
    Public Function ExecuteSQL(ByVal pSQL As String) As IDataReader
        Try
            Dim _cmd As SqlCommand
            _cmd = New SqlCommand()
            _cmd.Connection = Me.GetConnection()
            _cmd.CommandText = pSQL

            If _cmd.Connection.State = ConnectionState.Closed Then
                _cmd.Connection.Open()
            End If

            Return _cmd.ExecuteReader()

        Catch ex As Exception
            Throw New Exception("Error en la consulta a DB... " & ex.Message)
        End Try

    End Function

    'Retorna un dataset
    Public Function ExecuteSQL(ByVal pSQL As String, ByVal pTabla As String) As DataSet
        Dim adp As SqlDataAdapter
        Dim ds As New DataSet()
        adp = New SqlDataAdapter(pSQL, CType(GetConnection(), SqlConnection))
        adp.Fill(ds, pTabla)
        Return ds
    End Function

    Public Function execute_proc_return(ByVal pproc As String, ByVal ParamArray pParameters() As Parameters) As IDataReader
        Dim _cmd As SqlCommand
        Dim _nombre As String
        _cmd = New SqlCommand()
        _cmd.Connection = Me.GetConnection()

        For Each _element As Parameters In pParameters 'transformar la colección de parámetros en SqlParameter...
            _nombre = "@" & _element.Nombre
            _cmd.Parameters.AddWithValue(_nombre, _element.Dato)
        Next

        Try
            _cmd.CommandType = CommandType.StoredProcedure 'se indica que se va a ejecutar un store procedure...
            _cmd.CommandText = pproc 'se asigna el usp a ejecutar
            _cmd.Connection.Open() 'se abre la conexion...
            _cmd.ExecuteNonQuery() 'ejecución del comando...
        Catch ex As Exception
            Throw New Exception("Error en la consulta a DB... " & ex.Message)
        End Try
        Return _cmd.ExecuteReader()
    End Function

End Class


