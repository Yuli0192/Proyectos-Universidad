'libreria requerida
Imports CllDataAccess.ClsDataAccess
Public Class ClsComisionPorProductoPersist

    Dim _dataAccess As New CllDataAccess.ClsDataAccess
    
    Public Function calcularComisionPorProductoVendido(ByVal proc As String) As List(Of ClsComisionPorProducto)
        'instanciar un lector de datos genérico
        Dim _drCalculo As IDataReader
        'declarar e instanciar una lista genérica del tipo ClsComisionPorProductos
        Dim _listaGenerica As New List(Of ClsComisionPorProducto)

        Try
            'asignar al lector de datos el resultado de la consulta
            _drCalculo = _dataAccess.execute_proc_return(proc)

            'cargar a la lista genérica el resultado de la consulta.
            While _drCalculo.Read()
                _listaGenerica.Add(New ClsComisionPorProducto(CStr(_drCalculo.Item(0)), CStr(_drCalculo.Item(1)), CStr(_drCalculo.Item(2)), CDbl(_drCalculo.Item(3))))
            End While

            'retornar el resultado
            Return _listaGenerica

        Catch ex As Exception
            Throw New Exception("Error en la persistencia de Comision por producto... " & ex.Message)
        End Try
    End Function
End Class

