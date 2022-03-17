<%@ Page Title="Tarrago Reach System" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListaTotal.aspx.cs" Inherits="ReachSystem.ListaTotal" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server"> 
    <div class="container">
    <div class="card">
        <div class="card-header">
                <div class="form-row">
                    <div class="col10L">                        
                        <asp:Label ID="Label6" runat="server" Text="INCLUSIÓN: COBERTURAS" Style="font-weight: bold; font-size: 18px;"></asp:Label>                        
                        <asp:Label ID="Label2" runat="server" Text="ADICION: COBERTURAS" Style="font-weight: bold; font-size: 18px;"></asp:Label>               
                        <asp:Label ID="Label3" runat="server" Text="REEMPLAZO: COBERTURAS" Style="font-weight: bold; font-size: 18px;"></asp:Label>                        
                    </div>                   
                </div>
            </div>
        <div class="card-body">
                <div class="form-row">
                    <table style="width:80%">
                        <tr>
                            <td> <asp:Label ID="Label5" runat="server" Text="NOMBRE TOMADOR" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                                <input class="formularioblock" placeholder="Nombre Tomador" id="Text4" type="text" runat="server"   disabled/>
                            </td>
                            <td>
                                <asp:Label ID="Label15" runat="server" Text="CEDULA TOMADOR" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                                <input class="formularioblock" placeholder="Cedula Tomador" id="Text3" type="text" runat="server"   disabled/>
                            </td>
                            <td>
                                <asp:Label ID="Label16" runat="server" Text="FECHA DE NACIMIENTO" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                                <input class="formularioblock" placeholder="Fecha Nacimiento" id="Text5" type="text" runat="server"   disabled/>
                            </td>
                        </tr>
                    </table>
                    <hr />
      <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1"  GridLines="None" AllowPaging="True" BackColor="White" BorderStyle="None" BorderWidth="1px" CellPadding="20" ForeColor="Black"  CssClass="mGrid" PagerStyle-CssClass="pgr" margin-left="2%" AlternatingRowStyle-CssClass="alt" AllowSorting="True" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
<AlternatingRowStyle CssClass="alt"></AlternatingRowStyle>

        <Columns>            
            <asp:BoundField DataField="Nombre" HeaderText="NOMBRE" SortExpression="Nombre" />
            <asp:BoundField DataField="Cedula" HeaderText="CEDULA" SortExpression="Cedula" />
            <asp:BoundField DataField="Relacion" HeaderText="RELACION" SortExpression="Relacion" />
            <asp:BoundField DataField="FechaNac" HeaderText="FECHA DE NACIMIENTO" SortExpression="FechaNac" />
            <asp:BoundField DataField="Producto" HeaderText="COBERTURA" SortExpression="Producto" />
            <asp:BoundField DataField="PlanSelect" HeaderText="PLAN" SortExpression="PlanSelect" />
            <asp:BoundField DataField="Valor" HeaderText="PRIMA" SortExpression="Valor" />
            <asp:CommandField ShowSelectButton="True" ButtonType="Button" SelectText="ELIMINAR"></asp:CommandField>
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

                    <asp:SqlDataSource runat="server" ID="SqlDataSource1" ConnectionString='<%$ ConnectionStrings:affisDBConnectionString %>' SelectCommand="select nombre, Cedula, Relacion, FechaNac, producto, planselect, valor from VentaTemp  WHERE Ejecutivo = @Ejecutivo AND FechaVenta = @FechaVenta AND CedulaTomador = @CedulaTomador">
                        <SelectParameters>
                            <asp:CookieParameter CookieName="nombreC" Name="Ejecutivo" Type="String"></asp:CookieParameter>
                            <asp:CookieParameter CookieName="fechaC" Name="FechaVenta" Type="DateTime"></asp:CookieParameter>
                            <asp:CookieParameter CookieName="paramCedula" Name="CedulaTomador" Type="Int64"></asp:CookieParameter>
                        </SelectParameters>
                    </asp:SqlDataSource>
                    <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource2"  GridLines="None" AllowPaging="True" BackColor="White" BorderStyle="None" BorderWidth="1px" CellPadding="20" ForeColor="Black"  CssClass="mGrid" PagerStyle-CssClass="pgr" margin-left="2%" AlternatingRowStyle-CssClass="alt" AllowSorting="True" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
