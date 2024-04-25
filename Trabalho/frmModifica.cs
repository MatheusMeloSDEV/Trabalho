using CLUSA;

namespace Trabalho
{
    public partial class frmModifica : Form
    {
        public MAPA mapa;

        public frmModifica()
        {
            InitializeComponent();
        }

        private void frmModifica_Load(object sender, EventArgs e)
        {
            dtpPrevisao.Format = DateTimePickerFormat.Custom; dtpPrevisao.CustomFormat = "dd/MM/yyyy";
            dtpDatadeInspecao.Format = DateTimePickerFormat.Custom; dtpDatadeInspecao.CustomFormat = "dd/MM/yyyy";
            dtpDatadeEntrada.Format = DateTimePickerFormat.Custom; dtpDatadeEntrada.CustomFormat = "dd/MM/yyyy";
            bsModificaMAPA.DataSource = mapa;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mapa.NR = insNR.Text;
            mapa.SR = insSR.Text;
            mapa.Importador = insImportador.Text;
            mapa.Terminal = insTerminal.Text;
            mapa.Pendencia = insPendencia.Text;
            mapa.CSIOriginal = insCSIOriginal.Text;
            mapa.LI = insLI.Text;
            mapa.LPCO = insLPCO.Text;
            mapa.Parametrizacao = insParametrizacao.Text;
            mapa.StatusDoProcesso = insStatusdoProcesso.Text;
            mapa.Previsao = dtpPrevisao.Value.ToShortDateString();
            mapa.DataDeEntrada = dtpDatadeEntrada.Value.ToShortDateString();
            mapa.DataDeInspeção = dtpDatadeInspecao.Value.ToShortDateString();
            this.DialogResult = DialogResult.OK;
        }

        private void insCSIOriginal_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
