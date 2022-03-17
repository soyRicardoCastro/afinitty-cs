<%@ Page Title="Tarrago Reach System" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ReporteSeguimiento.aspx.cs" Inherits="ReachSystem.ReporteSeguimiento" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server"> 
    <div class="container">
    <div class="card">
        <div class="card-header">
                <div class="form-row">
                    <div class="col10L">                        
                        <asp:Label ID="Label6" runat="server" Text="REPORTE: SEGUIMIENTO" Style="font-weight: bold; font-size: 18px;"></asp:Label>                        
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
                            <td><asp:Label ID="Label4" runat="server" Text="EJECUTIVO" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                                <asp:DropDownList ID="DropDownList1" runat="server" class="formularioProc" DataSourceID="SqlDataSource2" DataTextField="Ejecutivo" DataValueField="Ejecutivo"></asp:DropDownList>
                                <asp:SqlDataSource runat="server" ID="SqlDataSource2" ConnectionString='<%$ ConnectionStrings:affisDBConnectionString %>' SelectCommand="SELECT DISTINCT Ejecutivo FROM Asegurados"></asp:SqlDataSource>
                            </td>
                            <td><%--<asp:Label ID="Label3" runat="server" Text="GENERAR" Style="font-weight: bold; font-size: 18px;"></asp:Label>--%><br />
                                <asp:Button runat="server" CssClass="botonsubmitTRESDOS" text="GENERAR" OnClick="Unnamed_Click1"></asp:Button>                                
                            </td>                            
                        </tr>
                    </table> 
                    <hr />
                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" AllowPaging="True" GridLines="None" BackColor="White" BorderStyle="None" BorderWidth="1px" CellPadding="20" ForeColor="Black" CssClass="mGrid" PagerStyle-CssClass="pgr" margin-left="2%" AlternatingRowStyle-CssClass="alt" AllowSorting="True" DataSourceID="SqlDataSource1" PageSize="100">
                        <Columns>
                            <asp:BoundField DataField="CantCer" HeaderText="CERTIFICADOS" SortExpression="CantCer" ReadOnly="True"></asp:BoundField>
                            <asp:BoundField DataField="canttom" HeaderText="TOMADORES" SortExpression="canttom" ReadOnly="True"></asp:BoundField>
                            <asp:BoundField DataField="tomadoresaseg" HeaderText="TOM ASEGURADOS" SortExpression="tomadoresaseg" ReadOnly="True"></asp:BoundField>
                            <asp:BoundField DataField="notomadoresaseg" HeaderText="DEPENDIENTES" SortExpression="notomadoresaseg" ReadOnly="True"></asp:BoundField>
                            <%-- <asp:BoundField DataField="Neto" HeaderText="NETO EJECUTIVO" SortExpression="Neto" ReadOnly="True"></asp:BoundField>--%>
                            <asp:BoundField DataField="asegurados" HeaderText="TOTAL ASEGURADOS" ReadOnly="True" SortExpression="asegurados"></asp:BoundField>
                            <asp:BoundField DataField="prima" HeaderText="PRIMA TOTAL" ReadOnly="True" SortExpression="prima"></asp:BoundField>
                            <asp:BoundField DataField="empresas" HeaderText="EMPRESAS" ReadOnly="True" SortExpression="empresas"></asp:BoundField>
                            <asp:BoundField DataField="Dias" HeaderText="DIAS" SortExpression="Dias"></asp:BoundField>
                            <asp:BoundField DataField="primaprom" HeaderText="PRIMA PROMEDIO DIARIA" ReadOnly="True" SortExpression="primaprom"></asp:BoundField>
                            <asp:BoundField DataField="tomprom" HeaderText="PROM TOMADORES" ReadOnly="True" SortExpression="tomprom"></asp:BoundField>
                            <%--<asp:BoundField DataField="primatom" HeaderText="PRIMA TOMADORES" ReadOnly="True" SortExpression="primatom"></asp:BoundField>
                            <asp:BoundField DataField="primaaseg" HeaderText="PRIMA ASEGURADOS" ReadOnly="True" SortExpression="primaaseg"></asp:BoundField>--%>
                            <asp:BoundField DataField="retenidos" HeaderText="RETENIDOS" ReadOnly="True" SortExpression="retenidos"></asp:BoundField>
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
                    <asp:SqlDataSource runat="server" ID="SqlDataSource1" ConnectionString='<%$ ConnectionStrings:affisDBConnectionString %>' SelectCommand="select COUNT(distinct a.NumeroCertificado) as CantCer, COUNT(distinct b.Cedula) as canttom, COUNT(case when a.Relacion = 'TOMADOR' then 1 else null end) as tomadoresaseg, COUNT(case when a.Relacion <> 'TOMADOR' then 1 else null end) as notomadoresaseg, COUNT(a.Nombre) as asegurados, sum(a.TotalPrima) as prima, COUNT(distinct b.NombreComercial) as empresas, c.Dias, sum(a.TotalPrima)/c.Dias as primaprom, convert(float, count(distinct b.Nombre))/c.Dias as tomprom, sum(a.TotalPrima)/COUNT(distinct a.CedulaTomador) as primatom, sum(a.TotalPrima)/COUNT(case when a.Relacion <> 'TOMADOR' then 1 else null end) as primaaseg, SUM(distinct (case when b.Retencion = 'RETENIDO' and b.Estado = 'VENTA' then b.TotalCobrar else null end)) as retenidos from Dependientes a join asegurados b on a.NumeroCertificado = b.NumeroCertificado join Asistencia c on b.ejecutivo = c.Ejecutivo where (a.FechaVenta BETWEEN @fechaini AND @fechafin and b.Ejecutivo = @ven and a.Estado = 'VENTA' AND c.Mes BETWEEN @fechaini AND @fechafin) or (b.FechaRet BETWEEN @fechaini AND @fechafin and b.Ejecutivo = @ven and b.Estado = 'VENTA' AND c.Mes BETWEEN @fechaini AND @fechafin) group by c.Dias">
                        <SelectParameters>
                            <asp:CookieParameter CookieName="paramIni" Name="fechaini"></asp:CookieParameter>
                            <asp:CookieParameter CookieName="paramFin" Name="fechafin"></asp:CookieParameter>
                            <asp:CookieParameter CookieName="paramVEN" Name="ven"></asp:CookieParameter>
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
