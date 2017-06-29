using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace SmartPropertySIW.Formularios
{
    public partial class frmEmpleado_ConsultarUsuarios : System.Web.UI.Page
    {
        CapaDatos.Conexion conexionModUs = new CapaDatos.Conexion();
        protected void Page_Load(object sender, EventArgs e)
        {
            if ((Session["idUsuario"]) != null)
                Session["idUsuario"].ToString();
            else
                Response.Redirect("frmindex.aspx");
        }
        public void cerrar()
        {
            Session.Abandon();
            Response.Redirect("frmindex.aspx");
        }

        protected void btnBuscarUsuario_Click(object sender, EventArgs e)
        {
            if (TxtBuscarUsuario.Text == "")
            {
                lblMensaje.Text = "No se Encuentra el usuario o el campo esta vacio";
                lblMensaje.CssClass = "list-group-item list-group-item-danger";
            }
            else
            {
                lblMensaje.Visible = false;
                DataTable dtDatosUsuario = conexionModUs.BusquedaConsultarUsuarioCpEmpleado(int.Parse(TxtBuscarUsuario.Text));
                gvConsultarUsuarios.DataSource = dtDatosUsuario;
                gvConsultarUsuarios.DataBind();
            }            
        }
    }
}
