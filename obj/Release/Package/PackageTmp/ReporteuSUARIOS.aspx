<%@ Page Title="Tarrago Reach System" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ReporteuSUARIOS.aspx.cs" Inherits="ReachSystem.ReporteuSUARIOS" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server"> 
    <div class="container">
    <div class="card">
        <div class="card-header">
                <div class="form-row">
                    <div class="col10L">                        
                        <asp:Label ID="Label6" runat="server" Text="REPORTE: USUARIOS" Style="font-weight: bold; font-size: 18px;"></asp:Label>                        
                    </div>                   
                </div>
            </div>
        <div class="card-body">
                <div class="form-row">
                    <%--<%--<table style="width: 100%;">
                        <tr>  
                            <td> <asp:Label ID="Label2" runat="server" Text="FECHA INICIO" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                                <input class="formularioProc" placeholder="NOMBRE O APELLIDO" id="Text1" type="date" runat="server"  AutoPostBack="true"/>                           
                            </td>
                            <td><asp:Label ID="Label1" runat="server" Text="FECHA FINAL" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                                <input class="formularioProc" placeholder="NOMBRE O APELLIDO" id="Correo" type="date" runat="server"  AutoPostBack="true"/>                            
                            </td>
                          <%--  <td><asp:Label ID="Label4" runat="server" Text="EJECUTIVO" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                                <asp:DropDownList ID="DropDownList1" runat="server" class="formularioProc" DataSourceID="SqlDataSource2" DataTextField="Ejecutivo" DataValueField="Ejecutivo"></asp:DropDownList>
                                <asp:SqlDataSource runat="server" ID="SqlDataSource2" ConnectionString='<%$ ConnectionStrings:affisDBConnectionString %>' SelectCommand="SELECT DISTINCT [Ejecutivo] FROM [Asegurados] WHERE ([Estado] = 'VENTA')"></asp:SqlDataSource>
                            </td>
                            <td><asp:Label ID="Label3" runat="server" Text="GENERAR" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                                <asp:Button runat="server" CssClass="botonsubmitTRESDOS" text="GENERAR REPORTE" OnClick="Unnamed_Click1"></asp:Button>                                
                            </td>                            
                        </tr>
                    </table> 
                    <hr />--%>
                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" AllowPaging="True" GridLines="None" BackColor="White" BorderStyle="None" BorderWidth="1px" CellPadding="20" ForeColor="Black" CssClass="mGrid" PagerStyle-CssClass="pgr" margin-left="2%" AlternatingRowStyle-CssClass="alt" AllowSorting="True" DataSourceID="SqlDataSource1" OnSelectedIndexChanged="Unnamed_Click1">
                        <Columns>
                            
                            <asp:BoundField DataField="num_row" HeaderText="Nº" SortExpression="num_row"></asp:BoundField>                            
                            <asp:BoundField DataField="Apellido" HeaderText="Apellidos" SortExpression="Apellido"></asp:BoundField>
                            <asp:BoundField DataField="Nombre" HeaderText="Nombres" SortExpression="Nombre"></asp:BoundField>
                            <asp:BoundField DataField="Alias" HeaderText="Alias" SortExpression="Alias"></asp:BoundField>
                            <asp:BoundField DataField="Usu" HeaderText="Usuario" SortExpression="Usu"></asp:BoundField>
                            <asp:BoundField DataField="Perfil" HeaderText="Perfil" SortExpression="Perfil"></asp:BoundField>
                            <asp:BoundField DataField="Cargo" HeaderText="Cargo" SortExpression="Cargo"></asp:BoundField>
                            <asp:BoundField DataField="Ciudad" HeaderText="Ciudad" SortExpression="Ciudad"></asp:BoundField>
                           <%-- <asp:BoundField DataField="Correo" HeaderText="Correo" SortExpression="Correo"></asp:BoundField>  --%>                                                                                  
                            <asp:BoundField DataField="FechaIngreso" HeaderText="Fecha Ingreso" SortExpression="FechaIngreso"></asp:BoundField>
                       <%--     <asp:BoundField DataField="FechaCreacion" HeaderText="Fecha Creacion" SortExpression="FechaCreacion"></asp:BoundField>--%>
                            <asp:CommandField ShowSelectButton="True" ButtonType="Button" SelectText="DESACTIVAR"></asp:CommandField>
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
                    <asp:SqlDataSource runat="server" ID="SqlDataSource1" ConnectionString='<%$ ConnectionStrings:affisDBConnectionString %>' SelectCommand="SELECT row_number() over(order by Nombre) as num_row, [Nombre], [Apellido], [Correo], [Perfil], [Cargo], [Ciudad], [FechaIngreso], [FechaCreacion], Usu, Alias FROM [Usuario] where Estado = 'ACTIVO'">
                    </asp:SqlDataSource>
                    <hr />
                                            
                    <CENTER>
                    <asp:Button  value="REGISTRARME" type="submit" runat="server" CssClass="botonsubmitTRES" Text="CANCELAR" OnClick="Unnamed_Click" UseSubmitBehavior="False" />                                                    
                    </CENTER>
                </div>
            

            </div>
        </div>
        </div>

</asp:Content>
