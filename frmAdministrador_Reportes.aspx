<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmAdministrador_Reportes.aspx.cs" Inherits="SmartPropertySIW.Formularios.frmAdministrador_Reportes" %>

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
                    <a class="navbar-brand" href="frmAdministrador.aspx">SMART PROPERTY</a>
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
                        <li class="dropdown">
                            <a href="#" class="dropdown dropdown-toggle" data-toggle="dropdown">Consultar<b class="caret"></b></a>
                            <ul class="dropdown-menu">
                                <li><a href="frmAdministrador_ConsultarUsuarios.aspx">Consultar Usuarios</a></li>
                                <li class="divider"></li>
                                <li><a href="frmAdministrador_ConsultarInmuebles.aspx">Consultar Inmuebles</a></li>
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
                        <li class="dropdown active">
                            <a href="#" class="dropdown dropdown-toggle" data-toggle="dropdown">Generar Reportes<b class="caret"></b></a>
                            <ul class="dropdown-menu">
                                <li class="active"><a href="frmAdministrador_Reportes.aspx">Ver Reportes</a></li>
                            </ul>
                        </li>
                    </ul>                    
                </div>
            </div>
        </nav>
        <div class="container-fluid text-center">
            <div class="row content">
                <div class="col-sm-2 sidenav"></div>
                <div class="col-sm-8">
                    <div>
                        <img src="../Imagenes/Imagen1.png" style="width: 50%" />
                    </div>
                    <div class="col-sm-2"></div>
                    <div class="input-group col-sm-8">
                        <span class="input-group-btn">
                            <asp:LinkButton ID="btnReporteUsuariosRegistrados" Style="width: 33%" runat="server" CssClass="btn btn-info" OnClick="btnReporteUsuariosRegistrados_Click"><span class="glyphicon glyphicon-user"></span>&nbsp;Usuarios Regitrados</asp:LinkButton>
                            <asp:LinkButton ID="btnReporteInmueblesRegistrados" Style="width: 33%" runat="server" CssClass="btn btn-success" OnClick="btnReporteInmueblesRegistrados_Click"><span class="glyphicon glyphicon-home"></span>&nbsp;Inmuebles Regitrados</asp:LinkButton>
                            <asp:LinkButton ID="btnReporteUsuariosEliminados" Style="width: 33%" runat="server" CssClass="btn btn-info" OnClick="btnReporteUsuariosEliminados_Click"><span class="glyphicon glyphicon-erase"></span>&nbsp;Usuarios Eliminados</asp:LinkButton>
                        </span>
                    </div>
                    <div class="col-sm-2"></div>
                    <section class="row">
                        <p></p>
                    </section>
                    <div class="col-sm-2"></div>
                    <div class="input-group col-sm-8">
                        <span class="input-group-btn">
                            <asp:LinkButton ID="btnReporteInmueblesEliminados" Style="width: 33%" runat="server" CssClass="btn btn-success" OnClick="btnReporteInmueblesEliminados_Click"><span class="glyphicon glyphicon-trash"></span>&nbsp;Inmuebles Eliminados</asp:LinkButton>
                            <asp:LinkButton ID="btnReporteInmueblesArrendados" Style="width: 33%" runat="server" CssClass="btn btn-info" OnClick="btnReporteInmueblesArrendados_Click"><span class="glyphicon glyphicon-edit"></span>&nbsp;Inmuebles Arrendados</asp:LinkButton>
                            <asp:LinkButton ID="btnReporteInmueblesVendidos" Style="width: 33%" runat="server" CssClass="btn btn-success" OnClick="btnReporteInmueblesVendidos_Click"><span class="glyphicon glyphicon-check"></span>&nbsp;Inmuebles Vendidos</asp:LinkButton>
                        </span>
                    </div>
                    <div class="col-sm-2"></div>
                    <section class="row">
                        <p></p>
                    </section>
                    <div class="col-sm-2"></div>
                    <div class="input-group col-sm-8">
                        <span class="input-group-btn">
                            <asp:LinkButton ID="btnReporteInmueblesArriendo" Style="width: 33%" runat="server" CssClass="btn btn-info" OnClick="btnReporteInmueblesArriendo_Click"><span class="glyphicon glyphicon-edit"></span>&nbsp;Inmuebles En Arriendo</asp:LinkButton>
                            <asp:LinkButton ID="btnReporteInmueblesVenta" Style="width: 33%" runat="server" CssClass="btn btn-success" OnClick="btnReporteInmueblesVenta_Click"><span class="glyphicon glyphicon-shopping-cart"></span>&nbsp;Inmuebles En Venta</asp:LinkButton>
                            <asp:LinkButton ID="btnReporteInmueblesAlquiler" Style="width: 33%" runat="server" CssClass="btn btn-info" OnClick="btnReporteInmueblesAlquiler_Click"><span class="glyphicon glyphicon-tag"></span>&nbsp;Inmuebles En Alquiler</asp:LinkButton>
                        </span>
                    </div>
                    <div class="col-sm-2"></div>
                    <section class="row">
                        <p></p>
                    </section>

                    <div class="container-fluid">
                        <div class="col-sm-2"></div>
                        <div class="col-lg-8" id="myWorkContent">
                            <asp:Label ID="lblInfo" runat="server" />
                            <section class="row">
                                <p></p>
                            </section>
                            <asp:Label ID="lblTotalClientes" runat="server" CssClass="label label-warning" /></span>
                            <asp:GridView ID="gvConsultarReportes" class="table table-bordered bs-table" runat="server"></asp:GridView>
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
