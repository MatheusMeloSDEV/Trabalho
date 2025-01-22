using CLUSA;

namespace Trabalho
{
    public partial class FrmAdmin : Form
    {
        public RepositorioUsers repositorio = new();
        public string usuario;

        public FrmAdmin()
        {
            InitializeComponent();
            usuario = FrmLogin.Instance.Logado.Usuario;
            // repositorio não precisa ser inicializado imediatamente
        }

        public void FrmADMIN_Load(object sender, EventArgs e)
        {
            repositorio = new RepositorioUsers();
            BSAdmin.DataSource = repositorio;
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
        }

        public async void BtnAdcionar_Click(object sender, EventArgs e)
        {
            Users users = new();
            FrmModificaAdmin form = new()
            {
                user = users
            };
            form.ShowDialog();

            if (form.DialogResult == DialogResult.OK)
            {
                await repositorio.Create(users);
                BSAdmin.Add(users);
            }
            BSAdmin.DataSource = repositorio.FindAll();
        }

        private async void BtnExcluir_Click(object sender, EventArgs e)
        {
            if (BSAdmin.Current is not Users currentUser)
            {
                throw new InvalidOperationException("Não foi possível obter o usuário atual.");
            }

            await repositorio.Delete(currentUser);
            BSAdmin.Remove(BSAdmin.Current as Users);
            BSAdmin.ResetBindings(false);
            BSAdmin.DataSource = repositorio.FindAll();
        }

        private async void BtnEditar_Click(object sender, EventArgs e)
        {
            FrmModificaAdmin frm = new()
            {
                user = BSAdmin.Current is Users currentUser ? currentUser : throw new InvalidOperationException("Não foi possível obter o usuário atual.")
            };
            frm.ShowDialog();

            if (frm.DialogResult == DialogResult.OK)
            {
                await repositorio.Udpate(frm.user);
                BSAdmin.ResetBindings(false);
            }
            BSAdmin.DataSource = repositorio.FindAll();
        }

        private void FrmADMIN_FormClosed(object sender, FormClosedEventArgs e)
        {
            repositorio = new();
        }
    }
}
