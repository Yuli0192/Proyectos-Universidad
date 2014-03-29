Public Class ClsCastCadenaCliente
    Dim _id As String
    Dim _nombre As String
    Dim _telefono As String
    Dim _correo As String
    Dim _contacto As String
    Dim _direccion As String

    Public Property idCliente() As String
        Get
            Return _id
        End Get
        Set(ByVal value As String)
            _id = value
        End Set
    End Property

    Public Property nombreCliente() As String
        Get
            Return _nombre
        End Get
        Set(ByVal value As String)
            _nombre = value
        End Set
    End Property

    Public Property telefonoCliente() As String
        Get
            Return _telefono
        End Get
        Set(ByVal value As String)
            _telefono = value
        End Set
    End Property

    Public Property correoCliente() As String
        Get
            Return _correo
        End Get
        Set(ByVal value As String)
            _correo = value
        End Set
    End Property

    Public Property contactoCliente() As String
        Get
            Return _contacto
        End Get
        Set(ByVal value As String)
            _contacto = value
        End Set
    End Property

    Public Property direccionCliente() As String
        Get
            Return _direccion
        End Get
        Set(ByVal value As String)
            _direccion = value
        End Set
    End Property

    Public Sub New()

    End Sub

    Public Sub New(ByVal pidCliente As String, ByVal pnombre As String, ByVal ptelefono As String, ByVal pcorreoCliente As String, ByVal pcontacto As String, ByVal pdireccion As String)
        _id = pidCliente
        _nombre = pnombre
        _telefono = ptelefono
        _correo = pcorreoCliente
        _contacto = pcontacto
        _direccion = pdireccion
    End Sub
End Class
