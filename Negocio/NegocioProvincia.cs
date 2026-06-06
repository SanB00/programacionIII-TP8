using Datos;
using System.Data;

namespace Negocio {
    public class NegocioProvincia {
        public NegocioProvincia() { }
        public DataTable getAll() {
            return new DaoProvincia().getAll();
        }
    }
}
