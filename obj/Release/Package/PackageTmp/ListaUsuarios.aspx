<%@ Page Title="Tarrago Reach System" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListaUsuarios.aspx.cs" Inherits="ReachSystem.ListaUsuarios" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">  
   <div class="fila col10L">
                <center><input class="formulario" placeholder="Nombre/Empresa" id="Correo" type="text" runat="server"/>  
                <asp:Button class="botonsubmit" value="REGISTRARME" type="submit" runat="server" CssClass="botonsubmit" Text="BUSCAR USUARIO" OnClick="Unnamed1_Click" /></center>
            </div>  
    <div class="container">
    <div class="card">
        <div class="card-header">
                <div class="form-row">
                    <div class="col10L">
                        <asp:Label ID="Label6" runat="server" Text="Usuarios" Style="font-weight: bold; font-size: 18px;"></asp:Label>
                    </div>
                </div>
            </div>
        <div class="card-body">
                <div class="form-row">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1"  GridLines="None" AllowPaging="True" BackColor="White" BorderStyle="None" BorderWidth="1px" CellPadding="20" ForeColor="Black"  CssClass="mGrid" PagerStyle-CssClass="pgr" margin-left="2%" AlternatingRowStyle-CssClass="alt" AllowSorting="True" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
<AlternatingRowStyle CssClass="alt"></AlternatingRowStyle>

        <Columns>                                    
            <asp:BoundField DataField="Email" HeaderText="Email" SortExpression="Email" />
            <asp:BoundField DataField="FechaCreacion" HeaderText="FechaCreacion" SortExpression="FechaCreacion" />
            <asp:BoundField DataField="Nombre" HeaderText="Nombre" SortExpression="Nombre" />
            <asp:BoundField DataField="Perfil" HeaderText="Perfil" SortExpression="Perfil" />
            <asp:BoundField DataField="Empresa" HeaderText="Empresa" SortExpression="Empresa" />
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
<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:tarragoReachConnectionString %>" SelectCommand="SELECT [Email], [FechaCreacion], [Nombre], [Perfil], [Empresa] FROM [Usuario] WHERE (([Nombre] LIKE '%'+ @Nombre + '%') OR ([Empresa] LIKE '%'+ @Empresa +'%') OR ([Email] LIKE '%'+ @Empresa +'%'))">
    <SelectParameters>
        <asp:CookieParameter CookieName="paramcuatroC" Name="Nombre" Type="String" />
        <asp:CookieParameter CookieName="paramcuatroC" Name="Empresa" Type="String" />
    </SelectParameters>
    </asp:SqlDataSource>
                    <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource2"  GridLines="None" AllowPaging="True" BackColor="White" BorderStyle="None" BorderWidth="1px" CellPadding="20" ForeColor="Black"  CssClass="mGrid" PagerStyle-CssClass="pgr" margin-left="2%" AlternatingRowStyle-CssClass="alt" AllowSorting="True" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
<AlternatingRowStyle CssClass="alt"></AlternatingRowStyle>

        <Columns>                                    
            <asp:BoundField DataField="Email" HeaderText="Email" SortExpression="Email" />
            <asp:BoundField DataField="FechaCreacion" HeaderText="FechaCreacion" SortExpression="FechaCreacion" />
            <asp:BoundField DataField="Nombre" HeaderText="Nombre" SortExpression="Nombre" />
            <asp:BoundField DataField="Perfil" HeaderText="Perfil" SortExpression="Perfil" />
            <asp:BoundField DataField="Empresa" HeaderText="Empresa" SortExpression="Empresa" />
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
<asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:tarragoReachConnectionString %>" SelectCommand="SELECT [Email], [FechaCreacion], [Nombre], [Perfil], [Empresa] FROM [Usuario]">
    </asp:SqlDataSource>
                    </div>
        </div>
        </div>
        </div>
</asp:Content>
