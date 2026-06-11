using Entidades;
using System;
using System.Collections.Generic;
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
            DataTable tabla = ds.obtenerTabla("Sucursal", "Select * from sucursal where Id_sucursal=" + sucu.getIdSucursal());
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
            return ds.obtenerTabla("Sucursal", CONSULTA_SUCURSAL + " AND s.Id_sucursal=" + obj.getIdSucursal());
        }

        public DataTable getTablaSucursales() {
            return ds.obtenerTabla("Sucursales", CONSULTA_SUCURSAL);
        }

        public int eliminarSucursal(Sucursal sucu) {
            SqlCommand comando = new SqlCommand();
            armarParametrosSucursalEliminar(ref comando, sucu);
            return ds.ejecutarProcedimientoAlmacenado(comando, "spEliminarSucursal");
        }

        public int agregarSucursal(Sucursal sucu) {
            SqlCommand comando = new SqlCommand();
            armarParametrosSucursalAgregar(ref comando, sucu);
            return ds.ejecutarProcedimientoAlmacenado(comando, "spAgregarSucursal");
        }

        private void armarParametrosSucursalEliminar(ref SqlCommand comando, Sucursal sucu) {
            SqlParameter sqlParametros = new SqlParameter();
            sqlParametros = comando.Parameters.Add("@IdSucursal", SqlDbType.Int);
            sqlParametros.Value = sucu.getIdSucursal();
        }

        private void armarParametrosSucursalAgregar(ref SqlCommand comando, Sucursal sucu) {
            SqlParameter sqlParametros = new SqlParameter();

            sqlParametros = comando.Parameters.Add("@NombreSucursal", SqlDbType.VarChar);
            sqlParametros.Value = sucu.getNombreSucursal();

            sqlParametros = comando.Parameters.Add("@DescripcionSucursal", SqlDbType.VarChar);
            sqlParametros.Value = sucu.getDescripcionSucursal();

            sqlParametros = comando.Parameters.Add("@DireccionSucursal", SqlDbType.VarChar);
            sqlParametros.Value = sucu.getDireccionSucursal();

            sqlParametros = comando.Parameters.Add("@Id_ProvinciaSucursal", SqlDbType.Int);
            sqlParametros.Value = sucu.getIdProvinciaSucursal();
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
    ------------------------------------------
   MODIFICACION DEL PROCEDIMIENTO SQL (necesario ejecutar en sql para que compile)
    ------------------------------------------
    
    ALTER PROCEDURE spAgregarSucursal
    (
        @NombreSucursal VARCHAR(100),
        @DescripcionSucursal VARCHAR(100),
        @DireccionSucursal VARCHAR(100),
        @Id_ProvinciaSucursal INT
    )
    AS
    BEGIN
        INSERT INTO Sucursal
        (
            NombreSucursal,
            DescripcionSucursal,
            DireccionSucursal,
            Id_ProvinciaSucursal
        )
        VALUES
        (
            @NombreSucursal,
            @DescripcionSucursal,
            @DireccionSucursal,
            @Id_ProvinciaSucursal
        )
    END
    */
}