using CLUSA;
using DnsClient.Protocol;
using System.Text.RegularExpressions;
using ZstdSharp.Unsafe;

namespace Trabalho
{
    public partial class frmModificaMapa : Form
    {
        public MAPA mapa;

        public frmModificaMapa()
        {
            InitializeComponent();
        }

        public void frmModifica_Load(object sender, EventArgs e)
        {
            bsModificaMAPA.DataSource = mapa;
            if (frmLogin.instance.escuro)
            {
                //DarkMode();
            }
        }

        private void tErro_Tick(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            mapa.Importador = TXTimportador.Text;
            mapa.Ref_USA = TXTnr.Text;
            mapa.SR = TXTsr.Text;
            mapa.Exportador = TXTexportador.Text;
            mapa.Produto = TXTProduto.Text;
            mapa.PortoDestino = TXTportodedestino.Text;
            mapa.Ordem = TXTordem.Text;
            mapa.FLO = TXTflo.Text;
            mapa.FreeTime = int.Parse(NUMfreetime.Text);
            mapa.BL = TXTbl.Text;
            mapa.AgenteDeCarga = TXTagentedecarga.Text;

            mapa.LI_LPCO = TXTlilpco.Text;
            mapa.DataRegistroLILPCO = DTPdataderegistrolilpco.Value.ToShortDateString().ToString();
            mapa.DataDeferimentoLILPCO = DTPdatadedeferimentolilpco.Value.ToShortDateString().ToString();
            mapa.ParametrizacaoLILPCO = CBparametrizacaolilpco.Text;

            mapa.DI = TXTdi.Text;
            mapa.DataRegistroDI = DTPdataderegistrodi.Value.ToShortDateString().ToString();
            mapa.DataDesembaracoDI = DTPdatadedesembaracodi.Value.ToShortDateString().ToString();
            mapa.DataCarregamentoDI = DTPdatadecarregamentodi.Value.ToShortDateString().ToString();
            mapa.ParametrizacaoDI = CBparametrizacaodi.Text;

            mapa.DataDeAtracacao = DTPdatadeatracacao.Value.ToShortDateString().ToString();
            mapa.Inspecao = DTPdatadeinspecao.Value.ToShortDateString().ToString();
            mapa.DataEmbarque = DTPdatadeembarque.Value.ToShortDateString().ToString();
            mapa.Previsao = DTPdatadeprevisao.Value.ToShortDateString().ToString();
            mapa.StatusDoProcesso = TXTstatusdoprocesso.Text;
            mapa.Pendencia = TXTpendencia.Text;
            mapa.Amostra = CBamostra.Checked;
            mapa.Desovado = CBdesovado.Checked;

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
                LBLprevisao.Visible = true;
                DTPdatadeprevisao.Visible = true;
            }
            else
            {
                LBLdatadeatracacao.Visible = false;
                DTPdatadeatracacao.Visible = false;
                LBLdatadeembarque.Visible = false;
                DTPdatadeembarque.Visible = false;
                LBLinspecao.Visible = false;
                DTPdatadeinspecao.Visible = false;
                LBLprevisao.Visible = false;
                DTPdatadeprevisao.Visible = false;
            }
        }
    }
}
