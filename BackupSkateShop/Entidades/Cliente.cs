using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackupSkateShop.Entidades
{
    class Cliente
    {
        int id_cliente;
        String dni;
        String nom_cliente;
        String ape_cliente;
        String dir_cliente;
        String cel_cliente;
        String correo;


        public int _id_cliente_
        {
            set { id_cliente = value; }
            get { return id_cliente; }
        }
        public string _dni_
        {
            set { dni = value; }
            get { return dni; }
        }
        public string _nom_cliente_
        {
            set { nom_cliente = value; }
            get { return nom_cliente; }
        }
        public string _ape_cliente_
        {
            set { ape_cliente = value; }
            get { return ape_cliente; }
        }
        public string _dir_cliente_
        {
            set { dir_cliente = value; }
            get { return dir_cliente; }
        }
        public string _nro_factura_
        {
            set { dir_cliente = value; }
            get { return dir_cliente; }
        }
        public string _cel_cliente_
        {
            set { cel_cliente = value; }
            get { return cel_cliente; }
        }
        public string _correo_
        {
            set { correo = value; }
            get { return correo; }
        }

    }
}
