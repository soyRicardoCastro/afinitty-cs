<%@ Page Title="Tarrago Reach System" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MedioCobro.aspx.cs" Inherits="ReachSystem.MedioCobro" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server"> 
    <div class="container">
    <div class="card">
        <div class="card-header">
                <div class="form-row">
                    <div class="col10L">                        
                        <asp:Label ID="Label6" runat="server" Text="PROCESAR CERTIFICADO: MEDIO DE COBRO" Style="font-weight: bold; font-size: 18px;"></asp:Label>                        
                    </div>                   
                </div>
            </div>
        <div class="card-body">
                <div class="form-row">  
                    <asp:GridView ID="GridView4" runat="server" DataSourceID="SqlDataSource3" AutoGenerateColumns="False" GridLines="None" BackColor="White" BorderStyle="None" BorderWidth="1px" CellPadding="20" ForeColor="Black" CssClass="mGrid" PagerStyle-CssClass="pgr" margin-left="2%" AlternatingRowStyle-CssClass="alt" >
                        <Columns>   
                            <asp:BoundField DataField="Cedula" HeaderText="CEDULA" SortExpression="Cedula"></asp:BoundField>
                            <asp:BoundField DataField="Nombre" HeaderText="NOMBRES COMPLETOS" SortExpression="Nombre"></asp:BoundField>
                           <%-- <asp:BoundField DataField="Genero" HeaderText="GENERO" SortExpression="Genero"></asp:BoundField>--%>                            
                            <asp:BoundField DataField="Relacion" HeaderText="RELACION" SortExpression="Relacion"></asp:BoundField>
                             <asp:BoundField DataField="FechaNac" HeaderText="FECHA DE NACIMIENTO" SortExpression="FechaNac"></asp:BoundField>
                            <asp:BoundField DataField="Producto" HeaderText="COBERTURA" SortExpression="Producto"></asp:BoundField>
                            <asp:BoundField DataField="Plan" HeaderText="PLAN" SortExpression="Plan"></asp:BoundField>
                            <asp:BoundField DataField="TotalPrima" HeaderText="TOTAL PRIMA" SortExpression="TotalPrima"></asp:BoundField>
                            <asp:BoundField DataField="FechaVigencia" HeaderText="INICIO VIGENCIA" SortExpression="FechaVigencia"></asp:BoundField>
                           <%-- <asp:CommandField ShowSelectButton="True" ButtonType="Button" SelectText="SELECCIONAR ASEGURADO" ></asp:CommandField> --%>                           
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
                    <asp:SqlDataSource runat="server" ID="SqlDataSource3" ConnectionString='<%$ ConnectionStrings:affisDBConnectionString %>' SelectCommand="SELECT [Nombre], [Genero], [Cedula], [Relacion], [FechaNac], [Producto], [Plan], [TotalPrima], [FechaVigencia], [Row] FROM [Dependientes] WHERE ([CedulaTomador] = @CedulaTomador) AND ([NumeroCertificado] = @NumeroCertificado)">
                        <SelectParameters>
                            <asp:CookieParameter CookieName="paramCedula" Name="CedulaTomador" Type="Int64"></asp:CookieParameter>
                            <asp:CookieParameter CookieName="paramCert" Name="NumeroCertificado" Type="Int32"></asp:CookieParameter>
                        </SelectParameters>
                    </asp:SqlDataSource> 
                    <hr />
                    <table style="width: 100%">
                        <tr>
                            <td>
                                <asp:Label ID="Label9" runat="server" Text="PRIMA CERTIFICADO $" Style="font-weight: bold; font-size: 18px; margin-left:300px;"></asp:Label><br />
                            </td>
                            <td>
                                <asp:Label ID="prefifin" runat="server" CssClass="formularioFin" style="margin-right:60px;"></asp:Label>
                            </td>
                        </tr>
                    </table>
                    <hr />
                    <table style="width: 100%;">
                        
                        <tr>
                            <td><asp:Label ID="Label4" runat="server" Text="MEDIO DE COBRO" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                                <asp:DropDownList ID="DropDownList1" runat="server" CssClass="formularioProc2" DataSourceID="SqlDataSource1" DataTextField="Medio" DataValueField="Medio" onselectedindexchanged="itemSelected" AutoPostBack="True">
                                </asp:DropDownList>
                                <asp:SqlDataSource runat="server" ID="SqlDataSource1"  ConnectionString='<%$ ConnectionStrings:affisDBConnectionString %>'  SelectCommand="SELECT [Medio] FROM [Medios] WHERE ([NombreComercial] = @NombreComercial)" >
                                    <SelectParameters>
                                        <asp:CookieParameter CookieName="paramEmp" Name="NombreComercial" Type="String"></asp:CookieParameter>
                                    </SelectParameters>
                                </asp:SqlDataSource>
                            </td>
                            <td><asp:Label ID="Label5" runat="server" Text="BANCO" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                                <input class="formularioProc2" placeholder="BANCO" id="Text1" type="text" runat="server"/><br />
                            </td>
                            <td><asp:Label ID="Label15" runat="server" Text="TIPO DE CUENTA" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                                <input class="formularioProcDOS" name="asegurado" id="Radio1" type="radio" runat="server"  /><label id="ahorros" runat="server">AHORROS </label>
                                <input class="formularioProcDOS" name="asegurado" id="Radio2" type="radio" runat="server"  /><label id="corriente" runat="server">CORRIENTE </label></td>                            
                        </tr>
                        <tr>
                            <td>&nbsp;</td>
                            <td><asp:Label ID="Label7" runat="server" Text="CUENTA NUMERO" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                                <input class="formularioProc2" placeholder="CUENTA NUMERO" id="Text4" type="text" runat="server"/><br />

                            </td>
                            <td>&nbsp;</td>                            
                        </tr>
                         <tr>
                            <td>&nbsp;</td>
                            <td><asp:Label ID="Label1" runat="server" Text="TARJETA DE CREDITO" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                                <input class="formularioProc2" placeholder="NOMBRE TC" id="Text2" type="text" runat="server"/><br />

                            </td>
                            <td><asp:Label ID="Label2" runat="server" Text="NUMERO" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                                <input class="formularioProc2" placeholder="NUMERO" id="Text8" type="number" runat="server"/><br /></td>                            
                        </tr>
                        <tr>
                            <td>&nbsp;</td>
                            <td><asp:Label ID="Label3" runat="server" Text="VENCIMIENTO" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                                <input class="formularioProc2" placeholder="VENCIMIENTO" id="Text10" type="text" runat="server"/><br /></td>
                            <td><asp:Label ID="Label8" runat="server" Text="CODIGO DE SEGURIDAD" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                                <input class="formularioProc2" placeholder="CODIGO DE SEGURIDAD" id="Text11" type="number" runat="server"/><br /></td>                            
                        </tr>   
                        <tr>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                        </tr> 
                    </table>
                    <hr />
                                            
                    <CENTER><asp:Button runat="server" CssClass="botonsubmitTRES" text="CANCELAR" OnClick="Unnamed_Click1"></asp:Button>  
                    <asp:Button  value="REGISTRARME" type="submit" runat="server" CssClass="botonsubmitTRES" Text="VOLVER" OnClick="Unnamed_Click"/>                                                  
                        <asp:Button  value="REGISTRARME" type="submit" runat="server" CssClass="botonsubmitTRES" Text="SIGUIENTE" OnClick="Unnamed1_Click"/>                                                  
                    </CENTER>
                </div>
            </div>
        </div>
        </div>
    
</asp:Content>
