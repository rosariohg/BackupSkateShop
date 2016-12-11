using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace BackupSkateShop.DAOEntidades
{
    class DAOCliente:Datos.cDatos
    {
        public DataTable obtenerCliente()
        {
            string consulta;
            consulta = "SELECT * from cliente c;";
            conectar();
            DataTable resultado = queryDS(consulta);
            desconectar();
            return resultado;
        }

        public DataTable obtenerCliente(int id_Cli)
        {
            string consulta;
            consulta = "SELECT * from cliente c WHERE id_Cliente=" + id_Cli;
            conectar();
            DataTable resultado = queryDS(consulta);
            desconectar();
            return resultado;
        }

        public bool actualizarCliente(Entidades.Cliente objCliente)
        {
            string sql = "UPDATE cliente SET nom_Cliente='" + objCliente._nom_cliente_+ "',direc_Cliente ='" + objCliente._dir_cliente_ + "',dni_Cliente='" + objCliente._dni_ + "' WHERE id_Cliente=" + objCliente._id_cliente_;
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

        public bool insertarCliente(Entidades.Cliente objCliente)
        {
            conectar();
            string sql = "INSERT INTO new_softskate.cliente (nom_Cliente,direc_Cliente,dni_Cliente) VALUES ('" + objCliente._nom_cliente_ + "','" + objCliente._dir_cliente_ + "','" + objCliente._dni_ + "')";

            if (ejecutar_sql(sql))
            {
                MessageBox.Show("Los datos se insertaron correctamente!");
                desconectar();
                return true;
            }
            desconectar();
            return false;
        }

        public bool eliminarCliente(int id_Cli)
        {
            string consulta;
            consulta = "DELETE FROM new_softskate.cliente WHERE id_Cliente=" + id_Cli;
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

        public DataTable buscarCliente(string cliente) {
            string consulta;
            consulta = "SELECT id_Cliente,nom_Cliente,dni_Cliente from cliente c Where nom_Cliente LIKE '%" + cliente + "%';";
            conectar();
            DataTable resultado = queryDS(consulta);
            desconectar();
            return resultado;
        }

    }
}
