using Negocio;
using System;

namespace Vistas {
    public partial class EliminarSucursal : System.Web.UI.Page {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "<Pending>")]
        protected void Page_Load(object sender, EventArgs e) {
            lblMensaje.ForeColor = System.Drawing.Color.Red;
        }

        protected void btnEliminar_Click(object sender, EventArgs e) {
            NegocioSucursal negocio = new NegocioSucursal();

            int id = Convert.ToInt32(txtIdSucursal.Text);

            bool eliminado = negocio.eliminarSucursal(id);

            if (eliminado) {
                lblMensaje.Text = "Sucursal eliminada correctamente";
            } else {
                lblMensaje.Text = "No se pudo eliminar la sucursal";
            }
        }
    }
}