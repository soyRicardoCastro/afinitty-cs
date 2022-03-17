<%@ Page Title="Tarrago Reach System" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="InclusionCertificados.aspx.cs" Inherits="ReachSystem.InclusionCertificados" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server"> 
    <div class="container">
    <div class="card">
        <div class="card-header">
                <div class="form-row">
                    <div class="col10L">                        
                        <asp:Label ID="Label6" runat="server" Text="INCLUSIÓN: CERTIFICADOS" Style="font-weight: bold; font-size: 18px;"></asp:Label>                        
                        <asp:Label ID="Label10" runat="server" Text="ADICION: CERTIFICADOS" Style="font-weight: bold; font-size: 18px;"></asp:Label>                        
                        <asp:Label ID="Label11" runat="server" Text="REEMPLAZO: CERTIFICADOS" Style="font-weight: bold; font-size: 18px;"></asp:Label> 
                        <asp:Label ID="Label5" runat="server" Text="PROCESAR CERTIFICADO: CERTIFICADOS" Style="font-weight: bold; font-size: 18px;"></asp:Label> 
                    </div>                   
                </div>
            </div>
        <div class="card-body">
                <div class="form-row">
                    <%--<asp:Label ID="Label5" runat="server" Text="NOMBRES TOMADOR" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                                <input class="formularioblock" placeholder="Nombres Tomador" id="Text4" type="text" runat="server"   disabled/>
                    <hr />
                      --%>
                        <center><asp:Label ID="Label17" runat="server" Text="ASIGNAR CERTIFICADO" Style="font-weight: bold; font-size: 24px;"></asp:Label></center><br />
                    <table style="width: 100%;">
                        <tr>
                            <td>
                                <asp:Label ID="Label1" runat="server" Text="CEDULA" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                                <asp:Label ID="Label7" runat="server"  Style="font-weight: bold; font-size: 14px;"></asp:Label>
                                
                            </td>
                            <td>
                                <asp:Label ID="Label2" runat="server" Text="TOMADOR" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                                <asp:Label ID="Label8" runat="server"  Style="font-weight: bold; font-size: 14px;"></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="Label3" runat="server" Text="PRIMA CERTIFICADO $" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                                <asp:Label ID="Label9" runat="server"  Style="font-weight: bold; font-size: 14px;"></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="Label4" runat="server" Text="CERTIFICADO" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                                <input class="formularioProc" placeholder="CERTIFICADO" id="Text1" type="text" runat="server"/>
                                <asp:DropDownList ID="DropDownList1" runat="server" CssClass="formularioProc" DataSourceID="SqlDataSource1" DataTextField="Numero" DataValueField="Numero">
                                </asp:DropDownList>
                                <asp:SqlDataSource runat="server" ID="SqlDataSource1" ConnectionString='<%$ ConnectionStrings:affisDBConnectionString %>' SelectCommand="SELECT [Numero] FROM [Certificados] WHERE (([Ejecutivo] = @Ejecutivo) AND ([Estado] = @Estado)) order by Numero asc">
                                    <SelectParameters>
                                        <asp:CookieParameter CookieName="namescreenC" Name="Ejecutivo" Type="String"></asp:CookieParameter>
                                        <asp:Parameter DefaultValue="ENTREGADO" Name="Estado" Type="String"></asp:Parameter>
                                    </SelectParameters>
                                </asp:SqlDataSource>
                            </td> 
                            <td>
                                <asp:Label ID="Label12" runat="server" Text="FECHA VENTA" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                                <input class="formularioProc" placeholder="CERTIFICADO" id="Text2" type="date" runat="server"/>
                            </td>
                        </tr>
                        
                        
                        
                    </table> 
                        
                    <hr />                                            
                    <CENTER><asp:Button  value="REGISTRARME" type="submit" runat="server" CssClass="botonsubmitTRES" Text="GUARDAR" OnClick="Unnamed_Click"/>                                                  
                    </CENTER>
                    <hr />                                            
                    <CENTER><asp:Button  value="REGISTRARME" type="submit" runat="server" CssClass="botonsubmitTRES" Text="CANCELAR" OnClick="Unnamed_Click2" UseSubmitBehavior="False" />  
                        <asp:Button  value="REGISTRARME" type="submit" runat="server" CssClass="botonsubmitTRES" Text="VOLVER" OnClick="Unnamed_Click3" UseSubmitBehavior="False" />                                              
                    </CENTER>
                </div>
            </div>
        </div>
        </div>
   
</asp:Content>
