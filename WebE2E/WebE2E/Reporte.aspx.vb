Imports CrystalDecisions.CrystalReports.Engine

Public Class Reporte
    Inherits System.Web.UI.Page

    Dim doc As New ReportDocument
    Dim oReportClientDocument As CrystalDecisions.ReportAppServer.ClientDoc.ISCDReportClientDocument

    Dim section As Section
    Dim oReportDocument As New ReportDocument
    Dim path As Object


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim nombreReporte As String = Request.QueryString("name")
        Try
            nombreRep.InnerText = nombreReporte
            doc.Load(Server.MapPath("~/Reports/" + nombreReporte)) 'El nombre del reporte('Reporte_prueba.rpt') va a ser dinámico

        Catch ex As Exception
            errores.InnerHtml = "<p style='color: crimson'>El reporte no existe</p>"
            content.Visible = False
        End Try
    End Sub

End Class