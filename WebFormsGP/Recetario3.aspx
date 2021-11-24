<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Recetario3.aspx.cs" Inherits="WebFormsGP.Recetario3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Recetarios</title>
    <meta name="viewport" content="width=device-width, user-scalable=no, initial-scale=1.0, maximum-scale=1.0, minimum-scale=1.0" />
    <link href="bootstrap-4.5.0-dist/css/bootstrap.min.css" rel="stylesheet" />
    <link rel="stylesheet" href="css/styleRecetario2.css" />
</head>
<body>
   <form id="form1" runat="server">
        <header>
            <div class="container">
                <div>
                    <h1>GRUPO PLAZA</h1>
                </div>
                <div id="imagenFondoDes">
                    <img src="images/recetarios3.png" width="60px" />
                </div>
                <div id="imagenFondoIz">
                    <img src="images/logo-img.png" width="60px" />
                </div>
            </div>
        </header>
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <div id="h2">
            <h2>GUIA DE RECETAS</h2>
        </div>
        <div class="container">
            <div class="row" style="margin: 20px 0px 0px 0px;">
                <div class="col-lg-6 col-sm-12 col-xs-12" style="margin-left: 0px;">
                    <asp:Label ID="lblIn" runat="server" Text="Ingredientes"></asp:Label>
                    <br />
                    <br />
                    <asp:ListBox ID="listIn" runat="server" Height="231px" Width="276px"></asp:ListBox>
                </div>
                <div class="col-lg-6 col-sm-12 col-xs-12" style="margin: 5px 0px 0px 0px;">
                    <asp:Label ID="lblNom" runat="server" Text="Nombre del producto"></asp:Label>
                    <br />
                    <br />
                    <asp:ListBox ID="listNom" runat="server" Height="283px" Width="454px" style="margin-bottom:10px;"></asp:ListBox>
                </div>
           </div>
        </div>
    </form>
</body>
</html>
