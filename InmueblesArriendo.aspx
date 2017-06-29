<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InmueblesArriendo.aspx.cs" Inherits="SmartPropertySIW.InmueblesArriendo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Inmuebles Arriendo</title>
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
                                <li><a href="InmueblesVenta.aspx">Inmuebles En Venta</a></li>
                                <li class="divider"></li>
                                <li><a href="InmueblesArriendo.aspx">Inmuebles En Arriendo</a></li>
                                <li class="divider"></li>
                                <li><a href="InmueblesAlquiler.aspx">Alquiler De Inmuebles</a></li>
                            </ul>
                        </li>
                        <li><a href="#">Quienes Somos</a></li>
                        <li class="dropdown">
                            <a href="#" class="dropdown dropdown-toggle" data-toggle="dropdown">Servicio Al Cliente<b class="caret"></b></a>
                            <ul class="dropdown-menu">
                                <li><a href="#contact">Contatenos</a></li>
                                <li class="divider"></li>
                                <li><a href="#">Dejanos Tus Comentarios</a></li>
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
    <div>
    
    </div>
    </form>
</body>
</html>
