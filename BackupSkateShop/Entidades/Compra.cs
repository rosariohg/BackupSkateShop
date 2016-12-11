using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackupSkateShop.Entidades
{
    class Compra
    {
        int id_compra;
        int id_proveedor;
        DateTime fecha_compra;
        decimal total_compra;
        string nro_factura;

        public int _id_compra_
        {
            get { return id_compra; }
            set { id_compra = value; }
        }
        public int _id_proveedor_
        {
            get { return id_proveedor; }
            set { id_proveedor = value; }
        }
        public DateTime _fecha_compra_
        {
            get { return fecha_compra; }
            set { fecha_compra = value; }
        }
        public decimal _total_compra_
        {
            get { return total_compra; }
            set { total_compra = value; }
        }
        public string _nro_factura_
        {
            get { return nro_factura; }
            set { nro_factura = value; }
        }
    }
}
