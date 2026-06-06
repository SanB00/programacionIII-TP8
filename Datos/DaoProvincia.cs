using System.Data;

namespace Datos {
    public class DaoProvincia {
        public DaoProvincia() {
        }

        public DataTable getAll() {
            string consultaSQL = "SELECT * FROM Provincia";
            return new Conexion().ejecutarConsulta(consultaSQL);
        }
    }
}
