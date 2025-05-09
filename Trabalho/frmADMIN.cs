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

        private async void BtnAdicionar_Click(object sender, EventArgs e)
        {
            // 1) Cria uma nova instância de Users e passa para o formulário
            var novoUsuario = new Users();
            using var form = new FrmModificaAdmin(novoUsuario);

            // 2) Exibe em modal e só prossegue se o usuário clicar em OK
            if (form.ShowDialog() == DialogResult.OK)
            {
                // 3) Persiste no banco
                await repositorio.CreateAsync(novoUsuario);

                // 4) Recarrega a lista inteira do BindingSource
                var todos = await repositorio.FindAllAsync();
                BSAdmin.DataSource = todos;
            }
        }

        private async void BtnExcluir_Click(object sender, EventArgs e)
        {
            if (BSAdmin.Current is not Users currentUser)
            {
                throw new InvalidOperationException("Não foi possível obter o usuário atual.");
            }

            await repositorio.DeleteAsync(currentUser);
            BSAdmin.Remove(BSAdmin.Current as Users);
            BSAdmin.ResetBindings(false);
            BSAdmin.DataSource = repositorio.FindAllAsync();
        }

        private async void BtnEditar_Click(object sender, EventArgs e)
        {
            // 1) Obtém o usuário selecionado no BindingSource
            if (BSAdmin.Current is not Users usuarioSelecionado)
            {
                MessageBox.Show("Selecione um usuário para editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2) Passa a instância existente para o formulário
            using var form = new FrmModificaAdmin(usuarioSelecionado);

            // 3) Se o usuário clicou em OK, atualiza
            if (form.ShowDialog() == DialogResult.OK)
            {
                await repositorio.UpdateAsync(usuarioSelecionado);

                // 4) Recarrega a lista inteira do BindingSource
                var todos = await repositorio.FindAllAsync();
                BSAdmin.DataSource = todos;
            }
        }
        private void FrmADMIN_FormClosed(object sender, FormClosedEventArgs e)
        {
            repositorio = new();
        }
    }
}
