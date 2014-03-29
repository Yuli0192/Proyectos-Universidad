Public Class ClsCastCadenaPermiso

    Dim cod As String
    Dim nombre As String
    Dim descripcion As String



    Public Property codPermiso() As String
        Get
            Return cod
        End Get
        Set(ByVal value As String)
            cod = value
        End Set
    End Property

    Public Property nombrePermiso() As String
        Get
            Return nombre
        End Get
        Set(ByVal value As String)
            nombre = value
        End Set
    End Property

    Public Property descripcionPermiso() As String
        Get
            Return descripcion
        End Get
        Set(ByVal value As String)
            descripcion = value
        End Set
    End Property


    Public Sub New()

    End Sub

    Public Sub New(ByVal pcod As String, ByVal pnombre As String, ByVal pdescripcion As String)
        cod = pcod
        nombre = pnombre
        descripcion = pdescripcion
    End Sub
End Class


