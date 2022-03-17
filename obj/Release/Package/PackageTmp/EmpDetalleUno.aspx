<%@ Page Title="Tarrago Reach System" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EmpDetalleUno.aspx.cs" Inherits="ReachSystem.EmpDetalleUno" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server"> 
    <div class="container">
    <div class="card">
        <div class="card-header">
                <div class="form-row">
                    <div class="col10L">
                        <asp:Label ID="Label6" runat="server" Text="EMPRESA: DATOS" Style="font-weight: bold; font-size: 18px;"></asp:Label>
                    </div>
                </div>
            </div>
        <div class="card-body">
                <div class="form-row">     
        <div class="fila col10L">
                <CENTER>
                    <asp:Label ID="Label1" runat="server" Text="SELECCIONE EMPRESA" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                    <asp:DropDownList ID="DropDownList4" runat="server" CssClass="formulario"  DataSourceID="SqlDataSource1" DataTextField="NombreComercial" DataValueField="NombreComercial">                                   
                    </asp:DropDownList>     
                    <asp:SqlDataSource runat="server" ID="SqlDataSource1" ConnectionString='<%$ ConnectionStrings:affisDBConnectionString %>' SelectCommand="SELECT [NombreComercial] FROM [Empresa] WHERE ([Ruc] IS NULL) ORDER BY [NombreComercial]"></asp:SqlDataSource>
</CENTER>
            </div>            
         <CENTER>       
        <asp:Button class="botonsubmit" value="REGISTRARME" type="submit" runat="server" CssClass="botonsubmit" Text="SIGUIENTE" OnClick="Unnamed1_Click" /></center>    
   </CENTER>
                     <hr />
        <CENTER><asp:Button  value="FF" type="submit" runat="server" CssClass="botonsubmitTRES" Text="CANCELAR" OnClick="Unnamed_Click" UseSubmitBehavior="False" /> </CENTER>
                    </div>
            </div>
        </div>
        </div>
    
</asp:Content>
