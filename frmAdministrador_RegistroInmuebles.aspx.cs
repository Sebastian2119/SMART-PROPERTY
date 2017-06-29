using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.IO;

namespace SmartPropertySIW.Formularios
{
    public partial class frmRegistroInmuebles : System.Web.UI.Page
    {

        CapaDatos.Conexion conexionIn = new CapaDatos.Conexion();
        protected void Page_Load(object sender, EventArgs e)
        {
            if ((Session["idUsuario"]) != null)
                Session["idUsuario"].ToString();
            else
                Response.Redirect("frmindex.aspx");

            if (!Page.IsPostBack)
            {
                cargarddlTipoOferta();
                cargarTipoInmueble();
                cargarUbicacionInmueble();
                cargarEstadoInmueble();
            }            
        }        
        public void cerrar()
        {
            Session.Abandon();
            Response.Redirect("frmindex.aspx");
        }
        private void cargarddlTipoOferta()
        {
            DataTable dtTipoOFerta = conexionIn.cargarTipoOferta();
            ddlTipoOferta.DataSource = dtTipoOFerta;
            ddlTipoOferta.DataTextField = "tipoOferta";
            ddlTipoOferta.DataValueField = "idOferta";
            ddlTipoOferta.DataBind();
            ddlTipoOferta.Items.Insert(0, new ListItem("Seleccionar", "0"));
        }
        private void cargarTipoInmueble()
        {
            DataTable dtTipoInmueble = conexionIn.cargarTipoInmueble();
            ddlTipoInmueble.DataSource = dtTipoInmueble;
            ddlTipoInmueble.DataTextField = "tipoInmueble";
            ddlTipoInmueble.DataValueField = "idTipoInmueble";
            ddlTipoInmueble.DataBind();
            ddlTipoInmueble.Items.Insert(0, new ListItem("Seleccionar:", "0"));
        }
        private void cargarUbicacionInmueble()
        {
            DataTable dtUbicacionInmueble = conexionIn.cargarUbicacion();
            ddlUbicacion.DataSource = dtUbicacionInmueble;
            ddlUbicacion.DataTextField = "Ciudad";
            ddlUbicacion.DataValueField = "idCiudad";
            ddlUbicacion.DataBind();
            ddlUbicacion.Items.Insert(0, new ListItem("Seleccionar:", "0"));
        }
        private void cargarEstadoInmueble()
        {
            DataTable dtEstadoInmueble = conexionIn.cargarEstadoInmueble();
            ddlEstado.DataSource = dtEstadoInmueble;
            ddlEstado.DataTextField = "Descripcion";
            ddlEstado.DataValueField = "idEstado";
            ddlEstado.DataBind();
            ddlEstado.Items.Insert(0, new ListItem("Seleccionar:", "0"));
        }
        protected void btnContinuar_Click(object sender, EventArgs e)
        {
            Response.Redirect("frmAdministrador_RegistroInmuebles.aspx");
        }
        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            if (txtCaracteristicasInteriores.Text == ""  )
            {
                lblMensaje2.Visible = true;
                lblMensaje2.Text = "No Se Admiten Campos Vacios";
                lblMensaje2.CssClass = "list-group-item list-group-item-danger";
            }
            if (txtCaracteristicasExteriores.Text == "")
            {
                lblMensaje2.Visible = true;
                lblMensaje2.Text = "No Se Admiten Campos Vacios";
                lblMensaje2.CssClass = "list-group-item list-group-item-danger";
            }
            if (txtSector.Text == "")
            {
                lblMensaje2.Visible = true;
                lblMensaje2.Text = "No Se Admiten Campos Vacios";
                lblMensaje2.CssClass = "list-group-item list-group-item-danger";
            }
            else
            {
                lblMensaje2.Visible = false;                
                btnEnviar.Visible = false;
                conexionIn.RegistrarInmueble(txtNombresCliente.Text, txtApellidosCliente.Text, txtCelularCliente.Text, txtDireccionCliente.Text, int.Parse(ddlTipoOferta.Text), int.Parse(ddlTipoInmueble.Text), int.Parse(ddlUbicacion.Text), txtBarrio.Text, txtDireccion.Text, ddlZona.Text, decimal.Parse(txtPrecioAvaluado.Text), decimal.Parse(txtPrecioCliente.Text), txtArea.Text, txtEstrato.Text, decimal.Parse(txtValorAdministracion.Text), txtHabitaciones.Text, txtBaños.Text, txtPisos.Text, ddlClima.Text, int.Parse(ddlEstado.Text), txtCaracteristicasInteriores.Text, txtCaracteristicasExteriores.Text, txtSector.Text, txtComentarios.Text, int.Parse(Session["idUsuario"].ToString()));
                lblMensajeOK.Text = "Inmueble Registrado Exitosamente";
                lblMensajeOK.CssClass = "list-group-item list-group-item-success";
                btnContinuar.Visible = true;
            }        
        }
        //-->Botones Caracteristicas Interiores
        //_________________________________________________________________________________________________________________________________________
        protected void btnAlarma_Click(object sender, EventArgs e)
        {
            txtCaracteristicasInteriores.Text = " |Alarma" + txtCaracteristicasInteriores.Text;
            btnAlarma.Enabled = false;
            btnAlarma.CssClass = "btn btn-primary disabled";
            txtCaracteristicasInteriores.Focus();
        }

