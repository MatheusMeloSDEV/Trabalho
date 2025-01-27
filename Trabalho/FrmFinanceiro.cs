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

            // Ajuste os parâmetros:
            //   - ConnectionString = "mongodb+srv://dev:dev@cluster0.cn10nzt.mongodb.net/"
            //   - DatabaseName = "Trabalho"
            //   - CollectionName = "Transacoes"
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
                // Carregar dados do repositório
                var lista = _repositorio.ListarTodos();

                // Se retornar vazio, simplesmente não bloquear a tela
                // Basta exibir o grid sem registros
                dgvTransacoes.DataSource = lista;
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
            var lista = _repositorio.ListarTodos();
            dgvTransacoes.DataSource = lista;
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
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

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvTransacoes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione uma transação para editar.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Obtém a transação selecionada
            var transacaoSelecionada = (Transacao)dgvTransacoes.SelectedRows[0].DataBoundItem;

            // Abre o formulário de edição
            using var frmEd = new FrmModificaTransacao(_repositorio, transacaoSelecionada);
            if (frmEd.ShowDialog() == DialogResult.OK)
            {
                // Se o diálogo retornou OK, recarrega o grid
                AtualizarGrid();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvTransacoes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione uma transação para excluir.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var transacaoSelecionada = (Transacao)dgvTransacoes.SelectedRows[0].DataBoundItem;

            var resposta = MessageBox.Show(
                $"Deseja realmente excluir '{transacaoSelecionada.Descricao}'?",
                "Confirmação",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );
            if (resposta == DialogResult.Yes)
            {
                _repositorio.Remover(transacaoSelecionada.Id);
                AtualizarGrid();
            }
        }
    }
}
