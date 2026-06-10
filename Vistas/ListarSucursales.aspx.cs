using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Vistas
{
    public partial class ListarSucursales : System.Web.UI.Page
    {
        NegocioSucursal neg = new NegocioSucursal();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                grdSucursales.DataSource = neg.getTabla();
                grdSucursales.DataBind();
            }
        }
    }
}