<%@ Page Title="Tarrago Reach System" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EditarUsuarioDos.aspx.cs" Inherits="ReachSystem.EditarUsuarioDos" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server"> 
    <div class="container">
    <div class="card">
        <div class="card-header">
                <div class="form-row">
                    <div class="col10L">                        
                        <asp:Label ID="Label6" runat="server" Text="USUARIOS: EDICION" Style="font-weight: bold; font-size: 18px;"></asp:Label>   
                        
                    </div>                   
                </div>
            </div>
        <div class="card-body">
                <div class="form-row">                    
                      
                        <%--<center><asp:Label ID="Label17" runat="server" Text="CREACION" Style="font-weight: bold; font-size: 24px;"></asp:Label></center><br />--%>
                    <table style="width: 100%;">
                         <tr>
                             <td>
                                <asp:Label ID="Label8" runat="server" Text="CEDULA" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                                <input class="formularioProc" placeholder="CEDULA" id="Text7" type="text" runat="server" ValidationGroup="ValidateMe" required/>
                            </td>
                            <td>
                                <asp:Label ID="Label1" runat="server" Text="NOMBRES" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                                <input class="formularioProc" placeholder="NOMBRES" id="Correo" type="text" runat="server" ValidationGroup="ValidateMe" required/>
                            </td>
                            <td>
                                <asp:Label ID="Label12" runat="server" Text="APELLIDOS" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                                <input class="formularioProc" placeholder="APELLIDOS" id="Text4" type="text" runat="server" ValidationGroup="ValidateMe" required/>
                            </td>                             
                            <td>
                                 <asp:Label ID="Label11" runat="server" Text="ALIAS" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                                <input class="formularioProc" placeholder="ALIAS" id="Text3" type="text" runat="server" ValidationGroup="ValidateMe" required/>
                            </td>
                                                      
                            </tr>
                        
                        <tr>
                             
                             <td>
                                <asp:Label ID="Label4" runat="server" Text="CARGO" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                                     <asp:DropDownList ID="DropDownList1" runat="server" CssClass="formularioProc"  AppendDataBoundItems="true" DataTextField="Edadmax" DataValueField="Edadmax">
                                    <asp:ListItem>CARGO</asp:ListItem>
    <asp:ListItem>MENSAJERO</asp:ListItem>
    <asp:ListItem>EJECUTIVO COMERCIAL</asp:ListItem>
    <asp:ListItem>ASISTENTE ADMINISTRATIVO</asp:ListItem>
    <asp:ListItem>SUPERVISOR COMERCIAL</asp:ListItem>
    <asp:ListItem>DIRECTOR COMERCIAL</asp:ListItem>
    <asp:ListItem>SUPERVISOR OPERACIONES</asp:ListItem>
    <asp:ListItem>GERENTE OPERACIONES</asp:ListItem>
    <asp:ListItem>GERENTE GENERAL</asp:ListItem>
</asp:DropDownList>
                                                             
                            </td>           
                            <td>
                                <asp:Label ID="Label3" runat="server" Text="PERFIL" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                                <asp:DropDownList ID="DropDownList7" runat="server" CssClass="formularioProc"  AppendDataBoundItems="true" DataTextField="Edadmin" DataValueField="Edadmin">
                                    <asp:ListItem>PERFIL</asp:ListItem>
    <asp:ListItem>COBRANZA</asp:ListItem>
    <asp:ListItem>VENTA</asp:ListItem>
                                    <asp:ListItem>SERVICIO</asp:ListItem>
    <asp:ListItem>OPERACIONES</asp:ListItem>
    <asp:ListItem>SUPERVEN</asp:ListItem>
                                    <asp:ListItem>DIRECVEN</asp:ListItem>
    <asp:ListItem>SUPEROP</asp:ListItem>
    <asp:ListItem>ADMIN</asp:ListItem>
