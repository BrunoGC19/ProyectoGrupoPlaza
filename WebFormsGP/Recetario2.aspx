<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Recetario2.aspx.cs" Inherits="WebFormsGP.Recetario2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Recetarios</title>
    <script src=""></script>
    <link rel='stylesheet' href='https://maxcdn.bootstrapcdn.com/bootstrap/3.3.6/css/bootstrap.min.css' />
    <link rel="stylesheet" href="css/styleRecetario2.css" />
    <script src='https://code.jquery.com/jquery-2.2.4.min.js'></script>
    <script src='https://maxcdn.bootstrapcdn.com/bootstrap/3.3.6/js/bootstrap.min.js'></script>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <header>
                <div>
                    <h1>GRUPO PLAZA</h1>
                </div>
                <div id="imagenFondoDes">
                    <img src="images/recetarios3.png" width="60px" />
                </div>
                <div id="imagenFondoIz">
                    <img src="images/logo-img.png" width="60px" />
                </div>
            </header>
            <section>
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
                <div>
                    <h2>GUIA DE RECETAS</h2>
                </div>
            </section>
            <section>
                <div class="container">
                    <div class="row" style="margin: 60px 0px 0px 0px;">
                        <div class="col-lg-12 col-sm-12 col-xs-12" style="margin-left: 0px;">
                            <div id="Producto">
                                <asp:GridView ID="GridView1" runat="server" AllowPaging="True" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" PageSize="3" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                                    <Columns>
                                        <asp:CommandField HeaderText="Eleccion " SelectText="Seleccionar Producto" ShowSelectButton="True" />
                                    </Columns>
                                    <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
                                    <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
                                    <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
                                    <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
                                    <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
                                    <SortedAscendingCellStyle BackColor="#FFF1D4" />
                                    <SortedAscendingHeaderStyle BackColor="#B95C30" />
                                    <SortedDescendingCellStyle BackColor="#F1E5CE" />
                                    <SortedDescendingHeaderStyle BackColor="#93451F" />
                                </asp:GridView>
                            </div>
                        </div>
                    </div>
                </div>
            </section>
        </div>
        <footer>
        </footer>
    </form>
</body>
</html>
