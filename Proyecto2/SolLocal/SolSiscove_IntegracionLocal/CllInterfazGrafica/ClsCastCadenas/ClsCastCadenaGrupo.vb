Public Class ClsCastCadenaGrupo

    Dim _cod As String
    Dim _descripcion As String
    Dim _idEncargado As String

    Public Property codGrupo() As String
        Get
            Return _cod
        End Get
        Set(ByVal value As String)
            _cod = value
        End Set
    End Property

    Public Property descripcionGrupo() As String
        Get
            Return _descripcion
        End Get
        Set(ByVal value As String)
            _descripcion = value
        End Set
    End Property

    Public Property idEncargadoGrupo() As String
        Get
            Return _idEncargado
        End Get
        Set(ByVal value As String)
            _idEncargado = value
        End Set
    End Property

    Public Sub New()

    End Sub

    Public Sub New(ByVal pcod As String, ByVal pdescripcion As String, ByVal pidEncargado As Double)
        _cod = pcod
        _descripcion = pdescripcion
        _idEncargado = pidEncargado

    End Sub

End Class


