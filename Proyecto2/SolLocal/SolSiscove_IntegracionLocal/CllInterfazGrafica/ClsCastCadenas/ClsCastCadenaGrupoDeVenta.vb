Public Class ClsCastCadenaGrupoDeVenta
    Dim _codigo As String
    Dim _descripcion As String
    Dim _idEncargado As String

    Public Property codigo()
        Get
            Return _codigo
        End Get
        Set(ByVal value)
            _codigo = value
        End Set
    End Property

    Public Property descripcion()
        Get
            Return _descripcion
        End Get
        Set(ByVal value)
            _descripcion = value
        End Set
    End Property

    Public Property idEncargado()

        Get
            Return _idEncargado
        End Get
        Set(ByVal value)
            _idEncargado = value
        End Set
    End Property

    Sub New()
    End Sub

    Sub New(ByVal pcodigo As String, ByVal pdescripcion As String, ByVal pidEncargado As String)
        _codigo = pcodigo
        _descripcion = pdescripcion
        _idEncargado = pidEncargado
    End Sub
End Class
