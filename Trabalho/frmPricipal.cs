using CLUSA;


namespace Trabalho
{
    public partial class frmPricipal : Form
    {
        private RepositorioUsers repositorio;
        frmPricipal principal;
        frmMapa mapa;
        frmADMIN admin;
        frmDecex decex;
        public frmPricipal()
        {
            InitializeComponent();
        }
        private void frmPricipal_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Users users = new Users();
            users.Username = txtUsername.Text;
            users.Password = txtPassword.Text;
            repositorio = new RepositorioUsers(users);
            bool Logado = repositorio.Login(users.Username, users.Password);
            if (Logado)
            {
                lblPassword.Visible = false;
                txtPassword.Visible = false;
                lblUsername.Visible = false;
                txtUsername.Visible = false;
                btnLogin.Visible = false;
                
                
                timer1.Interval = 3000;
                timer1.Tick += new System.EventHandler(this.timer1_Tick);
                check.Visible = true;
                lblLogado.Visible = true;
                timer1.Start();
            }
            else
            {
                lblError.Visible = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            check.Visible = false;
            lblLogado.Visible = false;
        }
    }
}
