using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackupSkateShop.Entidades
{
    class Producto
    {
        int id_producto;
        string cb_producto;
        string nom_producto;
        decimal prec_uni_producto;
        char activo_producto;
        int unidad_minima_producto;
        int id_temporada;
        int id_familia;
        int id_oferta;

        public int _id_producto_
        {
            get { return id_producto; }
            set { id_producto = value; }

        }
        public string _cb_producto_
        {
            get { return cb_producto; }
            set { cb_producto = value; }

        }
        public string _nom_producto_
        {
            get { return nom_producto; }
            set { nom_producto = value; }
        }
        public decimal _prec_uni_produto_
        {
            get { return prec_uni_producto; }
            set { prec_uni_producto = value; }
        }
        public char _activo_producto_
        {
            get { return activo_producto; }
            set { activo_producto = value; }
        }
        public int _unidad_minima_producto_
        {
            get { return unidad_minima_producto; }
            set { unidad_minima_producto = value; }
        }

        public int _id_temporada_ {
            get { return id_temporada; }
            set { id_temporada = value; }
        }

        public int _id_familia_
        {
            get { return id_familia; }
            set { id_familia = value; }
        }
        public int _id_oferta_
        {
            get { return id_oferta; }
            set { id_oferta = value; }
        }
    }
}
