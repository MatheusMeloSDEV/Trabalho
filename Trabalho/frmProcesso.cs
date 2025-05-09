using CLUSA;
using MongoDB.Driver;
using System.Diagnostics;

namespace Trabalho
{
    public partial class FrmProcesso : Form
    {
        private readonly RepositorioProcesso _repositorio;

        public FrmProcesso()
        {
            InitializeComponent();
            _repositorio = new RepositorioProcesso(); // Inicialização direta
            try
            {
                try
                {
                    ConectarProcesso();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao carregar o formulário: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                ConfigurarInterface();
                PopularToolStripComboBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar os dados: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private static Image? CarregarImagemDoRecurso(string caminhoRecurso)
        {
            var assembly = System.Reflection.Assembly.GetExecutingAssembly();
            using var stream = assembly.GetManifestResourceStream(caminhoRecurso);
            return stream != null ? Image.FromStream(stream) : null;
        }
        private void ConectarProcesso()
        {
            try
            {
                ConfigurarColunasDataGridViewProcesso();

                // Recupera os registros do repositório
                var registros = _repositorio.FindAll(); 
                if (registros.Count > 0)
                {
                    // Configura o BindingSource e o DataGridView
                    BsProcesso = new BindingSource
                    {
                        DataSource = registros
                    };

                    DataGridView1.DataSource = BsProcesso;
                }
                else
                {
                    MessageBox.Show("Nenhum registro foi encontrado para carregar no DataGridView.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                // Captura e exibe erros
                MessageBox.Show($"Erro ao carregar o DataGridView: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ConfigurarColunasDataGridViewProcesso()
        {
            DataGridView1.Columns.Clear();

            // Configuração básica
            DataGridView1.AutoGenerateColumns = false;
            DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridView1.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.True;
            DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridView1.RowHeadersVisible = false;
            DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            DataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            // Ref. USA - menor peso
            DataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Ref_USA",
                HeaderText = "Ref. USA",
                Name = "ColunaRefUSA",
                FillWeight = 40
            });

            // S. Ref - menor peso
            DataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "SR",
                HeaderText = "S. Ref",
                Name = "ColunaSR",
                FillWeight = 40
            });

            // Importador
            DataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Importador",
                HeaderText = "Importador",
                Name = "ColunaImportador",
                FillWeight = 80
            });

            // Exportador
            DataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Exportador",
                HeaderText = "Exportador",
                Name = "ColunaExportador",
                FillWeight = 80
            });

            // Produto
            DataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Produto",
                HeaderText = "Produto",
                Name = "ColunaProduto",
                FillWeight = 80
            });

