<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomeRestaurant.aspx.cs" Inherits="WebFormsGP.HomeRestaurant" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Cafe Plaza</title>

    <!-- aos css cdn link  -->
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/aos/2.3.4/aos.css">

    <!-- google fonts cdn link  -->
    <link rel="preconnect" href="https://fonts.gstatic.com">
    <link href="https://fonts.googleapis.com/css2?family=Oswald:wght@200;400;500&family=Roboto:wght@100;300;400;500&display=swap" rel="stylesheet">

    <!-- font awesome cdn link  -->
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.15.2/css/all.min.css">

    <!-- custom css file link  -->
    <link rel="stylesheet" href="css/style.css">
</head>
<body>
    <form id="form1" runat="server">
<!-- header section starts  -->

<header>

    <a href="#" class="logo"><img src="images/logo-img.png" alt=""></a>

    <div id="recetarios-bar" class="fas fa-align-justify"></div>

    <nav class="navbar">
        <ul>
            <li><a class="active" href="#inicio">Inicio</a></li>
            <li><a href="#nosotros">Nosotros</a></li>
            <li><a href="#recetarios">Recetarios</a></li>
            <li><a href="#comentarios">Comentarios</a></li>
            <li><a href="Registro.aspx">Registro</a></li>
            
        </ul>
    </nav>

</header>

<!-- header section ends -->

<!-- inicio section starts  -->

<section class="inicio" id="inicio">

    <div class="content" data-aos="fade-right">
        <h3>MISIÓN</h3>
        
        <p>vivimos el servicio con Responsabilidad Social.</p>
      
      <!-- boton de started-->
       <!--  <a href="#"><button class="btn">get started</button></a>     -->  


        <h3>VISIÓN</h3>
        <p>Restaurando raíces, cultura y tradición.</p>

        <h3>VALORES</h3>
        <p>Humanismo</p>
        <p>Pasión</p>
        <p>Excelencia</p>
        <p>Agilidad</p>
        <p>Innovación</p>

    </div>

    <div class="image" data-aos="fade-up">
        <img src="images/inicio-img.png" alt="">
    </div>

</section>

<!-- inicio section ends -->

<!-- nosotros section starts  -->

<section class="nosotros" id="nosotros">

    <div class="image" data-aos="fade-right"></div>

    <div class="content" data-aos="fade-left">
        <h3>Grupo Plaza</h3>
        <p>Cafe Plaza se remota a 1975, año en el que adquiere la patente de cafe tres gallos, cuyo objetivo era la venta de cafe. Con esta adquisición se emprende la comercializacion de café en taza; establecido
            en 1979 la primera cafetería del grupo centro comercial Plaza Dorada en la Cd. de Puebla, nombrada Café Plaza. </p>
        <p>A partir de esta idea, Grupo Plaza continuó su proceso de desarrollo, pasando de las cafeterías al concepto restaurantero, ofreciendo varios conceptos de negocio de comida internacional como mexicana.El exito
            de Grupo Plaza se debe a la calidad de los alimentos y bebidas que ofrece, la accesibilidad de sus precios, la originialidad de sus establecimientos, y la amabilidad, de nuestros colaboradores..</p>
        <p>Grupo Plaza ha alcanzado como los buenos vinos: madurez y experiencia bajo su filosofía principal, logrando la excelencia en la calidad de sus productos y servicios. Para así
            ser considerado como uno de los líderes en la industria restaurantera poblana, integrando conceptos definidos que satisfacen gran variedad de gustos y preferencias del mercado que se reflejan en 
            nuestras cafeterias y restaurantes.
        </p>
        
    </div>

</section>

<!-- nosotros section ends -->



<!--Section recetarios begin-->

<section class="recetarios" id="recetarios">

<h1 class="heading"> Nuestros  <span>recetarios</span> </h1>

<ul class="list" data-aos="fade-down">

    <li class="btn" data-src="images/recetarios1.png">Mi viejo café</li>
    <li class="btn" data-src="images/recetarios3.png">Mi viejo Pueblito</li>
    <li class="btn" data-src="images/recetarios4.png">Café Plaza</li>
    <li class="btn" data-src="images/recetarios2.jpg" >Café tres gallos</li>


</ul>

<div class="row" data-aos="fade-right">

    <div class="image" data-aos="fade-left">
       
        <img src="images/recetarios3.png"id=recetarios-img" alt="">



    </div>

    <div class="content">
        <div class="info">
            <h3> <span> </span> Accede a nuestros recetarios</h3>
            <asp:Button ID="Button1" runat="server" Text="Iniciar Sesión " class="btn" OnClick="Button1_Click"/>
        </div>
        
        
     

    </div>

</div>

</section>

<!--recetario section end-->


<!-- capacitacion section starts  -->

<h1 class="heading">  <span> Comentarios</span>  </h1>

<section class="form-login" id="comentarios">

<center>
      	<h5>Comentarios </h5>
      <!--imagen de resetario -->
      <img src="images/logo-img.png" width="100" height="100"/>
      <br/>
      <asp:TextBox ID="txtUsuario" runat="server" class="controls" name="usuario" placeholder="Usuario"></asp:TextBox>
      <br/>
      <asp:TextBox ID="txtCorreo" runat="server" class="controls" name="correo" placeholder="Correo Electronico"></asp:TextBox>
      <br />
      <asp:TextBox ID="txtMensaje" runat="server" class="controls" name="mensaje" placeholder="Escribe tu comentario"></asp:TextBox>
      <br />
      <asp:Button ID="btnEnviarMensaje" runat="server" Text="Enviar comentario" class="buttons" OnClick="btnEnviarMensaje_Click"></asp:Button>
</center>

</section>




<div class="footer">

    <div class="box-container">

        <div class="box">
<center>
       <img src="images/recetarios4blanco.png" alt="" width="100" height="100"/>
       <img src="images/recetarios3blanco.png" alt="" width="100" height="100"/>
       <img src="images/inicio-img.png" alt="" width="100" height="100"/>
       <img src="images/recetarios1blanco.png" alt="" width="100" height="100"/>
<!--IMAGEN CAFE 3 GALLOS PROVISIONAL-->
    <img src="images/recetarios2.jpg" alt="" width="100" height="100"/


</center>
            

        </div>

    </div>

    <h1 class="credit">Grupo Plaza <a href="#">Departamento de Sistemas</a>  Soporte Cel:######</h1>

</div>

<!-- footer section ends -->

<!-- aos js cdn link  -->
<script src="https://cdnjs.cloudflare.com/ajax/libs/aos/2.3.4/aos.js"></script>

<!-- jquery cdn link  -->
<script src="https://cdnjs.cloudflare.com/ajax/libs/jquery/3.6.0/jquery.min.js"></script>

<!-- custom js file link  -->
<script src="js/script.js"></script>

<!-- initializing aos  -->

<script>

    AOS.init({
        delay:400,
        duration:1000
    })

</script>
    </form>
</body>
</html>
