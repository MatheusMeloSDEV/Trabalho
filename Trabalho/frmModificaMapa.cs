using CLUSA;
using DnsClient.Protocol;
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
            dtpPrevisao.Format = DateTimePickerFormat.Custom; dtpPrevisao.CustomFormat = "dd/MM/yyyy";
            dtpDatadeInspecao.Format = DateTimePickerFormat.Custom; dtpDatadeInspecao.CustomFormat = "dd/MM/yyyy";
            dtpDatadeEntrada.Format = DateTimePickerFormat.Custom; dtpDatadeEntrada.CustomFormat = "dd/MM/yyyy";
            bsModificaMAPA.DataSource = mapa;
            if (frmLogin.instance.escuro)
            {
                //DarkMode();
            }
        }

        public void button1_Click(object sender, EventArgs e)
        {
            tErro.Interval = 1500;
            tErro.Tick += new System.EventHandler(this.tErro_Tick);
            btnOkMAPA.Enabled = false;
            tErro.Start();

            if (!check())
            {
                mapa.NR = int.Parse(insNR.Text);
                mapa.SR = int.Parse(insSR.Text);
                mapa.Importador = insImportador.Text;
                mapa.Terminal = insTerminal.Text;
                mapa.Pendencia = insPendencia.Text;
                mapa.CSIOriginal = insCSIOriginal.Text;
                mapa.LI = int.Parse(insLI.Text);
                mapa.LPCO = int.Parse(insLPCO.Text);
                mapa.Parametrizacao = insParametrizacao.Text;
                mapa.StatusDoProcesso = insStatusdoProcesso.Text;
                mapa.Previsao = dtpPrevisao.Value.ToShortDateString();
                mapa.DataDeEntrada = dtpDatadeEntrada.Value.ToShortDateString();
                mapa.DataDeInspeção = dtpDatadeInspecao.Value.ToShortDateString();
                this.DialogResult = DialogResult.OK;
            }
        }
        public bool check()
        {
            bool block = false;
            tErro.Interval = 1500;
            tErro.Tick += new System.EventHandler(this.tErro_Tick);

            if (insCSIOriginal.Text == "") { insCSIOriginal.BackColor = Color.MistyRose; block = true; tErro.Start(); }
            if (insImportador.Text == "") { insImportador.BackColor = Color.MistyRose; block = true; tErro.Start(); }
            if (insLI.Text == "") { insLI.BackColor = Color.MistyRose; block = true; tErro.Start(); }
            if (insLPCO.Text == "") { insLPCO.BackColor = Color.MistyRose; block = true; tErro.Start(); }
            if (insNR.Text == "") { insNR.BackColor = Color.MistyRose; block = true; tErro.Start(); }
            if (insParametrizacao.Text == "") { insParametrizacao.BackColor = Color.MistyRose; block = true; tErro.Start(); }
            if (insPendencia.Text == "") { insPendencia.BackColor = Color.MistyRose; block = true; tErro.Start(); }
            if (insStatusdoProcesso.Text == "") { insStatusdoProcesso.BackColor = Color.MistyRose; block = true; tErro.Start(); }
            if (insTerminal.Text == "") { insTerminal.BackColor = Color.MistyRose; block = true; tErro.Start(); }
            if (insSR.Text == "") { insSR.BackColor = Color.MistyRose; block = true; tErro.Start(); }

            return block;
        }

        private void tErro_Tick(object sender, EventArgs e)
        {
            insPendencia.BackColor = Color.White; insLPCO.BackColor = Color.White; insImportador.BackColor = Color.White; insCSIOriginal.BackColor = Color.White;
            insLI.BackColor = Color.White; insParametrizacao.BackColor = Color.White; insSR.BackColor = Color.White; insStatusdoProcesso.BackColor = Color.White;
            insTerminal.BackColor = Color.White; insNR.BackColor = Color.White; btnOkMAPA.Enabled = true;
            tErro.Stop();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
