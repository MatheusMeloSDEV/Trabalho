using CLUSA;

namespace Trabalho
{
    public partial class FrmModificaTransacao : Form
    {
        private readonly RepositorioTransacao _repositorio;
        private readonly Transacao _transacao;

        public FrmModificaTransacao(RepositorioTransacao repositorio, Transacao transacao)
        {
            InitializeComponent();
            _repositorio = repositorio;
            _transacao = transacao;
        }

        private void FrmEditarTransacao_Load(object sender, EventArgs e)
        {
            txtDescricao.Text = _transacao.Descricao;
            nudValor.Value = _transacao.Valor;
            cbTipo.SelectedItem = _transacao.Tipo == TipoTransacao.Entrada ? "Entrada" : "Saida";
            txtCategoria.Text = _transacao.Categoria;
            dtData.Value = _transacao.Data;
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            // Atualiza os campos do objeto em memória
            _transacao.Descricao = txtDescricao.Text;
            _transacao.Valor = nudValor.Value;
            _transacao.Tipo = (cbTipo.SelectedItem?.ToString() == "Entrada")
                              ? TipoTransacao.Entrada
                              : TipoTransacao.Saida;
            _transacao.Categoria = txtCategoria.Text;
            _transacao.Data = dtData.Value;

            // Grava no Mongo (ReplaceOne)
            _repositorio.Atualizar(_transacao);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
