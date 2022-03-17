<%@ Page Title="Tarrago Reach System" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default2.aspx.cs" Inherits="ReachSystem.Default2" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server"> 
    <div class="container">
    <div class="card">
        <div class="card-header">
                <div class="form-row">
                    <div class="col10L">
                        <asp:Label ID="Label6" runat="server" Text="APERTURA EMPRESA" Style="font-weight: bold; font-size: 18px;"></asp:Label>
                    </div>
                </div>
            </div>
        <div class="card-body">
                <div class="form-row">
    <center><%--<asp:Label ID="Label1" runat="server" Text="NOMBRE COMERCIAL" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />--%>
        <input class="formulario" placeholder="NOMBRE COMERCIAL" id="Correo" type="text" runat="server" required/>
        <br />
        <%--<asp:Label ID="Label2" runat="server" Text="MEDIO DE COBRO" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />--%>
        <div class="fila col10L">
                <asp:DropDownList ID="DropDownList4" runat="server" CssClass="formulario">
                    <asp:ListItem>MEDIO DE COBRO</asp:ListItem>
                    <asp:ListItem>ROL DE PAGOS</asp:ListItem>
                    <asp:ListItem>TARJETA DE CREDITO</asp:ListItem>
                    <asp:ListItem>AMBOS</asp:ListItem>
                </asp:DropDownList>   
            
            </div>       
        <div>
            <asp:RequiredFieldValidator ID="rel1" runat="server" InitialValue="MEDIO DE COBRO" ControlToValidate="DropDownList4" ErrorMessage="SELECCIONE MEDIO DE COBRO"> </asp:RequiredFieldValidator>
        </div>
                
        <asp:Button class="botonsubmit" value="REGISTRARME" type="submit" runat="server" CssClass="botonsubmit" Text="CREAR EMPRESA" OnClick="Unnamed1_Click" /></center>    
                     <hr />
        <CENTER><asp:Button  value="FF" type="submit" runat="server" CssClass="botonsubmitTRES" Text="CANCELAR" OnClick="Unnamed_Click" UseSubmitBehavior="False" /> 
    </div>
            </div>
        </div>
       
        </div>
    
</asp:Content>
