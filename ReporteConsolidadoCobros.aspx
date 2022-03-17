<%@ Page Title="Tarrago Reach System" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ReporteConsolidadoCobros.aspx.cs" Inherits="ReachSystem.ReporteConsolidadoCobros" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server"> 
    <div class="container">
    <div class="card">
        <div class="card-header">
                <div class="form-row">
                    <div class="col10L">                        
                        <asp:Label ID="Label6" runat="server" Text="REPORTE: CONSOLIDADO DE COBROS" Style="font-weight: bold; font-size: 18px;"></asp:Label>                        
                    </div>                   
                </div>
            </div>
        <div class="card-body">
                <div class="form-row">
                    <table style="width: 100%;">
                        <tr>  
                            <td> <asp:Label ID="Label2" runat="server" Text="FECHA INICIO" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                                <input class="formularioProc" placeholder="NOMBRE O APELLIDO" id="Text1" type="date" runat="server"  AutoPostBack="true"/>                           
                            </td>
                            <td><asp:Label ID="Label1" runat="server" Text="FECHA FIN" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                                <input class="formularioProc" placeholder="NOMBRE O APELLIDO" id="Correo" type="date" runat="server"  AutoPostBack="true"/>                            
                            </td>
                            <%--<td><asp:Label ID="Label3" runat="server" Text="EMPRESA" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                                <asp:DropDownList ID="DropDownList2" runat="server" class="formularioProc" DataSourceID="SqlDataSource3" DataTextField="NombreComercial" DataValueField="NombreComercial"></asp:DropDownList>
                                <asp:SqlDataSource runat="server" ID="SqlDataSource3" ConnectionString='<%$ ConnectionStrings:affisDBConnectionString %>' SelectCommand="SELECT DISTINCT NombreComercial FROM Asegurados where NumeroCertificado is not null and Estado = 'VENTA'"></asp:SqlDataSource>
                            </td>
                            <td><asp:Label ID="Label4" runat="server" Text="RELACION" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                                <asp:DropDownList ID="DropDownList1" runat="server" class="formularioProc" DataSourceID="SqlDataSource2" DataTextField="Relacion" DataValueField="Relacion"></asp:DropDownList>
                                <asp:SqlDataSource runat="server" ID="SqlDataSource2" ConnectionString='<%$ ConnectionStrings:affisDBConnectionString %>' SelectCommand="SELECT DISTINCT Relacion FROM dependientes where NumeroCertificado is not null"></asp:SqlDataSource>
                            </td>--%>
                            <td><%--<asp:Label ID="Label3" runat="server" Text="GENERAR" Style="font-weight: bold; font-size: 18px;"></asp:Label>--%><br />
                                <asp:Button runat="server" CssClass="botonsubmitTRESDOS" text="GENERAR" OnClick="Unnamed_Click1"></asp:Button>                                
                            </td>                            
                        </tr>
                    </table> 
                    <hr />
                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" AllowPaging="True" GridLines="None" BackColor="White" BorderStyle="None" BorderWidth="1px" CellPadding="20" ForeColor="Black" CssClass="mGrid" PagerStyle-CssClass="pgr" margin-left="2%" AlternatingRowStyle-CssClass="alt" AllowSorting="True" DataSourceID="SqlDataSource1" PageSize="100">
                        <Columns>
                            <asp:BoundField DataField="NombreComercial" HeaderText="EMPRESA" SortExpression="NombreComercial"></asp:BoundField>
                            <asp:BoundField DataField="Clase" HeaderText="CLASE" SortExpression="Clase"></asp:BoundField>                                
                            <asp:BoundField DataField="Poliza" HeaderText="POLIZA" SortExpression="Poliza"></asp:BoundField>                            
                            <asp:BoundField DataField="Mes" HeaderText="MES" SortExpression="Mes"></asp:BoundField>
                            <asp:BoundField DataField="NumeroFactura" HeaderText="NUMERO FACTURA" SortExpression="NumeroFactura"></asp:BoundField>
                            <asp:BoundField DataField="ValorFactura" HeaderText="VALOR FACTURA" SortExpression="ValorFactura"></asp:BoundField>
                            <asp:BoundField DataField="NumeroNotaCred" HeaderText="NOTA DE CREDITO" SortExpression="NumeroNotaCred"></asp:BoundField>
                            <asp:BoundField DataField="ValorNotaCred" HeaderText="VALOR NOTA DE CREDITO" SortExpression="ValorNotaCred"></asp:BoundField> 
                            <asp:BoundField DataField="Monto" HeaderText="NETO A COBRAR" SortExpression="Monto"></asp:BoundField>
                            <asp:BoundField DataField="Estado" HeaderText="PAGO EMPRESA" SortExpression="Estado"></asp:BoundField>    
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
                    <asp:SqlDataSource runat="server" ID="SqlDataSource1" ConnectionString='<%$ ConnectionStrings:affisDBConnectionString %>' SelectCommand="Select distinct b.NombreComercial, b.Clase, b.Poliza, a.Mes, c.NumeroFactura, c.ValorFactura/10000 as ValorFactura, c.NumeroNotaCred, c.ValorNotaCred, a.Monto - c.ValorNotaCred as Monto, a.Estado, b.FormaPago from Cierres a full outer Join Empresa b on b.NombreComercial = a.Empresa full outer join Pagos c on a.Mes = c.MesFacturacion And a.Empresa = c.RazonSocial where (a.Tipo <> 'EXCLUSION' AND b.NombreComercial is not null and c.FechaTransf BETWEEN @fechaini AND @fechafin AND a.Estado <> 'LIQUIDADO') or (a.Tipo <> 'EXCLUSION' AND b.NombreComercial is not null and c.FechaTransf is null AND a.Estado <> 'LIQUIDADO')"> 
                        <SelectParameters>                                
                            <asp:CookieParameter CookieName="paramIni" Name="fechaini" Type="String"></asp:CookieParameter> 
                            <asp:CookieParameter CookieName="paramFin" Name="fechafin" Type="String"></asp:CookieParameter> 
                       <%--     <asp:CookieParameter CookieName="paramVEN" Name="ven" Type="String"></asp:CookieParameter> 
                            <asp:CookieParameter CookieName="paramEstado" Name="est" Type="String"></asp:CookieParameter> --%>
                        </SelectParameters>
                    </asp:SqlDataSource>
                 <%--   <hr />--%>
                     <%--<asp:Label ID="Label5" runat="server" Style="font-weight: bold; font-size: 18px; margin-left:52%; color:green;"></asp:Label>--%>
                    
                    <hr />
                    <center>
                        <asp:Button  value="REGISTRARME" type="submit" runat="server" CssClass="botonsubmitTRES" Text="CANCELAR" OnClick="Unnamed_Click" UseSubmitBehavior="False" />  
                        <Button  value="REGISTRARME" type="submit" runat="server" Class="botonsubmitCUATRO" ID="Button3" OnServerClick="descarga1" UseSubmitBehavior="False" >EXPORTAR <i class="fa fa-file-excel-o"></i></Button></center>  
                    
                </div>
            

            </div>
        </div>
        </div>

</asp:Content>
