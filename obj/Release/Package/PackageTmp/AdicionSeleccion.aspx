<%@ Page Title="Tarrago Reach System" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AdicionSeleccion.aspx.cs" Inherits="ReachSystem.AdicionSeleccion" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server"> 
    <div class="container">
    <div class="card">
        <div class="card-header">
                <div class="form-row">
                    <div class="col10L">                        
                        <asp:Label ID="Label6" runat="server" Text="ADICION: SELECCION" Style="font-weight: bold; font-size: 18px;"></asp:Label>                         
                        <asp:Label ID="Label2" runat="server" Text="PROCESAR CERTIFICADO: SELECCION" Style="font-weight: bold; font-size: 18px;"></asp:Label> 
                        <asp:Label ID="Label3" runat="server" Text="REEMPLAZO: SELECCION" Style="font-weight: bold; font-size: 18px;"></asp:Label> 
                        <asp:Label ID="Label4" runat="server" Text="RECLAMO: SELECCION" Style="font-weight: bold; font-size: 18px;"></asp:Label>
                    </div>                   
                </div>
            </div>
        <div class="card-body">
                <div class="form-row"> 
                    <CENTER><asp:Label ID="Label7" runat="server" Text="ADICIONES" Style="font-weight: bold; font-size: 18px;"></asp:Label></CENTER><br />
                     <asp:GridView ID="GridView5" runat="server" DataSourceID="SqlDataSource2" AutoGenerateColumns="False" GridLines="None" BackColor="White" BorderStyle="None" BorderWidth="1px" CellPadding="20" ForeColor="Black" CssClass="mGrid" PagerStyle-CssClass="pgr" margin-left="2%" AlternatingRowStyle-CssClass="alt" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                        <Columns>  
                            <asp:BoundField DataField="Cedula" HeaderText="CEDULA" SortExpression="Cedula"></asp:BoundField>
                            <asp:BoundField DataField="Nombre" HeaderText="NOMBRES COMPLETOS" SortExpression="Nombre"></asp:BoundField>
                            <asp:BoundField DataField="Genero" HeaderText="GENERO" SortExpression="Genero"></asp:BoundField>
                            
                            <asp:BoundField DataField="Relacion" HeaderText="RELACION" SortExpression="Relacion"></asp:BoundField>
                             <asp:BoundField DataField="FechaNac" HeaderText="FECHA DE NACIMIENTO" SortExpression="FechaNac"></asp:BoundField>
                            <asp:BoundField DataField="Producto" HeaderText="COBERTURA" SortExpression="Producto"></asp:BoundField>
                            <asp:BoundField DataField="Plan" HeaderText="PLAN" SortExpression="Plan"></asp:BoundField>
                            <asp:BoundField DataField="TotalPrima" HeaderText="TOTAL PRIMA" SortExpression="TotalPrima"></asp:BoundField>
                            <asp:BoundField DataField="FechaVigencia" HeaderText="INICIO VIGENCIA" SortExpression="FechaVigencia"></asp:BoundField>
                            <%--<asp:CommandField ShowSelectButton="True" ButtonType="Button" SelectText="ADICIONAR COBERTURAS" ></asp:CommandField> --%>                           
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
                     <CENTER><asp:Label ID="Label1" runat="server" Text="ASEGURADOS" Style="font-weight: bold; font-size: 18px;"></asp:Label></CENTER><br />
                   <asp:GridView ID="GridView3" runat="server" DataSourceID="SqlDataSource1" AutoGenerateColumns="False" GridLines="None" BackColor="White" BorderStyle="None" BorderWidth="1px" CellPadding="20" ForeColor="Black" CssClass="mGrid" PagerStyle-CssClass="pgr" margin-left="2%" AlternatingRowStyle-CssClass="alt" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                        <Columns>  
                            <asp:BoundField DataField="Cedula" HeaderText="CEDULA" SortExpression="Cedula"></asp:BoundField>
                            <asp:BoundField DataField="Nombre" HeaderText="NOMBRES COMPLETOS" SortExpression="Nombre"></asp:BoundField>
                            <asp:BoundField DataField="Genero" HeaderText="GENERO" SortExpression="Genero"></asp:BoundField>
                            
                            <asp:BoundField DataField="Relacion" HeaderText="RELACION" SortExpression="Relacion"></asp:BoundField>
                             <asp:BoundField DataField="FechaNac" HeaderText="FECHA DE NACIMIENTO" SortExpression="FechaNac"></asp:BoundField>
                            <asp:BoundField DataField="Producto" HeaderText="COBERTURA" SortExpression="Producto"></asp:BoundField>
                            <asp:BoundField DataField="Plan" HeaderText="PLAN" SortExpression="Plan"></asp:BoundField>
                            <asp:BoundField DataField="TotalPrima" HeaderText="TOTAL PRIMA" SortExpression="TotalPrima"></asp:BoundField>
                            <asp:BoundField DataField="FechaVigencia" HeaderText="INICIO VIGENCIA" SortExpression="FechaVigencia"></asp:BoundField>
                            <asp:CommandField ShowSelectButton="True" ButtonType="Button" SelectText="ADICIONAR COBERTURAS" ></asp:CommandField>                            
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
                   
                    <asp:GridView ID="GridView1" runat="server" DataSourceID="SqlDataSource3" AutoGenerateColumns="False" GridLines="None" BackColor="White" BorderStyle="None" BorderWidth="1px" CellPadding="20" ForeColor="Black" CssClass="mGrid" PagerStyle-CssClass="pgr" margin-left="2%" AlternatingRowStyle-CssClass="alt" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                        <Columns>  
                            <asp:BoundField DataField="Cedula" HeaderText="CEDULA" SortExpression="Cedula"></asp:BoundField>
                            <asp:BoundField DataField="Nombre" HeaderText="NOMBRES COMPLETOS" SortExpression="Nombre"></asp:BoundField>
                            <asp:BoundField DataField="Genero" HeaderText="GENERO" SortExpression="Genero"></asp:BoundField>
                            
                            <asp:BoundField DataField="Relacion" HeaderText="RELACION" SortExpression="Relacion"></asp:BoundField>
                             <asp:BoundField DataField="FechaNac" HeaderText="FECHA DE NACIMIENTO" SortExpression="FechaNac"></asp:BoundField>
                            <asp:BoundField DataField="Producto" HeaderText="COBERTURA" SortExpression="Producto"></asp:BoundField>
                            <asp:BoundField DataField="Plan" HeaderText="PLAN" SortExpression="Plan"></asp:BoundField>
                            <asp:BoundField DataField="TotalPrima" HeaderText="TOTAL PRIMA" SortExpression="TotalPrima"></asp:BoundField>
                            <asp:BoundField DataField="FechaVigencia" HeaderText="INICIO VIGENCIA" SortExpression="FechaVigencia"></asp:BoundField>
                            <asp:BoundField DataField="row" HeaderText="ID" SortExpression="row"></asp:BoundField>
                            <asp:CommandField ShowSelectButton="True" ButtonType="Button" SelectText="EDITAR" ></asp:CommandField>                            
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
                    <asp:GridView ID="GridView2" runat="server" DataSourceID="SqlDataSource3" AutoGenerateColumns="False" GridLines="None" BackColor="White" BorderStyle="None" BorderWidth="1px" CellPadding="20" ForeColor="Black" CssClass="mGrid" PagerStyle-CssClass="pgr" margin-left="2%" AlternatingRowStyle-CssClass="alt" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                        <Columns>      
                            <asp:BoundField DataField="Cedula" HeaderText="CEDULA" SortExpression="Cedula"></asp:BoundField>
                            <asp:BoundField DataField="Nombre" HeaderText="NOMBRES COMPLETOS" SortExpression="Nombre"></asp:BoundField>
                            <asp:BoundField DataField="Genero" HeaderText="GENERO" SortExpression="Genero"></asp:BoundField>                            
                            <asp:BoundField DataField="Relacion" HeaderText="RELACION" SortExpression="Relacion"></asp:BoundField>
                             <asp:BoundField DataField="FechaNac" HeaderText="FECHA DE NACIMIENTO" SortExpression="FechaNac"></asp:BoundField>
                            <asp:BoundField DataField="Producto" HeaderText="COBERTURA" SortExpression="Producto"></asp:BoundField>
                            <asp:BoundField DataField="Plan" HeaderText="PLAN" SortExpression="Plan"></asp:BoundField>
                            <asp:BoundField DataField="TotalPrima" HeaderText="TOTAL PRIMA" SortExpression="TotalPrima"></asp:BoundField>
                            <asp:BoundField DataField="FechaVigencia" HeaderText="INICIO VIGENCIA" SortExpression="FechaVigencia"></asp:BoundField>
                            <asp:CommandField ShowSelectButton="True" ButtonType="Button" SelectText="REEMPLAZAR COBERTURA" ></asp:CommandField>                            
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
                    <asp:GridView ID="GridView4" runat="server" DataSourceID="SqlDataSource3" AutoGenerateColumns="False" GridLines="None" BackColor="White" BorderStyle="None" BorderWidth="1px" CellPadding="20" ForeColor="Black" CssClass="mGrid" PagerStyle-CssClass="pgr" margin-left="2%" AlternatingRowStyle-CssClass="alt" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
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
                            <asp:CommandField ShowSelectButton="True" ButtonType="Button" SelectText="SELECCIONAR ASEGURADO" ></asp:CommandField>                            
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
                    <asp:SqlDataSource runat="server" ID="SqlDataSource3" ConnectionString='<%$ ConnectionStrings:affisDBConnectionString %>' SelectCommand="SELECT [Nombre], [Genero], [Cedula], [Relacion], [FechaNac], [Producto], [Plan], [TotalPrima], [FechaVigencia], [Row] FROM [Dependientes] WHERE ([CedulaTomador] = @CedulaTomador) AND ([NumeroCertificado] = @NumeroCertificado) AND Estado <>'EXCLUIDO'">
                        <SelectParameters>
                            <asp:CookieParameter CookieName="paramCedula" Name="CedulaTomador" Type="Int64"></asp:CookieParameter>
                            <asp:CookieParameter CookieName="paramCert" Name="NumeroCertificado" Type="Int32"></asp:CookieParameter>
                        </SelectParameters>
                    </asp:SqlDataSource>      
                    <asp:SqlDataSource runat="server" ID="SqlDataSource1" ConnectionString='<%$ ConnectionStrings:affisDBConnectionString %>' SelectCommand="SELECT [Nombre], [Genero], [Cedula], [Relacion], [FechaNac], [Producto], [Plan], [TotalPrima], [FechaVigencia] FROM [Dependientes] WHERE ([CedulaTomador] = @CedulaTomador) AND ([NumeroCertificado] = @NumeroCertificado)  AND ([FechaVenta] <> @Fecha)">
                        <SelectParameters>
                            <asp:CookieParameter CookieName="paramCedula" Name="CedulaTomador" Type="Int64"></asp:CookieParameter>
                            <asp:CookieParameter CookieName="paramCert" Name="NumeroCertificado" Type="Int32"></asp:CookieParameter>
                            <asp:CookieParameter CookieName="fechaC" Name="Fecha" Type="DateTime"></asp:CookieParameter>
                        </SelectParameters>
                    </asp:SqlDataSource>  
                    <asp:SqlDataSource runat="server" ID="SqlDataSource2" ConnectionString='<%$ ConnectionStrings:affisDBConnectionString %>' SelectCommand="SELECT [Nombre], [Genero], [Cedula], [Relacion], [FechaNac], [Producto], [Plan], [TotalPrima], [FechaVigencia] FROM [Dependientes] WHERE ([CedulaTomador] = @CedulaTomador) AND ([NumeroCertificado] = @NumeroCertificado) AND ([FechaVenta] = @Fecha)">
                        <SelectParameters>
                            <asp:CookieParameter CookieName="paramCedula" Name="CedulaTomador" Type="Int64"></asp:CookieParameter>
                            <asp:CookieParameter CookieName="paramCert" Name="NumeroCertificado" Type="Int32"></asp:CookieParameter>
                            <asp:CookieParameter CookieName="fechaC" Name="Fecha" Type="DateTime"></asp:CookieParameter>
                        </SelectParameters>
                    </asp:SqlDataSource>  
                    <hr />
                     <asp:Label ID="Label5" runat="server" Style="font-weight: bold; font-size: 18px; margin-left:52%; color:green;"></asp:Label>
                    
                    <hr />
                    <CENTER>
                    <asp:Button  value="REGISTRARME" type="submit" runat="server" CssClass="botonsubmitTRES" Text="CANCELAR" OnClick="cancelar" ID="CANCEL" UseSubmitBehavior="False" />  
                    <asp:Button  value="REGISTRARME" type="submit" runat="server" CssClass="botonsubmitTRES" Text="VOLVER" ID="INCLU" UseSubmitBehavior="False" OnClick="siguiclick"/>  
                         <asp:Button  value="REGISTRARME" type="submit" runat="server" CssClass="botonsubmitTRES" Text="VOLVER" ID="Button3" UseSubmitBehavior="False" OnClick="volverclick"/>  
                    <asp:Button  value="REGISTRARME" type="submit" runat="server" CssClass="botonsubmitTRES" Text="SIGUIENTE" OnClick="siguiclick" ID="siguiente"/>  
                          
                    <asp:Button  value="REGISTRARME" type="submit" runat="server" CssClass="botonsubmitTRES" Text="ADICIONAR ASEGURADO" ID="ADIC" OnClick="Unnamed1_Click"/>
                        <asp:Button  value="REGISTRARME" type="submit" runat="server" CssClass="botonsubmitTRES" Text="ELIMINAR COBERTURA" ID="Button1" OnClick="elim"/>
                        <asp:Button  value="REGISTRARME" type="submit" runat="server" CssClass="botonsubmitTRES" Text="FINALIZAR" OnClick="siguiclick" ID="Button2"/>
                    </CENTER>                                        
                </div>
            </div>
        </div>
        </div>    
</asp:Content>
