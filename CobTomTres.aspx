<%@ Page Title="Tarrago Reach System" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CobTomTres.aspx.cs" Inherits="ReachSystem.CobTomTres" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server"> 
    <div class="container">
    <div class="card">
        <div class="card-header">
                <div class="form-row">
                    <div class="col10L">                        
                        <asp:Label ID="Label6" runat="server" Text="COBRAZAS: GESTION TOMADOR" Style="font-weight: bold; font-size: 18px;"></asp:Label>                                                 
                    </div>                   
                </div>
            </div>
        <div class="card-body">
                <div class="form-row">                                                                  
                     <CENTER><asp:Label ID="Label1" runat="server" Text="DATOS" Style="font-weight: bold; font-size: 18px;"></asp:Label></CENTER><br />
                    <hr />
                    <asp:Label ID="Label32" runat="server" Text="MES DE FACTURACION" Style="font-weight: bold; font-size: 18px;"/>
                        <asp:Label ID="Label33" runat="server"  Style="font-weight: bold; font-size: 18px;"/>
                    <asp:GridView ID="GridView3" runat="server" DataSourceID="SqlDataSource3" AutoGenerateColumns="False" GridLines="None" BackColor="White" BorderStyle="None" BorderWidth="1px" CellPadding="20" ForeColor="Black" CssClass="mGrid" PagerStyle-CssClass="pgr" margin-left="2%" AlternatingRowStyle-CssClass="alt" AllowPaging="True" AllowSorting="True">
                        <Columns>
                            
                            <asp:BoundField DataField="RazonSocial" HeaderText="Empresa" SortExpression="RazonSocial"></asp:BoundField>
                            <asp:BoundField DataField="NombreComercial" HeaderText="Nombre Comercial" SortExpression="NombreComercial" ReadOnly="True"></asp:BoundField>
                            <asp:BoundField DataField="Clase" HeaderText="Clase" SortExpression="Clase"></asp:BoundField> 
                            <asp:BoundField DataField="Poliza" HeaderText="Poliza" SortExpression="Poliza"></asp:BoundField>                             
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
                    <asp:GridView ID="GridView1" runat="server" DataSourceID="SqlDataSource3" AutoGenerateColumns="False" GridLines="None" BackColor="White" BorderStyle="None" BorderWidth="1px" CellPadding="20" ForeColor="Black" CssClass="mGrid" PagerStyle-CssClass="pgr" margin-left="2%" AlternatingRowStyle-CssClass="alt"  AllowPaging="True" AllowSorting="True">
                        <Columns>
                            
                            <asp:BoundField DataField="EmitenFactura" HeaderText="Emiten Factura Comision" SortExpression="EmitenFactura"></asp:BoundField>
                            <asp:BoundField DataField="PorcenComision" HeaderText="Porcentaje Comision" SortExpression="PorcenComision" ReadOnly="True"></asp:BoundField>
                            <asp:BoundField DataField="FechaLlamada" HeaderText="Fecha Llamada De Cobro" SortExpression="FechaLlamada"></asp:BoundField>                                                        
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
                    <asp:GridView ID="GridView2" runat="server" DataSourceID="SqlDataSource3" AutoGenerateColumns="False" GridLines="None" BackColor="White" BorderStyle="None" BorderWidth="1px" CellPadding="20" ForeColor="Black" CssClass="mGrid" PagerStyle-CssClass="pgr" margin-left="2%" AlternatingRowStyle-CssClass="alt"  AllowPaging="True" AllowSorting="True">
                        <Columns>
                            
                            <asp:BoundField DataField="cdc1" HeaderText="CONTACTO DE COBRANZA 1" SortExpression="cdc1"></asp:BoundField>
                            <asp:BoundField DataField="tdc1" HeaderText="TELEFONO DE COBRANZA 1" SortExpression="tdc1" ReadOnly="True"></asp:BoundField>
                            <asp:BoundField DataField="edc1" HeaderText="CORREO DE COBRANZA 1" SortExpression="edc1"></asp:BoundField>         
                            <asp:BoundField DataField="ccdc1" HeaderText="CELULAR DE COBRANZA 1" SortExpression="ccdc1"></asp:BoundField>         
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
                    <asp:GridView ID="GridView4" runat="server" DataSourceID="SqlDataSource3" AutoGenerateColumns="False" GridLines="None" BackColor="White" BorderStyle="None" BorderWidth="1px" CellPadding="20" ForeColor="Black" CssClass="mGrid" PagerStyle-CssClass="pgr" margin-left="2%" AlternatingRowStyle-CssClass="alt"  AllowPaging="True" AllowSorting="True">
                        <Columns>
                            
                            <asp:BoundField DataField="cdc2" HeaderText="CONTACTO DE COBRANZA 2" SortExpression="cdc2"></asp:BoundField>
                            <asp:BoundField DataField="tdc2" HeaderText="TELEFONO DE COBRANZA 2" SortExpression="tdc2" ReadOnly="True"></asp:BoundField>
                            <asp:BoundField DataField="edc2" HeaderText="CORREO DE COBRANZA 2" SortExpression="edc2"></asp:BoundField>         
                            <asp:BoundField DataField="ccdc2" HeaderText="CELULAR DE COBRANZA 2" SortExpression="ccdc2"></asp:BoundField>         
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
                    <asp:SqlDataSource runat="server" ID="SqlDataSource3" ConnectionString='<%$ ConnectionStrings:affisDBConnectionString %>' SelectCommand="SELECT [RazonSocial], [NombreComercial], [Clase], [Poliza], [EmitenFactura], [PorcenComision], [FechaLlamada], [cdc1], [tdc1], [ccdc1], [edc1], [cdc2], [tdc2], [ccdc2], [edc2], [MedioDeCobro] FROM [Empresa] WHERE ([NombreComercial] = @NombreComercial)">
                        <SelectParameters>
                            <asp:CookieParameter CookieName="emprecobnom" Name="NombreComercial" Type="String"></asp:CookieParameter>
                        </SelectParameters>
                    </asp:SqlDataSource>                     
                    <hr />
                    <table style="width: 100%;">
                        <tr>
                            <td><asp:Label ID="Label34" runat="server" Text="VALOR VENTA" Style="font-weight: bold; font-size: 18px;"></asp:Label>                                                 </td>
                            <%--<td><asp:Label ID="Label35" runat="server" Text="VALOR EXCLUSION" Style="font-weight: bold; font-size: 18px;"></asp:Label>                                                 </td>--%>
                            <td><asp:Label ID="Label36" runat="server" Text="VALOR ABONADO" Style="font-weight: bold; font-size: 18px;"></asp:Label>                                                 </td>
                                                                           
                        </tr> 
                         <tr>
                            <td><asp:Label ID="Label37" runat="server" Text="" Style="font-weight: bold; font-size: 18px;"></asp:Label>                                                 </td>
                            <%--<td><asp:Label ID="Label38" runat="server" Text="" Style="font-weight: bold; font-size: 18px;"></asp:Label> --%>                                                <%--</td>--%>
                            <td><asp:Label ID="Label39" runat="server" Text="" Style="font-weight: bold; font-size: 18px;"></asp:Label>                                                 </td>
                                                                           
                        </tr> 
                        </table>
                    <hr />
                    <table style="width: 100%;">
                        <tr>
                            <td><asp:Label ID="Label2" runat="server" Text="PRIMA NETA" Style="font-weight: bold; font-size: 18px;"></asp:Label>                                                 </td>
                            <td><asp:Label ID="Label3" runat="server" Text="VALOR FACTURA" Style="font-weight: bold; font-size: 18px;"></asp:Label>                                                 </td></td>
                            <%--<td><asp:Label ID="Label4" runat="server" Text="NRO. FACTURA" Style="font-weight: bold; font-size: 18px;"></asp:Label>                                                 </td></td>
                            <td><asp:Label ID="Label5" runat="server" Text="VALOR N/C" Style="font-weight: bold; font-size: 18px;"></asp:Label>                                                 </td></td>
                            <td><asp:Label ID="Label7" runat="server" Text="NUMERO N/C" Style="font-weight: bold; font-size: 18px;"></asp:Label>--%>                                                 </td></td>
                            <%--<td><asp:Label ID="Label8" runat="server" Text="NETO A COBRAR" Style="font-weight: bold; font-size: 18px;"></asp:Label>    --%>                                             </td></td>
                        </tr> 
                        <tr>
                            <td><input class="formularioProc" placeholder="PRIMA NETA" id="Correo" type="text" runat="server" ValidationGroup="ValidateMe" /></td>
                            <td><input class="formularioProc" placeholder="VALOR FACTURA" id="Text1" type="text" runat="server" ValidationGroup="ValidateMe" /></td>
                           <%-- <td><input class="formularioProc" placeholder="NRO. FACTURA" id="Text2" type="text" runat="server" ValidationGroup="ValidateMe" /></td>
                            <td><input class="formularioProc" placeholder="VALOR N/C" id="Text3" type="number" step="any" runat="server" ValidationGroup="ValidateMe"  /></td>
                            <td><input class="formularioProc" placeholder="NUMERO N/C" id="Text4" type="text" runat="server" ValidationGroup="ValidateMe" /></td>--%>
                            <%--<td><input class="formularioProc" placeholder="NETO A COBRAR" id="Text5" type="text" runat="server" ValidationGroup="ValidateMe" /></td>--%>
                        </tr>   
                    </table>
                   <%-- <hr />
                    <center><asp:Button  value="REGISTRARME" type="submit" runat="server" CssClass="botonsubmitTRES" Text="CALCULAR" ID="Button2" UseSubmitBehavior="False" OnClick="calc"/>                                                              </center>
                    <hr />
                    <asp:Label ID="Label15" runat="server" Text="REGISTRO DE PAGO" Style="font-weight: bold; font-size: 18px;"></asp:Label>                                                 
                    <hr />
                    <table style="width: 100%;">
                        <tr>
                            <td><asp:Label ID="Label9" runat="server" Text="NRO FACTURA COMISION" Style="font-weight: bold; font-size: 18px;"></asp:Label>                                                 </td>
                            <td><asp:Label ID="Label10" runat="server" Text="VALOR FACTURA COMISION" Style="font-weight: bold; font-size: 18px;"></asp:Label>                                                 </td></td>
                            <td><asp:Label ID="Label11" runat="server" Text="VALOR RETENCION ASEG" Style="font-weight: bold; font-size: 18px;"></asp:Label>                                                 </td></td>
                            <td><asp:Label ID="Label12" runat="server" Text="NUMERO COMPROBANTE RETENCION" Style="font-weight: bold; font-size: 18px;"></asp:Label>                                                 </td></td>
                            <td><asp:Label ID="Label13" runat="server" Text="VALOR RETENCION EMPRESA" Style="font-weight: bold; font-size: 18px;"></asp:Label>                                                 </td></td>
                            
                        </tr> 
                        <tr>
                            <td><input class="formularioProc" placeholder="NRO FACTURA COMISION" id="Text6" type="text" runat="server" ValidationGroup="ValidateMe" /></td>
                            <td><input class="formularioProc" placeholder="VALOR FACTURA COMISION" id="Text7" type="text" runat="server" ValidationGroup="ValidateMe" /></td>
                            <td><input class="formularioProc" placeholder="VALOR RETENCION ASEG" id="Text8" type="text" runat="server" ValidationGroup="ValidateMe" /></td>
                            <td><input class="formularioProc" placeholder="NUMERO COMPROBANTE RETENCION" id="Text9" type="text" runat="server" ValidationGroup="ValidateMe"  /></td>
                            <td><input class="formularioProc" placeholder="VALOR RETENCION EMPRESA" id="Text10" type="number" step="any" runat="server" ValidationGroup="ValidateMe" /></td>                            
                        </tr> 
                    </table>
                    <hr />
                    <asp:Label ID="Label14" runat="server" Text="CHEQUE" Style="font-weight: bold; font-size: 18px;"></asp:Label>                                                 
                    <hr />
                    <table style="width: 100%;">
                        <tr>
                            <td><asp:Label ID="Label16" runat="server" Text="BANCO" Style="font-weight: bold; font-size: 18px;"></asp:Label>                                                 </td>
                            <td><asp:Label ID="Label17" runat="server" Text="CUENTA" Style="font-weight: bold; font-size: 18px;"></asp:Label>                                                 </td></td>
                            <td><asp:Label ID="Label18" runat="server" Text="# CHEQUE" Style="font-weight: bold; font-size: 18px;"></asp:Label>                                                 </td></td>
                            <td><asp:Label ID="Label19" runat="server" Text="VALOR CHEQUE" Style="font-weight: bold; font-size: 18px;"></asp:Label>                                                 </td></td>
                            <td>&nbsp;                                                 </td>
                            
                        </tr> 
                        <tr>
                            <td><input class="formularioProc" placeholder="BANCO" id="Text11" type="text" runat="server" ValidationGroup="ValidateMe" /></td>
                            <td><input class="formularioProc" placeholder="CUENTA" id="Text12" type="text" runat="server" ValidationGroup="ValidateMe" /></td>
                            <td><input class="formularioProc" placeholder="# CHEQUE" id="Text13" type="text" runat="server" ValidationGroup="ValidateMe" /></td>
                            <td><input class="formularioProc" placeholder="VALOR CHEQUE" id="Text14" type="number" step="any" runat="server" ValidationGroup="ValidateMe"  /></td>
                            <td>&nbsp;</td>                            
                        </tr> 
                    </table>
                    <hr />
                    <asp:Label ID="Label21" runat="server" Text="TRANSFERENCIA" Style="font-weight: bold; font-size: 18px;"></asp:Label>                                                 
                    <hr />
                    <table style="width: 100%;">
                        <tr>
                            <td><asp:Label ID="Label22" runat="server" Text="BANCO" Style="font-weight: bold; font-size: 18px;"></asp:Label>                                                 </td>
                            <td><asp:Label ID="Label23" runat="server" Text="CUENTA" Style="font-weight: bold; font-size: 18px;"></asp:Label>                                                 </td></td>
                            <td><asp:Label ID="Label24" runat="server" Text="FECHA" Style="font-weight: bold; font-size: 18px;"></asp:Label>                                                 </td></td>
                            <td><asp:Label ID="Label25" runat="server" Text="COMPROBANTE" Style="font-weight: bold; font-size: 18px;"></asp:Label>                                                 </td></td>
                            <td><asp:Label ID="Label26" runat="server" Text="VALOR" Style="font-weight: bold; font-size: 18px;"></asp:Label>                                                 </td></td>
                            
                        </tr> 
                        <tr>
                            <td><input class="formularioProc" placeholder="BANCO" id="Text16" type="text" runat="server" ValidationGroup="ValidateMe" /></td>
                            <td><input class="formularioProc" placeholder="CUENTA" id="Text17" type="text" runat="server" ValidationGroup="ValidateMe" /></td>
                            <td><input class="formularioProc" placeholder="FECHA" id="Text18" type="text" runat="server" ValidationGroup="ValidateMe" /></td>
                            <td><input class="formularioProc" placeholder="COMPROBANTE" id="Text19" type="text" runat="server" ValidationGroup="ValidateMe"  /></td>
                            <td><input class="formularioProc" placeholder="VALOR" id="Text20" type="number" step="any" runat="server" ValidationGroup="ValidateMe" /></td>                            
                        </tr> 
                    </table>--%>
                    <hr />
                    <asp:Label ID="Label27" runat="server" Text="DEBITO" Style="font-weight: bold; font-size: 18px;"></asp:Label>                                                 
                    <hr />
                    <table style="width: 100%;">
                        <tr>
                            <td><asp:Label ID="Label28" runat="server" Text="VALOR" Style="font-weight: bold; font-size: 18px;"></asp:Label>                                                 </td>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                        </tr> 
                        <tr>
                            <td><input class="formularioProc" placeholder="VALOR" id="Text21" type="text" runat="server" ValidationGroup="ValidateMe" /></td>
                            <td><asp:Label ID="Label30" runat="server" Text="TOTAL A COBRAR" Style="font-weight: bold; font-size: 18px;"></asp:Label></td>
                            <td><asp:Label ID="Label31" runat="server" Text="0,00" CssClass="formularioFin"></asp:Label></td>
                            <td><asp:Label ID="Label20" runat="server" Text="TOTAL DEUDA" Style="font-weight: bold; font-size: 18px;"></asp:Label></td>
                            <td><asp:Label ID="Label29" runat="server" Text="0,00" CssClass="formularioDeuda"></asp:Label></td>                  
                        </tr> 
                    </table>
                    <hr />
                    <center><asp:Button  value="REGISTRARME" type="submit" runat="server" CssClass="botonsubmitTRES" Text="CALCULAR" ID="Button3" UseSubmitBehavior="False" OnClick="calcdos"/>                                                              </center>                    
                    <hr />
                    <center><asp:Button  value="REGISTRARME" type="submit" runat="server" CssClass="botonsubmitTRES" Text="REGISTRAR PAGO" ID="Button4"  OnClick="PAGAR"/>                                                              </center>                    
                    <hr />
                    <CENTER>
                    <asp:Button  value="REGISTRARME" type="submit" runat="server" CssClass="botonsubmitTRES" Text="CANCELAR" ID="CANCEL" UseSubmitBehavior="False" OnClick="siguiclick"/>                                                              
                        <asp:Button  value="REGISTRARME" type="submit" runat="server" CssClass="botonsubmitTRES" Text="VOLVER" ID="Button1" UseSubmitBehavior="False" OnClick="siguiclickDOS"/>                                                              
                    </CENTER>                                        
                </div>
            </div>
        </div>
        </div>    
</asp:Content>
