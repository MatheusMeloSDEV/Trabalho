using CLUSA;
using static Trabalho.frmProcesso;

namespace Trabalho
{
    public partial class frmDecex : Form
    {
        private RepositorioDecex repositorio;
        public frmDecex()
        {
            InitializeComponent();
            repositorio = new RepositorioDecex();
            bsDecex.DataSource = repositorio;
        }

        private void frmDecex_Load(object sender, EventArgs e)
        {
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            // Preencher o ToolStripComboBox
            PopularToolStripComboBox();

            // Configurar o autocompletar para o campo inicial
            ConfigurarAutoCompletarParaPesquisa();
        }
        private void CmbPesquisar_SelectedIndexChanged(object sender, EventArgs e)
        {
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
                "PossuiEmbarque"
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

        private async void btnEditar_Click(object sender, EventArgs e)
        {
            frmModificaDecex frm = new frmModificaDecex();
            frm.decex = bsDecex.Current as Decex;
            frm.ShowDialog();

            if (frm.DialogResult == DialogResult.OK)
            {
                await repositorio.Udpate(frm.decex);
                bsDecex.ResetBindings(false);
            }
            bsDecex.DataSource = repositorio.FindAll();
        }

        private async void btnExcluir_Click(object sender, EventArgs e)
        {
            await repositorio.Delete(bsDecex.Current as Decex);
            bsDecex.Remove(bsDecex.Current as Decex);
            bsDecex.ResetBindings(false);
            bsDecex.DataSource = repositorio.FindAll();
        }

        private void CmbPesquisar_Click(object sender, EventArgs e)
        {

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

                    bsDecex.DataSource = repositorio.Find(dataPropertyName, valorCelula);
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
                        bsDecex.DataSource = resultados; // Atualizar o BindingSource com os novos resultados
                        bsDecex.ResetBindings(false);    // Atualizar o DataGridView
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                // Buscar todos os processos no MongoDB
                var todosProcessos = repositorio.FindAll(); // Método para buscar todos os documentos

                // Atualizar o BindingSource
                bsDecex.DataSource = todosProcessos;
                bsDecex.ResetBindings(false); // Atualizar o DataGridView

                Console.WriteLine($"Total de processos carregados: {todosProcessos.Count}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar todos os processos: {ex.Message}",
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
