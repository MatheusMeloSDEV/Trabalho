using CLUSA;

namespace Trabalho
{
    public partial class FrmModificaMapa : Form
    {
        public MAPA mapa;

        public FrmModificaMapa()
        {
            InitializeComponent();
            mapa = new();
        }

        public void FrmModifica_Load(object sender, EventArgs e)
        {
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            BsModificaMAPA.DataSource = mapa;
            InicializarDateTimePickersComCheckbox();
            CarregarDateTimePickers(mapa);
        }
        private DateTime? GetDateIfChecked(DateTimePicker dtp)
            => dtp.Checked ? (DateTime?)dtp.Value : null;
        private void CarregarDateTimePickers(MAPA p)
        {
            // Mapeamento de cada DTP ao par (data, flag)
            var mapeamento = new Dictionary<DateTimePicker, (DateTime? data, bool has)>()
            {
                { DTPdataderegistrolilpco,    (p.DataRegistroLPCO,      p.CheckDataRegistroLPCO) },
                { DTPdatadedeferimentolilpco, (p.DataDeferimentoLPCO,   p.CheckDataDeferimentoLPCO) },
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
            mapa.LI = TXTli.Text;
            mapa.NCM = TXTncm.Text;
            mapa.LPCO = TXTlilpco.Text;
            mapa.ParametrizacaoLPCO = CBparametrizacaolilpco.Text;
            mapa.StatusDoProcesso = TXTstatusdoprocesso.Text;
            mapa.Pendencia = TXTpendencia.Text;
            mapa.Amostra = CBamostra.Checked;

            // Registro LPCO
            if (DTPdataderegistrolilpco.Checked)
            {
                mapa.DataRegistroLPCO = DTPdataderegistrolilpco.Value;
                mapa.CheckDataRegistroLPCO = true;
            }
            else
            {
                mapa.DataRegistroLPCO = default; // ou DateTime.MinValue
                mapa.CheckDataRegistroLPCO = false;
            }
            // Deferimento LPCO
            if (DTPdatadedeferimentolilpco.Checked)
            {
                mapa.DataDeferimentoLPCO = DTPdatadedeferimentolilpco.Value;
                mapa.CheckDataDeferimentoLPCO = true;
            }
            else
            {
                mapa.DataDeferimentoLPCO = default;
                mapa.CheckDataDeferimentoLPCO = false;
            }
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



            this.DialogResult = DialogResult.OK;
        }

        private void CbEmbarque_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbInspecao_CheckedChanged(object sender, EventArgs e)
        {
        }
    }
}
