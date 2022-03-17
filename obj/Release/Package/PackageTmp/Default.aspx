<%@ Page Title="AFFINITY" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ReachSystem._Default" %>

<%@ Register Assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" Namespace="System.Web.UI.DataVisualization.Charting" TagPrefix="asp" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server"> 
    <div class="container">
    <div class="card">
        <div class="card-header">
                <div class="form-row">
                    <div class="col10L">                        
                        <asp:Label ID="Label6" runat="server" Text="DASHBOARD" Style="font-weight: bold; font-size: 18px;"></asp:Label>                        
                    </div>                   
                </div>
            </div>
        <div class="card-body">
                <div class="form-row">
                    <div runat="server" id="paleta1">
                    <asp:Label ID="Label8" runat="server" Text="VENTAS AÑO EN CURSO" Style="font-weight: bold; font-size: 18px; color:red;"></asp:Label>
                    <hr />
                    <table style="width: 100%;" ID="TABLA1" runat="server">
                        <tr>
                            <td>
                                <asp:Label ID="Label1" runat="server" Text="GRAFICA: EJECUTIVO/CANTIDAD" Style="font-weight: bold; font-size: 18px;"></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="Label2" runat="server" Text="GRAFICA: EJECUTIVO/MONTO" Style="font-weight: bold; font-size: 18px;"></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="Label3" runat="server" Text="GRAFICA: GENERO/CANTIDAD" Style="font-weight: bold; font-size: 18px;"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Chart ID="Chart1" runat="server" DataSourceID="SqlDataSource1">
                                    <Series>
                                        <asp:Series Name="Series1" XValueMember="Ejecutivo" YValueMembers="TotalQuantity"></asp:Series>
                                    </Series>
                                    <ChartAreas>
                                        <asp:ChartArea Name="ChartArea1"></asp:ChartArea>
                                    </ChartAreas>
                                </asp:Chart>
                                <asp:SqlDataSource runat="server" ID="SqlDataSource1" ConnectionString='<%$ ConnectionStrings:affisDBConnectionString %>' SelectCommand="SELECT Ejecutivo, COUNT(Numerocertificado) AS TotalQuantity FROM Asegurados GROUP BY Ejecutivo order by TotalQuantity DESC"></asp:SqlDataSource>
                            </td>
                            <td>
                                <asp:Chart ID="Chart4" runat="server" DataSourceID="SqlDataSource4">
                                    <Series>
                                        <asp:Series Name="Series1" XValueMember="Ejecutivo" YValueMembers="TotalQuantity" ChartType="Bar" Palette="Fire"></asp:Series>
                                    </Series>
                                    <ChartAreas>
                                        <asp:ChartArea Name="ChartArea1"></asp:ChartArea>
                                    </ChartAreas>
                                </asp:Chart>
                                <asp:SqlDataSource runat="server" ID="SqlDataSource4" ConnectionString='<%$ ConnectionStrings:affisDBConnectionString %>' SelectCommand="SELECT Ejecutivo, SUM(TotalCobrar) AS TotalQuantity FROM Asegurados GROUP BY Ejecutivo order by TotalQuantity DESC"></asp:SqlDataSource>
                            </td>
                            <td>
                                <asp:Chart ID="Chart3" runat="server" DataSourceID="SqlDataSource3">
                                    <Series>
                                        <asp:Series Name="Series1" XValueMember="Genero" YValueMembers="TotalQuantity" ChartType="Bar" Palette="Berry"></asp:Series>
                                    </Series>
                                    <ChartAreas>
                                        <asp:ChartArea Name="ChartArea1"></asp:ChartArea>
                                    </ChartAreas>
                                </asp:Chart>
                                <asp:SqlDataSource runat="server" ID="SqlDataSource3" ConnectionString='<%$ ConnectionStrings:affisDBConnectionString %>' SelectCommand="SELECT Genero, COUNT(Genero) AS TotalQuantity FROM Dependientes GROUP BY Genero order by TotalQuantity DESC"></asp:SqlDataSource>
                            </td>
                        </tr>
                        <%--<tr>
                            <td>
                                <asp:Label ID="Label4" runat="server" Text="GRAFICA: COBERTURA/CANTIDAD" Style="font-weight: bold; font-size: 18px;"></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="Label5" runat="server" Text="GRAFICA: COBERTURA/MONTO" Style="font-weight: bold; font-size: 18px;"></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="Label7" runat="server" Text="GRAFICA: RELACION/MONTO" Style="font-weight: bold; font-size: 18px;"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Chart ID="Chart2" runat="server" DataSourceID="SqlDataSource2">
                                    <Series>
                                        <asp:Series Name="Series1" XValueMember="Producto" YValueMembers="TotalQuantity" ChartType="Bar" Palette="SeaGreen"></asp:Series>
                                    </Series>
                                    <ChartAreas>
                                        <asp:ChartArea Name="ChartArea1"></asp:ChartArea>
                                    </ChartAreas>
                                </asp:Chart>
                                <asp:SqlDataSource runat="server" ID="SqlDataSource2" ConnectionString='<%$ ConnectionStrings:affisDBConnectionString %>' SelectCommand="SELECT Producto, COUNT(Producto) AS TotalQuantity FROM Dependientes GROUP BY Producto order by TotalQuantity ASC"></asp:SqlDataSource>                                
                            </td>
                            <td>
                                <asp:Chart ID="Chart5" runat="server" DataSourceID="SqlDataSource5">
                                    <Series>
                                        <asp:Series Name="Series1" XValueMember="Producto" YValueMembers="TotalQuantity" ChartType="Bar" Palette="Bright"></asp:Series>
                                    </Series>
                                    <ChartAreas>
                                        <asp:ChartArea Name="ChartArea1"></asp:ChartArea>
                                    </ChartAreas>
                                </asp:Chart>
                                <asp:SqlDataSource runat="server" ID="SqlDataSource5" ConnectionString='<%$ ConnectionStrings:affisDBConnectionString %>' SelectCommand="SELECT Producto, SUM(TotalPrima) AS TotalQuantity FROM Dependientes GROUP BY Producto order by TotalQuantity ASC"></asp:SqlDataSource>
                            </td>
                            <td>
                                <asp:Chart ID="Chart6" runat="server" DataSourceID="SqlDataSource6">
                                    <Series>
                                        <asp:Series Name="Series1" XValueMember="Relacion" YValueMembers="TotalQuantity" ChartType="Bar" Palette="Berry"></asp:Series>
                                    </Series>
                                    <ChartAreas>
                                        <asp:ChartArea Name="ChartArea1"></asp:ChartArea>
                                    </ChartAreas>
                                </asp:Chart>
                                <asp:SqlDataSource runat="server" ID="SqlDataSource6" ConnectionString='<%$ ConnectionStrings:affisDBConnectionString %>' SelectCommand="SELECT Relacion, SUM(TotalPrima) AS TotalQuantity FROM Dependientes GROUP BY Relacion order by TotalQuantity DESC"></asp:SqlDataSource>
                            </td>
                        </tr>   --%>                     
                    </table>
                        </div>
                    <div id="paleta2" runat="server">
                    <hr />
                    <asp:Label ID="Label9" runat="server" Text="VENTAS MES EN CURSO" Style="font-weight: bold; font-size: 18px; color:red;"></asp:Label>
                    <hr />
                    <table style="width: 100%;">
                        <tr>
                            <td>
                                <asp:Label ID="Label10" runat="server" Text="GRAFICA: EJECUTIVO/CANTIDAD" Style="font-weight: bold; font-size: 18px;"></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="Label11" runat="server" Text="GRAFICA: EJECUTIVO/MONTO" Style="font-weight: bold; font-size: 18px;"></asp:Label>
                            </td>                            
                        </tr>
                        <tr>
                            <td>
                                <asp:Chart ID="Chart7" runat="server" DataSourceID="SqlDataSource7">
                                    <Series>
                                        <asp:Series Name="Series1" XValueMember="EJECUTIVO" YValueMembers="TotalQuantity"></asp:Series>
                                    </Series>
                                    <ChartAreas>
                                        <asp:ChartArea Name="ChartArea1"></asp:ChartArea>
                                    </ChartAreas>
                                </asp:Chart>
                                <asp:SqlDataSource runat="server" ID="SqlDataSource7" ConnectionString='<%$ ConnectionStrings:affisDBConnectionString %>' SelectCommand="SELECT Ejecutivo, COUNT(Nombre) AS TotalQuantity FROM Asegurados WHERE MONTH(FechaVenta) = MONTH(getdate()) AND YEAR(FechaVenta) = YEAR(GETDATE()) GROUP BY Ejecutivo order by TotalQuantity DESC"></asp:SqlDataSource>
                            </td>
                            <td>
                                <asp:Chart ID="Chart8" runat="server" DataSourceID="SqlDataSource8">
                                    <Series>
                                        <asp:Series Name="Series1" XValueMember="Ejecutivo" YValueMembers="TotalQuantity" ChartType="Bar" Palette="SeaGreen"></asp:Series>
                                    </Series>
                                    <ChartAreas>
                                        <asp:ChartArea Name="ChartArea1"></asp:ChartArea>
                                    </ChartAreas>
                                </asp:Chart>
                                <asp:SqlDataSource runat="server" ID="SqlDataSource8" ConnectionString='<%$ ConnectionStrings:affisDBConnectionString %>' SelectCommand="SELECT Ejecutivo, SUM(TotalCobrar) AS TotalQuantity FROM Asegurados WHERE MONTH(FechaVenta) = MONTH(getdate()) AND YEAR(FechaVenta) = YEAR(GETDATE()) GROUP BY Ejecutivo order by TotalQuantity DESC"></asp:SqlDataSource>
                            </td>                           
                        </tr>
                        </table>
                        </div>
                    <div runat="server" id="paleta3">
                    <hr />
                    <asp:Label ID="Label4" runat="server" Text="RECLAMOS" Style="font-weight: bold; font-size: 18px; color:red;"></asp:Label>
                    <hr />
                    <table>
                        <tr>
                            <td>
                                <asp:Label ID="Label50" runat="server" Text="GRAFICA: RECLAMOS MONTO/EMPRESA" Style="font-weight: bold; font-size: 18px;"></asp:Label>
                                
                            </td>
                            <td>
                                <%--<asp:Label ID="Label51" runat="server" Text="GRAFICA: COBERTURA/MONTO" Style="font-weight: bold; font-size: 18px;"></asp:Label>--%>
                            </td>                            
                        </tr>     
                        <tr>
                            <td>
                                <asp:Chart ID="Chart9" runat="server" DataSourceID="SqlDataSource15">
                                    <Series>
                                        <asp:Series Name="Series1" XValueMember="Entidad" YValueMembers="Monto"></asp:Series>
                                    </Series>
                                    <ChartAreas>
                                        <asp:ChartArea Name="ChartArea1"></asp:ChartArea>
                                    </ChartAreas>
                                </asp:Chart>
                                <asp:SqlDataSource runat="server" ID="SqlDataSource15" ConnectionString='<%$ ConnectionStrings:affisDBConnectionString %>' SelectCommand="SELECT Entidad, SUM(PagoAseg) AS Monto FROM Reclamos WHERE MONTH(FechaPagoCli) = MONTH(getdate()) AND YEAR(FechaPagoCli) = YEAR(GETDATE()) GROUP BY Entidad order by Monto DESC"></asp:SqlDataSource>
                            </td>
                            <td>

                            </td>
                        </tr>
                    </table>
                    </div>
                     <hr />
                    <asp:Label ID="Label12" runat="server" text="MENSUAL DE VENTAS" Style="font-weight: bold; font-size: 18px; color:red;"></asp:Label> 
                    <hr />
                    <asp:GridView ID="GridView1" runat="server" DataSourceID="SqlDataSource9" AutoGenerateColumns="False" AllowPaging="True" GridLines="None" BackColor="White" BorderStyle="None" BorderWidth="1px" CellPadding="20" ForeColor="Black"  CssClass="mGrid" PagerStyle-CssClass="pgr" margin-left="2%" AlternatingRowStyle-CssClass="alt" AllowSorting="True" >
                        <Columns>                            
                            <asp:BoundField DataField="Ejecutivo" HeaderText="EJECUTIVO" SortExpression="Ejecutivo"></asp:BoundField>
                            <asp:BoundField DataField="TotalQuantity" HeaderText="CERTIFICADOS" SortExpression="TotalQuantity"></asp:BoundField>
                            <asp:BoundField DataField="Total" HeaderText="TOTAL $" SortExpression="TOTAL"></asp:BoundField>                            
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
                    <asp:SqlDataSource runat="server" ID="SqlDataSource9" ConnectionString='<%$ ConnectionStrings:affisDBConnectionString %>' SelectCommand="SELECT Ejecutivo, COUNT(Nombre) AS TotalQuantity, SUM(TotalCobrar) AS Total FROM Asegurados WHERE MONTH(FechaVenta) = MONTH(getdate()) AND YEAR(FechaVenta) = YEAR(GETDATE()) AND Estado <> 'EXCLUIDO' GROUP BY Ejecutivo order by TotalQuantity DESC">                       
                    </asp:SqlDataSource>
                     <%--<hr />
                    <asp:Label ID="Label15" runat="server" text="COBRANZAS DETALLE" Style="font-weight: bold; font-size: 18px;"></asp:Label> 
                    <hr />
                    <asp:GridView ID="GridView2" runat="server" DataSourceID="SqlDataSource10" AutoGenerateColumns="False" AllowPaging="True" GridLines="None" BackColor="White" BorderStyle="None" BorderWidth="1px" CellPadding="20" ForeColor="Black"  CssClass="mGrid" PagerStyle-CssClass="pgr" margin-left="2%" AlternatingRowStyle-CssClass="alt" AllowSorting="True" >
                        <Columns>                            
                            <asp:BoundField DataField="NombreComercial" HeaderText="ENTIDAD TOMADORA" SortExpression="NombreComercial"></asp:BoundField>
                            <asp:BoundField DataField="TotalQuantity" HeaderText="TOMADORES" SortExpression="TotalQuantity"></asp:BoundField>
                            <asp:BoundField DataField="Total" HeaderText="Total $" SortExpression="TOTAL"></asp:BoundField>                            
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
                    <asp:SqlDataSource runat="server" ID="SqlDataSource10" ConnectionString='<%$ ConnectionStrings:affisDBConnectionString %>' SelectCommand="SELECT NombreComercial, COUNT(Nombre) AS TotalQuantity, SUM(TotalCobrar) AS Total FROM Asegurados WHERE MONTH(FechaVenta) = MONTH(getdate()) AND YEAR(FechaVenta) = YEAR(GETDATE()) GROUP BY NombreComercial order by TotalQuantity DESC">                       
                    </asp:SqlDataSource>--%>
                    <hr />
                     <asp:Label ID="Label13" runat="server" text="RETENCIONES" Style="font-weight: bold; font-size: 18px; color:red;"></asp:Label> 
                    <hr />
                    <asp:GridView ID="GridView3" runat="server" DataSourceID="SqlDataSource11" AutoGenerateColumns="False" AllowPaging="True" GridLines="None" BackColor="White" BorderStyle="None" BorderWidth="1px" CellPadding="20" ForeColor="Black"  CssClass="mGrid" PagerStyle-CssClass="pgr" margin-left="2%" AlternatingRowStyle-CssClass="alt" AllowSorting="True">
                        <Columns>

                            <asp:BoundField DataField="FechaRet" HeaderText="FECHA ASIGNACION" SortExpression="FechaRet"></asp:BoundField>
                            <asp:BoundField DataField="NombreComercial" HeaderText="EMPRESA" SortExpression="NombreComercial"></asp:BoundField>
                            <asp:BoundField DataField="Nombre" HeaderText="TOMADOR" SortExpression="Nombre"></asp:BoundField>   
                            <asp:BoundField DataField="NumeroCertificado" HeaderText="CERTIFICADO" SortExpression="NumeroCertificado"></asp:BoundField>                                                                                 
                            <asp:BoundField DataField="Responsable" HeaderText="RESPONSABLE RETENCION" SortExpression="Responsable"></asp:BoundField>
                            <asp:BoundField DataField="Retencion" HeaderText="ESTADO DE SOLICITUD" SortExpression="Retencion"></asp:BoundField>                            
                            <%--<asp:CommandField ShowSelectButton="True" SelectText="PROCESAR" ButtonType="Button"></asp:CommandField>--%>
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
                    <asp:SqlDataSource runat="server" ID="SqlDataSource11" ConnectionString='<%$ ConnectionStrings:affisDBConnectionString %>' SelectCommand="SELECT [NumeroCertificado], [Nombre], [NombreComercial], [Responsable], [Retencion], [FechaRet] FROM [Asegurados] WHERE Retencion IS NOT NULL AND Retencion = 'SOLICITADO' AND MONTH(FechaRet) = MONTH(getdate()) AND YEAR(FechaRet) = YEAR(GETDATE())">                        
                    </asp:SqlDataSource>
                    <hr />
                     <asp:Label ID="Label14" runat="server" text="COBRANZAS" Style="font-weight: bold; font-size: 18px; color:red;"></asp:Label> 
                    <hr />
                    <asp:GridView ID="GridView4" runat="server" DataSourceID="SqlDataSource12" AutoGenerateColumns="False" AllowPaging="True" GridLines="None" BackColor="White" BorderStyle="None" BorderWidth="1px" CellPadding="20" ForeColor="Black"  CssClass="mGrid" PagerStyle-CssClass="pgr" margin-left="2%" AlternatingRowStyle-CssClass="alt" AllowSorting="True">
                        <Columns>

                            <asp:BoundField DataField="Empresa" HeaderText="EMPRESA" SortExpression="Empresa"></asp:BoundField>
                            <asp:BoundField DataField="Mes" HeaderText="MES" SortExpression="Mes"></asp:BoundField>
                            <asp:BoundField DataField="Monto" HeaderText="VALOR FACTURA" SortExpression="Monto"></asp:BoundField>   
                                                   
                            <%--<asp:CommandField ShowSelectButton="True" SelectText="PROCESAR" ButtonType="Button"></asp:CommandField>--%>
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
                    <asp:SqlDataSource runat="server" ID="SqlDataSource12" ConnectionString='<%$ ConnectionStrings:affisDBConnectionString %>' SelectCommand="SELECT [Empresa], [Mes], [Monto] FROM [Cierres] WHERE (([Estado] <> @Estado) AND ([Estado] <> @Estado2) AND ([Tipo] = @Tipo)) ORDER BY [Fecha] DESC">
                        <SelectParameters>
                            <asp:Parameter DefaultValue="LIQUIDADO" Name="Estado" Type="String"></asp:Parameter>
                            <asp:Parameter DefaultValue="SALDADO" Name="Estado2" Type="String"></asp:Parameter>
                            <asp:Parameter DefaultValue="VENTA" Name="Tipo" Type="String"></asp:Parameter>
                        </SelectParameters>
                    </asp:SqlDataSource>
                    <hr />
                    
                     <asp:Label ID="Label16" runat="server" text="GESTION IMPAGOS" Style="font-weight: bold; font-size: 18px; color:red;"></asp:Label> 
                    <hr />
                    <asp:GridView ID="GridView5" runat="server" DataSourceID="SqlDataSource13" AutoGenerateColumns="False" AllowPaging="True" GridLines="None" BackColor="White" BorderStyle="None" BorderWidth="1px" CellPadding="20" ForeColor="Black"  CssClass="mGrid" PagerStyle-CssClass="pgr" margin-left="2%" AlternatingRowStyle-CssClass="alt" AllowSorting="True">
                        <Columns>
                            <asp:BoundField DataField="Empresa" HeaderText="EMPRESA" SortExpression="Empresa"></asp:BoundField>
                            <asp:BoundField DataField="Nombre" HeaderText="NOMBRE" SortExpression="Nombre"></asp:BoundField>
                            <asp:BoundField DataField="Ceudla" HeaderText="CEDULA" SortExpression="Ceudla"></asp:BoundField>
                            <asp:BoundField DataField="NumeroCertificado" HeaderText="CERTIFICADO" SortExpression="NumeroCertificado"></asp:BoundField>
                            <asp:BoundField DataField="Total" HeaderText="DEUDA" SortExpression="Total"></asp:BoundField>                                                  
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
                    <asp:SqlDataSource runat="server" ID="SqlDataSource13" ConnectionString='<%$ ConnectionStrings:affisDBConnectionString %>' SelectCommand="SELECT NOMBRE, Ceudla, NumeroCertificado, Total, Empresa from morosos group by Nombre, Ceudla, NumeroCertificado, Total, Empresa having Count(NumeroCertificado) >= 3">
                    </asp:SqlDataSource>
                     <hr />
                    
                     <asp:Label ID="Label17" runat="server" text="RECLAMOS FRECUENTES" Style="font-weight: bold; font-size: 18px; color:red;"></asp:Label> 
                    <hr />
                    <asp:GridView ID="GridView6" runat="server" DataSourceID="SqlDataSource14" AutoGenerateColumns="False" AllowPaging="True" GridLines="None" BackColor="White" BorderStyle="None" BorderWidth="1px" CellPadding="20" ForeColor="Black"  CssClass="mGrid" PagerStyle-CssClass="pgr" margin-left="2%" AlternatingRowStyle-CssClass="alt" AllowSorting="True">
                        <Columns>
                            <asp:BoundField DataField="Entidad" HeaderText="EMPRESA" SortExpression="Entidad"></asp:BoundField>
                            <asp:BoundField DataField="Nombre" HeaderText="TOMADOR" SortExpression="Nombre"></asp:BoundField>
                            <asp:BoundField DataField="Total" HeaderText="TOTAL" SortExpression="Total" ReadOnly="True"></asp:BoundField>                                                  
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
                    <asp:SqlDataSource runat="server" ID="SqlDataSource14" ConnectionString='<%$ ConnectionStrings:affisDBConnectionString %>' SelectCommand="select Entidad, Nombre, Sum(PagoAseg) over(Partition by Nombre) as Total from Reclamos Where EstadoReclamo = 'CREADO' or EstadoReclamo = 'DOCUMENTADO' group by Nombre, Entidad, PagoAseg having count(Nombre) >= 3">
                    </asp:SqlDataSource>
                    <hr />
                    
                     <asp:Label ID="Label18" runat="server" text="RECLAMOS POR EMPRESA" Style="font-weight: bold; font-size: 18px; color:red;"></asp:Label> 
                    <hr />
                    <asp:GridView ID="GridView7" runat="server" DataSourceID="SqlDataSource16" AutoGenerateColumns="False" AllowPaging="True" GridLines="None" BackColor="White" BorderStyle="None" BorderWidth="1px" CellPadding="20" ForeColor="Black"  CssClass="mGrid" PagerStyle-CssClass="pgr" margin-left="2%" AlternatingRowStyle-CssClass="alt" AllowSorting="True">
                        <Columns>
                            <asp:BoundField DataField="entidad" HeaderText="EMPRESA" SortExpression="entidad"></asp:BoundField>
                            <asp:BoundField DataField="Cantidad" HeaderText="NUMERO  CASOS" SortExpression="Cantidad" ReadOnly="True"></asp:BoundField>
                            <asp:BoundField DataField="Total" HeaderText="TOTAL INDEMNIZADO" SortExpression="Total" ReadOnly="True"></asp:BoundField>                                                  
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
                    <asp:SqlDataSource runat="server" ID="SqlDataSource16" ConnectionString='<%$ ConnectionStrings:affisDBConnectionString %>' SelectCommand="select  top 10 entidad, count(entidad) as Cantidad, sum(pagoaseg) as Total from reclamos where EstadoReclamo = 'LIQUIDADO' group by Entidad, pagoaseg ">
                    </asp:SqlDataSource>
                    <hr />
                    
                </div>
            </div>
        </div>
        </div>
    
</asp:Content>
