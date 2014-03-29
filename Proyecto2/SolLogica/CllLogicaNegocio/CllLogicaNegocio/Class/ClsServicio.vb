Public Class ClsServicio

#Region "Atributos"

    Private _cod As String
    Private _nombre As String
    Private _descripcion As String
    Private _precioColones As Decimal
    Private _precioDolares As Decimal
    Private _porcentComisionJuniorColones As Decimal
    Private _porcentComisionJuniorDolares As Decimal
    Private _porcentComisionSeniorColones As Decimal
    Private _porcentComisionSeniorDolares As Decimal
    Private _porcentComisionMasterColones As Decimal
    Private _porcentComisionMasterDolares As Decimal
    Private _cantPlaneada As Decimal

#End Region

#Region "Propiedades"

    Public Property cod() As String
        Get
            Return _cod
        End Get
        Set(ByVal value As String)
            _nombre = value
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

    Public Property descripcion() As String
        Get
            Return _descripcion
        End Get
        Set(ByVal value As String)
            _descripcion = value
        End Set
    End Property

    Public Property precioColones() As Decimal
        Get
            Return _precioColones
        End Get
        Set(ByVal value As Decimal)
            _precioColones = value
        End Set
    End Property

    Public Property precioDolares() As Decimal
        Get
            Return _precioDolares
        End Get
        Set(ByVal value As Decimal)
            _precioDolares = value
        End Set
    End Property

    Public Property porcentComisionJuniorColones() As Decimal
        Get
            Return _porcentComisionJuniorColones
        End Get
        Set(ByVal value As Decimal)
            _porcentComisionJuniorColones = value
        End Set
    End Property

    Public Property porcentComisionJuniorDolares() As Decimal
        Get
            Return _porcentComisionJuniorDolares
        End Get
        Set(ByVal value As Decimal)
            _porcentComisionJuniorDolares = value
        End Set
    End Property

    Public Property porcentComisionSeniorColones() As Decimal
        Get
            Return _porcentComisionSeniorColones
        End Get
        Set(ByVal value As Decimal)
            _porcentComisionSeniorColones = value
        End Set
    End Property

    Public Property porcentComisionSeniorDolares() As Decimal
        Get
            Return _porcentComisionSeniorDolares
        End Get
        Set(ByVal value As Decimal)
            _porcentComisionSeniorDolares = value
        End Set
    End Property

    Public Property porcentComisionMasterColones() As Decimal
        Get
            Return _porcentComisionMasterColones
        End Get
        Set(ByVal value As Decimal)
            _porcentComisionMasterColones = value
        End Set
    End Property

    Public Property porcentComisionMasterDolares() As Decimal
        Get
            Return _porcentComisionMasterDolares
        End Get
        Set(ByVal value As Decimal)
            _porcentComisionMasterDolares = value
        End Set
    End Property

    Public Property ventasPlaneadas() As Decimal
        Get
            Return _cantPlaneada
        End Get
        Set(ByVal value As Decimal)
            _cantPlaneada = value
        End Set
    End Property
#End Region

#Region "Constructor"

    Public Sub New()

    End Sub

    Public Sub New(ByVal pcod As String, ByVal pnombre As String, ByVal pdescripcion As String, ByVal _
                   pprecioColones As Decimal, ByVal pprecioDolares As Decimal, _
                   ByVal pporcentComisionJuniorColones As Decimal, ByVal pporcentComisionJuniorDolares As Decimal, _
                   ByVal pporcentComisionSeniorColones As Decimal, ByVal pporcentComisionSeniorDolares As Decimal, _
                   ByVal pporcentComisionMasterColones As Decimal, ByVal pporcentComisionMasterDolares As Decimal)

        _cod = pcod
        _nombre = pnombre
        _descripcion = pdescripcion
        _precioColones = pprecioColones
        _precioDolares = pprecioDolares
        _porcentComisionJuniorColones = pporcentComisionJuniorColones
        _porcentComisionJuniorDolares = pporcentComisionJuniorDolares
        _porcentComisionSeniorColones = pporcentComisionSeniorColones
        _porcentComisionSeniorDolares = pporcentComisionSeniorDolares
        _porcentComisionMasterColones = pporcentComisionMasterColones
        _porcentComisionMasterDolares = pporcentComisionMasterDolares
    End Sub

    Public Sub New(ByVal pcod As String, ByVal pnombre As String, ByVal pdescripcion As String, _
                   ByVal pprecioColones As Decimal, ByVal pprecioDolares As Decimal, _
                   ByVal pporcentComisionJuniorColones As Decimal, ByVal pporcentComisionJuniorDolares As Decimal, _
                   ByVal pporcentComisionSeniorColones As Decimal, ByVal pporcentComisionSeniorDolares As Decimal, _
                   ByVal pporcentComisionMasterColones As Decimal, ByVal pporcentComisionMasterDolares As Decimal, _
                   ByVal pcantPlaneada As Decimal)

        _cod = pcod
        _nombre = pnombre
        _descripcion = pdescripcion
        _precioColones = pprecioColones
        _precioDolares = pprecioDolares
        _porcentComisionJuniorColones = pporcentComisionJuniorColones
        _porcentComisionJuniorDolares = pporcentComisionJuniorDolares
        _porcentComisionSeniorColones = pporcentComisionSeniorColones
        _porcentComisionSeniorDolares = pporcentComisionSeniorDolares
        _porcentComisionMasterColones = pporcentComisionMasterColones
        _porcentComisionMasterDolares = pporcentComisionMasterDolares
        _cantPlaneada = pcantPlaneada
    End Sub

#End Region


End Class
