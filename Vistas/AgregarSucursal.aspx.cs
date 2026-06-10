using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using Entidades;
using Negocio;

namespace Vistas
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        NegocioProvincia neg = new NegocioProvincia();
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (!IsPostBack)
            {
                DataTable dtProv = neg.getTabla();

                ddlProvincia.DataSource = dtProv;
                ddlProvincia.DataTextField = "DescripcionProvincia";
                ddlProvincia.DataValueField = "Id_Provincia";
                ddlProvincia.DataBind();

                ddlProvincia.Items.Insert(0, new ListItem("-- Seleccione --", "0"));
            }
        }
    }
}