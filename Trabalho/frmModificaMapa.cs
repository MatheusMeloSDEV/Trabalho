using CLUSA;

namespace Trabalho
{
    public partial class FrmModificaMapa : Form
    {
        public MAPA mapa;

        public FrmModificaMapa()
        {
            InitializeComponent();
            mapa = new();
        }

        public void FrmModifica_Load(object sender, EventArgs e)
        {
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            if (FrmLogin.Instance.Escuro)
            {
                //DarkMode();
            }
            DTPdatadedeferimentolilpco.Value = System.DateTime.Today;
            DTPdataderegistrolilpco.Value = System.DateTime.Today;
            DTPdatadeinspecao.Value = System.DateTime.Today;
            DTPdatadeatracacao.Value = System.DateTime.Today;
            DTPdatadeembarque.Value = System.DateTime.Today;
            BsModificaMAPA.DataSource = mapa;
        }

        private void TErro_Tick(object sender, EventArgs e)
        {

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            mapa.Importador = TXTimportador.Text;
            mapa.Ref_USA = TXTnr.Text;
            mapa.SR = TXTsr.Text;
            mapa.Exportador = TXTexportador.Text;
            mapa.Produto = TXTProduto.Text;
            mapa.Origem = TXTorigem.Text;
            mapa.LI = TXTli.Text;
            mapa.NCM = TXTncm.Text;

            mapa.LPCO = TXTlilpco.Text;
            mapa.DataRegistroLPCO = DTPdataderegistrolilpco.Value.ToShortDateString().ToString();
            mapa.DataDeferimentoLPCO = DTPdatadedeferimentolilpco.Value.ToShortDateString().ToString();
            mapa.ParametrizacaoLPCO = CBparametrizacaolilpco.Text;

            mapa.TEmbarque = CbEmbarque.Checked;

            mapa.DataDeAtracacao = DTPdatadeatracacao.Value.ToShortDateString().ToString();
            mapa.Inspecao = DTPdatadeinspecao.Value.ToShortDateString().ToString();
            mapa.DataEmbarque = DTPdatadeembarque.Value.ToShortDateString().ToString();
            mapa.StatusDoProcesso = TXTstatusdoprocesso.Text;
            mapa.Pendencia = TXTpendencia.Text;
            mapa.Amostra = CBamostra.Checked;

            this.DialogResult = DialogResult.OK;
        }

        private void CbEmbarque_CheckedChanged(object sender, EventArgs e)
        {
            if (CbEmbarque.Checked)
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
