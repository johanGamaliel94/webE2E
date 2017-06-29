Imports CrystalDecisions.CrystalReports.Engine

Public Class ProductsReport
    Inherits System.Web.UI.Page
    Dim oReportClientDocument As CrystalDecisions.ReportAppServer.ClientDoc.ISCDReportClientDocument

    Dim section As Section
    Dim oReportDocument As New ReportDocument
    Dim path As Object

    Dim doc As New ReportDocument
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Cambiar la ruta de carga del reporte para diferenciar entre pedidos y productos (Hacer carpeta para productos)
        'Ej: doc.Load(Server.MapPath("~/Reports/Products/Reporte_prueba.rpt"))
        doc.Load(Server.MapPath("~\Reports\Reporte_Prueba.rpt"))
        CrystalReportViewer1.ReportSource = doc
        CrystalReportViewer1.RefreshReport()
    End Sub


End Class