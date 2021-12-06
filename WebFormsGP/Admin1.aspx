<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Admin1.aspx.cs" Inherits="WebFormsGP.Admin1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Administrador</title>
    <link href="css/styleRecetario.css" rel="stylesheet" />
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
        <div class="container">
            <div class="row" style="margin: 60px 0px 0px 0px;">
                <div class="col-lg-12 col-sm-12 col-xs-12">
                    <section class="form-login">
                        <center>
      	                    <h5>Recuperar Mensaje</h5>
                            <!--imagen de resetario -->
                            <img src="images/logo-img.png" width="100" height="100"/>
                            <br/>
                            <asp:TextBox ID="txtUsr" runat="server" class="controls" name="usuario" placeholder="Usuario a buscar"></asp:TextBox>
                            <br/>
                            <asp:Button ID="btnRecuperar" runat="server" Text="Recuperar Mensaje" class="buttons" OnClick="btnRecuperar_Click"></asp:Button>
                            <br/>
                            <asp:TextBox ID="txtMensaje" runat="server" class="controls" type="text" name="mensaje" placeholder="Mensaje Encriptado"></asp:TextBox>
                            <br />
                            <asp:Button ID="btnDescomprimir" runat="server" Text="Descomprimir Mensaje" class="buttons" OnClick="btnDescomprimir_Click"></asp:Button>
                            <br />
                            <asp:TextBox ID="txtMensjDesen" runat="server" class="controls" type="text" name="mensajeDesen" placeholder="Mensaje Desencriptado"></asp:TextBox>
                        </center>
                    </section>
                </div>
                <div class="col-lg-12 col-sm-12 col-xs-12">
                    <section class="form-login">
                        <center>
      	                    <h5>Insertar Marca</h5>
                            <!--imagen de resetario -->
                            <img src="images/logo-img.png" width="100" height="100"/>
                            <br/>
                            <asp:TextBox ID="txtNombre" runat="server" class="controls" name="nombre" placeholder="Nombre de la marca"></asp:TextBox>
                            <br/>
                            <asp:TextBox ID="txtDescripcion" runat="server" class="controls" type="text" name="descripcion" placeholder="Llave"></asp:TextBox>
                            <br />
                            <asp:Button ID="btnInsertarMarca" runat="server" Text="Insertar Marca" class="buttons" OnClick="btnInsertarMarca_Click"></asp:Button>
                        </center>
                    </section>
                </div>
                <div class="col-lg-12 col-sm-12 col-xs-12">
                    <section class="form-login" style="margin-bottom: 50px; height: 550px;">
                        <center>
      	                    <h5>Desencriptar Descripcion de la Marca</h5>
                            <!--imagen de resetario -->
                            <img src="images/logo-img.png" width="100" height="100"/>
                            <br/>
                            <asp:TextBox ID="txtMarca" runat="server" class="controls" name="marca" placeholder="Nombre de la marca a recuperar"></asp:TextBox>
                            <br/>
                            <asp:Button ID="btnBuscarMarca" runat="server" Text="Buscar Marca" class="buttons" OnClick="btnBuscarMarca_Click"></asp:Button>
                            <br />
                            <asp:TextBox ID="txtDescripcionMarca" runat="server" class="controls" type="text" name="descripcion" placeholder=" "></asp:TextBox>
                            <br />
                            <asp:TextBox ID="TextBox1" runat="server" class="controls" type="password" name="descripcion" placeholder="Llave de descriptacion "></asp:TextBox>
                            <br />
                            <asp:Button ID="btnDescomDescrip" runat="server" Text="Descomprimir" class="buttons" OnClick="btnDescomDescrip_Click"></asp:Button>
                            <br />
                            <asp:TextBox ID="txtDescomprimirText" runat="server" class="controls" type="text" name="descripcion2" placeholder="Descripcion de la marca Desencriptada"></asp:TextBox>
                        </center>
                    </section>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
