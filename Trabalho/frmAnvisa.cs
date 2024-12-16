using CLUSA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using static Trabalho.FrmProcesso;

namespace Trabalho
{
    public partial class FrmAnvisa : Form
    {
        private RepositorioAnvisa _repositorio;

        public FrmAnvisa()
        {
            InitializeComponent();
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            _repositorio = new RepositorioAnvisa();
        }

        private void frmAnvisa_Load(object sender, EventArgs e)
        {
            bsAnvisa.DataSource = _repositorio.FindAll();
            ConfigurarInterface();
            PopularToolStripComboBox();
            ConfigurarAutoCompletarParaPesquisa();
        }

        private void ConfigurarInterface()
        {
            if (FrmLogin.Instance.Escuro)
            {
                toolStrip1.BackColor = SystemColors.ControlDark;
                this.BackColor = SystemColors.ControlDark;
                CmbPesquisar.BackColor = SystemColors.ControlDarkDark;
                txtPesquisar.BackColor = SystemColors.ControlDarkDark;
                dataGridView1.DefaultCellStyle.BackColor = SystemColors.ControlDark;
                dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = SystemColors.ControlDarkDark;
                dataGridView1.BackgroundColor = SystemColors.ControlDark;
            }
        }

        private void PopularToolStripComboBox()
        {
            var camposIgnorados = new HashSet<string> { "Id", "TEmbarque" };
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
            if (CmbPesquisar.SelectedItem is DisplayItem campoSelecionado)
            {
                var valores = _repositorio.ObterValoresUnicos(campoSelecionado.DataPropertyName);
                ConfigurarAutoCompletar(txtPesquisar, valores);
            }
            else
            {
                MessageBox.Show("Selecione um campo para configurar o autocompletar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                bsAnvisa.DataSource = _repositorio.FindAll();
                bsAnvisa.ResetBindings(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar todos os processos: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            bsAnvisa.DataSource = _repositorio.FindAll();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (CmbPesquisar.SelectedItem is DisplayItem campoSelecionado)
            {
                var dataPropertyName = campoSelecionado.DataPropertyName;
                var textoPesquisa = txtPesquisar.Text;

                if (!string.IsNullOrEmpty(textoPesquisa))
                {
                    bsAnvisa.Filter = $"{dataPropertyName} LIKE '%{textoPesquisa}%'";
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

        private async void BTNeditar_Click_1(object sender, EventArgs e)
        {
            if (bsAnvisa.Current is not Anvisa anvisaAtual)
            {
                MessageBox.Show("Nenhum registro selecionado para edição.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var frm = new frmModificaAnvisa { anvisa = anvisaAtual };
            frm.ShowDialog();

            if (frm.DialogResult == DialogResult.OK)
            {
                try
                {
                    await _repositorio.UpdateAsync(frm.anvisa);
                    bsAnvisa.DataSource = await _repositorio.FindAllAsync();
                    bsAnvisa.ResetBindings(false);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao atualizar o registro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
                    bsAnvisa.DataSource = _repositorio.Find(dataPropertyName, valorCelula);
                }
                else
                {
                    MessageBox.Show("DataPropertyName não definido para esta coluna.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
