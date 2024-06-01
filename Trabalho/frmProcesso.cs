using CLUSA;

namespace Trabalho
{
    public partial class frmProcesso : Form
    {
        private RepositorioProcesso repositorio;
        public frmProcesso()
        {
            InitializeComponent();
        }

        private void frmProcesso_Load(object sender, EventArgs e)
        {

            repositorio = new RepositorioProcesso();
            //bsProcesso.DataSource = repositorio;


        }

        private async void btnAdicionar_Click(object sender, EventArgs e)
        {
            Processo processo = new Processo();
            frmModificaProcesso frm = new frmModificaProcesso();
            //frm.processo = processo;
            frm.ShowDialog();

            if (frm.DialogResult == DialogResult.OK)

                await repositorio.Create(processo);
            //bsProcesso.Add(processo);


        }

        private async void btnExcluir_Click(object sender, EventArgs e)
        {

            //await repositorio.Delete(bsProcesso.Current as Processo);
            //bsProcesso.Remove(bsProcesso.Current as Processo);
            //bsProcesso.ResetBindings(false);
            //bsProcesso.DataSource = repositorio.FindAll();


        }

        private async void btnEditar_Click(object sender, EventArgs e)
        {
            frmModificaProcesso frm = new frmModificaProcesso();
            //frm.processo = bsProcesso.Current as Processo;
            frm.ShowDialog();

            if (frm.DialogResult == DialogResult.OK)
            {
                //await repositorio.Udpate(frm.processo);
                //bsProcesso.ResetBindings(false);
            }
            //bsProcesso.DataSource = repositorio.FindAll();

        }
    }
}
