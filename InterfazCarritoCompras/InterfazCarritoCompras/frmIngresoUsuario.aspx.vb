Imports CapaNegocio
Public Class frmIngresoUsuario
    Inherits System.Web.UI.Page



    Protected Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        Dim obj_Cliente As New ClaseLogin
        Try
            obj_Cliente.IdCliente = TxtCedula.Text
            obj_Cliente.Nombre = TxtNombre.Text
            obj_Cliente.Contrasena = TxtContraseña.Text
            obj_Cliente.Telefono = TxtTelefono.Text
            obj_Cliente.Correo = TxtCorreo.Text
            obj_Cliente.validarDatos()
            obj_Cliente.guardarDatos()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class