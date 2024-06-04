using CLUSA;

namespace Trabalho
{
    public partial class frmAnvisa : Form
    {
        public frmAnvisa()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            Anvisa processo = new Anvisa();
            frmModificaAnvisa frm = new frmModificaAnvisa();
            frm.processo = processo;
            frm.ShowDialog();

            if (frm.DialogResult == DialogResult.OK)
            {
                await repositorio.Create(processo);
                bsAnvisa.Add(processo);
            }
        }

        private void frmAnvisa_Load(object sender, EventArgs e)
        {

        }
    }
}
