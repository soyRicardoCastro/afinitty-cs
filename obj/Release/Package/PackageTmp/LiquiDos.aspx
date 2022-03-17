<%@ Page Title="Tarrago Reach System" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="LiquiDos.aspx.cs" Inherits="ReachSystem.LiquiDos
    " %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server"> 
    <div class="container">
    <div class="card">
        <div class="card-header">
                <div class="form-row">
                    <div class="col10L">                        
                        <asp:Label ID="Label6" runat="server" Text="LIQUIDACIONES" Style="font-weight: bold; font-size: 18px;"></asp:Label>                                                 
                    </div>                   
                </div>
            </div>
        <div class="card-body">
                <div class="form-row">                                                                  
                    <%-- <asp:Label ID="Label1" runat="server" Text="DATOS COBRO" Style="font-weight: bold; font-size: 22px;"></asp:Label><br />
                    <hr />--%>
                    <asp:Label ID="Label32" runat="server" Text="MES DE FACTURACION:" Style="font-weight: bold; font-size: 18px; color: red;"/>
                        <asp:Label ID="Label33" runat="server"  Style="font-weight: bold; font-size: 18px; color:red;"/>
                    <asp:GridView ID="GridView3" runat="server" DataSourceID="SqlDataSource3" AutoGenerateColumns="False" GridLines="None" BackColor="White" BorderStyle="None" BorderWidth="1px" CellPadding="20" ForeColor="Black" CssClass="mGrid" PagerStyle-CssClass="pgr" margin-left="2%" AlternatingRowStyle-CssClass="alt" AllowPaging="True" AllowSorting="True">
                        <Columns>
                            
                           
                          <%--  <asp:BoundField DataField="NombreComercial" HeaderText="Nombre Comercial" SortExpression="NombreComercial" ReadOnly="True"></asp:BoundField>--%>
                            <asp:BoundField DataField="RazonSocial" HeaderText="RAZON SOCIAL" SortExpression="RazonSocial"></asp:BoundField>
                            <asp:BoundField DataField="Clase" HeaderText="CLASE" SortExpression="Clase"></asp:BoundField> 
                            <asp:BoundField DataField="Poliza" HeaderText="EMPRESA" SortExpression="Poliza"></asp:BoundField>    
<%--                            <asp:BoundField DataField="PorcenComision" HeaderText="Porcentaje Comision" SortExpression="PorcenComision" ReadOnly="True"></asp:BoundField>--%>
                             
                        </Columns>
                        <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
                            <HeaderStyle BackColor="white" Font-Bold="True" ForeColor="black" />
                            <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
                            <SelectedRowStyle BackColor="#CCCCCC" Font-Bold="True" ForeColor="White" />
                            <SortedAscendingCellStyle BackColor="#F7F7F7" />
                            <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
                            <SortedDescendingCellStyle BackColor="#E5E5E5" />
                            <SortedDescendingHeaderStyle BackColor="#242121" />
                        <PagerStyle CssClass="pgr"></PagerStyle>
                    </asp:GridView>                     
                    <asp:SqlDataSource runat="server" ID="SqlDataSource3" ConnectionString='<%$ ConnectionStrings:affisDBConnectionString %>' SelectCommand="SELECT * FROM [Empresa] WHERE ([NombreComercial] = @NombreComercial)">
                        <SelectParameters>
                            <asp:CookieParameter CookieName="emprecobnom" Name="NombreComercial" Type="String"></asp:CookieParameter>
                        </SelectParameters>
                    </asp:SqlDataSource>                     
           
                    <hr />
                    <table style="width: 100%;">
                        <tr>
                            <td><asp:Label ID="Label1" runat="server" Text="VALOR FACTURA" Style="font-weight: bold; font-size: 18px;"></asp:Label> 
                            <td><asp:Label ID="Label4" runat="server" Text="PRIMA NETA" Style="font-weight: bold; font-size: 18px;"></asp:Label>                                                 </td>
                            <td><asp:Label ID="Label2" runat="server" Text="PRIMA NETA PRE-LIQUIDACION" Style="font-weight: bold; font-size: 18px;"></asp:Label>                                                 </td>
                            <td><asp:Label ID="Label3" runat="server" Text="PORCENTAJE COMISION" Style="font-weight: bold; font-size: 18px;"></asp:Label>                                                 </td>
                            <td><asp:Label ID="Label7" runat="server" Text="COMISION" Style="font-weight: bold; font-size: 18px;"></asp:Label>                                                 </td>
                            <td><asp:Label ID="Label5" runat="server" Text="DIFERENCIA" Style="font-weight: bold; font-size: 18px;"></asp:Label>                                                 </td>
                            
                            
                        </tr> 
                        <tr>
                            <td><input class="formularioProc" placeholder="0,00" id="Text5" type="text" runat="server" ValidationGroup="ValidateMe" /></td>
                             <td><input class="formularioProc" placeholder="0,00" id="Correo" type="text" runat="server" ValidationGroup="ValidateMe" /></td>
                            <td><input class="formularioProc" placeholder="0,00" id="Text2" type="text" runat="server" ValidationGroup="ValidateMe" /></td>                           
                            <td><input class="formularioProc" placeholder="0,00" id="Text1" type="text" runat="server" ValidationGroup="ValidateMe" /></td>
                            <td><input class="formularioProc" placeholder="0,00" id="Text4" type="text" runat="server" ValidationGroup="ValidateMe" /></td>
                            <td><input class="formularioProc" placeholder="0,00" id="Text3" type="text"  runat="server" ValidationGroup="ValidateMe"  /></td>
                            
                            
                        </tr>   
                    </table>
                    <hr />
                    <center><asp:Button  value="REGISTRARME" type="submit" runat="server" CssClass="botonsubmitTRES" Text="CALCULAR" ID="Button2" UseSubmitBehavior="False" OnClick="calc"/>                                                              </center>
                    <hr />                   
                    <table style="width: 100%;">
                        <tr>
                            <td><asp:Label ID="Label9" runat="server" Text="FECHA RECEPCION" Style="font-weight: bold; font-size: 18px;"></asp:Label>                                                 </td>
                            <td><asp:Label ID="Label10" runat="server" Text="FECHA PRELIQUIDACION" Style="font-weight: bold; font-size: 18px;"></asp:Label>                                                 </td>                                                        
                        </tr> 
                        <tr>
                            <td><input class="formularioProc" placeholder="NRO. FACTURA COMISION" id="Text6" type="date" runat="server" ValidationGroup="ValidateMe" /></td>
                            <td><input class="formularioProc" placeholder="VALOR COMISION" id="Text7" type="date" runat="server" ValidationGroup="ValidateMe" /></td>                            
                        </tr> 
                    </table>
                     <hr />
                    <br />
                    <CENTER>

                       <asp:Button  value="REGISTRARME" type="submit" runat="server" CssClass="botonsubmitTRES" Text="LIQUIDAR" ID="Button4"  OnClick="PAGAR"/>
                    <asp:Button  value="REGISTRARME" type="submit" runat="server" CssClass="botonsubmitTRES" Text="CANCELAR" ID="CANCEL" UseSubmitBehavior="False" OnClick="siguiclick"/>                                                              
                        <asp:Button  value="REGISTRARME" type="submit" runat="server" CssClass="botonsubmitTRES" Text="VOLVER" ID="Button1" UseSubmitBehavior="False" OnClick="siguiclickDOS"/>                                                              
                    </CENTER>                                        
                </div>
            </div>
        </div>
        </div>    
</asp:Content>
