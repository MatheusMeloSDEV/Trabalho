using CLUSA;

namespace Trabalho
{
    public partial class frmModificaDecex : Form
    {
        public Decex decex;
        public frmModificaDecex()
        {
            InitializeComponent();
        }

        private void frmModificaDecex_Load(object sender, EventArgs e)
        {
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            DTPdatadedeferimentolilpco.Value = System.DateTime.Today;
            DTPdataderegistrolilpco.Value = System.DateTime.Today;
            DTPdatadeinspecao.Value = System.DateTime.Today;
            DTPdatadeatracacao.Value = System.DateTime.Today;
            DTPdatadeembarque.Value = System.DateTime.Today;
            bsModificaDecex.DataSource = decex;
        }

        private void btnOkMAPA_Click(object sender, EventArgs e)
        {


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            decex.Importador = TXTimportador.Text;
            decex.Ref_USA = TXTnr.Text;
            decex.SR = TXTsr.Text;
            decex.Exportador = TXTexportador.Text;
            decex.Produto = TXTProduto.Text;
            decex.Origem = TXTorigem.Text;
            decex.LI = TXTli.Text;
            decex.NCM = TXTncm.Text;

            decex.LPCO = TXTlilpco.Text;
            decex.DataRegistroLPCO = DTPdataderegistrolilpco.Value.ToShortDateString().ToString();
            decex.DataDeferimentoLPCO = DTPdatadedeferimentolilpco.Value.ToShortDateString().ToString();
            decex.ParametrizacaoLPCO = CBparametrizacaolilpco.Text;

            decex.TEmbarque = cbEmbarque.Checked;

            decex.DataDeAtracacao = DTPdatadeatracacao.Value.ToShortDateString().ToString();
            decex.Inspecao = DTPdatadeinspecao.Value.ToShortDateString().ToString();
            decex.DataEmbarque = DTPdatadeembarque.Value.ToShortDateString().ToString();
            decex.StatusDoProcesso = TXTstatusdoprocesso.Text;
            decex.Pendencia = TXTpendencia.Text;
            decex.Amostra = CBamostra.Checked;

            this.DialogResult = DialogResult.OK;
        }

        private void cbEmbarque_CheckedChanged(object sender, EventArgs e)
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
