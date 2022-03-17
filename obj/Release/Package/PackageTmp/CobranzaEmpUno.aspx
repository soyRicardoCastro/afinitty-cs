<%@ Page Title="Tarrago Reach System" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CobranzaEmpUno.aspx.cs" Inherits="ReachSystem.CobranzaEmpUno" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server"> 
    <div class="container">
    <div class="card">
        <div class="card-header">
                <div class="form-row">
                    <div class="col10L">                        
                        <asp:Label ID="Label6" runat="server" Text="COBRANZAS: GESTION EMPRESAS" Style="font-weight: bold; font-size: 18px;"></asp:Label>                                                 
                    </div>                   
                </div>
            </div>
        <div class="card-body">
                <div class="form-row">                                                                  
                     <CENTER><asp:Label ID="Label1" runat="server" Text="EMPRESAS" Style="font-weight: bold; font-size: 18px;"></asp:Label></CENTER><br />
                    <asp:GridView ID="GridView3" runat="server" DataSourceID="SqlDataSource3" AutoGenerateColumns="False" GridLines="None" BackColor="White" BorderStyle="None" BorderWidth="1px" CellPadding="20" ForeColor="Black" CssClass="mGrid" PagerStyle-CssClass="pgr" margin-left="2%" AlternatingRowStyle-CssClass="alt" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" AllowPaging="True" AllowSorting="True">
                        <Columns>
                            
                            <asp:BoundField DataField="Empresa" HeaderText="EMPRESA" SortExpression="Empresa"></asp:BoundField>
                            <asp:BoundField DataField="Mes" HeaderText="MES FACTURACION" SortExpression="Mes" ReadOnly="True"></asp:BoundField>
                            <asp:BoundField DataField="Observaciones" HeaderText="OBSERVACIONES" SortExpression="Observaciones"></asp:BoundField> 
                            <asp:CommandField ShowSelectButton="True" ButtonType="Button" SelectText="PROCESAR"></asp:CommandField>
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
                    <asp:SqlDataSource runat="server" ID="SqlDataSource3" ConnectionString='<%$ ConnectionStrings:affisDBConnectionString %>' SelectCommand="SELECT [Empresa], [Fecha], [Observaciones], [Mes] FROM [Cierres] WHERE (([Estado] = @Estado) AND ([Tipo] = 'VENTA')) OR (([Estado] = 'ABONADO') AND ([Tipo] = 'VENTA'))"><%--where MONTH(Mes) <= MONTH(GETDATE()) AND Deuda > 0 AND Status = 'PENDIENTE'--%>
                        <SelectParameters>
                            <asp:Parameter DefaultValue="VIGENTE" Name="Estado" Type="String"></asp:Parameter>                       
                        </SelectParameters>
                    </asp:SqlDataSource>                     
                    <hr />
                    <CENTER>
                    <asp:Button  value="REGISTRARME" type="submit" runat="server" CssClass="botonsubmitTRES" Text="CANCELAR" ID="CANCEL" UseSubmitBehavior="False" OnClick="siguiclick"/>                                                              
                    </CENTER>                                        
                </div>
            </div>
        </div>
        </div>    
</asp:Content>
