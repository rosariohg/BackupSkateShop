using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackupSkateShop.Entidades
{
    class Usuario
    {
        int id_usuario;
        string nom_usuario;
        string alias_usuario;
        string pass_usuario;
        string tipo_usuario;

        public int _id_usuario_
        {
            get { return id_usuario; }
            set { id_usuario = value; }
        }
        public string _nom_usuario_
        {
            get { return nom_usuario; }
            set { nom_usuario = value; }
        }
        public string _alias_usuario_
        {
            get { return alias_usuario; }
            set { alias_usuario = value; }
        }
        public string _pass_usuario_
        {
            get { return pass_usuario; }
            set { pass_usuario = value; }
        }
        public string _tipo_usuario_
        {
            get { return tipo_usuario; }
            set { tipo_usuario = value; }
        }
    }
}
