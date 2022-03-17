<%@ Page Title="Tarrago Reach System" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ConsMorososDos.aspx.cs" Inherits="ReachSystem.ConsMorososDos" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server"> 
    <div class="container">
    <div class="card">
        <div class="card-header">
                <div class="form-row">
                    <div class="col10L">                        
                        <asp:Label ID="Label6" runat="server" Text="COBRANZAS: GESTION TOMADOR (IMPAGOS)" Style="font-weight: bold; font-size: 18px;"></asp:Label>                        
                    </div>                   
                </div>
            </div>
        <div class="card-body">
                <div class="form-row">
    <%--<center><input class="formulario" placeholder="Cedula" id="Correo" type="text" runat="server"  AutoPostBack="true"/>
        <asp:Button class="botonsubmit" value="REGISTRARME" type="submit" runat="server" CssClass="botonsubmit" Text="BASE INTERNA"  OnClick="Unnamed1_Click"/></center> --%>   
                    
                    <%--<hr />--%>
                    <asp:Label ID="Label1" runat="server" Style="font-weight: bold; font-size: 18px;"></asp:Label> 
                    <asp:GridView ID="GridView2" runat="server" DataSourceID="SqlDataSource1" AutoGenerateColumns="False" AllowPaging="True" GridLines="None" BackColor="White" BorderStyle="None" BorderWidth="1px" CellPadding="20" ForeColor="Black"  CssClass="mGrid" PagerStyle-CssClass="pgr" margin-left="2%" AlternatingRowStyle-CssClass="alt" AllowSorting="True" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                        <Columns>                            
                            <asp:BoundField DataField="NombreComercial" HeaderText="Nombre Comercial" SortExpression="NombreComercial"></asp:BoundField>
                            <asp:BoundField DataField="MedioDeCobro" HeaderText="Medio De Cobro" SortExpression="MedioDeCobro"></asp:BoundField>
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
                    <asp:SqlDataSource runat="server" ID="SqlDataSource2" ConnectionString='<%$ ConnectionStrings:affisDBConnectionString %>' SelectCommand="Select * From Morosos where Empresa = @NombreComercial and Mes <> ''">
                        <SelectParameters>
                            <asp:CookieParameter CookieName="empresaadC" Name="NombreComercial" Type="String"></asp:CookieParameter>                            
                        </SelectParameters>
                    </asp:SqlDataSource>

                   <%-- <asp:GridView ID="GridView3" runat="server" DataSourceID="SqlDataSource3" AutoGenerateColumns="False" AllowPaging="True" GridLines="None" BackColor="White" BorderStyle="None" BorderWidth="1px" CellPadding="20" ForeColor="Black"  CssClass="mGrid" PagerStyle-CssClass="pgr" margin-left="2%" AlternatingRowStyle-CssClass="alt" AllowSorting="True" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                        <Columns>
                            
                         <%--   <asp:BoundField DataField="CeUDla" HeaderText="Cedula" SortExpression="CeUDla"></asp:BoundField>--%>
                           <%-- <asp:BoundField DataField="Nombre" HeaderText="Nombres Completos" SortExpression="Nombre"></asp:BoundField>
                            <asp:BoundField DataField="TotalPrima" HeaderText="Total Prima" SortExpression="TotalPrima"></asp:BoundField>
                            <asp:BoundField DataField="NumeroCertificado" HeaderText="Certificado" SortExpression="NumeroCertificado"></asp:BoundField>
                            <asp:BoundField DataField="Meses" HeaderText="Meses" SortExpression="Meses"></asp:BoundField>--%>
                            <%--<asp:CommandField ShowSelectButton="True" ButtonType="Button" SelectText="PAGAR"></asp:CommandField>--%>
                            <%--<asp:BoundField DataField="Empresa" HeaderText="Empresa" SortExpression="Empresa"></asp:BoundField>--%>
                        <%--</Columns>
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
                    <asp:SqlDataSource runat="server" ID="SqlDataSource3" ConnectionString='<%$ ConnectionStrings:affisDBConnectionString %>' SelectCommand="Select b.Nombre, a.NumeroCertificado, SUM(a.Total) as TotalPrima, COUNT(a.NumeroCertificado) as Meses from Morosos a JOIN Asegurados b ON a.NumeroCertificado = b.NumeroCertificado where a.Empresa = @NombreComercial group by a.NumeroCertificado, b.Nombre">
                        <SelectParameters>
                            <asp:CookieParameter CookieName="empresaadC" Name="NombreComercial" Type="String"></asp:CookieParameter>                            
                        </SelectParameters>
                    </asp:SqlDataSource>--%>
                    
                    <asp:GridView ID="GridView1" runat="server" DataSourceID="SqlDataSource2" AutoGenerateColumns="False" AllowPaging="True" GridLines="None" BackColor="White" BorderStyle="None" BorderWidth="1px" CellPadding="20" ForeColor="Black"  CssClass="mGrid" PagerStyle-CssClass="pgr" margin-left="2%" AlternatingRowStyle-CssClass="alt" AllowSorting="True" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                        <Columns>
                            
                            <asp:BoundField DataField="CeUDla" HeaderText="Cedula" SortExpression="CeUDla"></asp:BoundField>
                            <asp:BoundField DataField="Nombre" HeaderText="Nombres Completos" SortExpression="Nombre"></asp:BoundField>
                            <asp:BoundField DataField="Total" HeaderText="Prima" SortExpression="Total"></asp:BoundField>
                            <asp:BoundField DataField="NumeroCertificado" HeaderText="Certificado" SortExpression="NumeroCertificado"></asp:BoundField>
                            <asp:BoundField DataField="Mes" HeaderText="Mes" SortExpression="Mes"></asp:BoundField>
                            <asp:CommandField ShowSelectButton="True" ButtonType="Button" SelectText="PAGAR"></asp:CommandField>
                            <%--<asp:BoundField DataField="Empresa" HeaderText="Empresa" SortExpression="Empresa"></asp:BoundField>--%>
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
                    <asp:SqlDataSource runat="server" ID="SqlDataSource1" ConnectionString='<%$ ConnectionStrings:affisDBConnectionString %>' SelectCommand="SELECT [NombreComercial], [MedioDeCobro] FROM [Empresa] WHERE ([NombreComercial] = @NombreComercial)">
                        <SelectParameters>
                            <asp:CookieParameter CookieName="empresaadC" Name="NombreComercial" Type="String"></asp:CookieParameter>                            
                        </SelectParameters>
                    </asp:SqlDataSource>
                    <hr />
                                            
                    <CENTER><%--<asp:Button runat="server" CssClass="botonsubmitTRES" text="VOLVER" OnClick="Unnamed_Click1" UseSubmitBehavior="False"></asp:Button>  --%>
                    <asp:Button  value="REGISTRARME" type="submit" runat="server" CssClass="botonsubmitTRES" Text="CANCELAR" OnClick="Unnamed_Click" UseSubmitBehavior="False" />                          
                        <asp:Button  value="REGISTRARME" type="submit" runat="server" CssClass="botonsubmitTRES" Text="VOLVER" OnClick="Unnamed2_Click" UseSubmitBehavior="False" />
                        <%--<asp:Button ID="INCLU" value="REGISTRARME" type="submit" runat="server" CssClass="botonsubmitDOS" Text="INCLUIR" OnClick="Unnamed2_Click"/>--%>   
                    </CENTER>
                </div>
            </div>
        </div>
        </div>
    
</asp:Content>
