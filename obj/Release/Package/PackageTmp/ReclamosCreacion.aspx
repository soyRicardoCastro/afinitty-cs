<%@ Page Title="Tarrago Reach System" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ReclamosCreacion.aspx.cs" Inherits="ReachSystem.ReclamosCreacion" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server"> 
    <div class="container">
    <div class="card">
        <div class="card-header">
                <div class="form-row">
                    <div class="col10L">                        
                        <asp:Label ID="Label6" runat="server" Text="CREACION DEL RECLAMO" Style="font-weight: bold; font-size: 18px;"></asp:Label>                                                                        
                    </div>                   
                </div>
            </div>
        <div class="card-body">
                <div class="form-row">                    
                    <table style="width: 100%;">
                        <tr>
                            
                            <td>
                                <asp:Label ID="Label3" runat="server" Text="NRO. CASO" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                                <input class="formularioProc" placeholder="NRO.CASO" id="Text2" type="text" runat="server" required/>
                            </td>    
                            <td>
                                <asp:Label ID="Label8" runat="server" Text="FECHA DE CREACION" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                                <input class="formularioProc" placeholder="FECHA DE CREACION" id="Text6" type="text" runat="server"  />
                            </td>  
                            <td>
                                <asp:Label ID="Label26" runat="server" Text="&nbsp;" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                                <%--<input class="formularioProc" placeholder="&nbsp;" id="Text8" type="text" runat="server"  />--%>
                            </td>  
                            <td>
                                <asp:Label ID="Label27" runat="server" Text="&nbsp;" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                                <%--<input class="formularioProc" placeholder="&nbsp;" id="Text8" type="text" runat="server"  />--%>
                            </td>  
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="Label1" runat="server" Text="CEDULA" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                                <input class="formularioProc" placeholder="CEDULA" id="Correo" type="text" runat="server"  required/>
                            </td>
                            <td>
                                <asp:Label ID="Label2" runat="server" Text="NOMBRE COMPLETO" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                                <input class="formularioProc" placeholder="NOMBRE COMPLETO" id="Text1" type="text" runat="server"  required/>
                            </td>
                            <td>
                                <asp:Label ID="Label4" runat="server" Text="ENTIDAD TOMADORA" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                                <input class="formularioProc" placeholder="ENTIDAD TOMADORA" id="Text3" type="text" runat="server"  />
                            </td> 
                            <td>
                                <asp:Label ID="Label28" runat="server" Text="&nbsp;" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                                <%--<input class="formularioProc" placeholder="&nbsp;" id="Text8" type="text" runat="server"  />--%>
                            </td>  
                            
                                                                                                         
                        </tr>     
                        <tr>
                             <td>
                                <asp:Label ID="Label9" runat="server" Text="CELULAR" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                                <input class="formularioProc" placeholder="CELULAR" id="Text7" type="text" runat="server"  />
                            </td>  
                            <td>
                                <asp:Label ID="Label7" runat="server" Text="DIRECCION EMPLEADOR" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                                <input class="formularioProc" placeholder="DIRECCION EMPLEADOR" id="Text5" type="text" runat="server"  />
                            </td>
                            <td>
                                <asp:Label ID="Label29" runat="server" Text="MEDIO DE COBRO" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                                <input class="formularioProc" placeholder="MEDIO DE COBRO" id="Text8" type="text" runat="server"  />
                            </td>    
                            <td>
                                <asp:Label ID="Label5" runat="server" Text="EJECUTIVO" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                                <input class="formularioProc" placeholder="EJECUTIVO" id="Text4" type="text" runat="server"  />
                            </td>
                                                                                                          
                        </tr> 
                        <tr>
                            <td>
                                <asp:Label ID="Label12" runat="server" Text="ASEGURADO" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                                <input class="formularioProc" placeholder="ASEGURADO" id="Text10" type="text" runat="server"  />
                            </td>
                            <td>
                                <asp:Label ID="Label11" runat="server" Text="RELACION" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                                <input class="formularioProc" placeholder="RELACION" id="Text9" type="text" runat="server"  />
                            </td>  
                            <td>
                                <asp:Label ID="Label14" runat="server" Text="COBERTURA" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                                <input class="formularioProc" placeholder="COBERTURA" id="Text12" type="text" runat="server"  />
                            </td>  
                            <td>
                                <asp:Label ID="Label23" runat="server" Text="PLAN" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                                <input class="formularioProc" placeholder="PLAN" id="Text21" type="text" runat="server"  />
                            </td>  
                                                                                                           
                        </tr> 
                        <tr>
                            <td>
                                <asp:Label ID="Label17" runat="server" Text="CAUSA DE HOSPITALIZACION" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                                <asp:DropDownList ID="Text15" runat="server" CssClass="formularioProc" >
                                    <asp:ListItem>CAUSA</asp:ListItem>
                                    <asp:ListItem>ACCIDENTE</asp:ListItem>
                                    <asp:ListItem>ENFERMEDAD</asp:ListItem>                                    
                                </asp:DropDownList>   
                            </td>                             
                              <td>
                                <asp:Label ID="Label20" runat="server" Text="CASA DE SALUD" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                                <asp:DropDownList ID="Text18" runat="server" CssClass="formularioProc" >
                                    <asp:ListItem>CASA DE SALUD</asp:ListItem>
                                    <asp:ListItem>PUBLICA</asp:ListItem>
                                    <asp:ListItem>PRIVADA</asp:ListItem>                                    
                                </asp:DropDownList>  
                            </td>                                
                            <td>
                                <asp:Label ID="Label15" runat="server" Text="DIAGNOSTICO" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                                <input class="formularioProc" placeholder="DIAGNOSTICO" id="Text13" type="text" runat="server"  />
                            </td>
                            <td>
                                <asp:Label ID="Label16" runat="server" Text="OBSERVACIONES" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                                <input class="formularioProc" placeholder="OBSERVACIONES" id="Text14" type="text" runat="server"  />
                            </td>                                                                                
                        </tr> 
                       
                    </table>                    
                    <hr />  
                    
                    <CENTER><asp:Button  value="FF" type="submit" runat="server" CssClass="botonsubmitTRES" Text="CANCELAR" OnClick="Unnamed_Click" UseSubmitBehavior="False" />  
                        <asp:Button  value="FF" type="submit" runat="server" CssClass="botonsubmitTRES" Text="VOLVER" OnClick="Unnamed2_Click" UseSubmitBehavior="False" />  
                    <asp:Button  value="REGISTRARME" type="submit" runat="server" CssClass="botonsubmitTRES" Text="CREAR CASO" OnClick="Unnamed_Click1" UseSubmitBehavior="False" />                          

                    </CENTER>
                </div>
            </div>
        </div>
        </div>
    
</asp:Content>
