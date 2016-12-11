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
    public partial class frmProveedores : Office2007Form
    {
        public frmProveedores()
        {
            InitializeComponent();
        }

        public void llenarGridProveedor()
        {
            DAOEntidades.DAOProveedor daoProveedor = new DAOEntidades.DAOProveedor();
            DataTable dtProveedor;
            dtProveedor = daoProveedor.obtenerProveedor();
            dgvProveedor.DataSource = dtProveedor;
        }

        private void frmProveedores_Load(object sender, EventArgs e)
        {
            llenarGridProveedor();
        }

       
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvProveedor.CurrentRow != null)
            {
                int id_Proveedor = int.Parse(dgvProveedor.CurrentRow.Cells[0].Value.ToString());

                frmProveedoresMantenimiento objProveedorEditar = new frmProveedoresMantenimiento(this, id_Proveedor);
                objProveedorEditar.Show();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvProveedor.CurrentRow != null)
            {
                int id_Proveedor = int.Parse(dgvProveedor.CurrentRow.Cells[0].Value.ToString());
                DialogResult dialogResult = MessageBox.Show("Esta seguro de eliminar este Item?", "Eliminar?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    DAOEntidades.DAOProveedor daoProveedor = new DAOEntidades.DAOProveedor();
                    daoProveedor.eliminarProveedor(id_Proveedor);
                    llenarGridProveedor();
                }
                else if (dialogResult == DialogResult.No)
                {
                    //do something else
                }
            }
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            frmProveedoresMantenimiento objProveedorAgregar = new frmProveedoresMantenimiento(this);
            objProveedorAgregar.Show();
        }

        
    }
}
