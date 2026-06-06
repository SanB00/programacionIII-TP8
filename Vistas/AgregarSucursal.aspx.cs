using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Vistas {
    public partial class AgregarSucursal : System.Web.UI.Page {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "<Pending>")]
        protected void Page_Load(object sender, EventArgs e) {
            if (!IsPostBack) {
                cargarProvincias();
            }
        }
        private void cargarProvincias() {
            ddlProvincias.Items.Clear();
            ddlProvincias.DataSource = new NegocioProvincia().getAll();
            ddlProvincias.DataTextField = "DescripcionProvincia";
            ddlProvincias.DataValueField = "Id_Provincia";
            ddlProvincias.DataBind();
            ddlProvincias.Items.Insert(0, new ListItem("-- Seleccione --", "0"));
        }
    }
}