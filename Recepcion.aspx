<%@ Page Title="Tarrago Reach System" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Recepcion.aspx.cs" Inherits="ReachSystem.Recepcion" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server"> 
    <div class="container">
    <div class="card">
        <div class="card-header">
                <div class="form-row">
                    <div class="col10L">                        
                        <asp:Label ID="Label6" runat="server" Text="RECEPCION DOCUMENTOS" Style="font-weight: bold; font-size: 18px;"></asp:Label>                         
                    </div>                   
                </div>
            </div>
        <div class="card-body">
                <div class="form-row">                    
                    <asp:GridView ID="GridView1" runat="server" DataSourceID="SqlDataSource1" AutoGenerateColumns="False" AllowPaging="True" GridLines="None" BackColor="White" BorderStyle="None" BorderWidth="1px" CellPadding="20" ForeColor="Black"  CssClass="mGrid" PagerStyle-CssClass="pgr" margin-left="2%" AlternatingRowStyle-CssClass="alt" AllowSorting="True" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                        <Columns>                            
                            <asp:BoundField DataField="Empresa" HeaderText="EMPRESA" SortExpression="Empresa"></asp:BoundField>
                            <asp:BoundField DataField="Mes" HeaderText="MES FACTURACION" SortExpression="Mes"></asp:BoundField>
                            <asp:BoundField DataField="Listado" HeaderText="FACTURA" SortExpression="Listado"></asp:BoundField>
                            <asp:BoundField DataField="Documentos" HeaderText="LISTADO" SortExpression="Documentos"></asp:BoundField>
                            
                            <asp:BoundField DataField="Poliza" HeaderText="POLIZA" SortExpression="Poliza"></asp:BoundField>
                            <asp:CommandField ShowSelectButton="True" SelectText="PROCESAR" ButtonType="Button"></asp:CommandField>
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
                    <asp:SqlDataSource runat="server" ID="SqlDataSource1" ConnectionString='<%$ ConnectionStrings:affisDBConnectionString %>' SelectCommand="select distinct a.Empresa, a.Mes, a.Documentos, b.Poliza, a.Listado from Cierres a join Empresa b on a.Empresa=B.NombreComercial WHERE (Documentos IS NULL AND Tipo = 'VENTA') OR (Listado IS NULL AND Tipo = 'VENTA')">
                        <SelectParameters>
                            <asp:Parameter DefaultValue="LIQUIDADO" Name="Estado" Type="String"></asp:Parameter>
                        </SelectParameters>
                    </asp:SqlDataSource>       
                    <hr />
                    <CENTER>
                    <asp:Button  value="REGISTRARME" type="submit" runat="server" CssClass="botonsubmitTRES" Text="CANCELAR" ID="CANCEL" OnClick="CANCEL_Click" UseSubmitBehavior="False" />  
                    
                    </CENTER>                    
                    
                </div>
            </div>
        </div>
        </div>
    
</asp:Content>
