<%@ Page Title="Tarrago Reach System" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="InclusionAegurados.aspx.cs" Inherits="ReachSystem.InclusionAegurados" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server"> 
    <div class="container">
    <div class="card">
        <div class="card-header">
                <div class="form-row">
                    <div class="col10L">                        
                        <asp:Label ID="Label6" runat="server" Text="INCLUSIÓN: ASEGURADOS" Style="font-weight: bold; font-size: 18px;"></asp:Label>                        
                        <asp:Label ID="Label11" runat="server" Text="ADICION: COBERTURAS" Style="font-weight: bold; font-size: 18px;"></asp:Label>                        
                        <asp:Label ID="Label12" runat="server" Text="ADICION: ASEGURADOS" Style="font-weight: bold; font-size: 18px;"></asp:Label>                        
                        <asp:Label ID="Label13" runat="server" Text="PROCESAR CERTIFICADO: ASEGURADOS" Style="font-weight: bold; font-size: 18px;"></asp:Label>                        
                        <asp:Label ID="Label14" runat="server" Text="REEMPLAZO: COBERTURAS" Style="font-weight: bold; font-size: 18px;"></asp:Label>                        
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
                            <td>
                                <asp:Label ID="Label18" runat="server" Text="INICIO VIGENCIA" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                                <input class="formularioProc" placeholder="vigencia" id="Text6" type="date" runat="server"   />
                            </td>
                        </tr>
                    </table>
                   
                    <hr />
                      
                        <center><asp:Label ID="Label17" runat="server" Text="ASEGURADOS" Style="font-weight: bold; font-size: 24px;"></asp:Label></center><br />
                    <table style="width: 100%;">
                        <tr>
                            <td>
                                <asp:Label ID="Label1" runat="server" Text="CEDULA" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                                <input class="formularioProc" placeholder="CEDULA" id="Correo" type="text" runat="server" ValidationGroup="ValidateMe" />
                            </td>
                            <td>
                                <asp:Label ID="Label2" runat="server" Text="NOMBRE COMPLETO" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                                <input class="formularioProc" placeholder="NOMBRE COMPLETO" id="Text1" type="text" runat="server" ValidationGroup="ValidateMe" required/>
                            </td>
                            <td>
                                <asp:Label ID="Label3" runat="server" Text="FECHA DE NACIMIENTO" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                                <input class="formularioProc" placeholder="Cedula" id="Text2" type="date" runat="server" ValidationGroup="ValidateMe" required/>
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
                                <asp:Label ID="Label7" runat="server" Text="RELACION" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                                <asp:DropDownList ID="DropDownList2" runat="server" CssClass="formularioProc"   AppendDataBoundItems="true" DataTextField="Aplica" DataValueField="Aplica" OnSelectedIndexChanged="fijarrelacion" AutoPostBack="true">
                                <asp:ListItem Value="0">RELACION</asp:ListItem>  
                                </asp:DropDownList>                               
                            </td>
                            <td>                                
                                <asp:Label ID="Label8" runat="server" Text="COBERTURA" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                                <asp:DropDownList ID="DropDownList3" runat="server" CssClass="formularioProc" DataTextField="Producto" DataValueField="Producto" AutoPostBack="true" AppendDataBoundItems="true" OnSelectedIndexChanged="fijarcobertura">
                                <asp:ListItem Value="0">COBERTURA</asp:ListItem> 
                                </asp:DropDownList>                                                                 
                            </td>
                            <td>
                                <asp:Label ID="Label9" runat="server" Text="PLAN" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                                <asp:DropDownList ID="DropDownList4" runat="server" CssClass="formularioProc"  DataTextField="PlanSelect" DataValueField="PlanSelect" AutoPostBack="true" AppendDataBoundItems="true" OnSelectedIndexChanged="fijarplan">
                                    <asp:ListItem Value="0">PLAN</asp:ListItem> 
                                </asp:DropDownList>                                
                            </td>
                            <td>
                                <asp:Label ID="Label10" runat="server" Text="PRIMA $" Style="font-weight: bold; font-size: 18px;"></asp:Label><br />
                                <asp:Label ID="prefifin" runat="server" CssClass="formularioFin" ></asp:Label>
                                <asp:DropDownList ID="DropDownList5" runat="server" CssClass="formularioFin"  DataTextField="Valor" DataValueField="Valor" AutoPostBack="true" AppendDataBoundItems="true">
                                    <asp:ListItem Value="0">0,00</asp:ListItem> 
                                </asp:DropDownList>    
                                <asp:DropDownList ID="DropDownList6" runat="server" CssClass="formularioFin"  DataTextField="Edadmin" DataValueField="Edadmin" AutoPostBack="true" AppendDataBoundItems="true">
                                    <asp:ListItem Value="0">0</asp:ListItem> 
                                </asp:DropDownList> 
                                <asp:DropDownList ID="DropDownList7" runat="server" CssClass="formularioFin"  DataTextField="Edadmax" DataValueField="Edadmax" AutoPostBack="true" AppendDataBoundItems="true">
                                    <asp:ListItem Value="0">0</asp:ListItem> 
                                </asp:DropDownList> 
                            </td> 
                            
                        </tr>  
                        
                    </table> 
                        
                    <hr />                                            
                    <CENTER>
                        <asp:Button runat="server" CssClass="botonsubmitTRES" text="SRI" OnClick="Unnamed_Click6" ID="sri"></asp:Button>  
                    <asp:Button  value="REGISTRARME" type="submit" runat="server" CssClass="botonsubmitTRES" Text="REGISTRO CIVIL" OnClick="Unnamed_Click5" ID="regis"/>    
                        <asp:Button  value="REGISTRARME" type="submit" runat="server" CssClass="botonsubmitTRES" Text="NUEVO ASEGURADO" OnClick="Unnamed_Click7" ID="nuevoaseg"/>   
                                                                     
                    </CENTER>
                    <hr />                                            
                    <CENTER><asp:Button  value="REGISTRARME" CausesValidation="false" runat="server" CssClass="botonsubmitTRES" Text="CANCELAR" OnClick="Unnamed_Click3" UseSubmitBehavior="False" />  
                        <asp:Button  value="REGISTRARME" type="submit" runat="server" CssClass="botonsubmitTRES" Text="GUARDAR" OnClick="Unnamed_Click"/>     
                        <asp:Button  value="REGISTRARME" CausesValidation="false" runat="server" CssClass="botonsubmitTRES" Text="VOLVER" OnClick="Unnamed_Click2" UseSubmitBehavior="False" ID="VOLVERCLICK"/> 
                    <asp:Button  value="REGISTRARME" type="submit" runat="server" CssClass="botonsubmitTRES" Text="SIGUIENTE" OnClick="Unnamed_Click1" UseSubmitBehavior="False" ID="siguiclick"/>  
                        <asp:Button  value="REGISTRARME" type="submit" runat="server" CssClass="botonsubmitTRES" Text="ELIMINAR COBERTURA" OnClick="Button1_Click" UseSubmitBehavior="False" ID="Button1"/> 
                    </CENTER>
                </div>
            </div>
        </div>
        </div>    
</asp:Content>
