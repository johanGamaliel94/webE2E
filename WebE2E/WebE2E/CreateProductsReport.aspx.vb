Imports CrystalDecisions.CrystalReports.Engine

Public Class CreateProductsReport
    Inherits System.Web.UI.Page
    Dim oReportClientDocument As CrystalDecisions.ReportAppServer.ClientDoc.ISCDReportClientDocument

    Dim section As Section
    Dim oReportDocument As New ReportDocument
    Dim path As Object

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        errores.InnerHtml = ""
    End Sub

    Protected Sub creaReporte_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles creaReporte.ServerClick
        Dim nombreRep As String
        nombreRep = nombreReporte.Value
        If nombreRep.Length > 0 Then
            oReportClientDocument = oReportDocument.ReportClientDocument
            oReportClientDocument.[New]()
            path = Server.MapPath("~/Reports")

            oReportClientDocument.SaveAs(nombreRep + ".rpt", path, 1)
            Response.Redirect("ProductsReportList.aspx")
        Else
            errores.InnerHtml = "<p style='color: crimson;'>El campo de nombre de reporte no debe estar vacío</p>"
        End If

    End Sub

End Class