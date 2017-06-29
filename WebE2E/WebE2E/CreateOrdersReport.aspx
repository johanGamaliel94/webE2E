<%@ Page Title="Nuevo reporte de pedidos" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site1.Master" CodeBehind="CreateOrdersReport.aspx.vb" Inherits="WebE2E.CreateOrdersReport" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
<div class="col-md-8">
<div class="row">
    <input type="text" id="nombreReporte" runat="server" class="form-control"/>
</div>
<div class="row">
<button type="button" id="creaReporte" class="btn btn-success" runat="server">Crear reporte</button>
</div>
    <div class="col-md-6" runat="server" id="errores">

    </div>
</div>
</asp:Content>
