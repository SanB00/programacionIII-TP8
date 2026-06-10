using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace Entidades
{
    public class Sucursal
    {
        private int idSucursal;
        private string nombreSucursal;
        private string descripcionSucursal;
        private int idHorarioSucursal;
        private int idProvinciaSucursal;
        private string direccionSucursal;
        private string urlImagenSucursal;

        public Sucursal() { }

        public int getIdSucursal() { return idSucursal; }
        public void setIdSucursal(int id) { idSucursal = id; }

        public string getNombreSucursal() { return nombreSucursal; }
        public void setNombreSucursal(string n) { nombreSucursal = n; }

        public string getDescripcionSucursal() { return descripcionSucursal; }
        public void setDescripcionSucursal(string d) { descripcionSucursal = d; }

        public int getIdHorarioSucursal() { return idHorarioSucursal; }
        public void setIdHorarioSucursal(int id) { idHorarioSucursal = id; }

        public int getIdProvinciaSucursal() { return idProvinciaSucursal; }
        public void setIdProvinciaSucursal(int id) { idProvinciaSucursal = id; }

        public string getDireccionSucursal() { return direccionSucursal; }
        public void setDireccionSucursal(string dir) { direccionSucursal = dir; }

        public string getUrlImagenSucursal() { return urlImagenSucursal; }
        public void setUrlImagenSucursal(string url) { urlImagenSucursal = url; }
    }
}