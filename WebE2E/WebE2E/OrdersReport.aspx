<%@ Page Title="Reporte de pedidos" Language="VB" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="OrdersReport.aspx.vb" Inherits="WebE2E.OrdersReport" %>

<%@ Register Assembly="CrystalDecisions.Web, Version=13.0.2000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" Namespace="CrystalDecisions.Web" TagPrefix="CR" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
<div class="pull-right">
<button class="btn btn-primary btn-lg" id="btn_imprime" runat="server" data-toggle='tooltip' data-placement='left' title='Imprimir reporte'><span class="glyphicon glyphicon-print"></span></button>
</div>
<div runat="server" id="errores">
</div>
<h2 runat="server" id="nombreRep"></h2>
<script lang = "javaScript" type="text/javascript" src="Scripts/crystalreportviewers13/js/crviewer/crv.js"></script> 
<link rel="stylesheet" type="text/css" href="Scripts/crystalreportviewers13/js/crviewer/images/style.css" />
<CR:CrystalReportViewer ID="CrystalReportViewer1" runat="server" AutoDataBind="true" />
</asp:Content>
