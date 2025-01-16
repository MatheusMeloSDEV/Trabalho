using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using CLUSA;
using static Trabalho.FrmProcesso;

namespace Trabalho
{
    public partial class FrmImetro : Form
    {
        private readonly RepositorioImetro _repositorio;

        public FrmImetro()
        {
            InitializeComponent();
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            _repositorio = new RepositorioImetro();
        }

        private void FrmImetro_Load(object sender, EventArgs e)
        {
            // Primeiro configurar os DataPropertyNames das colunas
            ConfigurarDataPropertyNames();

            // Depois carregar a fonte de dados
            BsImetro.DataSource = _repositorio.FindAll();

            ConfigurarInterface();
            PopularComboBoxPesquisa();
            ConfigurarAutoCompletarPesquisa();
        }

        private void ConfigurarDataPropertyNames()
        {
            ColId.DataPropertyName = "Id";
            ColRefUSA.DataPropertyName = "Ref_USA";
            ColImportador.DataPropertyName = "Importador";
            ColSR.DataPropertyName = "SR";
            ColExportador.DataPropertyName = "Exportador";
            ColNavio.DataPropertyName = "Navio";
            ColTerminal.DataPropertyName = "Terminal";
            ColProduto.DataPropertyName = "Produto";
            ColOrigem.DataPropertyName = "Origem";
            ColTEmbarque.DataPropertyName = "TEmbarque";
            ColDataDeAtracacao.DataPropertyName = "DataDeAtracacao";
            ColInspecao.DataPropertyName = "Inspecao";
            ColDataEmbarque.DataPropertyName = "DataEmbarque";
            ColNCM.DataPropertyName = "NCM"; // Caso seja adicionado posteriormente ao modelo
            ColLI.DataPropertyName = "LI";
            ColLPCO.DataPropertyName = "LPCO";
            ColDataRegistroLPCO.DataPropertyName = "DataRegistroLPCO";
            ColDataDeferimentoLPCO.DataPropertyName = "DataDeferimentoLPCO";
            ColParametrizacaoLPCO.DataPropertyName = "ParametrizacaoLPCO";
            ColAmostra.DataPropertyName = "Amostra";
            ColPendencia.DataPropertyName = "Pendencia";
            ColStatusDoProcesso.DataPropertyName = "StatusDoProcesso";
        }

        private void ConfigurarInterface()
        {
            if (FrmLogin.Instance.Escuro)
            {
                ToolStripMain.BackColor = SystemColors.ControlDark;
                this.BackColor = SystemColors.ControlDark;
                CmbPesquisa.BackColor = SystemColors.ControlDarkDark;
                TxtPesquisa.BackColor = SystemColors.ControlDarkDark;
                DgvImetro.DefaultCellStyle.BackColor = SystemColors.ControlDark;
                DgvImetro.AlternatingRowsDefaultCellStyle.BackColor = SystemColors.ControlDarkDark;
                DgvImetro.BackgroundColor = SystemColors.ControlDark;
            }
        }

        private void PopularComboBoxPesquisa()
        {
            var camposIgnorados = new HashSet<string> { "Id", "TEmbarque" };
            CmbPesquisa.Items.Clear();

            foreach (DataGridViewColumn coluna in DgvImetro.Columns)
            {
                if (!string.IsNullOrEmpty(coluna.DataPropertyName) && !camposIgnorados.Contains(coluna.DataPropertyName))
                {
                    CmbPesquisa.Items.Add(new DisplayItem(coluna.DataPropertyName, coluna.HeaderText));
                }
            }

            if (CmbPesquisa.Items.Count > 0)
            {
                CmbPesquisa.SelectedIndex = 0;
            }
        }

        private void ConfigurarAutoCompletarPesquisa()
        {
            if (CmbPesquisa.SelectedItem is DisplayItem campoSelecionado)
            {
                var valores = _repositorio.ObterValoresUnicos(campoSelecionado.DataPropertyName);
                ConfigurarAutoCompletar(TxtPesquisa, valores);
            }
            else
            {
                MessageBox.Show("Selecione um campo para configurar o autocompletar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                BsImetro.DataSource = _repositorio.FindAll();
                BsImetro.ResetBindings(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar todos os processos: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnReload_Click(object sender, EventArgs e)
        {
            BsImetro.DataSource = _repositorio.FindAll();
        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            if (CmbPesquisa.SelectedItem is DisplayItem campoSelecionado)
            {
                var dataPropertyName = campoSelecionado.DataPropertyName;
                var textoPesquisa = TxtPesquisa.Text;

                if (!string.IsNullOrEmpty(textoPesquisa))
                {
                    BsImetro.Filter = $"{dataPropertyName} LIKE '%{textoPesquisa}%'";
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
            if (BsImetro.Current is not Imetro anvisaAtual)
            {
                MessageBox.Show("Nenhum registro selecionado para edição.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var frm = new FrmModificaImetro { imetro = anvisaAtual };
            frm.ShowDialog();

            if (frm.DialogResult == DialogResult.OK)
            {
                try
                {
                    await _repositorio.UpdateAsync(frm.imetro);
                    BsImetro.DataSource = await _repositorio.FindAllAsync();
                    BsImetro.ResetBindings(false);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao atualizar o registro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void DgvImetro_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var cell = DgvImetro.Rows[e.RowIndex].Cells[e.ColumnIndex];
                var valorCelula = cell.Value?.ToString();
                var dataPropertyName = DgvImetro.Columns[e.ColumnIndex].DataPropertyName;

                if (!string.IsNullOrEmpty(dataPropertyName))
                {
                    if (valorCelula != null)
                    {
                        BsImetro.DataSource = _repositorio.Find(dataPropertyName, valorCelula);
                    }
                    else
                    {
                        MessageBox.Show("Célula sem valor válido para pesquisa.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("DataPropertyName não definido para esta coluna.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        }
    }
}
