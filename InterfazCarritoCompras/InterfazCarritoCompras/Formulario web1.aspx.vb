Imports CapaNegocio
Public Class Formulario_web1
    Inherits System.Web.UI.Page

    Dim obj_producto As New ClaseProducto
    Dim tabla As DataTable

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        obj_producto.cargarDatos()
        tabla = obj_producto.TablaProductos.Copy()
        lblcamisa1Nom.Text = tabla.Rows(0).Item(1)
        lblcamisa1Precio.Text = tabla.Rows(0).Item(3)
        lblcamisa2Nom.Text = tabla.Rows(1).Item(1)
        lblcamisa2Precio.Text = tabla.Rows(1).Item(3)
        lblpantalon1Nom.Text = tabla.Rows(2).Item(1)
        lblpantalon1Precio.Text = tabla.Rows(2).Item(3)
        lblpantalon2Nom.Text = tabla.Rows(3).Item(1)
        lblpantalon2Precio.Text = tabla.Rows(3).Item(3)
        lbltenisNom.Text = tabla.Rows(4).Item(1)
        lbltenisPrecio.Text = tabla.Rows(4).Item(3)
    End Sub

End Class