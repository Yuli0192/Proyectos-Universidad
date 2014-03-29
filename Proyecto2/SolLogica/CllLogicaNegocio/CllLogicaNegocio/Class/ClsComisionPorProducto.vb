Public Class ClsComisionPorProducto
#Region "atributos de la clase ClsComisionPorProducto"
    Private _nombreServicio As String
    Private _rol As String
    Private _comisionColones As Double
    Private _comisionDolares As Double

#End Region

#Region "propiedades de la clase ClsComisionPorProducto"
    Public Property nombreServicio() As String
        Get
            Return _nombreServicio
        End Get
        Set(ByVal value As String)
            _nombreServicio = value
        End Set
    End Property

    Public Property rol() As String
        Get
            Return _rol
        End Get
        Set(ByVal value As String)
            _rol = value
        End Set
    End Property

    Public Property comisionColones() As String
        Get
            Return _comisionColones
        End Get
        Set(ByVal value As String)
            _comisionColones = value
        End Set
    End Property

    Public Property comisionDolares() As String
        Get
            Return _comisionDolares
        End Get
        Set(ByVal value As String)
            _comisionDolares = value
        End Set
    End Property
#End Region

#Region "constructor de la clase ClsComisionPorProducto"

    ''' <summary>
    ''' constructor vacío
    ''' </summary>
    ''' <remarks></remarks>
    Sub New()
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="pnombreServicio"></param>
    ''' <param name="prol"></param>
    ''' <param name="pcomisionColones"></param>
    ''' <param name="pcomisionDolares"></param>
    ''' <remarks></remarks>
    Sub New(ByVal pnombreServicio As String, ByVal prol As String, ByVal pcomisionColones As Double, ByVal pcomisionDolares As Double)
        _nombreServicio = pnombreServicio
        _rol = prol
        _comisionColones = pcomisionColones
        _comisionDolares = pcomisionDolares

    End Sub
#End Region

End Class
