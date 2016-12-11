using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace BackupSkateShop.DAOEntidades
{
    class DAOProveedor : Datos.cDatos
    {
        public DataTable obtenerProveedor()
        {
            string consulta;
            consulta = "SELECT * FROM proveedor p;";
            conectar();
            DataTable resultado = queryDS(consulta);
            desconectar();
            return resultado;
        }
    

        public DataTable obtenerProveedor(int id_Proveedor)
        {
            string consulta;
            consulta = "SELECT * FROM proveedor p WHERE id_Proveedor=" + id_Proveedor;
            conectar();
            DataTable resultado = queryDS(consulta);
            desconectar();
            return resultado;
        }

        public bool actualizarProveedor(Entidades.Proveedor objProveedor)
        {
            string sql = "UPDATE proveedor SET ruc_Proveedor='" + objProveedor._ruc_proveedor_ + "',rz_soc_proveedor ='" + objProveedor._rz_soc_proveedor_ + "',tel_Proveedor='" + objProveedor._tel_proveedor_ + "' WHERE id_Proveedor=" + objProveedor._id_proveedor_;
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

        public bool insertarProveedor(Entidades.Proveedor objProveedor)
        {
            conectar();
            string sql = "INSERT INTO new_softskate.proveedor (ruc_Proveedor,rz_soc_Proveedor,tel_Proveedor) VALUES ('" + objProveedor._ruc_proveedor_ + "','" + objProveedor._rz_soc_proveedor_ + "','" + objProveedor._tel_proveedor_ + "')";

            if (ejecutar_sql(sql))
            {
                MessageBox.Show("Los datos se insertaron correctamente!");
                desconectar();
                return true;
            }
            desconectar();
            return false;
        }

        public bool eliminarProveedor(int id_Prov)
        {
            string consulta;
            consulta = "DELETE FROM new_softskate.proveedor WHERE id_Proveedor=" + id_Prov;
            conectar();
            if (ejecutar_sql(consulta))
            {
                MessageBox.Show("El proveedor se eliminó correctamente!");
                desconectar();
                return true;
            }
            desconectar();
            return false;
        }


    }
}
