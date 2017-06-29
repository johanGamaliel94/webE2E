<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="Registro.aspx.vb" Inherits="WebE2E.Registro" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
    <div class="col-md-6 col-md-offset-3"><!--Pendiente-->
        <div class="panel panel-default">
            <div class="panel panel-heading">Regístrate (Pendiente)</div>
            <div class="panel panel-body">
                <div class="form-group">
                    <label class="control-label col-md-4">Nombre completo</label>
                    <input type="text" class="form-control datosUs" name="nombre" id="nombre" runat="server"/>
                    <div class="col-md-offset4"><p class="error"></p></div>
                </div>
                <div class="form-group">
                    <label class="control-label col-md-4">Correo</label>
                    <input type="email" class="form-control datosUs" name="correo" id="correo" runat="server"/>
                    <div class="col-md-offset-4"><p class="error"></p></div>
                </div>
                <div class="form-group">
                    <label class="control-label col-md-4">Celular</label>
                    <input type="tel" class="form-control datosUs" name="celular" id="celular" runat="server" />
                    <div class="col-md-offset-4"><p class="error"></p></div>
                </div>
                <div class="form-group">
                    <label class="control-label col-md-4">Fecha de nacimiento</label>
                    <input type="date" class="form-control datosUs" name="fechaNac" id="fechaNac" runat="server"/>
                    <div class="col-md-offset-4"><p class="error"></p></div>
                </div>
                <div class="form-group">
                    <label class="control-label col-md-4">Género</label>
                    <input type="email" class="form-control datosUs" name="genero" id="genero" runat="server"/>
                    <div class="col-md-offset-4"><p class="error"></p></div>
                </div>
                <div class="form-group">
                    <label class="control-label col-md-4">Contraseña</label>
                    <input type="email" class="form-control datosUs" name="contrasenia" id="contrasenia" runat="server" />
                    <div class="col-md-offset-4"><p class="error"></p></div>
                </div>
                <div class="form-group">
                    <label class="control-label col-md-4">Repite tu contraseña</label>
                    <input type="email" class="form-control datosUs" name="contraseniaR" id="contraseniaR" runat="server"/>
                    <div class="col-md-offset-4"><p class="error"></p></div>
                </div>
                <div class="form-group">
                    <label class="control-label col-md-4">Pregunta secreta</label>
                    <input type="email" class="form-control datosUs" name="pregunta" id="pregunta" runat="server"/>
                    <div class="col-md-offset-4"><p class="error"></p></div>
                </div>
                <div class="form-group">
                    <label class="control-label col-md-4">Correo</label>
                    <input type="email" class="form-control datosUs" name="respuestaPreg" id="respuestaPreg" runat="server"/>
                    <div class="col-md-offset-4"><p class="error"></p></div>
                </div>
                <div class="form-group">
                    <input class="btn btn-success" id="RegistraUs" type="submit" value="Registrar" runat="server" onclick="" />
                </div>
            </div>
        </div>
    </div>
    
</asp:Content>
