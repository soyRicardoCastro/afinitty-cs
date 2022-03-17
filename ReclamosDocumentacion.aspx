<%@ Page Title="Tarrago Reach System" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ReclamosDocumentacion.aspx.cs" Inherits="ReachSystem.ReclamosDocumentacion" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server"> 
    <div class="container">
    <div class="card">
        <div class="card-header">
                <div class="form-row">
                    <div class="col10L">                        
                        <asp:Label ID="Label6" runat="server" Text="DOCUMENTACION DEL RECLAMO" Style="font-weight: bold; font-size: 18px;"></asp:Label>                                                                        
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
                                <asp:Label ID="Label4" runat="server" Text="FECHA DE INGRESO" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                                <input class="formularioProc" placeholder="FECHA DE INGRESO" id="Text3" type="date" runat="server"  />
                            </td>  
                            <td>
                                <asp:Label ID="Label5" runat="server" Text="FECHA DE ALTA" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                                <input class="formularioProc" placeholder="FECHA DE ALTA" id="Text4" type="date" runat="server"  />
                            </td>
                            
                             </tr>
                        <tr>
                            <td>
                                <asp:Label ID="Label11" runat="server" Text="DIAS HOSPITALIZADOS" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                                <input class="formularioProc" placeholder="DIAS HOSPITALIZADOS" id="Text9" type="number" runat="server"  />
                            </td>  
                            <td>
                                <asp:Label ID="Label12" runat="server" Text="DIAS UCI" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                                <input class="formularioProc" placeholder="DIAS UCI" id="Text10" type="number" runat="server"  />
                            </td>
                           
                             </tr>
                        <tr>
                            <td>
                                <asp:Label ID="Label1" runat="server" Text="RECEPCION DE DOCUMENTOS" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                                <input class="formularioProc" placeholder="RECEPCION DE DOCUMENTOS" id="Correo" type="date" runat="server"  />
                            </td>
                           
                            <td>
                                <asp:Label ID="Label2" runat="server" Text="ENTREGA DOC. A ASEGURADORA" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                                <input class="formularioProc" placeholder="ENTREGA DOC. A ASEGURADORA" id="Text1" type="date" runat="server"  />
                            </td>
                         
                             </tr>
                       
                        <tr>
                            <td>
                                <asp:Label ID="Label9" runat="server" Text="CONFIRMACION CASO" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                                <input class="formularioProc" placeholder="CONFIRMACION CASO" id="Text7" type="date" runat="server"  />
                            </td>  
                            <td>
                                <asp:Label ID="Label7" runat="server" Text="FECHA SALIDA PAGO" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                                <input class="formularioProc" placeholder="FECHA SALIDA PAGO" id="Text5" type="date" runat="server"  />
                            </td>
                          
                             </tr>
                         
                        
                        
                        <tr>
                            <td>
                                <asp:Label ID="Label14" runat="server" Text="POSIBLE INDEMNIZACION $" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                                <input class="formularioProc" placeholder="POSIBLE INDEMNIZACION $" id="Number1" type="text" runat="server"  />
                            </td>  
                            <td>
                                <asp:Label ID="Label15" runat="server" Text="REGISTRADO POR:" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                                <asp:DropDownList ID="DropDownList1" runat="server" CssClass="formularioProc" DataSourceID="SqlDataSource1" DataTextField="Alias" DataValueField="Alias">
                                    <asp:ListItem>OPERADOR</asp:ListItem>
                                </asp:DropDownList>
                                <asp:SqlDataSource runat="server" ID="SqlDataSource1" ConnectionString='<%$ ConnectionStrings:affisDBConnectionString %>' SelectCommand="SELECT [Alias] FROM [Usuario] WHERE (([Perfil] = @Perfil) OR ([Perfil] = @Perfil2) OR ([Perfil] = @Perfil3)) AND Estado='ACTIVO' order by Alias ASC">
                                    <SelectParameters>
                                        <asp:Parameter DefaultValue="ADMIN" Name="Perfil" Type="String"></asp:Parameter>
                                        <asp:Parameter DefaultValue="SERVICIO" Name="Perfil2" Type="String"></asp:Parameter>
                                        <asp:Parameter DefaultValue="SUPEROP" Name="Perfil3" Type="String"></asp:Parameter>
                                    </SelectParameters>
                                </asp:SqlDataSource>
                            </td>
                            <td>
                                <asp:Label ID="Label16" runat="server" Text="&nbsp;" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                                <%--<input class="formularioProc" placeholder="CIUDAD" id="Text11" type="text" runat="server"  />--%>
                            </td>                                                                                
                        </tr>  
                        <tr>
                            
                            <td>
                                
                            </td>                                                                                
                        </tr> 
                    </table>  
                    <div id="OBSER">
                                <asp:Label ID="Label10" runat="server" Text="OBSERVACIONES" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                                <input class="formularioProc3" placeholder="OBSERVACIONES" id="Text8" type="text" runat="server"   width="100%"/>
                    </div>
                    <hr />  
                    
                    <CENTER><asp:Button  value="FF" type="submit" runat="server" CssClass="botonsubmitTRES" Text="CANCELAR" OnClick="Unnamed_Click" UseSubmitBehavior="False" />  
                        <asp:Button  value="FF" type="submit" runat="server" CssClass="botonsubmitTRES" Text="VOLVER" OnClick="Unnamed2_Click" UseSubmitBehavior="False" />  
                    <asp:Button  value="REGISTRARME" type="submit" runat="server" CssClass="botonsubmitTRES" Text="DOCUMENTAR CASO" OnClick="Unnamed_Click1" UseSubmitBehavior="False" />            
                         

                    </CENTER>
                </div>
            </div>
        </div>
        </div>
    
</asp:Content>
