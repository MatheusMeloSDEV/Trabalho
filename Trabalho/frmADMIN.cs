using CLUSA;

namespace Trabalho
{
    public partial class frmADMIN : Form
    {
        public RepositorioUsers repositorio;
        public string usuario;
        public frmADMIN()
        {
            InitializeComponent();
            usuario = frmLogin.instance.logado.Usuario;
        }

        public void frmADMIN_Load(object sender, EventArgs e)
        {
            repositorio = new RepositorioUsers();
            BSAdmin.DataSource = repositorio;
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
        }

        public async void btnAdcionar_Click(object sender, EventArgs e)
        {
            Users users = new Users();
            frmModificaAdmin form = new frmModificaAdmin();
            form.user = users;
            form.ShowDialog();

            if (form.DialogResult == DialogResult.OK)
            {
                await repositorio.Create(users, usuario);
                BSAdmin.Add(users);
            }
            BSAdmin.DataSource = repositorio.FindAll();
        }

        private async void btnExcluir_Click(object sender, EventArgs e)
        {
            await repositorio.Delete(BSAdmin.Current as Users, usuario);
            BSAdmin.Remove(BSAdmin.Current as Users);
            BSAdmin.ResetBindings(false);
            BSAdmin.DataSource = repositorio.FindAll();
        }

        private async void btnEditar_Click(object sender, EventArgs e)
        {
            frmModificaAdmin frm = new frmModificaAdmin();
            frm.user = BSAdmin.Current as Users;
            frm.ShowDialog();

            if (frm.DialogResult == DialogResult.OK)
            {
                await repositorio.Udpate(frm.user, usuario);
                BSAdmin.ResetBindings(false);
            }
            BSAdmin.DataSource = repositorio.FindAll();
        }

        private void frmADMIN_FormClosed(object sender, FormClosedEventArgs e)
        {
            repositorio = null;
        }
    }
}
