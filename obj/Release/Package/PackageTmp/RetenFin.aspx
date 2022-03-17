<%@ Page Title="Tarrago Reach System" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RetenFin.aspx.cs" Inherits="ReachSystem.RetenFin" %>

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
                    <asp:GridView ID="GridView1" runat="server" DataSourceID="SqlDataSource1" AutoGenerateColumns="False" AllowPaging="True" GridLines="None" BackColor="White" BorderStyle="None" BorderWidth="1px" CellPadding="20" ForeColor="Black"  CssClass="mGrid" PagerStyle-CssClass="pgr" margin-left="2%" AlternatingRowStyle-CssClass="alt" AllowSorting="True" >
                        <Columns>  
                            <asp:BoundField DataField="NumeroCertificado" HeaderText="CERTIFICADO" SortExpression="NumeroCertificado"></asp:BoundField>
                            <asp:BoundField DataField="Cedula" HeaderText="CEDULA" SortExpression="Cedula"></asp:BoundField>    
                            <asp:BoundField DataField="Nombre" HeaderText="TOMADOR" SortExpression="Nombre"></asp:BoundField>
                            <asp:BoundField DataField="NombreComercial" HeaderText="EMPRESA" SortExpression="NombreComercial"></asp:BoundField>
                            <asp:BoundField DataField="Ejecutivo" HeaderText="EJECUTIVO" SortExpression="Ejecutivo"></asp:BoundField>                            
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
                    <asp:SqlDataSource runat="server" ID="SqlDataSource1" ConnectionString='<%$ ConnectionStrings:affisDBConnectionString %>' SelectCommand="SELECT  [Nombre], [NumeroCertificado], [Cedula], [NombreComercial], Ejecutivo FROM [Asegurados] WHERE ([NumeroCertificado] = @NumeroCertificado)">
                        <SelectParameters>                                                        
                            <asp:CookieParameter CookieName="paramCert" Name="NumeroCertificado" Type="Int32"></asp:CookieParameter>
                        </SelectParameters>
                    </asp:SqlDataSource>
                    <asp:GridView ID="GridView2" runat="server" DataSourceID="SqlDataSource3" AutoGenerateColumns="False" AllowPaging="True" GridLines="None" BackColor="White" BorderStyle="None" BorderWidth="1px" CellPadding="20" ForeColor="Black"  CssClass="mGrid" PagerStyle-CssClass="pgr" margin-left="2%" AlternatingRowStyle-CssClass="alt" AllowSorting="True" >
                        <Columns>  
                            <asp:BoundField DataField="Motivo" HeaderText="MOTIVO" SortExpression="motivo"></asp:BoundField>
                            <asp:BoundField DataField="Canal" HeaderText="CANAL" SortExpression="Canal"></asp:BoundField>    
                            <asp:BoundField DataField="Responsable" HeaderText="RESPONSABLE " SortExpression="Responsable"></asp:BoundField>
                            <asp:BoundField DataField="FechaSolicitud" HeaderText="FECHA SOLICITUD" SortExpression="FechaSolicitud"></asp:BoundField>
                            <asp:BoundField DataField="FechaResolucion" HeaderText="FECHA RESOLUCION" SortExpression="FechaResolucion"></asp:BoundField>                            
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
                    <asp:SqlDataSource runat="server" ID="SqlDataSource3" ConnectionString='<%$ ConnectionStrings:affisDBConnectionString %>' SelectCommand="SELECT  Motivo, Canal, Responsable, FechaSolicitud, FechaResolucion FROM [Asegurados] WHERE ([NumeroCertificado] = @NumeroCertificado)">
                        <SelectParameters>                                                        
                            <asp:CookieParameter CookieName="paramCert" Name="NumeroCertificado" Type="Int32"></asp:CookieParameter>
                        </SelectParameters>
                    </asp:SqlDataSource>
                    <hr />
                    <table style="width: 100%;">                        
                        
                         <tr>
                            <td><asp:Label ID="Label3" runat="server" Text="MOTIVO" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                                <asp:DropDownList ID="DropDownList2" runat="server" CssClass="formularioProc2">
                                    <asp:ListItem>MOTIVO</asp:ListItem>
                                    <asp:ListItem>VOLUNTARIO</asp:ListItem>
                                    <asp:ListItem>RENUNCIA</asp:ListItem>
                                    <asp:ListItem>EDAD DE TERMINACION</asp:ListItem>
                                    <asp:ListItem>IMPAGO</asp:ListItem>
                                    <asp:ListItem>FALLECIDO</asp:ListItem>
                                </asp:DropDownList>
                            </td>
                            <td><asp:Label ID="Label5" runat="server" Text="CANAL" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                                <asp:DropDownList ID="DropDownList3" runat="server" CssClass="formularioProc2">
                                    <asp:ListItem>CANAL</asp:ListItem>
                                    <asp:ListItem>TELEFONICO</asp:ListItem>
                                    <asp:ListItem>CORREO</asp:ListItem>
                                    <asp:ListItem>PRESENCIAL</asp:ListItem>                                   
                                </asp:DropDownList>
                            </td>    
                             <td><asp:Label ID="Label7" runat="server" Text="RESPONSABLE RETENCION" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                                 <asp:DropDownList ID="DropDownList4" runat="server" CssClass="formularioProc2" DataSourceID="SqlDataSource2" DataTextField="Alias" DataValueField="Alias">
                                 </asp:DropDownList>
                                 <asp:SqlDataSource runat="server" ID="SqlDataSource2" ConnectionString='<%$ ConnectionStrings:affisDBConnectionString %>' SelectCommand="SELECT [Alias] FROM [Usuario] ORDER BY [Alias]"></asp:SqlDataSource>
                             </td> 
                        </tr>
                           <tr>
                               <td><asp:Label ID="Label2" runat="server" Text="FECHA ASIGNACION" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                                   <input class="formularioProc2" ID="Label1" placeholder="CEDULA/CERTIFICADO"   runat="server"  AutoPostBack="true" disabled/>
                                
                            </td>  
                            <td><asp:Label ID="Label8" runat="server" Text="FECHA SOLICITUD" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                                <input class="formularioProc2" placeholder="CEDULA/CERTIFICADO" id="Correo" type="DATE" runat="server"  AutoPostBack="true" />
                            </td>
                               <td><asp:Label ID="Label11" runat="server" Text="FECHA RESOLUCION" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                                <input class="formularioProc2" placeholder="CEDULA/CERTIFICADO" id="DATE1" type="DATE" runat="server"  AutoPostBack="true" />
                            </td>  
                                
                        </tr>  
                        <tr>
                            <td><asp:Label ID="Label4" runat="server" Text="TIPO DE ACCION" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                                <asp:DropDownList ID="DropDownList1" runat="server" CssClass="formularioProc2">
                                    <asp:ListItem>SELECCIONE LA ACCION</asp:ListItem>
                                    <asp:ListItem>SOLICITADO</asp:ListItem>
                                    <asp:ListItem>RETENIDO</asp:ListItem>
                                   <%-- <asp:ListItem>REEMPLAZADO</asp:ListItem>--%>
                                    <asp:ListItem>EXCLUIDO</asp:ListItem>
                                </asp:DropDownList>
                            </td>
                                                                              
                        </tr>
                    </table>
                    <table>
                        <tr>
                            <td>&nbsp;</td>
                            <td><asp:Label ID="Label9" runat="server" Text="CARTA" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                                <asp:FileUpload ID="FileUpload2" runat="server" CssClass="formularioProc2"/><br />

                            </td>                                                    
                        </tr>
                         <tr>
                            <td>&nbsp;</td>
                            <td><asp:Label ID="Label10" runat="server" Text="OTROS" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                               <asp:FileUpload ID="FileUpload3" runat="server" CssClass="formularioProc2"/><br />   </td>                               
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
