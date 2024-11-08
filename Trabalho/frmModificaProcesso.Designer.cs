namespace Trabalho
{
    partial class frmModificaProcesso
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
            label18 = new Label();
            CBparametrizacaolilpco = new ComboBox();
            DTPdatadedeferimentolilpco = new DateTimePicker();
            DTPdataderegistrolilpco = new DateTimePicker();
            TXTlilpco = new TextBox();
            label26 = new Label();
            groupBox2 = new GroupBox();
            label23 = new Label();
            label6 = new Label();
            label19 = new Label();
            label1 = new Label();
            CBparametrizacaodi = new ComboBox();
            DTPdatadecarregamentodi = new DateTimePicker();
            DTPdatadedesembaracodi = new DateTimePicker();
            DTPdataderegistrodi = new DateTimePicker();
            TXTdi = new TextBox();
            label21 = new Label();
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
            LBLinspecao = new Label();
            LBLdatadeatracacao = new Label();
            LBLprevisao = new Label();
            LBLdatadeembarque = new Label();
            cbEmbarque = new CheckBox();
            DTPdatadeinspecao = new DateTimePicker();
            DTPdatadeatracacao = new DateTimePicker();
            DTPdatadeembarque = new DateTimePicker();
            DTPdatadeprevisao = new DateTimePicker();
            label10 = new Label();
            TXTstatusdoprocesso = new TextBox();
            label8 = new Label();
            TXTpendencia = new TextBox();
            lblPEmbarque = new Label();
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
            groupBox3.Controls.Add(label18);
            groupBox3.Controls.Add(CBparametrizacaolilpco);
            groupBox3.Controls.Add(DTPdatadedeferimentolilpco);
            groupBox3.Controls.Add(DTPdataderegistrolilpco);
            groupBox3.Controls.Add(TXTlilpco);
            groupBox3.Controls.Add(label26);
            groupBox3.Location = new Point(90, 203);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(750, 82);
            groupBox3.TabIndex = 143;
            groupBox3.TabStop = false;
            groupBox3.Text = "LI/LPCO";
            // 
            // label22
            // 
            label22.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label22.Location = new Point(585, 19);
            label22.Name = "label22";
            label22.Size = new Size(111, 20);
            label22.TabIndex = 146;
            label22.Text = "Parametrização";
            // 
            // label20
            // 
            label20.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label20.Location = new Point(394, 20);
            label20.Name = "label20";
            label20.Size = new Size(150, 20);
            label20.TabIndex = 145;
            label20.Text = "Data de Deferimento";
            // 
            // label18
            // 
            label18.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label18.Location = new Point(227, 20);
            label18.Name = "label18";
            label18.Size = new Size(121, 20);
            label18.TabIndex = 145;
            label18.Text = "Data de Registro";
            // 
            // CBparametrizacaolilpco
            // 
            CBparametrizacaolilpco.AutoCompleteMode = AutoCompleteMode.Suggest;
            CBparametrizacaolilpco.DataBindings.Add(new Binding("Text", bsModificaProcesso, "ParametrizacaoLILPCO", true));
            CBparametrizacaolilpco.DataBindings.Add(new Binding("SelectedItem", bsModificaProcesso, "ParametrizacaoLILPCO", true));
            CBparametrizacaolilpco.FormattingEnabled = true;
            CBparametrizacaolilpco.Items.AddRange(new object[] { "Verde", "Amarelo", "Vermelho" });
            CBparametrizacaolilpco.Location = new Point(576, 43);
            CBparametrizacaolilpco.Name = "CBparametrizacaolilpco";
            CBparametrizacaolilpco.Size = new Size(128, 23);
            CBparametrizacaolilpco.TabIndex = 101;
            // 
            // DTPdatadedeferimentolilpco
            // 
            DTPdatadedeferimentolilpco.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            DTPdatadedeferimentolilpco.DataBindings.Add(new Binding("Text", bsModificaProcesso, "DataDeferimentoLILPCO", true));
            DTPdatadedeferimentolilpco.DataBindings.Add(new Binding("Value", bsModificaProcesso, "DataDeferimentoLILPCO", true));
            DTPdatadedeferimentolilpco.Format = DateTimePickerFormat.Short;
            DTPdatadedeferimentolilpco.Location = new Point(388, 43);
            DTPdatadedeferimentolilpco.MinDate = new DateTime(2024, 10, 17, 0, 0, 0, 0);
            DTPdatadedeferimentolilpco.Name = "DTPdatadedeferimentolilpco";
            DTPdatadedeferimentolilpco.Size = new Size(163, 23);
            DTPdatadedeferimentolilpco.TabIndex = 103;
            DTPdatadedeferimentolilpco.Value = new DateTime(2024, 10, 17, 0, 0, 0, 0);
            // 
            // DTPdataderegistrolilpco
            // 
            DTPdataderegistrolilpco.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            DTPdataderegistrolilpco.DataBindings.Add(new Binding("Text", bsModificaProcesso, "DataRegistroLILPCO", true));
            DTPdataderegistrolilpco.DataBindings.Add(new Binding("Value", bsModificaProcesso, "DataRegistroLILPCO", true));
            DTPdataderegistrolilpco.Format = DateTimePickerFormat.Short;
            DTPdataderegistrolilpco.Location = new Point(206, 43);
            DTPdataderegistrolilpco.MinDate = new DateTime(2024, 10, 17, 0, 0, 0, 0);
            DTPdataderegistrolilpco.Name = "DTPdataderegistrolilpco";
            DTPdataderegistrolilpco.Size = new Size(163, 23);
            DTPdataderegistrolilpco.TabIndex = 100;
            DTPdataderegistrolilpco.Value = new DateTime(2024, 10, 17, 0, 0, 0, 0);
            // 
            // TXTlilpco
            // 
            TXTlilpco.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TXTlilpco.Cursor = Cursors.IBeam;
            TXTlilpco.DataBindings.Add(new Binding("Text", bsModificaProcesso, "LI_LPCO", true));
            TXTlilpco.Location = new Point(65, 32);
            TXTlilpco.Name = "TXTlilpco";
            TXTlilpco.Size = new Size(120, 23);
            TXTlilpco.TabIndex = 84;
            // 
            // label26
            // 
            label26.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label26.AutoSize = true;
            label26.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label26.Location = new Point(31, 34);
            label26.Name = "label26";
            label26.Size = new Size(28, 21);
            label26.TabIndex = 85;
            label26.Text = "N°";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label23);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label19);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(CBparametrizacaodi);
            groupBox2.Controls.Add(DTPdatadecarregamentodi);
            groupBox2.Controls.Add(DTPdatadedesembaracodi);
            groupBox2.Controls.Add(DTPdataderegistrodi);
            groupBox2.Controls.Add(TXTdi);
            groupBox2.Controls.Add(label21);
            groupBox2.Location = new Point(21, 291);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(891, 82);
            groupBox2.TabIndex = 142;
            groupBox2.TabStop = false;
            groupBox2.Text = "DI";
            // 
            // label23
            // 
            label23.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label23.Location = new Point(753, 24);
            label23.Name = "label23";
            label23.Size = new Size(111, 20);
            label23.TabIndex = 147;
            label23.Text = "Parametrização";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(560, 24);
            label6.Name = "label6";
            label6.Size = new Size(161, 20);
            label6.TabIndex = 144;
            label6.Text = "Data de Carregamento";
            // 
            // label19
            // 
            label19.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label19.Location = new Point(380, 24);
            label19.Name = "label19";
            label19.Size = new Size(158, 20);
            label19.TabIndex = 144;
            label19.Text = "Data de Desembaraço";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(219, 24);
            label1.Name = "label1";
            label1.Size = new Size(121, 20);
            label1.TabIndex = 144;
            label1.Text = "Data de Registro";
            // 
            // CBparametrizacaodi
            // 
            CBparametrizacaodi.AutoCompleteMode = AutoCompleteMode.Suggest;
            CBparametrizacaodi.DataBindings.Add(new Binding("Text", bsModificaProcesso, "ParametrizacaoDI", true));
            CBparametrizacaodi.DataBindings.Add(new Binding("SelectedItem", bsModificaProcesso, "ParametrizacaoDI", true));
            CBparametrizacaodi.FormattingEnabled = true;
            CBparametrizacaodi.Items.AddRange(new object[] { "Verde", "Amarelo", "Vermelho" });
            CBparametrizacaodi.Location = new Point(741, 47);
            CBparametrizacaodi.Name = "CBparametrizacaodi";
            CBparametrizacaodi.Size = new Size(134, 23);
            CBparametrizacaodi.TabIndex = 94;
            // 
            // DTPdatadecarregamentodi
            // 
            DTPdatadecarregamentodi.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            DTPdatadecarregamentodi.DataBindings.Add(new Binding("Text", bsModificaProcesso, "DataCarregamentoDI", true));
            DTPdatadecarregamentodi.DataBindings.Add(new Binding("Value", bsModificaProcesso, "DataCarregamentoDI", true));
            DTPdatadecarregamentodi.Format = DateTimePickerFormat.Short;
            DTPdatadecarregamentodi.Location = new Point(555, 47);
            DTPdatadecarregamentodi.MinDate = new DateTime(2024, 10, 17, 0, 0, 0, 0);
            DTPdatadecarregamentodi.Name = "DTPdatadecarregamentodi";
            DTPdatadecarregamentodi.Size = new Size(171, 23);
            DTPdatadecarregamentodi.TabIndex = 97;
            DTPdatadecarregamentodi.Value = new DateTime(2024, 10, 17, 0, 0, 0, 0);
            // 
            // DTPdatadedesembaracodi
            // 
            DTPdatadedesembaracodi.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            DTPdatadedesembaracodi.DataBindings.Add(new Binding("Text", bsModificaProcesso, "DataDesembaracoDI", true));
            DTPdatadedesembaracodi.DataBindings.Add(new Binding("Value", bsModificaProcesso, "DataDesembaracoDI", true));
            DTPdatadedesembaracodi.Format = DateTimePickerFormat.Short;
            DTPdatadedesembaracodi.Location = new Point(374, 47);
            DTPdatadedesembaracodi.MinDate = new DateTime(2024, 10, 17, 0, 0, 0, 0);
            DTPdatadedesembaracodi.Name = "DTPdatadedesembaracodi";
            DTPdatadedesembaracodi.Size = new Size(171, 23);
            DTPdatadedesembaracodi.TabIndex = 95;
            DTPdatadedesembaracodi.Value = new DateTime(2024, 10, 17, 0, 0, 0, 0);
            // 
            // DTPdataderegistrodi
            // 
            DTPdataderegistrodi.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            DTPdataderegistrodi.DataBindings.Add(new Binding("Text", bsModificaProcesso, "DataRegistroDI", true));
            DTPdataderegistrodi.DataBindings.Add(new Binding("Value", bsModificaProcesso, "DataRegistroDI", true));
            DTPdataderegistrodi.Format = DateTimePickerFormat.Short;
            DTPdataderegistrodi.Location = new Point(194, 47);
            DTPdataderegistrodi.MinDate = new DateTime(2024, 10, 17, 0, 0, 0, 0);
            DTPdataderegistrodi.Name = "DTPdataderegistrodi";
            DTPdataderegistrodi.Size = new Size(171, 23);
            DTPdataderegistrodi.TabIndex = 93;
            DTPdataderegistrodi.Value = new DateTime(2024, 10, 17, 0, 0, 0, 0);
            // 
            // TXTdi
            // 
            TXTdi.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TXTdi.Cursor = Cursors.IBeam;
            TXTdi.DataBindings.Add(new Binding("Text", bsModificaProcesso, "DI", true));
            TXTdi.Location = new Point(56, 33);
            TXTdi.Name = "TXTdi";
            TXTdi.Size = new Size(120, 23);
            TXTdi.TabIndex = 84;
            // 
            // label21
            // 
            label21.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label21.Location = new Point(22, 35);
            label21.Name = "label21";
            label21.Size = new Size(28, 21);
            label21.TabIndex = 85;
            label21.Text = "N°";
            // 
            // CBamostra
            // 
            CBamostra.AutoSize = true;
            CBamostra.DataBindings.Add(new Binding("Checked", bsModificaProcesso, "Amostra", true));
            CBamostra.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CBamostra.Location = new Point(434, 557);
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
            CBdesovado.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CBdesovado.Location = new Point(528, 557);
            CBdesovado.Name = "CBdesovado";
            CBdesovado.Size = new Size(98, 25);
            CBdesovado.TabIndex = 100;
            CBdesovado.Text = "Desovado";
            CBdesovado.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox2.Location = new Point(528, 564);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(88, 25);
            checkBox2.TabIndex = 134;
            checkBox2.Text = "Amostra";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox1.Location = new Point(528, 564);
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
            button1.Location = new Point(666, 548);
            button1.Name = "button1";
            button1.Size = new Size(112, 32);
            button1.TabIndex = 132;
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
            groupBox1.Location = new Point(21, 531);
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
            CBdecex.Size = new Size(58, 19);
            CBdecex.TabIndex = 32;
            CBdecex.Text = "Decex";
            CBdecex.UseVisualStyleBackColor = true;
            // 
            // btnAdiciona
            // 
            btnAdiciona.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAdiciona.Cursor = Cursors.Hand;
            btnAdiciona.Location = new Point(784, 548);
            btnAdiciona.Name = "btnAdiciona";
            btnAdiciona.Size = new Size(112, 32);
            btnAdiciona.TabIndex = 127;
            btnAdiciona.Text = "Ok";
            btnAdiciona.UseVisualStyleBackColor = true;
            btnAdiciona.Click += btnAdiciona_Click;
            // 
            // NUMfreetime
            // 
            NUMfreetime.DataBindings.Add(new Binding("Value", bsModificaProcesso, "FreeTime", true));
            NUMfreetime.Location = new Point(732, 121);
            NUMfreetime.Name = "NUMfreetime";
            NUMfreetime.Size = new Size(166, 23);
            NUMfreetime.TabIndex = 288;
            // 
            // label17
            // 
            label17.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label17.Location = new Point(120, 36);
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
            TXTimportador.Location = new Point(215, 34);
            TXTimportador.Name = "TXTimportador";
            TXTimportador.Size = new Size(137, 23);
            TXTimportador.TabIndex = 286;
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(648, 85);
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
            TXTportodedestino.Location = new Point(779, 83);
            TXTportodedestino.Name = "TXTportodedestino";
            TXTportodedestino.Size = new Size(119, 23);
            TXTportodedestino.TabIndex = 284;
            // 
            // label15
            // 
            label15.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(648, 123);
            label15.Name = "label15";
            label15.Size = new Size(78, 21);
            label15.TabIndex = 283;
            label15.Text = "Free Time";
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(476, 161);
            label12.Name = "label12";
            label12.Size = new Size(125, 21);
            label12.TabIndex = 282;
            label12.Text = "Agente de Carga";
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(620, 36);
            label11.Name = "label11";
            label11.Size = new Size(35, 21);
            label11.TabIndex = 281;
            label11.Text = "S/R";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(395, 36);
            label9.Name = "label9";
            label9.Size = new Size(38, 21);
            label9.TabIndex = 280;
            label9.Text = "N/R";
            // 
            // TXTsr
            // 
            TXTsr.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TXTsr.Cursor = Cursors.IBeam;
            TXTsr.DataBindings.Add(new Binding("Text", bsModificaProcesso, "SR", true));
            TXTsr.Location = new Point(661, 34);
            TXTsr.Name = "TXTsr";
            TXTsr.Size = new Size(136, 23);
            TXTsr.TabIndex = 279;
            // 
            // TXTnr
            // 
            TXTnr.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TXTnr.Cursor = Cursors.IBeam;
            TXTnr.DataBindings.Add(new Binding("Text", bsModificaProcesso, "Ref_USA", true));
            TXTnr.Location = new Point(437, 34);
            TXTnr.Name = "TXTnr";
            TXTnr.Size = new Size(126, 23);
            TXTnr.TabIndex = 278;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(171, 165);
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
            TXTbl.Location = new Point(204, 163);
            TXTbl.Name = "TXTbl";
            TXTbl.Size = new Size(199, 23);
            TXTbl.TabIndex = 276;
            // 
            // TXTagentedecarga
            // 
            TXTagentedecarga.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TXTagentedecarga.Cursor = Cursors.IBeam;
            TXTagentedecarga.DataBindings.Add(new Binding("Text", bsModificaProcesso, "AgenteDeCarga", true));
            TXTagentedecarga.Location = new Point(607, 159);
            TXTagentedecarga.Name = "TXTagentedecarga";
            TXTagentedecarga.Size = new Size(119, 23);
            TXTagentedecarga.TabIndex = 275;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(337, 85);
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
            TXTProduto.Location = new Point(409, 83);
            TXTProduto.Name = "TXTProduto";
            TXTProduto.Size = new Size(178, 23);
            TXTProduto.TabIndex = 273;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(32, 123);
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
            TXTordem.Location = new Point(107, 121);
            TXTordem.Name = "TXTordem";
            TXTordem.Size = new Size(157, 23);
            TXTordem.TabIndex = 271;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(337, 123);
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
            TXTflo.Location = new Point(380, 121);
            TXTflo.Name = "TXTflo";
            TXTflo.Size = new Size(207, 23);
            TXTflo.TabIndex = 269;
            // 
            // Exportador
            // 
            Exportador.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Exportador.AutoSize = true;
            Exportador.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Exportador.Location = new Point(32, 85);
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
            TXTexportador.Location = new Point(127, 83);
            TXTexportador.Name = "TXTexportador";
            TXTexportador.Size = new Size(137, 23);
            TXTexportador.TabIndex = 267;
            // 
            // LBLinspecao
            // 
            LBLinspecao.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            LBLinspecao.AutoSize = true;
            LBLinspecao.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            LBLinspecao.Location = new Point(264, 387);
            LBLinspecao.Name = "LBLinspecao";
            LBLinspecao.Size = new Size(68, 20);
            LBLinspecao.TabIndex = 302;
            LBLinspecao.Text = "Inspeção";
            LBLinspecao.Visible = false;
            // 
            // LBLdatadeatracacao
            // 
            LBLdatadeatracacao.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            LBLdatadeatracacao.AutoSize = true;
            LBLdatadeatracacao.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            LBLdatadeatracacao.Location = new Point(64, 387);
            LBLdatadeatracacao.Name = "LBLdatadeatracacao";
            LBLdatadeatracacao.Size = new Size(133, 20);
            LBLdatadeatracacao.TabIndex = 301;
            LBLdatadeatracacao.Text = "Data de Atracação";
            LBLdatadeatracacao.Visible = false;
            // 
            // LBLprevisao
            // 
            LBLprevisao.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            LBLprevisao.AutoSize = true;
            LBLprevisao.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            LBLprevisao.Location = new Point(790, 387);
            LBLprevisao.Name = "LBLprevisao";
            LBLprevisao.Size = new Size(64, 20);
            LBLprevisao.TabIndex = 299;
            LBLprevisao.Text = "Previsão";
            LBLprevisao.Visible = false;
            // 
            // LBLdatadeembarque
            // 
            LBLdatadeembarque.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            LBLdatadeembarque.AutoSize = true;
            LBLdatadeembarque.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            LBLdatadeembarque.Location = new Point(588, 387);
            LBLdatadeembarque.Name = "LBLdatadeembarque";
            LBLdatadeembarque.Size = new Size(134, 20);
            LBLdatadeembarque.TabIndex = 300;
            LBLdatadeembarque.Text = "Data de Embarque";
            LBLdatadeembarque.Visible = false;
            // 
            // cbEmbarque
            // 
            cbEmbarque.AutoSize = true;
            cbEmbarque.DataBindings.Add(new Binding("Checked", bsModificaProcesso, "PossuiEmbarque", true));
            cbEmbarque.Location = new Point(465, 421);
            cbEmbarque.Name = "cbEmbarque";
            cbEmbarque.Size = new Size(15, 14);
            cbEmbarque.TabIndex = 297;
            cbEmbarque.UseVisualStyleBackColor = true;
            cbEmbarque.Click += cbEmbarque_CheckedChanged;
            // 
            // DTPdatadeinspecao
            // 
            DTPdatadeinspecao.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            DTPdatadeinspecao.DataBindings.Add(new Binding("Value", bsModificaProcesso, "Inspecao", true));
            DTPdatadeinspecao.Format = DateTimePickerFormat.Short;
            DTPdatadeinspecao.Location = new Point(231, 411);
            DTPdatadeinspecao.MinDate = new DateTime(2023, 8, 22, 0, 0, 0, 0);
            DTPdatadeinspecao.Name = "DTPdatadeinspecao";
            DTPdatadeinspecao.Size = new Size(135, 23);
            DTPdatadeinspecao.TabIndex = 296;
            DTPdatadeinspecao.Value = new DateTime(2023, 8, 22, 0, 0, 0, 0);
            DTPdatadeinspecao.Visible = false;
            // 
            // DTPdatadeatracacao
            // 
            DTPdatadeatracacao.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            DTPdatadeatracacao.DataBindings.Add(new Binding("Value", bsModificaProcesso, "DataDeAtracacao", true));
            DTPdatadeatracacao.Format = DateTimePickerFormat.Short;
            DTPdatadeatracacao.Location = new Point(63, 411);
            DTPdatadeatracacao.MinDate = new DateTime(2023, 8, 22, 0, 0, 0, 0);
            DTPdatadeatracacao.Name = "DTPdatadeatracacao";
            DTPdatadeatracacao.Size = new Size(135, 23);
            DTPdatadeatracacao.TabIndex = 295;
            DTPdatadeatracacao.Value = new DateTime(2023, 8, 22, 0, 0, 0, 0);
            DTPdatadeatracacao.Visible = false;
            // 
            // DTPdatadeembarque
            // 
            DTPdatadeembarque.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            DTPdatadeembarque.DataBindings.Add(new Binding("Value", bsModificaProcesso, "DataEmbarque", true));
            DTPdatadeembarque.Format = DateTimePickerFormat.Short;
            DTPdatadeembarque.Location = new Point(588, 410);
            DTPdatadeembarque.MinDate = new DateTime(2023, 8, 22, 0, 0, 0, 0);
            DTPdatadeembarque.Name = "DTPdatadeembarque";
            DTPdatadeembarque.Size = new Size(135, 23);
            DTPdatadeembarque.TabIndex = 294;
            DTPdatadeembarque.Value = new DateTime(2023, 8, 22, 0, 0, 0, 0);
            DTPdatadeembarque.Visible = false;
            // 
            // DTPdatadeprevisao
            // 
            DTPdatadeprevisao.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            DTPdatadeprevisao.DataBindings.Add(new Binding("Value", bsModificaProcesso, "Previsao", true));
            DTPdatadeprevisao.Format = DateTimePickerFormat.Short;
            DTPdatadeprevisao.Location = new Point(755, 410);
            DTPdatadeprevisao.MinDate = new DateTime(2023, 8, 22, 0, 0, 0, 0);
            DTPdatadeprevisao.Name = "DTPdatadeprevisao";
            DTPdatadeprevisao.Size = new Size(135, 23);
            DTPdatadeprevisao.TabIndex = 293;
            DTPdatadeprevisao.Value = new DateTime(2023, 8, 22, 0, 0, 0, 0);
            DTPdatadeprevisao.Visible = false;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(52, 450);
            label10.Name = "label10";
            label10.Size = new Size(140, 21);
            label10.TabIndex = 292;
            label10.Text = "Status do Processo";
            // 
            // TXTstatusdoprocesso
            // 
            TXTstatusdoprocesso.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TXTstatusdoprocesso.DataBindings.Add(new Binding("Text", bsModificaProcesso, "StatusDoProcesso", true));
            TXTstatusdoprocesso.Location = new Point(198, 449);
            TXTstatusdoprocesso.Name = "TXTstatusdoprocesso";
            TXTstatusdoprocesso.Size = new Size(684, 23);
            TXTstatusdoprocesso.TabIndex = 291;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(98, 490);
            label8.Name = "label8";
            label8.Size = new Size(80, 21);
            label8.TabIndex = 290;
            label8.Text = "Pendência";
            // 
            // TXTpendencia
            // 
            TXTpendencia.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TXTpendencia.DataBindings.Add(new Binding("Text", bsModificaProcesso, "Pendencia", true));
            TXTpendencia.Location = new Point(181, 488);
            TXTpendencia.Name = "TXTpendencia";
            TXTpendencia.Size = new Size(671, 23);
            TXTpendencia.TabIndex = 289;
            // 
            // lblPEmbarque
            // 
            lblPEmbarque.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblPEmbarque.AutoSize = true;
            lblPEmbarque.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblPEmbarque.Location = new Point(434, 398);
            lblPEmbarque.Name = "lblPEmbarque";
            lblPEmbarque.Size = new Size(77, 20);
            lblPEmbarque.TabIndex = 298;
            lblPEmbarque.Text = "Embarque";
            // 
            // frmModificaProcesso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(932, 622);
            ControlBox = false;
            Controls.Add(LBLinspecao);
            Controls.Add(LBLdatadeatracacao);
            Controls.Add(LBLprevisao);
            Controls.Add(LBLdatadeembarque);
            Controls.Add(cbEmbarque);
            Controls.Add(DTPdatadeinspecao);
            Controls.Add(DTPdatadeatracacao);
            Controls.Add(DTPdatadeembarque);
            Controls.Add(DTPdatadeprevisao);
            Controls.Add(label10);
            Controls.Add(TXTstatusdoprocesso);
            Controls.Add(label8);
            Controls.Add(TXTpendencia);
            Controls.Add(lblPEmbarque);
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
            Name = "frmModificaProcesso";
            Text = "frmModificaProcesso";
            Load += frmModificaProcesso_Load;
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
        private ComboBox CBparametrizacaolilpco;
        private DateTimePicker DTPdatadedeferimentolilpco;
        private DateTimePicker DTPdataderegistrolilpco;
        private TextBox TXTlilpco;
        private Label label26;
        private GroupBox groupBox2;
        private ComboBox CBparametrizacaodi;
        private DateTimePicker DTPdatadecarregamentodi;
        private DateTimePicker DTPdatadedesembaracodi;
        private DateTimePicker DTPdataderegistrodi;
        private TextBox TXTdi;
        private Label label21;
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
        private Label label1;
        private Label label6;
        private Label label19;
        private Label label18;
        private Label label20;
        private Label label22;
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
        private Label LBLprevisao;
        private Label LBLdatadeembarque;
        private CheckBox cbEmbarque;
        private DateTimePicker DTPdatadeinspecao;
        private DateTimePicker DTPdatadeatracacao;
        private DateTimePicker DTPdatadeembarque;
        private DateTimePicker DTPdatadeprevisao;
        private Label label10;
        private TextBox TXTstatusdoprocesso;
        private Label label8;
        private TextBox TXTpendencia;
        private Label lblPEmbarque;
    }
}