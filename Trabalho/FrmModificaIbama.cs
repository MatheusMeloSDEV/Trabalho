using CLUSA;
using System.Text.RegularExpressions;

namespace Trabalho
{
    public partial class FrmModificaIbama : Form
    {
        public Ibama ibama;
        public FrmModificaIbama()
        {
            InitializeComponent();
            ibama = new();
        }

        private void FrmModificaIbama_Load(object sender, EventArgs e)
        {
            bsModificaIbama.DataSource = ibama;
            InicializarDateTimePickersComCheckbox();
            CarregarDateTimePickers(ibama);
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
        }

        private DateTime? GetDateIfChecked(DateTimePicker dtp)
            => dtp.Checked ? (DateTime?)dtp.Value : null;
        private void CarregarDateTimePickers(Ibama p)
        {
            // Mapeamento de cada DTP ao par (data, flag)
            var mapeamento = new Dictionary<DateTimePicker, (DateTime? data, bool has)>()
            {
                { DTPdataderegistrolilpco,    (p.DataRegistroLPCO,      p.CheckDataRegistroLPCO) },
                { DTPdatadedeferimentolilpco, (p.DataDeferimentoLPCO,   p.CheckDataDeferimentoLPCO) },
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
            DTPdataderegistrolilpco,
            DTPdatadedeferimentolilpco,
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
            ibama.Navio = TXTnavio.Text;
            ibama.Exportador = TXTexportador.Text;
            ibama.Produto = TXTProduto.Text;
            ibama.Origem = TXTorigem.Text;
            ibama.LI = TXTli.Text;
            ibama.NCM = TXTncm.Text;
            ibama.LPCO = TXTlilpco.Text;
            ibama.ParametrizacaoLPCO = CBparametrizacaolilpco.Text;
            ibama.StatusDoProcesso = TXTstatusdoprocesso.Text;
            ibama.Pendencia = TXTpendencia.Text;
            ibama.Amostra = CBamostra.Checked;

            // Registro LPCO
            if (DTPdataderegistrolilpco.Checked)
            {
                ibama.DataRegistroLPCO = DTPdataderegistrolilpco.Value;
                ibama.CheckDataRegistroLPCO = true;
            }
            else
            {
                ibama.DataRegistroLPCO = default; // ou DateTime.MinValue
                ibama.CheckDataRegistroLPCO = false;
            }
            // Deferimento LPCO
            if (DTPdatadedeferimentolilpco.Checked)
            {
                ibama.DataDeferimentoLPCO = DTPdatadedeferimentolilpco.Value;
                ibama.CheckDataDeferimentoLPCO = true;
            }
            else
            {
                ibama.DataDeferimentoLPCO = default;
                ibama.CheckDataDeferimentoLPCO = false;
            }
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

            this.DialogResult = DialogResult.OK;
        }

        private void CbEmbarque_CheckedChanged(object sender, EventArgs e)
        {
        }
    }
}
