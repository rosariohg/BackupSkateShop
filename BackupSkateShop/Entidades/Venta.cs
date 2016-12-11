using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackupSkateShop.Entidades
{
    class Venta
    {
        int id_venta;
        int id_usuario;
        decimal total_venta;
        DateTime fecha_venta;

        public int _id_venta_
        {
            get { return id_venta; }
            set { id_venta = value; }
        }
        public int _id_usuario_
        {
            get { return id_usuario; }
            set { id_usuario = value; }
        }
        public decimal _total_venta_
        {
            get { return total_venta; }
            set { total_venta = value; }
        }
        public DateTime _fecha_venta_
        {
            get { return fecha_venta; }
            set { fecha_venta = value; }
        }
    }
}
