<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RecuperarContra.aspx.cs" Inherits="WebFormsGP.RecuperarContra" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Recuperar Contraseña</title>
    <link href="css/styleRecuperar.css" rel="stylesheet" />
    <style>
        body {
            font-family: arial;
            background: url("images/FondoAzul.jpg");
            background-size: cover;
            /* background-image: url('fondo login.png');*/
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <section class="form-login">
            <center>
      	<h5>Recuperar Contraseña</h5>
      <!--imagen de resetario -->
      <img src="images/logo-img.png" width="100" height="100"/>
      <br/>
      <asp:TextBox ID="txtUsr" runat="server" class="controls" name="usuario" placeholder="Usuario"></asp:TextBox>
      <br/>
      <asp:Button ID="btnBuscar" runat="server" Text="Buscar Contraseña" class="buttons" OnClick="btnBuscar_Click"></asp:Button>
      <br />
      <br />
      <asp:TextBox ID="txtPaswr" runat="server" class="controls" type="text" name="contrasena" placeholder="Contraseña Recuperada"></asp:TextBox>
      <br/>
      <asp:TextBox ID="txtClave" runat="server" class="controls" type="password" name="clave" placeholder="Clave Numerica De Desincriptar"></asp:TextBox>
      <br />
      <asp:TextBox ID="txtCorreo" runat="server" class="controls" type="text" name="correo" placeholder="Correo Electronico"></asp:TextBox>
      <br />
      <asp:Button ID="btnDescomprimir" runat="server" Text="Enviar Contraseña" class="buttons" OnClick="btnDescomprimir_Click"></asp:Button>
      <br />
      <a href="IndexRecetario.aspx" style="color:black;">¿Quieres loguearte?</a>
          </center>
        </section>
    </form>
</body>
</html>
