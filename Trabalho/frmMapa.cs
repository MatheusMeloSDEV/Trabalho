using CLUSA;
using iText.Kernel.Exceptions;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using static Trabalho.frmProcesso;

namespace Trabalho
{
    public partial class frmMapa : Form
    {
        private RepositorioMAPA repositorio;
        public frmMapa()
        {
            InitializeComponent();
        }

        private void frmMapa_Load(object sender, EventArgs e)
        {
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            repositorio = new RepositorioMAPA();
            BSmapa.DataSource = repositorio;
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
                "PossuiEmbarque",
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

        private void DarkMode()
        {
            toolStrip1.BackColor = SystemColors.ControlDark;
            this.BackColor = SystemColors.ControlDark;
            CmbPesquisar.BackColor = SystemColors.ControlDarkDark;
            txtPesquisar.BackColor = SystemColors.ControlDarkDark;
            dataGridView1.DefaultCellStyle.BackColor = SystemColors.ControlDark;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = SystemColors.ControlDarkDark;
            dataGridView1.BackgroundColor = SystemColors.ControlDark;
        }

        private async void btnAdicionar_click(object sender, EventArgs e)
        {

        }

        private void bsMAPA_CurrentChanged(object sender, EventArgs e)
        {

        }

        private async void btnExcluir_Click(object sender, EventArgs e)
        {
            await repositorio.Delete(BSmapa.Current as MAPA);
            BSmapa.Remove(BSmapa.Current as MAPA);
            BSmapa.ResetBindings(false);
            BSmapa.DataSource = repositorio.FindAll();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            repositorio = new RepositorioMAPA();
            BSmapa.DataSource = repositorio.FindAll();
            CmbPesquisar.Text = "";
        }

        private void txtPesquisar_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                repositorio = new RepositorioMAPA();
                BSmapa.DataSource = repositorio.Find(CmbPesquisar.Text, txtPesquisar.Text);
            }
        }

        private void frmMapa_FormClosed(object sender, FormClosedEventArgs e)
        {
            repositorio = null;
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            BSmapa.DataSource = repositorio.FindAll();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            repositorio = new RepositorioMAPA();
            BSmapa.DataSource = repositorio.Find(CmbPesquisar.Text, txtPesquisar.Text);
        }

        private void CmbPesquisar_Click(object sender, EventArgs e)
        {

        }
        public class PdfExporter
        {
            public void ExportDataGridViewToPdf(DataGridView dataGridView, string filePath)
            {
                try
                {
                    // Verifica se o DataGridView tem um DataSource
                    if (dataGridView.DataSource == null)
                    {
                        MessageBox.Show("O DataGridView não possui um DataSource válido.");
                        return;
                    }

                    // Verifica se o arquivo já existe
                    if (File.Exists(filePath))
                    {
                        // Pergunta ao usuário se deseja sobrescrever o arquivo
                        if (MessageBox.Show("O arquivo já existe. Deseja sobrescrevê-lo?", "Sobrescrever?", MessageBoxButtons.YesNo) == DialogResult.No)
                        {
                            return;
                        }
                    }

                    // Cria um objeto PDFWriter para salvar o PDF no local especificado
                    using (PdfWriter writer = new PdfWriter(filePath))
                    {
                        using (PdfDocument pdf = new PdfDocument(writer))
                        {
                            // Cria um documento PDF
                            Document document = new Document(pdf);

                            // Cria uma tabela com a mesma quantidade de colunas do DataGridView
                            Table table = new Table(dataGridView.ColumnCount);
                            table.SetWidth(UnitValue.CreatePercentValue(100)); // Definindo a largura da tabela

                            // Adiciona o cabeçalho das colunas
                            foreach (DataGridViewColumn column in dataGridView.Columns)
                            {
                                table.AddHeaderCell(new Cell().Add(new Paragraph(column.HeaderText)));
                            }

                            // Adiciona as linhas da tabela (valores das células)
                            foreach (DataGridViewRow row in dataGridView.Rows)
                            {
                                if (row.IsNewRow) continue; // Ignora a última linha vazia
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    string cellValue = cell.Value?.ToString() ?? "";
                                    table.AddCell(new Cell().Add(new Paragraph(cellValue)));
                                }
                            }

                            // Adiciona a tabela ao documento PDF
                            document.Add(table);

                            // Fecha o documento
                            document.Close();
                        }
                    }

                    MessageBox.Show("PDF gerado com sucesso em: " + filePath);
                }
                catch (PdfException ex)
                {
                    MessageBox.Show("Erro ao gerar o PDF: " + ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro geral: " + ex.Message);
                }
            }
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            PdfExporter exporter = new PdfExporter();
            exporter.ExportDataGridViewToPdf(dataGridView1, @"C:\FollowUp\teste.pdf");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void BTNeditar_Click_1(object sender, EventArgs e)
        {
            frmModificaMapa frm = new frmModificaMapa();
            frm.mapa = BSmapa.Current as MAPA;
            frm.ShowDialog();

            if (frm.DialogResult == DialogResult.OK)
            {
                await repositorio.Update(frm.mapa);
                BSmapa.ResetBindings(false);
            }
            BSmapa.DataSource = repositorio.FindAll();
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

                    BSmapa.DataSource = repositorio.Find(dataPropertyName, valorCelula);
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

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            // Verificar se há uma seleção válida no ToolStripComboBox
            if (CmbPesquisar.SelectedItem is DisplayItem campoSelecionado)
            {
                // Obter o DataPropertyName
                string dataPropertyName = campoSelecionado.DataPropertyName;

                // Obter o texto de pesquisa
                string textoPesquisa = txtPesquisar.Text;

                if (string.IsNullOrEmpty(textoPesquisa))
                {
                    MessageBox.Show("Digite um valor para pesquisar.",
                                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Aplicar o filtro no BindingSource
                BSmapa.Filter = $"{dataPropertyName} LIKE '%{textoPesquisa}%'";
            }
            else
            {
                MessageBox.Show("Selecione um campo para pesquisar.",
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
