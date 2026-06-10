using System;

namespace Vistas {
    public partial class Principal : System.Web.UI.MasterPage {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "<Pending>")]
        protected void Page_Load(object sender, EventArgs e) {
            lnkAgregarSucursal.NavigateUrl = "~/AgregarSucursal.aspx";
            lnkListarSucursales.NavigateUrl = "~/ListarSucursales.aspx";
            lnkEliminarSucursal.NavigateUrl = "~/EliminarSucursal.aspx";
        }
    }
}