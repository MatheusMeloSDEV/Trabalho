namespace Trabalho
{
    partial class FrmModificaIbama
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
            bsModificaIbama = new BindingSource(components);
            LBLinspecao = new Label();
            LBLdatadeatracacao = new Label();
            groupBox3 = new GroupBox();
            label22 = new Label();
            label20 = new Label();
            label18 = new Label();
            CBparametrizacaolilpco = new ComboBox();
            DTPdatadedeferimentolilpco = new DateTimePicker();
            DTPdataderegistrolilpco = new DateTimePicker();
            TXTlilpco = new TextBox();
            label26 = new Label();
            label17 = new Label();
            TXTimportador = new TextBox();
            DTPdatadeinspecao = new DateTimePicker();
            CBamostra = new CheckBox();
            button1 = new Button();
            label14 = new Label();
            TXTorigem = new TextBox();
            btnAdiciona = new Button();
            DTPdatadeatracacao = new DateTimePicker();
            label11 = new Label();
            label9 = new Label();
            TXTsr = new TextBox();
            TXTnr = new TextBox();
            label10 = new Label();
            TXTstatusdoprocesso = new TextBox();
            label7 = new Label();
            TXTProduto = new TextBox();
            label8 = new Label();
            TXTpendencia = new TextBox();
            Exportador = new Label();
            TXTexportador = new TextBox();
            label2 = new Label();
            TXTli = new TextBox();
            DTPdatadeembarque = new DateTimePicker();
            LBLdatadeembarque = new Label();
            label1 = new Label();
            TXTncm = new TextBox();
            label3 = new Label();
            TXTnavio = new TextBox();
            ((System.ComponentModel.ISupportInitialize)bsModificaIbama).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // bsModificaIbama
            // 
            bsModificaIbama.DataSource = typeof(CLUSA.Ibama);
            // 
            // LBLinspecao
            // 
            LBLinspecao.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            LBLinspecao.AutoSize = true;
            LBLinspecao.Font = new Font("Segoe UI", 11F);
            LBLinspecao.Location = new Point(445, 286);
            LBLinspecao.Name = "LBLinspecao";
            LBLinspecao.Size = new Size(68, 20);
            LBLinspecao.TabIndex = 272;
            LBLinspecao.Text = "Inspeção";
            // 
            // LBLdatadeatracacao
            // 
            LBLdatadeatracacao.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            LBLdatadeatracacao.AutoSize = true;
            LBLdatadeatracacao.Font = new Font("Segoe UI", 11F);
            LBLdatadeatracacao.Location = new Point(245, 286);
            LBLdatadeatracacao.Name = "LBLdatadeatracacao";
            LBLdatadeatracacao.Size = new Size(133, 20);
            LBLdatadeatracacao.TabIndex = 271;
            LBLdatadeatracacao.Text = "Data de Atracação";
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
            groupBox3.Location = new Point(94, 189);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(750, 82);
            groupBox3.TabIndex = 268;
            groupBox3.TabStop = false;
            groupBox3.Text = "LPCO";
            // 
            // label22
            // 
            label22.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI", 11F);
            label22.Location = new Point(594, 22);
            label22.Name = "label22";
            label22.Size = new Size(111, 20);
            label22.TabIndex = 146;
            label22.Text = "Parametrização";
            // 
            // label20
            // 
            label20.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 11F);
            label20.Location = new Point(407, 23);
            label20.Name = "label20";
            label20.Size = new Size(150, 20);
            label20.TabIndex = 145;
            label20.Text = "Data de Deferimento";
            // 
            // label18
            // 
            label18.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 11F);
            label18.Location = new Point(240, 23);
            label18.Name = "label18";
            label18.Size = new Size(121, 20);
            label18.TabIndex = 145;
            label18.Text = "Data de Registro";
            // 
            // CBparametrizacaolilpco
            // 
            CBparametrizacaolilpco.DataBindings.Add(new Binding("Text", bsModificaIbama, "ParametrizacaoLPCO", true));
            CBparametrizacaolilpco.DataBindings.Add(new Binding("SelectedValue", bsModificaIbama, "ParametrizacaoLPCO", true));
            CBparametrizacaolilpco.DataBindings.Add(new Binding("SelectedItem", bsModificaIbama, "ParametrizacaoLPCO", true));
            CBparametrizacaolilpco.FormattingEnabled = true;
            CBparametrizacaolilpco.Items.AddRange(new object[] { "Documental", "Conferência Física", "Exame Físico", "Coleta de Amostra" });
            CBparametrizacaolilpco.Location = new Point(585, 46);
            CBparametrizacaolilpco.Name = "CBparametrizacaolilpco";
            CBparametrizacaolilpco.Size = new Size(128, 23);
            CBparametrizacaolilpco.TabIndex = 101;
            // 
            // DTPdatadedeferimentolilpco
            // 
            DTPdatadedeferimentolilpco.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            DTPdatadedeferimentolilpco.Enabled = false;
            DTPdatadedeferimentolilpco.Format = DateTimePickerFormat.Short;
            DTPdatadedeferimentolilpco.Location = new Point(401, 46);
            DTPdatadedeferimentolilpco.MinDate = new DateTime(2024, 10, 17, 0, 0, 0, 0);
            DTPdatadedeferimentolilpco.Name = "DTPdatadedeferimentolilpco";
            DTPdatadedeferimentolilpco.Size = new Size(163, 23);
            DTPdatadedeferimentolilpco.TabIndex = 103;
            DTPdatadedeferimentolilpco.Value = new DateTime(2024, 10, 17, 0, 0, 0, 0);
            // 
            // DTPdataderegistrolilpco
            // 
            DTPdataderegistrolilpco.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            DTPdataderegistrolilpco.Enabled = false;
            DTPdataderegistrolilpco.Format = DateTimePickerFormat.Short;
            DTPdataderegistrolilpco.Location = new Point(219, 46);
            DTPdataderegistrolilpco.MinDate = new DateTime(2024, 10, 17, 0, 0, 0, 0);
            DTPdataderegistrolilpco.Name = "DTPdataderegistrolilpco";
            DTPdataderegistrolilpco.Size = new Size(163, 23);
            DTPdataderegistrolilpco.TabIndex = 100;
            DTPdataderegistrolilpco.Value = new DateTime(2024, 10, 17, 0, 0, 0, 0);
            // 
            // TXTlilpco
            // 
            TXTlilpco.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TXTlilpco.DataBindings.Add(new Binding("Text", bsModificaIbama, "LPCO", true));
            TXTlilpco.Location = new Point(78, 35);
            TXTlilpco.Name = "TXTlilpco";
            TXTlilpco.ReadOnly = true;
            TXTlilpco.Size = new Size(120, 23);
            TXTlilpco.TabIndex = 84;
            // 
            // label26
            // 
            label26.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label26.AutoSize = true;
            label26.Font = new Font("Segoe UI", 12F);
            label26.Location = new Point(44, 37);
            label26.Name = "label26";
            label26.Size = new Size(28, 21);
            label26.TabIndex = 85;
            label26.Text = "N°";
            // 
            // label17
            // 
            label17.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 12F);
            label17.Location = new Point(50, 129);
            label17.Name = "label17";
            label17.Size = new Size(89, 21);
            label17.TabIndex = 263;
            label17.Text = "Importador";
            // 
            // TXTimportador
            // 
            TXTimportador.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TXTimportador.DataBindings.Add(new Binding("Text", bsModificaIbama, "Importador", true));
            TXTimportador.Location = new Point(145, 127);
            TXTimportador.Name = "TXTimportador";
            TXTimportador.Size = new Size(137, 23);
            TXTimportador.TabIndex = 262;
            // 
            // DTPdatadeinspecao
            // 
            DTPdatadeinspecao.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            DTPdatadeinspecao.Format = DateTimePickerFormat.Short;
            DTPdatadeinspecao.Location = new Point(412, 310);
            DTPdatadeinspecao.MinDate = new DateTime(2023, 8, 22, 0, 0, 0, 0);
            DTPdatadeinspecao.Name = "DTPdatadeinspecao";
            DTPdatadeinspecao.Size = new Size(135, 23);
            DTPdatadeinspecao.TabIndex = 261;
            DTPdatadeinspecao.Value = new DateTime(2023, 8, 22, 0, 0, 0, 0);
            // 
            // CBamostra
            // 
            CBamostra.AutoSize = true;
            CBamostra.DataBindings.Add(new Binding("Checked", bsModificaIbama, "Amostra", true));
            CBamostra.Font = new Font("Segoe UI", 12F);
            CBamostra.Location = new Point(48, 521);
            CBamostra.Name = "CBamostra";
            CBamostra.Size = new Size(88, 25);
            CBamostra.TabIndex = 259;
            CBamostra.Text = "Amostra";
            CBamostra.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.Location = new Point(662, 514);
            button1.Name = "button1";
            button1.Size = new Size(112, 32);
            button1.TabIndex = 258;
            button1.Text = "Cancelar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += BtnCancel_Click;
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12F);
            label14.Location = new Point(666, 73);
            label14.Name = "label14";
            label14.Size = new Size(63, 21);
            label14.TabIndex = 257;
            label14.Text = "Origem";
            // 
            // TXTorigem
            // 
            TXTorigem.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TXTorigem.DataBindings.Add(new Binding("Text", bsModificaIbama, "Origem", true));
            TXTorigem.Location = new Point(735, 71);
            TXTorigem.Name = "TXTorigem";
            TXTorigem.Size = new Size(181, 23);
            TXTorigem.TabIndex = 256;
            // 
            // btnAdiciona
            // 
            btnAdiciona.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAdiciona.Location = new Point(780, 514);
            btnAdiciona.Name = "btnAdiciona";
            btnAdiciona.Size = new Size(112, 32);
            btnAdiciona.TabIndex = 254;
            btnAdiciona.Text = "Ok";
            btnAdiciona.UseVisualStyleBackColor = true;
            btnAdiciona.Click += BtnEditar_Click;
            // 
            // DTPdatadeatracacao
            // 
            DTPdatadeatracacao.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            DTPdatadeatracacao.Format = DateTimePickerFormat.Short;
            DTPdatadeatracacao.Location = new Point(244, 310);
            DTPdatadeatracacao.MinDate = new DateTime(2023, 8, 22, 0, 0, 0, 0);
            DTPdatadeatracacao.Name = "DTPdatadeatracacao";
            DTPdatadeatracacao.Size = new Size(135, 23);
            DTPdatadeatracacao.TabIndex = 253;
            DTPdatadeatracacao.Value = new DateTime(2023, 8, 22, 0, 0, 0, 0);
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F);
            label11.Location = new Point(372, 25);
            label11.Name = "label11";
            label11.Size = new Size(49, 21);
            label11.TabIndex = 249;
            label11.Text = "S. Ref";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F);
            label9.Location = new Point(131, 25);
            label9.Name = "label9";
            label9.Size = new Size(66, 21);
            label9.TabIndex = 248;
            label9.Text = "Ref. Usa";
            // 
            // TXTsr
            // 
            TXTsr.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TXTsr.DataBindings.Add(new Binding("Text", bsModificaIbama, "SR", true));
            TXTsr.Location = new Point(427, 23);
            TXTsr.Name = "TXTsr";
            TXTsr.Size = new Size(136, 23);
            TXTsr.TabIndex = 247;
            // 
            // TXTnr
            // 
            TXTnr.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TXTnr.DataBindings.Add(new Binding("Text", bsModificaIbama, "Ref_USA", true));
            TXTnr.Location = new Point(203, 23);
            TXTnr.Name = "TXTnr";
            TXTnr.Size = new Size(126, 23);
            TXTnr.TabIndex = 246;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Underline);
            label10.Location = new Point(56, 358);
            label10.Name = "label10";
            label10.Size = new Size(140, 21);
            label10.TabIndex = 245;
            label10.Text = "Status do Processo";
            // 
            // TXTstatusdoprocesso
            // 
            TXTstatusdoprocesso.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TXTstatusdoprocesso.DataBindings.Add(new Binding("Text", bsModificaIbama, "StatusDoProcesso", true));
            TXTstatusdoprocesso.Location = new Point(202, 357);
            TXTstatusdoprocesso.Multiline = true;
            TXTstatusdoprocesso.Name = "TXTstatusdoprocesso";
            TXTstatusdoprocesso.Size = new Size(684, 89);
            TXTstatusdoprocesso.TabIndex = 244;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(355, 73);
            label7.Name = "label7";
            label7.Size = new Size(66, 21);
            label7.TabIndex = 240;
            label7.Text = "Produto";
            // 
            // TXTProduto
            // 
            TXTProduto.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TXTProduto.DataBindings.Add(new Binding("Text", bsModificaIbama, "Produto", true));
            TXTProduto.Location = new Point(427, 71);
            TXTProduto.Name = "TXTProduto";
            TXTProduto.Size = new Size(178, 23);
            TXTProduto.TabIndex = 239;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(94, 465);
            label8.Name = "label8";
            label8.Size = new Size(80, 21);
            label8.TabIndex = 238;
            label8.Text = "Pendência";
            // 
            // TXTpendencia
            // 
            TXTpendencia.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TXTpendencia.DataBindings.Add(new Binding("Text", bsModificaIbama, "Pendencia", true));
            TXTpendencia.Location = new Point(177, 463);
            TXTpendencia.Name = "TXTpendencia";
            TXTpendencia.Size = new Size(671, 23);
            TXTpendencia.TabIndex = 237;
            // 
            // Exportador
            // 
            Exportador.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Exportador.AutoSize = true;
            Exportador.Font = new Font("Segoe UI", 12F);
            Exportador.Location = new Point(50, 73);
            Exportador.Name = "Exportador";
            Exportador.Size = new Size(86, 21);
            Exportador.TabIndex = 232;
            Exportador.Text = "Exportador";
            // 
            // TXTexportador
            // 
            TXTexportador.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TXTexportador.DataBindings.Add(new Binding("Text", bsModificaIbama, "Exportador", true));
            TXTexportador.Location = new Point(145, 71);
            TXTexportador.Name = "TXTexportador";
            TXTexportador.Size = new Size(137, 23);
            TXTexportador.TabIndex = 231;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(356, 129);
            label2.Name = "label2";
            label2.Size = new Size(22, 21);
            label2.TabIndex = 274;
            label2.Text = "LI";
            // 
            // TXTli
            // 
            TXTli.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TXTli.DataBindings.Add(new Binding("Text", bsModificaIbama, "LI", true));
            TXTli.Location = new Point(384, 129);
            TXTli.Name = "TXTli";
            TXTli.Size = new Size(221, 23);
            TXTli.TabIndex = 273;
            // 
            // DTPdatadeembarque
            // 
            DTPdatadeembarque.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            DTPdatadeembarque.Format = DateTimePickerFormat.Short;
            DTPdatadeembarque.Location = new Point(581, 310);
            DTPdatadeembarque.MinDate = new DateTime(2023, 8, 22, 0, 0, 0, 0);
            DTPdatadeembarque.Name = "DTPdatadeembarque";
            DTPdatadeembarque.Size = new Size(135, 23);
            DTPdatadeembarque.TabIndex = 251;
            DTPdatadeembarque.Value = new DateTime(2023, 8, 22, 0, 0, 0, 0);
            // 
            // LBLdatadeembarque
            // 
            LBLdatadeembarque.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            LBLdatadeembarque.AutoSize = true;
            LBLdatadeembarque.Font = new Font("Segoe UI", 11F);
            LBLdatadeembarque.Location = new Point(581, 287);
            LBLdatadeembarque.Name = "LBLdatadeembarque";
            LBLdatadeembarque.Size = new Size(134, 20);
            LBLdatadeembarque.TabIndex = 270;
            LBLdatadeembarque.Text = "Data de Embarque";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(666, 129);
            label1.Name = "label1";
            label1.Size = new Size(46, 21);
            label1.TabIndex = 276;
            label1.Text = "NCM";
            // 
            // TXTncm
            // 
            TXTncm.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TXTncm.DataBindings.Add(new Binding("Text", bsModificaIbama, "NCM", true));
            TXTncm.Location = new Point(718, 127);
            TXTncm.Name = "TXTncm";
            TXTncm.Size = new Size(198, 23);
            TXTncm.TabIndex = 275;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(610, 25);
            label3.Name = "label3";
            label3.Size = new Size(51, 21);
            label3.TabIndex = 278;
            label3.Text = "Navio";
            // 
            // TXTnavio
            // 
            TXTnavio.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TXTnavio.DataBindings.Add(new Binding("Text", bsModificaIbama, "Navio", true));
            TXTnavio.Location = new Point(667, 23);
            TXTnavio.Name = "TXTnavio";
            TXTnavio.Size = new Size(148, 23);
            TXTnavio.TabIndex = 277;
            // 
            // FrmModificaIbama
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(941, 567);
            ControlBox = false;
            Controls.Add(label3);
            Controls.Add(TXTnavio);
            Controls.Add(label1);
            Controls.Add(TXTncm);
            Controls.Add(label2);
            Controls.Add(TXTli);
            Controls.Add(LBLinspecao);
            Controls.Add(LBLdatadeatracacao);
            Controls.Add(LBLdatadeembarque);
            Controls.Add(groupBox3);
            Controls.Add(label17);
            Controls.Add(TXTimportador);
            Controls.Add(DTPdatadeinspecao);
            Controls.Add(CBamostra);
            Controls.Add(button1);
            Controls.Add(label14);
            Controls.Add(TXTorigem);
            Controls.Add(btnAdiciona);
            Controls.Add(DTPdatadeatracacao);
            Controls.Add(DTPdatadeembarque);
            Controls.Add(label11);
            Controls.Add(label9);
            Controls.Add(TXTsr);
            Controls.Add(TXTnr);
            Controls.Add(label10);
            Controls.Add(TXTstatusdoprocesso);
            Controls.Add(label7);
            Controls.Add(TXTProduto);
            Controls.Add(label8);
            Controls.Add(TXTpendencia);
            Controls.Add(Exportador);
            Controls.Add(TXTexportador);
            Name = "FrmModificaIbama";
            StartPosition = FormStartPosition.CenterScreen;
            Load += FrmModificaIbama_Load;
            ((System.ComponentModel.ISupportInitialize)bsModificaIbama).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private BindingSource bsModificaIbama;
        private Label LBLinspecao;
        private Label LBLdatadeatracacao;
        private GroupBox groupBox3;
        private Label label22;
        private Label label20;
        private Label label18;
        private ComboBox CBparametrizacaolilpco;
        private DateTimePicker DTPdatadedeferimentolilpco;
        private DateTimePicker DTPdataderegistrolilpco;
        private TextBox TXTlilpco;
        private Label label26;
        private Label label17;
        private TextBox TXTimportador;
        private DateTimePicker DTPdatadeinspecao;
        private CheckBox CBamostra;
        private Button button1;
        private Label label14;
        private TextBox TXTorigem;
        private Button btnAdiciona;
        private DateTimePicker DTPdatadeatracacao;
        private Label label11;
        private Label label9;
        private TextBox TXTsr;
        private TextBox TXTnr;
        private Label label10;
        private TextBox TXTstatusdoprocesso;
        private Label label7;
        private TextBox TXTProduto;
        private Label label8;
        private TextBox TXTpendencia;
        private Label Exportador;
        private TextBox TXTexportador;
        private Label label2;
        private TextBox TXTli;
        private DateTimePicker DTPdatadeembarque;
        private Label LBLdatadeembarque;
        private Label label1;
        private TextBox TXTncm;
        private Label label3;
        private TextBox TXTnavio;
    }
}