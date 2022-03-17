<%@ Page Title="Tarrago Reach System" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ReclamosResponder.aspx.cs" Inherits="ReachSystem.ReclamosResponder" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server"> 
    <div class="container">
    <div class="card">
        <div class="card-header">
                <div class="form-row">
                    <div class="col10L">                        
                        <asp:Label ID="Label6" runat="server" Text="RECLAMOS RESOLUCION" Style="font-weight: bold; font-size: 18px;"></asp:Label>                                                                        
                    </div>                   
                </div>
            </div>
        <div class="card-body">
                <div class="form-row">                    
                    <table style="width: 100%;">
                        <tr>                            
                            <td>
                                <asp:Label ID="Label3" runat="server" Text="NRO. CASO" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                                <input class="formularioProc" placeholder="NRO. CASO" id="Text2" type="text" runat="server" />
                            </td>   
                            <td>
                                <asp:Label ID="Label8" runat="server" Text="FECHA DE CREACION" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                                <input class="formularioProc" placeholder="FECHA DE CREACION" id="Text6" type="text" runat="server"  />
                            </td>  
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="Label1" runat="server" Text="NRO. DOCUMENTO" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                                <input class="formularioProc" placeholder="NRO. DOCUMENTO" id="Correo" type="number" runat="server"  />
                            </td>
                            <td>
                                <asp:Label ID="Label2" runat="server" Text="REGISTRO NRO. DOCUMENTO" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                                <input class="formularioProc" placeholder="REGISTRO NRO. DOCUMENTO" id="Text1" type="text" runat="server"  />
                            </td>
                            </tr>     
                        <tr>
                            <td>
                                <asp:Label ID="Label9" runat="server" Text="DIAS CASO RESUELTO" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                                <input class="formularioProc" placeholder="DIAS CASO RESUELTO" id="Text7" type="number" runat="server"  />
                            </td>  
                            <td>
                                <asp:Label ID="Label7" runat="server" Text="PAGO ASEGURADORA $" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                                <input class="formularioProc" placeholder="PAGO ASEGURADORA $" id="Text5" type="text" runat="server"  />
                            </td>
                                                                                                          
                        </tr>     
                        <tr>
                            <td>
                                <asp:Label ID="Label4" runat="server" Text="FECHA PAGO CLIENTE" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                                <input class="formularioProc" placeholder="FECHA PAGO CLIENTE" id="Text3" type="date" runat="server"  />
                            </td>  
                            <td>
                                <asp:Label ID="Label14" runat="server" Text="EJECUTIVO RESPONSABLE" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                                <asp:DropDownList ID="Drop1" runat="server" CssClass="formularioProc" DataSourceID="SqlDataSource1" DataTextField="Alias" DataValueField="Alias">
                                    <asp:ListItem>EJECUTIVO</asp:ListItem>
                                </asp:DropDownList>
                                <asp:SqlDataSource runat="server" ID="SqlDataSource1" ConnectionString='<%$ ConnectionStrings:affisDBConnectionString %>' SelectCommand="SELECT [Alias] FROM [Usuario] where Estado = 'ACTIVO' order by Alias asc"> <%--WHERE ([Perfil] = @Perfil) OR ([Perfil] = @Perfil2) OR ([Perfil] = @Perfil3)--%>
                                    <%--<SelectParameters>
                                        <asp:Parameter DefaultValue="ADMIN" Name="Perfil" Type="String"></asp:Parameter>
                                        <asp:Parameter DefaultValue="OPERACIONES" Name="Perfil2" Type="String"></asp:Parameter>
                                        <asp:Parameter DefaultValue="SUPEROP" Name="Perfil3" Type="String"></asp:Parameter>
                                    </SelectParameters>--%>
                                </asp:SqlDataSource>
                            </td>                                                                                                                                      
                        </tr>                         
                        <tr>
                            
                            <td>
                                <asp:Label ID="Label15" runat="server" Text="ESTADO DEL RECLAMO" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                                <asp:DropDownList ID="DropDownList1" runat="server" CssClass="formularioProc">
                                    <asp:ListItem>ESTADO</asp:ListItem>
                                    <asp:ListItem>LIQUIDADO</asp:ListItem>
                                    <asp:ListItem>NEGADO</asp:ListItem> 
                                    <asp:ListItem>NO CUMPLE 24 HORAS</asp:ListItem>
                                    <asp:ListItem>NO CUMPLE CONDICIONES POLIZA</asp:ListItem> 
                                    <asp:ListItem>NO ENTREGO DOCUMENTOS</asp:ListItem>                                
                                </asp:DropDownList>
                                
                            </td>
                             <td>
                                <asp:Label ID="Label10" runat="server" Text="OBSERVACIONES" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                                <input class="formularioProc" placeholder="OBSERVACIONES" id="Text8" type="text" runat="server"  />
                            </td>                                                                                  
                        </tr>      
                    </table>                    
                    <hr />  
                    
                    <CENTER><asp:Button  value="FF" type="submit" runat="server" CssClass="botonsubmitTRES" Text="CANCELAR" OnClick="Unnamed_Click" UseSubmitBehavior="False" />  
                        <asp:Button  value="FF" type="submit" runat="server" CssClass="botonsubmitTRES" Text="VOLVER" OnClick="Unnamed2_Click" UseSubmitBehavior="False" />  
                    <asp:Button  value="REGISTRARME" type="submit" runat="server" CssClass="botonsubmitTRES" Text="RESPONDER CASO" OnClick="Unnamed_Click1" UseSubmitBehavior="False" />                          

                    </CENTER>
                </div>
            </div>
        </div>
        </div>
    
</asp:Content>
