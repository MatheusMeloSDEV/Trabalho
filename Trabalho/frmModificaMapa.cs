using CLUSA;
using iText.Forms.Xfdf;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace Trabalho
{
    public partial class FrmModificaMapa : Form
    {
        public MAPA mapa;
        public string? Modo;
        public bool Visualização;
        private List<LiInfo> listaLis = new List<LiInfo>();
        public FrmModificaMapa()
        {
            InitializeComponent();
            mapa = new();
        }

        public void FrmModifica_Load(object sender, EventArgs e)
        {
            if (Modo == "Editar") { TXTnr.Enabled = false; }
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            BsModificaMAPA.DataSource = mapa;
            InicializarDateTimePickersComCheckbox();
            CarregarDateTimePickers(mapa);
            CarregarLis(mapa);
            if (Visualização) SetCamposSomenteLeitura(this);
        }
        private DateTime? GetDateIfChecked(DateTimePicker dtp)
            => dtp.Checked ? (DateTime?)dtp.Value : null;
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

                // Recursivamente trata controles compostos (GroupBox, Panel, etc.)
                if (control.HasChildren)
                {
                    SetCamposSomenteLeitura(control);
                }
            }
        }
        private void CarregarDateTimePickers(MAPA p)
        {
            // Mapeamento de cada DTP ao par (data, flag)
            var mapeamento = new Dictionary<DateTimePicker, (DateTime? data, bool has)>()
            {
                { DTPdatadeinspecao,          (p.InspecaoMapa,          p.CheckInspecaoMapa) },
                { DTPdatadeatracacao,         (p.DataDeAtracacao,       p.CheckDataDeAtracacao) },
                { DTPdatadeembarque,          (p.DataEmbarque,          p.CheckDataEmbarque) },
            };

            foreach (var kv in mapeamento)
            {
                var dtp = kv.Key;
                var (date, has) = kv.Value;

                // 1) Se quiser exibir checkbox interno (opcional)
                dtp.ShowCheckBox = true;

                // 2) Sincroniza o Checked com o banco
                dtp.Checked = has;

                // 3) Se tiver data, formata e atribui; senão, mantém em branco
                if (has && date.HasValue)
                {
                    dtp.Format = DateTimePickerFormat.Short;
                    dtp.Value = date.Value;
                }
                else
                {
                    dtp.Format = DateTimePickerFormat.Custom;
                    dtp.CustomFormat = " -";
                }
            }
        }
        public bool ContainsLi(string numeroLi)
        {
            return listaLis.Any(li => li.Numero == numeroLi);
        }

        public void AdicionarLi(LiInfo li)
        {
            listaLis.Add(li);
            AtualizarPainelLi();
        }

        public void AtualizarLi(string numeroLi, LiInfo liAtualizada)
        {
            var existente = listaLis.FirstOrDefault(li => li.Numero == numeroLi);
            if (existente != null)
            {
                existente.OrgaosAnuentes = liAtualizada.OrgaosAnuentes;
                existente.LPCO = liAtualizada.LPCO;
                existente.DataRegistroLPCO = liAtualizada.DataRegistroLPCO;
                existente.CheckDataRegistroLPCO = liAtualizada.CheckDataRegistroLPCO;
                existente.DataDeferimentoLPCO = liAtualizada.DataDeferimentoLPCO;
                existente.CheckDataDeferimentoLPCO = liAtualizada.CheckDataDeferimentoLPCO;
                existente.ParametrizacaoLPCO = liAtualizada.ParametrizacaoLPCO;

                AtualizarPainelLi();
            }
        }

        public void RemoverLi(string numeroLi)
        {
            var li = listaLis.FirstOrDefault(x => x.Numero == numeroLi);
            if (li != null)
            {
                listaLis.Remove(li);
                AtualizarPainelLi();
            }
        }
        public void CarregarLis(MAPA mapa)
        {
            if (mapa?.Li != null)
            {
                listaLis = mapa.Li.ToList();
                AtualizarPainelLi();
            }
        }
        private void AtualizarPainelLi()
        {
            flpLis.Controls.Clear();
            flpLis.FlowDirection = FlowDirection.LeftToRight;
            flpLis.WrapContents = true;
            flpLis.AutoScroll = true;

            int panelWidth = (flpLis.ClientSize.Width - SystemInformation.VerticalScrollBarWidth) / 2 - 4;
            int panelHeight = 40;

            foreach (var li in listaLis.Where(li => li.OrgaosAnuentes?.Contains("MAPA") == true))
            {
                var panel = new Panel
                {
                    Size = new Size(panelWidth, panelHeight),
                    BorderStyle = BorderStyle.FixedSingle,
                    Margin = new Padding(2)
                };

                var lbl = new Label
                {
                    Text = $"LI: {li.Numero}",
                    AutoSize = true,
                    Location = new Point(5, 10)
                };

                var btnVisualizar = new Button();

                if (!Visualização)
                {
                    btnVisualizar.Text = "Editar";
                    btnVisualizar.Click += (s, e) => {
                        // abre frmLi em modo editável
                        var frm = new frmLi(
                            li.Numero, li.OrgaosAnuentes, li.LPCO,
                            li.DataRegistroLPCO, li.CheckDataRegistroLPCO,
                            li.DataDeferimentoLPCO, li.CheckDataDeferimentoLPCO,
                            li.ParametrizacaoLPCO,
                            somenteVisualizacao: false  // <-- deixa editar
                        );
                        frm.Owner = this;
                        frm.ShowDialog(this);
                    };
                }

                panel.Controls.Add(lbl);
                panel.Controls.Add(btnVisualizar);
                flpLis.Controls.Add(panel);
            }
        }
        private void DateTimePicker_OnValueChanged(object? sender, EventArgs e)
        {
            // 1) Garante que sender é um DateTimePicker não-nulo
            if (sender is not DateTimePicker picker)
                return;

            // 2) Extrai o sufixo do nome para construir o nome da propriedade
            var campo = picker.Name!.Substring(3);  // confia que Name não é null

            // 3) Ajusta o formato de acordo com o Checked
            if (picker.Checked)
            {
                picker.Format = DateTimePickerFormat.Short;
            }
            else
            {
                picker.Format = DateTimePickerFormat.Custom;
                picker.CustomFormat = "' -'";
            }

            // 4) Prepara o valor nullable
            DateTime? valor = picker.Checked
                ? picker.Value
                : (DateTime?)null;

            // 5) Atualiza a propriedade DateTime? (DataX) no seu objeto _anvisa
            var nomePropData = char.ToUpper(campo[0]) + campo.Substring(1);
            var propData = typeof(MAPA).GetProperty(nomePropData);
            if (propData?.PropertyType == typeof(DateTime?))
            {
                propData.SetValue(mapa, valor);
            }

            // 6) Atualiza o flag CheckDataX (bool)
            var propCheck = typeof(MAPA).GetProperty("Check" + nomePropData);
            if (propCheck?.PropertyType == typeof(bool))
            {
                propCheck.SetValue(mapa, picker.Checked);
            }
        }

        private void InicializarDateTimePickersComCheckbox()
        {
            // Liste aqui todos os seus DateTimePickers que devem ter checkbox interno
            var dtps = new[]
            {
            DTPdatadeinspecao,
            DTPdatadeatracacao,
            DTPdatadeembarque
            };

            foreach (var dtp in dtps)
            {
                dtp.ShowCheckBox = true;
                dtp.ValueChanged += DateTimePicker_OnValueChanged;
                // caso queira capturar também o uncheck via clique:
                dtp.MouseUp += (s, e2) => DateTimePicker_OnValueChanged(s!, EventArgs.Empty);
            }
        }
        private void TErro_Tick(object sender, EventArgs e)
        {

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            mapa.Importador = TXTimportador.Text;
            mapa.Ref_USA = TXTnr.Text;
            mapa.SR = TXTsr.Text;
            mapa.Exportador = TXTexportador.Text;
            mapa.Produto = TXTProduto.Text;
            mapa.Origem = TXTorigem.Text;
            mapa.Navio = TXTNavio.Text;
            mapa.Li = listaLis;
            mapa.NCM = TXTncm.Text;
            mapa.StatusDoProcesso = TXTstatusdoprocesso.Text;
            mapa.Pendencia = TXTpendencia.Text;
            mapa.Amostra = CBamostra.Checked;

            // Inspeção
            if (DTPdatadeinspecao.Checked)
            {
                mapa.InspecaoMapa = DTPdatadeinspecao.Value;
                mapa.CheckInspecaoMapa = true;
            }
            else
            {
                mapa.InspecaoMapa = default;
                mapa.CheckInspecaoMapa = false;
            }

            // Atracação
            if (DTPdatadeatracacao.Checked)
            {
                mapa.DataDeAtracacao = DTPdatadeatracacao.Value;
                mapa.CheckDataDeAtracacao = true;
            }
            else
            {
                mapa.DataDeAtracacao = default;
                mapa.CheckDataDeAtracacao = false;
            }

            // Embarque
            if (DTPdatadeembarque.Checked)
            {
                mapa.DataEmbarque = DTPdatadeembarque.Value;
                mapa.CheckDataEmbarque = true;
            }
            else
            {
                mapa.DataEmbarque = default;
                mapa.CheckDataEmbarque = false;
            }

            DialogResult confirmResult;
            if (Modo == "Editar")
            {
                confirmResult = MessageBox.Show(
                    $"Tem certeza de que deseja editar o processo {mapa.Ref_USA}?",
                    "Confirmação",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (confirmResult == DialogResult.Yes) { DialogResult = DialogResult.OK; }
            }
            else
            {
                DialogResult = DialogResult.OK;
            }
        }

        private void CbEmbarque_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbInspecao_CheckedChanged(object sender, EventArgs e)
        {
        }
    }
}
