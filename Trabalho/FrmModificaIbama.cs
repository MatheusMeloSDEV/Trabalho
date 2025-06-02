using CLUSA;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace Trabalho
{
    public partial class FrmModificaIbama : Form, ILiHandler
    {
        public Ibama ibama;
        public string? Modo;
        public bool Visualização;
        private List<LiInfo> listaLis;
        public FrmModificaIbama()
        {
            InitializeComponent();
            ibama = new();
        }

        private void FrmModificaIbama_Load(object sender, EventArgs e)
        {
            if (Modo == "Editar") { TXTnr.Enabled = false; }
            bsModificaIbama.DataSource = ibama;
            listaLis = ibama.Li;
            InicializarDateTimePickersComCheckbox();
            CarregarDateTimePickers(ibama);
            CarregarLis(ibama);
            if (Visualização) SetCamposSomenteLeitura(this);
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
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
        private void CarregarDateTimePickers(Ibama p)
        {
            // Mapeamento de cada DTP ao par (data, flag)
            var mapeamento = new Dictionary<DateTimePicker, (DateTime? data, bool has)>()
            {
                { DTPdatadeinspecao,          (p.InspecaoIbama,         p.CheckInspecaoIbama) },
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
                existente.NCM = liAtualizada.NCM;
                existente.DataRegistroLI = liAtualizada.DataRegistroLI;
                existente.CheckDataRegistroLI = liAtualizada.CheckDataRegistroLI;
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
        public void CarregarLis(Ibama ibama)
        {
            if (ibama?.Li != null)
            {
                listaLis = ibama.Li.ToList();
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

            foreach (var li in listaLis.Where(li => li.OrgaosAnuentes?.Contains("IBAMA") == true))
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

                var somenteVisualizacao = this.Visualização;
                var btnVisualizar = new Button
                {
                    Text = somenteVisualizacao ? "Visualizar" : "Editar",
                    Size = new Size(75, 25),
                    Location = new Point(panel.Width - 80, 7),
                    Anchor = AnchorStyles.Top | AnchorStyles.Right
                };

                btnVisualizar.Click += (s, e) =>
                {
                    var frm = new frmLi(
                        li.Numero, li.OrgaosAnuentes, li.NCM, li.LPCO,
                        li.DataRegistroLI, li.CheckDataRegistroLI,
                        li.DataRegistroLPCO, li.CheckDataRegistroLPCO,
                        li.DataDeferimentoLPCO, li.CheckDataDeferimentoLPCO,
                        li.ParametrizacaoLPCO,
                        somenteVisualizacao
                    );
                    frm.Owner = this;
                    frm.ShowDialog(this);
                };

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
            var propData = typeof(Ibama).GetProperty(nomePropData);
            if (propData?.PropertyType == typeof(DateTime?))
            {
                propData.SetValue(ibama, valor);
            }

            // 6) Atualiza o flag CheckDataX (bool)
            var propCheck = typeof(Ibama).GetProperty("Check" + nomePropData);
            if (propCheck?.PropertyType == typeof(bool))
            {
                propCheck.SetValue(ibama, picker.Checked);
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
            ibama.Importador = TXTimportador.Text;
            ibama.Ref_USA = TXTnr.Text;
            ibama.SR = TXTsr.Text;
            ibama.Veiculo = TXTNavio.Text;
            ibama.Exportador = TXTexportador.Text;
            ibama.Produto = TXTProduto.Text;
            ibama.Origem = TXTorigem.Text;
            ibama.Li = listaLis;
            ibama.StatusDoProcesso = TXTstatusdoprocesso.Text;
            ibama.Pendencia = TXTpendencia.Text;
            ibama.Amostra = CBamostra.Checked;

            // Inspeção
            if (DTPdatadeinspecao.Checked)
            {
                ibama.InspecaoIbama = DTPdatadeinspecao.Value;
                ibama.CheckInspecaoIbama = true;
            }
            else
            {
                ibama.InspecaoIbama = default;
                ibama.CheckInspecaoIbama = false;
            }

            // Atracação
            if (DTPdatadeatracacao.Checked)
            {
                ibama.DataDeAtracacao = DTPdatadeatracacao.Value;
                ibama.CheckDataDeAtracacao = true;
            }
            else
            {
                ibama.DataDeAtracacao = default;
                ibama.CheckDataDeAtracacao = false;
            }

            // Embarque
            if (DTPdatadeembarque.Checked)
            {
                ibama.DataEmbarque = DTPdatadeembarque.Value;
                ibama.CheckDataEmbarque = true;
            }
            else
            {
                ibama.DataEmbarque = default;
                ibama.CheckDataEmbarque = false;
            }

            DialogResult confirmResult;
            if (Modo == "Editar")
            {
                confirmResult = MessageBox.Show(
                    $"Tem certeza de que deseja editar o processo {ibama.Ref_USA}?",
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

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
        }
    }
}
