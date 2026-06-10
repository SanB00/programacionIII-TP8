using Datos;
using Entidades;
using System.Data;

namespace Negocio {
    public class NegocioProvincia {
        public DataTable getTabla() {
            DaoProvincia dao = new DaoProvincia();
            return dao.getTablaProvincia();
        }
        public Provincia get(int id) {
            DaoProvincia dao = new DaoProvincia();
            Provincia prov = new Provincia();
            prov.setIdProvincia(id);
            return dao.getProvincia(prov);
        }

    }
}