</asp:DropDownList>
                                                   
                            </td>                            
                        
                                             
                                            
                          
                            <td>
                                <asp:Label ID="Label9" runat="server" Text="FECHA INGRESO" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                                <input class="formularioProc"  id="Text1" type="date" runat="server" ValidationGroup="ValidateMe" required/>                             
                            </td>
                             <td>
                                <asp:Label ID="Label5" runat="server" Text="CIUDAD" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                                <asp:DropDownList ID="DropDownList2" runat="server" CssClass="formularioProc"  AppendDataBoundItems="true" DataTextField="Edadmin" DataValueField="Edadmin">
                                    <asp:ListItem>CIUDAD</asp:ListItem>
    <asp:ListItem>QUITO</asp:ListItem>
    <asp:ListItem>GUAYAQUIL</asp:ListItem>

</asp:DropDownList>
                                                   
                            </td>         
                            
                            
                            
                        </tr> 
                        <tr>
                            <td>
                                <asp:Label ID="Label13" runat="server" Text="USUARIO" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                                <input class="formularioProc" placeholder="USUARIO" id="Text5" type="text" runat="server" ValidationGroup="ValidateMe" required/>
                            </td>  
                           
                                <%--<asp:Label ID="Label7" runat="server" Text="CONTRASEÑA" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />--%>
                                <%--<input class="formularioProc" placeholder="CONTRASEÑA" id="Text2" type="password" runat="server" ValidationGroup="ValidateMe" required/>--%>
                           
                            <td>
                                <asp:Label ID="Label2" runat="server" Text="CORREO" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                                <input class="formularioProc" placeholder="CORREO" id="Text6" type="text" runat="server" ValidationGroup="ValidateMe" required/>
                            </td> 
                            <td>
                                <asp:Label ID="Label15" runat="server" Text="CELULAR" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                                <input class="formularioProc" placeholder="CELULAR" id="Text8" type="text" runat="server" ValidationGroup="ValidateMe" required/>
                            </td> 
                              </tr>
                        
                        <tr>
                            <td>
                                <asp:Label ID="Label10" runat="server" Text="HORA ENTRADA" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                                <input class="formularioProc" placeholder="HORA ENTTRADA" id="horaini" type="text" runat="server" ValidationGroup="ValidateMe" required/>
                            </td>
                            <td>
                                <asp:Label ID="Label14" runat="server" Text="HORA SALIDA" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                                <input class="formularioProc" placeholder="HORA SALIDA" id="horacier" type="text" runat="server" ValidationGroup="ValidateMe" required/>
                            </td>  
                             <td>
                                    <center>
                                
                                    <input class="formularioProcDOS" name="asegurado3" id="Radio8" type="radio" runat="server"  value="ACTIVO" /><label> ACTIVO </label><br />
                                <input class="formularioProcDOS" name="asegurado3" id="Radio9" type="radio" runat="server"  value="INACTIVO" /><label> INACTIVO </label>
                                    
                                </center>
                            </td>
                            </tr>  
                    
                        

                           
                           
                       
                        
                    </table> 
                        
                    <hr />     
                    <CENTER><asp:Button  value="REGISTRARME" CausesValidation="false" runat="server" CssClass="botonsubmitTRES" Text="CANCELAR" OnClick="Unnamed_Click3" UseSubmitBehavior="False" />
                        <asp:Button  value="REGISTRARME" CausesValidation="false" runat="server" CssClass="botonsubmitTRES" Text="VOLVER" OnClick="Unnamed_Click1" UseSubmitBehavior="False" ID="VOLVER"/>
                    <asp:Button  value="REGISTRARME" type="submit" runat="server" CssClass="botonsubmitTRES" Text="GUARDAR" OnClick="Unnamed_Click"/>             
                        <%--<asp:Button  value="REGISTRARME" CausesValidation="false" runat="server" CssClass="botonsubmitTRES" Text="ELIMINAR" OnClick="Unnamed_Click2" UseSubmitBehavior="False" ID="ELIMINAR"/>--%>
                    </CENTER>
                                       
                    
                </div>
            </div>
        </div>
        </div>    
</asp:Content>
