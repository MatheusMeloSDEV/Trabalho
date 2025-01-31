namespace Trabalho
{
    public partial class ImporterSelectionForm : Form
    {
        public string SelectedImporter { get; private set; } = string.Empty;

        public ImporterSelectionForm(List<string> importadores)
        {
            InitializeComponent();
            listBoxImportadores.Items.AddRange(importadores.ToArray());
        }

        private void BtnConfirmar_Click(object sender, EventArgs e)
        {
            if (listBoxImportadores.SelectedItem != null)
            {
                SelectedImporter = listBoxImportadores.SelectedItem?.ToString() ?? string.Empty;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Por favor, selecione um importador.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}
