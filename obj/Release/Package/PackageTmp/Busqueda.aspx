<%@ Page Title="Tarrago Reach System" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Busqueda.aspx.cs" Inherits="ReachSystem.Busqueda" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server"> 
    <div class="container">
    <div class="card">
        <div class="card-header">
                <div class="form-row">
                    <div class="col10L">                        
                        <asp:Label ID="Label6" runat="server" Text="BUSQUEDA: RESULTADOS" Style="font-weight: bold; font-size: 18px;"></asp:Label>                         
                    </div>                   
                </div>
            </div>
        <div class="card-body">
                <div class="form-row">
                    <asp:Label ID="Label1" runat="server" Text="EL REGISTRO NO EXISTE EN NUESTRA BASE DE DATOS ¿QUE DESEA HACER?" Style="font-weight: bold; font-size: 18px;"></asp:Label>                         
                    <asp:GridView ID="GridView1" runat="server" DataSourceID="SqlDataSource1" AutoGenerateColumns="False" AllowPaging="True" GridLines="None" BackColor="White" BorderStyle="None" BorderWidth="1px" CellPadding="20" ForeColor="Black"  CssClass="mGrid" PagerStyle-CssClass="pgr" margin-left="2%" AlternatingRowStyle-CssClass="alt" AllowSorting="True" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                        <Columns>                            
                            <asp:BoundField DataField="Cedula" HeaderText="CEDULA" SortExpression="Cedula de Identidad"></asp:BoundField>
                            <asp:BoundField DataField="Nombre" HeaderText="NOMBRES COMPLETOS" SortExpression="Nombre"></asp:BoundField>
                            <asp:BoundField DataField="NumeroCertificado" HeaderText="CERTIFICADO" SortExpression="NumeroCertificado"></asp:BoundField>
                            <asp:BoundField DataField="Estado" HeaderText="ESTADO" SortExpression="Estado"></asp:BoundField>
                            <asp:CommandField ShowSelectButton="True" ButtonType="Button" SelectText="VER CERTIFICADO"></asp:CommandField>
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
                    <asp:SqlDataSource runat="server" ID="SqlDataSource1" ConnectionString='<%$ ConnectionStrings:affisDBConnectionString %>' SelectCommand="SELECT [Cedula], [Nombre], [NumeroCertificado], [Estado] FROM [Asegurados] WHERE (([Cedula] = @Cedula) OR ([NumeroCertificado] = @NumeroCertificado)) AND NumeroCertificado IS NOT NULL">  <%--)--%> <%--([Nombre] LIKE '%' + @Nombre + '%')--%>
                        <SelectParameters>  
                            <%--<asp:CookieParameter CookieName="paramCedula" Name="Nombre" Type="Empty"></asp:CookieParameter>--%>
                            <asp:CookieParameter CookieName="paramCedula" Name="Cedula" Type="Int64"></asp:CookieParameter>
                            <asp:CookieParameter CookieName="paramCedula" Name="NumeroCertificado" Type="Int64"></asp:CookieParameter>                            
                        </SelectParameters>
                    </asp:SqlDataSource>       
                    <hr />
                    <CENTER>
                    <asp:Button  value="REGISTRARME" type="submit" runat="server" CssClass="botonsubmitTRES" Text="CANCELAR" ID="CANCEL" OnClick="CANCEL_Click" UseSubmitBehavior="False" />  
                    <asp:Button  value="REGISTRARME" type="submit" runat="server" CssClass="botonsubmitTRES" Text="INCLUIR" ID="INCLU" OnClick="Unnamed1_Click"/>  
                    <asp:Button  value="REGISTRARME" type="submit" runat="server" CssClass="botonsubmitTRES" Text="ADICIONAR" ID="ADIC" OnClick="ADIC_Click"/>
                    </CENTER>                    
                    
                </div>
            </div>
        </div>
        </div>
    
</asp:Content>
