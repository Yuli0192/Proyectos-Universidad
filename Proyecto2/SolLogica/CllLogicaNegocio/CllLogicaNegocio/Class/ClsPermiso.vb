Public Class ClsPermiso

#Region "atributos de la clase clsPermiso"
    Private _cod As String
    Private _nombre As String
    Private _descripcion As String

#End Region

#Region "propiedades de la clase clsPermiso"
    Public Property cod() As String
        Get
            Return _cod
        End Get
        Set(ByVal value As String)
            _cod = value
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
#End Region

#Region "constructor de la clase clsPermiso"

    ''' <summary>
    ''' constructor vacío
    ''' </summary>
    ''' <remarks></remarks>
    Sub New()
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="pcod">Codigo de el permiso, Tipo String</param>
    ''' <param name="pnombre">Nombre de el permiso, Tipo String</param>
    ''' <param name="pdescripcion">Descripcion de el permiso, Tipo String</param>
    ''' <remarks></remarks>
    Sub New(ByVal pcod As String, ByVal pnombre As String, ByVal pdescripcion As String)
        _cod = pcod
        _nombre = pnombre
        _descripcion = pdescripcion

    End Sub
#End Region
End Class
