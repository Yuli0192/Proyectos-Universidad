Public Class ClsGrupoDeVenta

#Region "Atributos"
    Private _codigo As String
    Private _descripcion As String
    Private _idEncargado As String
#End Region

#Region "Constructor"
    Sub New(ByVal pcodigo As String, ByVal pdescripcion As String, ByVal pidEncargado As String)
        _codigo = pcodigo
        _descripcion = pdescripcion
        _idEncargado = pidEncargado
    End Sub

    Sub New()
        _codigo = Nothing
        _descripcion = Nothing
        _idEncargado = Nothing
    End Sub

#End Region

#Region "Propiedades"
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

    Public ReadOnly Property encargado()
        Get
            'Dim _objUsuarioPersist = New ClsUsuarioPersist()
            'Dim _encargado As ClsUsuario = (_objUsuarioPersist.buscarPorId(idEncargado))


            Dim _encargado2 As ClsUsuario = (New ClsUsuarioPersist()).buscarPorId(idEncargado)

            Return _encargado2
        End Get
    End Property

    Public ReadOnly Property vendedores()
        Get
            Dim _objUsuarioPersist = New ClsUsuarioPersist()
            Dim _vendedores As List(Of ClsUsuario) = (_objUsuarioPersist.buscarPorGrupoDeVentas(codigo))
            Return _vendedores
        End Get

    End Property

    Public ReadOnly Property servicios()
        Get
            Dim _objServicioPersist = New ClsServicioPersist()
            Dim _servicios As List(Of ClsServicio) = (_objServicioPersist.buscarPorGrupoDeVentas(codigo))
            Return _servicios
        End Get
    End Property
#End Region

End Class