using CLUSA;
using Microsoft.VisualBasic.ApplicationServices;


namespace Trabalho
{
    public partial class frmLogin : Form
    {
        private RepositorioUsers repositorio;
        frmLogin principal;
        frmMapa mapa;
        frmADMIN admin;
        frmDecex decex;
        frmMenu menu;
        public static frmLogin instance;
        public Logado logado;
        public frmLogin()
        {
            InitializeComponent();
            instance = this;
        }
        private void frmPricipal_Load(object sender, EventArgs e)
        {
            repositorio = new RepositorioUsers();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            Users users = new Users();
            users.Username = txtUsername.Text;
            users.Password = txtPassword.Text;

            btnLogin.Visible = false;
            try
            {
                logado = repositorio.Login(users);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            if (logado.log)
            {
                lblPassword.Visible = false;
                txtPassword.Visible = false;
                lblUsername.Visible = false;
                txtUsername.Visible = false;
                btnLogin.Visible = false;
                lblError.Visible = false;


                tLogado.Interval = 3000;
                tLogado.Tick += new System.EventHandler(this.timer1_Tick);
                check.Visible = true;
                lblLogado.Visible = true;
                tLogado.Start();

                frmMenu frm = new frmMenu();
                frm.ShowDialog();

                if (frm.DialogResult == DialogResult.OK)
                {
                    this.Show();
                    txtPassword.Text = "";
                    txtUsername.Text = "";
                    lblPassword.Visible = true;
                    txtPassword.Visible = true;
                    lblUsername.Visible = true;
                    txtUsername.Visible = true;
                    btnLogin.Visible = true;
                    
                }
            }
            else
            {
                tErro.Interval = 3000;
                tErro.Tick += new System.EventHandler(this.tErro_Tick);
                lblError.Visible = true;
                btnLogin.Visible = true;
                tErro.Start();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tLogado.Stop();
            check.Visible = false;
            lblLogado.Visible = false;
            this.Hide();
        }

        private void tErro_Tick(object sender, EventArgs e)
        {
            tErro.Stop();
            lblError.Visible = false;

        }
        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
