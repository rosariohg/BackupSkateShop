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
    public partial class frmUsuarioMantenimiento : Office2007Form
    {
        frmUsuario padre;
        int comportamiento;
        int id_Usuario;

        public frmUsuarioMantenimiento()
        {
            InitializeComponent();
        }

       public frmUsuarioMantenimiento(frmUsuario padre)
        {
            InitializeComponent();
            this.padre = padre;
            comportamiento = 1;
        }

       public frmUsuarioMantenimiento(frmUsuario padre, int id_Usuario)
        {
            InitializeComponent();
            this.padre = padre;
            this.id_Usuario = id_Usuario;
            comportamiento = 2;
        }
     
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Entidades.Usuario objUsuario = new Entidades.Usuario();
            objUsuario._nom_usuario_ = txtNombreUsuario.Text.ToString();
            objUsuario._alias_usuario_ = txtAlias.Text.ToString();
            objUsuario._pass_usuario_ = txtPassword.Text.ToString();
            objUsuario._tipo_usuario_ = txtTipoUsuario.Text.ToString();            
            
            DAOEntidades.DAOUsuario daoUsuario = new DAOEntidades.DAOUsuario();
            if (comportamiento == 1)
            {
                if (daoUsuario.insertarUsuario(objUsuario))//Se agrego correctamente
                {                    
                    padre.llenarGridUsuario();
                    Close();
                }
            }
            else if (comportamiento == 2)
            {
                objUsuario._id_usuario_=id_Usuario;
                if (daoUsuario.actualizarUsuario(objUsuario))
                {
                    padre.llenarGridUsuario();
                    Close();
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        
        public void obtenerDatosEdicion()
        {
            Entidades.Usuario objUsuario = new Entidades.Usuario();
            DAOEntidades.DAOUsuario daoUsuario = new DAOEntidades.DAOUsuario();
            DataTable dtUsuario = daoUsuario.obtenerUsuario(id_Usuario);

            txtNombreUsuario.Text = dtUsuario.Rows[0].ItemArray[1].ToString();
            txtAlias.Text = dtUsuario.Rows[0].ItemArray[2].ToString();
            txtPassword.Text = dtUsuario.Rows[0].ItemArray[3].ToString();
            txtTipoUsuario.Text = dtUsuario.Rows[0].ItemArray[4].ToString();            
        }

        private void frmUsuarioMantenimiento_Load(object sender, EventArgs e)
        {
            
            if (comportamiento == 2)
                obtenerDatosEdicion();
        }



    }
}