        protected void btnAireAcondicionado_Click(object sender, EventArgs e)
        {
            txtCaracteristicasInteriores.Text = " |Aire Acondicionado" + txtCaracteristicasInteriores.Text;
            btnAireAcondicionado.Enabled = false;
            btnAireAcondicionado.CssClass = "btn btn-primary disabled";
            txtCaracteristicasInteriores.Focus();
        }

        protected void btnInstalaciónDeAgua_Click(object sender, EventArgs e)
        {
            txtCaracteristicasInteriores.Text = " |Instalación De Agua" + txtCaracteristicasInteriores.Text;
            btnInstalaciónDeAgua.Enabled = false;
            btnInstalaciónDeAgua.CssClass = "btn btn-primary disabled";
            txtCaracteristicasInteriores.Focus();
        }

        protected void btnInstalaciónDeEnergía_Click(object sender, EventArgs e)
        {
            txtCaracteristicasInteriores.Text = " |Instalación De Energía" + txtCaracteristicasInteriores.Text;
            btnInstalaciónDeEnergía.Enabled = false;
            btnInstalaciónDeEnergía.CssClass = "btn btn-primary disabled";
            txtCaracteristicasInteriores.Focus();
        }

        protected void btnInstalaciónDeGas_Click(object sender, EventArgs e)
        {
            txtCaracteristicasInteriores.Text = " |Instalación De Gas" + txtCaracteristicasInteriores.Text;
            btnInstalaciónDeGas.Enabled = false;
            btnInstalaciónDeGas.CssClass = "btn btn-primary disabled";
            txtCaracteristicasInteriores.Focus();
        }

        protected void btnCocinaIntegral_Click(object sender, EventArgs e)
        {
            txtCaracteristicasInteriores.Text = " |Cocina Integral" + txtCaracteristicasInteriores.Text;
            btnCocinaIntegral.Enabled = false;
            btnCocinaIntegral.CssClass = "btn btn-primary disabled";
            txtCaracteristicasInteriores.Focus();
        }

        protected void btnAmoblado_Click(object sender, EventArgs e)
        {
            txtCaracteristicasInteriores.Text = " |Amoblado" + txtCaracteristicasInteriores.Text;
            btnAmoblado.Enabled = false;
            btnAmoblado.CssClass = "btn btn-primary disabled";
            txtCaracteristicasInteriores.Focus();
        }

        protected void btnCalentador_Click(object sender, EventArgs e)
        {
            txtCaracteristicasInteriores.Text = " |Calentador" + txtCaracteristicasInteriores.Text;
            btnCalentador.Enabled = false;
            btnCalentador.CssClass = "btn btn-primary disabled";
            txtCaracteristicasInteriores.Focus();
        }

