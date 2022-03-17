<%@ Page Title="Tarrago Reach System" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ReporteCobranzaTomador.aspx.cs" Inherits="ReachSystem.ReporteCobranzaTomador" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server"> 
    <div class="container">
    <div class="card">
        <div class="card-header">
                <div class="form-row">
                    <div class="col10L">                        
                        <asp:Label ID="Label6" runat="server" Text="REPORTE: COBRANZA TOMADOR" Style="font-weight: bold; font-size: 18px;"></asp:Label>                        
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
                            <td><asp:Label ID="Label4" runat="server" Text="ESTADO" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                                <asp:DropDownList ID="DropDownList1" runat="server" class="formularioProc" DataSourceID="SqlDataSource2" DataTextField="Estado" DataValueField="Estado">
                                </asp:DropDownList>
                                <asp:SqlDataSource runat="server" ID="SqlDataSource2" ConnectionString='<%$ ConnectionStrings:affisDBConnectionString %>' SelectCommand="SELECT DISTINCT [Estado] FROM [Asegurados]"></asp:SqlDataSource>
                            </td>
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
                            <asp:BoundField DataField="Nombre" HeaderText="TOMADOR" SortExpression="Nombre"></asp:BoundField>                            
                            <asp:BoundField DataField="EstadoCert" HeaderText="ESTADO" SortExpression="EstadoCert"></asp:BoundField>
                            <asp:BoundField DataField="NumeroCertificado" HeaderText="CERTIFICADO" SortExpression="NumeroCertificado"></asp:BoundField>  
                            <asp:BoundField DataField="MedioDeCobro" HeaderText="MEDIO DE COBRO" SortExpression="MedioDeCobro"></asp:BoundField>  
                            <asp:BoundField DataField="Prima" HeaderText="PRIMA" SortExpression="Prima"></asp:BoundField>     
                            <asp:BoundField DataField="MesesDeuda" HeaderText="MESES DEUDA" SortExpression="MesesDeuda"></asp:BoundField> 
                            <asp:BoundField DataField="TotalCobrar" HeaderText="TOTAL" SortExpression="TotalCobrar"></asp:BoundField> 
                            <asp:BoundField DataField="Estado" HeaderText="RESULTADO COBRANZA" SortExpression="Estado"></asp:BoundField>
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
                    <asp:SqlDataSource runat="server" ID="SqlDataSource1" ConnectionString='<%$ ConnectionStrings:affisDBConnectionString %>' SelectCommand="select distinct a.Nombre, count(a.NumeroCertificado) over(partition by a.NumeroCertificado) MesesDeuda, a.Total as Prima, a.NumeroCertificado, Total * count(a.NumeroCertificado) over(partition by a.NumeroCertificado) as TotalCobrar, b.NombreComercial, b.MedioDeCobro, b.Estado as EstadoCert,case when a.Mes = '' then 'PAGADO' else 'MOROSO' END AS Estado, c.Clase, c.Poliza from Morosos a left join Asegurados b on a.NumeroCertificado = b.NumeroCertificado left join Empresa c on b.NombreComercial = c.NombreComercial left join Cierres d on c.NombreComercial = d.Empresa where d.Fecha BETWEEN @fechaini AND @fechafin and b.Estado = @ven group by a.Nombre, a.NumeroCertificado, a.Total, b.NombreComercial, b.MedioDeCobro, a.Mes, b.Estado, c.clase, c.poliza"> 
                        <SelectParameters>                                
                            <asp:CookieParameter CookieName="paramIni" Name="fechaini" Type="String"></asp:CookieParameter> 
                            <asp:CookieParameter CookieName="paramFin" Name="fechafin" Type="String"></asp:CookieParameter> 
                            <asp:CookieParameter CookieName="paramVEN" Name="ven" Type="String"></asp:CookieParameter>                            
                        </SelectParameters>
                    </asp:SqlDataSource>
                    <%--<hr />
                     <asp:Label ID="Label5" runat="server" Style="font-weight: bold; font-size: 18px; margin-left:52%; color:green;"></asp:Label>--%>
                    
                    <hr />
                    <center>
                        <asp:Button  value="REGISTRARME" type="submit" runat="server" CssClass="botonsubmitTRES" Text="CANCELAR" OnClick="Unnamed_Click" UseSubmitBehavior="False" />  
                        <Button  value="REGISTRARME" type="submit" runat="server" Class="botonsubmitCUATRO" ID="Button3" OnServerClick="descarga1" UseSubmitBehavior="False" >EXPORTAR <i class="fa fa-file-excel-o"></i></Button></center>  
                    
                </div>
            

            </div>
        </div>
        </div>

</asp:Content>
