<%@ Page Title="Tarrago Reach System" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RecDos.aspx.cs" Inherits="ReachSystem.RecDos" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server"> 
    <div class="container">
    <div class="card">
        <div class="card-header">
                <div class="form-row">
                    <div class="col10L">                        
                        <asp:Label ID="Label6" runat="server" Text="RECEPCION DOCUMENTOS" Style="font-weight: bold; font-size: 18px;"></asp:Label>                                                 
                    </div>                   
                </div>
            </div>
        <div class="card-body">
                <div class="form-row">                                                                  
                    <%-- <asp:Label ID="Label1" runat="server" Text="DATOS COBRO" Style="font-weight: bold; font-size: 22px;"></asp:Label><br />
                    <hr />--%>
                    <asp:Label ID="Label32" runat="server" Text="MES DE FACTURACION:" Style="font-weight: bold; font-size: 18px; color: red;"/>
                        <asp:Label ID="Label33" runat="server"  Style="font-weight: bold; font-size: 18px; color:red;"/><br />
                    <asp:Label ID="Label1" runat="server" Text="EMPRESA:" Style="font-weight: bold; font-size: 18px; color: black;"/>
                        <asp:Label ID="Label2" runat="server"  Style="font-weight: bold; font-size: 18px; color:black;"/>
                      <hr />  
                    <CENTER><asp:Label ID="Label8" runat="server" Text="CONTACTOS DE FACTURACION" Style="font-weight: bold; font-size: 18px;"></asp:Label></CENTER>
                    <hr />  
                    <asp:GridView ID="GridView3" runat="server" DataSourceID="SqlDataSource3" AutoGenerateColumns="False" GridLines="None" BackColor="White" BorderStyle="None" BorderWidth="1px" CellPadding="20" ForeColor="Black" CssClass="mGrid" PagerStyle-CssClass="pgr" margin-left="2%" AlternatingRowStyle-CssClass="alt" AllowPaging="True" AllowSorting="True">
                        <Columns>
                            
                           
                            <asp:BoundField DataField="cf1" HeaderText="CONTACTO" SortExpression="cf1"></asp:BoundField>
                            <asp:BoundField DataField="telf1" HeaderText="TELEFONO" SortExpression="telf1"></asp:BoundField>
                            <asp:BoundField DataField="cel1" HeaderText="CELULAR" SortExpression="cel1"></asp:BoundField>
                            <asp:BoundField DataField="email1" HeaderText="EMAIL" SortExpression="email1"></asp:BoundField>
                             
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
                    <asp:SqlDataSource runat="server" ID="SqlDataSource3" ConnectionString='<%$ ConnectionStrings:affisDBConnectionString %>' SelectCommand="SELECT [cf1], [telf1], [cel1], [email1] FROM [Empresa] WHERE ([NombreComercial] = @NombreComercial)">
                        <SelectParameters>
                            <asp:CookieParameter CookieName="emprecobnom" Name="NombreComercial" Type="String"></asp:CookieParameter>
                        </SelectParameters>
                    </asp:SqlDataSource> 
                    <asp:GridView ID="GridView1" runat="server" DataSourceID="SqlDataSource1" AutoGenerateColumns="False" GridLines="None" BackColor="White" BorderStyle="None" BorderWidth="1px" CellPadding="20" ForeColor="Black" CssClass="mGrid" PagerStyle-CssClass="pgr" margin-left="2%" AlternatingRowStyle-CssClass="alt" AllowPaging="True" AllowSorting="True" >
                        <Columns>
                            
                           
                            <asp:BoundField DataField="cf2" HeaderText="CONTACTO" SortExpression="cf2"></asp:BoundField>
                            <asp:BoundField DataField="telf2" HeaderText="TELEFONO" SortExpression="telf2"></asp:BoundField>
                            <asp:BoundField DataField="cel2" HeaderText="CELULAR" SortExpression="cel2"></asp:BoundField>
                            <asp:BoundField DataField="email2" HeaderText="EMAIL" SortExpression="email2"></asp:BoundField>
                             
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
                    <asp:SqlDataSource runat="server" ID="SqlDataSource1" ConnectionString='<%$ ConnectionStrings:affisDBConnectionString %>' SelectCommand="SELECT [cf2], [telf2], [cel2], [email2] FROM [Empresa] WHERE ([NombreComercial] = @NombreComercial)">
                        <SelectParameters>
                            <asp:CookieParameter CookieName="emprecobnom" Name="NombreComercial" Type="String"></asp:CookieParameter>
                        </SelectParameters>
                    </asp:SqlDataSource> 
                    <asp:GridView ID="GridView4" runat="server" DataSourceID="SqlDataSource4" AutoGenerateColumns="False" GridLines="None" BackColor="White" BorderStyle="None" BorderWidth="1px" CellPadding="20" ForeColor="Black" CssClass="mGrid" PagerStyle-CssClass="pgr" margin-left="2%" AlternatingRowStyle-CssClass="alt" AllowPaging="True" AllowSorting="True" >
                        <Columns>
                            
                           
                            <asp:BoundField DataField="cf3" HeaderText="CONTACTO" SortExpression="cf3"></asp:BoundField>
                            <asp:BoundField DataField="telf3" HeaderText="TELEFONO" SortExpression="telf3"></asp:BoundField>
                            <asp:BoundField DataField="cel3" HeaderText="CELULAR" SortExpression="cel3"></asp:BoundField>
                            <asp:BoundField DataField="email3" HeaderText="EMAIL" SortExpression="email3"></asp:BoundField>
                             
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
                    <asp:SqlDataSource runat="server" ID="SqlDataSource4" ConnectionString='<%$ ConnectionStrings:affisDBConnectionString %>' SelectCommand="SELECT [cf3], [telf3], [cel3], [email3] FROM [Empresa] WHERE ([NombreComercial] = @NombreComercial)">
                        <SelectParameters>
                            <asp:CookieParameter CookieName="emprecobnom" Name="NombreComercial" Type="String"></asp:CookieParameter>
                        </SelectParameters>
                    </asp:SqlDataSource> 
                      <hr />  
                    <CENTER><asp:Label ID="Label11" runat="server" Text="CONTACTOS DEL LISTADO" Style="font-weight: bold; font-size: 18px;"></asp:Label></CENTER>
                    <hr />  
                    
                    <asp:GridView ID="GridView2" runat="server" DataSourceID="SqlDataSource2" AutoGenerateColumns="False" GridLines="None" BackColor="White" BorderStyle="None" BorderWidth="1px" CellPadding="20" ForeColor="Black" CssClass="mGrid" PagerStyle-CssClass="pgr" margin-left="2%" AlternatingRowStyle-CssClass="alt" AllowPaging="True" AllowSorting="True">
                        <Columns>
                            
                           
                            <asp:BoundField DataField="cdl1" HeaderText="CONTACTO" SortExpression="cdl1"></asp:BoundField>
                            <asp:BoundField DataField="cdl2" HeaderText="TELEFONO" SortExpression="cdl2"></asp:BoundField>
                            <asp:BoundField DataField="tdl1" HeaderText="CELULAR" SortExpression="tdl1"></asp:BoundField>
                            <asp:BoundField DataField="tdl2" HeaderText="EMAIL" SortExpression="tdl2"></asp:BoundField>
                             
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
                    <asp:SqlDataSource runat="server" ID="SqlDataSource2" ConnectionString='<%$ ConnectionStrings:affisDBConnectionString %>' SelectCommand="SELECT [cdl1], [cdl2], [tdl1], [tdl2] FROM [Empresa] WHERE ([NombreComercial] = @NombreComercial)">
                        <SelectParameters>
                            <asp:CookieParameter CookieName="emprecobnom" Name="NombreComercial" Type="String"></asp:CookieParameter>
                        </SelectParameters>
                    </asp:SqlDataSource>   
                    <asp:GridView ID="GridView5" runat="server" DataSourceID="SqlDataSource5" AutoGenerateColumns="False" GridLines="None" BackColor="White" BorderStyle="None" BorderWidth="1px" CellPadding="20" ForeColor="Black" CssClass="mGrid" PagerStyle-CssClass="pgr" margin-left="2%" AlternatingRowStyle-CssClass="alt" AllowPaging="True" AllowSorting="True">
                        <Columns>
                            
                           
                            <asp:BoundField DataField="ccdl1" HeaderText="CONTACTO" SortExpression="ccdl1"></asp:BoundField>
                            <asp:BoundField DataField="ccdl2" HeaderText="TELEFONO" SortExpression="ccdl2"></asp:BoundField>
                            <asp:BoundField DataField="edl1" HeaderText="CELULAR" SortExpression="edl1"></asp:BoundField>
                            <asp:BoundField DataField="edl2" HeaderText="EMAIL" SortExpression="edl2"></asp:BoundField>
                             
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
                    <asp:SqlDataSource runat="server" ID="SqlDataSource5" ConnectionString='<%$ ConnectionStrings:affisDBConnectionString %>' SelectCommand="SELECT [ccdl1], [ccdl2], [edl1], [edl2] FROM [Empresa] WHERE ([NombreComercial] = @NombreComercial)">
                        <SelectParameters>
                            <asp:CookieParameter CookieName="emprecobnom" Name="NombreComercial" Type="String"></asp:CookieParameter>
                        </SelectParameters>
                    </asp:SqlDataSource>   
                      <hr />  
                   <%-- <CENTER><asp:Label ID="Label12" runat="server" Text="CONTACTOS DE COBRANZA" Style="font-weight: bold; font-size: 18px;"></asp:Label></CENTER>
                    <hr />  
                    
           <asp:GridView ID="GridView1" runat="server" DataSourceID="SqlDataSource1" AutoGenerateColumns="False" GridLines="None" BackColor="White" BorderStyle="None" BorderWidth="1px" CellPadding="20" ForeColor="Black" CssClass="mGrid" PagerStyle-CssClass="pgr" margin-left="2%" AlternatingRowStyle-CssClass="alt" AllowPaging="True" AllowSorting="True">
                        <Columns>
                            
                           
                            <asp:BoundField DataField="cf3" HeaderText="CONTACTO" SortExpression="cf3"></asp:BoundField>
                            <asp:BoundField DataField="telf3" HeaderText="TELEFONO" SortExpression="telf3"></asp:BoundField>
                            <asp:BoundField DataField="cel3" HeaderText="CELULAR" SortExpression="cel3"></asp:BoundField>
                            <asp:BoundField DataField="email3" HeaderText="EMAIL" SortExpression="email3"></asp:BoundField>
                             
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
                    <asp:SqlDataSource runat="server" ID="SqlDataSource1" ConnectionString='<%$ ConnectionStrings:affisDBConnectionString %>' SelectCommand="SELECT [cf3], [telf3], [cel3], [email3] FROM [Empresa] WHERE ([NombreComercial] = @NombreComercial)">
                        <SelectParameters>
                            <asp:CookieParameter CookieName="emprecobnom" Name="NombreComercial" Type="String"></asp:CookieParameter>
                        </SelectParameters>
                    </asp:SqlDataSource> 
                    <hr />
                   --%>
                    <CENTER>
                        <asp:Button  value="REGISTRARME" type="submit" runat="server" CssClass="botonsubmitTRES" Text="FACTURA RECIBIDA" ID="Button2"  OnClick="PAGARDOS"/>
                       <asp:Button  value="REGISTRARME" type="submit" runat="server" CssClass="botonsubmitTRES" Text="LISTADO RECIBIDO" ID="Button4"  OnClick="PAGAR"/>
                    <asp:Button  value="REGISTRARME" type="submit" runat="server" CssClass="botonsubmitTRES" Text="CANCELAR" ID="CANCEL" UseSubmitBehavior="False" OnClick="siguiclick"/>                                                              
                        <asp:Button  value="REGISTRARME" type="submit" runat="server" CssClass="botonsubmitTRES" Text="VOLVER" ID="Button1" UseSubmitBehavior="False" OnClick="siguiclickDOS"/>                                                              
                    </CENTER>                                        
                </div>
            </div>
        </div>
        </div>    
</asp:Content>
