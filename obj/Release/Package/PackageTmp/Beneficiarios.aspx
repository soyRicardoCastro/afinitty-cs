<%@ Page Title="Tarrago Reach System" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Beneficiarios.aspx.cs" Inherits="ReachSystem.Beneficiarios" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server"> 
    <div class="container">
    <div class="card">
        <div class="card-header">
                <div class="form-row">
                    <div class="col10L">                        
                        <asp:Label ID="Label6" runat="server" Text="PROCESAR CERTIFICADOS: BENEFICIARIOS" Style="font-weight: bold; font-size: 18px;"></asp:Label>                        
                    </div>                   
                </div>
            </div>
        <div class="card-body">
                <div class="form-row">                           
                    <hr />
                    <asp:Label ID="Label4" runat="server" Text="BENEFICIARIOS TOMADOR" Style="font-weight: bold; font-size: 18px;"></asp:Label> 
                    <hr />
                    
                    <table style="width: 100%;">
                        <tr>
                            <td><asp:Label ID="Label1" runat="server" Text="NOMBRES COMPLETOS" Style="font-weight: bold; font-size: 18px;"></asp:Label></td>
                            <td><asp:Label ID="Label2" runat="server" Text="PARENTESCO" Style="font-weight: bold; font-size: 18px;"></asp:Label></td>
                            <td><asp:Label ID="Label3" runat="server" Text="PORCENTAJE %" Style="font-weight: bold; font-size: 18px;"></asp:Label></td>                            
                        </tr>
                        <tr>
                            <td><input class="formularioProc2" placeholder="NOMBRES COMPLETOS" id="Correo" type="text" runat="server"/><br /></td>
                            <td><input class="formularioProc2" placeholder="PARENTESCO" id="Text1" type="text" runat="server"/><br /></td>
                            <td><input class="formularioProc2" placeholder="PORCENTAJE" id="Text2" type="number" runat="server"/><br /></td>                            
                        </tr>
                        <tr>
                            <td><input class="formularioProc2" placeholder="NOMBRES COMPLETOS" id="Text3" type="text" runat="server"/><br /></td>
                            <td><input class="formularioProc2" placeholder="PARENTESCO" id="Text4" type="text" runat="server"/><br /></td>
                            <td><input class="formularioProc2" placeholder="PORCENTAJE" id="Text5" type="number" runat="server"/><br /></td>                            
                        </tr>
                         <tr>
                            <td><input class="formularioProc2" placeholder="NOMBRES COMPLETOS" id="Text6" type="text" runat="server"/><br /></td>
                            <td><input class="formularioProc2" placeholder="PARENTESCO" id="Text7" type="text" runat="server"/><br /></td>
                            <td><input class="formularioProc2" placeholder="PORCENTAJE" id="Text8" type="number" runat="server"/><br /></td>                            
                        </tr>
                        <tr>
                            <td><input class="formularioProc2" placeholder="NOMBRES COMPLETOS" id="Text9" type="text" runat="server"/><br /></td>
                            <td><input class="formularioProc2" placeholder="PARENTESCO" id="Text10" type="text" runat="server"/><br /></td>
                            <td><input class="formularioProc2" placeholder="PORCENTAJE" id="Text11" type="number" runat="server"/><br /></td>                            
                        </tr>
                        <tr>
                            <td><input class="formularioProc2" placeholder="NOMBRES COMPLETOS" id="Text12" type="text" runat="server"/><br /></td>
                            <td><input class="formularioProc2" placeholder="PARENTESCO" id="Text13" type="text" runat="server"/><br /></td>
                            <td><input class="formularioProc2" placeholder="PORCENTAJE" id="Text14" type="number" runat="server"/><br /></td>                            
                        </tr>
                    </table>
                    <hr />
                    <asp:Label ID="Label5" runat="server" Text="BENEFICIARIOS CONYUGE" Style="font-weight: bold; font-size: 18px;"></asp:Label> 
                    <hr />
                    <table style="width: 100%;">
                        <tr>
                            <td><asp:Label ID="Label7" runat="server" Text="NOMBRES COMPLETOS" Style="font-weight: bold; font-size: 18px;"></asp:Label></td>
                            <td><asp:Label ID="Label8" runat="server" Text="PARENTESCO" Style="font-weight: bold; font-size: 18px;"></asp:Label></td>
                            <td><asp:Label ID="Label9" runat="server" Text="PORCENTAJE %" Style="font-weight: bold; font-size: 18px;"></asp:Label></td>                            
                        </tr>
                        <tr>
                            <td><input class="formularioProc2" placeholder="NOMBRES COMPLETOS" id="Text15" type="text" runat="server"/><br /></td>
                            <td><input class="formularioProc2" placeholder="PARENTESCO" id="Text16" type="text" runat="server"/><br /></td>
                            <td><input class="formularioProc2" placeholder="PORCENTAJE" id="Text17" type="number" runat="server"/><br /></td>                            
                        </tr>
                        <tr>
                            <td><input class="formularioProc2" placeholder="NOMBRES COMPLETOS" id="Text18" type="text" runat="server"/><br /></td>
                            <td><input class="formularioProc2" placeholder="PARENTESCO" id="Text19" type="text" runat="server"/><br /></td>
                            <td><input class="formularioProc2" placeholder="PORCENTAJE" id="Text20" type="number" runat="server"/><br /></td>                            
                        </tr>
                         <tr>
                            <td><input class="formularioProc2" placeholder="NOMBRES COMPLETOS" id="Text21" type="text" runat="server"/><br /></td>
                            <td><input class="formularioProc2" placeholder="PARENTESCO" id="Text22" type="text" runat="server"/><br /></td>
                            <td><input class="formularioProc2" placeholder="PORCENTAJE" id="Text23" type="number" runat="server"/><br /></td>                            
                        </tr>
                        <tr>
                            <td><input class="formularioProc2" placeholder="NOMBRES COMPLETOS" id="Text24" type="text" runat="server"/><br /></td>
                            <td><input class="formularioProc2" placeholder="PARENTESCO" id="Text25" type="text" runat="server"/><br /></td>
                            <td><input class="formularioProc2" placeholder="PORCENTAJE" id="Text26" type="number" runat="server"/><br /></td>                            
                        </tr>
                        <tr>
                            <td><input class="formularioProc2" placeholder="NOMBRES COMPLETOS" id="Text27" type="text" runat="server"/><br /></td>
                            <td><input class="formularioProc2" placeholder="PARENTESCO" id="Text28" type="text" runat="server"/><br /></td>
                            <td><input class="formularioProc2" placeholder="PORCENTAJE" id="Text29" type="number" runat="server"/><br /></td>                            
                        </tr>
                    </table>
                    <hr />
                    <asp:Label ID="Label10" runat="server" Text="BENEFICIARIOS PROGENITORES" Style="font-weight: bold; font-size: 18px;"></asp:Label> 
                    <hr />
                    <table style="width: 100%;">
                        <tr>
                            <td><asp:Label ID="Label11" runat="server" Text="NOMBRES COMPLETOS" Style="font-weight: bold; font-size: 18px;"></asp:Label></td>
                            <td><asp:Label ID="Label12" runat="server" Text="PARENTESCO" Style="font-weight: bold; font-size: 18px;"></asp:Label></td>
                            <td><asp:Label ID="Label13" runat="server" Text="PORCENTAJE %" Style="font-weight: bold; font-size: 18px;"></asp:Label></td>                            
                        </tr>
                        <tr>
                            <td><input class="formularioProc2" placeholder="NOMBRES COMPLETOS" id="Text30" type="text" runat="server"/><br /></td>
                            <td><input class="formularioProc2" placeholder="PARENTESCO" id="Text31" type="text" runat="server"/><br /></td>
                            <td><input class="formularioProc2" placeholder="PORCENTAJE" id="Text32" type="number" runat="server"/><br /></td>                            
                        </tr>
                        <tr>
                            <td><input class="formularioProc2" placeholder="NOMBRES COMPLETOS" id="Text33" type="text" runat="server"/><br /></td>
                            <td><input class="formularioProc2" placeholder="PARENTESCO" id="Text34" type="text" runat="server"/><br /></td>
                            <td><input class="formularioProc2" placeholder="PORCENTAJE" id="Text35" type="number" runat="server"/><br /></td>                            
                        </tr>
                         <tr>
                            <td><input class="formularioProc2" placeholder="NOMBRES COMPLETOS" id="Text36" type="text" runat="server"/><br /></td>
                            <td><input class="formularioProc2" placeholder="PARENTESCO" id="Text37" type="text" runat="server"/><br /></td>
                            <td><input class="formularioProc2" placeholder="PORCENTAJE" id="Text38" type="number" runat="server"/><br /></td>                            
                        </tr>
                        <tr>
                            <td><input class="formularioProc2" placeholder="NOMBRES COMPLETOS" id="Text39" type="text" runat="server"/><br /></td>
                            <td><input class="formularioProc2" placeholder="PARENTESCO" id="Text40" type="text" runat="server"/><br /></td>
                            <td><input class="formularioProc2" placeholder="PORCENTAJE" id="Text41" type="number" runat="server"/><br /></td>                            
                        </tr>
                        <tr>
                            <td><input class="formularioProc2" placeholder="NOMBRES COMPLETOS" id="Text42" type="text" runat="server"/><br /></td>
                            <td><input class="formularioProc2" placeholder="PARENTESCO" id="Text43" type="text" runat="server"/><br /></td>
                            <td><input class="formularioProc2" placeholder="PORCENTAJE" id="Text44" type="number" runat="server"/><br /></td>                            
                        </tr>
                    </table>
                    <hr />
                                            
                    <CENTER><asp:Button runat="server" CssClass="botonsubmitTRES" text="CANCELAR" OnClick="Unnamed_Click1"></asp:Button>  
                    <asp:Button  value="REGISTRARME" type="submit" runat="server" CssClass="botonsubmitTRES" Text="VOLVER" OnClick="Unnamed_Click"/>                                                  
                        <asp:Button  value="REGISTRARME" type="submit" runat="server" CssClass="botonsubmitTRES" Text="SIGUIENTE" OnClick="Unnamed1_Click"/>                                                  
                    </CENTER>
                </div>
            </div>
        </div>
        </div>
    
</asp:Content>
