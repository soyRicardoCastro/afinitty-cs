<%@ Page Title="Tarrago Reach System" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Reclamos.aspx.cs" Inherits="ReachSystem.Reclamos" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server"> 
    <div class="container">
    <div class="card">
        <div class="card-header">
                <div class="form-row">
                    <div class="col10L">                        
                        <asp:Label ID="Label6" runat="server" Text="RECLAMO" Style="font-weight: bold; font-size: 18px;"></asp:Label>                         
                    </div>                   
                </div>
            </div>
        <div class="card-body">
                <div class="form-row">
                    <CENTER><asp:Label ID="Label3" runat="server" Text="CREACION" Style="font-weight: bold; font-size: 18px;"></asp:Label></CENTER><br />
                    <hr />
                    <asp:GridView ID="GridView1" runat="server" DataSourceID="SqlDataSource1" AutoGenerateColumns="False" GridLines="None" BackColor="White" BorderStyle="None" BorderWidth="1px" CellPadding="20" ForeColor="Black" CssClass="mGrid" PagerStyle-CssClass="pgr" margin-left="2%" AlternatingRowStyle-CssClass="alt" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                        <Columns>  
                            <asp:BoundField DataField="CasoNum" HeaderText="Nro. Caso" SortExpression="CasoNum"></asp:BoundField>
                            <asp:BoundField DataField="Fecha" HeaderText="Fecha Creacion" SortExpression="Fecha"></asp:BoundField>
                            <asp:BoundField DataField="Cedula" HeaderText="Cedula" SortExpression="Cedula"></asp:BoundField>
                            <asp:BoundField DataField="Nombre" HeaderText="Nombre Completo" SortExpression="Nombre"></asp:BoundField>
                            <asp:BoundField DataField="Entidad" HeaderText="Entidad Tomadora" SortExpression="Entidad"></asp:BoundField>
                            <asp:BoundField DataField="Celular" HeaderText="Celular" SortExpression="Celular"></asp:BoundField> 
                            <asp:BoundField DataField="Direccion" HeaderText="Direccion Empleador" SortExpression="Direccion"></asp:BoundField>
                            <asp:BoundField DataField="MedioDeCobro" HeaderText="Medio De Cobro" SortExpression="MedioDeCobro"></asp:BoundField>
                            
                            
                            
                            
                            
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
                    <asp:SqlDataSource runat="server" ID="SqlDataSource1" ConnectionString='<%$ ConnectionStrings:affisDBConnectionString %>' SelectCommand="SELECT [Cedula], [Celular], [Entidad], [Relacion], [Cobertura], [Causa], [Casa], [Plan], [CasoNum], [Fecha], [Nombre], [Direccion], [MedioDeCobro] FROM [Reclamos] WHERE ([CasoNum] = @CasoNum)">
                        <SelectParameters>
                            <asp:CookieParameter CookieName="casorecC" Name="CasoNum" Type="Int32"></asp:CookieParameter>
                        </SelectParameters>
                    </asp:SqlDataSource>                        
                    <asp:GridView ID="GridView2" runat="server" DataSourceID="SqlDataSource2" AutoGenerateColumns="False" GridLines="None" BackColor="White" BorderStyle="None" BorderWidth="1px" CellPadding="20" ForeColor="Black" CssClass="mGrid" PagerStyle-CssClass="pgr" margin-left="2%" AlternatingRowStyle-CssClass="alt" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                        <Columns>    
                            <asp:BoundField DataField="Relacion" HeaderText="Relacion" SortExpression="Relacion"></asp:BoundField>
                            <asp:BoundField DataField="Asegurado" HeaderText="Asegurado" SortExpression="Asegurado"></asp:BoundField>
                            <asp:BoundField DataField="Cobertura" HeaderText="Cobertura" SortExpression="Cobertura"></asp:BoundField>
                            <asp:BoundField DataField="Plan" HeaderText="Plan" SortExpression="Plan"></asp:BoundField>
                            <asp:BoundField DataField="Causa" HeaderText="Causa" SortExpression="Causa"></asp:BoundField>
                            <asp:BoundField DataField="Diagnostico" HeaderText="Diagnostico" SortExpression="Diagnostico"></asp:BoundField>
                            <asp:BoundField DataField="Casa" HeaderText="Casa de Salud" SortExpression="Casa"></asp:BoundField>
                            <asp:BoundField DataField="Ejecutivo" HeaderText="Ejecutivo" SortExpression="Ejecutivo"></asp:BoundField>                            
                            <%--<asp:BoundField DataField="Observaciones" HeaderText="Observaciones" SortExpression="Observaciones"></asp:BoundField>--%>
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
                    <asp:SqlDataSource runat="server" ID="SqlDataSource2" ConnectionString='<%$ ConnectionStrings:affisDBConnectionString %>' SelectCommand="SELECT [Nombre], [Direccion], [Ejecutivo], [Asegurado], [Diagnostico], [CasoNum], [Fecha], [Observaciones], Relacion, Cobertura, [Plan], Causa, Casa FROM [Reclamos] WHERE ([CasoNum] = @CasoNum)">
                        <SelectParameters>
                            <asp:CookieParameter CookieName="casorecC" Name="CasoNum" Type="Int32"></asp:CookieParameter>
                        </SelectParameters>
                    </asp:SqlDataSource>  
                    <hr />
                     <CENTER><asp:Label ID="Label1" runat="server" Text="DOCUMENTACION" Style="font-weight: bold; font-size: 18px;"></asp:Label></CENTER><br />
                    <hr />
                   <asp:GridView ID="GridView3" runat="server" DataSourceID="SqlDataSource3" AutoGenerateColumns="False" GridLines="None" BackColor="White" BorderStyle="None" BorderWidth="1px" CellPadding="20" ForeColor="Black" CssClass="mGrid" PagerStyle-CssClass="pgr" margin-left="2%" AlternatingRowStyle-CssClass="alt" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                        <Columns>    
                            <asp:BoundField DataField="FechaIngreso" HeaderText="Ingreso" SortExpression="FechaIngreso"></asp:BoundField>
                            <asp:BoundField DataField="Alta" HeaderText="Alta" SortExpression="Alta"></asp:BoundField>
                            <asp:BoundField DataField="Dias" HeaderText="Dias Hosp." SortExpression="Dias"></asp:BoundField>
                             <asp:BoundField DataField="Uci" HeaderText="Dias Uci" SortExpression="Uci"></asp:BoundField>
                            <asp:BoundField DataField="EntregaDoc" HeaderText="Entrega Doc." SortExpression="EntregaDoc"></asp:BoundField>
                            <asp:BoundField DataField="Confirmacion" HeaderText="Confirmacion Caso" SortExpression="Confirmacion"></asp:BoundField>
                            <asp:BoundField DataField="FechaPago" HeaderText="Salida Pago" SortExpression="FechaPago"></asp:BoundField>
                            <asp:BoundField DataField="Valor" HeaderText="Posible Indemnizacion" SortExpression="Valor"></asp:BoundField>
                            <%--<asp:BoundField DataField="Recepcion" HeaderText="Recepcion" SortExpression="Recepcion"></asp:BoundField>--%>                                                                                                                                                                                                   
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
                    <asp:SqlDataSource runat="server" ID="SqlDataSource3" ConnectionString='<%$ ConnectionStrings:affisDBConnectionString %>' SelectCommand="SELECT [Recepcion], [Confirmacion], [FechaIngreso], [Dias], [EntregaDoc], [FechaPago], [Alta], [Uci], [Valor] FROM [Reclamos] WHERE ([CasoNum] = @CasoNum)">
                        <SelectParameters>
                            <asp:CookieParameter CookieName="casorecC" Name="CasoNum" Type="Int32"></asp:CookieParameter>
                        </SelectParameters>
                    </asp:SqlDataSource>  
                    <hr />
                     <CENTER><asp:Label ID="Label2" runat="server" Text="RESPUESTA" Style="font-weight: bold; font-size: 18px;"></asp:Label></CENTER><br />
                    <hr />
                    <asp:GridView ID="GridView4" runat="server" DataSourceID="SqlDataSource4" AutoGenerateColumns="False" GridLines="None" BackColor="White" BorderStyle="None" BorderWidth="1px" CellPadding="20" ForeColor="Black" CssClass="mGrid" PagerStyle-CssClass="pgr" margin-left="2%" AlternatingRowStyle-CssClass="alt" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                        <Columns>                            
                            <asp:BoundField DataField="NroDoc" HeaderText="Nro. Doc." SortExpression="NroDoc"></asp:BoundField>
                            <asp:BoundField DataField="RegistroNum" HeaderText="Fecha Registro" SortExpression="RegistroNum"></asp:BoundField>
                            <asp:BoundField DataField="DiasResuelto" HeaderText="Dias Resuelto" SortExpression="DiasResuelto"></asp:BoundField>
                            <asp:BoundField DataField="PagoAseg" HeaderText="Pago" SortExpression="PagoAseg"></asp:BoundField>
                            <asp:BoundField DataField="FechaPagoCli" HeaderText="Fecha Pago" SortExpression="FechaPagoCli"></asp:BoundField>
                            <asp:BoundField DataField="EjecutivoResp" HeaderText="Ejecutivo Resp." SortExpression="EjecutivoResp"></asp:BoundField>
                             <asp:BoundField DataField="EstadoReclamo" HeaderText="Estado" SortExpression="EstadoReclamo"></asp:BoundField>
                            <asp:BoundField DataField="Registrado" HeaderText="Registrado por:" SortExpression="Registrado"></asp:BoundField>                                                                                                                                                                                                
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
                    <asp:SqlDataSource runat="server" ID="SqlDataSource4" ConnectionString='<%$ ConnectionStrings:affisDBConnectionString %>' SelectCommand="SELECT [Valor], [Registrado], [NroDoc], [DiasResuelto], [FechaPagoCli], [RegistroNum], [EjecutivoResp], [PagoAseg], [EstadoReclamo] FROM [Reclamos] WHERE ([CasoNum] = @CasoNum)">
                        <SelectParameters>
                            <asp:CookieParameter CookieName="casorecC" Name="CasoNum" Type="Int32"></asp:CookieParameter>
                        </SelectParameters>
                    </asp:SqlDataSource>  
                    <asp:GridView ID="GridView5" runat="server" DataSourceID="SqlDataSource5" AutoGenerateColumns="False" GridLines="None" BackColor="White" BorderStyle="None" BorderWidth="1px" CellPadding="20" ForeColor="Black" CssClass="mGrid" PagerStyle-CssClass="pgr" margin-left="2%" AlternatingRowStyle-CssClass="alt" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                        <Columns>    
                            <%--<asp:BoundField DataField="Relacion" HeaderText="Relacion" SortExpression="Relacion"></asp:BoundField>
                            <asp:BoundField DataField="Asegurado" HeaderText="Asegurado" SortExpression="Asegurado"></asp:BoundField>
                            <asp:BoundField DataField="Cobertura" HeaderText="Cobertura" SortExpression="Cobertura"></asp:BoundField>
                            <asp:BoundField DataField="Plan" HeaderText="Plan" SortExpression="Plan"></asp:BoundField>
                            <asp:BoundField DataField="Causa" HeaderText="Causa" SortExpression="Causa"></asp:BoundField>
                            <asp:BoundField DataField="Diagnostico" HeaderText="Diagnostico" SortExpression="Diagnostico"></asp:BoundField>
                            <asp:BoundField DataField="Casa" HeaderText="Casa de Salud" SortExpression="Casa"></asp:BoundField>
                            <asp:BoundField DataField="Ejecutivo" HeaderText="Ejecutivo" SortExpression="Ejecutivo"></asp:BoundField>    --%>                        
                            <asp:BoundField DataField="Observaciones" HeaderText="Observaciones" SortExpression="Observaciones"></asp:BoundField>
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
                    <asp:SqlDataSource runat="server" ID="SqlDataSource5" ConnectionString='<%$ ConnectionStrings:affisDBConnectionString %>' SelectCommand="SELECT [Observaciones] FROM [Reclamos] WHERE ([CasoNum] = @CasoNum)">
                        <SelectParameters>
                            <asp:CookieParameter CookieName="casorecC" Name="CasoNum" Type="Int32"></asp:CookieParameter>
                        </SelectParameters>
                    </asp:SqlDataSource>  
                    <hr />
                    <CENTER>
                    <asp:Button  value="REGISTRARME" type="submit" runat="server" CssClass="botonsubmitTRES no-print" Text="VOLVER" ID="CANCEL" OnClick="Unnamed1_Click" UseSubmitBehavior="False" />                      
                        <%--<asp:Button  value="REGISTRARME" type="submit" runat="server" CssClass="botonsubmitTRES" Text="ADICIONAR" ID="Button1" OnClick="Unnamed2_Click" UseSubmitBehavior="False" />                      
                        <asp:Button  value="REGISTRARME" type="submit" runat="server" CssClass="botonsubmitTRES" Text="REEMPLAZAR" ID="Button2" OnClick="Unnamed3_Click" UseSubmitBehavior="False" />  --%>                    
                        <asp:Button  value="FF" type="submit" runat="server" CssClass="botonsubmitTRES no-print" Text="IMPRIMIR" OnClientClick="javascript:window.print();" UseSubmitBehavior="False" /> 
                    </CENTER>                    
                    
                </div>
            </div>
        </div>
        </div>
    
</asp:Content>
