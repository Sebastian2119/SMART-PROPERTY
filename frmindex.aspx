<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmindex.aspx.cs" Inherits="SmartPropertySIW.Formularios.frmindex" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Index</title>    
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" />
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
    <link href="../Styles/Styles.css" rel="stylesheet" />
    <link href="../Styles/Styles_icons.css" rel="stylesheet" />
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
                                <li><a href="frmVerInmuebles_Venta.aspx">Inmuebles En Venta</a></li>
                                <li class="divider"></li>
                                <li><a href="frmVerInmuebles_Arriendo.aspx">Inmuebles En Arriendo</a></li>
                                <li class="divider"></li>
                                <li><a href="frmVerInmuebles_Alquiler.aspx">Alquiler De Inmuebles</a></li>
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
                                        <asp:ScriptManager ID="ScriptManager1" runat="server" />
                                        <asp:UpdatePanel runat="server" ID="UpdatePanel" UpdateMode="Conditional">
                                            <Triggers>
                                                <asp:AsyncPostBackTrigger ControlID="btnLogIn" EventName="Click" />
                                            </Triggers>
                                            <ContentTemplate>
                                                <div class="form-group">
                                                    <label for="email">Usuario:</label>
                                                    <asp:TextBox ID="txtUsuario" type="text" class="form-control" placeholder="Ingresar Usuario" name="Usuario" required="required" runat="server"></asp:TextBox>
                                                </div>
                                                <div class="form-group">
                                                    <label for="pwd">Contraseña:</label>
                                                    <asp:TextBox ID="txtContraseña" type="password" class="form-control" placeholder="Ingresar Contraseña" name="pwd" required="required" runat="server"></asp:TextBox>
                                                </div>
                                                <div class="form-group">
                                                    <asp:Label ID="lblMensaje" Style="color: red" runat="server" Text=""></asp:Label>
                                                </div>
                                                <div class="form-group align-left">
                                                    <asp:Button ID="btnLogIn" class="btn btn-success" runat="server" Text="Iniciar Sesión" OnClick="btnLogIn_Click" />
                                                </div>
                                            </ContentTemplate>
                                        </asp:UpdatePanel>
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
        <div class="container-fluid text-left">
            <div class="row content">
                <div class="col-sm-1 sidenav">
                </div>
                <div class="col-sm-10 text-left">
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
                    <div class="col-sm-1 sidenav">
                    </div>
                    <hr />
                </div>
            </div>
        </div>
        <div class="col-sm-2"></div>
        <div class="container-fluid col-lg-8">            
                    <div class="input-group">
                        <div class="col-lg-4">
                            <asp:Label ID="lblTipoOferta" runat="server" Text="Tipo de Oferta"></asp:Label>
                            <asp:DropDownList ID="ddlTipoOferta" class="btn btn-default dropdown-toggle" data-toggle="dropdown" Style="width: 100%" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlTipoOferta_SelectedIndexChanged"></asp:DropDownList>
                        </div>
                        <div class="col-lg-4">
                            <asp:Label ID="lblTipoInmueble" Style="width: 100%" runat="server" Text="Tipo de inmueble"></asp:Label>
                            <asp:DropDownList ID="ddlTipoInmueble" class="btn btn-default dropdown-toggle" data-toggle="dropdown" Style="width: 100%" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlTipoInmueble_SelectedIndexChanged"></asp:DropDownList>
                        </div>
                        <div class="col-lg-4">
                            <asp:Label ID="LblUbicacion" runat="server" Text="Ubicacion"></asp:Label>
                            <asp:DropDownList ID="ddlUbicacion" class="btn btn-default dropdown-toggle" data-toggle="dropdown" Style="width: 100%" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlUbicacion_SelectedIndexChanged"></asp:DropDownList>
                        </div>                       
                    </div>                 
        </div>
        <div class="col-sm-2"></div>
        <hr />
        <br />
        <br />
        <div id="services" class="container-fluid text-center">
            <h2>SERVICIOS</h2>
            <br />
            <div class="row slideanim">
                <div class="col-sm-4">
                    <a href="frmVerInmuebles_Venta.aspx"><span class="glyphicon glyphicon-shopping-cart logo-small"></span></a>
                    <h4>Inmuebles En Venta</h4>
                    <p>Mira Nuestras Ofertas...</p>
                </div>
                <div class="col-sm-4">
                    <a href="frmVerInmuebles_Arriendo.aspx"><span class="glyphicon glyphicon-edit logo-small"></span></a>
                    <h4>Inmuebles En Arriendo</h4>
                    <p>Mira Nuestras Ofertas...</p>
                </div>
                <div class="col-sm-4">
                    <a href="frmVerInmuebles_Alquiler.aspx"><span class="glyphicon glyphicon-tag logo-small"></span></a>
                    <h4>Alquiler De Inmuebles</h4>
                    <p>Mira Nuestras Ofertas...</p>
                </div>
            </div>
        </div>
        <br />
        <hr />
        <div id="contact" class="container-fluid bg-grey">
            <h2 class="text-center">CONTACTENOS</h2>
            <div class="row">
                <div class="col-sm-5">
                    <p><span class="glyphicon glyphicon-earphone"></span>Puede ponerse en contacto las 24 horas.</p>
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
