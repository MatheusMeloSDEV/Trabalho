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
    public partial class frmModificaAnvisa : Form
    {
        public Anvisa anvisa;
        public frmModificaAnvisa()
        {
            InitializeComponent();
        }

        private void frmModificaAnvisa_Load(object sender, EventArgs e)
        {
            bsModificaAnvisa.DataSource = anvisa;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            anvisa.Importador = TXTimportador.Text;
            anvisa.Ref_USA = TXTnr.Text;
            anvisa.SR = TXTsr.Text;
            anvisa.Exportador = TXTexportador.Text;
            anvisa.Produto = TXTProduto.Text;
            anvisa.PortoDestino = TXTportodedestino.Text;
            anvisa.Ordem = TXTordem.Text;
            anvisa.FLO = TXTflo.Text;
            anvisa.FreeTime = int.Parse(NUMfreetime.Text);
            anvisa.BL = TXTbl.Text;
            anvisa.AgenteDeCarga = TXTagentedecarga.Text;

            anvisa.LI_LPCO = TXTlilpco.Text;
            anvisa.DataRegistroLILPCO = DTPdataderegistrolilpco.Value.ToShortDateString().ToString();
            anvisa.DataDeferimentoLILPCO = DTPdatadedeferimentolilpco.Value.ToShortDateString().ToString();
            anvisa.ParametrizacaoLILPCO = CBparametrizacaolilpco.Text;

            anvisa.DI = TXTdi.Text;
            anvisa.DataRegistroDI = DTPdataderegistrodi.Value.ToShortDateString().ToString();
            anvisa.DataDesembaracoDI = DTPdatadedesembaracodi.Value.ToShortDateString().ToString();
            anvisa.DataCarregamentoDI = DTPdatadecarregamentodi.Value.ToShortDateString().ToString();
            anvisa.ParametrizacaoDI = CBparametrizacaodi.Text;

            anvisa.DataDeAtracacao = DTPdatadeatracacao.Value.ToShortDateString().ToString();
            anvisa.Inspecao = DTPdatadeinspecao.Value.ToShortDateString().ToString();
            anvisa.DataEmbarque = DTPdatadeembarque.Value.ToShortDateString().ToString();
            anvisa.Previsao = DTPdatadeprevisao.Value.ToShortDateString().ToString();
            anvisa.StatusDoProcesso = TXTstatusdoprocesso.Text;
            anvisa.Pendencia = TXTpendencia.Text;
            anvisa.Amostra = CBamostra.Checked;
            anvisa.Desovado = CBdesovado.Checked;

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
