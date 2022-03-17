<%@ Page Title="Tarrago Reach System" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Certificados.aspx.cs" Inherits="ReachSystem.Certificados" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server"> 
    <div class="container">
    <div class="card">
        <div class="card-header">
                <div class="form-row">
                    <div class="col10L">                        
                        <asp:Label ID="Label6" runat="server" Text="CERTIFICADO" Style="font-weight: bold; font-size: 18px;"></asp:Label>                         
                    </div>                   
                </div>
            </div>
        <div class="card-body">
                <div class="form-row">
                    <CENTER><asp:Label ID="Label2" runat="server" Text="TOMADOR" Style="font-weight: bold; font-size: 18px;"></asp:Label></CENTER><br />
                    <asp:GridView ID="GridView1" runat="server" DataSourceID="SqlDataSource1" AutoGenerateColumns="False" GridLines="None" BackColor="White" BorderStyle="None" BorderWidth="1px" CellPadding="20" ForeColor="Black" CssClass="mGrid" PagerStyle-CssClass="pgr" margin-left="2%" AlternatingRowStyle-CssClass="alt" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                        <Columns>                            
                            <asp:BoundField DataField="NombreComercial" HeaderText="ENTIDAD TOMADORA" SortExpression="NombreComercial"></asp:BoundField>
                            <asp:BoundField DataField="NumeroCertificado" HeaderText="CERTIFICADO" SortExpression="NumeroCertificado"></asp:BoundField>                            
                            <asp:BoundField DataField="Estado" HeaderText="ESTADO" SortExpression="Estado"></asp:BoundField>
                            <asp:BoundField DataField="Nombre" HeaderText="NOMBRE COMPLETO" SortExpression="Nombre"></asp:BoundField>
                            <asp:BoundField DataField="Cedula" HeaderText="CEDULA" SortExpression="Cedula"></asp:BoundField>
                            <asp:BoundField DataField="FechaNac" HeaderText="FECHA DE NACIMIENTO" SortExpression="FechaNac"></asp:BoundField>
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
                    <asp:SqlDataSource runat="server" ID="SqlDataSource1" ConnectionString='<%$ ConnectionStrings:affisDBConnectionString %>' SelectCommand="SELECT [NombreComercial], [NumeroCertificado], [Estado], [Nombre], [Cedula], [FechaNac] FROM [Asegurados] WHERE ([Cedula] = @Cedula) AND ([NumeroCertificado] = @NumeroCertificado)">
                        <SelectParameters>                            
                            <asp:CookieParameter CookieName="paramCedula" Name="Cedula" Type="Int64"></asp:CookieParameter>
                            <asp:CookieParameter CookieName="paramCert" Name="NumeroCertificado" Type="Int32"></asp:CookieParameter>
                        </SelectParameters>
                    </asp:SqlDataSource>                        
                    <asp:GridView ID="GridView2" runat="server" DataSourceID="SqlDataSource2" AutoGenerateColumns="False" GridLines="None" BackColor="White" BorderStyle="None" BorderWidth="1px" CellPadding="20" ForeColor="Black" CssClass="mGrid" PagerStyle-CssClass="pgr" margin-left="2%" AlternatingRowStyle-CssClass="alt" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                        <Columns>                            
                            <asp:BoundField DataField="telfdomicilio" HeaderText="TELEFONO DOMICILIO" SortExpression="telfdomicilio"></asp:BoundField>
                            <asp:BoundField DataField="telfcelular" HeaderText="TELEFONO CELULAR" SortExpression="telfcelular"></asp:BoundField>                            
                            <asp:BoundField DataField="telfempresa" HeaderText="TELEFONO EMPRESA" SortExpression="telfempresa"></asp:BoundField>
                            <asp:BoundField DataField="Email" HeaderText="EMAIL" SortExpression="Email"></asp:BoundField>
                            <asp:BoundField DataField="DireccionEmpleador" HeaderText="DIRECCION EMPLEADOR" SortExpression="DireccionEmpleador"></asp:BoundField>                            
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
                    <asp:SqlDataSource runat="server" ID="SqlDataSource2" ConnectionString='<%$ ConnectionStrings:affisDBConnectionString %>' SelectCommand="SELECT [telfdomicilio], [telfcelular], [telfempresa], [Email], [DireccionEmpleador] FROM [Asegurados] WHERE ([Cedula] = @Cedula) AND ([NumeroCertificado] = @NumeroCertificado)">
                        <SelectParameters>                            
                            <asp:CookieParameter CookieName="paramCedula" Name="Cedula" Type="Int64"></asp:CookieParameter>
                            <asp:CookieParameter CookieName="paramCert" Name="NumeroCertificado" Type="Int32"></asp:CookieParameter>
                        </SelectParameters>
                    </asp:SqlDataSource>  
                    <hr />
                     <CENTER><asp:Label ID="Label1" runat="server" Text="ASEGURADOS" Style="font-weight: bold; font-size: 18px;"></asp:Label></CENTER><br />
                   <asp:GridView ID="GridView3" runat="server" DataSourceID="SqlDataSource3" AutoGenerateColumns="False" GridLines="None" BackColor="White" BorderStyle="None" BorderWidth="1px" CellPadding="20" ForeColor="Black" CssClass="mGrid" PagerStyle-CssClass="pgr" margin-left="2%" AlternatingRowStyle-CssClass="alt" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                        <Columns>                            
                            <asp:BoundField DataField="Nombre" HeaderText="NOMBRE COMPLETO" SortExpression="Nombre"></asp:BoundField>
                            <asp:BoundField DataField="Cedula" HeaderText="CEDULA" SortExpression="Cedula"></asp:BoundField>
                            <asp:BoundField DataField="Relacion" HeaderText="RELACION" SortExpression="Relacion"></asp:BoundField>
                             <asp:BoundField DataField="FechaNac" HeaderText="FECHA DE NACIMIENTO" SortExpression="FechaNac"></asp:BoundField>
                            <asp:BoundField DataField="Producto" HeaderText="COBERTURA" SortExpression="Producto"></asp:BoundField>
                            <asp:BoundField DataField="Plan" HeaderText="PLAN" SortExpression="Plan"></asp:BoundField>
                            <asp:BoundField DataField="TotalPrima" HeaderText="TOTAL PRIMA" SortExpression="TotalPrima"></asp:BoundField>
                            <asp:BoundField DataField="FechaVigencia" HeaderText="INICIO VIGENCIA" SortExpression="FechaVigencia"></asp:BoundField>
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
                    <asp:SqlDataSource runat="server" ID="SqlDataSource3" ConnectionString='<%$ ConnectionStrings:affisDBConnectionString %>' SelectCommand="SELECT [Nombre], [Cedula], [Relacion], [FechaNac], [Producto], [Plan], [TotalPrima], [FechaVigencia] FROM [Dependientes] WHERE ([CedulaTomador] = @CedulaTomador) AND ([NumeroCertificado] = @NumeroCertificado)">
                        <SelectParameters>
                            <asp:CookieParameter CookieName="paramCedula" Name="CedulaTomador" Type="Int64"></asp:CookieParameter>
                            <asp:CookieParameter CookieName="paramCert" Name="NumeroCertificado" Type="Int32"></asp:CookieParameter>
                        </SelectParameters>
                    </asp:SqlDataSource>  
                    <asp:GridView ID="GridView4" runat="server" DataSourceID="SqlDataSource4" AutoGenerateColumns="False" GridLines="None" BackColor="White" BorderStyle="None" BorderWidth="1px" CellPadding="20" ForeColor="Black" CssClass="mGrid" PagerStyle-CssClass="pgr" margin-left="2%" AlternatingRowStyle-CssClass="alt" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                        <Columns>                            
                            <asp:BoundField DataField="Codigo" HeaderText="CODIGO" SortExpression="Codigo"></asp:BoundField>
                            <asp:BoundField DataField="MedioDeCobro" HeaderText="MEDIO DE COBRO" SortExpression="MedioDeCobro"></asp:BoundField>
                            <asp:BoundField DataField="Ejecutivo" HeaderText="EJECUTIVO" SortExpression="Ejecutivo"></asp:BoundField>
                            <asp:BoundField DataField="TotalCobrar" HeaderText="TOTAL" SortExpression="TotalCobrar"></asp:BoundField>
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
                    <asp:SqlDataSource runat="server" ID="SqlDataSource4" ConnectionString='<%$ ConnectionStrings:affisDBConnectionString %>' SelectCommand="SELECT [Codigo], [MedioDeCobro], [Ejecutivo], [TotalCobrar] FROM [Asegurados] WHERE ([Cedula] = @Cedula) AND ([NumeroCertificado] = @NumeroCertificado)">
                        <SelectParameters>
                            <asp:CookieParameter CookieName="paramCedula" Name="Cedula" Type="Int64"></asp:CookieParameter>
                            <asp:CookieParameter CookieName="paramCert" Name="NumeroCertificado" Type="Int32"></asp:CookieParameter>
                        </SelectParameters>
                    </asp:SqlDataSource>  
                    <hr />
                    <CENTER>
                    <asp:Button  value="REGISTRARME" type="submit" runat="server" CssClass="botonsubmitTRES" Text="VOLVER" ID="CANCEL" OnClick="Unnamed1_Click" UseSubmitBehavior="False" />                      
                        <asp:Button  value="REGISTRARME" type="submit" runat="server" CssClass="botonsubmitTRES" Text="ADICIONAR" ID="Button1" OnClick="Unnamed2_Click" UseSubmitBehavior="False" />                      
                        <asp:Button  value="REGISTRARME" type="submit" runat="server" CssClass="botonsubmitTRES" Text="REEMPLAZAR" ID="Button2" OnClick="Unnamed3_Click" UseSubmitBehavior="False" />                      
                    </CENTER>   
                    <hr />
                    <CENTER>
                    <Button  value="REGISTRARME" type="submit" runat="server" Class="botonsubmitCUATRO" ID="Button3" OnServerClick="descarga1" UseSubmitBehavior="False" >CERTIFICADO <i class="fa fa-file-pdf-o"></i></Button>      
                        <Button  value="REGISTRARME" type="submit" runat="server" Class="botonsubmitCUATRO" ID="Button4" OnServerClick="descarga2" UseSubmitBehavior="False" >CARTA  <i class="fa fa-file-pdf-o"></i></Button> 
                        <Button  value="REGISTRARME" type="submit" runat="server" Class="botonsubmitCUATRO" ID="Button5" OnServerClick="descarga3" UseSubmitBehavior="False" >OTROS <i class="fa fa-file-pdf-o"></i></Button> 
                        <%--<asp:Button  value="REGISTRARME" type="submit" runat="server" CssClass="botonsubmitCUATRO" Text="CARTA DE EXCLUSION" ID="Button4" OnClick="descarga2" UseSubmitBehavior="False" >    <i class="fa fa-file-pdf-o"></i>   </asp:Button>                
                       <asp:Button  value="REGISTRARME" type="submit" runat="server" CssClass="botonsubmitCUATRO" Text="CARTA DE RETENCION" ID="Button5" OnClick="descarga3" UseSubmitBehavior="False" > <i class="fa fa-file-pdf-o"></i>  </asp:Button>         --%>          
                    </CENTER>
                    
                </div>
            </div>
        </div>
        </div>
    
</asp:Content>
