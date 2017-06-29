Imports System.IO
Imports CrystalDecisions.CrystalReports.Engine

Public Class OrdersReport
    Inherits System.Web.UI.Page

    'Private Function GetReportClientDocument(ByVal myReportDocument As ReportDocument) As CrystalDecisions.ReportAppServer.ClientDoc.ISCDReportClientDocument
    '   GetReportClientDocument = myReportDocument.ReportClientDocument
    'End Function

    Dim doc As New ReportDocument
    Dim oReportClientDocument As CrystalDecisions.ReportAppServer.ClientDoc.ISCDReportClientDocument

    Dim section As Section
    Dim oReportDocument As New ReportDocument
    Dim path As Object


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        'Cambiar la ruta de carga del reporte para diferenciar entre pedidos y productos (Hacer carpeta para pedidos)
        'Ej: doc.Load(Server.MapPath("~/Reports/Orders/Reporte_prueba.rpt"))
        doc.Load(Server.MapPath("~/Reports/Reporte_prueba.rpt")) 'El nombre del reporte('Reporte_prueba.rpt') va a ser dinámico
        CrystalReportViewer1.ReportSource = doc
        CrystalReportViewer1.RefreshReport()

    End Sub



End Class