using System;
using System.Data;

namespace Vistas
{
    public partial class ListadoDeSucursales : System.Web.UI.Page
    {

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "<Pending>")]
        protected void Page_Load(object sender, EventArgs e) {
            if (!IsPostBack) {
                cargarListaSucursales();
            }
        }

        private void cargarListaSucursales() {
            const string consultaSQL = "SELECT * FROM Sucursal";
            DataTable dataTable = new Conexion().ejecutarConsulta(consultaSQL);
            gvSucursales.DataSource = dataTable;
            gvSucursales.DataBind();
            lblCantResultados.Text = $"Hay {dataTable.Rows.Count} resultado/s";
        }
        private void cargarSucursalFiltrada() {
            string filtro = txtBusqueda.Text;
            if (string.IsNullOrEmpty(filtro.Trim())) {
                cargarListaSucursales();
                return;
            }

            int id;

            if (!int.TryParse(filtro, out id)) {
                gvSucursales.DataSource = null;
                gvSucursales.DataBind();
                txtBusqueda.Text = "";
                return;
            }

            string consultaSQL = "SELECT * FROM Sucursal WHERE Id_Sucursal = " + id;
            DataTable dataTable = new Conexion().ejecutarConsulta(consultaSQL);

            if (dataTable.Rows.Count == 0) {
                gvSucursales.DataSource = null;
                gvSucursales.DataBind();

                lblError.Visible = true;

                txtBusqueda.Text = "";
                return;
            }

            lblError.Visible = false;
            gvSucursales.DataSource = dataTable;
            gvSucursales.DataBind();
            lblCantResultados.Text = $"Hay {dataTable.Rows.Count} resultado/s";
            txtBusqueda.Text = "";
        }

        protected void btnFiltrar_Click(object sender, EventArgs e) {
            cargarSucursalFiltrada();
            txtBusqueda.Text = "";
        }

        /*private void validarFiltro() {
            string strFiltro = Common.eliminarEspaciosDelTexto(txtFiltro.Text);
        }*/

        protected void btnMostrarTodos_Click1(object sender, EventArgs e) {
            txtBusqueda.Text = "";
            lblError.Visible = false;
            cargarListaSucursales();
        }

        //obtenerSucursalesPorNombre(string nombre)

    }
}