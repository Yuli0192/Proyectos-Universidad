Public Class ClsComisionVentasRealizadasPersist
    ''' <summary>
    ''' Se encarga de extraer las comisiones recien calculadas de ventas realizadas
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function listar() As List(Of ClsComisionVentasRealizadas)
        Dim drComision As IDataReader
        Dim listaComisiones As New List(Of ClsComisionVentasRealizadas)
        Dim dataAccess = New CllDataAccess.ClsDataAccess()
        Dim proc = My.Resources.proc_extraerDatosComisionCalculada.ToString() 'Busca de las propiedades del proyecto el nombre del StoreProcedure

        Try
            drComision = dataAccess.execute_proc_return(proc)
            While drComision.Read()
                listaComisiones.Add(New ClsComisionVentasRealizadas(drComision.GetDouble(0), drComision.GetDouble(1), drComision.GetString(2), drComision.GetString(3), drComision.GetString(4), drComision.GetString(5)))
            End While

            Return listaComisiones
        Catch ex As Exception
            Throw New System.Exception(ex.Message)
        End Try
    End Function
End Class
