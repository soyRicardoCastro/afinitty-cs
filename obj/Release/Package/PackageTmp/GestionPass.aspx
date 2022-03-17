<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="GestionPass.aspx.cs" Inherits="ReachSystem.GestionPass" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="baseform">
            <br />
            <br />
            <br />
            <br />
            <p><h2>ACTUALIZAR CONTRASEÑA</h2></p>            
            <div class="fila col10L">
                <input class="formulario" placeholder="Usuario" type="text"  required id="text1" runat="server"/>            
            </div>                        
            <div class="fila col10L">
                <input class="formulario" placeholder="Contraseña" type="password" required id="text2" runat="server"/>            
            </div>
            <div class="fila col10L">
                <input class="formulario" placeholder="Repetir Contraseña" type="password" required id="text3" runat="server"/>            
            </div>            
            <%--<p><a class="enlaces" href="Login.aspx">Volver al Login</a></p>--%>
            <div class="fila col10L">
                <asp:Button runat="server" class="botonsubmit" value="CAMBIAR CONTRASEÑA" text="ACTUALIZAR CONTRASEÑA" type="submit" OnClick="Unnamed1_Click1" />            
            </div>
        </div>  
</asp:Content>
