using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace SmartPropertySIW.Formularios
{
    public partial class frmAdministrador_Reportes : System.Web.UI.Page
    {
        CapaDatos.Conexion conexionReportes = new CapaDatos.Conexion();
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
        private void cargardatosUsuariosRegitrados()
        {
            DataTable dtDatosUsuario = conexionReportes.ReportesConsultarUsuariosRegistrados();
            gvConsultarReportes.DataSource = dtDatosUsuario;
            gvConsultarReportes.DataBind();                               
            lblInfo.Text = "Total Usuarios Registrados: " + dtDatosUsuario.Rows.Count.ToString();
            lblInfo.CssClass = "badge";
            
        }
        private void cargarDatoInmueblesRegistrados()
        {
            DataTable dtDatos = conexionReportes.ReportesConsultarInmueblesRegistrados();
            gvConsultarReportes.DataSource = dtDatos;
            gvConsultarReportes.DataBind();
            lblInfo.Text = "Total Inmuebles Registrados: " + dtDatos.Rows.Count.ToString();
            lblInfo.CssClass = "badge";
        }
        private void cargarDatoUsuariosEliminados()
        {
            DataTable dtDatos = conexionReportes.ReportesConsultarUsuariosEliminados();
            gvConsultarReportes.DataSource = dtDatos;
            gvConsultarReportes.DataBind();
            lblInfo.Text = "Total Usuarios Eliminados: " + dtDatos.Rows.Count.ToString();
            lblInfo.CssClass = "badge";
        }
        private void cargarDatoInmueblesEliminados()
        {
            DataTable dtDatos = conexionReportes.ReportesConsultarInmueblesEliminados();
            gvConsultarReportes.DataSource = dtDatos;
            gvConsultarReportes.DataBind();
            lblInfo.Text = "Total Inmuebles Eliminados: " + dtDatos.Rows.Count.ToString();
            lblInfo.CssClass = "badge";
        }
        private void cargarDatoInmueblesArrendados()
        {
            DataTable dtDatos = conexionReportes.ReportesConsultarInmueblesArrendados();
            gvConsultarReportes.DataSource = dtDatos;
            gvConsultarReportes.DataBind();
            lblInfo.Text = "Total Inmuebles Arrendados: " + dtDatos.Rows.Count.ToString();
            lblInfo.CssClass = "badge";
        }
        private void cargarDatoInmueblesVendidos()
        {
            DataTable dtDatos = conexionReportes.ReportesConsultarInmueblesVendidos();
            gvConsultarReportes.DataSource = dtDatos;
            gvConsultarReportes.DataBind();
            lblInfo.Text = "Total Inmuebles Vendidos: " + dtDatos.Rows.Count.ToString();
            lblInfo.CssClass = "badge";
        }

        private void cargarDatoInmueblesArriendo()
        {
            DataTable dtDatos = conexionReportes.ReportesConsultarInmueblesArriendo();
            gvConsultarReportes.DataSource = dtDatos;
            gvConsultarReportes.DataBind();
            lblInfo.Text = "Total Inmuebles En Arriendo: " + dtDatos.Rows.Count.ToString();
            lblInfo.CssClass = "badge";
        }
        private void cargarDatoInmueblesVenta()
        {
            DataTable dtDatos = conexionReportes.ReportesConsultarInmueblesVenta();
            gvConsultarReportes.DataSource = dtDatos;
            gvConsultarReportes.DataBind();
            lblInfo.Text = "Total Inmuebles En Venta: " + dtDatos.Rows.Count.ToString();
            lblInfo.CssClass = "badge";
        }
        private void cargarDatoInmueblesAlquiler()
        {
            DataTable dtDatos = conexionReportes.ReportesConsultarInmueblesAlquiler();
            gvConsultarReportes.DataSource = dtDatos;
            gvConsultarReportes.DataBind();
            lblInfo.Text = "Total Inmuebles En Alquiler: " + dtDatos.Rows.Count.ToString();
            lblInfo.CssClass = "badge";
        }


        protected void btnReporteUsuariosRegistrados_Click(object sender, EventArgs e)
        {
            btnReporteInmueblesEliminados.CssClass = "btn btn-success";
            btnReporteInmueblesVendidos.CssClass = "btn btn-success";
            btnReporteInmueblesArrendados.CssClass = "btn btn-info";
            btnReporteUsuariosEliminados.CssClass = "btn btn-info";
            btnReporteInmueblesRegistrados.CssClass = "btn btn-success";
            btnReporteUsuariosRegistrados.CssClass = "btn btn-primary";         
            cargardatosUsuariosRegitrados();
        }

        protected void btnReporteInmueblesRegistrados_Click(object sender, EventArgs e)
        {
            btnReporteInmueblesEliminados.CssClass = "btn btn-success";
            btnReporteInmueblesVendidos.CssClass = "btn btn-success";
            btnReporteInmueblesArrendados.CssClass = "btn btn-info";
            btnReporteUsuariosEliminados.CssClass = "btn btn-info";          
            btnReporteUsuariosRegistrados.CssClass = "btn btn-info";
            btnReporteInmueblesArriendo.CssClass = "btn btn-info";
            btnReporteInmueblesVenta.CssClass = "btn btn-success";
            btnReporteInmueblesAlquiler.CssClass = "btn btn-info";

            btnReporteInmueblesRegistrados.CssClass = "btn btn-primary";
            cargarDatoInmueblesRegistrados();
        }

        protected void btnReporteUsuariosEliminados_Click(object sender, EventArgs e)
        {
            btnReporteInmueblesEliminados.CssClass = "btn btn-success";
            btnReporteInmueblesVendidos.CssClass = "btn btn-success";
            btnReporteInmueblesArrendados.CssClass = "btn btn-info";            
            btnReporteUsuariosRegistrados.CssClass = "btn btn-info";
            btnReporteInmueblesRegistrados.CssClass = "btn btn-success";
            btnReporteInmueblesArriendo.CssClass = "btn btn-info";
            btnReporteInmueblesVenta.CssClass = "btn btn-success";
            btnReporteInmueblesAlquiler.CssClass = "btn btn-info";

            btnReporteUsuariosEliminados.CssClass = "btn btn-primary";
            cargarDatoUsuariosEliminados();
        }

        protected void btnReporteInmueblesArrendados_Click(object sender, EventArgs e)
        {
            btnReporteInmueblesEliminados.CssClass = "btn btn-success";
            btnReporteInmueblesVendidos.CssClass = "btn btn-success";            
            btnReporteUsuariosRegistrados.CssClass = "btn btn-info";
            btnReporteInmueblesRegistrados.CssClass = "btn btn-success";
            btnReporteUsuariosEliminados.CssClass = "btn btn-info";
            btnReporteInmueblesArriendo.CssClass = "btn btn-info";
            btnReporteInmueblesVenta.CssClass = "btn btn-success";
            btnReporteInmueblesAlquiler.CssClass = "btn btn-info";

            btnReporteInmueblesArrendados.CssClass = "btn btn-primary";
            cargarDatoInmueblesArrendados();
        }

        protected void btnReporteInmueblesVendidos_Click(object sender, EventArgs e)
        {
            btnReporteInmueblesEliminados.CssClass = "btn btn-success";            
            btnReporteUsuariosRegistrados.CssClass = "btn btn-info";
            btnReporteInmueblesRegistrados.CssClass = "btn btn-success";
            btnReporteUsuariosEliminados.CssClass = "btn btn-info";
            btnReporteInmueblesArrendados.CssClass = "btn btn-info";
            btnReporteInmueblesArriendo.CssClass = "btn btn-info";
            btnReporteInmueblesVenta.CssClass = "btn btn-success";
            btnReporteInmueblesAlquiler.CssClass = "btn btn-info";

            btnReporteInmueblesVendidos.CssClass = "btn btn-primary";
            cargarDatoInmueblesVendidos();
        }

        protected void btnReporteInmueblesEliminados_Click(object sender, EventArgs e)
        {            
            btnReporteUsuariosRegistrados.CssClass = "btn btn-info";
            btnReporteInmueblesRegistrados.CssClass = "btn btn-success";
            btnReporteUsuariosEliminados.CssClass = "btn btn-info";
            btnReporteInmueblesArrendados.CssClass = "btn btn-info";
            btnReporteInmueblesVendidos.CssClass = "btn btn-success";
            btnReporteInmueblesArriendo.CssClass = "btn btn-info";
            btnReporteInmueblesVenta.CssClass = "btn btn-success";
            btnReporteInmueblesAlquiler.CssClass = "btn btn-info";

            btnReporteInmueblesEliminados.CssClass = "btn btn-primary";
            cargarDatoInmueblesEliminados();
        }

        protected void btnReporteInmueblesArriendo_Click(object sender, EventArgs e)
        {
            btnReporteUsuariosRegistrados.CssClass = "btn btn-info";
            btnReporteInmueblesRegistrados.CssClass = "btn btn-success";
            btnReporteUsuariosEliminados.CssClass = "btn btn-info";
            btnReporteInmueblesArrendados.CssClass = "btn btn-info";
            btnReporteInmueblesVendidos.CssClass = "btn btn-success";
            btnReporteInmueblesEliminados.CssClass = "btn btn-success";            
            btnReporteInmueblesVenta.CssClass = "btn btn-success";
            btnReporteInmueblesAlquiler.CssClass = "btn btn-info";

            btnReporteInmueblesArriendo.CssClass = "btn btn-primary";
            cargarDatoInmueblesArriendo();
        }

        protected void btnReporteInmueblesVenta_Click(object sender, EventArgs e)
        {
            btnReporteUsuariosRegistrados.CssClass = "btn btn-info";
            btnReporteInmueblesRegistrados.CssClass = "btn btn-success";
            btnReporteUsuariosEliminados.CssClass = "btn btn-info";
            btnReporteInmueblesArrendados.CssClass = "btn btn-info";
            btnReporteInmueblesVendidos.CssClass = "btn btn-success";
            btnReporteInmueblesEliminados.CssClass = "btn btn-success";
            btnReporteInmueblesArriendo.CssClass = "btn btn-info";            
            btnReporteInmueblesAlquiler.CssClass = "btn btn-info";

            btnReporteInmueblesVenta.CssClass = "btn btn-primary";
            cargarDatoInmueblesVenta();
        }

        protected void btnReporteInmueblesAlquiler_Click(object sender, EventArgs e)
        {
            btnReporteUsuariosRegistrados.CssClass = "btn btn-info";
            btnReporteInmueblesRegistrados.CssClass = "btn btn-success";
            btnReporteUsuariosEliminados.CssClass = "btn btn-info";
            btnReporteInmueblesArrendados.CssClass = "btn btn-info";
            btnReporteInmueblesVendidos.CssClass = "btn btn-success";
            btnReporteInmueblesEliminados.CssClass = "btn btn-success";
            btnReporteInmueblesArriendo.CssClass = "btn btn-info";
            btnReporteInmueblesVenta.CssClass = "btn btn-success";

            btnReporteInmueblesAlquiler.CssClass = "btn btn-primary";            
            cargarDatoInmueblesAlquiler();
        }
    }
}