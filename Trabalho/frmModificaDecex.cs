using CLUSA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            decex.PortoDestino = TXTportodedestino.Text;
            decex.Ordem = TXTordem.Text;
            decex.FLO = TXTflo.Text;
            decex.FreeTime = int.Parse(NUMfreetime.Text);
            decex.BL = TXTbl.Text;
            decex.AgenteDeCarga = TXTagentedecarga.Text;

            decex.LI_LPCO = TXTlilpco.Text;
            decex.DataRegistroLILPCO = DTPdataderegistrolilpco.Value.ToShortDateString().ToString();
            decex.DataDeferimentoLILPCO = DTPdatadedeferimentolilpco.Value.ToShortDateString().ToString();
            decex.ParametrizacaoLILPCO = CBparametrizacaolilpco.Text;

            decex.DI = TXTdi.Text;
            decex.DataRegistroDI = DTPdataderegistrodi.Value.ToShortDateString().ToString();
            decex.DataDesembaracoDI = DTPdatadedesembaracodi.Value.ToShortDateString().ToString();
            decex.DataCarregamentoDI = DTPdatadecarregamentodi.Value.ToShortDateString().ToString();
            decex.ParametrizacaoDI = CBparametrizacaodi.Text;

            decex.DataDeAtracacao = DTPdatadeatracacao.Value.ToShortDateString().ToString();
            decex.Inspecao = DTPdatadeinspecao.Value.ToShortDateString().ToString();
            decex.DataEmbarque = DTPdatadeembarque.Value.ToShortDateString().ToString();
            decex.Previsao = DTPdatadeprevisao.Value.ToShortDateString().ToString();
            decex.StatusDoProcesso = TXTstatusdoprocesso.Text;
            decex.Pendencia = TXTpendencia.Text;
            decex.Amostra = CBamostra.Checked;
            decex.Desovado = CBdesovado.Checked;

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
