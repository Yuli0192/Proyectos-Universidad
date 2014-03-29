Imports CllLogicaNegocio.ClsGestor

Partial Public Class frmListarDisponibles
    Inherits System.Web.UI.Page
    Dim _gestor As New CllLogicaNegocio.ClsGestor

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.cargarDisponibles()
    End Sub

    Private Sub cargarDisponibles()
        Try
            Dim _listaDisponibles As List(Of Array) = New List(Of Array)() 'declarar una variable tipo lista genérica de Array

            _listaDisponibles = _gestor.listarmastersgerentesdisponibles() 'asignar el resultado de la búsqueda devuelto por un método del Gestor

            Dim _tempArray As Array 'declarar una variable tipo Array

            Dim _listTemp As New List(Of ClsCastCadenaUsuario) 'declarar una variable tipo lista genérica tipo ClsCastCadenaServicio (Wrapper)

            Dim _tempCast() As String 'declarar una variable tipo arreglo de String

            'estructura iterativa tipo matriz para recorrer y envolver por el tipo adecuado
            For i As Integer = 0 To _listaDisponibles.Count - 1

                _tempArray = _listaDisponibles(i) 'clonar a un Array temporal la FILA (ROW) de la consulta

                ReDim _tempCast(_tempArray.Length() - 1) 'redimensionar el arreglo a un tamaño indicado

                'recorrer la parte interna de la matriz, columna (COLUMN)
                For j As Integer = 0 To _tempArray.Length - 1
                    'asignar el valor de cada celda 
                    _tempCast(j) = _tempArray.GetValue(j).ToString()
                Next
                _listTemp.Add(New ClsCastCadenaUsuario(_tempCast(0).ToString(), _tempCast(1).ToString(), _tempCast(2).ToString(), _tempCast(3).ToString(), _tempCast(4).ToString())) 'agregar a la lista genérica una colección de la clase wrapper

            Next
            Me.gvDisponibles.DataSource = _listTemp 'asignar el fuente de dato para un control tipo DataGridView la lista genérica wrappeada

            Me.gvDisponibles.DataBind()
            'Vamos a probar si pondemos cambiar el nombre a las columnas..
            'gvServicio.Columns(1).ShowHeader = True
            'gvServicio.Columns(1).HeaderText = "Prueba para cambiar nombre"

            'Me.gvServicio.DataBind()
        Catch ex As Exception
            Response.Write("<script language='javascript' type='text/javascript'> alert('Error - Funcion cargarDisponibles() en frmBuscarModificarServicio.aspx.vb');</script>")
        End Try
    End Sub

End Class