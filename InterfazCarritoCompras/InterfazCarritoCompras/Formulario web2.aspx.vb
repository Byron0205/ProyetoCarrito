Imports CapaNegocio
Public Class Formulario_web2
    Inherits System.Web.UI.Page

    Dim obj_cliente As New ClaseLogin

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Try
            obj_cliente.IdCliente = txtCedula.Text
            obj_cliente.Nombre = txtNombre.Text
            obj_cliente.Correo = txtCorreo.Text
            obj_cliente.Contrasena = txtContrasena.Text
            obj_cliente.Telefono = txtTelefono.Text

            obj_cliente.validarDatos()
            obj_cliente.guardarDatos()

        Catch ex As Exception
            lblError.Text = ex.Message
        End Try
    End Sub
End Class