using CLUSA;

namespace Trabalho
{
    public partial class frmProcesso : Form
    {
        private RepositorioProcesso repositorio;
        public frmProcesso()
        {
            InitializeComponent();
            repositorio = new RepositorioProcesso();
            bsProcesso.DataSource = repositorio;
        }

        private async void btnAdicionar_Click(object sender, EventArgs e)
        {
            Processo processo = new Processo();
            frmModificaProcesso frm = new frmModificaProcesso();
            frm.processo = processo;
            frm.ShowDialog();

            if (frm.DialogResult == DialogResult.OK)
            {
                await repositorio.Create(processo);
                bsProcesso.Add(processo);
            }
        }

        private async void btnExcluir_Click(object sender, EventArgs e)
        {
            await repositorio.Delete(bsProcesso.Current as Processo);
            bsProcesso.Remove(bsProcesso.Current as Processo);
            bsProcesso.ResetBindings(false);
            bsProcesso.DataSource = repositorio.FindAll();
        }

        private async void btnEditar_Click(object sender, EventArgs e)
        {
            frmModificaProcesso frm = new();
            frm.processo = bsProcesso.Current as Processo;
            frm.ShowDialog();

            if (frm.DialogResult == DialogResult.OK)
            {
                await repositorio.Update(frm.processo);
                bsProcesso.ResetBindings(false);
            }
            bsProcesso.DataSource = repositorio.FindAll();
        }

        private void CmbPesquisar_Click(object sender, EventArgs e)
        {

        }

        private void txtPesquisar_Click(object sender, EventArgs e)
        {

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            repositorio = new RepositorioProcesso();
            bsProcesso.DataSource = repositorio.Find(CmbPesquisar.Text, txtPesquisar.Text);
        }

        private void frmProcesso_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                string columnName = dataGridView1.Columns[e.ColumnIndex].Name;

                object cellValue = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;

                string cellText = cellValue != null ? cellValue.ToString() : "Célula vazia";

                bsProcesso.DataSource = repositorio.Find(CmbPesquisar.Text = columnName, txtPesquisar.Text = cellText);
            }
        }
    }
}
