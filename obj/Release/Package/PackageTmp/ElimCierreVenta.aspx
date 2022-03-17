<%@ Page Title="Tarrago Reach System" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ElimCierreVenta.aspx.cs" Inherits="ReachSystem.ElimCierreVenta" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server"> 
    <div class="container">
    <div class="card">
        <div class="card-header">
                <div class="form-row">
                    <div class="col10L">                        
                        <asp:Label ID="Label6" runat="server" Text="ELIMINAR CIERRE: VENTAS" Style="font-weight: bold; font-size: 18px;"></asp:Label>                        
                    </div>                   
                </div>
            </div>
        <div class="card-body">
                <div class="form-row">
                    <table style="width: 100%;">
                        <tr>                            
                            <td><asp:Label ID="Label2" runat="server"  Style="font-weight: bold; font-size: 18px;"></asp:Label>                             
                            </td>
                            <td><asp:Button runat="server" CssClass="botonsubmitTRESDOS" text="ELIMINAR" OnClick="Unnamed_Click1"></asp:Button>
                                
                            </td>    
                            <td><asp:Label ID="Label1" runat="server"  Style="font-weight: bold; font-size: 18px;"></asp:Label>                             
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <input class="formulario" placeholder="Fecha Nacimiento" id="Text5" type="date" runat="server"  />
                            </td>
                        </tr>
                    </table> 
                     <hr />
                                            
                    <CENTER>
                    <asp:Button  value="REGISTRARME" type="submit" runat="server" CssClass="botonsubmitTRES" Text="CANCELAR" OnClick="Unnamed2_Click1" UseSubmitBehavior="False" /> 
                     </CENTER>  
                </div>
            </div>
        </div>
        </div>    
</asp:Content>
