<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Avisos2.aspx.cs" Inherits="WebFormsGP.Avisos2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Avisos</title>
    <meta name="viewport" content="width=device-width, user-scalable=no, initial-scale=1.0, maximum-scale=1.0, minimum-scale=1.0" />
    <link href="bootstrap-4.5.0-dist/css/bootstrap.min.css" rel="stylesheet" />
    <link rel="stylesheet" href="css/styleRecetario2.css" />
</head>
<body>
<form id="form1" runat="server">
        <header>
            <div class="container">
                <div>
                    <h1 id="tit1">TERMINOS DE USO DE SOFTWARE</h1>
                </div>
                <div id="imagenFondoDes">
                    <img src="images/recetarios3.png" width="60px"/>
                </div>
                <div id="imagenFondoIz" width="60px">
                    <img src="images/logo-img.png" width="60px"/>&nbsp;</div>
            </div>
        </header>
        <div class="container">
            <div class="row" style="margin:60px 0px 0px 0px;">
                <div class="col-lg-12 col-sm-12 col-xs-12">
                    <p id="parra">
                        Es requisito que lea y acepte los siguientes<b>Términos de Uso de Software</b> que a continuación se redactan. El uso de nuestros servicios
                        así como la compra de nuestros productos implicará que usted ha leído y aceptado los <b>Términos y Condiciones</b> de Uso en el
                        presente documento. Todas los productos  que son ofrecidos por nuestro sitio web pudieran ser creadas, cobradas, enviadas o 
                        presentadas por una página web tercera y en tal caso estarían sujetas a sus propios Términos y Condiciones. En algunos casos,
                        será necesario el registro por parte del usuario, con ingreso de datos personales fidedignos y definición de una contraseña.

                        El usuario puede elegir y cambiar la clave para su acceso de administración de la cuenta en cualquier momento. 
                        <b>GRUPO PLAZA</b>   no asume la responsabilidad en caso de que entregue dicha clave a terceros.
                        <br />
                        <br />
                        <b>USO NO AUTORIZADO:</b>
                        <br />
                        <br />
                        En caso de que aplique (para venta de software, templetes, u otro producto de diseño y programación) usted no puede colocar
                        uno de nuestros productos, modificado o sin modificar, en un CD, sitio web o ningún otro medio y ofrecerlos para la redistribución
                        o la reventa de ningún tipo.
                        <br />
                        <br />
                        <b>PROPIEDAD:</b> 
                        <br />
                        <br />
                        Usted no puede declarar propiedad intelectual o exclusiva a ninguno de nuestros productos, modificado o sin modificar. 
                        Todos los productos son propiedad  de los proveedores del contenido. En caso de que no se especifique lo contrario, nuestros
                        productos se proporcionan  sin ningún tipo de garantía, expresa o implícita. En ningún esta compañía será  responsables de ningún
                        daño incluyendo, pero no limitado a, daños directos, indirectos, especiales, fortuitos o consecuentes u otras pérdidas resultantes
                        del uso o de la imposibilidad de utilizar nuestros productos.
                        <br />
                        <br />
                        <b>PRIVACIDAD:</b>
                        <br />
                        <br />
                        Este documento garantiza que la información personal que usted envía cuenta con la seguridad necesaria. 
                        La suscripción a boletines de correos electrónicos publicitarios es voluntaria y podría ser seleccionada al momento de crear su cuenta.
                       <b>GRUPO PLAZA</b>  reserva los derechos de cambiar o de modificar estos términos sin previo aviso.

                    </p>
                </div>
                <div id="Checar" class="col-lg-12 col-sm-12 col-xs-12">
                    <asp:CheckBox ID="CheckBox1" runat="server" Text="Acepto los Terminos De Uso Del Software" />
                </div>
                <div id="btnPasar" class="col-lg-12 col-sm-12 col-xs-12">
                    <asp:Button ID="btnContinuar" runat="server" Text="Continuar" OnClick="btnContinuar_Click" />
                </div>
            </div>
        </div>
        <footer>

        </footer>        
    </form>
</body>
</html>
