using System;

namespace Vistas
{
    public partial class Principal : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e) {
            lnkAgregarSucursal.NavigateUrl = "~/AgregarSucursal.aspx";
            lnkListadoDeSucursales.NavigateUrl = "~/ListadoDeSucursales.aspx";
            lnkEliminarSucursal.NavigateUrl = "~/EliminarSucursal.aspx";
        }
    }
}