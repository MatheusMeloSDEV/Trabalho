using Amazon.Util;
using CLUSA;
using MongoDB.Driver.Linq;
using Trabalho;

namespace Trabalho
{
    public partial class frmMapa : Form
    {
        private RepositorioMAPA repositorio;
        public frmMapa()
        {
            InitializeComponent();
            repositorio = new RepositorioMAPA();
        }

        private void frmMapa_Load(object sender, EventArgs e)
        {
            bsMAPA.DataSource = repositorio;
        }
        private void btnMAPAEditar_Click(object sender, EventArgs e)
        {
            frmModifica frm = new frmModifica();
            frm.mapa = bsMAPA.Current as MAPA;
            frm.ShowDialog();

            if (frm.DialogResult == DialogResult.OK)
            {
                repositorio.Udpate(frm.mapa);
                bsMAPA.ResetBindings(false);
            }
        }

        private void btnCancelaPesquisa_Click(object sender, EventArgs e)
        {
            repositorio = new RepositorioMAPA();
            bsMAPA.DataSource = repositorio.FindAll();
        }

        private void btnAdicionar_click(object sender, EventArgs e)
        {
            MAPA mapa = new MAPA();
            frmModifica frm = new frmModifica();
            frm.mapa = mapa;
            frm.ShowDialog();

            if (frm.DialogResult == DialogResult.OK)
            {
                repositorio.Create(mapa);
                bsMAPA.Add(mapa);
            }
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            repositorio.Delete(bsMAPA.Current as MAPA);
            bsMAPA.Remove(bsMAPA.Current as MAPA);
            bsMAPA.ResetBindings(false);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            frmModifica frm = new frmModifica();
            frm.mapa = bsMAPA.Current as MAPA;
            frm.ShowDialog();

            if (frm.DialogResult == DialogResult.OK)
            {
                repositorio.Udpate(frm.mapa);
                bsMAPA.ResetBindings(false);
            }
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            repositorio = new RepositorioMAPA();
            bsMAPA.DataSource = repositorio.FindAll();
            CmbPesquisar.Text = "";
        }

        private void txtPesquisar_KeyUp(object sender, KeyEventArgs e)
        {
            repositorio = new RepositorioMAPA();
            bsMAPA.DataSource = repositorio.Find(CmbPesquisar.Text, txtPesquisar.Text);
        }

        private void CmbPesquisar_Click(object sender, EventArgs e)
        {

        }
        private void frmMapa_FormClosed(object sender, FormClosedEventArgs e)
        {
            repositorio = null;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_Layout(object sender, LayoutEventArgs e)
        {
        }
    }
}
