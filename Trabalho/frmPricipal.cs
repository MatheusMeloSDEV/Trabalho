using CLUSA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Syncfusion.SfDataGrid.XForms.Renderers;
using Xamarin.Forms;

namespace Trabalho
{
    public partial class frmPricipal : Form
    {
        private RepositorioUsers repositorio;
        frmMenu menu;
        frmMapa mapa;
        frmADMIN admin;
        frmDecex decex;
        public frmPricipal()
        {
            InitializeComponent();
            if (menu == null)
            {
                frmMenu MenuForm = new frmMenu();

                MenuForm.MdiParent = this;
                MenuForm.WindowState = FormWindowState.Maximized;
                MenuForm.Show();
            }
            else
            {
                menu.Activate();
            }
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
        private void planilhasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void frmPricipal_Load(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
