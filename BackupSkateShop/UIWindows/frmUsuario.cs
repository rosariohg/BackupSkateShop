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
    public partial class frmUsuario : Office2007Form
    {
        public frmUsuario()
        {
            InitializeComponent();
        }

        public frmUsuario(String alias)
        {
            InitializeComponent();
            string alias_usuario = alias;  
        }

        public void llenarGridUsuario()
        {
            DAOEntidades.DAOUsuario daoUsuario = new DAOEntidades.DAOUsuario();
            DataTable dtUsuario;
            dtUsuario = daoUsuario.obtenerUsuario();
            dgvUsuario.DataSource = dtUsuario;
        }

        private void frmUsuario_Load(object sender, EventArgs e)
        {
            llenarGridUsuario();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmUsuarioMantenimiento objUsuarioAgregar = new frmUsuarioMantenimiento(this);
            objUsuarioAgregar.Show();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvUsuario.CurrentRow != null)
            {
                int id_Usuario = int.Parse(dgvUsuario.CurrentRow.Cells[0].Value.ToString());

                frmUsuarioMantenimiento objUsuarioEditar = new frmUsuarioMantenimiento(this,id_Usuario);
                objUsuarioEditar.Show();                
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvUsuario.CurrentRow != null)
            {
                int id_Usuario = int.Parse(dgvUsuario.CurrentRow.Cells[0].Value.ToString());
                DialogResult dialogResult = MessageBox.Show("Esta seguro de eliminar este Item?", "Eliminar?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    DAOEntidades.DAOUsuario daoUsuario = new DAOEntidades.DAOUsuario();
                    daoUsuario.eliminarUsuario(id_Usuario);
                    llenarGridUsuario();
                }
                else if (dialogResult == DialogResult.No)
                {
                    //do something else
                }
            }
        }

 
    }
}
