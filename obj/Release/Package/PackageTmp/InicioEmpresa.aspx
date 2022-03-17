<%@ Page Title="Tarrago Reach System" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="InicioEmpresa.aspx.cs" Inherits="ReachSystem.InicioEmpresa" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server"> 
    <div class="container">
    <div class="card">
        <div class="card-header">
                <div class="form-row">
                    <div class="col10L">                        
                        <asp:Label ID="Label6" runat="server" Text="APERTURA EMPRESA" Style="font-weight: bold; font-size: 18px;"></asp:Label>                        
                    </div>                   
                </div>
            </div>
        <div class="card-body">
                <div class="form-row">
                    
    <center><input class="formulario" placeholder="NOMBRE COMERCIAL" id="Correo" type="text" runat="server"  AutoPostBack="true" required/><br />
        <asp:RegularExpressionValidator Display="Dynamic" ControlToValidate="Correo" ID="MyPassordMinMaxLengthValidator" ValidationExpression="^[\s\S]{3,10}$" runat="server" ErrorMessage="LA BUSQUEDA DEBE TENER 3-10 CARACTERES"></asp:RegularExpressionValidator><br />        
        <asp:Button class="botonsubmit" value="REGISTRARME" type="submit" runat="server" CssClass="botonsubmit" Text="BASE INTERNA"  OnClick="Unnamed1_Click"/></center>    
                    
                    <hr />
                    <asp:Label ID="Label1" runat="server" Style="font-weight: bold; font-size: 18px;"></asp:Label> 
                    <asp:GridView ID="GridView1" runat="server" DataSourceID="SqlDataSource1" AutoGenerateColumns="False" AllowPaging="True" GridLines="None" BackColor="White" BorderStyle="None" BorderWidth="1px" CellPadding="20" ForeColor="Black"  CssClass="mGrid" PagerStyle-CssClass="pgr" margin-left="2%" AlternatingRowStyle-CssClass="alt" AllowSorting="True" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                        <Columns>
    <asp:BoundField DataField="NombreComercial" HeaderText="NombreComercial" SortExpression="NombreComercial"></asp:BoundField>
    <asp:BoundField DataField="Ruc" HeaderText="Ruc" SortExpression="Ruc"></asp:BoundField>
    <asp:BoundField DataField="MedioDeCobro" HeaderText="MedioDeCobro" SortExpression="MedioDeCobro"></asp:BoundField>
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
                    <hr />
                                            
                    <CENTER><%--<asp:Button runat="server" CssClass="botonsubmitTRES" text="SRI" OnClick="Unnamed_Click1"></asp:Button>  
                    <asp:Button  value="REGISTRARME" type="submit" runat="server" CssClass="botonsubmitTRES" Text="REGISTRO CIVIL" OnClick="Unnamed_Click"/> --%>                         
                        <asp:Button ID="INCLU" value="REGISTRARME" type="submit" runat="server" CssClass="botonsubmitTRES" Text="APERTURA" OnClick="Unnamed2_Click"/>   
                    </CENTER>
                </div>
            </div>
        </div>
        </div>    
</asp:Content>
