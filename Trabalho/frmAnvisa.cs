using CLUSA;

namespace Trabalho
{
    public partial class frmAnvisa : Form
    {
        private RepositorioAnvisa repositorio;
        public frmAnvisa()
        {
            InitializeComponent();
            repositorio = new RepositorioAnvisa();
            bsAnvisa.DataSource = repositorio;
        }

        private void frmAnvisa_Load(object sender, EventArgs e)
        {
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            if (frmLogin.instance.escuro)
            {
                DarkMode();
            }
        }

        private void DarkMode()
        {
            toolStrip1.BackColor = SystemColors.ControlDark;
            this.BackColor = SystemColors.ControlDark;
            CmbPesquisar.BackColor = SystemColors.ControlDarkDark;
            txtPesquisar.BackColor = SystemColors.ControlDarkDark;
        }

        private async void btnEditar_Click(object sender, EventArgs e)
        {
            frmModificaAnvisa frm = new frmModificaAnvisa();
            frm.anvisa = bsAnvisa.Current as Anvisa;
            frm.ShowDialog();

            if (frm.DialogResult == DialogResult.OK)
            {
                await repositorio.Udpate(frm.anvisa);
                bsAnvisa.ResetBindings(false);
            }
            bsAnvisa.DataSource = repositorio.FindAll();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var cell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];

                string valorCelula = cell.Value?.ToString();

                string dataPropertyName = dataGridView1.Columns[e.ColumnIndex].DataPropertyName;

                if (!string.IsNullOrEmpty(dataPropertyName))
                {
                    MessageBox.Show($"Valor da célula: {valorCelula}\nDataPropertyName: {dataPropertyName}",
                                    "Pesquisa",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);

                    bsAnvisa.DataSource = repositorio.Find(dataPropertyName, valorCelula);
                }
                else
                {
                    MessageBox.Show("DataPropertyName não definido para esta coluna.",
                                    "Erro",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                }
            }
        }
    }
}
