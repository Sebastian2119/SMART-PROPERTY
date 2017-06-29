<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InmueblesVenta.aspx.cs" Inherits="SmartPropertySIW.Inmuebles" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Inmuebles Venta</title>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" />
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
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
                    <a class="navbar-brand" href="#">SMART PROPERTY</a>
                </div>
                <div class="collapse navbar-collapse" id="myNavbar">
                    <ul class="nav navbar-nav">
                        <li class="active"><a href="PaginaPrincipal.aspx"><span class="glyphicon glyphicon-home"></span>&nbsp Inicio</a></li>
                        <li class="dropdown">
                            <a href="#" class="dropdown dropdown-toggle" data-toggle="dropdown">Inmuebles<b class="caret"></b></a>
                            <ul class="dropdown-menu">
                                <li><a href="#">Inmuebles En Venta</a></li>
                                <li class="divider"></li>
                                <li><a href="#">Inmuebles En Arriendo</a></li>
                                <li class="divider"></li>
                                <li><a href="#">Alquiler De Inmuebles</a></li>
                            </ul>
                        </li>
                        <li><a href="#">Quienes Somos</a></li>
                        <li class="dropdown">
                            <a href="#" class="dropdown dropdown-toggle" data-toggle="dropdown">Servicio Al Cliente<b class="caret"></b></a>
                            <ul class="dropdown-menu">
                                <li><a href="#contact">Contatenos</a></li>
                                <li class="divider"></li>
                                <li><a href="#comments">Dejanos Tus Comentarios</a></li>
                            </ul>
                        </li>
                    </ul>
                    <ul class="nav navbar-nav navbar-right">
                        <li data-toggle="modal" data-target="#myModal"><a href="#"><span class="glyphicon glyphicon-log-in"></span>&nbsp Iniciar Sesión</a></li>
                        <div class="modal fade" id="myModal" role="dialog">
                            <div class="modal-dialog">
                                <!-- Modal content-->
                                <div class="modal-content">
                                    <div class="modal-header">
                                        <button type="button" class="close" data-dismiss="modal">&times;</button>
                                        <h4 class="modal-title">Iniciar Sesión</h4>
                                    </div>
                                    <div class="modal-body">
                                        <form action="/action_page.php">
                                            <div class="form-group">
                                                <label for="email">Usuario:</label>
                                                <input type="email" class="form-control" id="email" placeholder="Ingresar Correo" name="email" />
                                            </div>
                                            <div class="form-group">
                                                <label for="pwd">Contraseña:</label>
                                                <input type="password" class="form-control" id="pwd" placeholder="Ingresar Conraseña" name="pwd" />
                                            </div>
                                            <div class="checkbox">
                                                <label>
                                                    <input type="checkbox" name="remember" />Recuérdame</label>
                                            </div>
                                            <button type="submit" class="btn btn-default">Iniciar Sesión</button>
                                        </form>
                                    </div>
                                    <div class="modal-footer">
                                        <button type="button" class="btn btn-default" data-dismiss="modal">Cerrar Ventana</button>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </ul>
                </div>
            </div>
        </nav>

        <!-- Codigo de las imagenes en cada cuadro   -->
        <div class="container">
            <div class="row">
                <div class="col-sm-4">
                    <div class="panel panel-danger">
                        <!-- Imagen 1   -->
                        <div class="panel-heading"></div>
                        <div class="panel-body">
                            <img src="ImagenesVentas/apartahotel-617-apartamento-GL-01.jpg" class="img-responsive" style="width: 100%" alt="Image"></div>

                    </div>
                </div>
                <!-- Imagen 2   -->
                <div class="col-sm-4">
                    <div class="panel panel-primary">
                        <div class="panel-heading"></div>
                        <div class="panel-body">
                            <img src="ImagenesVentas/xstandar2.jpg.pagespeed.02.jpg" class="img-responsive" style="width: 100%" alt="Image"></div>

                    </div>
                </div>
                <!-- Imagen 3   -->
                <div class="col-sm-4">
                    <div class="panel panel-success">
                        <div class="panel-heading"></div>
                        <div class="panel-body">
                            <img src="ImagenesVentas/Apartamentos-Vida-Corcubión-03.jpg" class="img-responsive" style="width: 100%" alt="Image"></div>
                    </div>
                </div>
            </div>
        </div>
        <br />
        <div class="container">
            <div class="row">
                <!-- Imagen 4   -->
                <div class="col-sm-4">
                    <div class="panel panel-success">
                        <div class="panel-heading"></div>
                        <div class="panel-body">
                            <img src="ImagenesVentas/Modernos-Apartamentos-de-lujo-en-Ventas-en-Piantini-en-calle-tra_04.jpg" class="img-responsive" style="width: 100%" alt="Image"></div>

                    </div>
                </div>
                <!-- Imagen 5   -->
                <div class="col-sm-4">
                    <div class="panel panel-danger">
                        <div class="panel-heading"></div>
                        <div class="panel-body">
                            <img src="ImagenesVentas/EST_AptosMedellin_habitacion_05.jpg" class="img-responsive" style="width: 100%" alt="Image"></div>

                    </div>
                </div>
                <!-- Imagen 6   -->
                <div class="col-sm-4">
                    <div class="panel panel-primary">
                        <div class="panel-heading"></div>
                        <div class="panel-body">
                            <img src="ImagenesVentas/modern-apartment-interior-design-06.jpg" class="img-responsive" style="width: 100%" alt="Image"></div>

                    </div>
                </div>
            </div>
        </div>
        <br />
        <div class="container">
            <div class="row">
                <div class="col-sm-4">
                    <div class="panel panel-danger">
                        <!-- Imagen 7  -->
                        <div class="panel-heading"></div>
                        <div class="panel-body">
                            <img src="ImagenesVentas/apartahotel-617-apartamento-GL-01.jpg" class="img-responsive" style="width: 100%" alt="Image"></div>

                    </div>
                </div>
                <!-- Imagen 8   -->
                <div class="col-sm-4">
                    <div class="panel panel-primary">
                        <div class="panel-heading"></div>
                        <div class="panel-body">
                            <img src="ImagenesVentas/xstandar2.jpg.pagespeed.02.jpg" class="img-responsive" style="width: 100%" alt="Image"></div>

                    </div>
                </div>
                <!-- Imagen 9   -->
                <div class="col-sm-4">
                    <div class="panel panel-success">
                        <div class="panel-heading"></div>
                        <div class="panel-body">
                            <img src="ImagenesVentas/Apartamentos-Vida-Corcubión-03.jpg" class="img-responsive" style="width: 100%" alt="Image"></div>
                    </div>
                </div>
            </div>
        </div>
        <br />
        <!-- Fin del codigo de las imagenes   -->

        <!-- Contactenos  -->
        <div id="contact" class="container-fluid bg-grey">
                <h2 class="text-center">CONTACTENOS</h2>
                <div class="row">
                    <div class="col-sm-5">
                       <h4> <p><span class="glyphicon glyphicon-earphone"></span>Póngase en contacto con nosotros y nos pondremos en contacto con usted en 24 horas.</p></h4>
                       <h4> <p><span class="glyphicon glyphicon-map-marker"></span>&nbsp Cr 12D Bis # 24 - 91 sur Barrio San Jose,  Bogotá DC, Colombia.</p></h4>
                       <h4> <p><span class="glyphicon glyphicon-phone"></span>&nbsp +57 3132440181 - +57 32227579915.</p></h4>
                       <h4> <p><span class="glyphicon glyphicon-envelope"></span>&nbsp smartpropertysiw@gmail.com</p></h4>
                    </div>
                    <div class="col-sm-7">
                        <div class="row">
                            <div class="col-sm-6 form-group">
                                <input class="form-control" id="name" name="name" placeholder="Nombre" type="text" required />
                            </div>
                            <div class="col-sm-6 form-group">
                                <input class="form-control" id="email" name="email" placeholder="Correo" type="email" required />
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
        <div>
        </div>
    </form>
</body>
</html>
