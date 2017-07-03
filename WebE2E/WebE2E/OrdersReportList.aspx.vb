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
            pedidos_tablaReportes.InnerHtml += "<tr><td>" + Path.GetFileName(foundFile) + "</td>"
            pedidos_tablaReportes.InnerHtml += "<td><center><a href='Reporte.aspx?name=" + Path.GetFileName(foundFile) + "' class='btn btn-success' runat='server' data-toggle='tooltip' data-placement='right' title='Editar'  ><span class='glyphicon glyphicon-pencil'></span></a></center></td>"
            pedidos_tablaReportes.InnerHtml += "<td><center><a href='OrdersReport.aspx?name=" + Path.GetFileName(foundFile) + "' class='btn btn-primary' runat='server' data-toggle='tooltip' data-placement='right' title='Ver'><span class='glyphicon glyphicon-fullscreen'></span></a></center></td>"
            pedidos_tablaReportes.InnerHtml += "<td><center><a href='#' class='btn btn-danger' runat='server' data-toggle='tooltip' data-placement='right' title='Eliminar'><span class='glyphicon glyphicon-remove'></span></a></td></center></tr>"

        Next
        'prueba.InnerHtml = nombresReporte.Item(0)
    End Sub

End Class