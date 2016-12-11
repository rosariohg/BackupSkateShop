using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BackupSkateShop.UIWindows
{
    public partial class frmLoading : Form
    {
        public frmLoading()
        {
            InitializeComponent();
        }

        private void frmLoading_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 100)
            {
                progressBar1.Value = progressBar1.Value + 10;
                labelX1.Text = " Cargando el Sistema  al " + progressBar1.Value + "%";
            }
            else
            {
                timer1.Enabled = false;
                //essageBox.Show("Carga completa");

                frmLoad frm = new frmLoad();
                frm.Show();
                this.Hide();
            }
        }

        private void reflectionLabel1_Click(object sender, EventArgs e)
        {

        }

        private void progressBarX1_Click(object sender, EventArgs e)
        {

        }

        private void labelX1_Click(object sender, EventArgs e)
        {

        }

        private void progressBarX1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
