using CLUSA;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace Trabalho
{
    public partial class FrmModificaInmetro : Form
    {
        public Inmetro _inmetro;
        public FrmModificaInmetro(Inmetro inmetro)
        {
            InitializeComponent();
            _inmetro = inmetro;
        }

        private void FrmModificaInmetro_Load(object sender, EventArgs e)
        {
            bsModificaInmetro.DataSource = _inmetro;
            InicializarDateTimePickersComCheckbox();
            CarregarDateTimePickers(_inmetro);
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
        }
        private void CarregarDateTimePickers(Inmetro p)
        {
            // Mapeamento de cada DTP ao par (data, flag)
            var mapeamento = new Dictionary<DateTimePicker, (DateTime? data, bool has)>()
            {
                { DTPdataderegistrolilpco,    (p.DataRegistroLPCO,      p.CheckDataRegistroLPCO) },
                { DTPdatadedeferimentolilpco, (p.DataDeferimentoLPCO,   p.CheckDataDeferimentoLPCO) },
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
            _inmetro.Importador = TXTimportador.Text;
            _inmetro.Ref_USA = TXTnr.Text;
            _inmetro.SR = TXTsr.Text;
            _inmetro.Navio = TXTnavio.Text;
            _inmetro.Exportador = TXTexportador.Text;
            _inmetro.Produto = TXTProduto.Text;
            _inmetro.Origem = TXTorigem.Text;
            _inmetro.LI = TXTli.Text;
            _inmetro.NCM = TXTncm.Text;

            _inmetro.LPCO = TXTlilpco.Text;
            _inmetro.ParametrizacaoLPCO = CBparametrizacaolilpco.Text;

            _inmetro.StatusDoProcesso = TXTstatusdoprocesso.Text;
            _inmetro.Pendencia = TXTpendencia.Text;
            _inmetro.Amostra = CBamostra.Checked;

            // Registro LPCO
            if (DTPdataderegistrolilpco.Checked)
            {
                _inmetro.DataRegistroLPCO = DTPdataderegistrolilpco.Value;
                _inmetro.CheckDataRegistroLPCO = true;
            }
            else
            {
                _inmetro.DataRegistroLPCO = default; // ou DateTime.MinValue
                _inmetro.CheckDataRegistroLPCO = false;
            }
            // Deferimento LPCO
            if (DTPdatadedeferimentolilpco.Checked)
            {
                _inmetro.DataDeferimentoLPCO = DTPdatadedeferimentolilpco.Value;
                _inmetro.CheckDataDeferimentoLPCO = true;
            }
            else
            {
                _inmetro.DataDeferimentoLPCO = default;
                _inmetro.CheckDataDeferimentoLPCO = false;
            }
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

            this.DialogResult = DialogResult.OK;
        }

        private void CbEmbarque_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
