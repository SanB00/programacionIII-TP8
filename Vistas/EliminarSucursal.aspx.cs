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

            string strIdSucursal = Common.eliminarEspaciosDelTexto(txtIdSucursal.Text);
            if (!Common.esUnNroValidoMayorACero(strIdSucursal)) {
                Common.mostrarMensajeEnAlerta("Por favor, ingrese un número válido mayor a cero para poder eliminar por ID sucursal.", this);
                return;
            }
            int idSucursal = int.Parse(strIdSucursal);

            bool eliminado = negocio.eliminarSucursal(idSucursal);

            if (eliminado) {
                lblMensaje.Text = "Sucursal eliminada correctamente";
            } else {
                lblMensaje.Text = "No se pudo eliminar la sucursal";
            }
        }
    }
}