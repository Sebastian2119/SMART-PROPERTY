﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmAdministrador_ModificarInmuebles.aspx.cs" Inherits="SmartPropertySIW.Formularios.frmAdministrador_ModificarInmuebles" %>

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
                        <li class="dropdown active">
                            <a href="#" class="dropdown dropdown-toggle" data-toggle="dropdown">Modificar<b class="caret"></b></a>
                            <ul class="dropdown-menu">
                                <li><a href="frmAdministrador_ModificarUsuarios.aspx">Modificar Usuarios</a></li>
                                <li class="divider"></li>
                                <li class="active"><a href="frmAdministrador_ModificarInmuebles">Modificar Inmuebles</a></li>
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
                <h1>Modificar Inmuebles</h1>
                <asp:Label ID="lblMensaje" runat="server" Enabled="false" Text=""></asp:Label>
                <div class="col-sm-2"></div>
                <div class="col-sm-8 text-left">
                    <h3><span class="glyphicon glyphicon-list-alt"></span>&nbsp Datos del Propietario o Encargado</h3>
                    <div class="form-group">
                        <label for="Nombres">Nombres Cliente:</label>
                        <asp:TextBox ID="txtNombresCliente" required="required" type="text" class="form-control" Style="text-transform: capitalize" placeholder="Ingresar Nombres" name="txtNombresCliente" runat="server"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="Apellidos">Apellidos Cliente:</label>
                        <asp:TextBox ID="txtApellidosCliente" required="required" type="text" class="form-control" Style="text-transform: capitalize" placeholder="Ingresar Apellidos" name="txtApellidosCliente" runat="server"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="Direccion">Direccion Cliente:</label>
                        <asp:TextBox ID="txtDireccionCliente" required="required" type="text" class="form-control" Style="text-transform: uppercase;" placeholder="Ingresar Dirección" name="txtApellidosCliente" runat="server"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="Direccion">Celular Cliente:</label>
                        <asp:TextBox ID="txtCelularCliente" required="required" type="number" class="form-control" placeholder="Ingresar Celular" name="txtCelularCliente" runat="server"></asp:TextBox>
                    </div>
                    <hr />
                    <h3><span class="glyphicon glyphicon-check"></span>&nbsp Datos del Aviso</h3>
                    <div class="dropdown">
                        <label for="TipoOferta">Tipo Oferta:</label>
                        <asp:DropDownList ID="ddlTipoOferta" class="btn btn-default dropdown-toggle" Style="width: 100%; text-align: left" runat="server" required="required"></asp:DropDownList>
                    </div>
                    <div class="dropdown">
                        <label for="Tipo Inmueble">Tipo Inmueble:</label>
                        <asp:DropDownList ID="ddlTipoInmueble" class="btn btn-default dropdown-toggle" Style="width: 100%; text-align: left" runat="server" required="required"></asp:DropDownList>
                    </div>
                    <hr />
                    <h3><span class="glyphicon glyphicon-map-marker"></span>&nbsp Ubicación Del Inmueble</h3>
                    <div class="dropdown">
                        <label for="Ubicacion">Ubicacion Del Inmueble:</label>
                        <asp:DropDownList ID="ddlUbicacion" class="btn btn-default dropdown-toggle" Style="width: 100%; text-align: left" runat="server" required="required"></asp:DropDownList>
                    </div>
                    <div class="form-group">
                        <label for="Barrio">Barrio Donde Esta Ubicado El Inmueble:</label>
                        <asp:TextBox ID="txtBarrio" required="required" type="text" class="form-control" Style="text-transform: uppercase;" placeholder="Ingresar Un Barrio" name="txtBarrio" runat="server"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="Direccion">Dirección Del Inmueble:</label>
                        <asp:TextBox ID="txtDireccion" required="required" type="text" class="form-control" Style="text-transform: uppercase;" placeholder="Ingrese Una Dirección" name="txtBarrio" runat="server"></asp:TextBox>
                    </div>
                    <div class="dropdown">
                        <label for="Zona">Zona:</label>
                        <asp:DropDownList ID="ddlZona" class="btn btn-default dropdown-toggle" Style="width: 100%; text-align: left" required="required" runat="server">
                            <asp:ListItem>Seleccionar:</asp:ListItem>
                            <asp:ListItem>Zona Centro</asp:ListItem>
                            <asp:ListItem>Zona Noroccidente</asp:ListItem>
                            <asp:ListItem>Zona Norte</asp:ListItem>
                            <asp:ListItem>Zona Occidental</asp:ListItem>
                            <asp:ListItem>Zona Sur</asp:ListItem>
                        </asp:DropDownList>
                    </div>
                    <hr />
                    <h3><span class="glyphicon glyphicon-info-sign"></span>&nbsp Información del inmueble</h3>
                    <div class="form-group">
                        <label for="PrecioAvaluado">Precio Avaluado:</label>
                        <asp:TextBox ID="txtPrecioAvaluado" required="required" type="number" class="form-control" placeholder="Ingrese El PrecioAvaluado" name="txtPrecioAvaluado" runat="server"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="PrecioCliente">Precio Cliente:</label>
                        <asp:TextBox ID="txtPrecioCliente" required="required" type="number" class="form-control" placeholder="Ingrese Precio Del Cliente" name="txtPrecio Cliente" runat="server"></asp:TextBox>
                    </div>
                    <div class="form-group col-sm-4 ">
                        <label for="Area">Area M2:</label>
                        <asp:TextBox ID="txtArea" required="required" type="text" class="form-control" Style="text-transform: uppercase;" placeholder="Area En M2" name="txtArea" runat="server"></asp:TextBox>
                    </div>
                    <div class="form-group col-sm-4">
                        <label for="Estrato">Estrato:</label>
                        <asp:TextBox ID="txtEstrato" required="required" min="1" max="6" type="number" class="form-control" name="txtEstrato" runat="server"></asp:TextBox>
                    </div>
                    <div class="form-group col-sm-4">
                        <label for="habitaciones">Habitaciones:</label>
                        <asp:TextBox ID="txtHabitaciones" required="required" min="0" type="number" class="form-control" name="txtHabitaciones" runat="server"></asp:TextBox>
                    </div>
                    <div class="form-group col-sm-4">
                        <label for="Pisos">Pisos:</label>
                        <asp:TextBox ID="txtPisos" required="required" type="number" min="0" class="form-control" name="txtPisos" runat="server"></asp:TextBox>
                    </div>
                    <div class="form-group col-sm-4">
                        <label for="Baños">Baños:</label>
                        <asp:TextBox ID="txtBaños" required="required" type="number" min="0" class="form-control" name="txtBaños" runat="server"></asp:TextBox>
                    </div>
                    <div class="form-group col-sm-4">
                        <label for="clima">Clima:</label>
                        <asp:DropDownList ID="ddlClima" class="btn btn-default dropdown-toggle" Style="width: 100%; text-align: left" runat="server">
                            <asp:ListItem>Seleccionar:</asp:ListItem>
                            <asp:ListItem>Cálido</asp:ListItem>
                            <asp:ListItem>Templado/Medio</asp:ListItem>
                            <asp:ListItem>Frío</asp:ListItem>
                            <asp:ListItem>Páramo</asp:ListItem>
                        </asp:DropDownList>
                    </div>
                    <div class="form-group col-sm-6">
                        <label for="estado">Estado:</label>
                        <asp:DropDownList ID="ddlEstado" required="required" class="btn btn-default dropdown-toggle" Style="width: 100%; text-align: left" runat="server"></asp:DropDownList>
                    </div>
                    <div class="form-group col-sm-6">
                        <label for="ValorAdministracion">Valor Administración:</label>
                        <asp:TextBox ID="txtValorAdministracion" type="number" class="form-control" placeholder="Ingrese Valor Aministración" name="txtValorAdministracion" runat="server"></asp:TextBox>
                    </div>
                    <div class="form-group col-lg-12">
                        <hr />
                        <h3><span class="glyphicon glyphicon-list"></span>&nbsp Caracteristicas:</h3>
                        <div class="panel-group" id="accordion">
                            <div class="panel panel-default">
                                <div class="panel-heading">
                                    <h4 class="panel-title">
                                        <a data-toggle="collapse" data-parent="#accordion" href="#collapse1"><span class="glyphicon glyphicon-plus-sign"></span>&nbsp Interiores</a>
                                    </h4>
                                </div>
                                <div id="collapse1" class="panel-collapse collapse">
                                    <div class="panel-body">
                                        <div class="btn-group btn-group-justified">
                                            <asp:ScriptManager ID="ScriptManager1" runat="server" />
                                            <asp:UpdatePanel runat="server" ID="UpdatePanel" UpdateMode="Conditional">
                                                <Triggers>
                                                    <asp:AsyncPostBackTrigger ControlID="btnAlarma" EventName="Click" />
                                                </Triggers>
                                                <ContentTemplate>
                                                    <asp:Button ID="btnAlarma" class="btn btn-default" Style="width: 32%; text-align: left" runat="server" Text="Alarma" OnClick="btnAlarma_Click" />
                                                    <asp:Button ID="btnAmoblado" class="btn btn-default" Style="width: 32%; text-align: left" runat="server" Text="Amoblado" OnClick="btnAmoblado_Click" />
                                                    <asp:Button ID="btnCalentador" class="btn btn-default" Style="width: 32%; text-align: left" runat="server" Text="Calentador" OnClick="btnCalentador_Click" />
                                                    <asp:Button ID="btnChimenea" class="btn btn-default" Style="width: 32%; text-align: left" runat="server" Text="Chimenea" OnClick="btnChimenea_Click" />
                                                    <asp:Button ID="btnAireAcondicionado" class="btn btn-default" Style="width: 32%; text-align: left" runat="server" Text="Aire Acondicionado" OnClick="btnAireAcondicionado_Click" />
                                                    <asp:Button ID="btnCuartoDeServicio" class="btn btn-default" Style="width: 32%; text-align: left" runat="server" Text="Cuarto De Servicio" OnClick="btnCuartoDeServicio_Click" />
                                                    <asp:Button ID="btnGaraje" class="btn btn-default" Style="width: 32%; text-align: left" runat="server" Text="Garaje" OnClick="btnGaraje_Click" />
                                                    <asp:Button ID="btnPatio" class="btn btn-default" Style="width: 32%; text-align: left" runat="server" Text="Patio" OnClick="btnPatio_Click" />
                                                    <asp:Button ID="btnBalcon" class="btn btn-default" Style="width: 32%; text-align: left" runat="server" Text="Balcón" OnClick="btnBalcon_Click" />
                                                    <asp:Button ID="btnCocinaIntegral" class="btn btn-default" Style="width: 32%; text-align: left" runat="server" Text="Cocina Integral" OnClick="btnCocinaIntegral_Click" />
                                                    <asp:Button ID="btnCuartoEstudio" class="btn btn-default" Style="width: 32%; text-align: left" runat="server" Text="Cuarto Estudio" OnClick="btnCuartoEstudio_Click" />
                                                    <asp:Button ID="btnDepositoBodega" class="btn btn-default" Style="width: 32%; text-align: left" runat="server" Text="Deposito/Bodega" OnClick="btnDepositoBodega_Click" />
                                                    <asp:Button ID="btnInstalaciónDeAgua" class="btn btn-default" Style="width: 32%; text-align: left" runat="server" Text="Instalación de Agua" OnClick="btnInstalaciónDeAgua_Click" />
                                                    <asp:Button ID="btnInstalaciónDeEnergía" class="btn btn-default" Style="width: 32%; text-align: left" runat="server" Text="Instalación de Energía" OnClick="btnInstalaciónDeEnergía_Click" />
                                                    <asp:Button ID="btnInstalaciónDeGas" class="btn btn-default" Style="width: 32%; text-align: left" runat="server" Text="Instalación de Gas" OnClick="btnInstalaciónDeGas_Click" />
                                                    <asp:Button ID="btnPisosCeramica" class="btn btn-default" Style="width: 32%; text-align: left" runat="server" Text="Pisos Ceramica" OnClick="btnPisosCeramica_Click" />
                                                    <asp:Button ID="btnPisosMadera" class="btn btn-default" Style="width: 32%; text-align: left" runat="server" Text="Pisos Madera" OnClick="btnPisosMadera_Click" />
                                                    <asp:Button ID="btnPisosCemento" class="btn btn-default" Style="width: 32%; text-align: left" runat="server" Text="Pisos Cemento" OnClick="btnPisosCemento_Click" />
                                                    <hr />
                                                    <asp:TextBox ID="txtCaracteristicasInteriores" class="form-control" TextMode="MultiLine" Rows="5" runat="server"></asp:TextBox>
                                                </ContentTemplate>
                                            </asp:UpdatePanel>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class="panel panel-default">
                                <div class="panel-heading">
                                    <h4 class="panel-title">
                                        <a data-toggle="collapse" data-parent="#accordion" href="#collapse2"><span class="glyphicon glyphicon-plus-sign"></span>&nbsp Exteriores</a>
                                    </h4>
                                </div>
                                <div id="collapse2" class="panel-collapse collapse">
                                    <div class="panel-body">
                                        <div class="btn-group btn-group-justified">
                                            <asp:UpdatePanel runat="server" ID="UpdatePanel2" UpdateMode="Conditional">
                                                <Triggers>
                                                    <asp:AsyncPostBackTrigger ControlID="btnAscensor" EventName="Click" />
                                                </Triggers>
                                                <ContentTemplate>
                                                    <asp:Button ID="btnAscensor" class="btn btn-default" Style="width: 32%; text-align: left" runat="server" Text="Ascensor" OnClick="btnAscensor_Click" />
                                                    <asp:Button ID="btnConjuntoCerrado" class="btn btn-default" Style="width: 32%; text-align: left" runat="server" Text="Conjunto Cerrado" OnClick="btnConjuntoCerrado_Click" />
                                                    <asp:Button ID="btnVigilancia" class="btn btn-default" Style="width: 32%; text-align: left" runat="server" Text="Vigilancia" OnClick="btnVigilancia_Click" />
                                                    <asp:Button ID="btnPorteria" class="btn btn-default" Style="width: 32%; text-align: left" runat="server" Text="Portería/Recepción" OnClick="btnPorteria_Click" />
                                                    <asp:Button ID="btnEstacionamiento" class="btn btn-default" Style="width: 32%; text-align: left" runat="server" Text="Estacionamiento" OnClick="btnEstacionamiento_Click" />
                                                    <asp:Button ID="btnSalonComunal" class="btn btn-default" Style="width: 32%; text-align: left" runat="server" Text="Salón Comunal" OnClick="btnSalonComunal_Click" />
                                                    <asp:Button ID="btnZonasVerdes" class="btn btn-default" Style="width: 32%; text-align: left" runat="server" Text="Zonas Verdes" OnClick="btnZonasVerdes_Click" />
                                                    <asp:Button ID="btnZonaInfantil" class="btn btn-default" Style="width: 32%; text-align: left" runat="server" Text="Zona Infantil" OnClick="btnZonaInfantil_Click" />
                                                    <asp:Button ID="btnGimnacio" class="btn btn-default" Style="width: 32%; text-align: left" runat="server" Text="Gimnasio" OnClick="btnGimnacio_Click" />
                                                    <asp:Button ID="btnJardin" class="btn btn-default" Style="width: 32%; text-align: left" runat="server" Text="Jardín" OnClick="btnJardin_Click" />
                                                    <asp:Button ID="btnCanchasDeTennis" class="btn btn-default" Style="width: 32%; text-align: left" runat="server" Text="Canchas De Tennis" OnClick="btnCanchasDeTennis_Click" />
                                                    <asp:Button ID="btnCanchasDeBaloncesto" class="btn btn-default" Style="width: 32%; text-align: left" runat="server" Text="Canchas De Baloncesto" OnClick="btnCanchasDeBaloncesto_Click" />
                                                    <asp:Button ID="btnCanchasDeFutbol" class="btn btn-default" Style="width: 32%; text-align: left" runat="server" Text="Canchas De Fútbol" OnClick="btnCanchasDeFutbol_Click" />
                                                    <asp:Button ID="btnPiscina" class="btn btn-default" Style="width: 32%; text-align: left" runat="server" Text="Piscina" OnClick="btnPiscina_Click" />
                                                    <asp:Button ID="btnOtros" class="btn btn-default" Style="width: 32%; text-align: left" runat="server" Text="Otros" OnClick="btnOtros_Click" />
                                                    <hr />
                                                    <asp:TextBox ID="txtCaracteristicasExteriores" class="form-control" TextMode="MultiLine" Rows="5" runat="server"></asp:TextBox>
                                                </ContentTemplate>
                                            </asp:UpdatePanel>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class="panel panel-default">
                                <div class="panel-heading">
                                    <h4 class="panel-title">
                                        <a data-toggle="collapse" data-parent="#accordion" href="#collapse3"><span class="glyphicon glyphicon-plus-sign"></span>&nbsp Sector</a>
                                    </h4>
                                </div>
                                <div id="collapse3" class="panel-collapse collapse">
                                    <div class="panel-body">
                                        <div class="btn-group btn-group-justified">
                                            <asp:UpdatePanel runat="server" ID="UpdatePanel3" UpdateMode="Conditional">
                                                <Triggers>
                                                    <asp:AsyncPostBackTrigger ControlID="btnViaPrincipal" EventName="Click" />
                                                </Triggers>
                                                <ContentTemplate>
                                                    <asp:Button ID="btnViaPrincipal" class="btn btn-default" Style="width: 32%; text-align: left" runat="server" Text="Vía Principal" OnClick="btnViaPrincipal_Click" />
                                                    <asp:Button ID="btnParquesCercanos" class="btn btn-default" Style="width: 32%; text-align: left" runat="server" Text="Parques Cercanos" OnClick="btnParquesCercanos_Click" />
                                                    <asp:Button ID="TransportePúblico" class="btn btn-default" Style="width: 32%; text-align: left" runat="server" Text="Transporte Público" OnClick="TransportePúblico_Click" />
                                                    <asp:Button ID="btnZonaComercial" class="btn btn-default" Style="width: 32%; text-align: left" runat="server" Text="Zona Comercial" OnClick="btnZonaComercial_Click" />
                                                    <asp:Button ID="btnZonaIndustrial" class="btn btn-default" Style="width: 32%; text-align: left" runat="server" Text="Zona Industrial" OnClick="btnZonaIndustrial_Click" />
                                                    <asp:Button ID="btnZonaResidencial" class="btn btn-default" Style="width: 32%; text-align: left" runat="server" Text="Zona Residencial" OnClick="btnZonaResidencial_Click" />
                                                    <asp:Button ID="btnColegios" class="btn btn-default" Style="width: 32%; text-align: left" runat="server" Text="Colegios" OnClick="btnColegios_Click" />
                                                    <asp:Button ID="btnUniversidades" class="btn btn-default" Style="width: 32%; text-align: left" runat="server" Text="Universidades" OnClick="btnUniversidades_Click" />
                                                    <asp:Button ID="btnSupermecados" class="btn btn-default" Style="width: 32%; text-align: left" runat="server" Text="Supermecados/C.C" OnClick="btnSupermecados_Click" />
                                                    <hr />                                                     
                                                    <asp:TextBox ID="txtSector" class="form-control" TextMode="MultiLine" Rows="5" runat="server"></asp:TextBox>
                                                </ContentTemplate>
                                            </asp:UpdatePanel>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>                                           
                        <br />
                        <div class="form-group">
                            <label for="comment">Comentarios:</label>
                            <asp:TextBox ID="txtComentarios" class="form-control" TextMode="MultiLine" Rows="5" runat="server"></asp:TextBox>
                            <h6>Máximo 500 caracteres</h6>
                        </div>
                        <div class="form-group">
                            <asp:TextBox ID="txtUsuarioProvicional" runat="server" Enabled="False" Visible="false"></asp:TextBox>
                        </div>
                        <div class="col-sm-12 text-center">
                            <asp:Label ID="lblMensajeOK" runat="server" Enabled="false" Text=""></asp:Label>
                        </div>
                        <div class="col-sm-12 text-center">
                            <asp:Button ID="btnContinuar" Visible="false" name="btnEnviar" class="btn btn-success" runat="server" Text="Continuar" OnClick="btnContinuar_Click" />
                        </div>
                    </div>
                </div>
                <div class="col-sm-2"></div>
            </div>
        </div>
        <div class="container-fluid">
            <div class="col-sm-2"></div>
            <div class="col-lg-8" id="myWorkContent">
                <asp:GridView ID="gvDatosInmuebles" class="table table-bordered bs-table" Style="border: 0" runat="server" OnRowDeleting="gvDatosInmuebles_RowDeleting" OnRowEditing="gvDatosInmuebles_RowEditing" OnSelectedIndexChanged="gvDatosInmuebles_SelectedIndexChanged">
                    <Columns>
                        <asp:ButtonField CommandName="Select" ControlStyle-CssClass="btn btn-success" ShowHeader="True" Text="Seleccionar">
                            <ControlStyle CssClass="btn btn-success"></ControlStyle>
                        </asp:ButtonField>
                        <asp:ButtonField CommandName="Edit" ControlStyle-CssClass="btn btn-info" ShowHeader="True" Text="Editar">
                            <ControlStyle CssClass="btn btn-info"></ControlStyle>
                        </asp:ButtonField>
                        <asp:ButtonField CommandName="Delete" ControlStyle-CssClass="btn btn-danger" ShowHeader="True" Text="Arrendado o Vendido">
                            <ControlStyle CssClass="btn btn-danger"></ControlStyle>
                        </asp:ButtonField>
                    </Columns>
                </asp:GridView>
            </div>
            <div class="col-sm-2"></div>
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
