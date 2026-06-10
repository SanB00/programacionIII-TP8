using Entidades;
using Negocio;
using System;
using System.Web.UI.WebControls;

namespace Vistas {
    public partial class AgregarSucursal : System.Web.UI.Page {
        NegocioProvincia objNegocioProvincia = new NegocioProvincia();
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "<Pending>")]
        protected void Page_Load(object sender, EventArgs e) {

            if (!IsPostBack) {
                this.cargarProvincias();
            }
        }

        private void cargarProvincias() {
            ddlProvincias.Items.Clear();
            ddlProvincias.DataSource = objNegocioProvincia.getTabla();
            ddlProvincias.DataTextField = "DescripcionProvincia";
            ddlProvincias.DataValueField = "Id_Provincia";
            ddlProvincias.DataBind();

            ddlProvincias.Items.Insert(0, new ListItem("-- Seleccione --", "0"));
        }
    }
}