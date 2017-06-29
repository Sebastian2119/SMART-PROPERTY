using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace SmartPropertySIW.Formularios
{
    public partial class frmAdministrador_ConsultarInmuebles : System.Web.UI.Page
    {
        CapaDatos.Conexion conexionModUs = new CapaDatos.Conexion();
        protected void Page_Load(object sender, EventArgs e)
        {
            if ((Session["idUsuario"]) != null)
                Session["idUsuario"].ToString();
            else
                Response.Redirect("frmindex.aspx");

            if (!Page.IsPostBack)
            {

            }
        }
        public void cerrar()
        {
            Session.Abandon();
            Response.Redirect("frmindex.aspx");
        }

        protected void btnBuscarInmueble_Click(object sender, EventArgs e)
        {
            if (TxtBuscarInmueble.Text == "")
            {
                lblMensaje.Text = "No se Encuentra el Inmueble o el campo esta vacio";
                lblMensaje.CssClass = "list-group-item list-group-item-danger";
            }                              
            else
            {
                lblMensaje.Visible = false;
                DataTable dtDatosInmueble = conexionModUs.BusquedaConsultarInmueble(TxtBuscarInmueble.Text);
                gvConsultarInmuebles.DataSource = dtDatosInmueble;
                gvConsultarInmuebles.DataBind();
            }
            
        }

        protected void btnBuscarInmuebleEncargado_Click(object sender, EventArgs e)
        {
            if (txtBuscarPorEncargado.Text == "")
            {
                lblMensaje2.Text = "No se Encuentra el Inmueble o el campo esta vacio";
                lblMensaje2.CssClass = "list-group-item list-group-item-danger";
            }
            else
            {
                lblMensaje2.Visible = false;
                DataTable dtDatosInmuebleE = conexionModUs.BusquedaConsultarInmuebleEncargado(txtBuscarPorEncargado.Text);
                gvConsultarInmueblesEncargado.DataSource = dtDatosInmuebleE;
                gvConsultarInmueblesEncargado.DataBind();
            }            
        }
    }
}