<AlternatingRowStyle CssClass="alt"></AlternatingRowStyle>

        <Columns>            
            <asp:BoundField DataField="Nombre" HeaderText="NOMBRE" SortExpression="Nombre" />
            <asp:BoundField DataField="Cedula" HeaderText="CEDULA" SortExpression="Cedula" />
            <asp:BoundField DataField="Relacion" HeaderText="RELACION" SortExpression="Relacion" />
            <asp:BoundField DataField="FechaNac" HeaderText="FECHA DE NACIMIENTO" SortExpression="FechaNac" />
            <asp:BoundField DataField="Producto" HeaderText="COBERTURA" SortExpression="Producto" />
            <asp:BoundField DataField="Plan" HeaderText="PLAN" SortExpression="Plan" />
            <asp:BoundField DataField="totalcobrar" HeaderText="PRIMA" SortExpression="totalcobrar" />
            <%--<asp:CommandField ShowSelectButton="True" ButtonType="Button" SelectText="ELIMINAR"></asp:CommandField>--%>
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

                    <asp:SqlDataSource runat="server" ID="SqlDataSource2" ConnectionString='<%$ ConnectionStrings:affisDBConnectionString %>' SelectCommand="select nombre, Cedula, Relacion, FechaNac, producto, [plan], totalcobrar from Dependientes  WHERE NumeroCertificado = @CedulaTomador and Estado <> 'EXCLUIDO'">
                        <SelectParameters>
                          <%--  <asp:CookieParameter CookieName="nombreC" Name="Ejecutivo" Type="String"></asp:CookieParameter>
                            <asp:CookieParameter CookieName="fechaC" Name="FechaVenta" Type="DateTime"></asp:CookieParameter>--%>
                            <asp:CookieParameter CookieName="ParamCert" Name="CedulaTomador" Type="Int64"></asp:CookieParameter>
                        </SelectParameters>
                    </asp:SqlDataSource>
                    <hr />
                    <table style="width: 100%;">
                        <tr>                                                        
                            <td><asp:Label ID="Label1" runat="server" Text="PRIMA CERTIFICADO $:" Style="font-weight: bold; font-size: 18px;"></asp:Label></td>
                            <td><asp:Label ID="prefifin" runat="server" CssClass="formularioFin" ></asp:Label></td>
                        </tr>
                        <tr>
                            <td><asp:Label ID="Label4" runat="server" Text="TOTAL A PAGAR $:" Style="font-weight: bold; font-size: 18px;"></asp:Label></td>
                            <td><asp:Label ID="Label7" runat="server" CssClass="formularioFinCuatro" ></asp:Label></td>
                        </tr>
                    </table>
                    
                    <hr /> 
                    <CENTER><asp:Button  value="REGISTRARME" type="submit" runat="server" CssClass="botonsubmitTRES" Text="SIGUIENTE" OnClick="Unnamed_Click"/>                                                  
                    </CENTER>
                    <hr />                                            
                    <CENTER><asp:Button  value="REGISTRARME" type="submit" runat="server" CssClass="botonsubmitTRES" Text="CANCELAR" OnClick="Unnamed_Click2" UseSubmitBehavior="False" />  
                        <asp:Button  value="REGISTRARME" type="submit" runat="server" CssClass="botonsubmitTRES" Text="VOLVER" OnClick="Unnamed_Click3" UseSubmitBehavior="False" />                                             
                    </CENTER>
                </div>
            </div>
        </div>
        </div>
    
</asp:Content>
