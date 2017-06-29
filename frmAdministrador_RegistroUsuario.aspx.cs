using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace SmartPropertySIW
{
    public partial class frmAdministrador_RegistroUsuario : System.Web.UI.Page
    {
        CapaDatos.Conexion conexionUs = new CapaDatos.Conexion();
        protected void Page_Load(object sender, EventArgs e)
        {
            if ((Session["idUsuario"]) != null)
                Session["idUsuario"].ToString();
            else
                Response.Redirect("frmindex.aspx");

            if (!Page.IsPostBack)
            {
                cargarddlTipoDocumento();
                cargarddlGenero();
                cargarddlUbicacionResidencia();
                cargarddlRol();
            }            
        }
        public void cerrar()
        {
            Session.Abandon();
            Response.Redirect("frmindex.aspx");
        }
        public void cargarddlTipoDocumento()
        {
            DataTable dtTipoDocumento = conexionUs.cargarTipoDocumento();
            ddlTipoDocumento.DataSource = dtTipoDocumento;
            ddlTipoDocumento.DataTextField = "tipoDocumento";
            ddlTipoDocumento.DataValueField = "idTipoDocumento";
            ddlTipoDocumento.DataBind();
            ddlTipoDocumento.Items.Insert(0, new ListItem("Seleccionar:", "0"));
        }
        public void cargarddlGenero()
        {
            DataTable dtGenero = conexionUs.cargarGenero();
            ddlGenero.DataSource = dtGenero;
            ddlGenero.DataTextField = "tipoGenero";
            ddlGenero.DataValueField = "idGenero";
            ddlGenero.DataBind();
            ddlGenero.Items.Insert(0, new ListItem("Seleccionar:", "0"));
        }
        private void cargarddlUbicacionResidencia()
        {
            DataTable dtUbicacionResidencia = conexionUs.cargarUbicacion();
            ddlCiudadRecidencia.DataSource = dtUbicacionResidencia;
            ddlCiudadRecidencia.DataTextField = "Ciudad";
            ddlCiudadRecidencia.DataValueField = "idCiudad";
            ddlCiudadRecidencia.DataBind();
            ddlCiudadRecidencia.Items.Insert(0, new ListItem("Seleccionar:", "0"));
        }
        private void cargarddlRol()
        {
            DataTable dtRol = conexionUs.cargarRol();
            ddlTipoUsuario.DataSource = dtRol;
            ddlTipoUsuario.DataTextField = "tipoRol";
            ddlTipoUsuario.DataValueField = "idRol";
            ddlTipoUsuario.DataBind();
            ddlTipoUsuario.Items.Insert(0, new ListItem("Seleccionar:", "0"));
        }
        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            if (txtContraseña.Text == txtConfirmarContraseña.Text)
            {
                btnEnviar.Visible = false;
                conexionUs.RegistrarUsuario(txtNombres.Text, txtApellidos.Text, int.Parse(ddlTipoDocumento.Text), txtDocumento.Text, DateTime.Parse(txtFechaNacimiento.Text), int.Parse(ddlGenero.Text), int.Parse(ddlCiudadRecidencia.Text), txtDireccion.Text, txtNumeroCelular.Text, int.Parse(ddlTipoUsuario.Text), txtCorreo.Text, txtUsuario.Text, txtContraseña.Text);
                lblMensajeOK.Text = "Usuario Registrado Exitosamente";
                lblMensajeOK.CssClass = "list-group-item list-group-item-success";
                btnContinuar.Visible = true;                
            }
            else
            {
                lblMensajeOK.Text = "Las Contraseñas No Coinciden";
                lblMensajeOK.CssClass = "list-group-item list-group-item-danger";
            }  
        }
        protected void btnContinuar_Click(object sender, EventArgs e)
        {
            Response.Redirect("frmAdministrador_RegistroUsuario.aspx");
        }
    }
}