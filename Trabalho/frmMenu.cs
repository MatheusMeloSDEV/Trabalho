using CLUSA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho
{
    public partial class frmMenu : Form
    {
        frmPricipal principal;
        frmMapa mapa;
        frmADMIN admin;
        frmDecex decex;

        public frmMenu()
        {
            InitializeComponent();
        }

        private void mAPAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (mapa == null)
            {
                frmMapa MapaForm = new frmMapa();

                MapaForm.WindowState = FormWindowState.Maximized;
                this.Hide();
                MapaForm.ShowDialog();
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
            this.Show();
        }

        private void aDMINToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (admin == null)
            {
                frmADMIN ADMINForm = new frmADMIN();

                ADMINForm.MdiParent = this;
                ADMINForm.WindowState = FormWindowState.Maximized;
                ADMINForm.Show();

            }
            else
            {
                admin.Activate();
            }
        }

        private void decexToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (decex == null)
            {
                frmDecex DecexForm = new frmDecex();

                DecexForm.MdiParent = this;
                DecexForm.WindowState = FormWindowState.Maximized;
                DecexForm.Show();
            }
            else
            {
                decex.Activate();
            }
        }
    }
}