        protected void btnChimenea_Click(object sender, EventArgs e)
        {
            txtCaracteristicasInteriores.Text = " |Chimenea" + txtCaracteristicasInteriores.Text;
            btnChimenea.Enabled = false;
            btnChimenea.CssClass = "btn btn-primary disabled";
            txtCaracteristicasInteriores.Focus();
        }

        protected void btnCuartoDeServicio_Click(object sender, EventArgs e)
        {
            txtCaracteristicasInteriores.Text = " |Cuarto De Servicio" + txtCaracteristicasInteriores.Text;
            btnCuartoDeServicio.Enabled = false;
            btnCuartoDeServicio.CssClass = "btn btn-primary disabled";
            txtCaracteristicasInteriores.Focus();
        }

        protected void btnGaraje_Click(object sender, EventArgs e)
        {
            txtCaracteristicasInteriores.Text = " |Garaje" + txtCaracteristicasInteriores.Text;
            btnGaraje.Enabled = false;
            btnGaraje.CssClass = "btn btn-primary disabled";
            txtCaracteristicasInteriores.Focus();
        }

        protected void btnPatio_Click(object sender, EventArgs e)
        {
            txtCaracteristicasInteriores.Text = " |Patio" + txtCaracteristicasInteriores.Text;
            btnPatio.Enabled = false;
            btnPatio.CssClass = "btn btn-primary disabled";
            txtCaracteristicasInteriores.Focus();
        }

        protected void btnBalcon_Click(object sender, EventArgs e)
        {
            txtCaracteristicasInteriores.Text = " |Balcón" + txtCaracteristicasInteriores.Text;
            btnBalcon.Enabled = false;
            btnBalcon.CssClass = "btn btn-primary disabled";
            txtCaracteristicasInteriores.Focus();
        }

        protected void btnCuartoEstudio_Click(object sender, EventArgs e)
        {
            txtCaracteristicasInteriores.Text = " |Cuarto Estudio" + txtCaracteristicasInteriores.Text;
            btnCuartoEstudio.Enabled = false;
            btnCuartoEstudio.CssClass = "btn btn-primary disabled";
            txtCaracteristicasInteriores.Focus();
        }

        protected void btnDepositoBodega_Click(object sender, EventArgs e)
        {
            txtCaracteristicasInteriores.Text = " |Deposito/Bodega" + txtCaracteristicasInteriores.Text;
            btnDepositoBodega.Enabled = false;
            btnDepositoBodega.CssClass = "btn btn-primary disabled";
            txtCaracteristicasInteriores.Focus();
        }

        protected void btnPisosCeramica_Click(object sender, EventArgs e)
        {
            txtCaracteristicasInteriores.Text = " |Pisos Cerámica" + txtCaracteristicasInteriores.Text;
            btnPisosCeramica.Enabled = false;
            btnPisosCeramica.CssClass = "btn btn-primary disabled";
            txtCaracteristicasInteriores.Focus();
        }

        protected void btnPisosMadera_Click(object sender, EventArgs e)
        {
            txtCaracteristicasInteriores.Text = " |Pisos Madera" + txtCaracteristicasInteriores.Text;
            btnPisosMadera.Enabled = false;
            btnPisosMadera.CssClass = "btn btn-primary disabled";
            txtCaracteristicasInteriores.Focus();
        }

        protected void btnPisosCemento_Click(object sender, EventArgs e)
        {
            txtCaracteristicasInteriores.Text = " |Pisos Cemento" + txtCaracteristicasInteriores.Text;
            btnPisosCemento.Enabled = false;
            btnPisosCemento.CssClass = "btn btn-primary disabled";
            txtCaracteristicasInteriores.Focus();
        }
        //-->Botones Caracteristicas Exteriores
        //________________________________________________________________________________________________________
        protected void btnAscensor_Click(object sender, EventArgs e)
        {
            txtCaracteristicasExteriores.Text = " |Ascensor" + txtCaracteristicasExteriores.Text;
            btnAscensor.Enabled = false;
            btnAscensor.CssClass = "btn btn-primary disabled";
            txtCaracteristicasExteriores.Focus();
        }

