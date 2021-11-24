<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="IndexRecetario.aspx.cs" Inherits="WebFormsGP.IndexRecetario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
    <link href="css/styleRecetario.css" rel="stylesheet" />
    <style>
        body {
              font-family: arial;
              background: url("images/fondo%20login.png");
              background-size: cover;
              /* background-image: url('fondo login.png');*/
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <section class="form-login">
      <center>
      	<h5>Inicia Sesion </h5>
      <!--imagen de resetario -->
      <img src="images/logo-img.png" width="100" height="100"/>
      <br/>
      <asp:TextBox ID="txtUsr" runat="server" class="controls" name="usuario" placeholder="Usuario"></asp:TextBox>
      <br/>
      <asp:TextBox ID="txtPaswr" runat="server" class="controls" type="password" name="contrasena" placeholder="Contraseña"></asp:TextBox>
      <br/>
      <asp:Button ID="btnIniciar" runat="server" Text="Iniciar" class="buttons" OnClick="btnIniciar_Click"></asp:Button>
      <br/>
      <a href="RecuperarContra.aspx" style="color:black;">¿Olvidaste tu contraseña?</a>
</center>
    </section>
    </form>
</body>
</html>
