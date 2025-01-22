using CLUSA;

namespace Trabalho
{
    public partial class FrmModificaAdmin : Form
    {
        public Users user = null!;
        public bool block = false;
        public FrmModificaAdmin()
        {
            InitializeComponent();
        }

        public void FrmModificaAdmin_Load(object sender, EventArgs e)
        {
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            BsModificaAdmin.DataSource = user;
        }

        public void BtnEnviar_Click(object sender, EventArgs e)
        {
            if (!Check())
            {
                user.Username = txtUsername.Text;
                user.Password = txtPassword.Text;
                user.Admin = cbAdmin.Checked;
                this.DialogResult = DialogResult.OK;
            }
        }
        public bool Check()
        {
            if (txtPassword.Text == "")
            {
                tErro.Interval = 3000;
                tErro.Tick += new System.EventHandler(this.TErro_Tick);
                txtPassword.BackColor = Color.MistyRose;
                tErro.Start();
                block = true;
            }
            if (txtUsername.Text == "")
            {
                tErro.Interval = 3000;
                tErro.Tick += new System.EventHandler(this.TErro_Tick);
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

        private void TErro_Tick(object? sender, EventArgs e)
        {
            txtPassword.BackColor = Color.White;
            txtUsername.BackColor = Color.White;
            tErro.Stop();
        }
    }
}
