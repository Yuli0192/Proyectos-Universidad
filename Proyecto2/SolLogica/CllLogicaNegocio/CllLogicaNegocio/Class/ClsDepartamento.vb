Public Class ClsDepartamento

#Region "atributos de la clase clsDepartamento"

    Private _codigo As String
    Private _nombre As String

#End Region

#Region "propiedades de la clase clsDepartamento"

    Public Property codigo() As String
        Get
            Return _codigo
        End Get
        Set(ByVal value As String)
            _codigo = value
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

#End Region

#Region "constructor de la clase clsDepartamento"

    ''' <summary>
    ''' constructor vacío
    ''' </summary>
    ''' <remarks></remarks>
    Sub New()
    End Sub

    ''' <summary>
    ''' constructor con todos los parámetros
    ''' </summary>
    ''' <param name="pcodigo">codigo del departamento, tipo String</param>
    ''' <param name="pnombre">Nombre del departamento, tipo String</param>    
    ''' <remarks></remarks>
    Sub New(ByVal pcodigo As String, ByVal pnombre As String)

        _codigo = pcodigo
        _nombre = pnombre

    End Sub

#End Region

End Class
