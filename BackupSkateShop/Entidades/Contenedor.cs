using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackupSkateShop.Entidades
{
    class Contenedor
    {
        int id_contenedor;
        string nombre_contenedor;
        string unidades_contendor;
        int id_producto;

        public int _id_contenedor_
        {
            get { return id_contenedor; }
            set { id_contenedor = value; }
        }
        public string _nombre_contendor_
        {
            get { return nombre_contenedor; }
            set { nombre_contenedor = value; }
        }
        public string _unidades_contenedor_
        {
            get { return unidades_contendor; }
            set { unidades_contendor = value; }

        }
        public int _id_producto_
        {
            get { return id_producto; }
            set { id_producto = value; }
        }
    }
}
