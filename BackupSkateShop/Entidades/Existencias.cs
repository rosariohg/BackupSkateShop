using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackupSkateShop.Entidades
{
    class Existencias
    {
        int id_existencia;
        int id_producto;
        int cant_unidades_producto;

        public int _id_existencia_
        {
            get { return id_existencia; }
            set { id_existencia = value; }
        }
        public int _id_producto_
        {
            get { return id_producto; }
            set { id_producto = value; }
        }
        public int _cant_unidades_producto_
        {
            get { return cant_unidades_producto; }
            set { cant_unidades_producto = value; }
        }
    }
}
