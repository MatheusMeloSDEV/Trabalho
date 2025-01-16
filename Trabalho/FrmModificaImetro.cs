using CLUSA;

namespace Trabalho
{
    public partial class FrmModificaImetro : Form
    {
        public Imetro imetro;
        public FrmModificaImetro()
        {
            InitializeComponent();
        }

        private void frmModificaImetro_Load(object sender, EventArgs e)
        {
            DTPdatadedeferimentolilpco.Value = System.DateTime.Today;
            DTPdataderegistrolilpco.Value = System.DateTime.Today;
            DTPdatadeinspecao.Value = System.DateTime.Today;
            DTPdatadeatracacao.Value = System.DateTime.Today;
            DTPdatadeembarque.Value = System.DateTime.Today;
            bsModificaImetro.DataSource = imetro;
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            imetro.Importador = TXTimportador.Text;
            imetro.Ref_USA = TXTnr.Text;
            imetro.SR = TXTsr.Text;
            imetro.Navio = TXTnavio.Text;
            imetro.Exportador = TXTexportador.Text;
            imetro.Produto = TXTProduto.Text;
            imetro.Origem = TXTorigem.Text;
            imetro.LI = TXTli.Text;
            imetro.NCM = TXTncm.Text;

            imetro.LPCO = TXTlilpco.Text;
            imetro.DataRegistroLPCO = DTPdataderegistrolilpco.Value.ToShortDateString().ToString();
            imetro.DataDeferimentoLPCO = DTPdatadedeferimentolilpco.Value.ToShortDateString().ToString();
            imetro.ParametrizacaoLPCO = CBparametrizacaolilpco.Text;

            imetro.TEmbarque = cbEmbarque.Checked;

            imetro.DataDeAtracacao = DTPdatadeatracacao.Value.ToShortDateString().ToString();
            imetro.Inspecao = DTPdatadeinspecao.Value.ToShortDateString().ToString();
            imetro.DataEmbarque = DTPdatadeembarque.Value.ToShortDateString().ToString();
            imetro.StatusDoProcesso = TXTstatusdoprocesso.Text;
            imetro.Pendencia = TXTpendencia.Text;
            imetro.Amostra = CBamostra.Checked;

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
