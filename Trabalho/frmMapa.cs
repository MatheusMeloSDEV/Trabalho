using CLUSA;

namespace Trabalho
{
    public partial class frmMapa : Form
    {
        private RepositorioMAPA repositorio;
        public frmMapa()
        {
            InitializeComponent();
        }

        private void btnMAPAEnviar_Click(object sender, EventArgs e)
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

        private void frmMapa_Load(object sender, EventArgs e)
        {
            repositorio = new RepositorioMAPA();
            bsMAPA.DataSource = repositorio;
        }

        private void btnMAPAExcluir_Click(object sender, EventArgs e)
        {
            repositorio.Delete(bsMAPA.Current as MAPA);
            bsMAPA.Remove(bsMAPA.Current as MAPA);
            bsMAPA.ResetBindings(false);
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
    }
}
