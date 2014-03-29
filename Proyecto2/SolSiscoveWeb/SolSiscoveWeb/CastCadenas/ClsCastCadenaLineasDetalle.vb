Public Class ClsCastCadenaLineasDetalle
    Dim _codServicio As String
    Dim _nombre As String
    Dim _cantidad As Int32
    Dim _precio As Decimal

    Public Property codServicio() As String
        Get
            Return _codServicio
        End Get
        Set(ByVal value As String)
            _codServicio = value
        End Set
    End Property

    Public Property nombre() As String
        Get
            Return _nombre
        End Get
        Set(ByVal value As String)
            _nombre = value
        End Set
    End Property

    Public Property cantidad() As Int32
        Get
            Return _cantidad
        End Get
        Set(ByVal value As Int32)
            _cantidad = value
        End Set
    End Property

    Public Property precio() As Decimal
        Get
            Return _precio
        End Get
        Set(ByVal value As Decimal)
            _precio = value
        End Set
    End Property

    ''' <summary>
    ''' constructor con todos los parámetros
    ''' </summary>
    ''' <param name="pcodServicio">Codigo del servicio, tipo String</param>
    ''' <param name="pnombre">Nombre del servicio, tipo String</param>
    ''' <param name="pcantidad">Cantidad del servicio, tipo Int32</param>
    ''' <param name="pprecio">Precio del servicio, tipo date</param>
    ''' <remarks></remarks>
    Sub New(ByVal pcodServicio As String, ByVal pnombre As String, ByVal pcantidad As Int32, ByVal pprecio As Decimal)
        _codServicio = pcodServicio
        _nombre = pnombre
        _cantidad = pcantidad
        _precio = pprecio
    End Sub
End Class


