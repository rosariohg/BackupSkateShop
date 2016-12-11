using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackupSkateShop.Entidades
{
    class Oferta
    {
        int id_oferta;
        String nom_oferta;
        int id_temporada;



        public int _id_oferta_
        {
            set { id_oferta = value; }
            get { return id_oferta; }
        }
        public string _nom_oferta_
        {
            set { nom_oferta = value; }
            get { return nom_oferta; }
        }
        public int _id_temporada_
        {
            set { id_temporada = value; }
            get { return id_temporada; }
        }
    }
}
