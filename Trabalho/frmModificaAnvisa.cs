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
            tError.Interval = 1500;
            tError.Tick += new System.EventHandler(this.tError_Tick);
            btnOk.Enabled = false;
            tError.Start();

            if (!check())
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

        private bool check()
        {
            bool block = false;
            tError.Interval = 1500;
            tError.Tick += new System.EventHandler(this.tError_Tick);

            if (insImportador.Text == "") { insImportador.BackColor = Color.MistyRose; block = true; tError.Start(); }
            if (insLI.Text == "") { insLI.BackColor = Color.MistyRose; block = true; tError.Start(); }
            if (insLPCO.Text == "") { insLPCO.BackColor = Color.MistyRose; block = true; tError.Start(); }
            if (insNR.Text == "") { insNR.BackColor = Color.MistyRose; block = true; tError.Start(); }
            if (insPendencia.Text == "") { insPendencia.BackColor = Color.MistyRose; block = true; tError.Start(); }
            if (insStatusdoProcesso.Text == "") { insStatusdoProcesso.BackColor = Color.MistyRose; block = true; tError.Start(); }
            if (insTerminal.Text == "") { insTerminal.BackColor = Color.MistyRose; block = true; tError.Start(); }
            if (insSR.Text == "") { insSR.BackColor = Color.MistyRose; block = true; tError.Start(); }

            return block;
        }

        private void tError_Tick(object sender, EventArgs e)
        {
            insPendencia.BackColor = Color.White; insLPCO.BackColor = Color.White; insImportador.BackColor = Color.White;
            insLI.BackColor = Color.White; insSR.BackColor = Color.White; insStatusdoProcesso.BackColor = Color.White;
            insTerminal.BackColor = Color.White; insNR.BackColor = Color.White; btnOk.Enabled = true;
            tError.Stop();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
