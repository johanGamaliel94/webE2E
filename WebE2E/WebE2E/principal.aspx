<%@ Page Title="Dashboard" Language="vb" AutoEventWireup="false" CodeBehind="principal.aspx.vb" Inherits="WebE2E.principal" %>

<%@ Register Assembly="CrystalDecisions.Web, Version=13.0.2000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" Namespace="CrystalDecisions.Web" TagPrefix="CR" %>

<!DOCTYPE html>

<html lang="es">
<head runat="server">
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <title><%: Page.Title %> - My ASP.NET Application</title>

    <asp:PlaceHolder runat="server">
        <%: Scripts.Render("~/bundles/modernizr") %>
    </asp:PlaceHolder>

    <webopt:bundlereference runat="server" path="~/Content/css" />
    <link href="~/favicon.ico" rel="shortcut icon" type="image/x-icon" />
    <script lang = "javaScript" type="text/javascript" src="Scripts/crystalreportviewers13/js/crviewer/crv.js"></script> 

</head>
<body>
    <form runat="server" class="form-horizontal">
        <asp:ScriptManager runat="server">
            <Scripts>
                <%--To learn more about bundling scripts in ScriptManager see http://go.microsoft.com/fwlink/?LinkID=301884 --%>
                <%--Framework Scripts--%>
                <asp:ScriptReference Name="MsAjaxBundle" />
                <asp:ScriptReference Name="jquery" />
                <asp:ScriptReference Name="bootstrap" />
                <asp:ScriptReference Name="respond" />
                <asp:ScriptReference Name="WebForms.js" Assembly="System.Web" Path="~/Scripts/WebForms/WebForms.js" />
                <asp:ScriptReference Name="WebUIValidation.js" Assembly="System.Web" Path="~/Scripts/WebForms/WebUIValidation.js" />
                <asp:ScriptReference Name="MenuStandards.js" Assembly="System.Web" Path="~/Scripts/WebForms/MenuStandards.js" />
                <asp:ScriptReference Name="GridView.js" Assembly="System.Web" Path="~/Scripts/WebForms/GridView.js" />
                <asp:ScriptReference Name="DetailsView.js" Assembly="System.Web" Path="~/Scripts/WebForms/DetailsView.js" />
                <asp:ScriptReference Name="TreeView.js" Assembly="System.Web" Path="~/Scripts/WebForms/TreeView.js" />
                <asp:ScriptReference Name="WebParts.js" Assembly="System.Web" Path="~/Scripts/WebForms/WebParts.js" />
                <asp:ScriptReference Name="Focus.js" Assembly="System.Web" Path="~/Scripts/WebForms/Focus.js" />
                <asp:ScriptReference Name="main.js" Assembly="System.Web" Path="~/Scripts/WebForms/main.js"/>
                <asp:ScriptReference Name="crv.js" Assembly="System.Web" Path="~/Scripts/crystalreportviewers13/js/crviewer/crv.js" />
                
                <asp:ScriptReference Name="WebFormsBundle" />
                <%--Site Scripts--%>
            </Scripts>
        </asp:ScriptManager>

<div id="throbber" style="display:none; min-height:120px;"></div>
<div id="noty-holder"></div>
<div id="wrapper">
    <!-- Navigation -->
    <nav class="navbar navbar-inverse navbar-fixed-top" role="navigation">
        <!-- Brand and toggle get grouped for better mobile display -->
        <div class="navbar-header">
            <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-ex1-collapse">
                <span class="sr-only">Toggle navigation</span>
                <span class="icon-bar"></span>
                <span class="icon-bar"></span>
                <span class="icon-bar"></span>
            </button>
            <a class="navbar-brand" href="~/principal" runat="server">
                <img src="http://placehold.it/200x50&text=LOGO" alt="LOGO"">
            </a>
        </div>
        <!-- Top Menu Items -->
        <ul class="nav navbar-right top-nav">
            <!--li><a href="#" data-placement="bottom" data-toggle="tooltip" data-original-title="Stats"><i class="glyphicon glyphicon-stats"></i>
                </a>
            </li-->            
            <li class="dropdown">
                <a href="#" class="dropdown-toggle" data-toggle="dropdown">Usuario <b class="glyphicon glyphicon-chevron-down"></b></a>
                <ul class="dropdown-menu">
                    <li><a href="#"><i class="glyphicon glyphicon-user"></i> Editar perfil</a></li>
                    <li><a href="#"><i class="glyphicon glyphicon-edit"></i> Cambiar contraseña</a></li>
                    <li class="divider"></li>
                    <li><a runat="server" href="~/"><i class="glyphicon glyphicon-log-out"></i> Cerrar sesión</a></li>
                </ul>
            </li>
        </ul>
        <!-- Sidebar Menu Items - These collapse to the responsive navigation menu on small screens -->
        <div class="collapse navbar-collapse navbar-ex1-collapse">
            <ul class="nav navbar-nav side-nav">
                <li>
                    <a href="#" data-toggle="collapse" data-target="#submenu-1"><i class="glyphicon glyphicon-folder-open"></i> Pedidos <i class="glyphicon glyphicon-chevron-down"></i></a>
                    <ul id="submenu-1" class="collapse">
                        <li><a href="#"><i class="glyphicon glyphicon-chevron-right"></i> Ver pedidos</a></li>
                        <li><button type="button" runat="server" class="btn btn-reports" id="products_report"><i class="glyphicon glyphicon-chevron-right"></i> Generar reportes</button></li>
                        <li><a href="#"><i class="glyphicon glyphicon-chevron-right"></i> SUBMENU 1.3</a></li>
                    </ul>
                </li>
                <li>
                    <a href="#" data-toggle="collapse" data-target="#submenu-2"><i class="glyphicon glyphicon-shopping-cart"></i>  Productos <i class="glyphicon glyphicon-chevron-down"></i></a>
                    <ul id="submenu-2" class="collapse">
                        <li id="ver_prod"><a href="#"><i class="glyphicon glyphicon-chevron-right"></i> Ver productos</a></li>
                        <li><button type="button" class="btn btn-reports" runat="server" id="orders_report"><i class="glyphicon glyphicon-chevron-right"></i> Generar reportes</button></li>
                        <li><a href="#"><i class="glyphicon glyphicon-chevron-right"></i> SUBMENU 2.3</a></li>
                    </ul>
                </li>
                <li>
                    <a href="#"><i class="glyphicon glyphicon-chevron-down"></i>  MENU 3</a>
                </li>
                <li>
                    <a href="#"><i class="glyphicon glyphicon-chevron-down"></i> MENU 4</a>
                </li>
                <li>
                    <a href="#"><i class="glyphicon glyphicon-chevron-down"></i> MENU 5</a>
                </li>
            </ul>
        </div>
        <!-- /.navbar-collapse -->
    </nav>

    <div id="page-wrapper">
        <div class="container-fluid">
            <!-- Page Heading -->
            <div class="row" id="main">
                <div class="col-sm-12 col-md-12 well" id="content">
                    <h1>Bienvenido, usuario!</h1>
                </div>
                
            </div>
            <div class="row">
                <div class="container body-content">
                <hr />
                <footer>
                    <p>&copy; <%: DateTime.Now.Year %> - My ASP.NET Application</p>
                </footer>
                </div>
            </div>
            <!-- /.row -->
        </div>
        <!-- /.container-fluid -->
    </div>
    <!-- /#page-wrapper -->
</div><!-- /#wrapper -->
</form>
    
    
</body>
</html>