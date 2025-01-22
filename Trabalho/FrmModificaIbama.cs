using CLUSA;

namespace Trabalho
{
    public partial class FrmModificaIbama : Form
    {
        public Ibama ibama;
        public FrmModificaIbama()
        {
            InitializeComponent();
            ibama = new();
        }

        private void FrmModificaIbama_Load(object sender, EventArgs e)
        {
            DTPdatadedeferimentolilpco.Value = System.DateTime.Today;
            DTPdataderegistrolilpco.Value = System.DateTime.Today;
            DTPdatadeinspecao.Value = System.DateTime.Today;
            DTPdatadeatracacao.Value = System.DateTime.Today;
            DTPdatadeembarque.Value = System.DateTime.Today;
            bsModificaIbama.DataSource = ibama;
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            ibama.Importador = TXTimportador.Text;
            ibama.Ref_USA = TXTnr.Text;
            ibama.SR = TXTsr.Text;
            ibama.Navio = TXTnavio.Text;
            ibama.Exportador = TXTexportador.Text;
            ibama.Produto = TXTProduto.Text;
            ibama.Origem = TXTorigem.Text;
            ibama.LI = TXTli.Text;
            ibama.NCM = TXTncm.Text;

            ibama.LPCO = TXTlilpco.Text;
            ibama.DataRegistroLPCO = DTPdataderegistrolilpco.Value.ToShortDateString().ToString();
            ibama.DataDeferimentoLPCO = DTPdatadedeferimentolilpco.Value.ToShortDateString().ToString();
            ibama.ParametrizacaoLPCO = CBparametrizacaolilpco.Text;

            ibama.TEmbarque = cbEmbarque.Checked;

            ibama.DataDeAtracacao = DTPdatadeatracacao.Value.ToShortDateString().ToString();
            ibama.Inspecao = DTPdatadeinspecao.Value.ToShortDateString().ToString();
            ibama.DataEmbarque = DTPdatadeembarque.Value.ToShortDateString().ToString();
            ibama.StatusDoProcesso = TXTstatusdoprocesso.Text;
            ibama.Pendencia = TXTpendencia.Text;
            ibama.Amostra = CBamostra.Checked;

            this.DialogResult = DialogResult.OK;
        }

        private void CbEmbarque_CheckedChanged(object sender, EventArgs e)
        {
            if (cbEmbarque.Checked)
            {
                LBLdatadeatracacao.Visible = true;
                DTPdatadeatracacao.Visible = true;
                LBLdatadeembarque.Visible = true;
                DTPdatadeembarque.Visible = true;
                LBLinspecao.Visible = true;
                DTPdatadeinspecao.Visible = true;
            }
            else
            {
                LBLdatadeatracacao.Visible = false;
                DTPdatadeatracacao.Visible = false;
                LBLdatadeembarque.Visible = false;
                DTPdatadeembarque.Visible = false;
                LBLinspecao.Visible = false;
                DTPdatadeinspecao.Visible = false;
            }
        }
    }
}
