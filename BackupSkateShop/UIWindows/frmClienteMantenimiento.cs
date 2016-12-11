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
    public partial class frmClienteMantenimiento : Office2007Form
    {
        frmCliente padre;
        int comportamiento;
        int id_Cliente;

        public frmClienteMantenimiento()
        {
            InitializeComponent();
        }

        public frmClienteMantenimiento(frmCliente padre)
        {
            InitializeComponent();
            this.padre = padre;
            comportamiento = 1;
        }

        public frmClienteMantenimiento(frmCliente padre, int id_Cliente)
        {
            InitializeComponent();
            this.padre = padre;
            this.id_Cliente = id_Cliente;
            comportamiento = 2;
        }

        private void frmClienteMantenimiento_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Entidades.Cliente objCliente = new Entidades.Cliente();
            objCliente._nom_cliente_ = txtNombreCliente.Text.ToString();
            objCliente._dni_ = txtDNI.Text.ToString();
            objCliente._dir_cliente_ = txtDireccion.Text.ToString();

            DAOEntidades.DAOCliente daoCliente = new DAOEntidades.DAOCliente();
            if (comportamiento == 1)
            {
                if (daoCliente.insertarCliente(objCliente))
                {
                    padre.llenarGridCliente();
                    Close();
                }
            }
            else if (comportamiento == 2)
            {
                objCliente._id_cliente_= id_Cliente;
                if (daoCliente.actualizarCliente(objCliente))
                {
                    padre.llenarGridCliente();
                    Close();
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }




    }
}
