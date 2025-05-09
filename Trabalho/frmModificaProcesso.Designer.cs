namespace Trabalho
{
    partial class FrmModificaProcesso
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            bsModificaProcesso = new BindingSource(components);
            groupBox3 = new GroupBox();
            label22 = new Label();
            label20 = new Label();
            CBparametrizacaolilpco = new ComboBox();
            DTPdatadedeferimentolilpco = new DateTimePicker();
            label18 = new Label();
            DTPdataderegistrolilpco = new DateTimePicker();
            TXTlilpco = new TextBox();
            label26 = new Label();
            groupBox2 = new GroupBox();
            label19 = new Label();
            label1 = new Label();
            DTPdatadedesembaracodi = new DateTimePicker();
            DTPdataderegistrodi = new DateTimePicker();
            LBLinspecao = new Label();
            TXTdi = new TextBox();
            label21 = new Label();
            label23 = new Label();
            DTPdatadeinspecao = new DateTimePicker();
            label6 = new Label();
            CBparametrizacaodi = new ComboBox();
            DTPdatadecarregamentodi = new DateTimePicker();
            CBamostra = new CheckBox();
            CBdesovado = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            button1 = new Button();
            groupBox1 = new GroupBox();
            CBmapa = new CheckBox();
            CBimetro = new CheckBox();
            CBanvisa = new CheckBox();
            CBibama = new CheckBox();
            CBdecex = new CheckBox();
            btnAdiciona = new Button();
            NUMfreetime = new NumericUpDown();
            label17 = new Label();
            TXTimportador = new TextBox();
            label14 = new Label();
            TXTportodedestino = new TextBox();
            label15 = new Label();
            label12 = new Label();
            label11 = new Label();
            label9 = new Label();
            TXTsr = new TextBox();
            TXTnr = new TextBox();
            label5 = new Label();
            TXTbl = new TextBox();
            TXTagentedecarga = new TextBox();
            label7 = new Label();
            TXTProduto = new TextBox();
            label3 = new Label();
            TXTordem = new TextBox();
            label2 = new Label();
            TXTflo = new TextBox();
            Exportador = new Label();
            TXTexportador = new TextBox();
            LBLdatadeatracacao = new Label();
            LBLdatadeembarque = new Label();
            DTPdatadeatracacao = new DateTimePicker();
            DTPdatadeembarque = new DateTimePicker();
            label10 = new Label();
            TXTstatusdoprocesso = new TextBox();
            label8 = new Label();
            TXTpendencia = new TextBox();
            label4 = new Label();
            TXTli = new TextBox();
            label13 = new Label();
            TXTnavio = new TextBox();
            checkedListBox1 = new CheckedListBox();
            label16 = new Label();
            checkedListBox2 = new CheckedListBox();
            label24 = new Label();
            label25 = new Label();
            DTPDataRecOriginais = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)bsModificaProcesso).BeginInit();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NUMfreetime).BeginInit();
            SuspendLayout();
            // 
            // bsModificaProcesso
            // 
            bsModificaProcesso.DataSource = typeof(CLUSA.Processo);
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label22);
            groupBox3.Controls.Add(label20);
            groupBox3.Controls.Add(CBparametrizacaolilpco);
            groupBox3.Controls.Add(DTPdatadedeferimentolilpco);
            groupBox3.Controls.Add(label18);
            groupBox3.Controls.Add(DTPdataderegistrolilpco);
            groupBox3.Controls.Add(TXTlilpco);
            groupBox3.Controls.Add(label26);
            groupBox3.Location = new Point(36, 246);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(365, 171);
            groupBox3.TabIndex = 13;
            groupBox3.TabStop = false;
            groupBox3.Text = "LPCO";
            // 
            // label22
            // 
            label22.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI", 11F);
            label22.Location = new Point(37, 94);
            label22.Name = "label22";
            label22.Size = new Size(111, 20);
            label22.TabIndex = 150;
            label22.Text = "Parametrização";
            // 
            // label20
            // 
            label20.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 11F);
            label20.Location = new Point(188, 95);
            label20.Name = "label20";
            label20.Size = new Size(150, 20);
            label20.TabIndex = 149;
            label20.Text = "Data de Deferimento";
            // 
            // CBparametrizacaolilpco
            // 
            CBparametrizacaolilpco.AutoCompleteMode = AutoCompleteMode.Suggest;
            CBparametrizacaolilpco.DataBindings.Add(new Binding("Text", bsModificaProcesso, "ParametrizacaoLPCO", true));
            CBparametrizacaolilpco.DataBindings.Add(new Binding("SelectedItem", bsModificaProcesso, "ParametrizacaoLPCO", true));
            CBparametrizacaolilpco.DataBindings.Add(new Binding("SelectedValue", bsModificaProcesso, "ParametrizacaoLPCO", true));
            CBparametrizacaolilpco.FormattingEnabled = true;
            CBparametrizacaolilpco.Items.AddRange(new object[] { "Documental", "Conferência Física", "Exame Físico", "Coleta de Amostra" });
            CBparametrizacaolilpco.Location = new Point(28, 117);
            CBparametrizacaolilpco.Name = "CBparametrizacaolilpco";
            CBparametrizacaolilpco.Size = new Size(128, 23);
            CBparametrizacaolilpco.TabIndex = 148;
            // 
            // DTPdatadedeferimentolilpco
            // 
            DTPdatadedeferimentolilpco.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            DTPdatadedeferimentolilpco.Format = DateTimePickerFormat.Short;
            DTPdatadedeferimentolilpco.Location = new Point(182, 118);
            DTPdatadedeferimentolilpco.MinDate = new DateTime(2024, 10, 17, 0, 0, 0, 0);
            DTPdatadedeferimentolilpco.Name = "DTPdatadedeferimentolilpco";
            DTPdatadedeferimentolilpco.Size = new Size(163, 23);
            DTPdatadedeferimentolilpco.TabIndex = 147;
            DTPdatadedeferimentolilpco.Value = new DateTime(2024, 10, 17, 0, 0, 0, 0);
            DTPdatadedeferimentolilpco.ValueChanged += DateTimePicker_OnValueChanged;
            // 
            // label18
            // 
            label18.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 11F);
            label18.Location = new Point(204, 29);
            label18.Name = "label18";
            label18.Size = new Size(121, 20);
            label18.TabIndex = 145;
            label18.Text = "Data de Registro";
            // 
            // DTPdataderegistrolilpco
            // 
            DTPdataderegistrolilpco.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            DTPdataderegistrolilpco.Format = DateTimePickerFormat.Short;
            DTPdataderegistrolilpco.Location = new Point(183, 52);
            DTPdataderegistrolilpco.MinDate = new DateTime(2024, 10, 17, 0, 0, 0, 0);
            DTPdataderegistrolilpco.Name = "DTPdataderegistrolilpco";
            DTPdataderegistrolilpco.Size = new Size(163, 23);
            DTPdataderegistrolilpco.TabIndex = 14;
            DTPdataderegistrolilpco.Value = new DateTime(2024, 10, 17, 0, 0, 0, 0);
            DTPdataderegistrolilpco.ValueChanged += DateTimePicker_OnValueChanged;
            // 
            // TXTlilpco
            // 
            TXTlilpco.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TXTlilpco.Cursor = Cursors.IBeam;
            TXTlilpco.DataBindings.Add(new Binding("Text", bsModificaProcesso, "LPCO", true));
            TXTlilpco.Location = new Point(28, 52);
            TXTlilpco.Name = "TXTlilpco";
            TXTlilpco.Size = new Size(128, 23);
            TXTlilpco.TabIndex = 13;
            // 
            // label26
            // 
            label26.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label26.AutoSize = true;
            label26.Font = new Font("Segoe UI", 12F);
            label26.Location = new Point(78, 28);
            label26.Name = "label26";
            label26.Size = new Size(28, 21);
            label26.TabIndex = 85;
            label26.Text = "N°";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label19);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(DTPdatadedesembaracodi);
            groupBox2.Controls.Add(DTPdataderegistrodi);
            groupBox2.Controls.Add(LBLinspecao);
            groupBox2.Controls.Add(TXTdi);
            groupBox2.Controls.Add(label21);
            groupBox2.Controls.Add(label23);
            groupBox2.Controls.Add(DTPdatadeinspecao);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(CBparametrizacaodi);
            groupBox2.Controls.Add(DTPdatadecarregamentodi);
            groupBox2.Location = new Point(425, 246);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(489, 171);
            groupBox2.TabIndex = 17;
            groupBox2.TabStop = false;
            groupBox2.Text = "DI";
            // 
            // label19
            // 
            label19.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 11F);
            label19.Location = new Point(318, 95);
            label19.Name = "label19";
            label19.Size = new Size(158, 20);
            label19.TabIndex = 152;
            label19.Text = "Data de Desembaraço";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(179, 95);
            label1.Name = "label1";
            label1.Size = new Size(121, 20);
            label1.TabIndex = 153;
            label1.Text = "Data de Registro";
            // 
            // DTPdatadedesembaracodi
            // 
            DTPdatadedesembaracodi.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            DTPdatadedesembaracodi.Format = DateTimePickerFormat.Short;
            DTPdatadedesembaracodi.Location = new Point(330, 117);
            DTPdatadedesembaracodi.MinDate = new DateTime(2024, 10, 17, 0, 0, 0, 0);
            DTPdatadedesembaracodi.Name = "DTPdatadedesembaracodi";
            DTPdatadedesembaracodi.Size = new Size(135, 23);
            DTPdatadedesembaracodi.TabIndex = 150;
            DTPdatadedesembaracodi.Value = new DateTime(2024, 10, 17, 0, 0, 0, 0);
            DTPdatadedesembaracodi.ValueChanged += DateTimePicker_OnValueChanged;
            // 
            // DTPdataderegistrodi
            // 
            DTPdataderegistrodi.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            DTPdataderegistrodi.Format = DateTimePickerFormat.Short;
            DTPdataderegistrodi.Location = new Point(168, 117);
            DTPdataderegistrodi.MinDate = new DateTime(2024, 10, 17, 0, 0, 0, 0);
            DTPdataderegistrodi.Name = "DTPdataderegistrodi";
            DTPdataderegistrodi.Size = new Size(142, 23);
            DTPdataderegistrodi.TabIndex = 149;
            DTPdataderegistrodi.Value = new DateTime(2024, 10, 17, 0, 0, 0, 0);
            DTPdataderegistrodi.ValueChanged += DateTimePicker_OnValueChanged;
            // 
            // LBLinspecao
            // 
            LBLinspecao.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            LBLinspecao.AutoSize = true;
            LBLinspecao.Font = new Font("Segoe UI", 11F);
            LBLinspecao.Location = new Point(363, 28);
            LBLinspecao.Name = "LBLinspecao";
            LBLinspecao.Size = new Size(68, 20);
            LBLinspecao.TabIndex = 302;
            LBLinspecao.Text = "Inspeção";
            // 
            // TXTdi
            // 
            TXTdi.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TXTdi.Cursor = Cursors.IBeam;
            TXTdi.DataBindings.Add(new Binding("Text", bsModificaProcesso, "DI", true));
            TXTdi.Location = new Point(17, 52);
            TXTdi.Name = "TXTdi";
            TXTdi.Size = new Size(134, 23);
            TXTdi.TabIndex = 148;
            // 
            // label21
            // 
            label21.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 12F);
            label21.Location = new Point(70, 28);
            label21.Name = "label21";
            label21.Size = new Size(28, 21);
            label21.TabIndex = 151;
            label21.Text = "N°";
            // 
            // label23
            // 
            label23.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI", 11F);
            label23.Location = new Point(29, 94);
            label23.Name = "label23";
            label23.Size = new Size(111, 20);
            label23.TabIndex = 147;
            label23.Text = "Parametrização";
            // 
            // DTPdatadeinspecao
            // 
            DTPdatadeinspecao.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            DTPdatadeinspecao.Format = DateTimePickerFormat.Short;
            DTPdatadeinspecao.Location = new Point(330, 52);
            DTPdatadeinspecao.MinDate = new DateTime(2023, 8, 22, 0, 0, 0, 0);
            DTPdatadeinspecao.Name = "DTPdatadeinspecao";
            DTPdatadeinspecao.Size = new Size(135, 23);
            DTPdatadeinspecao.TabIndex = 23;
            DTPdatadeinspecao.Value = new DateTime(2023, 8, 22, 0, 0, 0, 0);
            DTPdatadeinspecao.ValueChanged += DateTimePicker_OnValueChanged;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F);
            label6.Location = new Point(159, 29);
            label6.Name = "label6";
            label6.Size = new Size(161, 20);
            label6.TabIndex = 144;
            label6.Text = "Data de Carregamento";
            // 
            // CBparametrizacaodi
            // 
            CBparametrizacaodi.AutoCompleteMode = AutoCompleteMode.Suggest;
            CBparametrizacaodi.DataBindings.Add(new Binding("Text", bsModificaProcesso, "ParametrizacaoDI", true));
            CBparametrizacaodi.DataBindings.Add(new Binding("SelectedItem", bsModificaProcesso, "ParametrizacaoDI", true));
            CBparametrizacaodi.DataBindings.Add(new Binding("SelectedValue", bsModificaProcesso, "ParametrizacaoDI", true));
            CBparametrizacaodi.FormattingEnabled = true;
            CBparametrizacaodi.Items.AddRange(new object[] { "Verde", "Amarelo", "Vermelho" });
            CBparametrizacaodi.Location = new Point(17, 117);
            CBparametrizacaodi.Name = "CBparametrizacaodi";
            CBparametrizacaodi.Size = new Size(134, 23);
            CBparametrizacaodi.TabIndex = 21;
            // 
            // DTPdatadecarregamentodi
            // 
            DTPdatadecarregamentodi.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            DTPdatadecarregamentodi.Format = DateTimePickerFormat.Short;
            DTPdatadecarregamentodi.Location = new Point(168, 52);
            DTPdatadecarregamentodi.MinDate = new DateTime(2024, 10, 17, 0, 0, 0, 0);
            DTPdatadecarregamentodi.Name = "DTPdatadecarregamentodi";
            DTPdatadecarregamentodi.Size = new Size(142, 23);
            DTPdatadecarregamentodi.TabIndex = 20;
            DTPdatadecarregamentodi.Value = new DateTime(2024, 10, 17, 0, 0, 0, 0);
            DTPdatadecarregamentodi.ValueChanged += DateTimePicker_OnValueChanged;
            // 
            // CBamostra
            // 
            CBamostra.AutoSize = true;
            CBamostra.DataBindings.Add(new Binding("Checked", bsModificaProcesso, "Amostra", true));
            CBamostra.Font = new Font("Segoe UI", 12F);
            CBamostra.Location = new Point(442, 769);
            CBamostra.Name = "CBamostra";
            CBamostra.Size = new Size(88, 25);
            CBamostra.TabIndex = 133;
            CBamostra.Text = "Amostra";
            CBamostra.UseVisualStyleBackColor = true;
            // 
            // CBdesovado
            // 
            CBdesovado.AutoSize = true;
            CBdesovado.DataBindings.Add(new Binding("Checked", bsModificaProcesso, "Desovado", true));
            CBdesovado.Font = new Font("Segoe UI", 12F);
            CBdesovado.Location = new Point(536, 769);
            CBdesovado.Name = "CBdesovado";
            CBdesovado.Size = new Size(98, 25);
            CBdesovado.TabIndex = 100;
            CBdesovado.Text = "Desovado";
            CBdesovado.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Font = new Font("Segoe UI", 12F);
            checkBox2.Location = new Point(536, 776);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(88, 25);
            checkBox2.TabIndex = 134;
            checkBox2.Text = "Amostra";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 12F);
            checkBox1.Location = new Point(536, 776);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(98, 25);
            checkBox1.TabIndex = 99;
            checkBox1.Text = "Desovado";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.Cursor = Cursors.Hand;
            button1.Location = new Point(704, 760);
            button1.Name = "button1";
            button1.Size = new Size(112, 32);
            button1.TabIndex = 27;
            button1.Text = "Cancelar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnCancelar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(CBmapa);
            groupBox1.Controls.Add(CBimetro);
            groupBox1.Controls.Add(CBanvisa);
            groupBox1.Controls.Add(CBibama);
            groupBox1.Controls.Add(CBdecex);
            groupBox1.Location = new Point(29, 743);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(358, 75);
            groupBox1.TabIndex = 128;
            groupBox1.TabStop = false;
            groupBox1.Text = "Orgãos Anuentes";
            // 
            // CBmapa
            // 
            CBmapa.AutoSize = true;
            CBmapa.DataBindings.Add(new Binding("Checked", bsModificaProcesso, "TMapa", true));
            CBmapa.Location = new Point(27, 32);
            CBmapa.Name = "CBmapa";
            CBmapa.Size = new Size(56, 19);
            CBmapa.TabIndex = 30;
            CBmapa.Text = "Mapa";
            CBmapa.UseVisualStyleBackColor = true;
            CBmapa.CheckedChanged += CBmapa_CheckedChanged;
            // 
            // CBimetro
            // 
            CBimetro.AutoSize = true;
            CBimetro.DataBindings.Add(new Binding("Checked", bsModificaProcesso, "TImetro", true));
            CBimetro.Location = new Point(283, 32);
            CBimetro.Name = "CBimetro";
            CBimetro.Size = new Size(61, 19);
            CBimetro.TabIndex = 34;
            CBimetro.Text = "Imetro";
            CBimetro.UseVisualStyleBackColor = true;
            // 
            // CBanvisa
            // 
            CBanvisa.AutoSize = true;
            CBanvisa.DataBindings.Add(new Binding("Checked", bsModificaProcesso, "TAnvisa", true));
            CBanvisa.Location = new Point(89, 32);
            CBanvisa.Name = "CBanvisa";
            CBanvisa.Size = new Size(61, 19);
            CBanvisa.TabIndex = 31;
            CBanvisa.Text = "Anvisa";
            CBanvisa.UseVisualStyleBackColor = true;
            // 
            // CBibama
            // 
            CBibama.AutoSize = true;
            CBibama.DataBindings.Add(new Binding("Checked", bsModificaProcesso, "TIbama", true));
            CBibama.Location = new Point(220, 32);
            CBibama.Name = "CBibama";
            CBibama.Size = new Size(59, 19);
            CBibama.TabIndex = 33;
            CBibama.Text = "Ibama";
            CBibama.UseVisualStyleBackColor = true;
            // 
            // CBdecex
            // 
            CBdecex.AutoSize = true;
            CBdecex.DataBindings.Add(new Binding("Checked", bsModificaProcesso, "TDecex", true));
            CBdecex.Location = new Point(156, 32);
            CBdecex.Name = "CBdecex";
            CBdecex.Size = new Size(57, 19);
            CBdecex.TabIndex = 32;
            CBdecex.Text = "Decex";
            CBdecex.UseVisualStyleBackColor = true;
            // 
            // btnAdiciona
            // 
            btnAdiciona.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAdiciona.Cursor = Cursors.Hand;
            btnAdiciona.Location = new Point(822, 760);
            btnAdiciona.Name = "btnAdiciona";
            btnAdiciona.Size = new Size(112, 32);
            btnAdiciona.TabIndex = 28;
            btnAdiciona.Text = "Ok";
            btnAdiciona.UseVisualStyleBackColor = true;
            btnAdiciona.Click += btnAdiciona_Click;
            // 
            // NUMfreetime
            // 
            NUMfreetime.DataBindings.Add(new Binding("Value", bsModificaProcesso, "FreeTime", true));
            NUMfreetime.Location = new Point(743, 156);
            NUMfreetime.Name = "NUMfreetime";
            NUMfreetime.Size = new Size(166, 23);
            NUMfreetime.TabIndex = 9;
            // 
            // label17
            // 
            label17.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 12F);
            label17.Location = new Point(228, 78);
            label17.Name = "label17";
            label17.Size = new Size(89, 21);
            label17.TabIndex = 287;
            label17.Text = "Importador";
            // 
            // TXTimportador
            // 
            TXTimportador.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TXTimportador.Cursor = Cursors.IBeam;
            TXTimportador.DataBindings.Add(new Binding("Text", bsModificaProcesso, "Importador", true));
            TXTimportador.Location = new Point(323, 76);
            TXTimportador.Name = "TXTimportador";
            TXTimportador.Size = new Size(155, 23);
            TXTimportador.TabIndex = 3;
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12F);
            label14.Location = new Point(664, 120);
            label14.Name = "label14";
            label14.Size = new Size(125, 21);
            label14.TabIndex = 285;
            label14.Text = "Porto de Destino";
            // 
            // TXTportodedestino
            // 
            TXTportodedestino.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TXTportodedestino.Cursor = Cursors.IBeam;
            TXTportodedestino.DataBindings.Add(new Binding("Text", bsModificaProcesso, "PortoDestino", true));
            TXTportodedestino.Location = new Point(795, 118);
            TXTportodedestino.Name = "TXTportodedestino";
            TXTportodedestino.Size = new Size(119, 23);
            TXTportodedestino.TabIndex = 7;
            // 
            // label15
            // 
            label15.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 12F);
            label15.Location = new Point(664, 158);
            label15.Name = "label15";
            label15.Size = new Size(78, 21);
            label15.TabIndex = 283;
            label15.Text = "Free Time";
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F);
            label12.Location = new Point(353, 195);
            label12.Name = "label12";
            label12.Size = new Size(125, 21);
            label12.TabIndex = 282;
            label12.Text = "Agente de Carga";
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F);
            label11.Location = new Point(504, 37);
            label11.Name = "label11";
            label11.Size = new Size(49, 21);
            label11.TabIndex = 281;
            label11.Text = "S. Ref";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F);
            label9.Location = new Point(286, 37);
            label9.Name = "label9";
            label9.Size = new Size(66, 21);
            label9.TabIndex = 280;
            label9.Text = "Ref. Usa";
            // 
            // TXTsr
            // 
            TXTsr.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TXTsr.Cursor = Cursors.IBeam;
            TXTsr.DataBindings.Add(new Binding("Text", bsModificaProcesso, "SR", true));
            TXTsr.Location = new Point(559, 35);
            TXTsr.Name = "TXTsr";
            TXTsr.Size = new Size(118, 23);
            TXTsr.TabIndex = 2;
            // 
            // TXTnr
            // 
            TXTnr.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TXTnr.Cursor = Cursors.IBeam;
            TXTnr.DataBindings.Add(new Binding("Text", bsModificaProcesso, "Ref_USA", true));
            TXTnr.Location = new Point(358, 35);
            TXTnr.Name = "TXTnr";
            TXTnr.Size = new Size(99, 23);
            TXTnr.TabIndex = 1;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(48, 199);
            label5.Name = "label5";
            label5.Size = new Size(27, 21);
            label5.TabIndex = 277;
            label5.Text = "BL";
            // 
            // TXTbl
            // 
            TXTbl.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TXTbl.Cursor = Cursors.IBeam;
            TXTbl.DataBindings.Add(new Binding("Text", bsModificaProcesso, "BL", true));
            TXTbl.Location = new Point(81, 197);
            TXTbl.Name = "TXTbl";
            TXTbl.Size = new Size(199, 23);
            TXTbl.TabIndex = 10;
            // 
            // TXTagentedecarga
            // 
            TXTagentedecarga.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TXTagentedecarga.Cursor = Cursors.IBeam;
            TXTagentedecarga.DataBindings.Add(new Binding("Text", bsModificaProcesso, "AgenteDeCarga", true));
            TXTagentedecarga.Location = new Point(484, 193);
            TXTagentedecarga.Name = "TXTagentedecarga";
            TXTagentedecarga.Size = new Size(119, 23);
            TXTagentedecarga.TabIndex = 11;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(353, 120);
            label7.Name = "label7";
            label7.Size = new Size(66, 21);
            label7.TabIndex = 274;
            label7.Text = "Produto";
            // 
            // TXTProduto
            // 
            TXTProduto.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TXTProduto.Cursor = Cursors.IBeam;
            TXTProduto.DataBindings.Add(new Binding("Text", bsModificaProcesso, "Produto", true));
            TXTProduto.Location = new Point(425, 118);
            TXTProduto.Name = "TXTProduto";
            TXTProduto.Size = new Size(178, 23);
            TXTProduto.TabIndex = 6;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(48, 158);
            label3.Name = "label3";
            label3.Size = new Size(59, 21);
            label3.TabIndex = 272;
            label3.Text = "Ordem";
            // 
            // TXTordem
            // 
            TXTordem.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TXTordem.Cursor = Cursors.IBeam;
            TXTordem.DataBindings.Add(new Binding("Text", bsModificaProcesso, "Ordem", true));
            TXTordem.Location = new Point(123, 156);
            TXTordem.Name = "TXTordem";
            TXTordem.Size = new Size(157, 23);
            TXTordem.TabIndex = 8;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(353, 158);
            label2.Name = "label2";
            label2.Size = new Size(37, 21);
            label2.TabIndex = 270;
            label2.Text = "FLO";
            // 
            // TXTflo
            // 
            TXTflo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TXTflo.Cursor = Cursors.IBeam;
            TXTflo.DataBindings.Add(new Binding("Text", bsModificaProcesso, "FLO", true));
            TXTflo.Location = new Point(396, 156);
            TXTflo.Name = "TXTflo";
            TXTflo.Size = new Size(207, 23);
            TXTflo.TabIndex = 9;
            // 
            // Exportador
            // 
            Exportador.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Exportador.AutoSize = true;
            Exportador.Font = new Font("Segoe UI", 12F);
            Exportador.Location = new Point(48, 120);
            Exportador.Name = "Exportador";
            Exportador.Size = new Size(86, 21);
            Exportador.TabIndex = 268;
            Exportador.Text = "Exportador";
            // 
            // TXTexportador
            // 
            TXTexportador.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TXTexportador.Cursor = Cursors.IBeam;
            TXTexportador.DataBindings.Add(new Binding("Text", bsModificaProcesso, "Exportador", true));
            TXTexportador.Location = new Point(143, 118);
            TXTexportador.Name = "TXTexportador";
            TXTexportador.Size = new Size(137, 23);
            TXTexportador.TabIndex = 5;
            // 
            // LBLdatadeatracacao
            // 
            LBLdatadeatracacao.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            LBLdatadeatracacao.AutoSize = true;
            LBLdatadeatracacao.Font = new Font("Segoe UI", 10F);
            LBLdatadeatracacao.Location = new Point(532, 498);
            LBLdatadeatracacao.Name = "LBLdatadeatracacao";
            LBLdatadeatracacao.Size = new Size(121, 19);
            LBLdatadeatracacao.TabIndex = 301;
            LBLdatadeatracacao.Text = "Data de Atracação";
            // 
            // LBLdatadeembarque
            // 
            LBLdatadeembarque.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            LBLdatadeembarque.AutoSize = true;
            LBLdatadeembarque.Font = new Font("Segoe UI", 10F);
            LBLdatadeembarque.Location = new Point(532, 546);
            LBLdatadeembarque.Name = "LBLdatadeembarque";
            LBLdatadeembarque.Size = new Size(123, 19);
            LBLdatadeembarque.TabIndex = 300;
            LBLdatadeembarque.Text = "Data de Embarque";
            // 
            // DTPdatadeatracacao
            // 
            DTPdatadeatracacao.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            DTPdatadeatracacao.Format = DateTimePickerFormat.Short;
            DTPdatadeatracacao.Location = new Point(524, 520);
            DTPdatadeatracacao.MinDate = new DateTime(2023, 8, 22, 0, 0, 0, 0);
            DTPdatadeatracacao.Name = "DTPdatadeatracacao";
            DTPdatadeatracacao.Size = new Size(135, 23);
            DTPdatadeatracacao.TabIndex = 22;
            DTPdatadeatracacao.Value = new DateTime(2023, 8, 22, 0, 0, 0, 0);
            DTPdatadeatracacao.ValueChanged += DateTimePicker_OnValueChanged;
            // 
            // DTPdatadeembarque
            // 
            DTPdatadeembarque.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            DTPdatadeembarque.Format = DateTimePickerFormat.Short;
            DTPdatadeembarque.Location = new Point(525, 568);
            DTPdatadeembarque.MinDate = new DateTime(2023, 8, 22, 0, 0, 0, 0);
            DTPdatadeembarque.Name = "DTPdatadeembarque";
            DTPdatadeembarque.Size = new Size(135, 23);
            DTPdatadeembarque.TabIndex = 24;
            DTPdatadeembarque.Value = new DateTime(2023, 8, 22, 0, 0, 0, 0);
            DTPdatadeembarque.ValueChanged += DateTimePicker_OnValueChanged;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Underline);
            label10.Location = new Point(55, 434);
            label10.Name = "label10";
            label10.Size = new Size(140, 21);
            label10.TabIndex = 292;
            label10.Text = "Status do Processo";
            // 
            // TXTstatusdoprocesso
            // 
            TXTstatusdoprocesso.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TXTstatusdoprocesso.DataBindings.Add(new Binding("Text", bsModificaProcesso, "StatusDoProcesso", true));
            TXTstatusdoprocesso.Location = new Point(69, 472);
            TXTstatusdoprocesso.Multiline = true;
            TXTstatusdoprocesso.Name = "TXTstatusdoprocesso";
            TXTstatusdoprocesso.Size = new Size(430, 195);
            TXTstatusdoprocesso.TabIndex = 25;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(116, 702);
            label8.Name = "label8";
            label8.Size = new Size(80, 21);
            label8.TabIndex = 290;
            label8.Text = "Pendência";
            // 
            // TXTpendencia
            // 
            TXTpendencia.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TXTpendencia.DataBindings.Add(new Binding("Text", bsModificaProcesso, "Pendencia", true));
            TXTpendencia.Location = new Point(199, 700);
            TXTpendencia.Name = "TXTpendencia";
            TXTpendencia.Size = new Size(671, 23);
            TXTpendencia.TabIndex = 26;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(664, 195);
            label4.Name = "label4";
            label4.Size = new Size(22, 21);
            label4.TabIndex = 304;
            label4.Text = "LI";
            // 
            // TXTli
            // 
            TXTli.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TXTli.Cursor = Cursors.IBeam;
            TXTli.DataBindings.Add(new Binding("Text", bsModificaProcesso, "LI", true));
            TXTli.Location = new Point(692, 193);
            TXTli.Name = "TXTli";
            TXTli.Size = new Size(217, 23);
            TXTli.TabIndex = 12;
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F);
            label13.Location = new Point(522, 78);
            label13.Name = "label13";
            label13.Size = new Size(51, 21);
            label13.TabIndex = 306;
            label13.Text = "Navio";
            // 
            // TXTnavio
            // 
            TXTnavio.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TXTnavio.Cursor = Cursors.IBeam;
            TXTnavio.DataBindings.Add(new Binding("Text", bsModificaProcesso, "Navio", true));
            TXTnavio.Location = new Point(579, 76);
            TXTnavio.Name = "TXTnavio";
            TXTnavio.Size = new Size(155, 23);
            TXTnavio.TabIndex = 4;
            // 
            // checkedListBox1
            // 
            checkedListBox1.BorderStyle = BorderStyle.FixedSingle;
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "BL", "Fatura", "Packing List", "CO", "Fito", "CSI", "CA", "CF" });
            checkedListBox1.Location = new Point(692, 519);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(108, 110);
            checkedListBox1.TabIndex = 307;
            // 
            // label16
            // 
            label16.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 11F);
            label16.Location = new Point(689, 496);
            label16.Name = "label16";
            label16.Size = new Size(115, 20);
            label16.TabIndex = 308;
            label16.Text = "Docs Recebidos";
            // 
            // checkedListBox2
            // 
            checkedListBox2.BorderStyle = BorderStyle.FixedSingle;
            checkedListBox2.FormattingEnabled = true;
            checkedListBox2.Items.AddRange(new object[] { "DHL", "UPS", "Correio", "Fedex", "Daytona" });
            checkedListBox2.Location = new Point(827, 519);
            checkedListBox2.Name = "checkedListBox2";
            checkedListBox2.Size = new Size(79, 110);
            checkedListBox2.TabIndex = 309;
            checkedListBox2.ItemCheck += checkedListBox2_ItemCheck;
            // 
            // label24
            // 
            label24.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label24.AutoSize = true;
            label24.Font = new Font("Segoe UI", 11F);
            label24.Location = new Point(825, 496);
            label24.Name = "label24";
            label24.Size = new Size(82, 20);
            label24.TabIndex = 310;
            label24.Text = "Forma Rec.";
            // 
            // label25
            // 
            label25.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label25.AutoSize = true;
            label25.Font = new Font("Segoe UI", 10F);
            label25.Location = new Point(531, 594);
            label25.Name = "label25";
            label25.Size = new Size(124, 19);
            label25.TabIndex = 312;
            label25.Text = "Data Rec. Originais";
            // 
            // DTPDataRecOriginais
            // 
            DTPDataRecOriginais.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            DTPDataRecOriginais.Format = DateTimePickerFormat.Short;
            DTPDataRecOriginais.Location = new Point(524, 616);
            DTPDataRecOriginais.MinDate = new DateTime(2023, 8, 22, 0, 0, 0, 0);
            DTPDataRecOriginais.Name = "DTPDataRecOriginais";
            DTPDataRecOriginais.Size = new Size(135, 23);
            DTPDataRecOriginais.TabIndex = 311;
            DTPDataRecOriginais.Value = new DateTime(2023, 8, 22, 0, 0, 0, 0);
            DTPDataRecOriginais.ValueChanged += DateTimePicker_OnValueChanged;
            // 
            // FrmModificaProcesso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(962, 827);
            ControlBox = false;
            Controls.Add(label25);
            Controls.Add(DTPDataRecOriginais);
            Controls.Add(label24);
            Controls.Add(checkedListBox2);
            Controls.Add(label16);
            Controls.Add(checkedListBox1);
            Controls.Add(label13);
            Controls.Add(TXTnavio);
            Controls.Add(label4);
            Controls.Add(TXTli);
            Controls.Add(LBLdatadeatracacao);
            Controls.Add(LBLdatadeembarque);
            Controls.Add(DTPdatadeatracacao);
            Controls.Add(DTPdatadeembarque);
            Controls.Add(label10);
            Controls.Add(TXTstatusdoprocesso);
            Controls.Add(label8);
            Controls.Add(TXTpendencia);
            Controls.Add(NUMfreetime);
            Controls.Add(label17);
            Controls.Add(TXTimportador);
            Controls.Add(label14);
            Controls.Add(TXTportodedestino);
            Controls.Add(label15);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label9);
            Controls.Add(TXTsr);
            Controls.Add(TXTnr);
            Controls.Add(label5);
            Controls.Add(TXTbl);
            Controls.Add(TXTagentedecarga);
            Controls.Add(label7);
            Controls.Add(TXTProduto);
            Controls.Add(label3);
            Controls.Add(TXTordem);
            Controls.Add(label2);
            Controls.Add(TXTflo);
            Controls.Add(Exportador);
            Controls.Add(TXTexportador);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(CBamostra);
            Controls.Add(CBdesovado);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Controls.Add(btnAdiciona);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmModificaProcesso";
            Text = "frmModificaProcesso";
            Load += FrmModificaProcesso_Load;
            ((System.ComponentModel.ISupportInitialize)bsModificaProcesso).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NUMfreetime).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private BindingSource bsModificaProcesso;
        private GroupBox groupBox3;
        private DateTimePicker DTPdataderegistrolilpco;
        private TextBox TXTlilpco;
        private Label label26;
        private GroupBox groupBox2;
        private ComboBox CBparametrizacaodi;
        private DateTimePicker DTPdatadecarregamentodi;
        private CheckBox CBamostra;
        private CheckBox CBdesovado;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private Button button1;
        private GroupBox groupBox1;
        private CheckBox CBmapa;
        private CheckBox CBimetro;
        private CheckBox CBanvisa;
        private CheckBox CBibama;
        private CheckBox CBdecex;
        private Button btnAdiciona;
        private Label label6;
        private Label label18;
        private Label label23;
        private NumericUpDown NUMfreetime;
        private Label label17;
        private TextBox TXTimportador;
        private Label label14;
        private TextBox TXTportodedestino;
        private Label label15;
        private Label label12;
        private Label label11;
        private Label label9;
        private TextBox TXTsr;
        private TextBox TXTnr;
        private Label label5;
        private TextBox TXTbl;
        private TextBox TXTagentedecarga;
        private Label label7;
        private TextBox TXTProduto;
        private Label label3;
        private TextBox TXTordem;
        private Label label2;
        private TextBox TXTflo;
        private Label Exportador;
        private TextBox TXTexportador;
        private Label LBLinspecao;
        private Label LBLdatadeatracacao;
        private Label LBLdatadeembarque;
        private DateTimePicker DTPdatadeinspecao;
        private DateTimePicker DTPdatadeatracacao;
        private DateTimePicker DTPdatadeembarque;
        private Label label10;
        private TextBox TXTstatusdoprocesso;
        private Label label8;
        private TextBox TXTpendencia;
        private Label label4;
        private TextBox TXTli;
        private Label label13;
        private TextBox TXTnavio;
        private Label label22;
        private Label label20;
        private ComboBox CBparametrizacaolilpco;
        private DateTimePicker DTPdatadedeferimentolilpco;
        private Label label19;
        private Label label1;
        private DateTimePicker DTPdatadedesembaracodi;
        private DateTimePicker DTPdataderegistrodi;
        private TextBox TXTdi;
        private Label label21;
        private CheckedListBox checkedListBox1;
        private Label label16;
        private CheckedListBox checkedListBox2;
        private Label label24;
        private Label label25;
        private DateTimePicker DTPDataRecOriginais;
    }
}