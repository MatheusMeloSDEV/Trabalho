using CLUSA;

namespace Trabalho
{
    public partial class frmADMIN : Form
    {
        private RepositorioUsers repositorio;
        public frmADMIN()
        {
            InitializeComponent();
        }

        private void frmADMIN_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Users users = new Users();
            users.Username = txtUsername.Text;
            users.Password = txtPassword.Text;
            repositorio = new RepositorioUsers(users);
            repositorio.Create(users);
        }
    }
}
