using CLUSA;

namespace Trabalho
{
    public partial class frmDecex : Form
    {
        private RepositorioDecex repositorio;
        public frmDecex()
        {
            InitializeComponent();
            repositorio = new RepositorioDecex();
            bsDecex.DataSource = repositorio;
        }

        private void frmDecex_Load(object sender, EventArgs e)
        {

        }

        private async void btnAdicionar_Click(object sender, EventArgs e)
        {
            Decex decex = new Decex();
            frmModificaDecex frm = new frmModificaDecex();
            frm.decex = decex;
            frm.ShowDialog();

            if (frm.DialogResult == DialogResult.OK)
            {
                await repositorio.Create(decex);
                bsDecex.Add(decex);
            }
        }

        private async void btnEditar_Click(object sender, EventArgs e)
        {
            frmModificaDecex frm = new frmModificaDecex();
            frm.decex = bsDecex.Current as Decex;
            frm.ShowDialog();

            if (frm.DialogResult == DialogResult.OK)
            {
                await repositorio.Udpate(frm.decex);
                bsDecex.ResetBindings(false);
            }
            bsDecex.DataSource = repositorio.FindAll();
        }

        private async void btnExcluir_Click(object sender, EventArgs e)
        {
            await repositorio.Delete(bsDecex.Current as Decex);
            bsDecex.Remove(bsDecex.Current as Decex);
            bsDecex.ResetBindings(false);
            bsDecex.DataSource = repositorio.FindAll();
        }

        private void CmbPesquisar_Click(object sender, EventArgs e)
        {

        }
    }
}
