<%@ Page Title="Tarrago Reach System" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ProcesoIngresado.aspx.cs" Inherits="ReachSystem.ProcesoIngresado" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server"> 
    <div class="container">
    <div class="card">
        <div class="card-header">
                <div class="form-row">
                    <div class="col10L">                        
                        <asp:Label ID="Label6" runat="server" Text="CERTIFICADOS INGRESADOS" Style="font-weight: bold; font-size: 18px;"></asp:Label>                        
                    </div>                   
                </div>
            </div>
        <div class="card-body">
                <div class="form-row">
                    <table style="width: 100%;">
                        <tr>  
                           <%-- <td> <asp:Label ID="Label2" runat="server" Text="FECHA DE HOY" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                                <input class="formularioProc" placeholder="NOMBRE O APELLIDO" id="Text1" type="date" runat="server"  AutoPostBack="true"/>                           
                            </td>--%>
                            <%--<td><asp:Label ID="Label1" runat="server" Text="FECHA FIN" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                                <input class="formularioProc" placeholder="NOMBRE O APELLIDO" id="Correo" type="date" runat="server"  AutoPostBack="true"/>                            
                            </td>                           
                            <td><asp:Label ID="Label4" runat="server" Text="EMPRESA" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                                <asp:DropDownList ID="DropDownList1" runat="server" class="formularioProc" DataSourceID="SqlDataSource2" DataTextField="NombreComercial" DataValueField="NombreComercial"></asp:DropDownList>
                                <asp:SqlDataSource runat="server" ID="SqlDataSource2" ConnectionString='<%$ ConnectionStrings:affisDBConnectionString %>' SelectCommand="SELECT DISTINCT NombreComercial FROM Asegurados Where Estado='VENTA'"></asp:SqlDataSource>
                            </td>--%>
                          <%--  <td><%--<asp:Label ID="Label3" runat="server" Text="GENERAR" Style="font-weight: bold; font-size: 18px;"></asp:Label>--%><br />
                               <%-- <asp:Button runat="server" CssClass="botonsubmitTRESDOS" text="GENERAR" OnClick="Unnamed_Click1"></asp:Button>                                
                            </td> --%>                  
                        </tr>
                    </table> 
                  <%--  <hr />--%>
                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" AllowPaging="True" GridLines="None" BackColor="White" BorderStyle="None" BorderWidth="1px" CellPadding="20" ForeColor="Black" CssClass="mGrid" PagerStyle-CssClass="pgr" margin-left="2%" AlternatingRowStyle-CssClass="alt" AllowSorting="True" DataSourceID="SqlDataSource1" PageSize="100">
                        <Columns>
                            <asp:BoundField DataField="NombreComercial" HeaderText="NombreComercial" SortExpression="NombreComercial"></asp:BoundField>
    <asp:BoundField DataField="NumeroCertificado" HeaderText="NumeroCertificado" SortExpression="NumeroCertificado"></asp:BoundField>
    <%--<asp:BoundField DataField="CedulaTomador" HeaderText="CEDULA" SortExpression="CedulaTomador"></asp:BoundField>  --%>
    <%--<asp:BoundField DataField="Relacion" HeaderText="RELACION" SortExpression="Relacion"></asp:BoundField>
                            <asp:BoundField DataField="Producto" HeaderText="COBERTURA" SortExpression="Producto"></asp:BoundField> 
                            <asp:BoundField DataField="Plan" HeaderText="PLAN" SortExpression="Plan"></asp:BoundField>--%>
    <asp:BoundField DataField="Nombre" HeaderText="Nombre" SortExpression="Nombre"></asp:BoundField>
    <%--<asp:BoundField DataField="FechaVig" HeaderText="INICIO VIGENCIA" SortExpression="FechaVig"></asp:BoundField>--%>
    <asp:BoundField DataField="Cedula" HeaderText="Cedula" SortExpression="Cedula"></asp:BoundField>
    <asp:BoundField DataField="FechaVenta" HeaderText="FechaVenta" SortExpression="FechaVenta"></asp:BoundField>
    <asp:BoundField DataField="Ejecutivo" HeaderText="Ejecutivo" SortExpression="Ejecutivo"></asp:BoundField>
    <asp:BoundField DataField="Digitador" HeaderText="Digitador" SortExpression="Digitador"></asp:BoundField>
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
                    <asp:SqlDataSource runat="server" ID="SqlDataSource1" ConnectionString='<%$ ConnectionStrings:affisDBConnectionString %>' SelectCommand="select  NombreComercial, NumeroCertificado, Nombre, Cedula, FechaVenta, Ejecutivo, Digitador from Asegurados where proceso='INGRESADO' AND NumeroCertificado is not null"> 
                        
                    </asp:SqlDataSource>
                    <%--<hr />
                     <asp:Label ID="Label5" runat="server" Style="font-weight: bold; font-size: 18px; margin-left:52%; color:green;"></asp:Label>--%>
                    
                    <hr />
                    <center>
                        <asp:Button  value="REGISTRARME" type="submit" runat="server" CssClass="botonsubmitTRES" Text="CANCELAR" OnClick="Unnamed_Click" UseSubmitBehavior="False" />  
                        <%--<asp:Button  value="REGISTRARME" type="submit" runat="server" CssClass="botonsubmitTRESTRES" Text="ELIMINAR REGISTROS" OnClick="Unnamed_Click1" UseSubmitBehavior="False" />  --%>
                        <Button  value="REGISTRARME" type="submit" runat="server" Class="botonsubmitCUATRO" ID="Button3" OnServerClick="descarga1" UseSubmitBehavior="False" >EXPORTAR <i class="fa fa-file-excel-o"></i></Button></center>  
                    
                </div>
            

            </div>
        </div>
        </div>

</asp:Content>
