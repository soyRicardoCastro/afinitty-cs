<%@ Page Title="Tarrago Reach System" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ReemplazoElim.aspx.cs" Inherits="ReachSystem.ReemplazoElim" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server"> 
    <div class="container">
    <div class="card">
        <div class="card-header">
                <div class="form-row">
                    <div class="col10L">                        
                        <asp:Label ID="Label6" runat="server" Text="ELIMINAR: COBERTURAS" Style="font-weight: bold; font-size: 18px;"></asp:Label>                         
                    </div>                   
                </div>
            </div>
        <div class="card-body">
                <div class="form-row">
                    <asp:Label ID="Label1" runat="server" Text="El registro no existe en nuestra base de Datos ¿Que Desea Hacer?" Style="font-weight: bold; font-size: 18px;"></asp:Label>                         
                    <asp:GridView ID="GridView1" runat="server" DataSourceID="SqlDataSource1" AutoGenerateColumns="False" AllowPaging="True" GridLines="None" BackColor="White" BorderStyle="None" BorderWidth="1px" CellPadding="20" ForeColor="Black"  CssClass="mGrid" PagerStyle-CssClass="pgr" margin-left="2%" AlternatingRowStyle-CssClass="alt" AllowSorting="True" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                        <Columns>      
                            <asp:BoundField DataField="Row" HeaderText="ID" SortExpression="Row"></asp:BoundField>
                            <asp:BoundField DataField="Cedula" HeaderText="CEDULA" SortExpression="Cedula de Identidad"></asp:BoundField>
                            <asp:BoundField DataField="Nombre" HeaderText="NOMBRES COMPLETOS" SortExpression="Nombre"></asp:BoundField>
                            <asp:BoundField DataField="Genero" HeaderText="GENERO" SortExpression="Genero"></asp:BoundField>
                            <asp:BoundField DataField="Relacion" HeaderText="RELACION" SortExpression="Relacion"></asp:BoundField>
                            <asp:BoundField DataField="FechaNac" HeaderText="FECHA DE NACIMIENTO" SortExpression="FechaNac"></asp:BoundField>
                            <asp:BoundField DataField="Producto" HeaderText="COBERTURA" SortExpression="Producto"></asp:BoundField>
                            <asp:BoundField DataField="Plan" HeaderText="PLAN" SortExpression="Plan"></asp:BoundField>
                            <asp:BoundField DataField="TotalPrima" HeaderText="TOTAL PRIMA" SortExpression="TotalPrima"></asp:BoundField>
                            <asp:CommandField ShowSelectButton="True" ButtonType="Button" SelectText="ELIMINAR COBERTURA"></asp:CommandField>
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
                    <asp:SqlDataSource runat="server" ID="SqlDataSource1" ConnectionString='<%$ ConnectionStrings:affisDBConnectionString %>' SelectCommand="SELECT [Cedula], [Nombre], [Producto], [Plan], [TotalPrima], [Row], Relacion, Genero, FechaNac FROM [Dependientes] WHERE ([NumeroCertificado] = @NumeroCertificado) AND Estado <> 'EXCLUIDO'">  <%--)--%> <%--([Nombre] LIKE '%' + @Nombre + '%')--%>
                        <SelectParameters>  
                            <%--<asp:CookieParameter CookieName="paramCedula" Name="Nombre" Type="Empty"></asp:CookieParameter>--%>
                            <%--<asp:CookieParameter CookieName="paramCedula" Name="Cedula" Type="Empty"></asp:CookieParameter>--%>
                            <asp:CookieParameter CookieName="paramCert" Name="NumeroCertificado" Type="Empty"></asp:CookieParameter>                            
                        </SelectParameters>
                    </asp:SqlDataSource>       
                    <hr />
                    <CENTER>
                    <asp:Button  value="REGISTRARME" type="submit" runat="server" CssClass="botonsubmitTRES" Text="CANCELAR" ID="CANCEL" OnClick="CANCEL_Click" UseSubmitBehavior="False" />  
                    <asp:Button  value="REGISTRARME" type="submit" runat="server" CssClass="botonsubmitTRES" Text="INCLUIR" ID="INCLU" OnClick="Unnamed1_Click"/>  
                    <asp:Button  value="REGISTRARME" type="submit" runat="server" CssClass="botonsubmitTRES" Text="VOLVER" ID="ADIC" OnClick="ADIC_Click"/>
                        <asp:Button  value="REGISTRARME" type="submit" runat="server" CssClass="botonsubmitTRES" Text="GUARDAR" ID="Button1" OnClick="ADIC_Click"/>
                    </CENTER>                    
                    
                </div>
            </div>
        </div>
        </div>
    
</asp:Content>
