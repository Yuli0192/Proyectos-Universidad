Imports CllLogicaNegocio

Partial Public Class iniciarSesion
    Inherits System.Web.UI.Page

    Dim _gestor As New ClsGestor() 'declara e instancia de la clase Gestor

    Private Function validarEspacio() As Boolean

        If Me.txtCorreo.Text.Equals("") Then

            MsgBox("Debe ingresar el nombre de usuario", "Iniciar sesión")
            Me.txtCorreo.Focus()
            Return False

        End If

        If Me.txtContrasenna.Text.Equals("") Then

            MsgBox("Debe ingresar la contraseña", "Iniciar sesión")
            txtContrasenna.Text = ""
            Me.txtContrasenna.Focus()
            Return False

        End If

        Return True

    End Function

    Private Sub iniciarSesion()
        If validarEspacio() Then

            Try

                Session.Add("DATOS_USUARIOS", _gestor.iniciarSession(Me.txtCorreo.Text, Me.txtContrasenna.Text))
                Dim datos As ArrayList = Session("DATOS_USUARIOS")

                If datos.Count > 0 Then
                    Session.Add("ROL_USUARIO", datos(4))
                    Response.Redirect("~/inicio.aspx", False)
                Else
                    Response.Write("<Script>alert('El usuario o contraseña no coinciden.');</Script>")
                End If
            Catch ex As Exception
                Response.Write("<Script>alert('Error al tratar de conectar con la base de datos.');</Script>")
            End Try

        End If

    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        Me.txtCorreo.Focus()

        If Not IsPostBack Then

            Session.Clear()

        End If
    End Sub

    Protected Sub btnmodificar2_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btnmodificar2.Click
        iniciarSesion()
    End Sub
End Class