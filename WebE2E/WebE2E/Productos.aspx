<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Productos.aspx.vb" Inherits="WebE2E.Productos" %>

    <table class="table table-bordered">
        <thead class="table-inverse">
            <tr>
                <th>#</th>
                <th>Nombre</th>
                <th>Descripciòn</th>
                <th>Precio</th>
            </tr>
        </thead>
        <tbody>
            <%For i As Integer = 1 To 5 %>
            <tr>
                <td><%Response.Write(i.ToString()) %></td>
                <td>Producto <%Response.Write(i.ToString()) %></td>
                <td>$15.00</td>
                <td>Descripciòn</td>
            </tr>
            <%Next %>
        </tbody>
    </table>

