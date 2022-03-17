<%@ Page Title="Tarrago Reach System" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AdminCert.aspx.cs" Inherits="ReachSystem.AdminCert" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server"> 
    <div class="container">
    <div class="card">
        <div class="card-header">
                <div class="form-row">
                    <div class="col10L">                        
                        <asp:Label ID="Label6" runat="server" Text="CERTIFICADOS: ADMINISTRAR" Style="font-weight: bold; font-size: 18px;"></asp:Label>                        
                    </div>                   
                </div>
            </div>
        <div class="card-body">
                <div class="form-row">
                    <table style="width: 100%;">
                        <tr>
                            <td><asp:Label ID="Label5" runat="server" Text="TIPO DE ACCION" Style="font-weight: bold; font-size: 18px;"  ></asp:Label>
                                <asp:DropDownList ID="DropDownList1" runat="server" CssClass="formularioProc" onselectedindexchanged="itemSelected" AutoPostBack="True">
                                    <asp:ListItem>SELECCIONE LA ACCION</asp:ListItem>
                                    <asp:ListItem>ANULADO</asp:ListItem>
                                    <asp:ListItem>DEVUELTO</asp:ListItem>
                                    <asp:ListItem>ENTREGADO</asp:ListItem>                                                                        
                                    <asp:ListItem>REASIGNADO</asp:ListItem>
                                    <asp:ListItem>USADO</asp:ListItem>
                                </asp:DropDownList>
                            </td>  
                            <td>

                            </td>
                        </tr>
                        <tr>
                            <td><asp:Label ID="Label1" runat="server" Text="DESDE" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                                <input class="formularioProc" id="Text4" type="number" runat="server"   placeholder="DESDE"/>
                            </td>
                            <td><asp:Label ID="Label2" runat="server" Text="HASTA" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                                <input class="formularioProc" placeholder="HASTA" id="Text1" type="number" runat="server"/>
                            </td>                            
                        </tr>
                        <tr>
                            <td><asp:Label ID="Label4" runat="server" Text="EJECUTIVO ASIGNADO" Style="font-weight: bold; font-size: 18px;"></asp:Label>
                                <asp:DropDownList ID="DropDownList2" runat="server" CssClass="formularioProc" AppendDataBoundItems="true" DataTextField="Alias" DataValueField="Alias">
                                    <asp:ListItem>EJECUTIVO ASIGNADO</asp:ListItem>  
                                </asp:DropDownList>
                            </td>
                                  <td>
                                      <asp:Label ID="Label3" runat="server" Text="OBSERVACIONES" Style="font-weight: bold; font-size: 18px;"></asp:Label>
                            <input class="formularioProc" placeholder="OBSERVACIONES" id="Correo" type="text" runat="server"  AutoPostBack="true"/>
                                  </td>                    
                        </tr>                        
                    </table>
                    
                    
                                      
                    
                    <hr />
                                            
                    <CENTER><asp:Button runat="server" CssClass="botonsubmitTRES" text="CANCELAR" OnClick="Unnamed_Click1"></asp:Button>  
                    <asp:Button  value="REGISTRARME" type="submit" runat="server" CssClass="botonsubmitTRES" Text="GUARDAR" OnClick="Unnamed_Click"/>                                                    
                    </CENTER>
                </div>
            </div>
        </div>
        </div>
    
</asp:Content>
