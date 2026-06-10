using Datos;
using Entidades;
using System;
using System.Data;

namespace Negocio {
    public class NegocioSucursal {
        public DataTable getTabla() {
            DaoSucursal dao = new DaoSucursal();
            return dao.getTablaSucursales();
        }
        public DataTable getPorId(int id) {
            DaoSucursal dao = new DaoSucursal();
            Sucursal objSucursal = new Sucursal();
            objSucursal.setIdSucursal(id);
            return dao.getSucursal(objSucursal);
        }

        public bool eliminarSucursal(int id) {
            DaoSucursal dao = new DaoSucursal();
            Sucursal objSucursal = new Sucursal();
            objSucursal.setIdSucursal(id);
            int op = dao.eliminarSucursal(objSucursal);
            if (op == 1)
                return true;
            else
                return false;
        }

        public bool agregarSucursal(String nombre) {
            int cantFilas = 0;

            Sucursal objSucursal = new Sucursal();
            objSucursal.setNombreSucursal(nombre);

            DaoSucursal dao = new DaoSucursal();
            if (dao.existeSucursal(objSucursal) == false) {
                cantFilas = dao.agregarSucursal(objSucursal);
            }

            if (cantFilas == 1)
                return true;
            else
                return false;
        }
    }

}

