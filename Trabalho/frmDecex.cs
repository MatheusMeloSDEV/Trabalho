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
    }
}
