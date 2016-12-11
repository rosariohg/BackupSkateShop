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
    public partial class frmProductoMantenimiento : Office2007Form
    {
        frmProducto padre;
        int comportamiento;
        int id_Producto;

        public frmProductoMantenimiento()
        {
            InitializeComponent();
        }

        public frmProductoMantenimiento(frmProducto padre)
        {
            InitializeComponent();
            this.padre = padre;
            comportamiento = 1;
        }

        public frmProductoMantenimiento(frmProducto padre, int id_Producto)
        {
            InitializeComponent();
            this.padre = padre;
            this.id_Producto = id_Producto;
            comportamiento = 2;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            /// TODO: restricciones
            
            Entidades.Producto objProducto = new Entidades.Producto();
            objProducto._cb_producto_ = txtCodigoBarras.Text.ToString();
            objProducto._nom_producto_ = txtNombreProducto.Text.ToString();            
            objProducto._prec_uni_produto_ = decimal.Parse(txtPrecio.Text.ToString());
            objProducto._unidad_minima_producto_ = int.Parse(txtUnidadProductos.Text.ToString());
            if (checkExistencia.Checked)
                objProducto._activo_producto_ = 'A';
            else
                objProducto._activo_producto_ = 'X';
            objProducto._id_familia_ = (int)(cbFamilia.SelectedValue);
            objProducto._id_temporada_ = (int)(cbTemporada.SelectedValue);
            objProducto._id_oferta_ = (int)(cbOferta.SelectedValue);

            DAOEntidades.DAOProducto daoProducto = new DAOEntidades.DAOProducto();
            if (comportamiento == 1)
            {
                if (daoProducto.insertarProducto(objProducto))//Se agrego correctamente
                {
                    padre.llenarGridProducto();
                    Close();
                }
            }
            else if (comportamiento == 2) {
                objProducto._id_producto_ = id_Producto;
                if(daoProducto.actualizarProducto(objProducto))
                {
                    padre.llenarGridProducto();
                    Close();
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void frmProductoAgregar_Load(object sender, EventArgs e)
        {
            llenarcomboFamilia();
            llenarcomboTemporada();
            llenarcomboOferta();
            if (comportamiento == 2)
                obtenerDatosEdicion();
        }

        public void obtenerDatosEdicion(){
            Entidades.Producto objProducto = new Entidades.Producto();
            DAOEntidades.DAOProducto daoProducto = new DAOEntidades.DAOProducto();
            DataTable dtProducto= daoProducto.obtenerProducto(id_Producto);
            
            txtCodigoBarras.Text = dtProducto.Rows[0].ItemArray[1].ToString();
            txtNombreProducto.Text = dtProducto.Rows[0].ItemArray[2].ToString();            
            txtPrecio.Text = dtProducto.Rows[0].ItemArray[3].ToString();
            txtUnidadProductos.Text = dtProducto.Rows[0].ItemArray[6].ToString();
            if( dtProducto.Rows[0].ItemArray[4].ToString() == "A")
                checkExistencia.Checked = true;
            else
                checkExistencia.Checked = false;
            cbFamilia.SelectedValue = dtProducto.Rows[0].ItemArray[5].ToString();            
            cbOferta.SelectedValue = dtProducto.Rows[0].ItemArray[8].ToString();
            cbTemporada.SelectedValue = dtProducto.Rows[0].ItemArray[7].ToString();
        }


        public void llenarcomboFamilia()
        {
            DAOEntidades.DAOFamilia daoFamilia = new DAOEntidades.DAOFamilia();
            DataTable dtFamilia;
            dtFamilia = daoFamilia.obtenerFamilia();
            cbFamilia.DataSource = dtFamilia;
            cbFamilia.DisplayMember = "nom_Familia";
            cbFamilia.ValueMember = "id_Familia";
        }

        public void llenarcomboTemporada() {
            DAOEntidades.DAOTemporada daoTemporada = new DAOEntidades.DAOTemporada();
            DataTable dtTemporada;
            dtTemporada = daoTemporada.obtenerTemporada();
            cbTemporada.DataSource = dtTemporada;
            cbTemporada.DisplayMember = "nom_Temporada";
            cbTemporada.ValueMember = "id_Temporada";
        }

        public void llenarcomboOferta() {
            DAOEntidades.DAOOferta daoOferta = new DAOEntidades.DAOOferta();
            DataTable dtOferta;
            dtOferta = daoOferta.obtenerOfertas();
            cbOferta.DataSource = dtOferta;
            cbOferta.DisplayMember = "nom_Oferta";
            cbOferta.ValueMember = "id_Oferta";
        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPrecio_Validating(object sender, CancelEventArgs e)
        {
            /*if (txtPrecio.Text.Length > 0)
            {
                decimal value;
                if (decimal.TryParse(txtPrecio.Text, out value))
                {
                    txtPrecio.Text = value.ToString("N2");
                    //errorProvider1.SetError(textBox1, "");
                }
                else
                {
                    e.Cancel = true;
                    txtPrecio.SelectAll();
                    //errorProvider1.SetError(textBox1, "Please enter a number");
                }
            }*/
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar))
            {
                e.Handled = !(((TextBox)sender).SelectionStart != 0 && (e.KeyChar.ToString() == Application.CurrentCulture.NumberFormat.NumberDecimalSeparator && ((TextBox)sender).Text.IndexOf(Application.CurrentCulture.NumberFormat.NumberDecimalSeparator) == -1));
            }
        }

        




        

      
    }
}
