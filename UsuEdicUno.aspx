<%@ Page Title="Tarrago Reach System" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UsuEdicUno.aspx.cs" Inherits="ReachSystem.UsuEdicUno" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server"> 
    <div class="container">
    <div class="card">
        <div class="card-header">
                <div class="form-row">
                    <div class="col10L">
                        <asp:Label ID="Label6" runat="server" Text="USUARIO: EDICION" Style="font-weight: bold; font-size: 18px;"></asp:Label>
                    </div>
                </div>
            </div>
        <div class="card-body">
                <div class="form-row">     
        <div class="fila col10L">
                <CENTER>
                    <asp:Label ID="Label2" runat="server" Text="SELECCIONE ESTADO" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                    <asp:DropDownList ID="DropDownList1" runat="server" CssClass="formulario" OnSelectedIndexChanged="fijarrelacion" AutoPostBack="true"><asp:ListItem Value="0">ESTADO</asp:ListItem>
<asp:ListItem>ACTIVO</asp:ListItem>
<asp:ListItem>INACTIVO</asp:ListItem>
</asp:DropDownList><br />
                    <asp:Label ID="Label1" runat="server" Text="SELECCIONE USUARIO" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                    <asp:DropDownList ID="DropDownList4" runat="server" CssClass="formulario"   DataTextField="Alias" DataValueField="Alias"  AppendDataBoundItems="true" >
                        <asp:ListItem Value="0">USUARIO</asp:ListItem>  
                    </asp:DropDownList>     
                    <%--<asp:SqlDataSource runat="server" ID="SqlDataSource1" ConnectionString='<%$ ConnectionStrings:affisDBConnectionString %>' SelectCommand="select distinct nombrecomercial from asegurados where estado = 'VENTA'"></asp:SqlDataSource>--%>
</CENTER>
            </div>            
         <CENTER>       
        <asp:Button class="botonsubmit" value="REGISTRARME" type="submit" runat="server" CssClass="botonsubmit" Text="SIGUIENTE" OnClick="Unnamed1_Click" /></center>      
                     <hr />
        <CENTER><asp:Button  value="FF" type="submit" runat="server" CssClass="botonsubmitTRES" Text="CANCELAR" OnClick="Unnamed_Click" UseSubmitBehavior="False" /> </CENTER>
                    </div>
            </div>
        </div>
        </div>
    
</asp:Content>
