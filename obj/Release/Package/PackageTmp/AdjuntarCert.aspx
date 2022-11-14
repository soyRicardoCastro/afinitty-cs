<%@ Page Title="Tarrago Reach System" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AdjuntarCert.aspx.cs" Inherits="ReachSystem.AdjuntarCert" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server"> 
    <div class="container">
    <div class="card">
        <div class="card-header">
                <div class="form-row">
                    <div class="col10L">                        
                        <asp:Label ID="Label6" runat="server" Text="PROCESAR CERTIFICADO: ADJUNTAR DOCUMENTOS" Style="font-weight: bold; font-size: 18px;"></asp:Label>                        
                        <asp:Label ID="Label2" runat="server" Text="INCLUSION: ADJUNTAR DOCUMENTOS" Style="font-weight: bold; font-size: 18px;"></asp:Label>                        
                        <asp:Label ID="Label3" runat="server" Text="ADICION: ADJUNTAR DOCUMENTOS" Style="font-weight: bold; font-size: 18px;"></asp:Label>       
                        <asp:Label ID="Label8" runat="server" Text="REEMPLAZO: ADJUNTAR DOCUMENTOS" Style="font-weight: bold; font-size: 18px;"></asp:Label>                        
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
                            <asp:BoundField DataField="TotalCobrar" HeaderText="PRIMA CERTIFICADO" SortExpression="TotalCobrar"></asp:BoundField>
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
                    <asp:SqlDataSource runat="server" ID="SqlDataSource1" ConnectionString='<%$ ConnectionStrings:affisDBConnectionString %>' SelectCommand="SELECT [NumeroCertificado], [Cedula], [Nombre], [TotalCobrar] FROM [Asegurados] WHERE ([Cedula] = @Cedula) AND NumeroCertificado IS NOT NULL AND Estado = 'VENTA'">
                        <SelectParameters>
                            <asp:CookieParameter CookieName="paramCedula" Name="Cedula" Type="Int64"></asp:CookieParameter>
                        </SelectParameters>
                    </asp:SqlDataSource>
                    <div class="form-row">  
                    <asp:GridView ID="GridView2" runat="server" DataSourceID="SqlDataSource2" AutoGenerateColumns="False" AllowPaging="True" GridLines="None" BackColor="White" BorderStyle="None" BorderWidth="1px" CellPadding="20" ForeColor="Black"  CssClass="mGrid" PagerStyle-CssClass="pgr" margin-left="2%" AlternatingRowStyle-CssClass="alt" AllowSorting="True" >
                        <Columns>  
                            <asp:BoundField DataField="NumeroCertificado" HeaderText="CERTIFICADO" SortExpression="NumeroCertificado"></asp:BoundField>
                            <asp:BoundField DataField="Cedula" HeaderText="CEDULA" SortExpression="Cedula"></asp:BoundField>
                            <asp:BoundField DataField="Nombre" HeaderText="TOMADOR" SortExpression="Nombre"></asp:BoundField>
                            <asp:BoundField DataField="TotalCobrar" HeaderText="PRIMA CERTIFICADO" SortExpression="TotalCobrar"></asp:BoundField>
                            <asp:BoundField DataField="Proceso" HeaderText="ESTADO DE REVISION" SortExpression="Proceso"></asp:BoundField>
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
                    <asp:SqlDataSource runat="server" ID="SqlDataSource2" ConnectionString='<%$ ConnectionStrings:affisDBConnectionString %>' SelectCommand="SELECT [NumeroCertificado], [Cedula], [Nombre], [TotalCobrar], Proceso FROM [Asegurados] WHERE ([Cedula] = @Cedula) AND NumeroCertificado IS NOT NULL AND Estado = 'VENTA'">
                        <SelectParameters>
                            <asp:CookieParameter CookieName="paramCedula" Name="Cedula" Type="Int64"></asp:CookieParameter>
                        </SelectParameters>
                    </asp:SqlDataSource>
                    <hr />
                    <table style="width: 100%;">                        
                        <tr>
                            <td><asp:Label ID="Label4" runat="server" Text="ESTADO DE REVISION" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                                <asp:DropDownList ID="DropDownList1" runat="server" CssClass="formularioProc2">
                                    <asp:ListItem>INGRESADO</asp:ListItem>
                                    <asp:ListItem>COMPLETADO</asp:ListItem>
                                    <asp:ListItem>REVISADO</asp:ListItem>
                                </asp:DropDownList>
                            </td>
                            <td><asp:Label ID="Label5" runat="server" Text="CERTIFICADO" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                                <asp:FileUpload ID="FileUpload1" runat="server" CssClass="formularioProc2" /><br />
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="FileUpload1" ErrorMessage="ARCHIVO OBLIGATORIO" CssClass="Aviso"></asp:RequiredFieldValidator>
                            </td>                                                     
                        </tr>
                        <tr>
                            <td> &nbsp; </td>
                            <td><asp:Label ID="Label7" runat="server" Text="CARTA DE EXCLUSION" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                                <asp:FileUpload ID="FileUpload2" runat="server" CssClass="formularioProc2"/><br /><br />

                            </td>                                                    
                        </tr>
                         <tr>
                            <td>&nbsp;</td>
                            <td><asp:Label ID="Label1" runat="server" Text="OTROS" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                               <asp:FileUpload ID="FileUpload3" runat="server" CssClass="formularioProc2"/><br />   </td>                               
                        </tr>                                            
                    </table>
                    <hr />
                          <center><Button  value="REGISTRARME" type="submit" runat="server" Class="botonsubmitCUATRO" ID="Button3" OnServerClick="descarga1" UseSubmitBehavior="False" >CERTIFICADO <i class="fa fa-file-pdf-o"></i></Button></center>   
                    <hr />
                    <CENTER><asp:Button runat="server" CssClass="botonsubmitTRES" text="CANCELAR" OnClick="Unnamed_Click1"></asp:Button>  
                    <asp:Button  value="REGISTRARME" type="submit" runat="server" CssClass="botonsubmitTRES" Text="VOLVER" OnClick="Unnamed_Click"/>                                                  
                        <asp:Button  value="REGISTRARME" type="submit" runat="server" CssClass="botonsubmitTRES" Text="FINALIZAR" OnClick="Unnamed1_Click" UseSubmitBehavior="False" />                                                  
                    </CENTER>
                </div>
            </div>
        </div>
        </div>
    
</asp:Content>
