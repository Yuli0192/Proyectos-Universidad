Public Class ClsRol
#Region "atributos de la clase clsRol"
    Private _nombre As String
    Private _descripcion As String
#End Region

#Region "propiedades de la clase clsRol"


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

#Region "constructor de la clase clsRol"

    ''' <summary>
    ''' constructor vacío
    ''' </summary>
    ''' <remarks></remarks>
    Sub New()
    End Sub

    ''' <summary>
    ''' constructor con 2 parámetros
    ''' </summary>
    ''' <param name="pnombre">Nombre del permiso, tipo String</param>
    ''' <param name="pdescripcion">Descripción del permiso, tipo string</param>
    ''' <remarks></remarks>
    Sub New(ByVal pnombre As String, ByVal pdescripcion As String)
        _nombre = pnombre
        _descripcion = pdescripcion
    End Sub


#End Region

End Class


