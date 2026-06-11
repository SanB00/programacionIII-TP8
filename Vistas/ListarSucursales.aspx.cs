using Negocio;
using System;
using System.Data;
using System.Text.RegularExpressions;


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

        protected void btnFiltrar_Click(object sender, EventArgs e) {
            string strIdSucursal = Common.eliminarEspaciosDelTexto(txtBusqueda.Text);
            if (!Common.esUnNroValidoMayorACero(strIdSucursal)) {
                Common.mostrarMensajeEnAlerta("Por favor, ingrese un número válido mayor a cero para filtrar por ID sucursal.", this);
                cargarListaSucursales();
                return;
            }
            int idProvincia = int.Parse(strIdSucursal);
            /// Sucursal objSucursal = objNegocioSucursal.get(idProvincia);
            DataTable dataTable = objNegocioSucursal.getPorId(idProvincia);
            gvSucursales.DataSource = dataTable;
            gvSucursales.DataBind();
            lblCantResultados.Text = $"Hay {dataTable.Rows.Count} resultado/s";
        }
        protected void btnMostrarTodos_Click(object sender, EventArgs e) {
            txtBusqueda.Text = "";
            cargarListaSucursales();
        }
    }

    public class Common {
        public static string eliminarEspaciosDelTexto(string texto) {
            return Regex.Replace(texto.Trim(), @"\s+", " ");
        }
        public static bool esUnNroValidoMayorACero(string texto) {
            return int.TryParse(texto, out int nroValidar) && nroValidar > 0; //texto.All(char.IsDigit)
        }
        public static void mostrarMensajeEnAlerta(string mensaje, System.Web.UI.Page page) {
            string safeMessage = mensaje.Replace("'", "\\'").Replace("\n", "\\n");
            page.ClientScript.RegisterStartupScript(page.GetType(),
                "alert",
                $"alert('{safeMessage}');",
                true);
        }
    }
}