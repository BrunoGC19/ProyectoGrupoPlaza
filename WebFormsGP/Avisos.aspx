<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Avisos.aspx.cs" Inherits="WebFormsGP.Avisos" %>

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
                    <h1 id="tit1">AVISO DE PRIVACIDAD</h1>
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
                        De conformidad con la <b>LEY FEDERAL DE PROTECCION DE DATOS PERSONALES EN POSESIÓN DE PARTICULARES</b>, 
                        y al <b>capítulo VI del Título V de las Políticas Corporativas Responsables en Protección de Datos</b>, 
                        ponemos a su disposición nuestro <b>AVISO DE PRIVACIDAD WEB</b>, con la finalidad de hacer de su consentimiento 
                        el tratamiento que daremos a sus datos personales, así como los derechos que puede ejercer como titular 
                        de sus datos personales. Le solicitamos leer cuidadosamente, ya que la sola disposición del presente <b>AVISO 
                        DE PRIVACIDAD</b> sin que usted se oponga, otorga su consentimiento tácito para permitirnos tratar sus datos 
                        personales con base a lo establecido en el presente <b>AVISO DE PRIVACIDAD</b>
                        <br />
                        <br />
                        <b>I.- RESPONSABLE DEL USO Y PROTECCION DE SUS DATOS:</b>
                        <br />
                        <br />
                        <b>GRUPO CAFÉ PLAZA con domicilio en: CALLE 23 SUR 3501, BENITO JUÁREZ, 72090 PUEBLA, PUE, en lo sucesivo CAFÉ PLAZA;</b> 
                        y como responsable del tratamiento de sus datos personales, hace de su conocimiento que todos sus datos personales 
                        son tratados de forma estrictamente confidencial por lo que, al proporcionarlos, tales como: 
                        <br />
                        <br />
                        <b>II.- DATOS PERSONALES QUE PODEMOS OBTENER:</b> 
                        <br />
                        <br />
                        Nombre, Correo electrónico, Teléfonos móviles y contraseñas
                        <br />
                        <br />
                        <b>III. FINALIDADES DEL TRATAMIENTO DE SUS DATOS:</b>
                        <br />
                        <br />
                        - Dar cumplimiento a obligaciones contraídas con nuestros clientes, empleados o proveedores.
                        <br />
                        - Llevar a cabo los servicios relacionados con asesoría legal, mandato judicial, litigio, investigación judicial 
                        teórica o práctica. 
                        <br />
                        - Informar sobre cambios en el servicio 
                        <br />
                        - Evaluar la calidad del servicio 
                    </p>
                </div>
                <div id="Checar" class="col-lg-12 col-sm-12 col-xs-12">
                    <asp:CheckBox ID="CheckBox1" runat="server" Text="Acepto el aviso de privacidad" />
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
