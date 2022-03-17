<%@ Page Title="Tarrago Reach System" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ReporteCobertEmp.aspx.cs" Inherits="ReachSystem.ReporteCobertEmp" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server"> 
    <div class="container">
    <div class="card">
        <div class="card-header">
                <div class="form-row">
                    <div class="col10L">                        
                        <asp:Label ID="Label6" runat="server" Text="REPORTE: PRIMA POR EMPRESA" Style="font-weight: bold; font-size: 18px;"></asp:Label>                        
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
                            <td><asp:Label ID="Label1" runat="server" Text="FECHA FINAL" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                                <input class="formularioProc" placeholder="NOMBRE O APELLIDO" id="Correo" type="date" runat="server"  AutoPostBack="true"/>                            
                            </td>
                          <%--  <td><asp:Label ID="Label4" runat="server" Text="EJECUTIVO" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                                <asp:DropDownList ID="DropDownList1" runat="server" class="formularioProc" DataSourceID="SqlDataSource2" DataTextField="Ejecutivo" DataValueField="Ejecutivo"></asp:DropDownList>
                                <asp:SqlDataSource runat="server" ID="SqlDataSource2" ConnectionString='<%$ ConnectionStrings:affisDBConnectionString %>' SelectCommand="SELECT DISTINCT [Ejecutivo] FROM [Asegurados] WHERE ([Estado] = 'VENTA')"></asp:SqlDataSource>
                            </td>--%>
                            <td><asp:Label ID="Label3" runat="server" Text="GENERAR" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                                <asp:Button runat="server" CssClass="botonsubmitTRESDOS" text="GENERAR REPORTE" OnClick="Unnamed_Click1"></asp:Button>                                
                            </td>                            
                        </tr>
                    </table> 
                    <hr />
                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" AllowPaging="True" GridLines="None" BackColor="White" BorderStyle="None" BorderWidth="1px" CellPadding="20" ForeColor="Black" CssClass="mGrid" PagerStyle-CssClass="pgr" margin-left="2%" AlternatingRowStyle-CssClass="alt" AllowSorting="True" DataSourceID="SqlDataSource1">
                        <Columns>

                            <asp:BoundField DataField="NombreComercial" HeaderText="Empresa" SortExpression="NombreComercial"></asp:BoundField>
                            <%--<asp:BoundField DataField="Relacion" HeaderText="Relacion" SortExpression="Relacion"></asp:BoundField>
                            <asp:BoundField DataField="Producto" HeaderText="Producto" SortExpression="Producto"></asp:BoundField>
                            <asp:BoundField DataField="Plan" HeaderText="Plan" SortExpression="Plan"></asp:BoundField>--%>
                            <asp:BoundField DataField="TotaL" HeaderText="Total" SortExpression="TotaL"></asp:BoundField>
                            <%--<asp:BoundField DataField="NumeroCertificado" HeaderText="Numero Certificado" SortExpression="NumeroCertificado"></asp:BoundField>--%>
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
                    <asp:SqlDataSource runat="server" ID="SqlDataSource1" ConnectionString='<%$ ConnectionStrings:affisDBConnectionString %>' SelectCommand="select NombreComercial, sum(TotalCobrar) as Total from Asegurados WHERE ([NumeroCertificado] IS NOT NULL) AND fechaventa BETWEEN @fechaini AND @fechafin group by NombreComercial">
                        <SelectParameters>                                
                            <asp:CookieParameter CookieName="paramIni" Name="fechaini" Type="String"></asp:CookieParameter> 
                            <asp:CookieParameter CookieName="paramFin" Name="fechafin" Type="String"></asp:CookieParameter> 
                            <%--<asp:CookieParameter CookieName="paramVEN" Name="est" Type="String"></asp:CookieParameter> --%>
                        </SelectParameters>
                    </asp:SqlDataSource>
                </div>
            

            </div>
        </div>
        </div>

</asp:Content>
