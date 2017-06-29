<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmCliente.aspx.cs" Inherits="SmartPropertySIW.Formularios.frmCliente" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Cliente</title>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" />
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
    <link href="../Styles/Styles.css" rel="stylesheet" />
    </head>
<body>
    <form id="form1" runat="server">
         <nav class="navbar navbar-inverse">
            <div class="container-fluid">
                <div class="navbar-header">
                    <button type="button" class="navbar-toggle" data-toggle="collapse" data-target="#myNavbar">
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                    </button>
                    <a class="navbar-brand" href="frmCliente.aspx">SMART PROPERTY</a>
                </div>
                <div class="collapse navbar-collapse" id="myNavbar">
                    <ul class="nav navbar-nav">
                        <li class="active"><a href="frmCliente.aspx"><span class="glyphicon glyphicon-home"></span>&nbsp Inicio</a></li>
                        <li class="dropdown">
                            <a href="#" class="dropdown dropdown-toggle" data-toggle="dropdown">Registrar<b class="caret"></b></a>
                            <ul class="dropdown-menu">                                
                                <li><a href="frmCliente_RegistroInmuebles.aspx">Registrar Inmuebles</a></li>
                            </ul>
                        </li>
                        <li class="dropdown">
                            <a href="#" class="dropdown dropdown-toggle" data-toggle="dropdown">Modificar Mis Datos<b class="caret"></b></a>
                            <ul class="dropdown-menu">
                                <li><a href="frmCliente_ModificarUsuarios.aspx">Mi Perfil</a></li>
                                <li class="divider"></li>
                                <li><a href="frmCliente_ModificarInmuebles.aspx">Mis Inmuebles</a></li>
                            </ul>
                        </li>                        
                    </ul>
                    <ul class="nav navbar-nav navbar-right">
                        <li data-toggle="modal" data-target="#myModal"><a href="frmindex.aspx"><span class="glyphicon glyphicon-off"></span>&nbsp Cerrar Sesión</a></li>
                    </ul>
                </div>
            </div>
        </nav>
        <div class="container-fluid text-left">
            <div class="row content">
                <div class="col-sm-1 sidenav">
                </div>
                <div class="col-lg-10 text-left">
                    <h1>Bienvenido a Smart Property</h1>
                    <div id="myCarousel" class="carousel slide" data-ride="carousel" style="width: 100%;">
                        <!-- Indicadores -->

                        <ol class="carousel-indicators">
                            <li data-target="#myCarousel" data-slide-to="0" class="active"></li>
                            <li data-target="#myCarousel" data-slide-to="1"></li>
                            <li data-target="#myCarousel" data-slide-to="2"></li>
                        </ol>

                        <!-- Imagenes -->
                        <div class="carousel-inner">
                            <div class="item active">

                                <img src="../Imagenes/casa-moderna-de-dos-pisos.jpg" alt="Los Angeles" style="width: 100%;" />
                            </div>

                            <div class="item">
                                <img src="../Imagenes/casadeplaya.jpg" alt="Chicago" style="width: 100%;" />
                            </div>

                            <div class="item">
                                <img src="../Imagenes/CasaKimballUltra HD.jpg" alt="New york" style="width: 100%;" />
                            </div>
                        </div>

                        <!-- Controles Izquierda & Derecha -->
                        <a class="left carousel-control" href="#myCarousel" data-slide="prev">
                            <span class="glyphicon glyphicon-chevron-left"></span>
                            <span class="sr-only">Previous</span>
                        </a>
                        <a class="right carousel-control" href="#myCarousel" data-slide="next">
                            <span class="glyphicon glyphicon-chevron-right"></span>
                            <span class="sr-only">Next</span>
                        </a>
                    </div>
                    <hr />
                </div>
            </div>
        </div>
        <div id="divisor" class="panel-footer" style="background-color: #202020;"></div>
        <div id="contact" class="container-fluid bg-grey">
            <h2 class="text-center">CONTACTENOS</h2>
            <div class="row">
                <div class="col-sm-5">
                    <p><span class="glyphicon glyphicon-earphone"></span>&nbsp Puede ponerse en contacto las 24 horas.</p>
                    <p><span class="glyphicon glyphicon-map-marker"></span>&nbsp Cr 12D Bis # 24 - 91 sur  Barrio San Jose, Bogotá DC, Colombia.</p>
                    <p><span class="glyphicon glyphicon-phone"></span>&nbsp +57 3132440181 - +57 32227579915.</p>
                    <p><span class="glyphicon glyphicon-envelope"></span>&nbsp smartpropertysiw@gmail.com</p>
                </div>
                <div class="col-sm-7">
                    <div class="row">
                        <div class="col-sm-6 form-group">
                            <input class="form-control" id="name" name="name" placeholder="Nombre" type="text" />
                        </div>
                        <div class="col-sm-6 form-group">
                            <input class="form-control" id="email" name="email" placeholder="Correo" type="email" />
                        </div>

                    </div>
                    <textarea class="form-control" id="comments" name="comments" placeholder="Comentarios" rows="5"></textarea><br />
                    <div class="row">
                        <div class="col-sm-12 form-group">
                            <button class="btn btn-default pull-right" type="submit">Enviar</button>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <!--Google Maps-->
        <!--To use this code on your website, get a free API key from Google.Read more at: https://www.w3schools.com/graphics/google_maps_basic.asp -->
        <div id="googleMap" style="width: 100%; height: 400px;"></div>
        <footer>
        </footer>
        <script>
            function myMap() {
                var myCenter = new google.maps.LatLng(4.5766792, -74.1023181);
                var mapProp = {
                    center: new google.maps.LatLng(4.5766428, -74.1028474, 19),
                    zoom: 17, scrollwheel: false, draggable: false, mapTypeId: google.maps.MapTypeId.ROADMAP
                };
                var map = new google.maps.Map(document.getElementById("googleMap"), mapProp);
                var marker = new google.maps.Marker({ position: myCenter });
                marker.setMap(map);
            }
        </script>
        <script src="https://maps.googleapis.com/maps/api/js?key=AIzaSyC74e1pcP1AJgR5ibeLI_nL3g8yO7x5gqg&callback=myMap"></script>
        <br />
        <div id="foter" class="panel-footer" style="background-color: #202020; font-family: Verdana, Geneva, Tahoma, sans-serif; text-align: center; color: white">
            <section class="row">
                <p>Copyright © 2017 - <strong>SMART PROPERTY SIW</strong> - Todos los Derechos Reservados </p>
            </section>
        </div>
        <footer class="container-fluid text-center">
            <a href="#myPage" title="To Top">
                <span class="glyphicon glyphicon-chevron-up"></span>
            </a>
            <p>Smart Property <a href="https://www.SmartPropertySIW.com" title="Visit w3schools">www.SmartPropertySIW.com</a></p>
        </footer>
    </form>
</body>
</html>
