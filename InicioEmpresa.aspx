<%@ Page Title="Tarrago Reach System" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="InicioEmpresa.aspx.cs" Inherits="ReachSystem.InicioEmpresa" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
  <section class="w-[80%] p-8 mx-auto my-20 rounded-md bg-gray-800 flex flex-col items-center justify-center gap-8">
    <h2 class="text-center text-2xl font-bold text-white">Apertura de Empresa</h2>
    <hr class="w-[90%] h-[2px] my-4" />

    <input class="formulario" placeholder="Nombre Comercial" id="Correo" type="text" runat="server" AutoPostBack="true" required/>
    <div class="flex justify-evenly items-center gap-6 my-4">
        <asp:RegularExpressionValidator Display="Dynamic" ControlToValidate="Correo" ID="MyPassordMinMaxLengthValidator" ValidationExpression="^[\s\S]{1,30}$" runat="server" ErrorMessage="LA BUSQUEDA DEBE TENER 1-30 CARACTERES"></asp:RegularExpressionValidator><br />        
        <asp:Button value="REGISTRARME" type="submit" runat="server" CssClass="px-4 py-2 rounded-sm bg-cyan-brand cursor-pointer text-white font-semibold" Text="Buscar"  OnClick="Unnamed1_Click"/>
        <asp:Button ID="INCLU" value="REGISTRARME" type="submit" runat="server" CssClass="px-4 py-2 rounded-sm bg-gray-400 text-white font-semibold cursor-pointer" Text="Apertura" OnClick="Unnamed2_Click" />
    </div>

  <asp:Label ID="Label1" runat="server" CssClass="text-white text-sm font-semibold"></asp:Label> 
  <asp:GridView ID="GridView1" runat="server" DataSourceID="SqlDataSource1" AutoGenerateColumns="False" AllowPaging="True" GridLines="None" BackColor="White" BorderStyle="None" BorderWidth="1px" CellPadding="20" ForeColor="Black"  CssClass="mGrid" PagerStyle-CssClass="pgr" margin-left="2%" AlternatingRowStyle-CssClass="alt" AllowSorting="True" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
    <Columns>
      <asp:BoundField DataField="NombreComercial" HeaderText="Nombre Comercial" SortExpression="NombreComercial"></asp:BoundField>
      <asp:BoundField DataField="Ruc" HeaderText="Ruc" SortExpression="Ruc"></asp:BoundField>
      <asp:BoundField DataField="MedioDeCobro" HeaderText="Medio De Cobro" SortExpression="MedioDeCobro"></asp:BoundField>
      <asp:BoundField DataField="Clase" HeaderText="Clase" SortExpression="Clase"></asp:BoundField>
      <asp:BoundField DataField="Poliza" HeaderText="Poliza" SortExpression="Poliza"></asp:BoundField>
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
  <asp:SqlDataSource runat="server" ID="SqlDataSource1" ConnectionString='<%$ ConnectionStrings:affisDBConnectionString %>' SelectCommand="SELECT [NombreComercial], [Ruc], [MedioDeCobro], [Clase], [Poliza] FROM [Empresa] WHERE ([NombreComercial] LIKE '%' + @NombreComercial + '%')">
    <SelectParameters>
      <asp:CookieParameter CookieName="paramComer" Name="NombreComercial" Type="String"></asp:CookieParameter>
    </SelectParameters>
  </asp:SqlDataSource>                        
  
  </section>
</asp:Content>
