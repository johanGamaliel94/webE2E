Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class principal
    Inherits System.Web.UI.Page


    Dim doc As New ReportDocument

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        
    End Sub

    Protected Sub Products_ReportClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles products_report.ServerClick

        'doc.Load(Server.MapPath("~\Reports\Reporte_Prueba.rpt"))
        'CrystalReportViewer1.ReportSource = doc
        Response.Redirect("ProductsReport.aspx")

    End Sub
    Protected Sub Orders_ReportClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles orders_report.ServerClick
        Response.Redirect("OrdersReport.aspx")
    End Sub


End Class