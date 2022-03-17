<%@ Page Title="Tarrago Reach System" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ReportePrimaEmp.aspx.cs" Inherits="ReachSystem.ReportePrimaEmp" %>

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
                            <td><asp:Label ID="Label1" runat="server" Text="FECHA FIN" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                                <input class="formularioProc" placeholder="NOMBRE O APELLIDO" id="Correo" type="date" runat="server"  AutoPostBack="true"/>                            
                            </td>                           
                            <td><asp:Label ID="Label4" runat="server" Text="POLIZA" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                                <asp:DropDownList ID="DropDownList1" runat="server" class="formularioProc" DataSourceID="SqlDataSource2" DataTextField="Poliza" DataValueField="Poliza"></asp:DropDownList>
                                <asp:SqlDataSource runat="server" ID="SqlDataSource2" ConnectionString='<%$ ConnectionStrings:affisDBConnectionString %>' SelectCommand="SELECT DISTINCT Poliza FROM Empresa Where Estado='ACTIVA'"></asp:SqlDataSource>
                            </td>
                            <td><%--<asp:Label ID="Label3" runat="server" Text="GENERAR" Style="font-weight: bold; font-size: 18px;"></asp:Label>--%><br />
                                <asp:Button runat="server" CssClass="botonsubmitTRESDOS" text="GENERAR" OnClick="Unnamed_Click1"></asp:Button>                                
                            </td>                            
                        </tr>
                    </table> 
                    <hr />
                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" AllowPaging="True" GridLines="None" BackColor="White" BorderStyle="None" BorderWidth="1px" CellPadding="20" ForeColor="Black" CssClass="mGrid" PagerStyle-CssClass="pgr" margin-left="2%" AlternatingRowStyle-CssClass="alt" AllowSorting="True" DataSourceID="SqlDataSource1" PageSize="100">
                        <Columns>
                            <%--<asp:BoundField DataField="Ruc" HeaderText="RUC" SortExpression="Ruc"></asp:BoundField>--%>
                            <asp:BoundField DataField="RazonSocial" HeaderText="RAZON SOCIAL" SortExpression="RazonSocial"></asp:BoundField>                                
                            <asp:BoundField DataField="Clase" HeaderText="CLASE" SortExpression="Clase"></asp:BoundField>                            
                            <asp:BoundField DataField="Poliza" HeaderText="POLIZA" SortExpression="Poliza"></asp:BoundField>
                            <asp:BoundField DataField="Neta" HeaderText="PRIMA NETA" SortExpression="Neta"></asp:BoundField>   
                            <asp:BoundField DataField="Impu" HeaderText="BANCARIO" SortExpression="Impu"></asp:BoundField>   
                            <asp:BoundField DataField="Campe" HeaderText="CAMPESINO" SortExpression="Campe"></asp:BoundField>   
                            <asp:BoundField DataField="Factura" HeaderText="VALOR FACTURA" SortExpression="Factura"></asp:BoundField>   
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
                    <asp:SqlDataSource runat="server" ID="SqlDataSource1" ConnectionString='<%$ ConnectionStrings:affisDBConnectionString %>' SelectCommand="select distinct sum(a.totalcobrar) over(partition by a.nombrecomercial) as  Factura, b.Ruc, b.RazonSocial, b.clase, b.poliza, b.email1, b.email2, b.email3, (sum(a.totalcobrar) over(partition by a.nombrecomercial) / 1.04) * 0.005 as campe, (sum(a.totalcobrar) over(partition by a.nombrecomercial) / 1.04) * 0.035 as impu, sum(a.totalcobrar) over(partition by a.nombrecomercial) / 1.04 as neta from asegurados a join empresa b on a.nombrecomercial = b.nombrecomercial WHERE a.FechaVigencia BETWEEN @fechaini AND @fechafin AND a.Estado = 'VENTA' AND b.Poliza = @ven"> 
                        <SelectParameters>                                
                            <asp:CookieParameter CookieName="paramIni" Name="fechaini" Type="String"></asp:CookieParameter> 
                            <asp:CookieParameter CookieName="paramFin" Name="fechafin" Type="String"></asp:CookieParameter> 
                            <asp:CookieParameter CookieName="paramVEN" Name="ven" Type="String"></asp:CookieParameter>                            
                        </SelectParameters>
                    </asp:SqlDataSource>
                   <%-- <hr />
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
