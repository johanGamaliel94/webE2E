Public Class Login
    Inherits System.Web.UI.Page
    Dim ws As New WebService.Service1
    'Protected Sub Page_PreInit(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.PreInit

    '   Page.MasterPageFile = "Site1.master"

    'End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Login_Click(ByVal sender As Object, ByVal e As System.EventArgs) 'Handles Login.ServerClick
        'Response.Redirect("principal.aspx")
        'Aquí va a ir la validación del inicio de sesión
        'Session("razon_soc") = "Don Wicho S.A de C.V" 'Este valor cambiará dependiendo del usuario que inicie sesión
        'Session("nombre_com") = "Tacos Don Wicho" 'Este valor cambiará dependiendo del usuario que inicie sesión
        Dim claveCliente As String = claveClienteLog.Value
        Dim claveUsuario As String = claveUsuarioLog.Value
        Dim contrasenia As String = contraseniaLog.Value

        Dim peticionWS As String = String.Format("104|40D2FF65|{0}|{1}|{2}|0", claveCliente, contrasenia, claveUsuario)
        'Dim peticionWS As String = "104|40D2FF65|100|qq|5|0"

        If claveCliente.Length > 0 And claveUsuario.Length > 0 And contrasenia.Length > 0 Then

            Dim respuestaWS As String = ws.wmCampo(peticionWS)
            If respuestaWS.ToLower().Contains("ok") Then
                Dim datosUsuario() As String = Split(respuestaWS, "|")
                '5 6 7 8 (Índice de campos en el formato de retorno de la clave 104)
                'Esto se debe modelar en una clase (Usuario / Cliente)
                Session("nivel_seguridad") = datosUsuario(5)
                Session("usuario") = datosUsuario(6)
                Session("nombre_com") = datosUsuario(7)
                Session("razon_soc") = datosUsuario(8)
                Response.Redirect("~/menu.aspx")

                'errores.InnerHtml = "1 " + datosUsuario(0) + " 2 " + datosUsuario(1) + " 3 " + datosUsuario(2)
                'errores.InnerHtml = "nombre_com " + Session("nombre_com") + " razon soc " + Session("razon_soc") + " usuario " + Session("usuario") + " nivel seguridad " + Session("nivel_seguridad")
            Else
                errores.InnerHtml = "<p style='color: red;'>Datos incorrectos, intente de nuevo</p>"
            End If

        Else
            errores.InnerHtml = "<p style='color: red;'>Debes llenar todos los campos</p>"
        End If

        'Response.Redirect("~/menu.aspx")
        'Response.Redirect(Request.Url.ToString())
    End Sub

End Class