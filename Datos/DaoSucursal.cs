using Entidades;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text.RegularExpressions;

namespace Datos {

    public class DaoSucursal {
        AccesoDatos ds = new AccesoDatos();
        const string CONSULTA_SUCURSAL = "" +
            "SELECT s.Id_Sucursal, s.NombreSucursal, s.DescripcionSucursal, " +
                "p.DescripcionProvincia AS PROVINCIA, s.DireccionSucursal " +
                "FROM Sucursal s " +
                "INNER JOIN Provincia p ON s.Id_ProvinciaSucursal = p.Id_Provincia";

        public Sucursal getSucursal(Sucursal sucu) {
            DataTable tabla = ds.ObtenerTabla("Sucursal", "Select * from sucursal where Id_sucursal=" + sucu.getIdSucursal());
            sucu.setIdSucursal(Convert.ToInt32(tabla.Rows[0][0].ToString()));
            sucu.setNombreSucursal(tabla.Rows[0][1].ToString());
            sucu.setDescripcionSucursal(tabla.Rows[0][2].ToString());
            return sucu;
        }

        public Boolean existeSucursal(Sucursal sucu) {
            String consulta = "Select * from sucursal where NombreSucursal='" + sucu.getNombreSucursal() + "'";
            return ds.existe(consulta);
        }

        public DataTable getTablaPorId(Sucursal obj) {
            return ds.ObtenerTabla("Sucursal", CONSULTA_SUCURSAL + " AND s.Id_sucursal=" + obj.getIdSucursal());
        }

        public DataTable getTablaSucursales() {
            return ds.ObtenerTabla("Sucursales", CONSULTA_SUCURSAL);
        }


        public int eliminarSucursal(Sucursal sucu) {
            SqlCommand comando = new SqlCommand();
            ArmarParametrosSucursalEliminar(ref comando, sucu);
            return ds.EjecutarProcedimientoAlmacenado(comando, "spEliminarSucursal");
        }


        public int agregarSucursal(Sucursal sucu) {
            sucu.setIdSucursal(ds.ObtenerMaximo("SELECT max(ID_SUCURSAL) FROM Sucursal") + 1);
            SqlCommand comando = new SqlCommand();
            ArmarParametrosSucursalAgregar(ref comando, sucu);
            return ds.EjecutarProcedimientoAlmacenado(comando, "spAgregarSucursal");
        }

        private void ArmarParametrosSucursalEliminar(ref SqlCommand Comando, Sucursal sucu) {
            SqlParameter SqlParametros = new SqlParameter();
            SqlParametros = Comando.Parameters.Add("@ID_SUCURSAL", SqlDbType.Int);
            SqlParametros.Value = sucu.getIdSucursal();
        }

        private void ArmarParametrosSucursalAgregar(ref SqlCommand Comando, Sucursal sucu) {
            SqlParameter SqlParametros = new SqlParameter();

            SqlParametros = Comando.Parameters.Add("@ID_SUCURSAL", SqlDbType.Int);
            SqlParametros.Value = sucu.getIdSucursal();

            SqlParametros = Comando.Parameters.Add("@NombreSucursal", SqlDbType.VarChar);
            SqlParametros.Value = sucu.getNombreSucursal();

            SqlParametros = Comando.Parameters.Add("@DescripcionSucursal", SqlDbType.VarChar);
            SqlParametros.Value = sucu.getDescripcionSucursal();

            SqlParametros = Comando.Parameters.Add("@DireccionSucursal", SqlDbType.VarChar);
            SqlParametros.Value = sucu.getDireccionSucursal();

            SqlParametros = Comando.Parameters.Add("@Id_ProvinciaSucursal", SqlDbType.Int);
            SqlParametros.Value = sucu.getIdProvinciaSucursal();
        }
    }

    /*
    CREATE PROCEDURE dbo.spEliminarSucursal
    (
        @ID_SUCURSAL INT
    )
    AS
    BEGIN
        DELETE FROM Sucursal
        WHERE ID_SUCURSAL = @ID_SUCURSAL
    END
    GO
     */

    /*
   CREATE PROCEDURE dbo.spAgregarSucursal
    (
        @ID_SUCURSAL INT,
        @NombreSucursal NVARCHAR(100)
    )
    AS
    BEGIN
        INSERT INTO Sucursal (ID_SUCURSAL, NombreSucursal)
        VALUES (@ID_SUCURSAL, @NombreSucursal)
    END
    GO
    */
}