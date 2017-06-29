<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmVerInmuebles.aspx.cs" Inherits="SmartPropertySIW.Formularios.frmVerInmuebles_Venta1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Ver Inmuebles</title>
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
                    <a class="navbar-brand" href="frmindex.aspx">SMART PROPERTY</a>
                </div>
                <div class="collapse navbar-collapse" id="myNavbar">
                    <ul class="nav navbar-nav">
                        <li class="active"><a href="frmindex.aspx"><span class="glyphicon glyphicon-home"></span>&nbsp Inicio</a></li>
                        <li class="dropdown">
                            <a href="#" class="dropdown dropdown-toggle" data-toggle="dropdown">Inmuebles<b class="caret"></b></a>
                            <ul class="dropdown-menu">
                                <li><a href="InmueblesVenta.aspx">Inmuebles En Venta</a></li>
                                <li class="divider"></li>
                                <li><a href="#">Inmuebles En Arriendo</a></li>
                                <li class="divider"></li>
                                <li><a href="#">Alquiler De Inmuebles</a></li>
                            </ul>
                        </li>                        
                    </ul>
                </div>
            </div>
        </nav>
        <div class="container-fluid text-center">
            <div class="row content">
                <div class="col-sm-2 sidenav" style="left: 0px; top: 0px">
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
                        <div class="input-group">
                            <div class="col-lg-3">
                                <asp:Label ID="lblTipoOferta" runat="server" Text="Tipo de Oferta"></asp:Label>
                                <asp:DropDownList ID="ddlTipoOferta" class="btn btn-default dropdown-toggle" data-toggle="dropdown" Style="width: 100%" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlTipoOferta_SelectedIndexChanged"></asp:DropDownList>
                            </div>
                            <div class="col-lg-3">
                                <asp:Label ID="lblTipoInmueble" Style="width: 100%" runat="server" Text="Tipo de inmueble"></asp:Label>
                                <asp:DropDownList ID="ddlTipoInmueble" class="btn btn-default dropdown-toggle" data-toggle="dropdown" Style="width: 100%" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlTipoInmueble_SelectedIndexChanged"></asp:DropDownList>
                            </div>
                            <div class="col-lg-3">
                                <asp:Label ID="LblUbicacion" runat="server" Text="Ubicacion"></asp:Label>
                                <asp:DropDownList ID="ddlUbicacion" class="btn btn-default dropdown-toggle" data-toggle="dropdown" Style="width: 100%" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlUbicacion_SelectedIndexChanged"></asp:DropDownList>
                            </div>                            
                        </div>
                    </div>
                    <section class="row">
                        <p></p>
                    </section>
                    <div class="container-fluid">
                        <div class="col-sm-2"></div>
                        <div class="col-lg-8" id="myWorkContent">
                            <asp:GridView ID="gvConsultarInmuebles" data-toggle="modal" data-target="#myModal" class="table table-bordered bs-table" runat="server" OnSelectedIndexChanged="gvConsultarInmuebles_SelectedIndexChanged">
                                <Columns>
                                    <asp:ButtonField CommandName="Select"  ControlStyle-CssClass="btn btn-info" Text="Ver Información" />
                                </Columns>
                            </asp:GridView>
                        </div>

                        <div class="modal fade" id="myModal" role="dialog">
                            <div class="modal-dialog">
                                <!-- Modal content-->
                                <div class="modal-content">
                                    <div class="modal-header">
                                        <button type="button" class="close" data-dismiss="modal">&times;</button>
                                        <h4 class="modal-title">Descripcion del Inmueble</h4>
                                    </div>
                                    <div class="modal-body" style="text-align:left">                                    
                                            <asp:Label ID="Label1" runat="server" Text="Habitaciones: "></asp:Label>
                                            <asp:Label ID="lblHabitaciones" runat="server" Text=""></asp:Label>
                                            <hr />
                                            <asp:Label ID="Label2" runat="server" Text="Baños: "></asp:Label>
                                            <asp:Label ID="lblBaños" runat="server" Text=""></asp:Label>
                                            <hr />
                                            <asp:Label ID="Label3" runat="server" Text="Pisos: "></asp:Label>
                                            <asp:Label ID="lblPisos" runat="server" Text=""></asp:Label>
                                            <hr />
                                             <hr />
                                            <asp:Label ID="Label8" runat="server" Text="Valor Administración: "></asp:Label>
                                            <asp:Label ID="lblValorAdministracion" runat="server" Text=""></asp:Label>
                                            <hr />
                                            <hr />
                                            <asp:Label ID="Label6" runat="server" Text="Clima: "></asp:Label>
                                            <asp:Label ID="lblClima" runat="server" Text=""></asp:Label>
                                            <hr />
                                            <asp:Label ID="Label4" runat="server" Text="Caracteristicas Interiores: "></asp:Label>
                                            <br />
                                            <asp:Label ID="lblCaracteristicasInteriores" runat="server" Text=""></asp:Label>
                                            <hr />
                                            <asp:Label ID="Label5" runat="server" Text="Caracteristicas Exteriores: "></asp:Label>
                                            <br />
                                            <asp:Label ID="lblCaracteristicasExteriores" runat="server" Text=""></asp:Label>
                                            <hr />
                                            <asp:Label ID="Label7" runat="server" Text="Sector: "></asp:Label>
                                            <br />
                                            <asp:Label ID="lblSector" runat="server" Text=""></asp:Label>
                                            <hr />
                                            <asp:Label ID="Label9" runat="server" Text="Comentarios:"></asp:Label>
                                            <br />
                                            <asp:Label ID="lblComentarios" runat="server" Text=""></asp:Label>
                                            <hr />
                                            <asp:Label ID="Label10" runat="server" Text="Contacto:"></asp:Label>
                                            <asp:Label ID="lblContacto" runat="server" Text="Contáctese Con La Inmobiliaria 3132440181"></asp:Label>
                                        </div>                                    
                                    <div class="modal-footer">
                                        <button type="button" class="btn btn-default" data-dismiss="modal">Close</button>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="col-sm-2"></div>
                    </div>
                </div>
                <div class="col-sm-2 sidenav"></div>
            </div>
        </div>
    </form>
</body>
</html>
