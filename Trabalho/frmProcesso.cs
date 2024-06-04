using CLUSA;

namespace Trabalho
{
    public partial class frmProcesso : Form
    {
        private RepositorioProcesso repositorio;
        public frmProcesso()
        {
            InitializeComponent();
            repositorio = new RepositorioProcesso();
            bsProcesso.DataSource = repositorio;
        }

        private async void btnAdicionar_Click(object sender, EventArgs e)
        {
            Processo processo = new Processo();
            frmModificaProcesso frm = new frmModificaProcesso();
            frm.processo = processo;
            frm.ShowDialog();

            if (frm.DialogResult == DialogResult.OK)
            {
                await repositorio.Create(processo);
                bsProcesso.Add(processo);
            }
        }

        private void frmProcesso_Load(object sender, EventArgs e)
        {

        }
    }
}
