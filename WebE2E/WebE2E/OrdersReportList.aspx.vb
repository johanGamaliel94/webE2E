Imports System.IO

Public Class OrdersReportList
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim nombresReporte As New ArrayList
        Dim rep As New Reporte_Prueba
        'Dim startN As Integer
        Dim cont As Integer
        cont = 1

        For Each foundFile As String In Directory.GetFiles(Server.MapPath("~/Reports"), "*.rpt")

            'startN = foundFile.ToString().LastIndexOf("\Reports")
            'nombresReporte.Add(foundFile.Substring(startN))
            pedidos_tablaReportes.InnerHtml += "<tr><td>" + foundFile + "</td></tr>"

        Next
        'prueba.InnerHtml = nombresReporte.Item(0)
    End Sub

End Class