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
    public partial class frmAdministrador : Office2007Form
    {
        public frmAdministrador()
        {
            InitializeComponent();
        }

      

        private void tabControlPanel1_Click(object sender, EventArgs e)
        {

        }

        private void btnArticulos_Click(object sender, EventArgs e)
        {
            frmProducto objProducto = new frmProducto();
            objProducto.Show();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            frmUsuario objUsuario = new frmUsuario();
            objUsuario.Show();
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            frmProveedores objProveedor = new frmProveedores();
            objProveedor.Show();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            frmCliente objCliente = new frmCliente();
            objCliente.Show();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            frmVentas objVentas = new frmVentas();
            objVentas.Show();
        }

        private void btnEmpresa_Click(object sender, EventArgs e)
        {
            frmEmpresa objEmpresa = new frmEmpresa();
            objEmpresa.Show();
        }



   


      


       

        
    }
}
