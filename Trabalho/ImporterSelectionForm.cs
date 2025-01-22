using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho
{
    public partial class ImporterSelectionForm : Form
    {
        public string SelectedImporter { get; private set; }

        public ImporterSelectionForm(List<string> importadores)
        {
            InitializeComponent();
            listBoxImportadores.Items.AddRange(importadores.ToArray());

            SelectedImporter = ""; // valor padrão (string vazia, por exemplo)
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
