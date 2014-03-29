Public Class ClsPlanVenta

#Region "atributos de la clase clsPlanVenta"
    Private _idPlanVenta As String
    Private _descripcion As String
    Private _fechaInicio As Date
    Private _fechaFin As Date
#End Region

#Region "propiedades de la clase clsPlanVenta"
    Public Property idPlanVenta() As String
        Get
            Return _idPlanVenta
        End Get
        Set(ByVal value As String)
            _idPlanVenta = value
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

    Public Property fechaInicio() As Date
        Get
            Return _fechaInicio
        End Get
        Set(ByVal value As Date)
            _fechaInicio = value
        End Set
    End Property

    Public Property fechaFin() As Date
        Get
            Return _fechaFin
        End Get
        Set(ByVal value As Date)
            _fechaFin = value
        End Set
    End Property
#End Region

#Region "constructor de la clase clsPlanVenta"

    ''' <summary>
    ''' constructor vacío
    ''' </summary>
    ''' <remarks></remarks>
    Sub New()
    End Sub

    ''' <summary>
    ''' constructor con todos los parámetros
    ''' </summary>
    ''' <param name="pidPlanVenta">Id del plan de venta, tipo String</param>
    ''' <param name="pdescripcion">Descripción del plan de venta, tipo String</param>
    ''' <param name="pfechaInicio">Fecha Inicio del plan de venta, tipo date</param>
    ''' <param name="pfechaFin">Fecha fin del plan de venta, tipo date</param>
    ''' <remarks></remarks>
    Sub New(ByVal pidPlanVenta As String, ByVal pdescripcion As String, ByVal pfechaInicio As DateTime, ByVal pfechaFin As DateTime)
        _idPlanVenta = pidPlanVenta
        _descripcion = pdescripcion
        _fechaInicio = pfechaInicio
        _fechaFin = pfechaFin

    End Sub
#End Region

End Class
