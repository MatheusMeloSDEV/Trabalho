namespace Trabalho
{
    public partial class frmDocumento : Form
    {
        public string NomeDocumento { get; private set; }
        public string NumeroDocumento { get; private set; }

        public frmDocumento()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (cboDocumento.SelectedIndex < 0 || string.IsNullOrWhiteSpace(txtNumero.Text))
            {
                MessageBox.Show("Preencha todos os campos!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            NomeDocumento = cboDocumento.SelectedItem.ToString();
            NumeroDocumento = txtNumero.Text.Trim();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
