using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Provincia
    {
        private int idProvincia;
        private string descripcionProvincia;

        public Provincia() { }

        public int getIdProvincia() { return idProvincia; }
        public void setIdProvincia(int id) { idProvincia = id; }

        public string getDescripcionProvincia() { return descripcionProvincia; }
        public void setDescripcionProvincia(string d) { descripcionProvincia = d; }
    }
}
