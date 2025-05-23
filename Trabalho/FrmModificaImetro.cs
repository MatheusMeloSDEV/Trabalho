using CLUSA;
using iText.Forms.Xfdf;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace Trabalho
{
    public partial class FrmModificaInmetro : Form
    {
        public Inmetro _inmetro;
        public string? Modo;
        public bool Visualização;
        private List<LiInfo> listaLis = new List<LiInfo>();
        public FrmModificaInmetro(Inmetro inmetro)
        {
            InitializeComponent();
            _inmetro = inmetro;
        }

        private void FrmModificaInmetro_Load(object sender, EventArgs e)
        {
            if (Modo == "Editar") { TXTnr.Enabled = false; }
            bsModificaInmetro.DataSource = _inmetro;
            InicializarDateTimePickersComCheckbox();
            CarregarDateTimePickers(_inmetro);
            CarregarLis(_inmetro);
            if (Visualização) SetCamposSomenteLeitura(this);
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
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

                // Recursivamente trata controles compostos (GroupBox, Panel, etc.)
                if (control.HasChildren)
                {
                    SetCamposSomenteLeitura(control);
                }
            }
        }
        private void CarregarDateTimePickers(Inmetro p)
        {
            // Mapeamento de cada DTP ao par (data, flag)
            var mapeamento = new Dictionary<DateTimePicker, (DateTime? data, bool has)>()
            {
                { DTPdatadeinspecao,          (p.InspecaoInmetro,       p.CheckInspecaoInmetro) },
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
        public void CarregarLis(Inmetro inmetro)
        {
            if (inmetro?.Li != null)
            {
                // Carrega apenas as LIs que possuem "DECEX" nos órgãos anuentes
                listaLis = inmetro.Li
                    .Where(li => li.OrgaosAnuentes != null && li.OrgaosAnuentes.Contains("INMETRO"))
                    .ToList();
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

            foreach (var li in listaLis)
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
                if (Visualização)
                {
                    btnVisualizar = new Button { Text = "Visualizar", Size = new Size(75, 25), Location = new Point(panel.Width - 80, 7), Anchor = AnchorStyles.Top | AnchorStyles.Right };
                    btnVisualizar.Click += (s, e) =>
                    {
                        var formVis = new frmLi(
                            li.Numero,
                            li.OrgaosAnuentes,
                            li.LPCO,
                            li.DataRegistroLPCO,
                            li.CheckDataRegistroLPCO,
                            li.DataDeferimentoLPCO,
                            li.CheckDataDeferimentoLPCO,
                            li.ParametrizacaoLPCO,
                            somenteVisualizacao: true);
                        // Define owner para permitir remoção e fechamento correto
                        formVis.Owner = this;
                        formVis.ShowDialog(this);
                    };
                }
                else
                {
                    btnVisualizar = new Button { Text = "Editar", Size = new Size(75, 25), Location = new Point(panel.Width - 80, 7), Anchor = AnchorStyles.Top | AnchorStyles.Right };
                    btnVisualizar.Click += (s, e) =>
                    {
                        var formVis = new frmLi(
                            li.Numero,
                            li.OrgaosAnuentes,
                            li.LPCO,
                            li.DataRegistroLPCO,
                            li.CheckDataRegistroLPCO,
                            li.DataDeferimentoLPCO,
                            li.CheckDataDeferimentoLPCO,
                            li.ParametrizacaoLPCO,
                            somenteVisualizacao: false);
                        // Define owner para permitir remoção e fechamento correto
                        formVis.Owner = this;
                        formVis.ShowDialog(this);
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
            var propData = typeof(Inmetro).GetProperty(nomePropData);
            if (propData?.PropertyType == typeof(DateTime?))
            {
                propData.SetValue(_inmetro, valor);
            }

            // 6) Atualiza o flag CheckDataX (bool)
            var propCheck = typeof(Inmetro).GetProperty("Check" + nomePropData);
            if (propCheck?.PropertyType == typeof(bool))
            {
                propCheck.SetValue(_inmetro, picker.Checked);
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

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            _inmetro.Importador = TXTimportador.Text;
            _inmetro.Ref_USA = TXTnr.Text;
            _inmetro.SR = TXTsr.Text;
            _inmetro.Navio = TXTNavio.Text;
            _inmetro.Exportador = TXTexportador.Text;
            _inmetro.Produto = TXTProduto.Text;
            _inmetro.Origem = TXTorigem.Text;
            _inmetro.Li = listaLis;
            _inmetro.NCM = TXTncm.Text;

            _inmetro.StatusDoProcesso = TXTstatusdoprocesso.Text;
            _inmetro.Pendencia = TXTpendencia.Text;
            _inmetro.Amostra = CBamostra.Checked;

            // Inspeção
            if (DTPdatadeinspecao.Checked)
            {
                _inmetro.InspecaoInmetro = DTPdatadeinspecao.Value;
                _inmetro.CheckInspecaoInmetro = true;
            }
            else
            {
                _inmetro.InspecaoInmetro = default;
                _inmetro.CheckInspecaoInmetro = false;
            }

            // Atracação
            if (DTPdatadeatracacao.Checked)
            {
                _inmetro.DataDeAtracacao = DTPdatadeatracacao.Value;
                _inmetro.CheckDataDeAtracacao = true;
            }
            else
            {
                _inmetro.DataDeAtracacao = default;
                _inmetro.CheckDataDeAtracacao = false;
            }

            // Embarque
            if (DTPdatadeembarque.Checked)
            {
                _inmetro.DataEmbarque = DTPdatadeembarque.Value;
                _inmetro.CheckDataEmbarque = true;
            }
            else
            {
                _inmetro.DataEmbarque = default;
                _inmetro.CheckDataEmbarque = false;
            }
            DialogResult confirmResult;
            if (Modo == "Editar")
            {
                confirmResult = MessageBox.Show(
                    $"Tem certeza de que deseja editar o processo {_inmetro.Ref_USA}?",
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
    }
}
