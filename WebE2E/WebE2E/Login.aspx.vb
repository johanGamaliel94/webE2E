Public Class Login
    Inherits System.Web.UI.Page
    'Protected Sub Page_PreInit(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.PreInit

    '   Page.MasterPageFile = "Site1.master"

    'End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Login_Click(ByVal sender As Object, ByVal e As System.EventArgs) 'Handles Login.ServerClick
        'Response.Redirect("principal.aspx")
        'Aquí va a ir la validación del inicio de sesión
        Session("razon_soc") = "Don Wicho S.A de C.V" 'Este valor cambiará dependiendo del usuario que inicie sesión
        Session("nombre_com") = "Tacos Don Wicho" 'Este valor cambiará dependiendo del usuario que inicie sesión
        Response.Redirect("~/menu.aspx")
        'Response.Redirect(Request.Url.ToString())
    End Sub

End Class