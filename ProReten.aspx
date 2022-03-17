<%@ Page Title="Tarrago Reach System" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ProReten.aspx.cs" Inherits="ReachSystem.ProReten" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server"> 
    <div class="container">
    <div class="card">
        <div class="card-header">
                <div class="form-row">
                                         
                    <div class="col10L">                        
                        <asp:Label ID="Label6" runat="server" Text="GESTION EXCLUSIONES" Style="font-weight: bold; font-size: 18px;"></asp:Label>                        
                    </div>                   
                </div>
            </div>
        <div class="card-body">
                <div class="form-row">
                    <asp:GridView ID="GridView1" runat="server" DataSourceID="SqlDataSource1" AutoGenerateColumns="False" AllowPaging="True" GridLines="None" BackColor="White" BorderStyle="None" BorderWidth="1px" CellPadding="20" ForeColor="Black"  CssClass="mGrid" PagerStyle-CssClass="pgr" margin-left="2%" AlternatingRowStyle-CssClass="alt" AllowSorting="True" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                        <Columns>

                            
                            <asp:BoundField DataField="NumeroCertificado" HeaderText="CERTIFICADO" SortExpression="NumeroCertificado"></asp:BoundField>
                            <asp:BoundField DataField="Nombre" HeaderText="TOMADOR" SortExpression="Nombre"></asp:BoundField>                            
                            <asp:BoundField DataField="NombreComercial" HeaderText="EMPRESA" SortExpression="NombreComercial"></asp:BoundField>
                            <asp:BoundField DataField="Ejecutivo" HeaderText="EJECUTIVO" SortExpression="Ejecutivo"></asp:BoundField>
                            <asp:BoundField DataField="procesoWSM" HeaderText="PROCESO" SortExpression="procesoWSM"></asp:BoundField>
                            <asp:BoundField DataField="Estado" HeaderText="ESTADO" SortExpression="Estado"></asp:BoundField>
                            <asp:CommandField ShowSelectButton="True" SelectText="PROCESAR" ButtonType="Button"></asp:CommandField>
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
                    <asp:SqlDataSource runat="server" ID="SqlDataSource1" ConnectionString='<%$ ConnectionStrings:affisDBConnectionString %>' SelectCommand="SELECT [NumeroCertificado], [Nombre], [NombreComercial], [Ejecutivo], [Retencion], [FechaRet], procesoWSM, Estado FROM [Asegurados] WHERE (([Cedula] = @Cedula) OR ([NumeroCertificado] = @NumeroCertificado))">
                        <SelectParameters>                            
                            <asp:CookieParameter CookieName="paramCedula" Name="Cedula" Type="Int64"></asp:CookieParameter>
                            <asp:CookieParameter CookieName="paramCedula" Name="NumeroCertificado" Type="Int32"></asp:CookieParameter>
                        </SelectParameters>
                    </asp:SqlDataSource>
                    <asp:Label ID="Label1" runat="server" Style="font-weight: bold; font-size: 18px;"></asp:Label>
    <center><input class="formulario" placeholder="CEDULA/CERTIFICADO" id="Correo" type="text" runat="server"  AutoPostBack="true" required/><br />  
        <asp:RegularExpressionValidator Display="Dynamic" ControlToValidate="Correo" ID="MyPassordMinMaxLengthValidator" ValidationExpression="^[\s\S]{3,10}$" runat="server" ErrorMessage="LA BUSQUEDA DEBE TENER 3-10 CARACTERES"></asp:RegularExpressionValidator><br />  
        <asp:Button class="botonsubmit" value="REGISTRARME" type="submit" runat="server" CssClass="botonsubmit" Text="BASE INTERNA"  OnClick="Unnamed1_Click"/></center>    
                    
                    <hr />
                    

                    <asp:GridView ID="GridView2" runat="server" DataSourceID="SqlDataSource2" AutoGenerateColumns="False" AllowPaging="True" GridLines="None" BackColor="White" BorderStyle="None" BorderWidth="1px" CellPadding="20" ForeColor="Black"  CssClass="mGrid" PagerStyle-CssClass="pgr" margin-left="2%" AlternatingRowStyle-CssClass="alt" AllowSorting="True" OnSelectedIndexChanged="GridView2_SelectedIndexChanged">
                        <Columns>

                            <asp:BoundField DataField="FechaRet" HeaderText="FECHA ASIGNACION" SortExpression="FechaRet"></asp:BoundField>
                            <asp:BoundField DataField="NombreComercial" HeaderText="EMPRESA" SortExpression="NombreComercial"></asp:BoundField>
                            <asp:BoundField DataField="Nombre" HeaderText="TOMADOR" SortExpression="Nombre"></asp:BoundField>   
                            <asp:BoundField DataField="NumeroCertificado" HeaderText="CERTIFICADO" SortExpression="NumeroCertificado"></asp:BoundField>                                                                                 
                            <asp:BoundField DataField="Responsable" HeaderText="RESPONSABLE RETENCION" SortExpression="Responsable"></asp:BoundField>
                            <asp:BoundField DataField="Retencion" HeaderText="ESTADO DE SOLICITUD" SortExpression="Retencion"></asp:BoundField>                            
                            <asp:CommandField ShowSelectButton="True" SelectText="PROCESAR" ButtonType="Button"></asp:CommandField>
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
                    <asp:SqlDataSource runat="server" ID="SqlDataSource2" ConnectionString='<%$ ConnectionStrings:affisDBConnectionString %>' SelectCommand="SELECT [NumeroCertificado], [Nombre], [NombreComercial], [Responsable], [Retencion], [FechaRet] FROM [Asegurados] WHERE Retencion IS NOT NULL">                        
                    </asp:SqlDataSource>
                    <hr />
                                            
                    <center>
                    <asp:Button  value="REGISTRARME" type="submit" runat="server" CssClass="botonsubmitTRES" Text="CANCELAR" OnClick="Unnamed_Click" UseSubmitBehavior="False" />                                                  
                    </CENTER>
                </div>
            </div>
        </div>
        </div>
    
</asp:Content>
