using CLUSA;

namespace Trabalho
{
    public partial class frmModificaAdmin : Form
    {
        public Users user;
        public bool block = false;
        public frmModificaAdmin()
        {
            InitializeComponent();
        }

        public void frmModificaAdmin_Load(object sender, EventArgs e)
        {
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            BsModificaAdmin.DataSource = user;
        }

        public void btnEnviar_Click(object sender, EventArgs e)
        {
            if (!check())
            {
                user.Username = txtUsername.Text;
                user.Password = txtPassword.Text;
                user.Admin = cbAdmin.Checked;
                this.DialogResult = DialogResult.OK;
            }
        }
        public bool check()
        {
            if (txtPassword.Text == "")
            {
                tErro.Interval = 3000;
                tErro.Tick += new System.EventHandler(this.tErro_Tick);
                txtPassword.BackColor = Color.MistyRose;
                tErro.Start();
                block = true;
            }
            if (txtUsername.Text == "")
            {
                tErro.Interval = 3000;
                tErro.Tick += new System.EventHandler(this.tErro_Tick);
                txtUsername.BackColor = Color.MistyRose;
                tErro.Start();
                block = true;
            }
            if (block)
            {
                MessageBox.Show("Preencha todos os dados.");
            }
            return block;
        }

        private void tErro_Tick(object sender, EventArgs e)
        {
            txtPassword.BackColor = Color.White;
            txtUsername.BackColor = Color.White;
            tErro.Stop();
        }
    }
}
