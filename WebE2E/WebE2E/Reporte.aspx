<%@ Page Title="Editar Reporte" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site1.Master" CodeBehind="Reporte.aspx.vb" Inherits="WebE2E.Reporte" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
<div class="pull-right">
    <a class="btn btn-info" runat="server" href="OrdersReportList">Regresar a la lista</a>
</div>
<div runat="server" id="errores">
</div>
<h3 runat="server" id="nombreRep"></h3>
<div class="col-sm-12 col-md-12" id="content" runat="server">
    <div class="row">
        
        <label class="">Fecha inicio: 
        <input type="text" class="form-control"/>
        </label>
        <label class="">Fecha fin: 
        <input type="text" class="form-control" />
        </label>
        
    </div>
    <div class="row">

        <label class="">Cadena 1: 
        <input type="text" class="form-control"/>
        </label>
        <label class="">Cadena 2: 
        <input type="text" class="form-control"/>
        </label>
    </div>
</div> 
</asp:Content>
