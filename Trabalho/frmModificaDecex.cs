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
            //dtpDatadeEntrada.Format = DateTimePickerFormat.Custom; dtpDatadeEntrada.CustomFormat = "dd/MM/yyyy";
            bsModificaDecex.DataSource = decex;
        }

        private void btnOkMAPA_Click(object sender, EventArgs e)
        {


        }
        private bool check()
        {
            bool block = false;
            tError.Interval = 1500;
            tError.Tick += new System.EventHandler(this.tError_Tick);

            if (insImportador.Text == "") { insImportador.BackColor = Color.MistyRose; block = true; tError.Start(); }
            if (insLI.Text == "") { insLI.BackColor = Color.MistyRose; block = true; tError.Start(); }

            if (insNR.Text == "") { insNR.BackColor = Color.MistyRose; block = true; tError.Start(); }

            if (insPendencia.Text == "") { insPendencia.BackColor = Color.MistyRose; block = true; tError.Start(); }
            if (insStatusdoProcesso.Text == "") { insStatusdoProcesso.BackColor = Color.MistyRose; block = true; tError.Start(); }
            if (insTerminal.Text == "") { insTerminal.BackColor = Color.MistyRose; block = true; tError.Start(); }
            if (insSR.Text == "") { insSR.BackColor = Color.MistyRose; block = true; tError.Start(); }

            return block;

        }

        private void tError_Tick(object sender, EventArgs e)
        {
            insPendencia.BackColor = Color.White; BackColor = Color.White; insImportador.BackColor = Color.White; BackColor = Color.White;
            insLI.BackColor = Color.White; BackColor = Color.White; insSR.BackColor = Color.White; insStatusdoProcesso.BackColor = Color.White;
            insTerminal.BackColor = Color.White; insNR.BackColor = Color.White; btnEditar.Enabled = true;
            tError.Stop();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            tError.Interval = 1500;
            tError.Tick += new System.EventHandler(this.tError_Tick);
            btnEditar.Enabled = false;
            tError.Start();
            if (!check())
            {
                decex.Ref_USA = insNR.Text;
                decex.SR = int.Parse(insSR.Text);
                decex.Importador = insImportador.Text;
                decex.Terminal = insTerminal.Text;
                decex.Pendencia = insPendencia.Text;
                decex.LI = int.Parse(insLI.Text);
                decex.StatusDoProcesso = insStatusdoProcesso.Text;
                decex.Previsao = dtpPrevisao.Value.ToShortDateString();
                //decex.DataDeEntrada = dtpDatadeEntrada.Value.ToShortDateString();
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
