﻿using CLUSA;
using static Trabalho.FrmProcesso;

namespace Trabalho
{
    public partial class FrmDecex : Form
    {
        private readonly RepositorioDecex _repositorio;

        public FrmDecex()
        {
            InitializeComponent();
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            _repositorio = new RepositorioDecex();
        }
        private void FrmDecex_Load(object sender, EventArgs e)
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
                    BsDecex = new BindingSource
                    {
                        DataSource = registros
                    };

                    dataGridView1.DataSource = BsDecex;
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
        private void ConfigurarColunasDataGridView()
        {
            // Limpa colunas anteriores
            dataGridView1.Columns.Clear();

            // Configuração básica
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            // ——————————————————————
            // 1) Colunas principais (texto)
            // ——————————————————————
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
                DataPropertyName = "Produto",
                HeaderText = "Produto",
                Name = "ColunaProduto"
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "NCM",
                HeaderText = "NCM",
                Name = "ColunaNCM"
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

            foreach (DataGridViewColumn coluna in dataGridView1.Columns)
            {
                coluna.DefaultCellStyle.Font = new Font("Segoe UI", 10);
                coluna.DefaultCellStyle.ForeColor = Color.Black;
                coluna.DefaultCellStyle.BackColor = Color.White;
                coluna.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
                coluna.DefaultCellStyle.SelectionForeColor = Color.Black;
                coluna.MinimumWidth = 100;
            }
        }
        private void PopularToolStripComboBox()
        {
            var camposIgnorados = new HashSet<string> { "Id" };
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
        private void ConfigurarAutoCompletarParaPesquisa()
        {
            try
            {
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
                BsDecex.DataSource = _repositorio.FindAll();
                BsDecex.ResetBindings(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar todos os processos: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BtnReload_Click(object sender, EventArgs e)
        {
            BsDecex.DataSource = _repositorio.FindAll();
        }
        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            if (CmbPesquisar.SelectedItem is DisplayItem campoSelecionado)
            {
                var dataPropertyName = campoSelecionado.DataPropertyName;
                var textoPesquisa = TxtPesquisar.Text;

                if (!string.IsNullOrEmpty(textoPesquisa))
                {
                    BsDecex.Filter = $"{dataPropertyName} LIKE '%{textoPesquisa}%'";
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
            if (BsDecex.Current is not Decex decexAtual)
            {
                MessageBox.Show("Nenhum registro selecionado para edição.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var frm = new FrmModificaDecex { decex = decexAtual, Visualização = false, Modo = "Editar" };
            frm.ShowDialog();

            if (frm.DialogResult == DialogResult.OK)
            {
                try
                {
                    await _repositorio.UpdateAsync(frm.decex);
                    BsDecex.DataSource = await _repositorio.FindAllAsync();
                    BsDecex.ResetBindings(false);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao atualizar o registro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (BsDecex.Current is not Decex decexSelecionado)
            {
                MessageBox.Show("Nenhum processo selecionado para edição.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using var frm = new FrmModificaDecex { decex = decexSelecionado, Visualização = true, Modo = "Visualizar" };
            frm.ShowDialog();

            if (frm.DialogResult == DialogResult.OK)
            {
                BsDecex.ResetBindings(false);
            }

            BsDecex.DataSource = _repositorio.FindAll();
        }
        private void CmbPesquisar_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConfigurarAutoCompletarParaPesquisa();
        }
    }
}
