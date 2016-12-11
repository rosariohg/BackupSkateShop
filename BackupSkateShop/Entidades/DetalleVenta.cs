using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackupSkateShop.Entidades
{
    class DetalleVenta
    {
        int id_detalle_venta;
        int cant_detalle;
        int id_producto;
        string nom_producto;
        int id_venta;
        decimal total_detalle;

        public int _id_detalle_venta_
        {
            get { return id_detalle_venta; }
            set { id_detalle_venta = value; }
        }
        public int _cant_detalle_
        {
            get { return cant_detalle; }
            set { cant_detalle = value; }
        }
        public int _id_producto_
        {
            get { return id_producto; }
            set { id_producto = value; }
        }
        public string _nom_product_
        {
            get { return nom_producto; }
            set { nom_producto = value; }
        }
        public int _id_venta_
        {
            get { return id_venta; }
            set { id_venta = value; }
        }
        public decimal _total_detalle_
        {
            get { return total_detalle; }
            set { total_detalle = value; }
        }
    }
}
