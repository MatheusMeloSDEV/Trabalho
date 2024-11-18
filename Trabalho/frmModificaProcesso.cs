using CLUSA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho
{
    public partial class frmModificaProcesso : Form
    {
        public Processo processo;
        public frmModificaProcesso()
        {
            InitializeComponent();
        }

        private void frmModificaProcesso_Load(object sender, EventArgs e)
        {
            bsModificaProcesso.DataSource = processo;
            if (processo.PossuiEmbarque)
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

            DialogResult = DialogResult.OK;
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

        private void CBmapa_CheckedChanged(object sender, EventArgs e)
        {
        }
    }
}
