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
        frmMapa mapa;
        frmADMIN admin;
        frmDecex decex;
        frmMenu instance;

        public frmMenu()
        {
            InitializeComponent();
            instance = this;
            if(frmLogin.instance.logado.admin == false)
            {
                aDMINToolStripMenuItem.Visible = false;
            }
            tLiberaSaida.Interval = 3000;
            tLiberaSaida.Tick += new System.EventHandler(this.tLiberaSaida_Tick);
            sairToolStripMenuItem.Enabled = false;
            tLiberaSaida.Start();
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
    }
}
