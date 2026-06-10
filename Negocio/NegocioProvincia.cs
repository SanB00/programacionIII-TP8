using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NegocioProvincia
    {
        public DataTable getTabla()
        {
            DaoProvincia dao = new DaoProvincia();
            return dao.getTablaProvincia();
        }
        public Provincia get(int id)
        {
            DaoProvincia dao = new DaoProvincia();
            Provincia prov = new Provincia();
            prov.setIdProvincia(id);
            return dao.getProvincia(prov);
        }

    }
}
