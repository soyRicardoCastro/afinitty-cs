<%@ Page Title="AFFINITY" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ReachSystem._Default" %>

<%@ Register Assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" Namespace="System.Web.UI.DataVisualization.Charting" TagPrefix="asp" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="my-32 mx-20 flex flex-col justify-between" runat="server">
        <h2 class="text-2xl my-10 text-white">Ventas año en curso</h2>
        <section class="flex gap-5 w-full flex-wrap justify-between">
            <div class="flex flex-col gap-2 rounded-md p-4 bg-gray-700">
              <h2 class="text-xl text-white text-center font-md">Ejecutivo / Cantidad</h2>
              <asp:Chart ID="Chart1" runat="server" DataSourceID="SqlDataSource1">
                  <Series>
                      <asp:Series Name="Series1" XValueMember="Ejecutivo" YValueMembers="TotalQuantity"></asp:Series>
                  </Series>
                  <ChartAreas>
                      <asp:ChartArea Name="ChartArea1"></asp:ChartArea>
                  </ChartAreas>
              </asp:Chart>
              <asp:SqlDataSource runat="server" ID="SqlDataSource1" ConnectionString='<%$ ConnectionStrings:affisDBConnectionString %>' SelectCommand="SELECT Ejecutivo, COUNT(Numerocertificado) AS TotalQuantity FROM Asegurados GROUP BY Ejecutivo order by TotalQuantity DESC"></asp:SqlDataSource>
            </div>

          <div class="flex flex-col gap-2 rounded-md p-4 bg-gray-700">
              <h2 class="text-xl text-white text-center font-md">Ejecutivo / Monto</h2>
              <asp:Chart ID="Chart4" runat="server" DataSourceID="SqlDataSource4">
                <Series>
                    <asp:Series Name="Series1" XValueMember="Ejecutivo" YValueMembers="TotalQuantity" ChartType="Bar" Palette="Fire"></asp:Series>
                </Series>
                <ChartAreas>
                    <asp:ChartArea Name="ChartArea1"></asp:ChartArea>
                </ChartAreas>
            </asp:Chart>
            <asp:SqlDataSource runat="server" ID="SqlDataSource4" ConnectionString='<%$ ConnectionStrings:affisDBConnectionString %>' SelectCommand="SELECT Ejecutivo, SUM(TotalCobrar) AS TotalQuantity FROM Asegurados GROUP BY Ejecutivo order by TotalQuantity DESC"></asp:SqlDataSource>
            </div>

          <div class="flex flex-col gap-2 rounded-md p-4 bg-gray-700">
              <h2 class="text-xl text-white text-center font-md">Genero / Cantidad</h2>
              <asp:Chart ID="Chart3" runat="server" DataSourceID="SqlDataSource3">
                <Series>
                    <asp:Series Name="Series1" XValueMember="Genero" YValueMembers="TotalQuantity" ChartType="Bar" Palette="Berry"></asp:Series>
                </Series>
                <ChartAreas>
                    <asp:ChartArea Name="ChartArea1"></asp:ChartArea>
                </ChartAreas>
            </asp:Chart>
            <asp:SqlDataSource runat="server" ID="SqlDataSource3" ConnectionString='<%$ ConnectionStrings:affisDBConnectionString %>' SelectCommand="SELECT Genero, COUNT(Genero) AS TotalQuantity FROM Dependientes GROUP BY Genero order by TotalQuantity DESC"></asp:SqlDataSource>
            </div>
        </section>

      <h2 class="text-2xl my-10 text-white">Ventas mes en curso</h2>
      <section class="flex gap-5 w-full flex-wrap justify-evenly">
          <div class="flex flex-col gap-2 rounded-md p-4 bg-gray-700">
              <h2 class="text-xl text-white text-center font-md">Ejecutivo / Cantidad</h2>
              <asp:Chart ID="Chart7" runat="server" DataSourceID="SqlDataSource7">
                <Series>
                    <asp:Series Name="Series1" XValueMember="EJECUTIVO" YValueMembers="TotalQuantity"></asp:Series>
                </Series>
                <ChartAreas>
                    <asp:ChartArea Name="ChartArea1"></asp:ChartArea>
                </ChartAreas>
            </asp:Chart>
            <asp:SqlDataSource runat="server" ID="SqlDataSource7" ConnectionString='<%$ ConnectionStrings:affisDBConnectionString %>' SelectCommand="SELECT Ejecutivo, COUNT(Nombre) AS TotalQuantity FROM Asegurados WHERE MONTH(FechaVenta) = MONTH(getdate()) AND YEAR(FechaVenta) = YEAR(GETDATE()) GROUP BY Ejecutivo order by TotalQuantity DESC"></asp:SqlDataSource>
          </div>

        <div class="flex flex-col gap-2 rounded-md p-4 bg-gray-700">
              <h2 class="text-xl text-white text-center font-md">Ejecutivo / Monto</h2>
              <asp:Chart ID="Chart8" runat="server" DataSourceID="SqlDataSource8">
                <Series>
                    <asp:Series Name="Series1" XValueMember="Ejecutivo" YValueMembers="TotalQuantity" ChartType="Bar" Palette="SeaGreen"></asp:Series>
                </Series>
                <ChartAreas>
                    <asp:ChartArea Name="ChartArea1"></asp:ChartArea>
                </ChartAreas>
            </asp:Chart>
            <asp:SqlDataSource runat="server" ID="SqlDataSource8" ConnectionString='<%$ ConnectionStrings:affisDBConnectionString %>' SelectCommand="SELECT Ejecutivo, SUM(TotalCobrar) AS TotalQuantity FROM Asegurados WHERE MONTH(FechaVenta) = MONTH(getdate()) AND YEAR(FechaVenta) = YEAR(GETDATE()) GROUP BY Ejecutivo order by TotalQuantity DESC"></asp:SqlDataSource>
          </div>
      </section>

      <h2 class="text-2xl my-10 text-white">Reclamos</h2>
      <section class="flex gap-5 w-full flex-wrap justify-evenly">
          <div class="flex flex-col gap-2 rounded-md p-4 bg-gray-700">
              <h2 class="text-xl text-white text-center font-md">Monto / Empresa</h2>
              <asp:Chart ID="Chart9" runat="server" DataSourceID="SqlDataSource15">
                  <Series>
                      <asp:Series Name="Series1" XValueMember="Entidad" YValueMembers="Monto"></asp:Series>
                  </Series>
                  <ChartAreas>
                      <asp:ChartArea Name="ChartArea1"></asp:ChartArea>
                  </ChartAreas>
              </asp:Chart>
              <asp:SqlDataSource runat="server" ID="SqlDataSource15" ConnectionString='<%$ ConnectionStrings:affisDBConnectionString %>' SelectCommand="SELECT Entidad, SUM(PagoAseg) AS Monto FROM Reclamos WHERE MONTH(FechaPagoCli) = MONTH(getdate()) AND YEAR(FechaPagoCli) = YEAR(GETDATE()) GROUP BY Entidad order by Monto DESC"></asp:SqlDataSource>
          </div>

        <div class="flex flex-col gap-2 rounded-md p-4 bg-gray-700">
              <h2 class="text-xl text-white text-center font-md">Cobertura / Monto</h2>
              <asp:Chart ID="Chart5" runat="server" DataSourceID="SqlDataSource8">
                <Series>
                    <asp:Series Name="Series1" XValueMember="Ejecutivo" YValueMembers="TotalQuantity" ChartType="Bar" Palette="SeaGreen"></asp:Series>
                </Series>
                <ChartAreas>
                    <asp:ChartArea Name="ChartArea1"></asp:ChartArea>
                </ChartAreas>
            </asp:Chart>
            <asp:SqlDataSource runat="server" ID="SqlDataSource5" ConnectionString='<%$ ConnectionStrings:affisDBConnectionString %>' SelectCommand="SELECT Ejecutivo, SUM(TotalCobrar) AS TotalQuantity FROM Asegurados WHERE MONTH(FechaVenta) = MONTH(getdate()) AND YEAR(FechaVenta) = YEAR(GETDATE()) GROUP BY Ejecutivo order by TotalQuantity DESC"></asp:SqlDataSource>
          </div>
      </section>

      <h2 class="text-2xl my-10 text-white">Mensual de Ventas</h2>
      <section class="flex w-full mx-auto items-center justify-center p-5 rounded-md bg-gray-700" runat="server">
        <asp:GridView ID="GridView1" runat="server" DataSourceID="SqlDataSource9" AutoGenerateColumns="False" AllowPaging="True" GridLines="None" CellPadding="20"  CssClass="mGrid" PagerStyle-CssClass="pgr" margin-left="2%" AlternatingRowStyle-CssClass="alt">
            <Columns>                            
              <asp:BoundField DataField="Ejecutivo" HeaderText="EJECUTIVO" SortExpression="Ejecutivo"></asp:BoundField>
              <asp:BoundField DataField="TotalQuantity" HeaderText="CERTIFICADOS" SortExpression="TotalQuantity"></asp:BoundField>
              <asp:BoundField DataField="Total" HeaderText="TOTAL $" SortExpression="TOTAL"></asp:BoundField>                            
            </Columns>
            <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
            <HeaderStyle BackColor="white" ForeColor="" />
            <PagerStyle BackColor="#ccc" ForeColor="#fff" HorizontalAlign="Right" />
            <SelectedRowStyle BackColor="#CCCCCC" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F7F7F7" />
            <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
            <SortedDescendingCellStyle BackColor="#E5E5E5" />
            <SortedDescendingHeaderStyle BackColor="#242121" />
            <PagerStyle CssClass="pgr"></PagerStyle>
          </asp:GridView>
          <asp:SqlDataSource runat="server" ID="SqlDataSource9" ConnectionString='<%$ ConnectionStrings:affisDBConnectionString %>' SelectCommand="SELECT Ejecutivo, COUNT(Nombre) AS TotalQuantity, SUM(TotalCobrar) AS Total FROM Asegurados WHERE MONTH(FechaVenta) = MONTH(getdate()) AND YEAR(FechaVenta) = YEAR(GETDATE()) AND Estado <> 'EXCLUIDO' GROUP BY Ejecutivo order by TotalQuantity DESC"></asp:SqlDataSource>
      
          </section>

        <h2 class="text-white text-2xl my-10">Ejecutivo</h2>

        <section class="flex justify-center items-center w-full" runat="server">
          <asp:GridView ID="GridView2" runat="server" DataSourceID="SqlDataSource11" AutoGenerateColumns="False" AllowPaging="True" GridLines="None" BackColor="White" BorderStyle="None" BorderWidth="1px" CellPadding="20" ForeColor="Black"  CssClass="mGrid" PagerStyle-CssClass="pgr" margin-left="2%" AlternatingRowStyle-CssClass="alt" AllowSorting="True">
            <Columns>
                <asp:BoundField DataField="FechaRet" HeaderText="FECHA ASIGNACION" SortExpression="FechaRet"></asp:BoundField>
                <asp:BoundField DataField="NombreComercial" HeaderText="EMPRESA" SortExpression="NombreComercial"></asp:BoundField>
                <asp:BoundField DataField="Nombre" HeaderText="TOMADOR" SortExpression="Nombre"></asp:BoundField>   
                <asp:BoundField DataField="NumeroCertificado" HeaderText="CERTIFICADO" SortExpression="NumeroCertificado"></asp:BoundField>                                                                                 
                <asp:BoundField DataField="Responsable" HeaderText="RESPONSABLE RETENCION" SortExpression="Responsable"></asp:BoundField>
                <asp:BoundField DataField="Retencion" HeaderText="ESTADO DE SOLICITUD" SortExpression="Retencion"></asp:BoundField>
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
        <asp:SqlDataSource runat="server" ID="SqlDataSource2" ConnectionString='<%$ ConnectionStrings:affisDBConnectionString %>' SelectCommand="SELECT [NumeroCertificado], [Nombre], [NombreComercial], [Responsable], [Retencion], [FechaRet] FROM [Asegurados] WHERE Retencion IS NOT NULL AND Retencion = 'SOLICITADO' AND MONTH(FechaRet) = MONTH(getdate()) AND YEAR(FechaRet) = YEAR(GETDATE())">                        </asp:SqlDataSource>
      
        </section>

      <h2 class="text-white text-2xl my-10">Retenciones</h2>

        <section class="flex justify-center items-center w-full" runat="server">
          <asp:GridView ID="GridView3" runat="server" DataSourceID="SqlDataSource11" AutoGenerateColumns="False" AllowPaging="True" GridLines="None" BackColor="White" BorderStyle="None" BorderWidth="1px" CellPadding="20" ForeColor="Black"  CssClass="mGrid" PagerStyle-CssClass="pgr" margin-left="2%" AlternatingRowStyle-CssClass="alt" AllowSorting="True">
                        <Columns>

                            <asp:BoundField DataField="FechaRet" HeaderText="FECHA ASIGNACION" SortExpression="FechaRet"></asp:BoundField>
                            <asp:BoundField DataField="NombreComercial" HeaderText="EMPRESA" SortExpression="NombreComercial"></asp:BoundField>
                            <asp:BoundField DataField="Nombre" HeaderText="TOMADOR" SortExpression="Nombre"></asp:BoundField>   
                            <asp:BoundField DataField="NumeroCertificado" HeaderText="CERTIFICADO" SortExpression="NumeroCertificado"></asp:BoundField>                                                                                 
                            <asp:BoundField DataField="Responsable" HeaderText="RESPONSABLE RETENCION" SortExpression="Responsable"></asp:BoundField>
                            <asp:BoundField DataField="Retencion" HeaderText="ESTADO DE SOLICITUD" SortExpression="Retencion"></asp:BoundField>
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
        </section>

      <h2 class="text-white text-2xl my-10">Cobranzas</h2>

        <section class="flex w-full mx-auto items-center justify-center p-5 rounded-md bg-gray-700" runat="server">
          <asp:GridView ID="GridView4" runat="server" DataSourceID="SqlDataSource12" AutoGenerateColumns="False" AllowPaging="True" GridLines="None" BackColor="White" BorderStyle="None" BorderWidth="1px" CellPadding="20" ForeColor="Black"  CssClass="mGrid" PagerStyle-CssClass="pgr" margin-left="2%" AlternatingRowStyle-CssClass="alt" AllowSorting="True">
                        <Columns>

                            <asp:BoundField DataField="Empresa" HeaderText="EMPRESA" SortExpression="Empresa"></asp:BoundField>
                            <asp:BoundField DataField="Mes" HeaderText="MES" SortExpression="Mes"></asp:BoundField>
                            <asp:BoundField DataField="Monto" HeaderText="VALOR FACTURA" SortExpression="Monto"></asp:BoundField>   
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
        </section>

      <h2 class="text-white text-2xl my-10">Gestion Impagos</h2>

        <section class="flex justify-center items-center w-full" runat="server">
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
        </section>

      <h2 class="text-white text-2xl my-10">Reclamos Frecuentes</h2>

        <section class="flex justify-center items-center w-full" runat="server">
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
        </section>

      <h2 class="text-white text-2xl my-10">Reclamos por Empresa</h2>

        <section class="flex w-full mx-auto items-center justify-center p-5 rounded-md bg-gray-700" runat="server">
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
        </section>
    </div>
</asp:Content>