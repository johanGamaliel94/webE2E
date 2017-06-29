<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site1.Master" CodeBehind="ProductsReportList.aspx.vb" Inherits="WebE2E.ProductsReportList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table class="table table-bordered">
        <thead class="table-inverse">
            <tr>
                <th>Nombre</th>
            </tr>
        </thead>
        <tbody  runat="server" id="productos_tablaReportes">
            
        </tbody>
    </table>
</asp:Content>
