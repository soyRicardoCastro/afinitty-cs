<%@ Page Title="Tarrago Reach System" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AsistenciaLista.aspx.cs" Inherits="ReachSystem.AsistenciaLista" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server"> 
    <div class="container">
    <div class="card">
        <div class="card-header">
                <div class="form-row">
                    <div class="col10L">                        
                        <asp:Label ID="Label6" runat="server" Text="REGISTRO ASISTENCIA" Style="font-weight: bold; font-size: 18px;"></asp:Label>                         
                    </div>                   
                </div>
            </div>
        <div class="card-body">
                <div class="form-row">
                    <div class="fila col10L">
                <CENTER>
                    <asp:Label ID="Label1" runat="server" Text="SELECCIONE EJECUTIVO" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                    <asp:DropDownList ID="DropDownList4" runat="server" CssClass="formulario"  DataSourceID="SqlDataSource2" DataTextField="Alias" DataValueField="Alias">                                   
                    </asp:DropDownList>     
                    <asp:SqlDataSource runat="server" ID="SqlDataSource2" ConnectionString='<%$ ConnectionStrings:affisDBConnectionString %>' SelectCommand="SELECT [Alias] FROM [Usuario] where Estado='ACTIVO' AND Perfil='VENTA' OR Perfil='SUPERVEN' OR Perfil='DIRECVEN'"></asp:SqlDataSource>
</CENTER>
            </div>            
         <CENTER>       
        <asp:Button class="botonsubmit" value="REGISTRARME" type="submit" runat="server" CssClass="botonsubmit" Text="SIGUIENTE" OnClick="Unnamed1_Click" /></center>    
   </CENTER>
                     <hr />
        <CENTER><asp:Button  value="FF" type="submit" runat="server" CssClass="botonsubmitTRES" Text="CANCELAR" OnClick="CANCEL_Click" UseSubmitBehavior="False" /> </CENTER>
                                                            
                    
                </div>
            </div>
        </div>
        </div>
    
</asp:Content>
