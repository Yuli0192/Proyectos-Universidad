Public Class ClsCastCadenaFactura

    Private _num As String
    Private _idCliente As String
    Private _idUsuario As String
    Private _fechaFacturacion As Date
    Private _fechaCreacion As Date
    Private _fechaValidez As Date
    Private _moneda As String
    Private _estado As String
    Private _monto As Decimal
    Private _tipoDeCambio As Decimal


    Public Sub New(ByVal pnum As String, ByVal pidCliente As String, ByVal pidUsuario As String, _
                   ByVal pfechaFacturacion As Date, ByVal pfechaCreacion As Date, ByVal pfechaValidez As Date, _
                   ByVal pmoneda As String, ByVal pestado As String, ByVal pmonto As Decimal, ByVal ptipoDeCambio As Decimal)

        _num = pnum
        _idCliente = pidCliente
        _idUsuario = pidUsuario
        _fechaFacturacion = pfechaFacturacion
        _fechaCreacion = pfechaCreacion
        _fechaValidez = pfechaValidez
        _moneda = pmoneda
        _estado = pestado
        _monto = pmonto
        _tipoDeCambio = ptipoDeCambio

    End Sub

    Public Property num()
        Get
            Return _num
        End Get
        Set(ByVal value)
            _num = value
        End Set
    End Property

    Public Property idCliente()
        Get
            Return _idCliente
        End Get
        Set(ByVal value)
            _idCliente = value
        End Set
    End Property

    Public Property idUsuario()
        Get
            Return _idUsuario
        End Get
        Set(ByVal value)
            _idUsuario = value
        End Set
    End Property

    Public Property fechaFacturacion()
        Get
            Return _fechaFacturacion
        End Get
        Set(ByVal value)
            _fechaFacturacion = value
        End Set
    End Property

    Public Property fechaCreacion()
        Get
            Return _fechaCreacion
        End Get
        Set(ByVal value)
            _fechaCreacion = value
        End Set
    End Property

    Public Property fechaValidez()
        Get
            Return _fechaValidez
        End Get
        Set(ByVal value)
            _fechaValidez = value
        End Set
    End Property

    Public Property moneda()
        Get
            Return _moneda
        End Get
        Set(ByVal value)
            _moneda = value
        End Set
    End Property

    Public Property estado()
        Get
            Return _estado
        End Get
        Set(ByVal value)
            _estado = value
        End Set
    End Property

    Public Property monto()
        Get
            Return _monto
        End Get
        Set(ByVal value)
            _monto = value
        End Set
    End Property

    Public Property tipoDeCambio()
        Get
            Return _tipoDeCambio
        End Get
        Set(ByVal value)
            _tipoDeCambio = value
        End Set
    End Property
End Class
