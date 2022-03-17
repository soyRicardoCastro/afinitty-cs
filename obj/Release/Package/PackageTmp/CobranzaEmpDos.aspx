<%@ Page Title="Tarrago Reach System" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CobranzaEmpDos.aspx.cs" Inherits="ReachSystem.CobranzaEmpDos" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server"> 
    <div class="container">
    <div class="card">
        <div class="card-header">
                <div class="form-row">
                    <div class="col10L">                        
                        <asp:Label ID="Label6" runat="server" Text="COBRANZAS: GESTION EMPRESAS" Style="font-weight: bold; font-size: 18px;"></asp:Label>                                                 
                    </div>                   
                </div>
            </div>
        <div class="card-body">
                <div class="form-row">                                                                  
                     <asp:Label ID="Label1" runat="server" Text="DATOS COBRO" Style="font-weight: bold; font-size: 22px;"></asp:Label><br />
                    <hr />
                    <asp:Label ID="Label32" runat="server" Text="MES DE FACTURACION:" Style="font-weight: bold; font-size: 18px; color: red;"/>
                        <asp:Label ID="Label33" runat="server"  Style="font-weight: bold; font-size: 18px; color:red;"/>
                    <asp:GridView ID="GridView3" runat="server" DataSourceID="SqlDataSource3" AutoGenerateColumns="False" GridLines="None" BackColor="White" BorderStyle="None" BorderWidth="1px" CellPadding="20" ForeColor="Black" CssClass="mGrid" PagerStyle-CssClass="pgr" margin-left="2%" AlternatingRowStyle-CssClass="alt" AllowPaging="True" AllowSorting="True">
                        <Columns>
                            
                           
                            <asp:BoundField DataField="NombreComercial" HeaderText="NOMBRE COMERCIAL" SortExpression="NombreComercial" ReadOnly="True"></asp:BoundField>
                            <asp:BoundField DataField="RazonSocial" HeaderText="RAZON SOCIAL" SortExpression="RazonSocial"></asp:BoundField>
                            <asp:BoundField DataField="Clase" HeaderText="CLASE" SortExpression="Clase"></asp:BoundField> 
                            <asp:BoundField DataField="Poliza" HeaderText="POLIZA" SortExpression="Poliza"></asp:BoundField>    
                             
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
                            
                            <asp:BoundField DataField="EmitenFactura" HeaderText="EMITE FACTURA COMISION" SortExpression="EmitenFactura"></asp:BoundField>
                            <asp:BoundField DataField="PorcenComision" HeaderText="PORCENTAJE COMISION" SortExpression="PorcenComision" ReadOnly="True"></asp:BoundField>
                            <asp:BoundField DataField="FechaLlamada" HeaderText="FECHA LLAMADA" SortExpression="FechaLlamada"></asp:BoundField>   
                            <asp:BoundField DataField="MedioDeCobro" HeaderText="MEDIO DE COBRO" SortExpression="MedioDeCobro"></asp:BoundField>   
                            <asp:BoundField DataField="FormaPago" HeaderText="FORMA DE PAGO" SortExpression="FormaPago"></asp:BoundField>   
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
                            
                            <asp:BoundField DataField="cdc1" HeaderText="CONTACTO" SortExpression="cdc1"></asp:BoundField>
                            <asp:BoundField DataField="cdc2" HeaderText="TELEFONO" SortExpression="cdc2" ReadOnly="True"></asp:BoundField>
                                   
                            <asp:BoundField DataField="tdc1" HeaderText="CELULAR" SortExpression="tdc1"></asp:BoundField>    
                            <asp:BoundField DataField="tdc2" HeaderText="EMAIL" SortExpression="tdc2"></asp:BoundField>  
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
                            
                            <asp:BoundField DataField="ccdc1" HeaderText="CONTACTO" SortExpression="ccdc1"></asp:BoundField>
                            
                            <asp:BoundField DataField="ccdc2" HeaderText="TELEFONO" SortExpression="ccdc2"></asp:BoundField> 
                            
                            <asp:BoundField DataField="edc1" HeaderText="CELULAR" SortExpression="edc1"></asp:BoundField>  
                            <asp:BoundField DataField="edc2" HeaderText="EMAIL" SortExpression="edc2" ReadOnly="True"></asp:BoundField>
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
                    <asp:Label ID="Label40" runat="server" Text="DATOS FACTURA" Style="font-weight: bold; font-size: 22px;"></asp:Label><br />
                    <hr />
                    <table style="width: 100%;">
                        <tr>
                            <td><asp:Label ID="Label34" runat="server" Text="VALOR VENTA" Style="font-weight: bold; font-size: 18px;"></asp:Label>                                                 </td>
                            <td><asp:Label ID="Label35" runat="server" Text="VALOR EXCLUSION" Style="font-weight: bold; font-size: 18px;"></asp:Label>                                                 </td>
                            <td><asp:Label ID="Label36" runat="server" Text="VALOR DEUDA" Style="font-weight: bold; font-size: 18px;"></asp:Label>                                                 </td>
                                                                           
                        </tr> 
                         <tr>
                            <td><asp:Label ID="Label37" runat="server" Text="" Style="font-weight: bold; font-size: 18px;"></asp:Label>                                                 </td>
                            <td><asp:Label ID="Label38" runat="server" Text="" Style="font-weight: bold; font-size: 18px;"></asp:Label>                                                 </td>
                            <td><asp:Label ID="Label39" runat="server" Text="" Style="font-weight: bold; font-size: 18px;"></asp:Label>                                                 </td>
                                                                           
                        </tr> 
                        </table>
                    <hr />
                    <table style="width: 100%;">
                        <tr>
                            <td><asp:Label ID="Label4" runat="server" Text="NRO. FACTURA" Style="font-weight: bold; font-size: 18px;"></asp:Label>                                                 </td>
                            <td><asp:Label ID="Label2" runat="server" Text="PRIMA NETA" Style="font-weight: bold; font-size: 18px;"></asp:Label>                                                 </td>
                            <td><asp:Label ID="Label3" runat="server" Text="VALOR FACTURA" Style="font-weight: bold; font-size: 18px;"></asp:Label>                                                 </td>
                            <td><asp:Label ID="Label7" runat="server" Text="NRO. N/C" Style="font-weight: bold; font-size: 18px;"></asp:Label>                                                 </td>
                            <td><asp:Label ID="Label5" runat="server" Text="VALOR N/C" Style="font-weight: bold; font-size: 18px;"></asp:Label>                                                 </td>
                            
                            <td><asp:Label ID="Label8" runat="server" Text="NETO A COBRAR" Style="font-weight: bold; font-size: 18px;"></asp:Label>                                                 </td>
                        </tr> 
                        <tr>
                            <td><input class="formularioProc" placeholder="NRO. FACTURA" id="Text2" type="text" runat="server" ValidationGroup="ValidateMe" /></td>
                            <td><input class="formularioProc" placeholder="PRIMA NETA" id="Correo" type="text" runat="server" ValidationGroup="ValidateMe" /></td>
                            <td><input class="formularioProc" placeholder="VALOR FACTURA" id="Text1" type="text" runat="server" ValidationGroup="ValidateMe" /></td>
                            <td><input class="formularioProc" placeholder="NRO. N/C" id="Text4" type="text" runat="server" ValidationGroup="ValidateMe" /></td>
                            <td><input class="formularioProc" placeholder="VALOR N/C" id="Text3" type="text" step="any" runat="server" ValidationGroup="ValidateMe"  /></td>
                            
                            <td><input class="formularioProc" placeholder="NETO A COBRAR" id="Text5" type="text" runat="server" ValidationGroup="ValidateMe" /></td>
                        </tr>   
                    </table>
                    <hr />
                    <center><asp:Button  value="REGISTRARME" type="submit" runat="server" CssClass="botonsubmitTRES" Text="CALCULAR" ID="Button2" UseSubmitBehavior="False" OnClick="calc"/>                                                              </center>
                    <hr />
                    <asp:Label ID="Label15" runat="server" Text="DATOS PAGO" Style="font-weight: bold; font-size: 22px;"></asp:Label>                                                 
                    <hr />
                    <table style="width: 100%;">
                        <tr>
                            <td><asp:Label ID="Label9" runat="server" Text="NRO. FACTURA COMISION" Style="font-weight: bold; font-size: 18px;"></asp:Label>                                                 </td>
                            <td><asp:Label ID="Label10" runat="server" Text="VALOR COMISION" Style="font-weight: bold; font-size: 18px;"></asp:Label>                                                 </td></td>
                            <td><asp:Label ID="Label11" runat="server" Text="VALOR RET. ASEG." Style="font-weight: bold; font-size: 18px;"></asp:Label>                                                 </td></td>
                            <td><asp:Label ID="Label12" runat="server" Text="NRO. RET. EMPRESA" Style="font-weight: bold; font-size: 18px;"></asp:Label>                                                 </td></td>
                            <td><asp:Label ID="Label13" runat="server" Text="VALOR RET. EMPRESA" Style="font-weight: bold; font-size: 18px;"></asp:Label>                                                 </td></td>
                            
                        </tr> 
                        <tr>
                            <td><input class="formularioProc" placeholder="NRO. FACTURA COMISION" id="Text6" type="text" runat="server" ValidationGroup="ValidateMe" /></td>
                            <td><input class="formularioProc" placeholder="VALOR COMISION" id="Text7" type="text" runat="server" ValidationGroup="ValidateMe" /></td>
                            <td><input class="formularioProc" placeholder="VALOR RET. ASEG." id="Text8" type="text" runat="server" ValidationGroup="ValidateMe" /></td>
                            <td><input class="formularioProc" placeholder="NRO. RET. EMPRESA" id="Text9" type="text" runat="server" ValidationGroup="ValidateMe"  /></td>
                            <td><input class="formularioProc" placeholder="VALOR RET. EMPRESA" id="Text10" type="text" step="any" runat="server" ValidationGroup="ValidateMe" /></td>                            
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
                            <td><asp:Label ID="Label19" runat="server" Text="VALOR" Style="font-weight: bold; font-size: 18px;"></asp:Label>                                                 </td></td>
                            <td>&nbsp;                                                 </td>
                            
                        </tr> 
                        <tr>
                            <td><input class="formularioProc" placeholder="BANCO" id="Text11" type="text" runat="server" ValidationGroup="ValidateMe" /></td>
                            <td><input class="formularioProc" placeholder="CUENTA" id="Text12" type="text" runat="server" ValidationGroup="ValidateMe" /></td>
                            <td><input class="formularioProc" placeholder="# CHEQUE" id="Text13" type="text" runat="server" ValidationGroup="ValidateMe" /></td>
                            <td><input class="formularioProc" placeholder="VALOR" id="Text14" type="text" step="any" runat="server" ValidationGroup="ValidateMe"  /></td>
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
                            <td><input class="formularioProc" placeholder="FECHA" id="Text18" type="date" runat="server" ValidationGroup="ValidateMe" /></td>
                            <td><input class="formularioProc" placeholder="COMPROBANTE" id="Text19" type="text" runat="server" ValidationGroup="ValidateMe"  /></td>
                            <td><input class="formularioProc" placeholder="VALOR" id="Text20" type="text" step="any" runat="server" ValidationGroup="ValidateMe" /></td>                            
                        </tr> 
                    </table>
                    <hr />
                    <asp:Label ID="Label27" runat="server" Text="DEBITO" Style="font-weight: bold; font-size: 18px;"></asp:Label>                                                 
                    <hr />
                    <table style="width: 100%;">
                        <tr>
                            <td><asp:Label ID="Label28" runat="server" Text="VALOR" Style="font-weight: bold; font-size: 18px;"></asp:Label>                                                 </td>
                            <td><asp:Label ID="Label43" runat="server" Text="OBSERVACIONES" Style="font-weight: bold; font-size: 18px;"></asp:Label>  </td>
                            
                        </tr> 
                        <tr>
                            <td><input class="formularioProc" placeholder="VALOR" id="Text21" type="text" runat="server" ValidationGroup="ValidateMe" /></td>
                              <td><input class="formularioProc" placeholder="OBSERVACIONES" id="Text15" type="text" runat="server" ValidationGroup="ValidateMe" /></td>                
                        </tr> 
                        
                    </table>
                    <hr />
                    <table style="width: 100%;">
                        <tr>
                            <td><asp:Label ID="Label30" runat="server" Text="TOTAL COBRADO" Style="font-weight: bold; font-size: 18px;"></asp:Label></td>
                            <td><asp:Label ID="Label41" runat="server" Text="$ " CssClass="formularioFin"></asp:Label><asp:Label ID="Label31" runat="server" Text="0,00" CssClass="formularioFin"></asp:Label></td>
                            <td><asp:Label ID="Label20" runat="server" Text="DIFERENCIA" Style="font-weight: bold; font-size: 18px;"></asp:Label></td>
                            <td><asp:Label ID="Label42" runat="server" Text="$ " CssClass="formularioDeuda"></asp:Label><asp:Label ID="Label29" runat="server" Text="0,00" CssClass="formularioDeuda"></asp:Label></td>
                        </tr>
                        </table>
                                  
                    <hr />
                    <CENTER>
                        <asp:Button  value="REGISTRARME" type="submit" runat="server" CssClass="botonsubmitTRES" Text="CALCULAR" ID="Button3" UseSubmitBehavior="False" OnClick="calcdos"/>  
                       <asp:Button  value="REGISTRARME" type="submit" runat="server" CssClass="botonsubmitTRES" Text="GUARDAR PAGO" ID="Button4"  OnClick="PAGAR"/>
                    <asp:Button  value="REGISTRARME" type="submit" runat="server" CssClass="botonsubmitTRES" Text="CANCELAR" ID="CANCEL" UseSubmitBehavior="False" OnClick="siguiclick"/>                                                              
                        <asp:Button  value="REGISTRARME" type="submit" runat="server" CssClass="botonsubmitTRES" Text="VOLVER" ID="Button1" UseSubmitBehavior="False" OnClick="siguiclickDOS"/>                                                              
                    </CENTER>                                        
                </div>
            </div>
        </div>
        </div>    
</asp:Content>
