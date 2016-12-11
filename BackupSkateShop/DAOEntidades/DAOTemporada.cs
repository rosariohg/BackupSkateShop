using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BackupSkateShop.DAOEntidades
{
    class DAOTemporada: Datos.cDatos
    {
        public DataTable obtenerTemporada()
        {
            string consulta;
            consulta = "SELECT * FROM temporada t;";
            conectar();
            DataTable resultado = queryDS(consulta);
            desconectar();
            return resultado;
        }
    }
}
