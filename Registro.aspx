<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registro.aspx.cs" Inherits="ReachSystem.Registro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
        <meta name="Oscar Perez Lugo" content="Developer"/>
        <meta name="description"  content="Tarrago Brands"/>
        <meta name="keywords"  content="QUIMICOS"/>
        <meta name="viewport" content="width=device-width, initial-scale=1.0"/>        
        <title>Tarrago Reach System</title>
        <link rel="stylesheet" href="Content/picocss.css"/>
        <link rel="stylesheet" href="Content/login.css" />
        <link href="favicon.ico" rel="shortcut icon" type="image/x-icon" />
    <script src="https://www.google.com/recaptcha/api.js" async defer></script>
</head>
<body>
    <nav class="container-fluid">
        <ul>
          <li>
            <img src="https://i.ibb.co/v306sQ3/Refrescamiento-de-logo-D-L-Mesa-de-trabajo-1-copia-2-Copy-prisma.png" class="mr-3 h-6 sm:h-10" style="width: 60px;" />
          </li>
        </ul>                       
    </nav>

    <main class="container">
        <article class="grid">
            <div>
                <h1>Registrarse</h1>

                <form id="form1" runat="server">
                    <input placeholder="Nombre (John)" id="Nombre" type="text" required runat="server"/>
                    <input placeholder="Usuario (Pierce)" id="Text2" type="text" required runat="server"/>
                    <input placeholder="Compañia (Tarrago Brands)" id="Apellido" type="text" required runat="server"/>
                    <input placeholder="Correo (john@gmail.com)" id="Correo" type="email" required runat="server"/>
                    <asp:DropDownList ID="DropDownList2" runat="server" Cs required>
                        <asp:ListItem>COUNTRY</asp:ListItem>
                        <asp:ListItem>AUSTRIA</asp:ListItem>
                        <asp:ListItem>BELGIUM</asp:ListItem>
                        <asp:ListItem>BULGARIA</asp:ListItem>
                        <asp:ListItem>CROATIA</asp:ListItem>
                        <asp:ListItem>CYPRUS</asp:ListItem>
                        <asp:ListItem>CZECH REPUBLIC</asp:ListItem>
                        <asp:ListItem>DENMARK</asp:ListItem>
                        <asp:ListItem>ESTONIA</asp:ListItem>
                        <asp:ListItem>FINLAND</asp:ListItem>
                        <asp:ListItem>FRANCE</asp:ListItem>
                        <asp:ListItem>GERMANY</asp:ListItem>
                        <asp:ListItem>GREECE</asp:ListItem>
                        <asp:ListItem>HUNGARY</asp:ListItem>
                        <asp:ListItem>IRELAND</asp:ListItem>
                        <asp:ListItem>ITALY</asp:ListItem>
                        <asp:ListItem>LATVIA</asp:ListItem>
                        <asp:ListItem>LITHUANIA</asp:ListItem>
                        <asp:ListItem>LUXEMBOURG</asp:ListItem>
                        <asp:ListItem>MALT</asp:ListItem>
                        <asp:ListItem>NETHERLANDS</asp:ListItem>
                        <asp:ListItem>POLAND</asp:ListItem>
                        <asp:ListItem>PORTUGAL</asp:ListItem>
                        <asp:ListItem>ROMANIA</asp:ListItem>
                        <asp:ListItem>SLOVAK REPUBLIC</asp:ListItem>
                        <asp:ListItem>SLOVENIA</asp:ListItem>
                        <asp:ListItem>SPAIN</asp:ListItem>
                        <asp:ListItem>SWEDEN</asp:ListItem>
                    </asp:DropDownList>

                    <input placeholder="Contraseña" id="Contraseña" type="password" required runat="server"/>

                    <input placeholder="Repite la Contraseña" id="Repetir" type="password" required runat="server"/>

                    <!--<div class="g-recaptcha" data-sitekey="6LefeNwZAAAAAMIRMWRYV7Ir7gJbOQ1ZyaHpJc47"></div> -->

                    <p>
                        <input type="checkbox" required /> I agree to the <a class="enlaces" href="https://www.tarrago.com/privacy-policy/">Terms of Service & Privacy Policy</a>
                    </p>
                    <p>
                        Do you already have an account? <a class="enlaces" href="Login.aspx">Login from Here</a>
                    </p>

                    <asp:Button class="botonsubmit" value="REGISTRARME" type="submit"  runat="server" CssClass="botonsubmit"  OnClick="Unnamed1_Click"  Text="Sign up"/>       
                </form>
            </div>
            <div></div>
        </article>
    </main>

    
</body>
</html>
