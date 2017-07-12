Public Class Site1
    Inherits System.Web.UI.MasterPage

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Recogemos los valores previamente asignados del inicio de sesión correcto para mostrarlos en la vista

        razon_soc.InnerText = Session("razon_soc")
        nombre_com.InnerText = Session("nombre_com")
        etiqueta_usuario.InnerText = Session("usuario")

        'Esto es cuando los elementos de abajo no están en el WebForm
        Try
            usuario_label.InnerText = Session("usuario")
            razon_soc_label.InnerText = Session("razon_soc")
            nombre_com_label.InnerText = Session("nombre_com")
            nivel_seguridad_label.InnerText = Session("nivel_seguridad")
        Catch ex As Exception

        End Try
    End Sub

End Class