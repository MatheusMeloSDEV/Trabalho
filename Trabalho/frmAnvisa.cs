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
    }
}