        protected void btnConjuntoCerrado_Click(object sender, EventArgs e)
        {
            txtCaracteristicasExteriores.Text = " |Conjunto Cerrado" + txtCaracteristicasExteriores.Text;
            btnConjuntoCerrado.Enabled = false;
            btnConjuntoCerrado.CssClass = "btn btn-primary disabled";
            txtCaracteristicasExteriores.Focus();
        }

        protected void btnVigilancia_Click(object sender, EventArgs e)
        {
            txtCaracteristicasExteriores.Text = " |Vigilancia" + txtCaracteristicasExteriores.Text;
            btnVigilancia.Enabled = false;
            btnVigilancia.CssClass = "btn btn-primary disabled";
            txtCaracteristicasExteriores.Focus();
        }

        protected void btnPorteria_Click(object sender, EventArgs e)
        {
            txtCaracteristicasExteriores.Text = " |Portería" + txtCaracteristicasExteriores.Text;
            btnPorteria.Enabled = false;
            btnPorteria.CssClass = "btn btn-primary disabled";
            txtCaracteristicasExteriores.Focus();
        }

        protected void btnEstacionamiento_Click(object sender, EventArgs e)
        {
            txtCaracteristicasExteriores.Text = " |Estacionamiento" + txtCaracteristicasExteriores.Text;
            btnEstacionamiento.Enabled = false;
            btnEstacionamiento.CssClass = "btn btn-primary disabled";
            txtCaracteristicasExteriores.Focus();
        }

        protected void btnSalonComunal_Click(object sender, EventArgs e)
        {
            txtCaracteristicasExteriores.Text = " |Salón Comunal" + txtCaracteristicasExteriores.Text;
            btnSalonComunal.Enabled = false;
            btnSalonComunal.CssClass = "btn btn-primary disabled";
            txtCaracteristicasExteriores.Focus();
        }

        protected void btnZonasVerdes_Click(object sender, EventArgs e)
        {
            txtCaracteristicasExteriores.Text = " |Zonas Verdes" + txtCaracteristicasExteriores.Text;
            btnZonasVerdes.Enabled = false;
            btnZonasVerdes.CssClass = "btn btn-primary disabled";
            txtCaracteristicasExteriores.Focus();
        }

        protected void btnZonaInfantil_Click(object sender, EventArgs e)
        {
            txtCaracteristicasExteriores.Text = " |Zona Infantil" + txtCaracteristicasExteriores.Text;
            btnZonaInfantil.Enabled = false;
            btnZonaInfantil.CssClass = "btn btn-primary disabled";
            txtCaracteristicasExteriores.Focus();
        }

        protected void btnGimnacio_Click(object sender, EventArgs e)
        {
            txtCaracteristicasExteriores.Text = " |Gimnasio" + txtCaracteristicasExteriores.Text;
            btnGimnacio.Enabled = false;
            btnGimnacio.CssClass = "btn btn-primary disabled";
            txtCaracteristicasExteriores.Focus();
        }

        protected void btnJardin_Click(object sender, EventArgs e)
        {
            txtCaracteristicasExteriores.Text = " |Jardín" + txtCaracteristicasExteriores.Text;
            btnJardin.Enabled = false;
            btnJardin.CssClass = "btn btn-primary disabled";
            txtCaracteristicasExteriores.Focus();
        }

        protected void btnCanchasDeTennis_Click(object sender, EventArgs e)
        {
            txtCaracteristicasExteriores.Text = " |Canchas De Tennis" + txtCaracteristicasExteriores.Text;
            btnCanchasDeTennis.Enabled = false;
            btnCanchasDeTennis.CssClass = "btn btn-primary disabled";
            txtCaracteristicasExteriores.Focus();
        }

        protected void btnCanchasDeBaloncesto_Click(object sender, EventArgs e)
        {
            txtCaracteristicasExteriores.Text = " |Canchas De Baloncesto" + txtCaracteristicasExteriores.Text;
            btnCanchasDeBaloncesto.Enabled = false;
            btnCanchasDeBaloncesto.CssClass = "btn btn-primary disabled";
            txtCaracteristicasExteriores.Focus();
        }

