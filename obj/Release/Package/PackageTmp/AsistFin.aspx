<%@ Page Title="Tarrago Reach System" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AsistFin.aspx.cs" Inherits="ReachSystem.AsistFin" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server"> 
    <div class="container">
    <div class="card">
        <div class="card-header">
                <div class="form-row">
                    <div class="col10L">                        
                        <asp:Label ID="Label6" runat="server" Text="ASISTENCIA" Style="font-weight: bold; font-size: 18px;"></asp:Label>                        
                    </div>                   
                </div>
            </div>
        <div class="card-body">
                <div class="form-row">  
                    <asp:Label ID="Label2" runat="server" Style="font-weight: bold; font-size: 18px;"></asp:Label>  
                     <asp:GridView ID="GridView1" runat="server" DataSourceID="SqlDataSource1" AutoGenerateColumns="False" AllowPaging="True" GridLines="None" BackColor="White" BorderStyle="None" BorderWidth="1px" CellPadding="20" ForeColor="Black"  CssClass="mGrid" PagerStyle-CssClass="pgr" margin-left="2%" AlternatingRowStyle-CssClass="alt" AllowSorting="True" >
                        <Columns>
                            
                            <asp:BoundField DataField="Nombre" HeaderText="Nombres" SortExpression="Nombre"></asp:BoundField>
                            <asp:BoundField DataField="Apellido" HeaderText="Apellidos" SortExpression="Apellido"></asp:BoundField>
                            <asp:BoundField DataField="Correo" HeaderText="Correo" SortExpression="Correo"></asp:BoundField>
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
                    <asp:SqlDataSource runat="server" ID="SqlDataSource1" ConnectionString='<%$ ConnectionStrings:affisDBConnectionString %>' SelectCommand="SELECT [Nombre], [Apellido], [Correo] FROM [Usuario] WHERE ([Nombre] = @Nombre)">
                        <SelectParameters>
                            <asp:CookieParameter CookieName="asistnombre" Name="Nombre" Type="String"></asp:CookieParameter>
                        </SelectParameters>
                    </asp:SqlDataSource>   
                    <hr />
                    <table style="width: 100%;">                        
                        <tr>
                            <td><asp:Label ID="Label4" runat="server" Text="SELECCIONE LA FECHA" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                                <input id="Number1" type="date" class="formularioProc2" runat="server" placeholder="DIAS"/>              
                            </td>
                            <td>
                                <asp:Label ID="Label1" runat="server" Text="DIAS LABORADOS" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                                <input id="Text1" type="number" class="formularioProc2" runat="server" placeholder="DIAS"/>
                            </td>                                                     
                        </tr>
                                                           
                    </table>
                    <hr />
                                            
                    <CENTER><asp:Button runat="server" CssClass="botonsubmitTRES" text="CANCELAR" OnClick="Unnamed_Click1"></asp:Button>  
                    <asp:Button  value="REGISTRARME" type="submit" runat="server" CssClass="botonsubmitTRES" Text="VOLVER" OnClick="Unnamed_Click"/>                                                  
                        <asp:Button  value="REGISTRARME" type="submit" runat="server" CssClass="botonsubmitTRES" Text="FINALIZAR" OnClick="Unnamed1_Click"/>                                                  
                    </CENTER>
                </div>
            </div>
        </div>
        </div>
    
</asp:Content>
