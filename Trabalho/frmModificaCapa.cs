using CLUSA;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Trabalho
{
    public partial class FrmModificaCapa : Form
    {
        public Capa capa;
        public string? Modo;
        public bool Visualizacao;

        public FrmModificaCapa()
        {
            InitializeComponent();
            capa = new();

            btnSalvar.Size = new Size(100, 32);
            btnCancelar.Size = new Size(100, 32);

            // Substitua
            // LBLSigvig, TXTSigvig, LBLSigvigData, DTPSigvigData

            // Por:
            LBLSigvig = new Label();
            CBOSigvig = new ComboBox();
            LBLSigvigData = new Label();
            DTPSigvigData = new DateTimePicker();

            CBOSigvig.DropDownStyle = ComboBoxStyle.DropDownList;
            CBOSigvig.Items.AddRange(new object[] { "Selecionado", "Liberado" });
            CBOSigvig.SelectedIndexChanged += new EventHandler(CBOSigvig_SelectedIndexChanged);
            CBOSigvig.SelectedIndex = 0; // padrão

            // Adicione ao TableLayoutPanel:
            tableLayoutPanel1.Controls.Add(LBLSigvig, 0, 2);
            tableLayoutPanel1.Controls.Add(CBOSigvig, 1, 2);
            tableLayoutPanel1.Controls.Add(LBLSigvigData, 0, 3);
            tableLayoutPanel1.Controls.Add(DTPSigvigData, 1, 3);
        }

        private void FrmModificaCapa_Load(object sender, EventArgs e)
        {
            if (Modo == "Editar") { TXTMaster.Enabled = false; }
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);

            // Preenche os controles com os valores do objeto capa
            TXTMaster.Text = capa.Master;
            TXTContainer.Text = capa.Container;
            CBOSigvig.SelectedItem = capa.Sigvig;
            DTPSigvigData.Value = capa.SigvigData ?? DateTime.Today;
            TXTIncoterm.Text = capa.Incoterm;
            TXTNumerario.Text = capa.Numerario;
            TXTDTA.Text = capa.DTA;
            TXTMarinha.Text = capa.Marinha;
            TXTCE.Text = capa.CE;
            if (capa.Imposto != null)
            {
                foreach (var item in capa.Imposto)
                {
                    int idx = CLBImposto.Items.IndexOf(item);
                    if (idx >= 0) CLBImposto.SetItemChecked(idx, true);
                }
            }

            // Adiciona os checkboxes ao FlowLayoutPanel
            panelBools.Controls.Add(CBTelaDoCanal);
            panelBools.Controls.Add(CBAverbar);
            panelBools.Controls.Add(CBLiberarBL);
            panelBools.Controls.Add(CBMarinhaMercante_Isencao);
            panelBools.Controls.Add(CBICMS_Exoneracao);
            panelBools.Controls.Add(CBLancado);
            panelBools.Controls.Add(CBConsultaSEFAZ);
            panelBools.Controls.Add(CBDAT_IIDeferida);
            panelBools.Controls.Add(CBSISCargaLiberado);
            panelBools.Controls.Add(CBDANFE);
            panelBools.Controls.Add(CBArmazenagem);
            panelBools.Controls.Add(CBFaturado);
            panelBools.Controls.Add(CBPago);
            panelBools.Controls.Add(CBENTTransporte);
            panelBools.Controls.Add(CBENTAlfandega);
            panelBools.Controls.Add(CBConferenciaFisica);

            // Bools
            CBTelaDoCanal.Checked = capa.TelaDoCanal;
            CBAverbar.Checked = capa.Averbar;
            CBLiberarBL.Checked = capa.LiberarBL;
            CBMarinhaMercante_Isencao.Checked = capa.MarinhaMercante_Isencao;
            CBICMS_Exoneracao.Checked = capa.ICMS_Exoneracao;
            CBLancado.Checked = capa.Lancado;
            CBConsultaSEFAZ.Checked = capa.ConsultaSEFAZ;
            CBDAT_IIDeferida.Checked = capa.DAT_IIDeferida;
            CBSISCargaLiberado.Checked = capa.SISCargaLiberado;
            CBDANFE.Checked = capa.DANFE;
            CBArmazenagem.Checked = capa.Armazenagem;
            CBFaturado.Checked = capa.Faturado;
            CBPago.Checked = capa.Pago;
            CBENTTransporte.Checked = capa.ENTTransporte;
            CBENTAlfandega.Checked = capa.ENTAlfandega;
            CBConferenciaFisica.Checked = capa.ConferenciaFisica;

            // Datas
            DTPAverbarData.Value = capa.AverbarData ?? DateTime.Today;
            DTPLiberarBLData.Value = capa.LiberarBLData ?? DateTime.Today;
            DTPMarinhaMercante_IsencaoData.Value = capa.MarinhaMercante_IsencaoData ?? DateTime.Today;
            DTPICMS_ExoneracaoData.Value = capa.ICMS_ExoneracaoData ?? DateTime.Today;
            DTPSISCargaLiberadoData.Value = capa.SISCargaLiberadoData ?? DateTime.Today;
            TXTPagoPor.Text = capa.PagoPor;
            DTPENTTransporteData.Value = capa.ENTTransporteData.Value;
            TXTENTTransporteN.Text = capa.ENTTransporteN;
            DTPENTAlfandegaData.Value = capa.ENTAlfandegaData.Value;
            TXTENTAlfandegaDossie.Text = capa.ENTAlfandegaDossie;
            DTPConferenciaFisicaData.Value = capa.ConferenciaFisicaData ?? DateTime.Today;

            TXTObservacoes.Text = capa.Observacoes;

            if (Visualizacao) SetCamposSomenteLeitura(this);
        }

        private void SetCamposSomenteLeitura(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                switch (control)
                {
                    case TextBox textBox:
                        textBox.ReadOnly = true;
                        break;
                    case DateTimePicker:
                    case CheckBox:
                    case ComboBox:
                    case NumericUpDown:
                    case CheckedListBox:
                        control.Enabled = false;
                        break;
                }
                if (control.HasChildren)
                    SetCamposSomenteLeitura(control);
            }
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            // Preencher objeto capa com os valores dos controles
            capa.Master = TXTMaster.Text;
            capa.Container = TXTContainer.Text;
            capa.Sigvig = CBOSigvig.SelectedItem?.ToString();
            capa.SigvigData = (capa.Sigvig == "Liberado") ? DTPSigvigData.Value : null;
            capa.Incoterm = TXTIncoterm.Text;
            capa.Numerario = TXTNumerario.Text;
            capa.DTA = TXTDTA.Text;
            capa.Marinha = TXTMarinha.Text;
            capa.CE = TXTCE.Text;
            capa.Imposto = CLBImposto.CheckedItems.OfType<string>().ToArray();

            capa.TelaDoCanal = CBTelaDoCanal.Checked;
            capa.Averbar = CBAverbar.Checked;
            capa.LiberarBL = CBLiberarBL.Checked;
            capa.MarinhaMercante_Isencao = CBMarinhaMercante_Isencao.Checked;
            capa.ICMS_Exoneracao = CBICMS_Exoneracao.Checked;
            capa.Lancado = CBLancado.Checked;
            capa.ConsultaSEFAZ = CBConsultaSEFAZ.Checked;
            capa.DAT_IIDeferida = CBDAT_IIDeferida.Checked;
            capa.SISCargaLiberado = CBSISCargaLiberado.Checked;
            capa.DANFE = CBDANFE.Checked;
            capa.Armazenagem = CBArmazenagem.Checked;
            capa.Faturado = CBFaturado.Checked;
            capa.Pago = CBPago.Checked;
            capa.ENTTransporte = CBENTTransporte.Checked;
            capa.ENTAlfandega = CBENTAlfandega.Checked;
            capa.ConferenciaFisica = CBConferenciaFisica.Checked;

            capa.AverbarData = DTPAverbarData.Value;
            capa.LiberarBLData = DTPLiberarBLData.Value;
            capa.MarinhaMercante_IsencaoData = DTPMarinhaMercante_IsencaoData.Value;
            capa.ICMS_ExoneracaoData = DTPICMS_ExoneracaoData.Value;
            capa.SISCargaLiberadoData = DTPSISCargaLiberadoData.Value;
            capa.PagoPor = TXTPagoPor.Text;
            DTPENTTransporteData.Value = capa.ENTTransporteData.Value;
            TXTENTTransporteN.Text = capa.ENTTransporteN;
            DTPENTAlfandegaData.Value = capa.ENTAlfandegaData.Value;
            TXTENTAlfandegaDossie.Text = capa.ENTAlfandegaDossie;
            DTPConferenciaFisicaData.Value = capa.ConferenciaFisicaData.Value;

            capa.Observacoes = TXTObservacoes.Text;

            DialogResult = DialogResult.OK;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CBOSigvig_SelectedIndexChanged(object sender, EventArgs e)
        {
            DTPSigvigData.Enabled = CBOSigvig.SelectedItem?.ToString() == "Liberado";
        }
    }
}