        protected void btnCanchasDeFutbol_Click(object sender, EventArgs e)
        {
            txtCaracteristicasExteriores.Text = " |Canchas De Fútbol" + txtCaracteristicasExteriores.Text;
            btnCanchasDeFutbol.Enabled = false;
            btnCanchasDeFutbol.CssClass = "btn btn-primary disabled";
            txtCaracteristicasExteriores.Focus();
        }
        protected void btnOtros_Click(object sender, EventArgs e)
        {
            txtCaracteristicasExteriores.Text = " |Otros" + txtCaracteristicasExteriores.Text;
            btnOtros.Enabled = false;
            btnOtros.CssClass = "btn btn-primary disabled";
            txtCaracteristicasExteriores.Focus();
        }

        protected void btnPiscina_Click(object sender, EventArgs e)
        {
            txtCaracteristicasExteriores.Text = " |Piscina" + txtCaracteristicasExteriores.Text;
            btnPiscina.Enabled = false;
            btnPiscina.CssClass = "btn btn-primary disabled";
            txtCaracteristicasExteriores.Focus(); 
        }
        //-->Botones Sector
        //________________________________________________________________________________________________________
        protected void btnViaPrincipal_Click(object sender, EventArgs e)
        {
            txtSector.Text = " |Vía Principal" + txtSector.Text;
            btnViaPrincipal.Enabled = false;
            btnViaPrincipal.CssClass = "btn btn-primary disabled";
            txtSector.Focus();
        }

        protected void btnParquesCercanos_Click(object sender, EventArgs e)
        {
            txtSector.Text = " |Parques Cercanos" + txtSector.Text;
            btnParquesCercanos.Enabled = false;
            btnParquesCercanos.CssClass = "btn btn-primary disabled";
            txtSector.Focus();
        }

        protected void TransportePúblico_Click(object sender, EventArgs e)
        {
            txtSector.Text = " |Transporte Público" + txtSector.Text;
            TransportePúblico.Enabled = false;
            TransportePúblico.CssClass = "btn btn-primary disabled";
            txtSector.Focus();
        }

        protected void btnZonaComercial_Click(object sender, EventArgs e)
        {
            txtSector.Text = " |Zona Comercial" + txtSector.Text;
            btnZonaComercial.Enabled = false;
            btnZonaComercial.CssClass = "btn btn-primary disabled";
            txtSector.Focus();
        }

        protected void btnZonaIndustrial_Click(object sender, EventArgs e)
        {
            txtSector.Text = " |Zona Industrial" + txtSector.Text;
            btnZonaIndustrial.Enabled = false;
            btnZonaIndustrial.CssClass = "btn btn-primary disabled";
            txtSector.Focus();
        }

        protected void btnZonaResidencial_Click(object sender, EventArgs e)
        {
            txtSector.Text = " |Zona Residencial" + txtSector.Text;
            btnZonaResidencial.Enabled = false;
            btnZonaResidencial.CssClass = "btn btn-primary disabled";
            txtSector.Focus();
        }

        protected void btnColegios_Click(object sender, EventArgs e)
        {
            txtSector.Text = " |Colegios" + txtSector.Text;
            btnColegios.Enabled = false;
            btnColegios.CssClass = "btn btn-primary disabled";
            txtSector.Focus();
        }

        protected void btnUniversidades_Click(object sender, EventArgs e)
        {
            txtSector.Text = " |Universidades" + txtSector.Text;
            btnUniversidades.Enabled = false;
            btnUniversidades.CssClass = "btn btn-primary disabled";
            txtSector.Focus();
        }

        protected void btnSupermecados_Click(object sender, EventArgs e)
        {
            txtSector.Text = " |Supermercados" + txtSector.Text;
            btnSupermecados.Enabled = false;
            btnSupermecados.CssClass = "btn btn-primary disabled";
            txtSector.Focus();
        }
        protected void UploadFile(object sender, EventArgs e)
        {
            
        }
       
    }   
}