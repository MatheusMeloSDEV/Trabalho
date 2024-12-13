using CLUSA;
using iText.Commons.Datastructures;
using MongoDB.Driver;
using System;
using System.Diagnostics;

namespace Trabalho
{
    public partial class frmProcesso : Form
    {
        private RepositorioProcesso _repositorio;

        public frmProcesso()
        {
            InitializeComponent();
        }

        private void frmProcesso_Load(object sender, EventArgs e)
        {
            _repositorio = new RepositorioProcesso();
            bsProcesso.DataSource = _repositorio.FindAll();
            dataGridView1.DataSource = bsProcesso;
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);

            if (frmLogin.instance.escuro)
                AplicarModoEscuro();

            PopularToolStripComboBox();
            ConfigurarAutoCompletarParaPesquisa();
        }

        private void AplicarModoEscuro()
        {
            BackColor = SystemColors.ControlDark;
            toolStrip1.BackColor = SystemColors.ControlDark;
            dataGridView1.BackgroundColor = SystemColors.ControlDarkDark;
        }

        private void PopularToolStripComboBox()
        {
            var camposIgnorados = new HashSet<string>
        {
            "Id", "TDecex", "TAnvisa", "TMapa", "TImetro", "TIbama",
            "PossuiEmbarque", "VencimentoFreeTime", "VencimentoFMA"
        };

            CmbPesquisar.Items.Clear();

            foreach (DataGridViewColumn coluna in dataGridView1.Columns)
            {
                if (!string.IsNullOrEmpty(coluna.DataPropertyName) &&
                    !camposIgnorados.Contains(coluna.DataPropertyName))
                {
                    CmbPesquisar.Items.Add(new DisplayItem(coluna.DataPropertyName, coluna.HeaderText));
                }
            }

            if (CmbPesquisar.Items.Count > 0)
                CmbPesquisar.SelectedIndex = 0;
        }

        private void ConfigurarAutoCompletarParaPesquisa()
        {
            if (CmbPesquisar.SelectedItem is DisplayItem campoSelecionado)
            {
                var valores = _repositorio.ObterValoresUnicos(campoSelecionado.DataPropertyName);
                ConfigurarAutoCompletar(txtPesquisar, valores);
            }
            else
            {
                MessageBox.Show("Selecione um campo para configurar o autocompletar.",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ConfigurarAutoCompletar(ToolStripTextBox textBox, IEnumerable<string> valores)
        {
            var autoCompleteCollection = new AutoCompleteStringCollection();
            autoCompleteCollection.AddRange(valores.ToArray());

            textBox.AutoCompleteCustomSource = autoCompleteCollection;
            textBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private async void btnAdicionar_Click(object sender, EventArgs e)
        {
            var processo = new Processo();
            using var frm = new frmModificaProcesso { processo = processo };
            frm.ShowDialog();

            if (frm.DialogResult == DialogResult.OK)
            {
                await _repositorio.Create(processo, "PROCESSO");
                bsProcesso.Add(processo);
                bsProcesso.ResetBindings(false);
            }
        }

        private async void btnExcluir_Click(object sender, EventArgs e)
        {
            if (bsProcesso.Current is not Processo processoSelecionado)
            {
                MessageBox.Show("Nenhum processo selecionado para exclusão.",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirmResult = MessageBox.Show(
                $"Tem certeza de que deseja excluir o processo '{processoSelecionado.Ref_USA}'?",
                "Confirmação de Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                await _repositorio.Delete(processoSelecionado);
                bsProcesso.Remove(processoSelecionado);
                bsProcesso.ResetBindings(false);
            }
        }

        private async void btnEditar_Click(object sender, EventArgs e)
        {
            if (bsProcesso.Current is not Processo processoAtual)
            {
                MessageBox.Show("Nenhum processo selecionado para edição.",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using var frm = new frmModificaProcesso { processo = processoAtual };
            frm.ShowDialog();

            if (frm.DialogResult == DialogResult.OK)
            {
                await _repositorio.Update(processoAtual);
                bsProcesso.DataSource = await _repositorio.FindAllAsync();
                bsProcesso.ResetBindings(false);
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (CmbPesquisar.SelectedItem is not DisplayItem campoSelecionado)
            {
                MessageBox.Show("Selecione um campo para pesquisar.",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var filtro = campoSelecionado.DataPropertyName;
            var pesquisa = txtPesquisar.Text;

            if (string.IsNullOrEmpty(pesquisa))
            {
                MessageBox.Show("Digite um valor para pesquisar.",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var resultados = _repositorio.Find(filtro, pesquisa);

            if (resultados.Any())
            {
                bsProcesso.DataSource = resultados;
                bsProcesso.ResetBindings(false);
            }
            else
            {
                MessageBox.Show("Nenhum resultado encontrado.",
                    "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var cell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
                var valorCelula = cell.Value?.ToString();
                var dataPropertyName = dataGridView1.Columns[e.ColumnIndex].DataPropertyName;

                if (!string.IsNullOrEmpty(dataPropertyName))
                {
                    bsProcesso.DataSource = _repositorio.Find(dataPropertyName, valorCelula);
                    bsProcesso.ResetBindings(false);
                }
            }
        }

        private string ExecutarScriptPython(string importador)
        {
            string pythonPath = @"C:\Users\mathe\AppData\Local\Programs\Python\Python313\python.exe";
            string scriptPath = @"C:\USA App\Python Program\index.py";

            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = pythonPath,
                Arguments = $"\"{scriptPath}\" \"{importador}\"",
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            try
            {
                using Process process = Process.Start(psi);
                string output = process.StandardOutput.ReadToEnd();
                string errors = process.StandardError.ReadToEnd();
                process.WaitForExit();

                return !string.IsNullOrEmpty(errors) ? $"Erro: {errors}" : output;
            }
            catch (Exception ex)
            {
                return $"Erro ao executar o script Python: {ex.Message}";
            }
        }

        private void BTNexportar_Click(object sender, EventArgs e)
        {
            var importadores = _repositorio.ObterImportadoresUnicos();

            using var form = new ImporterSelectionForm(importadores);
            if (form.ShowDialog() == DialogResult.OK)
            {
                string importador = form.SelectedImporter;

                using var progressForm = new ProgressForm();
                progressForm.Show();
                progressForm.Update();

                Task.Run(() =>
                {
                    string result = ExecutarScriptPython(importador);

                    Invoke(new Action(() =>
                    {
                        progressForm.Close();
                        MessageBox.Show(result, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }));
                });
            }
        }

        private void CmbPesquisar_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConfigurarAutoCompletarParaPesquisa();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            bsProcesso.DataSource = _repositorio.FindAll();
            bsProcesso.ResetBindings(false);
        }

        private void frmProcesso_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnPesquisar.PerformClick();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        public class DisplayItem
        {
            public string DataPropertyName { get; }
            public string HeaderText { get; }

            public DisplayItem(string dataPropertyName, string headerText)
            {
                DataPropertyName = dataPropertyName;
                HeaderText = headerText;
            }

            public override string ToString() => HeaderText;
        }
    }
}
