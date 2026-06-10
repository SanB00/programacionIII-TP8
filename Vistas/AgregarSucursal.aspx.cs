using Entidades;
using Negocio;
using System;
using System.Drawing;
using System.Web.UI.WebControls;

namespace Vistas {
    public partial class AgregarSucursal : System.Web.UI.Page {

        NegocioProvincia objNegocioProvincia = new NegocioProvincia();
        NegocioSucursal objNegocioSucursal = new NegocioSucursal();

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

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Trim() == "" ||
                txtDescripcion.Text.Trim() == "" ||
                txtDireccion.Text.Trim() == "" ||
                ddlProvincias.SelectedValue == "0") {

                lblMensaje.Text = "Debe completar todos los campos.";
                return;
            }
            string nombre = txtNombre.Text.Trim();
            string descripcion = txtDescripcion.Text.Trim();
            string direccion = txtDireccion.Text.Trim();
            int idProvincia = Convert.ToInt32(ddlProvincias.SelectedValue);

            bool agregado = objNegocioSucursal.agregarSucursal(
                nombre,
                descripcion,
                direccion,
                idProvincia
            );

            if (agregado) {
                lblMensaje.ForeColor = Color.Green;
                lblMensaje.Text = "La sucursal se ha agregado con éxito.";
                limpiarControles();
            } else {
                lblMensaje.ForeColor = Color.Red;
                lblMensaje.Text = "No se pudo agregar la sucursal. Verifique si ya existe.";
            }
        }
        private void limpiarControles() {
            txtNombre.Text = "";
            txtDescripcion.Text = "";
            txtDireccion.Text = "";
            ddlProvincias.SelectedIndex = 0;
        }
    }
}