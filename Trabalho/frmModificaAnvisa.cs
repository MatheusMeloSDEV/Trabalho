using CLUSA;

namespace Trabalho
{
    public partial class FrmModificaAnvisa : Form
    {
        public Anvisa anvisa;

        public FrmModificaAnvisa()
        {
            InitializeComponent();
            anvisa = new();
        }

        public void FrmModificaAnvisa_Load(object sender, EventArgs e)
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
            BsModificaAnvisa.DataSource = anvisa;
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
            anvisa.Importador = TXTimportador.Text;
            anvisa.Ref_USA = TXTnr.Text;
            anvisa.SR = TXTsr.Text;
            anvisa.Exportador = TXTexportador.Text;
            anvisa.Produto = TXTProduto.Text;
            anvisa.Origem = TXTorigem.Text;
            anvisa.LI = TXTli.Text;
            anvisa.NCM = TXTncm.Text;

            anvisa.LPCO = TXTlilpco.Text;
            anvisa.DataRegistroLPCO = DTPdataderegistrolilpco.Value.ToShortDateString().ToString();
            anvisa.DataDeferimentoLPCO = DTPdatadedeferimentolilpco.Value.ToShortDateString().ToString();
            anvisa.ParametrizacaoLPCO = CBparametrizacaolilpco.Text;

            anvisa.TEmbarque = CbEmbarque.Checked;

            anvisa.DataDeAtracacao = DTPdatadeatracacao.Value.ToShortDateString().ToString();
            anvisa.Inspecao = DTPdatadeinspecao.Value.ToShortDateString().ToString();
            anvisa.DataEmbarque = DTPdatadeembarque.Value.ToShortDateString().ToString();
            anvisa.StatusDoProcesso = TXTstatusdoprocesso.Text;
            anvisa.Pendencia = TXTpendencia.Text;
            anvisa.Amostra = CBamostra.Checked;

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
