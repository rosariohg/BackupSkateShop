using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace BackupSkateShop.DAOEntidades
{
    class DAOProducto : Datos.cDatos
    {
        public DataTable obtenerProducto()
        {
            string consulta;
            consulta = "SELECT id_Producto,cb_Producto,nom_Producto,prec_Producto,activo_Producto, nom_Familia,  uni_min_Producto, nom_Oferta, nom_Temporada FROM new_softskate.producto p,new_softskate.familia f, new_softskate.temporada t, new_softskate.oferta o  WHERE p.Familia_id_Familia=f.id_Familia AND p.id_Temporada = t.id_Temporada AND p.Oferta_id_Oferta = o.id_Oferta;";
            conectar();
            DataTable resultado = queryDS(consulta);
            desconectar();
            return resultado;
        }

        public DataTable obtenerProducto(int id_Prod)
        {
            string consulta;
            consulta = "SELECT id_Producto,cb_Producto,nom_Producto,prec_Producto,activo_Producto,Familia_id_Familia, uni_min_Producto, id_Temporada, Oferta_id_Oferta FROM new_softskate.producto WHERE id_Producto=" + id_Prod;
            conectar();
            DataTable resultado = queryDS(consulta);
            desconectar();
            return resultado;
        }

        public bool actualizarProducto(Entidades.Producto objProducto)
        {
            string sql = "UPDATE producto SET cb_Producto='" + objProducto._cb_producto_ + "',nom_Producto ='" + objProducto._nom_producto_ + "',prec_Producto=" + objProducto._prec_uni_produto_ + ",activo_Producto='" + objProducto._activo_producto_ + "',Familia_id_Familia=" + objProducto._id_familia_ + ",uni_min_Producto=" + objProducto._unidad_minima_producto_ + ",id_Temporada=" +objProducto._id_temporada_ + ", Oferta_id_Oferta="+objProducto._id_oferta_+" WHERE id_Producto=" + objProducto._id_producto_ ;
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
        

        public bool insertarProducto(Entidades.Producto objProducto) {
            conectar();
            string sql = "INSERT INTO new_softskate.producto (nom_Producto,cb_Producto,prec_Producto,activo_Producto,Familia_id_Familia,uni_min_Producto,id_Temporada,Oferta_id_Oferta) VALUES ('" + objProducto._nom_producto_ + "','" + objProducto._cb_producto_ + "'," + objProducto._prec_uni_produto_ + ",'" + objProducto._activo_producto_ + "'," + objProducto._id_familia_ + "," + objProducto._unidad_minima_producto_ + "," + objProducto._id_temporada_ + ", " + objProducto._id_oferta_+ ")";
            
            if (ejecutar_sql(sql))
            {
                MessageBox.Show("Los datos se insertaron correctamente!");
                desconectar();
                return true;
            }
            desconectar();
            return false;
        }
        
        public bool eliminarProducto(int id_Prod)
        {
            string consulta;
            consulta = "DELETE FROM new_softskate.producto WHERE id_Producto=" + id_Prod;
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

        public DataTable buscarProducto(string cbBarras)
        {
            string consulta;
            consulta = "SELECT id_Producto,cb_Producto,nom_Producto,prec_Producto,prec_Venta_Producto,precio_antes,precio_oferta from new_softskate.producto p JOIN new_softskate.oferta o  where p.cb_Producto LIKE '%"+cbBarras+"%'";
            conectar();
            DataTable resultado = queryDS(consulta);
            desconectar();
            return resultado;
        }
    }
}
