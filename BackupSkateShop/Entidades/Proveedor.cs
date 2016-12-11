using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackupSkateShop.Entidades
{
    class Proveedor
    {
        int id_proveedor;
        String ruc_proveedor;
        //String tipo_id_proveedor;
        String rz_soc_proveedor;
        String tel_proveedor;
        //String correo_proveedor;

        public int _id_proveedor_
        {
            set { id_proveedor = value; }
            get { return id_proveedor; }
        }
        /*public string _tipo_id_proveedor_
        {
            set { tipo_id_proveedor = value; }
            get { return tipo_id_proveedor; }
        }*/
        public string _rz_soc_proveedor_
        {
            set { rz_soc_proveedor = value; }
            get { return rz_soc_proveedor; }
        }
        public string _tel_proveedor_
        {
            set { tel_proveedor = value; }
            get { return tel_proveedor; }
        }
        /*public string _correo_proveedor_
        {
            set { correo_proveedor = value; }
            get { return correo_proveedor; }
        }*/
        public string _ruc_proveedor_
        {
            set { ruc_proveedor = value; }
            get { return ruc_proveedor; }
        }
    }
}
