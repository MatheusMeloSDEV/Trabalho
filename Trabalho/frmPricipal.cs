using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho
{
    public partial class frmPricipal : Form
    {
        frmMapa mapa;
        public frmPricipal()
        {
            InitializeComponent();
        }

        private void mAPAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (mapa == null)
            {
                frmMapa MapaForm = new frmMapa();

                MapaForm.MdiParent = this;
                MapaForm.WindowState = FormWindowState.Maximized;
                MapaForm.Show();

            }
            else
            {
                mapa.Activate();
            }
        }

        private void maximizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (WindowState != FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Maximized;
                maximizarToolStripMenuItem.Text = "Normal";
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                maximizarToolStripMenuItem.Text = "Maximizar";
            }

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
