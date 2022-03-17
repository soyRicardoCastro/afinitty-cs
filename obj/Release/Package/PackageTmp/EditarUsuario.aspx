<%@Page Title="Tarrago Reach System" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EditarUsuario.aspx.cs" Inherits="ReachSystem.EditarUsuario" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server"> 
    <div class="container">
    <div class="card">
        <div class="card-header">
                <div class="form-row">
                    <div class="col10L">                        
                        <asp:Label ID="Label6" runat="server" Text="USUARIO: EDITAR" Style="font-weight: bold; font-size: 18px;"></asp:Label>                        
                    </div>                   
                </div>
            </div>
        <div class="card-body">
                <div class="form-row">
    <center><input class="formulario" placeholder="APELLIDO" id="Correo" type="text" runat="server"  AutoPostBack="true" required/><br />  
        <asp:RegularExpressionValidator Display="Dynamic" ControlToValidate="Correo" ID="MyPassordMinMaxLengthValidator" ValidationExpression="^[\s\S]{3,10}$" runat="server" ErrorMessage="LA BUSQUEDA DEBE TENER 3-10 CARACTERES"></asp:RegularExpressionValidator><br />  
        <asp:Button class="botonsubmit" value="REGISTRARME" type="submit" runat="server" CssClass="botonsubmit" Text="BASE INTERNA"  OnClick="Unnamed1_Click"/></center>    
                    
                    <hr />
                    <asp:Label ID="Label1" runat="server" Style="font-weight: bold; font-size: 18px;"></asp:Label> 
                    <asp:GridView ID="GridView1" runat="server" DataSourceID="SqlDataSource1" AutoGenerateColumns="False" AllowPaging="True" GridLines="None" BackColor="White" BorderStyle="None" BorderWidth="1px" CellPadding="20" ForeColor="Black"  CssClass="mGrid" PagerStyle-CssClass="pgr" margin-left="2%" AlternatingRowStyle-CssClass="alt" AllowSorting="True" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                        <Columns>
                            <asp:BoundField DataField="Row" HeaderText="Id" SortExpression="Row" InsertVisible="False" ReadOnly="True"></asp:BoundField>
    <asp:BoundField DataField="Nombre" HeaderText="Nombre" SortExpression="Nombre"></asp:BoundField>
    <asp:BoundField DataField="Apellido" HeaderText="Apellido" SortExpression="Apellido"></asp:BoundField>
    <asp:BoundField DataField="Correo" HeaderText="Correo" SortExpression="Correo"></asp:BoundField>
    <asp:BoundField DataField="Cargo" HeaderText="Cargo" SortExpression="Cargo"></asp:BoundField>
    <asp:BoundField DataField="FechaIngreso" HeaderText="FechaIngreso" SortExpression="FechaIngreso"></asp:BoundField>
    <asp:CommandField SelectText="EDITAR" ShowSelectButton="True" ButtonType="Button"></asp:CommandField>
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
                    <asp:SqlDataSource runat="server" ID="SqlDataSource1" ConnectionString='<%$ ConnectionStrings:affisDBConnectionString %>' SelectCommand="SELECT [Row], [Nombre], [Apellido], [Correo], [Cargo], [FechaIngreso] FROM [Usuario] WHERE ([Apellido] LIKE '%' + @Apellido + '%')">
        <SelectParameters>
            <asp:CookieParameter CookieName="buscarC" Name="Apellido" Type="String"></asp:CookieParameter>
                        </SelectParameters>
                    </asp:SqlDataSource>
                    <asp:GridView ID="GridView2" runat="server" DataSourceID="SqlDataSource2" AutoGenerateColumns="False" AllowPaging="True" GridLines="None" BackColor="White" BorderStyle="None" BorderWidth="1px" CellPadding="20" ForeColor="Black"  CssClass="mGrid" PagerStyle-CssClass="pgr" margin-left="2%" AlternatingRowStyle-CssClass="alt" AllowSorting="True" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                        <Columns>
    
    <asp:BoundField DataField="Row" HeaderText="Id" SortExpression="Row" InsertVisible="False" ReadOnly="True"></asp:BoundField>
    <asp:BoundField DataField="Nombre" HeaderText="Nombre" SortExpression="Nombre"></asp:BoundField>
    <asp:BoundField DataField="Apellido" HeaderText="Apellido" SortExpression="Apellido"></asp:BoundField>
    <asp:BoundField DataField="Cargo" HeaderText="Cargo" SortExpression="Cargo"></asp:BoundField>
    <asp:BoundField DataField="FechaIngreso" HeaderText="FechaIngreso" SortExpression="FechaIngreso"></asp:BoundField>
    <asp:CommandField ShowSelectButton="True" ButtonType="Button" SelectText="EDITAR"></asp:CommandField>
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
                    <asp:SqlDataSource runat="server" ID="SqlDataSource2" ConnectionString='<%$ ConnectionStrings:affisDBConnectionString %>' SelectCommand="SELECT [Row], [Nombre], [Apellido], [Cargo], [FechaIngreso] FROM [Usuario]">
                       
                    </asp:SqlDataSource>
                    <hr />
                                            
                    <CENTER><%--<asp:Button runat="server" CssClass="botonsubmitTRES" text="VOLVER" OnClick="Unnamed_Click1" UseSubmitBehavior="False"></asp:Button> --%> 
                    <asp:Button  value="REGISTRARME" type="submit" runat="server" CssClass="botonsubmitTRES" Text="CANCELAR" OnClick="Unnamed_Click" UseSubmitBehavior="False" />                                                  
                    </CENTER>
                </div>
            </div>
        </div>
        </div>
    
</asp:Content>
