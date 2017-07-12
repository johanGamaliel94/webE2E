Imports System.Drawing.Printing
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
        Dim nombreReporte As String = Request.QueryString("name")
        nombreRep.InnerText = nombreReporte
        'Cambiar la ruta de carga del reporte para diferenciar entre pedidos y productos (Hacer carpeta para pedidos)
        'Ej: doc.Load(Server.MapPath("~/Reports/Orders/Reporte_prueba.rpt"))
        Try
            doc.Load(Server.MapPath("~/Reports/" + nombreReporte)) 'El nombre del reporte('Reporte_prueba.rpt') va a ser dinámico
            CrystalReportViewer1.ReportSource = doc
            CrystalReportViewer1.RefreshReport()

        Catch ex As Exception
            nombreRep.InnerHtml = "El reporte no existe. <a href='OrdersReportList' class='btn btn-link' runat='server'>Regresar</a>"

        End Try
    End Sub

    Protected Sub Imprime_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_imprime.ServerClick
        Try
            'Imprimir el informe. Establecer los parámetros startPageN 
            '  y endPageN en 0 para imprimir todas las páginas.
            doc.PrintToPrinter(1, True, 0, 0)
        Catch ex As Exception
            errores.InnerHtml = "<p style='color: crimson;'>No es posible imprimir el reporte</p>"
        End Try
    End Sub


End Class