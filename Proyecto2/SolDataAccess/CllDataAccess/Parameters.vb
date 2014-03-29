Public Class Parameters
#Region "atributos"
    'Nombre del parametro
    Private pNombre As String
    'Objeto Almacenado en el parametro
    Private pDato As Object
#End Region

#Region "propiedades"
    Public Property Nombre() As String
        Get
            Return pNombre
        End Get
        Set(ByVal value As String)
            pNombre = value
        End Set
    End Property

    Public Property Dato() As Object
        Get
            Return pDato
        End Get
        Set(ByVal value As Object)
            pDato = value
        End Set
    End Property
#End Region

#Region "constructores"

    'Constructor de 0 parametro
    Sub New()
    End Sub


    'Constructor de dos parameters 
    Sub New(ByVal pDato As Object, ByVal pNombre As String)
        Nombre = pNombre
        Dato = pDato
    End Sub
#End Region
End Class
