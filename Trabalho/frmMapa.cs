using CLUSA;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Trabalho
{
    public partial class frmMapa : Form
    {
        private RepositorioMAPA repositorio;
        public frmMapa()
        {
            InitializeComponent();
        }

        private void frmMapa_Load(object sender, EventArgs e)
        {
            repositorio = new RepositorioMAPA();
            bsMAPA.DataSource = repositorio;
            if (frmLogin.instance.escuro)
            {
                DarkMode();
            }
        }

        private void DarkMode()
        {
            toolStrip1.BackColor = SystemColors.ControlDark;
            this.BackColor = SystemColors.ControlDark;
            CmbPesquisar.BackColor = SystemColors.ControlDarkDark;
            txtPesquisar.BackColor= SystemColors.ControlDarkDark;
            dataGridView1.DefaultCellStyle.BackColor = SystemColors.ControlDark;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = SystemColors.ControlDarkDark;
        }

        private async void btnAdicionar_click(object sender, EventArgs e)
        {
            MAPA mapa = new MAPA();
            frmModificaMapa frm = new frmModificaMapa();
            frm.mapa = mapa;
            frm.ShowDialog();

            if (frm.DialogResult == DialogResult.OK)
            {
                await repositorio.Create(mapa);
                bsMAPA.Add(mapa);
            }
        }
        private async void btnExcluir_Click(object sender, EventArgs e)
        {
            await repositorio.Delete(bsMAPA.Current as MAPA);
            bsMAPA.Remove(bsMAPA.Current as MAPA);
            bsMAPA.ResetBindings(false);
            bsMAPA.DataSource = repositorio.FindAll();
        }

        private async void btnEditar_Click(object sender, EventArgs e)
        {
            frmModificaMapa frm = new frmModificaMapa();
            frm.mapa = bsMAPA.Current as MAPA;
            frm.ShowDialog();

            if (frm.DialogResult == DialogResult.OK)
            {
                await repositorio.Update(frm.mapa);
                bsMAPA.ResetBindings(false);
            }
            bsMAPA.DataSource = repositorio.FindAll();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            repositorio = new RepositorioMAPA();
            bsMAPA.DataSource = repositorio.FindAll();
            CmbPesquisar.Text = "";
        }

        private void txtPesquisar_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                repositorio = new RepositorioMAPA();
                bsMAPA.DataSource = repositorio.Find(CmbPesquisar.Text, txtPesquisar.Text);
            }
        }

        private void frmMapa_FormClosed(object sender, FormClosedEventArgs e)
        {
            repositorio = null;
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            bsMAPA.DataSource = repositorio.FindAll();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            repositorio = new RepositorioMAPA();
            bsMAPA.DataSource = repositorio.Find(CmbPesquisar.Text, txtPesquisar.Text);
        }

        private void CmbPesquisar_Click(object sender, EventArgs e)
        {

        }
    }
}
