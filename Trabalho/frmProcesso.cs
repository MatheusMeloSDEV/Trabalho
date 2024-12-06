using CLUSA;
using iText.Commons.Datastructures;
using MongoDB.Driver;
using System;
using System.Diagnostics;

namespace Trabalho
{
    public partial class frmProcesso : Form
    {
        private RepositorioProcesso repositorio;
        public frmProcesso()
        {
            InitializeComponent();
        }
        private void frmProcesso_Load(object sender, EventArgs e)
        {
            repositorio = new();
            bsProcesso.DataSource = repositorio;
            dataGridView1.DataSource = bsProcesso;
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            if (frmLogin.instance.escuro)
            {
                DarkMode();
            }
            // Preencher o ToolStripComboBox
            PopularToolStripComboBox();

            // Configurar o autocompletar para o campo inicial
            ConfigurarAutoCompletarParaPesquisa();
        }
        private void ConfigurarAutoCompletarParaPesquisa()
        {
            // Obter o campo selecionado no ToolStripComboBox
            var campoSelecionado = CmbPesquisar.SelectedItem as DisplayItem;

            if (campoSelecionado == null)
            {
                MessageBox.Show("Selecione um campo para configurar o autocompletar.",
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string dataPropertyName = campoSelecionado.DataPropertyName;

            // Buscar os valores únicos no MongoDB
            var valores = repositorio.ObterValoresUnicos(dataPropertyName);

            // Configurar o autocompletar no TextBox
            ConfigurarAutoCompletar(txtPesquisar, valores);
        }
        private void ConfigurarAutoCompletar(ToolStripTextBox textBox, IEnumerable<string> valores)
        {
            // Criar a coleção para autocompletar
            var autoCompleteCollection = new AutoCompleteStringCollection();
            autoCompleteCollection.AddRange(valores.ToArray());

            // Configurar o TextBox para usar o autocompletar
            textBox.AutoCompleteCustomSource = autoCompleteCollection;
            textBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }
        private void PopularToolStripComboBox()
        {
            // Lista de campos a serem ignorados
            var camposIgnorados = new HashSet<string>
            {
                "Id",
                "TDecex",
                "TAnvisa",
                "TMapa",
                "TImetro",
                "TIbama",
                "PossuiEmbarque",
                "VencimentoFreeTime",
                "VencimentoFMA"
            };

            // Limpar o ToolStripComboBox antes de adicionar os itens
            CmbPesquisar.Items.Clear();

            // Adicionar os HeaderTexts e DataPropertyNames das colunas do DataGridView
            foreach (DataGridViewColumn coluna in dataGridView1.Columns)
            {
                if (!string.IsNullOrEmpty(coluna.DataPropertyName) &&
                    !camposIgnorados.Contains(coluna.DataPropertyName)) // Excluir campos ignorados
                {
                    // Adicionar diretamente o HeaderText ao ToolStripComboBox
                    CmbPesquisar.Items.Add(new DisplayItem(coluna.DataPropertyName, coluna.HeaderText));
                }
            }

            // Selecionar o primeiro item por padrão, se houver itens
            if (CmbPesquisar.Items.Count > 0)
            {
                CmbPesquisar.SelectedIndex = 0;
            }
        }

        // Classe auxiliar para exibir HeaderText, mas armazenar DataPropertyName
        public class DisplayItem
        {
            public string DataPropertyName { get; }
            public string HeaderText { get; }

            public DisplayItem(string dataPropertyName, string headerText)
            {
                DataPropertyName = dataPropertyName;
                HeaderText = headerText;
            }

            public override string ToString()
            {
                return HeaderText; // Exibir apenas o HeaderText no ComboBox
            }
        }


        private async void btnAdicionar_Click(object sender, EventArgs e)
        {
            Processo processo = new();
            frmModificaProcesso frm = new();
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
            // Obter o processo selecionado
            var processoSelecionado = bsProcesso.Current as Processo;

            if (processoSelecionado == null)
            {
                MessageBox.Show("Nenhum processo selecionado para exclusão.",
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Exibir uma mensagem de confirmação com o RefUsa
            var confirmResult = MessageBox.Show(
                $"Tem certeza de que deseja excluir o processo: '{processoSelecionado.Ref_USA}'?",
                "Confirmação de Exclusão",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                // Executar a exclusão
                await repositorio.Delete(processoSelecionado);

                // Remover da fonte de dados
                bsProcesso.Remove(processoSelecionado);
                bsProcesso.ResetBindings(false);

                // Atualizar a lista de processos
                bsProcesso.DataSource = repositorio.FindAll();

                MessageBox.Show("Processo excluído com sucesso.",
                                "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private async void btnEditar_Click(object sender, EventArgs e)
        {
            frmModificaProcesso frm = new()
            {
                processo = bsProcesso.Current as Processo
            };
            Processo pr = new()
            {
                TMapa = frm.processo.TMapa,
                TDecex = frm.processo.TDecex,
                TAnvisa = frm.processo.TAnvisa,
                TIbama = frm.processo.TIbama,
                TImetro = frm.processo.TImetro
            };
            frm.ShowDialog();

            if (frm.DialogResult == DialogResult.OK)
            {
                if (pr.TMapa != frm.processo.TMapa)
                {
                    if (frm.processo.TMapa)
                    {
                        await repositorio.Create(frm.processo);
                        bsProcesso.Add(frm.processo);
                    }
                }
                if (pr.TDecex != frm.processo.TDecex)
                {
                    if (frm.processo.TDecex)
                    {
                        await repositorio.Create(frm.processo);
                        bsProcesso.Add(frm.processo);
                    }
                }
                if (pr.TAnvisa != frm.processo.TAnvisa)
                {
                    if (frm.processo.TAnvisa)
                    {
                        await repositorio.Create(frm.processo);
                        bsProcesso.Add(frm.processo);
                    }
                }
                if (pr.TImetro != frm.processo.TImetro)
                {
                    if (frm.processo.TImetro)
                    {
                        await repositorio.Create(frm.processo);
                        bsProcesso.Add(frm.processo);
                    }
                }
                if (pr.TIbama != frm.processo.TIbama)
                {
                    if (frm.processo.TIbama)
                    {
                        await repositorio.Create(frm.processo);
                        bsProcesso.Add(frm.processo);
                    }
                }
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
            if (CmbPesquisar.SelectedItem is DisplayItem campoSelecionado)
            {
                string dataPropertyName = campoSelecionado.DataPropertyName;
                string textoPesquisa = txtPesquisar.Text;

                if (string.IsNullOrEmpty(textoPesquisa))
                {
                    MessageBox.Show("Digite um valor para pesquisar.",
                                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                try
                {
                    // Buscar os dados no MongoDB
                    var resultados = repositorio.Find(dataPropertyName, textoPesquisa);

                    if (resultados.Any())
                    {
                        bsProcesso.DataSource = resultados; // Atualizar o BindingSource com os novos resultados
                        bsProcesso.ResetBindings(false);    // Atualizar o DataGridView
                        Console.WriteLine($"Filtro aplicado: {dataPropertyName} com pesquisa '{textoPesquisa}'. Itens encontrados: {resultados.Count}");
                    }
                    else
                    {
                        MessageBox.Show("Nenhum resultado encontrado para os critérios de pesquisa.",
                                        "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao buscar dados: {ex.Message}",
                                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Selecione um campo para pesquisar.",
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }


        private void DarkMode()
        {
            this.BackColor = SystemColors.ControlDark;
            toolStrip1.BackColor = SystemColors.ControlDark;
            dataGridView1.BackgroundColor = SystemColors.ControlDarkDark;
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

                    bsProcesso.DataSource = repositorio.Find(dataPropertyName, valorCelula);
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

        private string ExecutarScriptPython(string importador)
        {
            // Caminho do Python e do Script
            string pythonPath = @"C:\Users\mathe\AppData\Local\Programs\Python\Python313\python.exe";
            string scriptPath = @"C:\USA App\Python Program\index.py";

            // Configurar o processo
            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = pythonPath,
                Arguments = $"\"{scriptPath}\" \"{importador}\"", // Passar o importador como argumento
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            try
            {
                // Iniciar o processo
                using (Process process = Process.Start(psi))
                {
                    // Capturar a saída
                    string output = process.StandardOutput.ReadToEnd();
                    string errors = process.StandardError.ReadToEnd();

                    process.WaitForExit();

                    if (!string.IsNullOrEmpty(errors))
                    {
                        return $"Erro ao executar o script Python:\n{errors}";
                    }

                    return $"Saída do Python:\n{output}";
                }
            }
            catch (Exception ex)
            {
                return $"Erro ao executar o script Python:\n{ex.Message}";
            }
        }


        private void BTNexportar_Click(object sender, EventArgs e)
        {
            // Obter importadores únicos do MongoDB
            var processoRepo = new RepositorioProcesso();
            var importadores = processoRepo.ObterImportadoresUnicos();

            // Abrir o formulário de seleção de importador
            var form = new ImporterSelectionForm(importadores);
            if (form.ShowDialog() == DialogResult.OK)
            {
                // Importador selecionado pelo usuário
                string importador = form.SelectedImporter;

                // Mostrar o ProgressForm
                ProgressForm progressForm = new ProgressForm();
                progressForm.Show();
                progressForm.Update();

                // Executar o script Python em segundo plano
                Task.Run(() =>
                {
                    string result = ExecutarScriptPython(importador);

                    // Voltar à thread principal para atualizar a interface
                    Invoke(new Action(() =>
                    {
                        // Fechar o ProgressForm
                        if (progressForm != null && !progressForm.IsDisposed)
                        {
                            progressForm.Close();
                            progressForm.Dispose();
                        }

                        // Mostrar o resultado
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
            try
            {
                // Buscar todos os processos no MongoDB
                var todosProcessos = repositorio.FindAll(); // Método para buscar todos os documentos

                // Atualizar o BindingSource
                bsProcesso.DataSource = todosProcessos;
                bsProcesso.ResetBindings(false); // Atualizar o DataGridView

                Console.WriteLine($"Total de processos carregados: {todosProcessos.Count}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar todos os processos: {ex.Message}",
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmProcesso_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnPesquisar.PerformClick(); // Simula o clique no ToolStripButton
                e.Handled = true; // Marca o evento como tratado
                e.SuppressKeyPress = true; // Impede que o Enter insira uma nova linha ou emita outro som
            }
        }
    }
}
