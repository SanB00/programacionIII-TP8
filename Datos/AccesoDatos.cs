using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class AccesoDatos
    {
        private string rutaBD = @"Data Source=localhost;Initial Catalog=BDSucursales;Integrated Security=True";
        //private string rutaBD = @"Data Source=localhost\sqlexpress;Initial Catalog=BDSucursales;Integrated Security=True";
        //private const string rutaBD = @"Initial Catalog=BDSucursales;Data Source=(localdb)\MSSQLLocalDB;Integrated Security=True";
        //private string rutaBD = @"Data Source =.\SQLEXPRESS;Initial Catalog = BDSucursales; Integrated Security = True;";
        public AccesoDatos() 
        {

        }

        private SqlConnection obtenerConexion()
        {
            SqlConnection cn = new SqlConnection(rutaBD);
            try
            {
                cn.Open();
                return cn;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        private SqlDataAdapter obtenerAdaptador(String consultaSql, SqlConnection cn)
        {
            SqlDataAdapter adaptador;
            try
            {
                adaptador = new SqlDataAdapter(consultaSql, cn);
                return adaptador;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public Boolean testConexion()
        {
            SqlConnection cn = obtenerConexion();
            if (cn != null)
            {
                cn.Close();
                return true;
            }
            return false;
        }
        public DataTable obtenerTabla(String nombreTabla, String sql)
        {
            DataSet ds = new DataSet();
            SqlConnection conexion = obtenerConexion();
            SqlDataAdapter adp = new SqlDataAdapter(sql, conexion);
            adp.Fill(ds, nombreTabla);
            conexion.Close();
            return ds.Tables[nombreTabla];
        }
        public int ejecutarProcedimientoAlmacenado(SqlCommand comando, String nombreSP)
        {
            int filasCambiadas;
            SqlConnection conexion = obtenerConexion();
            SqlCommand cmd = new SqlCommand();
            cmd = comando;
            cmd.Connection = conexion;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = nombreSP;
            filasCambiadas = cmd.ExecuteNonQuery();
            conexion.Close();
            return filasCambiadas;
        }

        public Boolean existe(String consulta)
        {
            Boolean estado = false;
            SqlConnection conexion = obtenerConexion();
            SqlCommand cmd = new SqlCommand(consulta, conexion);
            SqlDataReader datos = cmd.ExecuteReader();
            if (datos.Read())
            {
                estado = true;
            }
            return estado;
        }

        public int obtenerMaximo(String consulta)
        {
            int max = 0;
            SqlConnection conexion = obtenerConexion();
            SqlCommand cmd = new SqlCommand(consulta, conexion);
            SqlDataReader datos = cmd.ExecuteReader();
            if (datos.Read())
            {
                max = Convert.ToInt32(datos[0].ToString());
            }
            return max;
        }

    } 
} 