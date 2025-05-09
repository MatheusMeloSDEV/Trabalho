using CLUSA;
using System.Diagnostics;

namespace Trabalho
{
    public partial class FrmModificaDecex : Form
    {
        public Decex decex;
        public FrmModificaDecex()
        {
            InitializeComponent();
            decex = new();
        }

        private void FrmModificaDecex_Load(object sender, EventArgs e)
        {
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            InicializarDateTimePickersComCheckbox();
            CarregarDateTimePickers(decex);
            bsModificaDecex.DataSource = decex;
        }
        private DateTime? GetDateIfChecked(DateTimePicker dtp)
            => dtp.Checked ? (DateTime?)dtp.Value : null;
        private void CarregarDateTimePickers(Decex p)
        {
            // Mapeamento de cada DTP ao par (data, flag)
            var mapeamento = new Dictionary<DateTimePicker, (DateTime? data, bool has)>()
            {
                { DTPdataderegistrolilpco,    (p.DataRegistroLPCO,      p.CheckDataRegistroLPCO) },
                { DTPdatadedeferimentolilpco, (p.DataDeferimentoLPCO,   p.CheckDataDeferimentoLPCO) },
                { DTPdatadeinspecao,          (p.InspecaoDecex,       p.CheckInspecaoDecex) },
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
            var propData = typeof(Decex).GetProperty(nomePropData);
            if (propData?.PropertyType == typeof(DateTime?))
            {
                propData.SetValue(decex, valor);
            }

            // 6) Atualiza o flag CheckDataX (bool)
            var propCheck = typeof(Decex).GetProperty("Check" + nomePropData);
            if (propCheck?.PropertyType == typeof(bool))
            {
                propCheck.SetValue(decex, picker.Checked);
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

        private void BtnOkMAPA_Click(object sender, EventArgs e)
        {


        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            decex.Importador = TXTimportador.Text;
            decex.Ref_USA = TXTnr.Text;
            decex.SR = TXTsr.Text;
            decex.Exportador = TXTexportador.Text;
            decex.Produto = TXTProduto.Text;
            decex.Origem = TXTorigem.Text;
            decex.LI = TXTli.Text;
            decex.NCM = TXTncm.Text;

            decex.LPCO = TXTlilpco.Text;
            decex.ParametrizacaoLPCO = CBparametrizacaolilpco.Text;

            decex.StatusDoProcesso = TXTstatusdoprocesso.Text;
            decex.Pendencia = TXTpendencia.Text;
            decex.Amostra = CBamostra.Checked;

            // Registro LPCO
            if (DTPdataderegistrolilpco.Checked)
            {
                decex.DataRegistroLPCO = DTPdataderegistrolilpco.Value;
                decex.CheckDataRegistroLPCO = true;
            }
            else
            {
                decex.DataRegistroLPCO = default; // ou DateTime.MinValue
                decex.CheckDataRegistroLPCO = false;
            }
            // Deferimento LPCO
            if (DTPdatadedeferimentolilpco.Checked)
            {
                decex.DataDeferimentoLPCO = DTPdatadedeferimentolilpco.Value;
                decex.CheckDataDeferimentoLPCO = true;
            }
            else
            {
                decex.DataDeferimentoLPCO = default;
                decex.CheckDataDeferimentoLPCO = false;
            }
            // Inspeção
            if (DTPdatadeinspecao.Checked)
            {
                decex.InspecaoDecex = DTPdatadeinspecao.Value;
                decex.CheckInspecaoDecex = true;
            }
            else
            {
                decex.InspecaoDecex = default;
                decex.CheckInspecaoDecex = false;
            }

            // Atracação
            if (DTPdatadeatracacao.Checked)
            {
                decex.DataDeAtracacao = DTPdatadeatracacao.Value;
                decex.CheckDataDeAtracacao = true;
            }
            else
            {
                decex.DataDeAtracacao = default;
                decex.CheckDataDeAtracacao = false;
            }

            // Embarque
            if (DTPdatadeembarque.Checked)
            {
                decex.DataEmbarque = DTPdatadeembarque.Value;
                decex.CheckDataEmbarque = true;
            }
            else
            {
                decex.DataEmbarque = default;
                decex.CheckDataEmbarque = false;
            }
            this.DialogResult = DialogResult.OK;
        }

        private void CbEmbarque_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
