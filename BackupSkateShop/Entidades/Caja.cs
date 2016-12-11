using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackupSkateShop.Entidades
{
    class Caja
    {
        int id_caja;
        string oper_caja;
        string obs_caja;
        decimal monto_oper_caja;
        DateTime fecha_oper;
        int id_usuario;

        public int _id_caja_
        {
            get { return id_caja; }
            set { id_caja = value; }
        }
        public string _oper_caj_
        {
            get { return oper_caja; }
            set { oper_caja = value; }
        }
        public string _obs_caja_
        {
            get { return obs_caja; }
            set { obs_caja = value; }
        }
        public decimal _monto_oper_caja_
        {
            get { return monto_oper_caja; }
            set { monto_oper_caja = value; }
        }
        public DateTime _fecha_oper_
        {
            get { return fecha_oper; }
            set { fecha_oper = value; }
        }
        public int _id_usuario_
        {
            get { return id_usuario; }
            set { id_usuario = value; }
        }
    }
}
