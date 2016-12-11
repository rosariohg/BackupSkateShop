using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Common;
using System.Windows.Forms;

namespace BackupSkateShop.Datos
{
    class cDatos
    {
        DbConnection xcon;
        DbProviderFactory objFac;
        String strProvider = "MySql.Data.MySqlClient";
        String strConnectionString = "Data Source=127.0.0.1;Database=new_softskate;User Id=root;password=root";

        public void conectar()
        {
            try
            {
                objFac = DbProviderFactories.GetFactory(strProvider);
                xcon = objFac.CreateConnection();

                xcon.ConnectionString = strConnectionString;
                xcon.Open();
            }
            catch
            {
                MessageBox.Show("Error al conectar la base de datos");
            }
        }
        public void desconectar()
        {
            try
            {
                xcon.Close();
            }
            catch
            {
                MessageBox.Show("Error al desconectar la base de datos");
            }

        }
        public bool ejecutar_sql(String sql)
        {
            try
            {
                DbCommand xcmd = xcon.CreateCommand();
                xcmd.CommandText = sql;
                xcmd.CommandType = System.Data.CommandType.Text;
                xcmd.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Error al ejecutar la sentencia SQL" + " " + sql);
                return false;
            }
            return true;

        }
        public DataTable queryDS(String sql)
        {
            DataTable xdt = new DataTable();
            DbDataAdapter xda = objFac.CreateDataAdapter();
            xda.SelectCommand = objFac.CreateCommand();
            xda.SelectCommand.Connection = xcon;
            xda.SelectCommand.CommandText = sql;
            xda.Fill(xdt);
            return xdt;
        }
    }
}
