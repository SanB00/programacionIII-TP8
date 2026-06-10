using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DaoProvincia
    {
        AccesoDatos dp = new AccesoDatos();
        public Provincia getProvincia(Provincia prov)
        {
            DataTable tabla = dp.ObtenerTabla("Provincia", "Select * from Provincia where Id_Provincia=" + prov.getIdProvincia());
            prov.setIdProvincia(Convert.ToInt32(tabla.Rows[0][0].ToString()));
            prov.setDescripcionProvincia(tabla.Rows[0][1].ToString());
            return prov;
        }

        public Boolean existeProvincia(Provincia prov)
        {
            String consulta = "Select * from Provincia where DescripcionProvincia='" + prov.getDescripcionProvincia() + "'";
            return dp.existe(consulta);
        }

        public DataTable getTablaProvincia()
        {
            return dp.ObtenerTabla("Provincia", "SELECT Id_Provincia, DescripcionProvincia FROM Provincia ORDER BY DescripcionProvincia");
        }
    }
   
}
