using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BackupSkateShop.DAOEntidades
{
    class DAOFamilia : Datos.cDatos
    {
        public DataTable obtenerFamilia()
        {
            string consulta;
            consulta = "SELECT * from familia f;";
            conectar();
            DataTable resultado = queryDS(consulta);
            desconectar();
            return resultado;
        }
    }
}
