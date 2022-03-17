<%@ Page Title="Tarrago Reach System" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="InclusionTomador.aspx.cs" Inherits="ReachSystem.InclusionTomador" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server"> 
    <div class="container">
    <div class="card">
        <div class="card-header">
                <div class="form-row">
                    <div class="col10L">                        
                        <asp:Label ID="Label6" runat="server" Text="INCLUSIÓN: TOMADOR PRINCIPAL" Style="font-weight: bold; font-size: 18px;"></asp:Label>                        
                        <asp:Label ID="Label5" runat="server" Text="PROCESAR CERTIFICADO: TOMADOR PRINCIPAL" Style="font-weight: bold; font-size: 18px;"></asp:Label>                        
                    </div>                   
                </div>
            </div>
        <div class="card-body">
                <div class="form-row">                    
                    <table style="width: 100%;">
                        <tr>
                            
                            <td>
                                <asp:Label ID="Label18" runat="server" Text="EMPRESA" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                                <asp:DropDownList ID="DropDownList3" runat="server" CssClass="formularioProc"  DataTextField="NombreComercial" DataValueField="NombreComercial" AutoPostBack="true" AppendDataBoundItems="true" OnSelectedIndexChanged="fijarempresa" required>
                                    <asp:ListItem Value="0">EMPRESA</asp:ListItem> 
                                </asp:DropDownList>
                            </td>
                            <td>
                                <asp:Label ID="Label14" runat="server" Text="MEDIO DE COBRO" Style="font-weight: bold; font-size: 18px;" required></asp:Label><br />
                                <asp:DropDownList ID="DropDownList2" runat="server" CssClass="formularioProc" DataTextField="Medio" DataValueField="Medio" AutoPostBack="true" AppendDataBoundItems="true" >
                                          <asp:ListItem Value="0">MEDIO DE COBRO</asp:ListItem>                                    
                                </asp:DropDownList>     
                            </td>
                            <td>
                               <asp:Label ID="Label16" runat="server" Text="INICIO VIGENCIA" Style="font-weight: bold; font-size: 18px;" ></asp:Label><br />
                                <input class="formularioProc" placeholder="Cedula" id="Text14" type="date" runat="server"  required/>
                            </td> 
                            <td>
                                <asp:Label ID="Label15" runat="server" Text="¿EL TOMADOR ES UN ASEGURADO?" Style="font-weight: bold; font-size: 18px;" required></asp:Label><br />
                                <input class="formularioProcDOS" name="asegurado" id="Text13" type="radio" runat="server"  /><label> SI </label>
                                <input class="formularioProcDOS" name="asegurado" id="Radio1" type="radio" runat="server"  /><label> NO </label>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="Label1" runat="server" Text="CEDULA" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                                <input class="formularioProc" placeholder="CEDULA" id="Correo" type="text" runat="server"  required />
                            </td>
                            <td>
                                <asp:Label ID="Label2" runat="server" Text="NOMBRE COMPLETO" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                                <input class="formularioProc" placeholder="APELLIDOS/NOMBRES" id="Text1" type="text" runat="server"  required/>
                            </td>
                            <td>
                                <asp:Label ID="Label3" runat="server" Text="FECHA DE NACIMIENTO" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                                <input class="formularioProc" placeholder="Cedula" id="Text2" type="date" runat="server" required/>
                            </td>
                            <td>
                                <asp:Label ID="Label4" runat="server" Text="GENERO" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                                <asp:DropDownList ID="DropDownList1" runat="server" CssClass="formularioProc" >
                                    <asp:ListItem>GENERO</asp:ListItem>
                                    <asp:ListItem>MASCULINO</asp:ListItem>
                                    <asp:ListItem>FEMENINO</asp:ListItem>                                    
                                </asp:DropDownList>                                
                            </td>                            
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="Label7" runat="server" Text="DIRECCION" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                                <input class="formularioProc" placeholder="DIRECCION" id="Text5" type="text" runat="server"  />
                            </td>
                            <td>
                                <asp:Label ID="Label8" runat="server" Text="DIRECCION EMPLEADOR" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                                <input class="formularioProc" placeholder="DIRECCION EMPLEADOR" id="Text6" type="text" runat="server"  />
                            </td>
                            <td>
                                <asp:Label ID="Label9" runat="server" Text="CARGO" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                                <input class="formularioProc" placeholder="CARGO" id="Text7" type="text" runat="server"  />
                            </td>
                            <td>
                                <asp:Label ID="Label10" runat="server" Text="CODIGO" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                                <input class="formularioProc" placeholder="CODIGO" id="Text8" type="text" runat="server"  />
                            </td>                            
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="Label11" runat="server" Text="TELEFONO CELULAR" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                                <input class="formularioProc" placeholder="TELEFONO CELULAR" id="Text9" type="text" runat="server"  />
                            </td>
                            <td>
                                <asp:Label ID="Label12" runat="server" Text="TELEFONO DOMICILIO" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                                <input class="formularioProc" placeholder="TELEFONO DOMICILIO" id="Domicilio" type="text" runat="server"  />
                            </td>
                            <td>
                                <asp:Label ID="Label17" runat="server" Text="TELEFONO EMPRESA" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                                <input class="formularioProc" placeholder="TELEFONO EMPRESA" id="Text10" type="text" runat="server"  />
                            </td>
                            <td>
                                <asp:Label ID="Label13" runat="server" Text="EMAIL" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                                <input class="formularioProc" placeholder="EMAIL" id="Text11" type="email" runat="server"  />
                            </td>                                                      
                        </tr>
                        
                        
                    </table>
                    
                    <hr />
                                            
                    <CENTER><asp:Button  value="REGISTRARME" type="submit" runat="server" CssClass="botonsubmitTRES" Text="CANCELAR" OnClick="Unnamed_Click" UseSubmitBehavior="False" /> 
                        <asp:Button  value="REGISTRARME" type="submit" runat="server" CssClass="botonsubmitTRES" Text="VOLVER" OnClick="Unnamed4_Click" UseSubmitBehavior="False" /> 
                    <asp:Button  value="REGISTRARME" type="submit" runat="server" CssClass="botonsubmitTRES" Text="SIGUIENTE" OnClick="Unnamed_Click1"/>                          

                    </CENTER>
                </div>
            </div>
        </div>
        </div>
    
</asp:Content>
