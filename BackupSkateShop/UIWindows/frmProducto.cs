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
    public partial class frmProducto : Office2007Form
    {
        public frmProducto()
        {
            InitializeComponent();
        }

        public void llenarGridProducto() {
            DAOEntidades.DAOProducto daoProducto = new DAOEntidades.DAOProducto();
            DataTable dtProducto;
            dtProducto = daoProducto.obtenerProducto();
            dgvProducto.DataSource = dtProducto;
        }

        private void frmProducto_Load(object sender, EventArgs e)
        {
            llenarGridProducto();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmProductoMantenimiento objProdAgregar = new frmProductoMantenimiento(this);
            objProdAgregar.Show();
        }
             
        private void btnEditar_Click(object sender, EventArgs e)
        {
            //dgvProducto.SelectedRows
            if (dgvProducto.CurrentRow != null)
            {
                int id_Producto = int.Parse(dgvProducto.CurrentRow.Cells[0].Value.ToString());

                frmProductoMantenimiento objProdEditar = new frmProductoMantenimiento(this,id_Producto);
                objProdEditar.Show();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvProducto.CurrentRow != null)
            {
                int id_Producto = int.Parse(dgvProducto.CurrentRow.Cells[0].Value.ToString());
                DialogResult dialogResult = MessageBox.Show("Esta seguro de eliminar este Item?", "Eliminar?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    DAOEntidades.DAOProducto daoProducto = new DAOEntidades.DAOProducto();
                    daoProducto.eliminarProducto(id_Producto);
                    llenarGridProducto();
                }
                else if (dialogResult == DialogResult.No)
                {
                    //do something else
                }
                
                
            }
        }

        

        
    }
}
