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
    public partial class frmModificaDecex : Form
    {
        public Decex decex;
        public frmModificaDecex()
        {
            InitializeComponent();
        }

        private void frmModificaDecex_Load(object sender, EventArgs e)
        {
            dtpPrevisao.Format = DateTimePickerFormat.Custom; dtpPrevisao.CustomFormat = "dd/MM/yyyy";
            dtpDatadeEntrada.Format = DateTimePickerFormat.Custom; dtpDatadeEntrada.CustomFormat = "dd/MM/yyyy";
            bsModificaDecex.DataSource = decex;
        }

        private void btnOkMAPA_Click(object sender, EventArgs e)
        {
            decex.NR = int.Parse(insNR.Text);
            decex.SR = int.Parse(insSR.Text);
            decex.Importador = insImportador.Text;
            decex.Terminal = insTerminal.Text;
            decex.Pendencia = insPendencia.Text;
            decex.LI = int.Parse(insLI.Text);
            decex.StatusDoProcesso = insStatusdoProcesso.Text;
            decex.Previsao = dtpPrevisao.Value.ToShortDateString();
            decex.DataDeEntrada = dtpDatadeEntrada.Value.ToShortDateString();
            this.DialogResult = DialogResult.OK;
        }
    }
}
