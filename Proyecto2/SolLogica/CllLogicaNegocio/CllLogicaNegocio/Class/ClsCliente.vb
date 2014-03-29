Public Class ClsCliente

#Region "atributos de la clase clsCliente"
    Private _idCliente As String
    Private _nombre As String
    Private _telefono As String
    Private _correoCliente As String
    Private _contacto As String
    Private _direccion As String
#End Region


#Region "constructor de la clase clsCliente"

    ''' <summary>
    ''' constructor vacío
    ''' </summary>
    ''' <remarks></remarks>
    Sub New()
    End Sub

    ''' <summary>
    ''' constructor con todos los parámetros
    ''' </summary>
    ''' <param name="pidCliente">Id del cliente, tipo String</param>
    ''' <param name="pnombre">Nombre del cliente, tipo String</param>
    ''' <param name="ptelefono">Telefono del cliente, tipo string</param>
    ''' <param name="pcorreoCliente">Correo del cliente, tipo string</param>
    ''' <param name="pcontacto">Contacto del cliente, tipo string</param>
    ''' <param name="pdireccion">Direccion del cliente, tipo string</param>
    ''' <remarks></remarks>
    Sub New(ByVal pidCliente As String, ByVal pnombre As String, ByVal ptelefono As String, _
            ByVal pcorreoCliente As String, ByVal pcontacto As String, ByVal pdireccion As String)
        _idCliente = pidCliente
        _nombre = pnombre
        _telefono = ptelefono
        _correoCliente = pcorreoCliente
        _contacto = pcontacto
        _direccion = pdireccion

    End Sub
#End Region

#Region "propiedades de la clase clsCliente"
    Public Property idCliente() As String
        Get
            Return _idCliente
        End Get
        Set(ByVal value As String)
            _idCliente = value
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

    Public Property telefono() As String
        Get
            Return _telefono
        End Get
        Set(ByVal value As String)
            _telefono = value
        End Set
    End Property

    Public Property correoCliente() As String
        Get
            Return _correoCliente
        End Get
        Set(ByVal value As String)
            _correoCliente = value
        End Set
    End Property

    Public Property contacto() As String
        Get
            Return _contacto
        End Get
        Set(ByVal value As String)
            _contacto = value
        End Set
    End Property

    Public Property direccion() As String
        Get
            Return _direccion
        End Get
        Set(ByVal value As String)
            _direccion = value
        End Set
    End Property
#End Region


End Class

