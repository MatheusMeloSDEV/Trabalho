using CLUSA;

namespace Trabalho
{
    public partial class FrmModificaProcesso : Form
    {
        public Processo processo;
        public FrmModificaProcesso()
        {
            InitializeComponent();
            processo = new();
        }

        private void FrmModificaProcesso_Load(object sender, EventArgs e)
        {
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            if (processo.PossuiEmbarque)
            {
                LBLdatadeatracacao.Visible = true;
                DTPdatadeatracacao.Visible = true;
                LBLdatadeembarque.Visible = true;
                DTPdatadeembarque.Visible = true;
                LBLinspecao.Visible = true;
                DTPdatadeinspecao.Visible = true;

            }
            DTPdatadedeferimentolilpco.Value = System.DateTime.Today;
            DTPdataderegistrolilpco.Value = System.DateTime.Today;
            DTPdataderegistrodi.Value = System.DateTime.Today;
            DTPdatadedesembaracodi.Value = System.DateTime.Today;
            DTPdatadecarregamentodi.Value = System.DateTime.Today;
            DTPdatadeinspecao.Value = System.DateTime.Today;
            DTPdatadeatracacao.Value = System.DateTime.Today;
            DTPdatadeembarque.Value = System.DateTime.Today;
            bsModificaProcesso.DataSource = processo;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdiciona_Click(object sender, EventArgs e)
        {
            processo.TMapa = CBmapa.Checked;
            processo.TAnvisa = CBanvisa.Checked;
            processo.TDecex = CBdecex.Checked;
            processo.TIbama = CBibama.Checked;
            processo.TImetro = CBimetro.Checked;

            processo.Importador = TXTimportador.Text;
            processo.Navio = TXTnavio.Text;
            processo.Ref_USA = TXTnr.Text;
            processo.SR = TXTsr.Text;
            processo.Exportador = TXTexportador.Text;
            processo.Produto = TXTProduto.Text;
            processo.PortoDestino = TXTportodedestino.Text;
            processo.Ordem = TXTordem.Text;
            processo.FLO = TXTflo.Text;
            processo.FreeTime = int.Parse(NUMfreetime.Text);
            processo.VencimentoFreeTime = DataHelper.CalcularVencimento(DTPdatadeatracacao.Value.ToShortDateString().ToString(), int.Parse(NUMfreetime.Text));
            processo.VencimentoFMA = DataHelper.CalcularVencimento(DTPdatadeatracacao.Value.ToShortDateString().ToString(), 85);
            processo.BL = TXTbl.Text;
            processo.AgenteDeCarga = TXTagentedecarga.Text;

            processo.LI = TXTli.Text;
            processo.LPCO = TXTlilpco.Text;
            processo.DataRegistroLPCO = DTPdataderegistrolilpco.Value.ToShortDateString().ToString();
            processo.DataDeferimentoLPCO = DTPdatadedeferimentolilpco.Value.ToShortDateString().ToString();
            processo.ParametrizacaoLPCO = CBparametrizacaolilpco.Text;

            processo.DI = TXTdi.Text;
            processo.DataRegistroDI = DTPdataderegistrodi.Value.ToShortDateString().ToString();
            processo.DataDesembaracoDI = DTPdatadedesembaracodi.Value.ToShortDateString().ToString();
            processo.DataCarregamentoDI = DTPdatadecarregamentodi.Value.ToShortDateString().ToString();
            processo.ParametrizacaoDI = CBparametrizacaodi.Text;

            processo.DataDeAtracacao = DTPdatadeatracacao.Value.ToShortDateString().ToString();
            processo.Inspecao = DTPdatadeinspecao.Value.ToShortDateString().ToString();
            processo.DataEmbarque = DTPdatadeembarque.Value.ToShortDateString().ToString();
            processo.StatusDoProcesso = TXTstatusdoprocesso.Text;
            processo.Pendencia = TXTpendencia.Text;
            processo.Amostra = CBamostra.Checked;
            processo.Desovado = CBdesovado.Checked;

            var confirmResult = MessageBox.Show(
                            $"Tem certeza de que deseja adicionar o novo processo?",
                            "Confirmação",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                // Opcional: Exibir um feedback ao usuário
                MessageBox.Show("Modificação feita.", "Sucesso",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
            }

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

        private void CBmapa_CheckedChanged(object sender, EventArgs e)
        {
        }
    }
}
