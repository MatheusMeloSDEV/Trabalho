using CLUSA;
using System.Windows.Forms;

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
            txtPesquisar.BackColor = SystemColors.ControlDarkDark;
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
    }
}
