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
            //bsAnvisa.DataSource = repositorio;
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
                //bsAnvisa.Add(anvisa);
            }
        }

        private void frmAnvisa_Load(object sender, EventArgs e)
        {

        }
    }
}
