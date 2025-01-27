using CLUSA;
using static Trabalho.FrmProcesso;

namespace Trabalho
{
    public partial class FrmMapa : Form
    {
        private readonly RepositorioMAPA _repositorio;

        public FrmMapa()
        {
            InitializeComponent();
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            _repositorio = new RepositorioMAPA();
        }
        private void FrmMapa_Load(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    Conectar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao carregar o formulário: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                ConfigurarInterface();
                PopularToolStripComboBox();
                ImagensBotoes();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar os dados: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Conectar()
        {
            try
            {
                ConfigurarColunasDataGridView();

                // Recupera os registros do repositório
                var registros = _repositorio.FindAll();

                if (registros.Count > 0)
                {
                    // Configura o BindingSource e o DataGridView
                    BSmapa = new BindingSource
                    {
                        DataSource = registros
                    };

                    dataGridView1.DataSource = BSmapa;
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
        private void ConfigurarColunasDataGridView()
        {
            dataGridView1.Columns.Clear(); // Limpa colunas anteriores

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Id",
                HeaderText = "ID",
                Name = "ColunaId",
                ReadOnly = true,
                Visible = false
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Ref_USA",
                HeaderText = "Ref. USA",
                Name = "ColunaRefUSA"
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "SR",
                HeaderText = "SR",
                Name = "ColunaSR"
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Importador",
                HeaderText = "Importador",
                Name = "ColunaImportador"
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Exportador",
                HeaderText = "Exportador",
                Name = "ColunaExportador"
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Navio",
                HeaderText = "Navio",
                Name = "ColunaNavio"
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Terminal",
                HeaderText = "Terminal",
                Name = "ColunaTerminal"
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Produto",
                HeaderText = "Produto",
                Name = "ColunaProduto"
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Origem",
                HeaderText = "Origem",
                Name = "ColunaOrigem"
            });

            dataGridView1.Columns.Add(new DataGridViewCheckBoxColumn
            {
                DataPropertyName = "TEmbarque",
                HeaderText = "Tem Embarque",
                Name = "ColunaTEmbarque",
                Visible = false
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "DataDeAtracacao",
                HeaderText = "Data de Atracação",
                Name = "ColunaDataDeAtracacao"
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "DataEmbarque",
                HeaderText = "Data de Embarque",
                Name = "ColunaDataEmbarque"
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Inspecao",
                HeaderText = "Inspeção",
                Name = "ColunaInspecao"
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "NCM",
                HeaderText = "NCM",
                Name = "ColunaNCM"
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "LI",
                HeaderText = "LI",
                Name = "ColunaLI"
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "LPCO",
                HeaderText = "LPCO",
                Name = "ColunaLPCO"
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "DataRegistroLPCO",
                HeaderText = "Data Registro LPCO",
                Name = "ColunaDataRegistroLPCO"
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "DataDeferimentoLPCO",
                HeaderText = "Data Deferimento LPCO",
                Name = "ColunaDataDeferimentoLPCO"
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ParametrizacaoLPCO",
                HeaderText = "Parametrização LPCO",
                Name = "ColunaParametrizacaoLPCO"
            });

            dataGridView1.Columns.Add(new DataGridViewCheckBoxColumn
            {
                DataPropertyName = "Amostra",
                HeaderText = "Amostra",
                Name = "ColunaAmostra"
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Pendencia",
                HeaderText = "Pendência",
                Name = "ColunaPendencia"
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "StatusDoProcesso",
                HeaderText = "Status do Processo",
                Name = "ColunaStatusDoProcesso"
            });

            // Ajusta automaticamente o tamanho das colunas com base no conteúdo
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            // Permite quebra de texto nos cabeçalhos
            dataGridView1.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.True;

            // Ajusta a altura dos cabeçalhos para suportar múltiplas linhas
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            // Define uma largura mínima para todas as colunas
            foreach (DataGridViewColumn coluna in dataGridView1.Columns)
            {
                coluna.MinimumWidth = 100; // Define largura mínima
            }
        }
        private void ImagensBotoes()
        {
            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            var resources = assembly.GetManifestResourceNames();
            foreach (var r in resources)
            {
                Console.WriteLine(r);
            }

            // Crie um array de tuplas (string caminhoRecurso, Button botao)
            var recursos = new (string CaminhoRecurso, ToolStripButton Botao)[]
            {
                ("Trabalho.Imagens.botao-editar.png", BtnEditar),
                ("Trabalho.Imagens.cancelar.png", BtnCancelar),
                ("Trabalho.Imagens.lupa-de-pesquisa.png", BtnPesquisar),
                ("Trabalho.Imagens.recarregar.png", BtnReload)
            };

            foreach (var (caminho, botao) in recursos)
            {
                botao.Image = CarregarImagemDoRecurso(assembly, caminho);
            }
        }
        private static System.Drawing.Image? CarregarImagemDoRecurso(System.Reflection.Assembly assembly, string resourcePath)
        {
            using var stream = assembly.GetManifestResourceStream(resourcePath);
            return stream != null ? System.Drawing.Image.FromStream(stream) : null;
        }
        private void ConfigurarInterface()
        {
            if (FrmLogin.Instance.Escuro)
            {
                toolStrip1.BackColor = SystemColors.ControlDark;
                this.BackColor = SystemColors.ControlDark;
                CmbPesquisar.BackColor = SystemColors.ControlDarkDark;
                TxtPesquisar.BackColor = SystemColors.ControlDarkDark;
                dataGridView1.DefaultCellStyle.BackColor = SystemColors.ControlDark;
                dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = SystemColors.ControlDarkDark;
                dataGridView1.BackgroundColor = SystemColors.ControlDark;
            }
        }
        private void PopularToolStripComboBox()
        {
            var camposIgnorados = new HashSet<string> { "Id", "PossuiEmbarque" };
            CmbPesquisar.Items.Clear();

            foreach (DataGridViewColumn coluna in dataGridView1.Columns)
            {
                if (!string.IsNullOrEmpty(coluna.DataPropertyName) && !camposIgnorados.Contains(coluna.DataPropertyName))
                {
                    CmbPesquisar.Items.Add(new DisplayItem(coluna.DataPropertyName, coluna.HeaderText));
                }
            }

            if (CmbPesquisar.Items.Count > 0)
            {
                CmbPesquisar.SelectedIndex = 0;
            }
        }
        private void ConfigurarAutoCompletarParaPesquisa()
        {
            try
            {
                // Certifique-se de que há um campo selecionado no ComboBox
                if (CmbPesquisar.SelectedItem == null)
                {
                    MessageBox.Show("Selecione um campo para configurar o autocompletar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var campoSelecionado = CmbPesquisar.SelectedItem?.ToString();

                if (!string.IsNullOrEmpty(campoSelecionado))
                {
                    var valores = _repositorio.ObterValoresUnicos(campoSelecionado);

                    var autoCompleteCollection = new AutoCompleteStringCollection();
                    autoCompleteCollection.AddRange(valores.ToArray());
                    TxtPesquisar.AutoCompleteCustomSource = autoCompleteCollection;
                    TxtPesquisar.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                    TxtPesquisar.AutoCompleteSource = AutoCompleteSource.CustomSource;
                }
                else
                {
                    MessageBox.Show("Selecione um campo para configurar o autocompletar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao configurar o autocompletar: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                BSmapa.DataSource = _repositorio.FindAll();
                BSmapa.ResetBindings(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar todos os processos: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BtnReload_Click(object sender, EventArgs e)
        {
            BSmapa.DataSource = _repositorio.FindAll();
        }
        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            if (CmbPesquisar.SelectedItem is DisplayItem campoSelecionado)
            {
                var dataPropertyName = campoSelecionado.DataPropertyName;
                var textoPesquisa = TxtPesquisar.Text;

                if (!string.IsNullOrEmpty(textoPesquisa))
                {
                    BSmapa.Filter = $"{dataPropertyName} LIKE '%{textoPesquisa}%'";
                }
                else
                {
                    MessageBox.Show("Digite um valor para pesquisar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Selecione um campo para pesquisar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private async void BtnEditar_Click(object sender, EventArgs e)
        {
            if (BSmapa.Current is not MAPA mapaAtual)
            {
                MessageBox.Show("Nenhum registro selecionado para edição.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var frm = new FrmModificaMapa { mapa = mapaAtual };
            frm.ShowDialog();

            if (frm.DialogResult == DialogResult.OK)
            {
                try
                {
                    await _repositorio.UpdateAsync(frm.mapa);
                    BSmapa.DataSource = await _repositorio.FindAllAsync();
                    BSmapa.ResetBindings(false);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao atualizar o registro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var cell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
                var valorCelula = cell.Value?.ToString();
                var dataPropertyName = dataGridView1.Columns[e.ColumnIndex].DataPropertyName;

                if (!string.IsNullOrEmpty(dataPropertyName))
                {
                    if (valorCelula != null)
                    {
                        BSmapa.DataSource = _repositorio.Find(dataPropertyName, valorCelula);
                    }
                    else
                    {
                        // Tratar o caso de valorCelula nulo.
                        // Por exemplo, não chamar o método ou usar um valor padrão.
                        MessageBox.Show("Não há valor para pesquisa.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("DataPropertyName não definido para esta coluna.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        private void CmbPesquisar_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConfigurarAutoCompletarParaPesquisa();
        }
    }
}
