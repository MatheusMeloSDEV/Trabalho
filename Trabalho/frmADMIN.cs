using CLUSA;

namespace Trabalho
{
    public partial class FrmAdmin : Form
    {
        public RepositorioUsers? repositorio;
        public string usuario;

        public FrmAdmin()
        {
            InitializeComponent();
            usuario = FrmLogin.Instance.Logado.Usuario;
            // repositorio não precisa ser inicializado imediatamente
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
            FrmModificaAdmin form = new FrmModificaAdmin();
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
            var currentUser = BSAdmin.Current as Users;
            if (currentUser == null)
            {
                throw new InvalidOperationException("Não foi possível obter o usuário atual.");
            }

            await repositorio.Delete(currentUser, usuario);
            BSAdmin.Remove(BSAdmin.Current as Users);
            BSAdmin.ResetBindings(false);
            BSAdmin.DataSource = repositorio.FindAll();
        }

        private async void btnEditar_Click(object sender, EventArgs e)
        {
            FrmModificaAdmin frm = new FrmModificaAdmin();
            var currentUser = BSAdmin.Current as Users;
            frm.user = currentUser != null ? currentUser : throw new InvalidOperationException("Não foi possível obter o usuário atual.");
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
