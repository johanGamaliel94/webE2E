Public Class Site1
    Inherits System.Web.UI.MasterPage

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        razon_soc.InnerText = Session("razon_soc")
        nombre_com.InnerHtml = Session("nombre_com")
    End Sub

End Class