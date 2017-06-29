<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmAdministrador_RegistroUsuario.aspx.cs" Inherits="SmartPropertySIW.frmAdministrador_RegistroUsuario" %>

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
                        
                        <li class="dropdown active">
                            <a href="#" class="dropdown dropdown-toggle" data-toggle="dropdown">Registrar<b class="caret"></b></a>
                            <ul class="dropdown-menu">
                                <li class="active"><a href="frmAdministrador_RegistroUsuario.aspx">Registrar Usuarios</a></li>
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
        <div class="container-fluid text-left">
            <div class="col-sm-2 sidenav"></div>
            <div class="col-sm-8 text-center">
                <h1>Registrar Usuarios</h1>
                <div class="col-sm-2"></div>
                <div class="col-sm-8 text-left">
                    <h3><span class="glyphicon glyphicon-check"></span>&nbsp Datos Personales</h3>
                    <div class="form-group">
                        <label for="Nombres">Nombres:</label>
                        <asp:TextBox ID="txtNombres" MaxLength="45" Style="text-transform: capitalize" type="text" class="form-control" placeholder="Ingresar Nombres" name="txtNombres" runat="server" required="required"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="Apellidos">Apellidos:</label>
                        <asp:TextBox ID="txtApellidos"  MaxLength="45" Style="text-transform: capitalize" type="text" class="form-control" placeholder="Ingresar Apellidos" name="txtApellidos" runat="server" required="required"></asp:TextBox>
                    </div>
                    <div class="dropdown">
                        <label for="TipoDocumento">Tipo Documento:</label>
                        <asp:DropDownList ID="ddlTipoDocumento" class="btn btn-default dropdown-toggle" Style="width: 100%; text-align: left" runat="server" required="required"></asp:DropDownList>
                    </div>
                    <div class="form-group">
                        <label for="Documento">Documento:</label>
                        <asp:TextBox ID="txtDocumento" MaxLength="11" type="text" class="form-control" placeholder="Ingresar Numero De Documento" name="txtDocumento" runat="server" required="required"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="FechaNacimiento">Fecha De Nacimiento:</label>
                        <asp:TextBox ID="txtFechaNacimiento" type="date" class="form-control" name="txtDocumento" runat="server"></asp:TextBox>
                    </div>
                    <div class="dropdown">
                        <label for="Genero">Genero:</label>
                        <asp:DropDownList ID="ddlGenero" class="btn btn-default dropdown-toggle" Style="width: 100%; text-align: left" runat="server" required="required"></asp:DropDownList>
                    </div>
                    <hr />
                    <h3><span class="glyphicon glyphicon-phone"></span>&nbsp Datos de Contacto</h3>
                    <div class="dropdown">
                        <label for="Ciudad">Ciudad Residencia:</label>
                        <asp:DropDownList ID="ddlCiudadRecidencia" class="btn btn-default dropdown-toggle" Style="width: 100%; text-align: left" runat="server" required="required"></asp:DropDownList>
                    </div>
                    <div class="form-group">
                        <label for="Direccion">Dirección:</label>
                        <asp:TextBox ID="txtDireccion" Style="text-transform: uppercase" type="text" class="form-control" placeholder="Ingrese su Dirección" name="txtDireccion" runat="server"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="NumeroCelular">Numero Celular:</label>
                        <asp:TextBox ID="txtNumeroCelular" type="number" MaxLength="10" class="form-control" placeholder="Ingresar Numero De Celular" name="txtCelular" runat="server" required="required"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="Correo">Correo:</label>
                        <asp:TextBox ID="txtCorreo" Style="text-transform: uppercase" MaxLength="45" type="email" class="form-control" placeholder="smartpropertysiw@gmail.com" name="txtCorreo" runat="server" required="required"></asp:TextBox>
                    </div>
                    <hr />
                    <h3><span class="glyphicon glyphicon-user"></span>&nbsp Crear Usuario</h3>
                    <div class="form-group">
                        <label for="Usuario">Usuario:</label>
                        <asp:TextBox ID="txtUsuario" type="text" class="form-control" placeholder="smartpropertysiw@gmail.com" name="txtUsuario" runat="server" required="required"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="Password">Contraseña:</label>
                        <asp:TextBox ID="txtContraseña" type="password" class="form-control" name="txtContraseña" runat="server" required="required"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="Password">Confirmar Contraseña:</label>
                        <asp:TextBox ID="txtConfirmarContraseña" type="password" class="form-control" name="txtContraseñaContraseña" runat="server" required="required"></asp:TextBox>
                    </div>
                    <div class="dropdown">
                        <label for="TipoUsuario">Tipo Usuario:</label>
                        <asp:DropDownList ID="ddlTipoUsuario" class="btn btn-default dropdown-toggle" Style="width: 100%; text-align: left" runat="server" required="required"></asp:DropDownList>
                    </div>
                    <br />
                    <div class="col-sm-12 text-center">
                        <asp:ScriptManager ID="ScriptManager1" runat="server" />
                        <asp:UpdatePanel runat="server" ID="UpdatePanel3" UpdateMode="Conditional">
                            <Triggers>
                                <asp:AsyncPostBackTrigger ControlID="btnEnviar" EventName="Click" />
                            </Triggers>
                            <ContentTemplate>
                                <asp:Button ID="btnEnviar" name="btnEnviar" class="btn btn-success" runat="server" Text="Registrar" OnClick="btnEnviar_Click" />
                                <div class="form-group">
                                    <asp:Label ID="lblMensajeOK" runat="server" Enabled="false" Text=""></asp:Label>
                                </div>
                                <asp:Button ID="btnContinuar" Visible="false" Style="background-position: center" name="btnEnviar" class="btn btn-success" runat="server" Text="Registrar Otro Usuario" OnClick="btnContinuar_Click" />
                            </ContentTemplate>
                        </asp:UpdatePanel>                        
                    </div>
                </div>
                <div class="col-sm-2"></div>
            </div>
            <div class="col-sm-2 sidenav">
            </div>
        </div>
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
