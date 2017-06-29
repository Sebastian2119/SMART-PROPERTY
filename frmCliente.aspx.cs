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
    public partial class frmCliente : System.Web.UI.Page
    {
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
    }   
}