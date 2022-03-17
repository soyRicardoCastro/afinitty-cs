<%@ Page Title="Tarrago Reach System" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ReportePagos.aspx.cs" Inherits="ReachSystem.ReportePagos" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server"> 
    <div class="container">
    <div class="card">
        <div class="card-header">
                <div class="form-row">
                    <div class="col10L">                        
                        <asp:Label ID="Label6" runat="server" Text="REPORTE: PAGOS" Style="font-weight: bold; font-size: 18px;"></asp:Label>                        
                    </div>                   
                </div>
            </div>
        <div class="card-body">
                <div class="form-row">
                    <table style="width: 100%;">
                        <tr>  
                            <%--<td> <asp:Label ID="Label2" runat="server" Text="FECHA INICIO" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                                <input class="formularioProc" placeholder="NOMBRE O APELLIDO" id="Text1" type="date" runat="server"  AutoPostBack="true"/>                           
                            </td>
                            <td><asp:Label ID="Label1" runat="server" Text="FECHA FINAL" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                                <input class="formularioProc" placeholder="NOMBRE O APELLIDO" id="Correo" type="date" runat="server"  AutoPostBack="true"/>                            
                            </td>--%>
                            <td><asp:Label ID="Label4" runat="server" Text="ESTADO" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                                <asp:DropDownList ID="DropDownList1" runat="server" class="formularioProc" DataSourceID="SqlDataSource2" DataTextField="Status" DataValueField="Status"></asp:DropDownList>
                                <asp:SqlDataSource runat="server" ID="SqlDataSource2" ConnectionString='<%$ ConnectionStrings:affisDBConnectionString %>' SelectCommand="SELECT DISTINCT [Status] FROM [Pagos] WHERE ([Status] IS NOT NULL)"></asp:SqlDataSource>
                            </td>
                            <td><asp:Label ID="Label3" runat="server" Text="GENERAR" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                                <asp:Button runat="server" CssClass="botonsubmitTRESDOS" text="GENERAR REPORTE" OnClick="Unnamed_Click1"></asp:Button>                                
                            </td>                            
                        </tr>
                    </table> 
                    <hr />
                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" AllowPaging="True" GridLines="None" BackColor="White" BorderStyle="None" BorderWidth="1px" CellPadding="20" ForeColor="Black" CssClass="mGrid" PagerStyle-CssClass="pgr" margin-left="2%" AlternatingRowStyle-CssClass="alt" AllowSorting="True" DataSourceID="SqlDataSource1">
                        <Columns>

                            <asp:BoundField DataField="RazonSocial" HeaderText="Razon Social" SortExpression="RazonSocial"></asp:BoundField>
                            <asp:BoundField DataField="MesFacturacion" HeaderText="Mes" SortExpression="MesFacturacion"></asp:BoundField>
                            <asp:BoundField DataField="ValorFactura" HeaderText="Valor Factura" SortExpression="ValorFactura"></asp:BoundField>
                            <asp:BoundField DataField="ValorTransf" HeaderText="Valor Pago" SortExpression="ValorTransf"></asp:BoundField>
                            <asp:BoundField DataField="Deuda" HeaderText="Deuda" SortExpression="Deuda"></asp:BoundField>
                            <asp:BoundField DataField="Status" HeaderText="Estado" SortExpression="Status"></asp:BoundField>
                            <asp:BoundField DataField="FechaTransf" HeaderText="Fecha" SortExpression="FechaTransf"></asp:BoundField>
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
                    <asp:SqlDataSource runat="server" ID="SqlDataSource1" ConnectionString='<%$ ConnectionStrings:affisDBConnectionString %>' SelectCommand="SELECT [RazonSocial], [MesFacturacion], [ValorFactura], [ValorTransf], [Deuda], [Status], [FechaTransf] FROM [Pagos] WHERE Status = @Status">
                        <SelectParameters>                                
                            <%--<asp:CookieParameter CookieName="paramIni" Name="fechaini" Type="String"></asp:CookieParameter> 
                            <asp:CookieParameter CookieName="paramFin" Name="fechafin" Type="String"></asp:CookieParameter> --%>
                            <asp:CookieParameter CookieName="parampag" Name="Status" Type="String"></asp:CookieParameter> 
                        </SelectParameters>
                    </asp:SqlDataSource>
                </div>
            

            </div>
        </div>
        </div>
    
</asp:Content>
