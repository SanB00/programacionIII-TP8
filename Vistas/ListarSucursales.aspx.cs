using Negocio;
using System;
using System.Data;

namespace Vistas {
    public partial class ListarSucursales : System.Web.UI.Page {
        NegocioSucursal objNegocioSucursal = new NegocioSucursal();

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "<Pending>")]
        protected void Page_Load(object sender, EventArgs e) {
            if (!IsPostBack) {
                cargarListaSucursales();
            }
        }

        private void cargarListaSucursales() {
            DataTable dataTable = objNegocioSucursal.getTabla();
            gvSucursales.DataSource = dataTable;
            gvSucursales.DataBind();
            lblCantResultados.Text = $"Hay {dataTable.Rows.Count} resultado/s";
        }
    }
}