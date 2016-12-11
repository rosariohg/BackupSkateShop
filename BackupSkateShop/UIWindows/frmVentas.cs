using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace BackupSkateShop.UIWindows
{
    public partial class frmVentas : Office2007Form
    {
        public frmVentas()
        {
            InitializeComponent();
        }

        private void frmVentas_Load(object sender, EventArgs e)
        {                       
            //this.txtCliente.AutoCompleteMode = AutoCompleteMode.Suggest;
            //this.txtCliente.AutoCompleteSource = AutoCompleteSource.CustomSource;

            this.dateTimeFecha.Value = System.DateTime.Today;
        }

        /*private void txtCliente_TextChanged(object sender, EventArgs e)
        {
            TextBox t = sender as TextBox;
            if (t != null)
            {
                //say you want to do a search when user types 3 or more chars
                if (t.Text.Length >= 3)
                {
                    DAOEntidades.DAOCliente daoCliente = new DAOEntidades.DAOCliente();
                    DataTable dtCliente;
                    dtCliente=daoCliente.buscarCliente(this.txtCliente.Text.ToString());

                    string[] arr = dtCliente.AsEnumerable().Select(r => r.Field<string>("nom_Cliente")).ToArray();
                    
                    var source = new AutoCompleteStringCollection();
                    source.AddRange(arr);

                    this.txtCliente.AutoCompleteCustomSource = source;
                }
            }
        }*/

        private void cbCliente_TextUpdate(object sender, EventArgs e)
        {
            if (this.cbCliente.Text.Length >= 3)
            {
                DAOEntidades.DAOCliente daoCliente = new DAOEntidades.DAOCliente();
                DataTable dtCliente;
                dtCliente = daoCliente.buscarCliente(this.cbCliente.Text.ToString());

                cbCliente.DataSource = dtCliente;
                cbCliente.DisplayMember = "nom_Cliente";
                cbCliente.ValueMember = "id_Cliente";

                cbCliente.Show();
            }
        }

        
        private void txtCodigoBarras_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                DAOEntidades.DAOProducto daoProducto = new DAOEntidades.DAOProducto();
                DataTable dtProducto;
                dtProducto = daoProducto.buscarProducto(this.txtCodigoBarras.Text.ToString());

                int id_Producto = int.Parse(dtProducto.Rows[0].ItemArray[0].ToString());
                string cb_Producto = dtProducto.Rows[0].ItemArray[1].ToString();
                string nom_Producto = dtProducto.Rows[0].ItemArray[2].ToString();
                string precio_Producto = dtProducto.Rows[0].ItemArray[3].ToString();
                int cantidad = 1;
                decimal total = decimal.Parse(precio_Producto) * cantidad;

                dgvVentas.Rows.Add(cb_Producto,nom_Producto,precio_Producto,cantidad,total);

                decimal total_t = 0;
                //MessageBox.Show(dgvVentas.Rows.Count + " " + dgvVentas.Rows[0].Cells[4].ToString());
                for(int i= 0; i < dgvVentas.Rows.Count-1;++i)
                    total_t += decimal.Parse(dgvVentas.Rows[i].Cells[4].Value.ToString());
                txtTotal.Text = total_t.ToString();
            }
        }

        private void dgvVentas_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvVentas.Columns[e.ColumnIndex].Name == "cant_Detalle")
            {
                decimal precio=decimal.Parse(dgvVentas.CurrentRow.Cells[2].Value.ToString());
                decimal cantidad=decimal.Parse(dgvVentas.CurrentRow.Cells[3].Value.ToString());
                dgvVentas.CurrentRow.Cells[4].Value = precio*cantidad;


                decimal total_t = 0;
                for (int i = 0; i < dgvVentas.Rows.Count-1; ++i)
                    total_t += decimal.Parse(dgvVentas.Rows[i].Cells[4].Value.ToString());
                txtTotal.Text = total_t.ToString();
            }
        }

       

        

        
    }
}
