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
    public partial class frmCliente : Office2007Form
    {
        public frmCliente()
        {
            InitializeComponent();
        }

        public void llenarGridCliente()
        {
            DAOEntidades.DAOCliente daoCliente = new DAOEntidades.DAOCliente();
            DataTable dtCliente;
            dtCliente = daoCliente.obtenerCliente();
            dgvCliente.DataSource = dtCliente;
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            llenarGridCliente();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmClienteMantenimiento objCliente = new frmClienteMantenimiento(this);
            objCliente.Show();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvCliente.CurrentRow != null)
            {
                int id_Cliente = int.Parse(dgvCliente.CurrentRow.Cells[0].Value.ToString());

                frmClienteMantenimiento objClienteEditar = new frmClienteMantenimiento(this, id_Cliente);
                objClienteEditar.Show();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvCliente.CurrentRow != null)
            {
                int id_Cliente = int.Parse(dgvCliente.CurrentRow.Cells[0].Value.ToString());
                DialogResult dialogResult = MessageBox.Show("Esta seguro de eliminar este Item?", "Eliminar?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    DAOEntidades.DAOCliente daoCliente = new DAOEntidades.DAOCliente();
                    daoCliente.eliminarCliente(id_Cliente);
                    llenarGridCliente();
                }
                else if (dialogResult == DialogResult.No)
                {
                    //do something else
                }
            }
        }




    }
}
