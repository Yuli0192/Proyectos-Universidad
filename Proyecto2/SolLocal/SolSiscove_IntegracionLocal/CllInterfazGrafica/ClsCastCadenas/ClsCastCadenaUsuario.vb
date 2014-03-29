Public Class ClsCastCadenaUsuario
    Dim _cedula As String
    Dim _nombre As String
    Dim _apellido1 As String
    Dim _apellido2 As String
    Dim _correo As String
    Dim _departamento As String
    Dim _rol As String

    Public ReadOnly Property nombreCompleto() As String
        Get
            Return _nombre & " " & apellido1 & " " & apellido2
        End Get
    End Property

    Public Property cedula() As String
        Get
            Return _cedula
        End Get
        Set(ByVal value As String)
            _cedula = value
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

    Public Property apellido1() As String
        Get
            Return _apellido1
        End Get
        Set(ByVal value As String)
            _apellido1 = value
        End Set
    End Property

    Public Property apellido2() As String
        Get
            Return _apellido2
        End Get
        Set(ByVal value As String)
            _apellido2 = value
        End Set
    End Property

    Public Property correo() As String
        Get
            Return _correo
        End Get
        Set(ByVal value As String)
            _correo = value
        End Set
    End Property

    Public Property departamento() As String
        Get
            Return _departamento
        End Get
        Set(ByVal value As String)
            _departamento = value
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

    Public Sub New()

    End Sub

    Sub New(ByVal pcedula As String, ByVal pnombre As String, ByVal papellido1 As String, ByVal papellido2 As String, ByVal pcorreo As String, ByVal pdepartamento As String, ByVal prol As String)
        _cedula = pcedula
        _nombre = pnombre
        _apellido1 = papellido1
        _apellido2 = papellido2
        _correo = pcorreo
        _departamento = pdepartamento
        _rol = prol

    End Sub

    Sub New(ByVal pcedula As String, ByVal pnombre As String, ByVal papellido1 As String, ByVal papellido2 As String, ByVal prol As String)
        _cedula = pcedula
        _nombre = pnombre
        _apellido1 = papellido1
        _apellido2 = papellido2
        _rol = prol

    End Sub
End Class
