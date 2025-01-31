using CLUSA;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Trabalho
{
    public partial class FrmFinanceiro : Form
    {
        private readonly RepositorioTransacao _repositorio;

        public FrmFinanceiro()
        {
            InitializeComponent();

            _repositorio = new RepositorioTransacao(
                "mongodb+srv://dev:dev@cluster0.cn10nzt.mongodb.net/",
                "Trabalho",
                "Transacoes"
            );
        }

        private void FrmFinanceiro_Load(object sender, EventArgs e)
        {
            try
            {
                AtualizarGrid();
            }
            catch (Exception ex)
            {
                // Se der erro de conexão ou qualquer outro problema, 
                // podemos mostrar uma mensagem, mas manter o form aberto
                MessageBox.Show($"Não foi possível carregar registros do banco:\n{ex.Message}",
                                "Aviso",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);

                // Podemos deixar o DataSource nulo ou vazio para não travar
                dgvTransacoes.DataSource = null;
            }
        }

        private void AtualizarGrid()
        {
            // Apenas configura as colunas se ainda não estiverem configuradas
            if (dgvTransacoes.Columns.Count == 0)
            {
                ConfigurarColunasDataGridView();
            }

            // Atualiza o DataSource do DataGridView
            var transacoes = _repositorio.ListarTodos();

            var bindingSource = new BindingSource
            {
                DataSource = transacoes
            };

            dgvTransacoes.DataSource = bindingSource;
        }


        private void ConfigurarColunasDataGridView()
        {
            dgvTransacoes.Columns.Clear(); // Limpa colunas anteriores

            // Configuração básica do DataGridView
            dgvTransacoes.AutoGenerateColumns = false;
            dgvTransacoes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTransacoes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTransacoes.RowHeadersVisible = false;

            // Coluna ID
            dgvTransacoes.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Id",
                HeaderText = "ID",
                Name = "ColunaId",
                ReadOnly = true,
                Visible = false,
                Width = 100
            });

            // Coluna Descrição
            dgvTransacoes.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Descricao",
                HeaderText = "Descrição",
                Name = "ColunaDescricao",
                Width = 200
            });

            // Coluna Valor
            dgvTransacoes.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Valor",
                HeaderText = "Valor (R$)",
                Name = "ColunaValor",
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Format = "C2" // Formata como moeda
                },
                Width = 150
            });

            // Coluna Tipo de Transação
            dgvTransacoes.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Tipo",
                HeaderText = "Tipo de Transação",
                Name = "ColunaTipo",
                Width = 150
            });

            // Coluna Categoria
            dgvTransacoes.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Categoria",
                HeaderText = "Categoria",
                Name = "ColunaCategoria",
                Width = 200
            });

            // Coluna Data
            dgvTransacoes.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Data",
                HeaderText = "Data",
                Name = "ColunaData",
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Format = "dd/MM/yyyy" // Formata como data
                },
                Width = 150
            });

            // Ajusta as larguras mínimas para cada coluna
            foreach (DataGridViewColumn coluna in dgvTransacoes.Columns)
            {
                coluna.MinimumWidth = 100;
                coluna.DefaultCellStyle.Font = new Font("Segoe UI", 10);
                coluna.DefaultCellStyle.BackColor = Color.White;
                coluna.DefaultCellStyle.ForeColor = Color.Black;
                coluna.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
                coluna.DefaultCellStyle.SelectionForeColor = Color.Black;
            }
        }
        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            // Cria objeto baseado nos campos
            var transacao = new Transacao
            {
                Descricao = txtDescricao.Text,
                Valor = nudValor.Value,
                Tipo = (cbTipo.SelectedItem?.ToString() == "Entrada")
                       ? TipoTransacao.Entrada
                       : TipoTransacao.Saida,
                Categoria = txtCategoria.Text,
                Data = dtData.Value
            };

            // Insere no MongoDB
            _repositorio.Adicionar(transacao);

            // Limpa campos (opcional)
            txtDescricao.Clear();
            nudValor.Value = 0;
            txtCategoria.Clear();
            dtData.Value = DateTime.Now;

            // Atualiza DataGrid
            AtualizarGrid();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (dgvTransacoes.CurrentCell == null)
            {
                MessageBox.Show("Selecione uma célula para editar a transação correspondente.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Obtém a linha correspondente à célula selecionada
            var linhaSelecionada = dgvTransacoes.Rows[dgvTransacoes.CurrentCell.RowIndex];

            if (linhaSelecionada.DataBoundItem is not Transacao transacaoSelecionada)
            {
                MessageBox.Show("Não foi possível recuperar a transação selecionada.", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Abre o formulário de edição
            using var frmEd = new FrmModificaTransacao(_repositorio, transacaoSelecionada);
            if (frmEd.ShowDialog() == DialogResult.OK)
            {
                // Se o diálogo retornou OK, recarrega o grid
                AtualizarGrid();
            }
        }


        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvTransacoes.SelectedCells.Count == 0)
            {
                MessageBox.Show("Selecione uma célula na transação que deseja excluir.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Identifica a linha correspondente à célula selecionada
            int rowIndex = dgvTransacoes.SelectedCells[0].RowIndex;
            var transacaoSelecionada = (Transacao)dgvTransacoes.Rows[rowIndex].DataBoundItem;

            var resposta = MessageBox.Show(
                $"Deseja realmente excluir a transação '{transacaoSelecionada.Descricao}'?",
                "Confirmação",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resposta == DialogResult.Yes)
            {
                // Remove a transação do banco de dados
                _repositorio.Remover(transacaoSelecionada.Id);

                // Atualiza o DataGridView
                AtualizarGrid();

                MessageBox.Show("Transação excluída com sucesso.", "Sucesso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}