            // Navio
            DataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Navio",
                HeaderText = "Navio",
                Name = "ColunaNavio",
                FillWeight = 80
            });

            // Porto Destino
            DataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "PortoDestino",
                HeaderText = "Porto Destino",
                Name = "ColunaPortoDestino",
                FillWeight = 80
            });

            // Pendência (texto longo com quebra de linha)
            DataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Pendencia",
                HeaderText = "Pendência",
                Name = "ColunaPendencia",
                FillWeight = 120,
                DefaultCellStyle = new DataGridViewCellStyle { WrapMode = DataGridViewTriState.True }
            });


            // 2) Estilo geral
            foreach (DataGridViewColumn coluna in DataGridView1.Columns)
            {
                coluna.DefaultCellStyle.Font = new Font("Segoe UI", 10);
                coluna.DefaultCellStyle.ForeColor = Color.Black;
                coluna.DefaultCellStyle.BackColor = Color.White;
                coluna.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
                coluna.DefaultCellStyle.SelectionForeColor = Color.Black;
                coluna.MinimumWidth = 100;
            }
        }

        private void FrmProcesso_Load(object sender, EventArgs e)
        {
            BsProcesso.DataSource = _repositorio.FindAll();
            DataGridView1.DataSource = BsProcesso;
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);

            if (FrmLogin.Instance.Escuro)
                AplicarModoEscuro();

            PopularToolStripComboBox();
        }

        private void AplicarModoEscuro()
        {
            BackColor = SystemColors.ControlDark;
            ToolStrip1.BackColor = SystemColors.ControlDark;
            DataGridView1.BackgroundColor = SystemColors.ControlDarkDark;
        }

        private void PopularToolStripComboBox()
        {
            var camposIgnorados = new HashSet<string>
        {
            "Id", "TDecex", "TAnvisa", "TMapa", "TImetro", "TIbama",
            "PossuiEmbarque", "VencimentoFreeTime", "VencimentoFMA"
        };

            CmbPesquisar.Items.Clear();

            foreach (DataGridViewColumn coluna in DataGridView1.Columns)
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

        private void ConfigurarInterface()
        {
            if (FrmLogin.Instance.Escuro)
            {
                ToolStrip1.BackColor = SystemColors.ControlDark;
                this.BackColor = SystemColors.ControlDark;
                CmbPesquisar.BackColor = SystemColors.ControlDarkDark;
                TxtPesquisar.BackColor = SystemColors.ControlDarkDark;
                DataGridView1.DefaultCellStyle.BackColor = SystemColors.ControlDark;
                DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = SystemColors.ControlDarkDark;
                DataGridView1.BackgroundColor = SystemColors.ControlDark;
            }
        }

        private void ConfigurarAutoCompletarParaPesquisa()
        {
            if (CmbPesquisar.SelectedItem is DisplayItem campoSelecionado)
            {
                var valores = _repositorio.ObterValoresUnicos(campoSelecionado.DataPropertyName);
                ConfigurarAutoCompletar(TxtPesquisar, valores);
            }
            else
            {
                MessageBox.Show("Selecione um campo para configurar o autocompletar.",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private static void ConfigurarAutoCompletar(ToolStripTextBox textBox, IEnumerable<string> valores)
        {
            var autoCompleteCollection = new AutoCompleteStringCollection();
            autoCompleteCollection.AddRange(valores.ToArray());

            textBox.AutoCompleteCustomSource = autoCompleteCollection;
            textBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }
        private async void BtnAdicionar_Click(object sender, EventArgs e)
        {
            var processo = new Processo();
            using var frm = new FrmModificaProcesso { processo = processo, Modo = "Adicionar", Visualização = false };
            frm.ShowDialog();

            if (frm.DialogResult == DialogResult.OK)
            {
                // Adiciona o processo principal
                await _repositorio.Create(processo, "PROCESSO");
                BsProcesso.Add(processo);
                BsProcesso.ResetBindings(false);

                // Verifica e adiciona nas coleções específicas se necessário
                if (!_repositorio.VerificarExistencia(processo))
                {
                    if (processo.TMapa)
                    {
                        await _repositorio.Create(processo, "MAPA");
                    }
                    if (processo.TAnvisa)
                    {
                        await _repositorio.Create(processo, "Anvisa");
                    }
                    if (processo.TDecex)
                    {
                        await _repositorio.Create(processo, "Decex");
                    }
                    if (processo.TImetro)
                    {
                        await _repositorio.Create(processo, "IMETRO");
                    }
                    if (processo.TIbama)
                    {
                        await _repositorio.Create(processo, "IBAMA");
                    }
                }
            }
        }
        private async void BtnExcluir_Click(object sender, EventArgs e)
        {
            if (BsProcesso.Current is not Processo processoSelecionado)
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
                BsProcesso.Remove(processoSelecionado);
                BsProcesso.ResetBindings(false);
            }
        }
        private async void BtnEditar_Click(object sender, EventArgs e)
        {
            if (BsProcesso.Current is not Processo processoSelecionado)
            {
                MessageBox.Show("Nenhum processo selecionado para edição.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using var frm = new FrmModificaProcesso { processo = processoSelecionado, Modo = "Editar", Visualização = false};
            frm.ShowDialog();

            if (frm.DialogResult == DialogResult.OK)
            {
                // Atualiza o processo principal
                await _repositorio.Update(processoSelecionado);

                BsProcesso.ResetBindings(false);
            }
        }


        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            if (CmbPesquisar.SelectedItem is not DisplayItem campoSelecionado)
            {
                MessageBox.Show("Selecione um campo para pesquisar.",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var filtro = campoSelecionado.DataPropertyName;
            var pesquisa = TxtPesquisar.Text;

            if (string.IsNullOrEmpty(pesquisa))
            {
                MessageBox.Show("Digite um valor para pesquisar.",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var resultados = _repositorio.Find(filtro, pesquisa);

            if (resultados.Any())
            {
                BsProcesso.DataSource = resultados;
                BsProcesso.ResetBindings(false);
            }
            else
            {
                MessageBox.Show("Nenhum resultado encontrado.",
                    "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (BsProcesso.Current is not Processo processoSelecionado)
            {
                MessageBox.Show("Nenhum processo selecionado para edição.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using var frm = new FrmModificaProcesso { processo = processoSelecionado , Visualização = true, Modo = "Visualizar"};
            frm.ShowDialog();

            if (frm.DialogResult == DialogResult.OK)
            {
                BsProcesso.ResetBindings(false);
            }

            BsProcesso.DataSource = _repositorio.FindAll();
        }

        private void BtnExportar_Click(object sender, EventArgs e)
        {
            // Obtém a lista de importadores únicos do repositório
            var importadores = _repositorio.ObterImportadoresUnicos();

            // Exibe um formulário para seleção do importador
            using var form = new ImporterSelectionForm(importadores);
            if (form.ShowDialog() == DialogResult.OK)
            {
                string importador = form.SelectedImporter;

                // 1) Cria sem using
                var progressForm = new ProgressForm();
                progressForm.Show(this);       // exibe modeless, com o próprio Form como owner


                Task.Run(() =>
                {
                    string pdfPath = "";
                    string? mensagemErro = null;

                    try
                    {
                        pdfPath = PythonRunner.ExecutarExportador(importador).Trim();
                    }
                    catch (Exception ex)
                    {
                        mensagemErro = $"Erro durante exportação: {ex.Message}";
                    }

                    Invoke(new Action(() =>
                    {
                        progressForm.Close();
                        progressForm.Dispose();

                        if (mensagemErro != null)
                        {
                            MessageBox.Show(mensagemErro, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        var resp = MessageBox.Show(
                            "Exportação concluída. Deseja abrir o PDF?",
                            "Resultado",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question
                        );

                        if (resp == DialogResult.Yes && File.Exists(pdfPath))
                        {
                            Process.Start(new ProcessStartInfo
                            {
                                FileName = pdfPath,
                                UseShellExecute = true
                            });
                        }
                    }));
                });
            }
        }


        private void CmbPesquisar_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConfigurarAutoCompletarParaPesquisa();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            BsProcesso.DataSource = _repositorio.FindAll();
            BsProcesso.ResetBindings(false);
        }

        private void FrmProcesso_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnPesquisar.PerformClick();
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
