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
    public partial class frmLoad : Office2007Form
    {
        public frmLoad()
        {
            InitializeComponent();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            DAOEntidades.DAOLogin DAO = new DAOEntidades.DAOLogin();
            DAOEntidades.DAOUsuario DAOUsuario = new DAOEntidades.DAOUsuario();
            Entidades.Usuario objUsuario = new Entidades.Usuario();
            objUsuario._alias_usuario_ = txtUsuario.Text;            
            objUsuario._pass_usuario_ = txtContraseña.Text;
            
            if (DAO.login(objUsuario))
            {
                if (DAO.login2(txtUsuario.Text).Equals("Administrador"))
                {

                    UIWindows.frmAdministrador frmAdmin = new UIWindows.frmAdministrador();
                    this.Hide();
                    frmAdmin.ShowDialog();
                    this.Close();
                }
                else
                {

                    UIWindows.frmUsuario fmrUsu = new UIWindows.frmUsuario(txtUsuario.Text);
                    this.Hide();
                    fmrUsu.ShowDialog();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Inserte una contraseña o alias correcto!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
