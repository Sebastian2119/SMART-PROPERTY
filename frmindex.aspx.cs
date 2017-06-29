using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace SmartPropertySIW.Formularios
{    
    public partial class frmindex : System.Web.UI.Page
    {
        CapaDatos.Conexion conexion = new CapaDatos.Conexion();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
                cargarddlTipoOferta();
                cargarTipoInmueble();
                cargarUbicacionInmueble();
            }
        }        

        protected void btnLogIn_Click(object sender, EventArgs e)
        {
            string usuario = this.txtUsuario.Text.Replace(";", "").Replace("--", "");
            string contraseña = this.txtContraseña.Text.Replace(";", "").Replace("--", "");

            if (conexion.LoginUsuario(txtUsuario.Text, txtContraseña.Text) == true)
            {
                DataTable dtPersona = conexion.ConsultarUsuario(usuario, contraseña);
                Session["codRolUsuario"] = dtPersona.Rows[0]["codRol"].ToString();
                Session["idUsuario"] = dtPersona.Rows[0]["idusuario"].ToString();

                int id = int.Parse(Session["idUsuario"].ToString());
                int roles = int.Parse(Session["codRolUsuario"].ToString());

                switch (roles)
                {
                    case 1:
                        {
                            Response.Redirect("frmAdministrador.aspx");
                            break;
                        }
                    case 2:
                        {
                            Response.Redirect("frmEmpleado.aspx");
                            break;
                        }
                    case 3:
                        {
                            Response.Redirect("frmCliente.aspx");
                            break;
                        }
                    default:
                        break;
                }
            }
            else
            {
                lblMensaje.Text = "Usuario o Contraseña Incorrectos";                
            }
        }
        private void cargarddlTipoOferta()
        {
            DataTable dtTipoOFerta = conexion.cargarTipoOferta();
            ddlTipoOferta.DataSource = dtTipoOFerta;
            ddlTipoOferta.DataTextField = "tipoOferta";
            ddlTipoOferta.DataValueField = "idOferta";
            ddlTipoOferta.DataBind();
            ddlTipoOferta.Items.Insert(0, new ListItem("Seleccionar", "0"));
        }
        private void cargarTipoInmueble()
        {
            DataTable dtTipoInmueble = conexion.cargarTipoInmueble();
            ddlTipoInmueble.DataSource = dtTipoInmueble;
            ddlTipoInmueble.DataTextField = "tipoInmueble";
            ddlTipoInmueble.DataValueField = "idTipoInmueble";
            ddlTipoInmueble.DataBind();
            ddlTipoInmueble.Items.Insert(0, new ListItem("Seleccionar:", "0"));
        }
        private void cargarUbicacionInmueble()
        {
            DataTable dtUbicacionInmueble = conexion.cargarUbicacion();
            ddlUbicacion.DataSource = dtUbicacionInmueble;
            ddlUbicacion.DataTextField = "Ciudad";
            ddlUbicacion.DataValueField = "idCiudad";
            ddlUbicacion.DataBind();
            ddlUbicacion.Items.Insert(0, new ListItem("Seleccionar:", "0"));
        }

        protected void ddlTipoOferta_SelectedIndexChanged(object sender, EventArgs e)
        {            
            Response.Redirect("frmVerInmuebles.aspx");
        }

        protected void ddlTipoInmueble_SelectedIndexChanged(object sender, EventArgs e)
        {
            Response.Redirect("frmVerInmuebles.aspx");

        }

        protected void ddlUbicacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            Response.Redirect("frmVerInmuebles.aspx");
        }
    }
}