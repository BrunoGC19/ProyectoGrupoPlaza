<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Recetario.aspx.cs" Inherits="WebFormsGP.Recetario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Recetarios</title>
    <meta name="viewport" content="width=device-width, user-scalable=no, initial-scale=1.0, maximum-scale=1.0, minimum-scale=1.0" />
    <link href="bootstrap-4.5.0-dist/css/bootstrap.min.css" rel="stylesheet" />
    <link rel="stylesheet" href="css/styleReceta.css" />
    <!-- Latest compiled and minified CSS -->
    <%--<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" integrity="sha384-BVYiiSIFeK1dGmJRAkycuHAHRg32OmUcww7on3RYdg4Va+PmSTsz/K68vbdEjh4u" crossorigin="anonymous">--%>
</head>
<body>
    <form id="form1" runat="server">
        <header>
            <div class="container">
                <div>
                    <h1 id="tit1">GRUPO PLAZA</h1>
                </div>
                <div id="imagenFondoDes">
                    <img src="images/recetarios3.png" width="60px" />
                </div>
                <div id="imagenFondoIz">
                    <img src="images/logo-img.png" width="60px" />
                </div>
            </div>
        </header>
        <div class="container">
            <div class="row" style="margin: 60px 0px 0px 0px;">
                <div class="col-lg-3 col-sm-6 col-xs-12">
                    <div class="row" style="margin-left: 0px;">
                        <asp:Button ID="btnAlimentos" runat="server" Text="Alimentos" OnClick="btnAlimentos_Click" />
                    </div>
                    <div class="row" style="margin: 20px 0px 0px 0px;">
                        <asp:Button ID="btnBebidas" runat="server" Text="Bebidas" OnClick="btnBebidas_Click" />
                    </div>
                </div>
                <div class="col-lg-3 col-sm-6 col-xs-12" style="margin: 5px 0px 0px 0px">
                    <asp:ListBox ID="ListBox1" runat="server" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged" AutoPostBack="True" BackColor="Gray" Height="130px" Width="131px" Visible="True"></asp:ListBox>
                </div>
                <div class="col-lg-3 col-sm-6 col-xs-12" style="margin: 5px 0px 0px 0px">
                    <asp:ListBox ID="ListBox2" runat="server" BackColor="Gray" Height="127px" Width="126px" Visible="True" AutoPostBack="True" OnSelectedIndexChanged="ListBox2_SelectedIndexChanged"></asp:ListBox>
                </div>
                <div class="col-lg-3 col-sm-6 col-xs-12" style="margin: 5px 0px 0px 0px">
                    <img id="imgAside" src="images/logo-img.png" />
                </div>
            </div>
        </div>
        <footer>

        </footer>   
        <!-- Latest compiled and minified JavaScript -->
        <%--<script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js" integrity="sha384-Tc5IQib027qvyjSMfHjOMaLkfuWVxZxUPnCJA7l2mCWNIpG9mGCD8wGNIcPD7Txa" crossorigin="anonymous"></script>--%>
        <script src="js/JavaScript2.js"></script>
        <script src="bootstrap-4.5.0-dist/js/bootstrap.min.js"></script>
    </form>
</body>
</html>


        
