using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace SmartPropertySIW.Formularios
{
    public partial class frmVerInmuebles_Venta1 : System.Web.UI.Page
    {
        CapaDatos.Conexion conexion = new CapaDatos.Conexion();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                cargarddlTipoOferta();
                cargarTipoInmueble();
                cargarUbicacionInmueble();                
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
            DataTable dtDatosTipoInmueble = conexion.BusquedaFiltroOferta(int.Parse(ddlTipoOferta.Text));
            gvConsultarInmuebles.DataSource = dtDatosTipoInmueble;
            gvConsultarInmuebles.DataBind();
        }

        protected void ddlTipoInmueble_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dtDatosTipoInmueble = conexion.BusquedafiltroTipoInmueble(int.Parse(ddlTipoInmueble.Text));
            gvConsultarInmuebles.DataSource = dtDatosTipoInmueble;
            gvConsultarInmuebles.DataBind();
        }

        protected void ddlUbicacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dtDatosTipoInmueble = conexion.BusquedafiltroUbicacion(int.Parse(ddlUbicacion.Text));
            gvConsultarInmuebles.DataSource = dtDatosTipoInmueble;
            gvConsultarInmuebles.DataBind();
        }

        protected void gvConsultarInmuebles_SelectedIndexChanged(object sender, EventArgs e)
        {
            CapaDatos.Conexion conexionModIn = new CapaDatos.Conexion();
            GridViewRow row = gvConsultarInmuebles.SelectedRow;
            gvConsultarInmuebles.SelectedRow.BackColor = System.Drawing.Color.Beige;
            string codigo = row.Cells[10].Text;
            int id;
            id = int.Parse(codigo);
            Session["id"] = id;
            id = (int)(Session["id"]);           

            DataTable dtCargarcampos = new DataTable();
            dtCargarcampos = conexionModIn.SelecionarIdInmueble(int.Parse(codigo));

            if (dtCargarcampos.Rows.Count > 0)
            {                        
                lblValorAdministracion.Text = dtCargarcampos.Rows[0]["valorAdministracion"].ToString();
                lblHabitaciones.Text = dtCargarcampos.Rows[0]["habitaciones"].ToString();
                lblBaños.Text = dtCargarcampos.Rows[0]["baños"].ToString();
                lblPisos.Text = dtCargarcampos.Rows[0]["pisos"].ToString();
                lblClima.Text = dtCargarcampos.Rows[0]["clima"].ToString();               
                lblCaracteristicasInteriores.Text = dtCargarcampos.Rows[0]["caracteristicasInteriores"].ToString();
                lblCaracteristicasExteriores.Text = dtCargarcampos.Rows[0]["caracteristicasExteriotes"].ToString();
                lblSector.Text = dtCargarcampos.Rows[0]["sector"].ToString();
                lblComentarios.Text = dtCargarcampos.Rows[0]["comentarios"].ToString();
            }
        }
    }
}