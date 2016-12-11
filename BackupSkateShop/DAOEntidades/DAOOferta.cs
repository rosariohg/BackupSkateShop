using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BackupSkateShop.DAOEntidades
{
    class DAOOferta: Datos.cDatos
    {
        public DataTable obtenerOfertas()
        {
            string consulta;
            consulta = "SELECT * FROM oferta o;";
            conectar();
            DataTable resultado = queryDS(consulta);
            desconectar();
            return resultado;
        }
    }
}
