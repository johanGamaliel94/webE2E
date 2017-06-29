Public Class ScriptLogin
    Inherits System.Web.UI.Page
    Protected Sub Page_PreInit(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.PreInit
        'Aquí podría ir la validación del inicio de sesión
        Page.MasterPageFile = "Site1.master" 'Le damos el control a la otra master page(Site1.master)

    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

End Class