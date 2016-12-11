using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackupSkateShop.Entidades
{
    class DetalleCompra
    {
        int id_detalle_compra;
        int cant_detalle_venta;
        int id_producto;
        decimal precio_unitario;
        int id_compra;
        decimal total_detalle_compra;

        public int _id_detalle_compra_
        {
            get { return id_detalle_compra; }
            set { id_detalle_compra = value; }
        }
        public int _cant_detalle_venta_
        {
            get { return cant_detalle_venta; }
            set { cant_detalle_venta = value; }
        }
        public int _id_producto_
        {
            get { return id_producto; }
            set { id_producto = value; }
        }
        public decimal _precio_unitario_
        {
            get { return precio_unitario; }
            set { precio_unitario = value; }
        }
        public int _id_compra_
        {
            get { return id_compra; }
            set { id_compra = value; }
        }
        public decimal _total_detalle_compra_
        {
            get { return total_detalle_compra; }
            set { total_detalle_compra = value; }
        }
    }
}
