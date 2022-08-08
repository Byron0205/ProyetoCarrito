Public Class PáginaMaestra
    Inherits System.Web.UI.MasterPage

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Inicio_Click(sender As Object, e As EventArgs) Handles Inicio.Click
        Response.Redirect("Formulario web1.aspx")
    End Sub

    Protected Sub AcercaDe_Click(sender As Object, e As EventArgs) Handles AcercaDe.Click
        Response.Redirect("Formulario web3.aspx")
    End Sub

    Protected Sub Registrarse_Click(sender As Object, e As EventArgs) Handles Registrarse.Click
        Response.Redirect("Formulario web2.aspx")
    End Sub
End Class