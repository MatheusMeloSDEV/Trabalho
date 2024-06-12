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
    public partial class frmModificaAnvisa : Form
    {
        public Anvisa anvisa;
        public frmModificaAnvisa()
        {
            InitializeComponent();
        }

        private void frmModificaAnvisa_Load(object sender, EventArgs e)
        {
            dtpPrevisao.Format = DateTimePickerFormat.Custom; dtpPrevisao.CustomFormat = "dd/MM/yyyy";
            dtpDatadeInspecao.Format = DateTimePickerFormat.Custom; dtpDatadeInspecao.CustomFormat = "dd/MM/yyyy";
            dtpDatadeEntrada.Format = DateTimePickerFormat.Custom; dtpDatadeEntrada.CustomFormat = "dd/MM/yyyy";
            bsModificaAnvisa.DataSource = anvisa;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            anvisa.NR = int.Parse(insNR.Text);
            anvisa.SR = int.Parse(insSR.Text);
            anvisa.Importador = insImportador.Text;
            anvisa.Terminal = insTerminal.Text;
            anvisa.Pendencia = insPendencia.Text;
            anvisa.LI = int.Parse(insLI.Text);
            anvisa.LPCO = int.Parse(insLPCO.Text);
            anvisa.StatusDoProcesso = insStatusdoProcesso.Text;
            anvisa.Previsao = dtpPrevisao.Value.ToShortDateString();
            anvisa.DataDeEntrada = dtpDatadeEntrada.Value.ToShortDateString();
            anvisa.DataDeInspeção = dtpDatadeInspecao.Value.ToShortDateString();
            this.DialogResult = DialogResult.OK;
        }
    }
}
