using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace BackupSkateShop.DAOEntidades
{
    class DAOUsuario : Datos.cDatos
    {
        public DataTable obtenerUsuario()
        {
            string consulta;
            consulta = "SELECT * from usuario u;";
            conectar();
            DataTable resultado = queryDS(consulta);
            desconectar();
            return resultado;
        }

        public DataTable obtenerUsuario(int id_Usu)
        {
            string consulta;
            consulta = "SELECT * from usuario u WHERE id_Usuario="+id_Usu;
            conectar();
            DataTable resultado = queryDS(consulta);
            desconectar();
            return resultado;
        }

        public bool actualizarUsuario(Entidades.Usuario objUsuario) {
            string sql = "UPDATE usuario SET nom_Usuario='" + objUsuario._nom_usuario_ + "',alias_Usuario ='" + objUsuario._alias_usuario_ + "',pass_Usuario='" + objUsuario._pass_usuario_ + "',tipo_Usuario='" + objUsuario._tipo_usuario_ + "' WHERE id_Usuario=" + objUsuario._id_usuario_;
            conectar();
            if (ejecutar_sql(sql))
            {
                MessageBox.Show("Los datos se actualizaron correctamente!");
                desconectar();
                return true;
            }
            desconectar();
            return false;
        }

        public bool insertarUsuario(Entidades.Usuario objUsuario)
        {
            conectar();
            string sql = "INSERT INTO new_softskate.usuario (nom_Usuario,alias_Usuario,pass_Usuario,tipo_Usuario) VALUES ('" + objUsuario._nom_usuario_ + "','" + objUsuario._alias_usuario_ + "','" + objUsuario._pass_usuario_ + "','" + objUsuario._tipo_usuario_+ "')";

            if (ejecutar_sql(sql))
            {
                MessageBox.Show("Los datos se insertaron correctamente!");
                desconectar();
                return true;
            }
            desconectar();
            return false;
        }

        public bool eliminarUsuario(int id_Usu)
        {
            string consulta;
            consulta = "DELETE FROM new_softskate.usuario WHERE id_Usuario=" + id_Usu;
            conectar();
            if (ejecutar_sql(consulta))
            {
                MessageBox.Show("El producto se eliminó correctamente!");
                desconectar();
                return true;
            }
            desconectar();
            return false;
        }
        
    }
}
