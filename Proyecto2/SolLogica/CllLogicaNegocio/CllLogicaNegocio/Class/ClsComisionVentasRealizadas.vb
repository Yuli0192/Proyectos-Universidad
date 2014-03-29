Public Class ClsComisionVentasRealizadas

#Region "atributos"
    Private _porcentaje As Double
    Private _montoAPagar As Double
    Private _nombre As String
    Private _apellido1 As String
    Private _apellido2 As String
    Private _correo As String
#End Region
#Region "contructor"
    Sub New(ByVal pporcentaje As Double, ByVal pmontoAPagar As Double, ByVal pnombre As String, ByVal papellido1 As String, ByVal papellido2 As String, ByVal pcorreo As String)
        _porcentaje = pporcentaje
        _montoAPagar = pmontoAPagar
        _nombre = pnombre
        _apellido1 = papellido1
        _apellido2 = papellido2
        _correo = pcorreo
    End Sub
#End Region
#Region "propiedades"


    Public Property nombre() As String
        Get
            Return _nombre
        End Get
        Set(ByVal value As String)
            _nombre = value
        End Set
    End Property

    Public Property porcentaje() As String
        Get
            Return _porcentaje
        End Get
        Set(ByVal value As String)
            _porcentaje = value
        End Set
    End Property

    Public Property montoapagar() As String
        Get
            Return _montoAPagar
        End Get
        Set(ByVal value As String)
            _montoAPagar = value
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
#End Region
End Class
