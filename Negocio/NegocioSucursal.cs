using Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Entidades;
using System.Threading.Tasks;

namespace Negocio
{
    public class NegocioSucursal
    {
        public DataTable getTabla()
        {
            DaoSucursal dao = new DaoSucursal();
            return dao.getTablaSucursales();
        }
        public Sucursal get(int id)
        {
            DaoSucursal dao = new DaoSucursal();
            Sucursal sucu = new Sucursal();
            sucu.setIdSucursal(id);
            return dao.getSucursal(sucu);
        }

        public bool eliminarSucursal(int id)
        { 
            DaoSucursal dao = new DaoSucursal();
            Sucursal sucu = new Sucursal();
            sucu.setIdSucursal(id);
            int op = dao.eliminarSucursal(sucu);
            if (op == 1)
                return true;
            else
                return false;
        }

        public bool agregarSucursal(String nombre)
        {
            int cantFilas = 0;

            Sucursal sucu = new Sucursal();
            sucu.setNombreSucursal(nombre);

            DaoSucursal dao = new DaoSucursal();
            if (dao.existeSucursal(sucu) == false)
            {
                cantFilas = dao.agregarSucursal(sucu);
            }

            if (cantFilas == 1)
                return true;
            else
                return false;
        }
    }
    
}

