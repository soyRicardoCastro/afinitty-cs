<%@ Page Title="Tarrago Reach System" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ConsMorosos.aspx.cs" Inherits="ReachSystem.ConsMorosos" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server"> 
    <div class="container">
    <div class="card">
        <div class="card-header">
                <div class="form-row">
                    <div class="col10L">                        
                        <asp:Label ID="Label6" runat="server" Text="COBRANZAS: GESTION TOMADOR (IMPAGOS)" Style="font-weight: bold; font-size: 18px;"></asp:Label>                        
                                            
                    </div>                   
                </div>
            </div>
        <div class="card-body">
                <div class="form-row">                    
                    <table style="width: 100%;">
                        
                        
                        <tr>                            
                            <td>
                                <asp:Label ID="Label13" runat="server" Text="SELECCIONE EMPRESA" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />                                
                            </td>
                            <td>                                
                                <asp:DropDownList ID="DropDownList3" runat="server" CssClass="formularioProc" DataTextField="empresa" DataValueField="empresa" AutoPostBack="true" AppendDataBoundItems="true" OnSelectedIndexChanged="fijarempresa"  DataSourceID="SqlDataSource1">
                                    <asp:ListItem Value="0">EMPRESA</asp:ListItem>
                                </asp:DropDownList>

                                <asp:SqlDataSource runat="server" ID="SqlDataSource1" ConnectionString='<%$ ConnectionStrings:affisDBConnectionString %>' SelectCommand="select distinct empresa from Morosos"></asp:SqlDataSource>
                            </td>                            
                        </tr>
                        
                        
                    </table>
                    
                    <hr />
                                            
                    <CENTER><asp:Button  value="REGISTRARME" type="submit" runat="server" CssClass="botonsubmitTRES" Text="CANCELAR" OnClick="Unnamed_Click" UseSubmitBehavior="False" />  
                    <asp:Button  value="REGISTRARME" type="submit" runat="server" CssClass="botonsubmitTRES" Text="SIGUIENTE" OnClick="Unnamed_Click1"/>                          

                    </CENTER>
                </div>
            </div>
        </div>
        </div>
    
</asp:Content>
