<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ReachSystem.Login" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
  <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
  <meta name="Oscar Perez Lugo" content="Developer"/>
  <meta name="description"  content="Tarrago Brands"/>
  <meta name="keywords"  content="QUIMICOS"/>
  <meta name="viewport" content="width=device-width, initial-scale=1.0"/>        
  <title>AFFINITY</title>
  <link href="favicon.ico" rel="shortcut icon" type="image/x-icon" />
  <link href="Content/picocss.css" rel="stylesheet" />
  <link href="Content/login.css" rel="stylesheet" />
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
          <form id="form1" runat="server">
            <h1>Inicia Sesión</h1>
            <input type="text" name="login" id="Correo" placeholder="Correo" aria-label="Iniciar Sesión" autocomplete="nickname" required runat="server" />
            <input type="password" id="Contrasena" name="password" placeholder="Contraseña" aria-label="Contraseña" autocomplete="current-password" required runat="server" />
            <fieldset>
              <label>
                No tienes una cuenta? <a href="Registro.aspx">Registrate</a>
              </label>
            </fieldset>
            <asp:Button class="botonsubmit" value="REGISTRARME" type="submit" runat="server" CssClass="botonsubmit" Text="Enviar" OnClick="Unnamed1_Click" /> 
          </form>
        </div>
        <div></div>
      </article>
  </main>
</body>
</html>
