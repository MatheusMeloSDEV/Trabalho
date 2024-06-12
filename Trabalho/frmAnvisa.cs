using CLUSA;

namespace Trabalho
{
    public partial class frmAnvisa : Form
    {
        private RepositorioAnvisa repositorio;
        public frmAnvisa()
        {
            InitializeComponent();
            repositorio = new RepositorioAnvisa();
            bsAnvisa.DataSource = repositorio;
        }

        private async void btnAdicionar_Click(object sender, EventArgs e)
        {
            Anvisa anvisa = new Anvisa();
            frmModificaAnvisa frm = new frmModificaAnvisa();
            frm.anvisa = anvisa;
            frm.ShowDialog();

            if (frm.DialogResult == DialogResult.OK)
            {
                await repositorio.Create(anvisa);
                bsAnvisa.Add(anvisa);
            }
        }

        private void frmAnvisa_Load(object sender, EventArgs e)
        {

        }

        private async void btnEditar_Click(object sender, EventArgs e)
        {
            frmModificaAnvisa frm = new frmModificaAnvisa();
            frm.anvisa = bsAnvisa.Current as Anvisa;
            frm.ShowDialog();

            if (frm.DialogResult == DialogResult.OK)
            {
                await repositorio.Udpate(frm.anvisa);
                bsAnvisa.ResetBindings(false);
            }
            bsAnvisa.DataSource = repositorio.FindAll();
        }

        private async void btnExcluir_Click(object sender, EventArgs e)
        {
            await repositorio.Delete(bsAnvisa.Current as Anvisa);
            bsAnvisa.Remove(bsAnvisa.Current as Anvisa);
            bsAnvisa.ResetBindings(false);
            bsAnvisa.DataSource = repositorio.FindAll();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            repositorio = new RepositorioAnvisa();
            bsAnvisa.DataSource = repositorio.FindAll();
            CmbPesquisar.Text = "";
            txtPesquisar.Text = "";
        }
    }
}
