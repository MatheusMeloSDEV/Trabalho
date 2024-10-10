using CLUSA;
using System.IO;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;

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
        frmMapa mapa;
        frmADMIN admin;
        frmDecex decex;
        frmMenu instance;
        frmProcesso processo;
        frmAnvisa anvisa;

        public frmMenu()
        {
            InitializeComponent();
            instance = this;
            if (frmLogin.instance.logado.admin == false)
            {
                aDMINToolStripMenuItem.Visible = false;
            }
            tLiberaSaida.Interval = 3000;
            tLiberaSaida.Tick += new System.EventHandler(this.tLiberaSaida_Tick);
            sairToolStripMenuItem.Enabled = false;
            tLiberaSaida.Start();
            if (frmLogin.instance.escuro)
            {
                DarkMode();
            }
        }

        private void mAPAToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (mapa == null)
            {
                frmMapa MapaForm = new frmMapa();

                MapaForm.MdiParent = this;
                MapaForm.Show();
            }
            else
            {
                mapa.Activate();
            }
        }

        private void DarkMode()
        {
            menuStrip1.BackColor = SystemColors.ControlDark;
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void aDMINToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (admin == null)
            {
                frmADMIN ADMINForm = new frmADMIN();

                ADMINForm.MdiParent = this;
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
                DecexForm.Show();
            }
            else
            {
                decex.Activate();
            }
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        private void tLiberaSaida_Tick(object sender, EventArgs e)
        {
            tLiberaSaida.Stop();
            sairToolStripMenuItem.Enabled = true;
        }

        private void processoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (processo == null)
            {
                frmProcesso ProcessoForm = new frmProcesso();

                ProcessoForm.MdiParent = this;
                ProcessoForm.Show();

            }
            else
            {
                processo.Activate();
            }
        }

        private void anvisaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (anvisa == null)
            {
                frmAnvisa AnvisaForm = new frmAnvisa();

                AnvisaForm.MdiParent = this;
                AnvisaForm.Show();

            }
            else
            {
                anvisa.Activate();
            }
        }

        private void inícioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in this.MdiChildren)
            {
                // Fecha cada formulário filho
                childForm.Close();
            }
        }

        private void maximizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

    }
}
