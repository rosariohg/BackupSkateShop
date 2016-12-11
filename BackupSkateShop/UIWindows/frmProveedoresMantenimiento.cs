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
    public partial class frmProveedoresMantenimiento : Office2007Form
    {
        frmProveedores padre;
        int comportamiento;
        int id_Proveedor;

        public frmProveedoresMantenimiento()
        {
            InitializeComponent();
        }

        public frmProveedoresMantenimiento(frmProveedores padre)
        {
            InitializeComponent();
            this.padre = padre;
            comportamiento = 1;
        }

        public frmProveedoresMantenimiento(frmProveedores padre, int id_Proveedor)
        {
            InitializeComponent();
            this.padre = padre;
            this.id_Proveedor= id_Proveedor;
            comportamiento = 2;
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            Entidades.Proveedor objProveedor = new Entidades.Proveedor();
            objProveedor._ruc_proveedor_ = txtRUC.Text.ToString();
            objProveedor._rz_soc_proveedor_ = txtRazonSocial.Text.ToString();
            objProveedor._tel_proveedor_ = txtTelefono.Text.ToString();

            DAOEntidades.DAOProveedor daoProveedor = new DAOEntidades.DAOProveedor();
            if (comportamiento == 1)
            {
                if (daoProveedor.insertarProveedor(objProveedor))
                {
                    padre.llenarGridProveedor();
                    Close();
                }
            }
            else if (comportamiento == 2)
            {
                objProveedor._id_proveedor_ = id_Proveedor;
                if (daoProveedor.actualizarProveedor(objProveedor))
                {
                    padre.llenarGridProveedor();
                    Close();
                }
            }
        }

        public void obtenerDatosEdicion()
        {
            Entidades.Proveedor objProveedor = new Entidades.Proveedor();
            DAOEntidades.DAOProveedor daoProveedor = new DAOEntidades.DAOProveedor();
            DataTable dtProveedor = daoProveedor.obtenerProveedor(id_Proveedor);

            txtRUC.Text = dtProveedor.Rows[0].ItemArray[1].ToString();
            txtRazonSocial.Text = dtProveedor.Rows[0].ItemArray[2].ToString();
            txtTelefono.Text = dtProveedor.Rows[0].ItemArray[3].ToString();
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmProveedoresMantenimiento_Load(object sender, EventArgs e)
        {
            if (comportamiento == 2)
                obtenerDatosEdicion();
        }

        

    }
}
