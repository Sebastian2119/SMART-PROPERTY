<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmAdministrador_ConsultarInmuebles.aspx.cs" Inherits="SmartPropertySIW.Formularios.frmAdministrador_ConsultarInmuebles" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Administrador</title>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" />
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
    <link href="../Styles/Styles.css" rel="stylesheet" />
    <link href="../Styles/StylesWorkContent.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <nav class="navbar navbar-inverse">
            <div class="container-fluid">
                <div class="navbar-header">
                    o
                    <button type="button" class="navbar-toggle" data-toggle="collapse" data-target="#myNavbar">
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                    </button>
                    <a class="navbar-brand" href="#">SMART PROPERTY</a>
                </div>
                <div class="collapse navbar-collapse" id="myNavbar">
                    <ul class="nav navbar-nav">
                        <li><a href="frmAdministrador.aspx"><span class="glyphicon glyphicon-home"></span>&nbsp Inicio</a></li>                        
                        <li class="dropdown">
                            <a href="#" class="dropdown dropdown-toggle" data-toggle="dropdown">Registrar<b class="caret"></b></a>
                            <ul class="dropdown-menu">
                                <li><a href="frmAdministrador_RegistroUsuario.aspx">Registrar Usuarios</a></li>
                                <li class="divider"></li>
                                <li><a href="frmAdministrador_RegistroInmuebles.aspx">Registrar Inmuebles</a></li>
                            </ul>
                        </li>
                        <li class="dropdown active">
                            <a href="#" class="dropdown dropdown-toggle" data-toggle="dropdown">Consultar<b class="caret"></b></a>
                            <ul class="dropdown-menu">
                                <li><a href="frmAdministrador_ConsultarUsuarios.aspx">Consultar Usuarios</a></li>
                                <li class="divider"></li>
                                <li class="active"><a href="frmAdministrador_ConsultarInmuebles.aspx">Consultar Inmuebles</a></li>
                            </ul>
                        </li>
                        <li class="dropdown">
                            <a href="#" class="dropdown dropdown-toggle" data-toggle="dropdown">Modificar<b class="caret"></b></a>
                            <ul class="dropdown-menu">
                                <li><a href="frmAdministrador_ModificarUsuarios.aspx">Modificar Usuarios</a></li>
                                <li class="divider"></li>
                                <li><a href="frmAdministrador_ModificarInmuebles.aspx">Modificar Inmuebles</a></li>
                            </ul>
                        </li>
                        <li class="dropdown">
                            <a href="#" class="dropdown dropdown-toggle" data-toggle="dropdown">Generar Reportes<b class="caret"></b></a>
                            <ul class="dropdown-menu">
                                <li><a href="frmAdministrador_Reportes.aspx">Ver Reportes</a></li>                                
                            </ul>
                        </li>
                    </ul>    
                </div>
            </div>
        </nav>
        <div class="container-fluid text-center">
            <div class="row content">
                <div class="col-sm-2 sidenav">
                    <p><a href="#"></a></p>
                    <p><a href="#"></a></p>
                </div>
                <div class="col-sm-8">
                    <div>
                        <img src="../Imagenes/Imagen1.png" style="width: 50%" />
                    </div>
                    <div class="input-group">
                        <asp:Label ID="lblMensaje" runat="server" Enabled="False"></asp:Label>
                    </div>
                    <div class="input-group">
                        <asp:TextBox ID="TxtBuscarInmueble" Style="text-transform: uppercase;" runat="server" class="form-control" placeholder="Buscar Por Dirección Del Inmueble"></asp:TextBox>
                        <span class="input-group-btn">
                            <asp:LinkButton ID="btnBuscarInmueble" runat="server" CssClass="btn btn-info" Text="Buscar" OnClick="btnBuscarInmueble_Click"><span class="glyphicon glyphicon-search"></span>&nbsp;Buscar</asp:LinkButton>
                        </span>
                    </div>
                    <section class="row">
                        <p></p>
                    </section>
                    <div class="container-fluid">
                        <div class="col-sm-2"></div>
                        <div class="col-lg-8" id="WorkContent">
                            <asp:GridView ID="gvConsultarInmuebles" class="table table-bordered bs-table" runat="server"></asp:GridView>
                        </div>
                        <div class="col-sm-2"></div>
                    </div>
                    <section class="row">
                        <p></p>
                    </section>
                    <div class="input-group">
                        <asp:Label ID="lblMensaje2" runat="server" Enabled="False"></asp:Label>
                    </div>
                    <div class="input-group">
                        <asp:TextBox ID="txtBuscarPorEncargado" Style="text-transform: capitalize;" runat="server" class="form-control" placeholder="BUSCAR POR ENCARGADO DEL INMUEBLE"></asp:TextBox>
                        <span class="input-group-btn">
                            <asp:LinkButton ID="btnBuscarInmuebleEncargado" runat="server" CssClass="btn btn-info" Text="Buscar" OnClick="btnBuscarInmuebleEncargado_Click"><span class="glyphicon glyphicon-search"></span>&nbsp;Buscar</asp:LinkButton>
                        </span>
                    </div>
                    <section class="row">
                        <p></p>
                    </section>
                    <div class="container-fluid">
                        <div class="col-sm-2"></div>
                        <div class="col-lg-8" id="mWorkContent">
                            <asp:GridView ID="gvConsultarInmueblesEncargado" class="table table-bordered bs-table" runat="server"></asp:GridView>
                        </div>
                        <div class="col-sm-2"></div>
                    </div>
                </div>
                <div class="col-sm-2 sidenav"></div>
            </div>
        </div>

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
