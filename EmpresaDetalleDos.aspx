<%@ Page Title="Tarrago Reach System" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EmpresaDetalleDos.aspx.cs" Inherits="ReachSystem.EmpresaDetalleDos" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server"> 
    <div class="container">
    <div class="card">
        <div class="card-header">
                <div class="form-row">
                    <div class="col10L">                        
                        <asp:Label ID="Label6" runat="server" Text="DATOS" Style="font-weight: bold; font-size: 18px;"></asp:Label>                                                                        
                    </div>                   
                </div>
            </div>
        <div class="card-body">
                <div class="form-row">                    
                    <table style="width: 100%;">
                        <tr>
                            <td>
                                <asp:Label ID="Label1" runat="server" Text="RUC" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                                <input class="formularioProc" placeholder="RUC" id="Correo" type="text" runat="server"  />
                            </td>
                            <td>
                                <asp:Label ID="Label2" runat="server" Text="RAZON SOCIAL" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                                <input class="formularioProc" placeholder="RAZON SOCIAL" id="Text1" type="text" runat="server"  />
                            </td>
                            <td>
                                <asp:Label ID="Label3" runat="server" Text="NOMBRE COMERCIAL" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                                <input class="formularioProc" placeholder="NOMBRE COMERCIAL" id="Text2" type="text" runat="server" />
                            </td>                                                      
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="Label9" runat="server" Text="DIRECCION" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                                <input class="formularioProc" placeholder="DIRECCION" id="Text7" type="text" runat="server"  />
                            </td>  
                            <td>
                                <asp:Label ID="Label7" runat="server" Text="PROVINCIA" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                                <input class="formularioProc" placeholder="PROVINCIA" id="Text5" type="text" runat="server"  />
                            </td>
                            <td>
                                <asp:Label ID="Label8" runat="server" Text="CIUDAD" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                                <input class="formularioProc" placeholder="CIUDAD" id="Text6" type="text" runat="server"  />
                            </td>                                                                                
                        </tr>                                                             
                    </table>                    
                    <hr />  
                    <CENTER><asp:Label ID="Label4" runat="server" Text="CONTACTOS DE FACTURACION" Style="font-weight: bold; font-size: 18px;"></asp:Label></CENTER>
                    <hr />  
                    <table style="width: 100%;">
                        <tr>
                            <td>
                                <asp:Label ID="Label5" runat="server" Text="CONTACTO" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                                <input class="formularioProc" placeholder="CONTACTO" id="Text3" type="text" runat="server"  />
                            </td>
                            <td>
                                <asp:Label ID="Label10" runat="server" Text="TELEFONO" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                                <input class="formularioProc" placeholder="TELEFONO" id="Text4" type="text" runat="server" />
                            </td>
                            <td>
                                <asp:Label ID="Label11" runat="server" Text="CELULAR" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                                <input class="formularioProc" placeholder="CELULAR" id="Text8" type="text" runat="server" />
                            </td>  
                            <td>
                                <asp:Label ID="Label20" runat="server" Text="EMAIL" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                                <input class="formularioProc" placeholder="EMAIL" id="Text17" type="text" runat="server"  />
                            </td>   
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="Label12" runat="server" Text="CONTACTO" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                                <input class="formularioProc" placeholder="CONTACTO" id="Text9" type="text" runat="server"  />
                            </td>
                            <td>
                                <asp:Label ID="Label13" runat="server" Text="TELEFONO" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                                <input class="formularioProc" placeholder="TELEFONO" id="Text10" type="text" runat="server"  />
                            </td>
                            <td>
                                <asp:Label ID="Label14" runat="server" Text="CELULAR" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                                <input class="formularioProc" placeholder="CELULAR" id="Text11" type="text" runat="server" />
                            </td>  
                            <td>
                                <asp:Label ID="Label15" runat="server" Text="EMAIL" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                                <input class="formularioProc" placeholder="EMAIL" id="Text12" type="text" runat="server"  />
                            </td>   
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="Label16" runat="server" Text="CONTACTO" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                                <input class="formularioProc" placeholder="CONTACTO" id="Text13" type="text" runat="server"  />
                            </td>
                            <td>
                                <asp:Label ID="Label17" runat="server" Text="TELEFONO" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                                <input class="formularioProc" placeholder="TELEFONO" id="Text14" type="text" runat="server"  />
                            </td>
                            <td>
                                <asp:Label ID="Label18" runat="server" Text="CELULAR" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                                <input class="formularioProc" placeholder="CELULAR" id="Text15" type="text" runat="server" />
                            </td>  
                            <td>
                                <asp:Label ID="Label19" runat="server" Text="EMAIL" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                                <input class="formularioProc" placeholder="EMAIL" id="Text16" type="text" runat="server"  />
                            </td>   
                        </tr>                       
                    </table> 
                     <hr />  
                    <CENTER><asp:Label ID="Label21" runat="server" Text="CONTACTOS DEL LISTADO" Style="font-weight: bold; font-size: 18px;"></asp:Label></CENTER>
                    <hr /> 
                    <table style="width: 100%;">
                        <tr>
                            <td>
                                <asp:Label ID="Label22" runat="server" Text="CONTACTO" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                                <input class="formularioProc" placeholder="CONTACTO" id="Text18" type="text" runat="server"  />
                            </td>
                            <td>
                                <asp:Label ID="Label23" runat="server" Text="TELEFONO" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                                <input class="formularioProc" placeholder="TELEFONO" id="Text19" type="text" runat="server" />
                            </td>
                            <td>
                                <asp:Label ID="Label24" runat="server" Text="CELULAR" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                                <input class="formularioProc" placeholder="CELULAR" id="Text20" type="text" runat="server" />
                            </td>  
                            <td>
                                <asp:Label ID="Label25" runat="server" Text="EMAIL" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                                <input class="formularioProc" placeholder="EMAIL" id="Text21" type="text" runat="server"  />
                            </td>   
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="Label26" runat="server" Text="CONTACTO" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                                <input class="formularioProc" placeholder="CONTACTO" id="Text22" type="text" runat="server"  />
                            </td>
                            <td>
                                <asp:Label ID="Label27" runat="server" Text="TELEFONO" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                                <input class="formularioProc" placeholder="TELEFONO" id="Text23" type="text" runat="server"  />
                            </td>
                            <td>
                                <asp:Label ID="Label28" runat="server" Text="CELULAR" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                                <input class="formularioProc" placeholder="CELULAR" id="Text24" type="text" runat="server" />
                            </td>  
                            <td>
                                <asp:Label ID="Label29" runat="server" Text="EMAIL" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                                <input class="formularioProc" placeholder="EMAIL" id="Text25" type="text" runat="server"  />
                            </td>   
                        </tr>                                             
                    </table> 
                    <hr />  
                    <CENTER><asp:Label ID="Label30" runat="server" Text="CONTACTOS DE COBRANZA" Style="font-weight: bold; font-size: 18px;"></asp:Label></CENTER>
                    <hr /> 
                    <table style="width: 100%;">
                        <tr>
                            <td>
                                <asp:Label ID="Label31" runat="server" Text="CONTACTO" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                                <input class="formularioProc" placeholder="CONTACTO" id="Text26" type="text" runat="server"  />
                            </td>
                            <td>
                                <asp:Label ID="Label32" runat="server" Text="TELEFONO" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                                <input class="formularioProc" placeholder="TELEFONO" id="Text27" type="text" runat="server"  />
                            </td>
                            <td>
                                <asp:Label ID="Label33" runat="server" Text="CELULAR" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                                <input class="formularioProc" placeholder="CELULAR" id="Text28" type="text" runat="server" />
                            </td>  
                            <td>
                                <asp:Label ID="Label34" runat="server" Text="EMAIL" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                                <input class="formularioProc" placeholder="EMAIL" id="Text29" type="text" runat="server"  />
                            </td>   
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="Label35" runat="server" Text="CONTACTO" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                                <input class="formularioProc" placeholder="CONTACTO" id="Text30" type="text" runat="server"  />
                            </td>
                            <td>
                                <asp:Label ID="Label36" runat="server" Text="TELEFONO" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                                <input class="formularioProc" placeholder="TELEFONO" id="Text31" type="text" runat="server"  />
                            </td>
                            <td>
                                <asp:Label ID="Label37" runat="server" Text="CELULAR" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                                <input class="formularioProc" placeholder="CELULAR" id="Text32" type="text" runat="server" />
                            </td>  
                            <td>
                                <asp:Label ID="Label38" runat="server" Text="EMAIL" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                                <input class="formularioProc" placeholder="EMAIL" id="Text33" type="text" runat="server"  />
                            </td>   
                        </tr>                                             
                    </table> 
                    <hr /> 
                    <table style="width: 100%;">
                        <tr>
                            <td>
                                <asp:Label ID="Label39" runat="server" Text="POLIZA" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                                <asp:DropDownList ID="DropDownList4" runat="server" class="formularioProc">
                                    <asp:ListItem>POLIZA</asp:ListItem>
                                    <asp:ListItem>77715</asp:ListItem>
                                    <asp:ListItem>77731</asp:ListItem>
                                </asp:DropDownList>
                            </td>
                            <td>
                                <asp:Label ID="Label40" runat="server" Text="CLASE" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                                <input class="formularioProc" placeholder="CLASE" id="Text35" type="text" runat="server"  />
                            </td>
                            <td>
                                <asp:Label ID="Label41" runat="server" Text="EJECUTIVO DE APERTURA" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                                <asp:DropDownList ID="DropDownList1" runat="server" CssClass="formularioProc" DataSourceID="SqlDataSource1" DataTextField="Alias" DataValueField="Alias"></asp:DropDownList>
                                <asp:SqlDataSource runat="server" ID="SqlDataSource1" ConnectionString='<%$ ConnectionStrings:affisDBConnectionString %>' SelectCommand="SELECT [Alias] FROM [Usuario] where Estado='ACTIVO' order by Alias asc"></asp:SqlDataSource>
                            </td>                              
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="Label43" runat="server" Text="FECHA FACTURACION" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />                                
                                <asp:DropDownList ID="DropDownList3" runat="server" class="formularioProc">
                                    <asp:ListItem>FECHA</asp:ListItem>
                                    <asp:ListItem>8</asp:ListItem>
                                    <asp:ListItem>18</asp:ListItem>
                                </asp:DropDownList>
                            </td>
                            <td>
                                <asp:Label ID="Label44" runat="server" Text="FECHA ENVIO LISTADO" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                                <input class="formularioProc" placeholder="FECHA ENVIO LISTADO" id="Text39" type="text" runat="server" />
                            </td>
                            <td>
                                <asp:Label ID="Label45" runat="server" Text="TIPO DE LISTADO" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                                <asp:DropDownList ID="DropDownList5" runat="server" class="formularioProc">
                                    <asp:ListItem>TIPO</asp:ListItem>
                                    <asp:ListItem>CORREO</asp:ListItem>
                                    <asp:ListItem>FISICO</asp:ListItem>
                                    <asp:ListItem>AMBOS</asp:ListItem>
                                </asp:DropDownList>
                            </td>                             
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="Label47" runat="server" Text="EMITE FACTURA DE COMISION" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                                <asp:DropDownList ID="DropDownList2" runat="server" CssClass="formularioProc">
                                    <asp:ListItem>SELECCIONE</asp:ListItem>
                                    <asp:ListItem>SI</asp:ListItem>
                                    <asp:ListItem>NO</asp:ListItem>
                                </asp:DropDownList>
                            </td>
                            <td>
                                <asp:Label ID="Label48" runat="server" Text="PORCENTAJE COMISION" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                                <input class="formularioProc" placeholder="PORCENTAJE COMISION" id="Text43" type="text" runat="server"  />
                            </td>
                            <td>
                                <asp:Label ID="Label49" runat="server" Text="FECHA LLAMADA" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                                <input class="formularioProc" placeholder="FECHA LLAMADA" id="Text44" type="text" runat="server" />
                            </td>                                 
                        </tr>                       
                    </table> 
                    <hr />
                    <table style="width: 100%;">  
                        <tr>
                            <td><center><asp:Label ID="Label51" runat="server" Text="MEDIO DE COBRO" Style="font-weight: bold; font-size: 18px;"></asp:Label></center></td>
                            <td><center><asp:Label ID="Label52" runat="server" Text="FORMA DE PAGO" Style="font-weight: bold; font-size: 18px;"></asp:Label></center></td>
                            <td><center><asp:Label ID="Label42" runat="server" Text="ESTADO" Style="font-weight: bold; font-size: 18px;"></asp:Label></center></td>

                        </tr>
                        <tr>
                            
                            <td>
                                <center>
                                
                                <input class="formularioProcDOS" name="asegurado2" id="Radio1" type="radio" runat="server"  value="TARJETA DE CREDITO" /><label> TARJETA DE CREDITO </label><br />
                                <input class="formularioProcDOS" name="asegurado2" id="Radio2" type="radio" runat="server" value="ROL DE PAGOS" /><label> ROL DE PAGOS </label><br />
                                <input class="formularioProcDOS" name="asegurado2" id="Radio7" type="radio" runat="server" value="AMBOS" /><label> AMBOS </label>
                                </center>
                            </td>
                            <td>
                                <center>
                                
                                    <input class="formularioProcDOS" name="asegurado" id="Radio3" type="radio" runat="server" value="TRANSFERENCIA" /><label> TRANSFERENCIA </label><br />
                                <input class="formularioProcDOS" name="asegurado" id="Radio4" type="radio" runat="server"  value="CHEQUE" /><label> CHEQUE </label><br />
                                    <input class="formularioProcDOS" name="asegurado" id="Radio5" type="radio" runat="server" value="DEBITO BANCARIO" /><label> DEBITO BANCARIO </label><br />
                                    <input class="formularioProcDOS" name="asegurado" id="Radio6" type="radio" runat="server" value="MIX" /><label> MIX </label>
                                </center>
                            </td> 
                            <td>
                                <center>
                                
                                    <input class="formularioProcDOS" name="asegurado3" id="Radio8" type="radio" runat="server"  value="ACTIVA" /><label> ACTIVA </label><br />
                                <input class="formularioProcDOS" name="asegurado3" id="Radio9" type="radio" runat="server"  value="INACTIVA" /><label> INACTIVA </label>
                                    
                                </center>
                            </td>
                        </tr>                                             
                    </table> 
                    <hr />
                    <CENTER><asp:Button  value="FF" type="submit" runat="server" CssClass="botonsubmitTRES" Text="CANCELAR" OnClick="Unnamed_Click" UseSubmitBehavior="False" />
                        <asp:Button  value="FF" type="submit" runat="server" CssClass="botonsubmitTRES" Text="VOLVER" OnClick="Unnamed2_Click" UseSubmitBehavior="False" />
                    <asp:Button  value="REGISTRARME" type="submit" runat="server" CssClass="botonsubmitTRES" Text="GUARDAR" OnClick="Unnamed_Click1" UseSubmitBehavior="False" />      
                        <asp:Button  value="FF" type="submit" runat="server" CssClass="botonsubmitTRES" Text="ELIMINAR" OnClick="Unnamed_Click12" UseSubmitBehavior="False" ID="elimbutton" />

                    </CENTER>
                </div>
            </div>
        </div>
        </div>
    
</asp:Content>
