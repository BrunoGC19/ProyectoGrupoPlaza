<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registro.aspx.cs" Inherits="WebFormsGP.Registro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Registro</title>
    <link href="css/styleRegistro.css" rel="stylesheet" />
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
      	<h5>Registro</h5>
      <!--imagen de Registro -->
      <img src="images/logo-img.png" width="100" height="100"/>
      <br/>
      <asp:TextBox ID="txtUsr" runat="server" class="controls" name="usuario" placeholder="Usuario"></asp:TextBox>
      <br />
      <asp:TextBox ID="txtPaswr" runat="server" class="controls" type="text" name="contrasena" placeholder="Contraseña en letras"></asp:TextBox>
      <br/>
      <asp:Label ID="lblPuesto" runat="server" Text="Puesto:"></asp:Label>
      <asp:DropDownList ID="ddlPuesto" runat="server" class="drop"  Height="44px" Width="192px"></asp:DropDownList>
      <br />
      <br />
      <asp:Label ID="lblMarca" runat="server" Text="Marca:"></asp:Label>
      <asp:DropDownList ID="ddlMarca" runat="server" class="drop"  Height="44px" Width="192px"></asp:DropDownList>
      <br />
      <br />
      <asp:TextBox ID="txtClave" runat="server" class="controls" type="password" name="clave" placeholder="Clave Numerica De Incriptacion"></asp:TextBox>
      <br />
      <asp:Button ID="btnRegistro" runat="server" Text="Registro" class="buttons" OnClick="btnRegistro_Click"></asp:Button>
      <br />
      <a href="IndexRecetario.aspx" style="color:black;">¿Quieres loguearte?</a>
</center>
    </section>
    </form>
</body>
</html>
