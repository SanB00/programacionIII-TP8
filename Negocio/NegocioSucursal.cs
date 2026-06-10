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
            return dao.getTablaPorId(objSucursal);
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

        public bool agregarSucursal(string nombre, string descripcion, string direccion, int idProvincia) {
            {
                int cantFilas = 0;

                Sucursal sucu = new Sucursal();
                sucu.setNombreSucursal(nombre);
                sucu.setDescripcionSucursal(descripcion);
                sucu.setDireccionSucursal(direccion);
                sucu.setIdProvinciaSucursal(idProvincia);

                DaoSucursal dao = new DaoSucursal();
                if (dao.existeSucursal(sucu) == false) {
                    cantFilas = dao.agregarSucursal(sucu);
                }

                if (cantFilas == 1)
                    return true;
                else
                    return false;
            }
        }

    }
}

