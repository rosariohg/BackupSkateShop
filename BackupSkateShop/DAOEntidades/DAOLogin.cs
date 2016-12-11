using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BackupSkateShop.DAOEntidades
{
    class DAOLogin:Datos.cDatos
    {
        public string login2(String aliasUsuario)
        {
            conectar();
            string sql = "SELECT  tipo_usuario from usuario where alias_usuario='" + aliasUsuario + "'"; ;
            DataTable id = queryDS(sql);
            desconectar();
            string codigo = id.Rows[0][0].ToString();
            return codigo;
        }

        public bool login(Entidades.Usuario objUsuario)
        {
            conectar();
            string sql_verificar = "SELECT count(*) FROM usuario WHERE alias_usuario='" + objUsuario._alias_usuario_ + "' and pass_usuario='" + objUsuario._pass_usuario_ + "'";
            int es_usuario = int.Parse(queryDS(sql_verificar).Rows[0][0].ToString());
            desconectar();
            return es_usuario > 0 ? true : false;
        }
    }
}
