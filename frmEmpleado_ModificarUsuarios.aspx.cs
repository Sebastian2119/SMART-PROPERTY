using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace SmartPropertySIW
{
    public partial class frmEmpleado_ModificarUsuarios : System.Web.UI.Page
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
                cargarddlTipoDocumento();
                cargarddlGenero();
                cargarddlUbicacionResidencia();
                cargarddlRol();
                cargargvDatosUsuario();
            }
        }        
        public void cerrar()
        {
            Session.Abandon();
            Response.Redirect("frmindex.aspx");
        }
        public void cargarddlTipoDocumento()
        {
            DataTable dtTipoDocumento = conexionModUs.cargarTipoDocumento();
            ddlTipoDocumento.DataSource = dtTipoDocumento;
            ddlTipoDocumento.DataTextField = "tipoDocumento";
            ddlTipoDocumento.DataValueField = "idTipoDocumento";
            ddlTipoDocumento.DataBind();
            ddlTipoDocumento.Items.Insert(0, new ListItem("Seleccionar:", "0"));
        }
        public void cargarddlGenero()
        {
            DataTable dtGenero = conexionModUs.cargarGenero();
            ddlGenero.DataSource = dtGenero;
            ddlGenero.DataTextField = "tipoGenero";
            ddlGenero.DataValueField = "idGenero";
            ddlGenero.DataBind();
            ddlGenero.Items.Insert(0, new ListItem("Seleccionar:", "0"));
        }
        private void cargarddlUbicacionResidencia()
        {
            DataTable dtUbicacionResidencia = conexionModUs.cargarUbicacion();
            ddlCiudadRecidencia.DataSource = dtUbicacionResidencia;
            ddlCiudadRecidencia.DataTextField = "Ciudad";
            ddlCiudadRecidencia.DataValueField = "idCiudad";
            ddlCiudadRecidencia.DataBind();
            ddlCiudadRecidencia.Items.Insert(0, new ListItem("Seleccionar:", "0"));
        }
        private void cargarddlRol()
        {
            DataTable dtRol = conexionModUs.cargarRolcpEmpleado();
            ddlTipoUsuario.DataSource = dtRol;
            ddlTipoUsuario.DataTextField = "tipoRol";
            ddlTipoUsuario.DataValueField = "idRol";
            ddlTipoUsuario.DataBind();
            ddlTipoUsuario.Items.Insert(0, new ListItem("Seleccionar:", "0"));
        }
        private void cargargvDatosUsuario()
        {
            DataTable dtDatosUsuario = conexionModUs.CargarDatosUsuariocpEmpleado();
            gvDatosUsuarios.DataSource = dtDatosUsuario;
            gvDatosUsuarios.DataBind();
        }
        
        public void gvDatosUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            CapaDatos.Conexion conexionModUs = new CapaDatos.Conexion();
            GridViewRow row = gvDatosUsuarios.SelectedRow;
            gvDatosUsuarios.SelectedRow.BackColor = System.Drawing.Color.Beige;
            string codigo = row.Cells[3].Text;
            int id;
            id = int.Parse(codigo);
            Session["id"] = id;
            id = (int)(Session["id"]);
            lblMensaje.Visible = false;

            DataTable dtCargarcampos = new DataTable();
            dtCargarcampos = conexionModUs.SelecionarId(int.Parse(codigo));

            if (dtCargarcampos.Rows.Count > 0)
            {
                txtNombres.Text = dtCargarcampos.Rows[0]["nombres"].ToString();
                txtApellidos.Text = dtCargarcampos.Rows[0]["apellidos"].ToString();
                ddlTipoDocumento.Text = dtCargarcampos.Rows[0]["codTipoDocumento"].ToString();
                txtDocumento.Text = dtCargarcampos.Rows[0]["documento"].ToString();
                txtFechaNacimiento.Text = dtCargarcampos.Rows[0]["fechaNacimiento"].ToString();
                ddlGenero.Text = dtCargarcampos.Rows[0]["codGenero"].ToString();
                ddlCiudadRecidencia.Text = dtCargarcampos.Rows[0]["codCiudad"].ToString();
                txtDireccion.Text = dtCargarcampos.Rows[0]["direccion"].ToString();
                txtNumeroCelular.Text = dtCargarcampos.Rows[0]["numeroCelular"].ToString();
                txtCorreo.Text = dtCargarcampos.Rows[0]["correo"].ToString();
                txtUsuario.Text = dtCargarcampos.Rows[0]["usuario"].ToString();
                txtContraseña.Text = dtCargarcampos.Rows[0]["contraseña"].ToString();
                ddlTipoUsuario.Text = dtCargarcampos.Rows[0]["codRol"].ToString();
            }              
        }        
        protected void gvDatosUsuarios_RowEditing(object sender, GridViewEditEventArgs e)
        {
            if(txtUsuario.Text == "")
            {
                lblMensaje.Text = "Debe Seleccionar Un Usuario Para Esta Operacion";
                lblMensaje.CssClass = "list-group-item list-group-item-danger";
            }
            else
            {
                conexionModUs.ActualizarUsuario((int)(Session["id"]), txtNombres.Text, txtApellidos.Text, int.Parse(ddlTipoDocumento.Text), txtDocumento.Text, DateTime.Parse(txtFechaNacimiento.Text), int.Parse(ddlGenero.Text), int.Parse(ddlCiudadRecidencia.Text), txtDireccion.Text, txtNumeroCelular.Text, int.Parse(ddlTipoUsuario.Text), txtCorreo.Text, txtUsuario.Text, txtContraseña.Text);
                lblMensajeOK.Text = "Datos De Usuario Actualizados Correctamente";
                lblMensajeOK.CssClass = "list-group-item list-group-item-success";
                btnContinuar.Visible = true;
            }            
        }
        protected void gvDatosUsuarios_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            if(txtUsuario.Text == "")
            {
                lblMensaje.Text = "Debe Seleccionar Un Usuario Para Esta Operacion";
                lblMensaje.CssClass = "list-group-item list-group-item-danger";
            }
            else
            {
                conexionModUs.EliminarUsuario((int)(Session["id"]));
                lblMensajeOK.Text = "Datos De Usuario Eliminados Correctamente";
                lblMensajeOK.CssClass = "list-group-item list-group-item-success";
                btnContinuar.Visible = true;
            }            
        }

        protected void btnContinuar_Click(object sender, EventArgs e)
        {
            Response.Redirect("frmEmpleado_ModificarUsuarios.aspx");
        }
    }
}