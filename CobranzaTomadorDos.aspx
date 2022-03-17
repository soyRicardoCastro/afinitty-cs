<%@ Page Title="Tarrago Reach System" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CobranzaTomadorDos.aspx.cs" Inherits="ReachSystem.CobranzaTomadorDos" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server"> 
    <div class="container">
    <div class="card">
        <div class="card-header">
                <div class="form-row">
                    <div class="col10L">                        
                        <asp:Label ID="Label6" runat="server" Text="COBRANZAS: GESTION TOMADOR" Style="font-weight: bold; font-size: 18px;"></asp:Label>                        
                    </div>                   
                </div>
            </div>
        <div class="card-body">
                <div class="form-row">
    <%--<center><input class="formulario" placeholder="Cedula" id="Correo" type="text" runat="server"  AutoPostBack="true"/>
        <asp:Button class="botonsubmit" value="REGISTRARME" type="submit" runat="server" CssClass="botonsubmit" Text="BASE INTERNA"  OnClick="Unnamed1_Click"/></center> --%>   
                    
                    <%--<hr />--%>
                    <asp:Label ID="Label2" runat="server"  Style="font-weight: bold; font-size: 18px;"></asp:Label>                        
                    <asp:Label ID="Label1" runat="server" Style="font-weight: bold; font-size: 18px;"></asp:Label> 
                    <asp:GridView ID="GridView2" runat="server" DataSourceID="SqlDataSource1" AutoGenerateColumns="False" AllowPaging="True" GridLines="None" BackColor="White" BorderStyle="None" BorderWidth="1px" CellPadding="20" ForeColor="Black"  CssClass="mGrid" PagerStyle-CssClass="pgr" margin-left="2%" AlternatingRowStyle-CssClass="alt" AllowSorting="True" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                        <Columns>                            
                            <asp:BoundField DataField="NombreComercial" HeaderText="EMPRESA" SortExpression="NombreComercial"></asp:BoundField>
                            <asp:BoundField DataField="MedioDeCobro" HeaderText="MEDIO DE COBRO" SortExpression="MedioDeCobro"></asp:BoundField>
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
                    <asp:SqlDataSource runat="server" ID="SqlDataSource2" ConnectionString='<%$ ConnectionStrings:affisDBConnectionString %>' SelectCommand="Select Cedula, Nombre, TotalCobrar, NumeroCertificado, Estado from Asegurados where (NombreComercial = @NombreComercial and Estado = 'VENTA' AND FechaVenta < @MesGuia) OR (NombreComercial = @NombreComercial and Estado = 'EXCLUIDO' AND FechaRet > @MesGuia)">
                        <SelectParameters>
                            <asp:CookieParameter CookieName="empresaadC" Name="NombreComercial" Type="String"></asp:CookieParameter>       
                            <asp:CookieParameter CookieName="empresmesguiaC" Name="MesGuia" Type="DateTime"></asp:CookieParameter> 
                        </SelectParameters>
                    </asp:SqlDataSource>
                    <hr />
                    <table style="width: 100%;">
                        <tr>
                            <td><center><asp:Label ID="Label5" runat="server"  text="Prima Ventas" Style="font-weight: bold; font-size: 18px;"></asp:Label></center></td>
                            <td><center><asp:Label ID="Label7" runat="server"  text="Prima Exclusiones" Style="font-weight: bold; font-size: 18px;"></asp:Label></center></td>
                            
                        </tr>
                        <tr>
                            <td><center><asp:Label ID="Label3" runat="server"  Style="font-weight: bold; font-size: 22px;  color:green"></asp:Label></center></td>
                            <td><center><asp:Label ID="Label4" runat="server"  Style="font-weight: bold; font-size: 22px; color:red"></asp:Label></center></td>
                            
                        </tr>
                        
                    </table>

                    <hr />
                    
                    <asp:GridView ID="GridView1" runat="server" DataSourceID="SqlDataSource2" AutoGenerateColumns="False" AllowPaging="True" GridLines="None" BackColor="White" BorderStyle="None" BorderWidth="1px" CellPadding="20" ForeColor="Black"  CssClass="mGrid" PagerStyle-CssClass="pgr" margin-left="2%" AlternatingRowStyle-CssClass="alt" AllowSorting="True" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                        <Columns>                            
                            <asp:BoundField DataField="Cedula" HeaderText="CEDULA" SortExpression="Cedula"></asp:BoundField>
                            <asp:BoundField DataField="Nombre" HeaderText="TOMADOR" SortExpression="Nombre"></asp:BoundField>
                            <asp:BoundField DataField="TotalCobrar" HeaderText="PRIMA" SortExpression="TotalCobrar"></asp:BoundField>
                            <asp:BoundField DataField="NumeroCertificado" HeaderText="CERTIFICADO" SortExpression="NumeroCertificado"></asp:BoundField>
                            <asp:BoundField DataField="Estado" HeaderText="ESTADO" SortExpression="Estado"></asp:BoundField>
                            <asp:CommandField ShowSelectButton="True" ButtonType="Button" SelectText="NOTIFICAR"></asp:CommandField>
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
