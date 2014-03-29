Public Class ClsCastCadenaComision

    Private _codComision As Int32
    Private _tipoComision As String
    Private _fechaEmision As Date
    Private _fechaInicial As Date
    Private _fechaFinal As Date
    Private _fechaCancelacion As Date
    Private _porcentajeComision As Decimal
    Private _montoMeta As Decimal
    Private _montoAlcanzado As Decimal
    Private _cantMeta As Decimal
    Private _cantAlcanzada As Decimal
    Private _montoPagado As Decimal
    Private _estado As String
    Private _idUsuario As String
    Private _codGrupo As String
    Private _periodoCancelacion As String

    Public Property codigo() As Int32
        Get
            Return _codComision
        End Get
        Set(ByVal value As Int32)
            _codComision = value
        End Set
    End Property

    Public Property tipoComision() As String
        Get
            Return _tipoComision
        End Get
        Set(ByVal value As String)
            _tipoComision = value
        End Set
    End Property

    Public Property fechaEmision() As Date
        Get
            Return _fechaEmision
        End Get
        Set(ByVal value As Date)
            _fechaEmision = value
        End Set
    End Property

    Public Property fechaInicial() As Date
        Get
            Return _fechaInicial
        End Get
        Set(ByVal value As Date)
            _fechaInicial = value
        End Set
    End Property

    Public Property fechaFinal() As Date
        Get
            Return _fechaFinal
        End Get
        Set(ByVal value As Date)
            _fechaFinal = value
        End Set
    End Property

    Public Property fechaCancelacion() As Date
        Get
            Return _fechaCancelacion
        End Get
        Set(ByVal value As Date)
            _fechaCancelacion = value
        End Set
    End Property

    Public Property porcentajeComision() As Decimal
        Get
            Return _porcentajeComision
        End Get
        Set(ByVal value As Decimal)
            _porcentajeComision = value
        End Set
    End Property

    Public Property montoMeta() As Decimal
        Get
            Return _montoMeta
        End Get
        Set(ByVal value As Decimal)
            _montoMeta = value
        End Set
    End Property

    Public Property montoAlcanzado() As Decimal
        Get
            Return _montoAlcanzado
        End Get
        Set(ByVal value As Decimal)
            _montoAlcanzado = value
        End Set
    End Property

    Public Property cantidadMeta() As Decimal
        Get
            Return _cantMeta
        End Get
        Set(ByVal value As Decimal)
            _cantMeta = value
        End Set
    End Property

    Public Property cantidadAlcanzada() As Decimal
        Get
            Return _cantAlcanzada
        End Get
        Set(ByVal value As Decimal)
            _cantAlcanzada = value
        End Set
    End Property

    Public Property montoPagado() As Decimal
        Get
            Return _montoPagado
        End Get
        Set(ByVal value As Decimal)
            _montoPagado = value
        End Set
    End Property

    Public Property estado() As String
        Get
            Return _estado
        End Get
        Set(ByVal value As String)
            _estado = value
        End Set
    End Property

    Public Property idUsuario() As String
        Get
            Return _idUsuario
        End Get
        Set(ByVal value As String)
            _idUsuario = value
        End Set
    End Property

    Public Property codGrupo() As String
        Get
            Return _codGrupo
        End Get
        Set(ByVal value As String)
            _codGrupo = value
        End Set
    End Property

    Public Property periodoCancelacion() As String
        Get
            Return _periodoCancelacion
        End Get
        Set(ByVal value As String)
            _periodoCancelacion = value
        End Set
    End Property

    Sub New()

    End Sub

    Sub New(ByVal pcodComision As Int32, ByVal ptipoComision As String, ByVal pfechaEmision As Date, ByVal pfechaInicial As Date, _
            ByVal pfechaFinal As Date, ByVal pfechaCancelacion As Date, ByVal pporcentajeComision As Decimal, ByVal pmontoMeta As Decimal, _
             ByVal pmontoAlcanzado As Decimal, ByVal pcantMeta As Decimal, ByVal pcantAlcanzada As Decimal, ByVal pmontoPagado As Decimal, _
             ByVal pestado As String, ByVal pidUsuario As String, ByVal pcodGrupo As String, ByVal pperiodoCancelacion As String)

        _codComision = pcodComision
        _tipoComision = ptipoComision
        _fechaEmision = pfechaEmision
        _fechaInicial = pfechaInicial
        _fechaFinal = pfechaFinal
        _fechaCancelacion = pfechaCancelacion
        _porcentajeComision = pporcentajeComision
        _montoMeta = _montoMeta
        _montoAlcanzado = pmontoAlcanzado
        _cantMeta = pcantMeta
        _cantAlcanzada = pcantAlcanzada
        _montoPagado = pmontoPagado
        _estado = pestado
        _idUsuario = pidUsuario
        _codGrupo = pcodGrupo
        _periodoCancelacion = pperiodoCancelacion
    End Sub

End Class
