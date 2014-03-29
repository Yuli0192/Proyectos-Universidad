Public Class ClsUsuario
#Region "atributos"
    Private _cedula As String
    Private _nombre As String
    Private _apellido1 As String
    Private _apellido2 As String
    Private _correo As String
    Private _contrasenna As String
    Private _rol As String
    Private _coddepartamento As String
    Private _departamento As String
#End Region

#Region "constructores"
    Sub New()

    End Sub

    Sub New(ByVal pcedula As String, ByVal pnombre As String, ByVal papellido1 As String, _
            ByVal papellido2 As String, ByVal pcorreo As String, ByVal pcontrasenna As String, _
            ByVal prol As String, ByVal pcoddepartamento As String, ByVal pdepartamento As String)
        _cedula = pcedula
        _nombre = pnombre
        _apellido1 = papellido1
        _apellido2 = papellido2
        _correo = pcorreo
        _contrasenna = pcontrasenna
        _rol = prol
        _coddepartamento = pcoddepartamento
        _departamento = pdepartamento
    End Sub

    Sub New(ByVal pcedula As String, ByVal pnombre As String, ByVal papellido1 As String, _
            ByVal papellido2 As String, ByVal pcorreo As String, ByVal pcontrasenna As String, _
            ByVal prol As String, ByVal pdepartamento As String)
        _cedula = pcedula
        _nombre = pnombre
        _apellido1 = papellido1
        _apellido2 = papellido2
        _correo = pcorreo
        _departamento = pdepartamento
        _contrasenna = pcontrasenna
        _rol = prol

    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="pcedula"></param>
    ''' <param name="pnombre"></param>
    ''' <param name="papellido1"></param>
    ''' <param name="papellido2"></param>
    ''' <param name="prol"></param>
    ''' <remarks></remarks>
    Sub New(ByVal pcedula As String, ByVal pnombre As String, ByVal papellido1 As String _
            , ByVal papellido2 As String, ByVal prol As String)
        _cedula = pcedula
        _nombre = pnombre
        _apellido1 = papellido1
        _apellido2 = papellido2
        _rol = prol

    End Sub
#End Region

#Region "propiedades"
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

    Public Property contrasenna() As String
        Get
            Return _contrasenna
        End Get
        Set(ByVal value As String)
            _contrasenna = value
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

    Public Property coddepartamento() As String
        Get
            Return _coddepartamento
        End Get
        Set(ByVal value As String)
            _coddepartamento = value
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

#End Region
End Class
