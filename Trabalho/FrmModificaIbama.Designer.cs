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
            LBLdatadeembarque = new Label();
            Label17 = new Label();
            TXTimportador = new TextBox();
            DTPdatadeinspecao = new DateTimePicker();
            CBamostra = new CheckBox();
            Button1 = new Button();
            Label14 = new Label();
            TXTorigem = new TextBox();
            BtnAdiciona = new Button();
            DTPdatadeatracacao = new DateTimePicker();
            DTPdatadeembarque = new DateTimePicker();
            Label11 = new Label();
            Label9 = new Label();
            TXTsr = new TextBox();
            TXTnr = new TextBox();
            Label10 = new Label();
            TXTstatusdoprocesso = new TextBox();
            Label7 = new Label();
            TXTProduto = new TextBox();
            Label8 = new Label();
            TXTpendencia = new TextBox();
            Exportador = new Label();
            TXTexportador = new TextBox();
            label2 = new Label();
            TXTNavio = new TextBox();
            groupBox1 = new GroupBox();
            flpLis = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)bsModificaIbama).BeginInit();
            groupBox1.SuspendLayout();
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
            LBLinspecao.Location = new Point(434, 334);
            LBLinspecao.Name = "LBLinspecao";
            LBLinspecao.Size = new Size(68, 20);
            LBLinspecao.TabIndex = 377;
            LBLinspecao.Text = "Inspeção";
            // 
            // LBLdatadeatracacao
            // 
            LBLdatadeatracacao.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            LBLdatadeatracacao.AutoSize = true;
            LBLdatadeatracacao.Font = new Font("Segoe UI", 11F);
            LBLdatadeatracacao.Location = new Point(234, 334);
            LBLdatadeatracacao.Name = "LBLdatadeatracacao";
            LBLdatadeatracacao.Size = new Size(133, 20);
            LBLdatadeatracacao.TabIndex = 376;
            LBLdatadeatracacao.Text = "Data de Atracação";
            // 
            // LBLdatadeembarque
            // 
            LBLdatadeembarque.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            LBLdatadeembarque.AutoSize = true;
            LBLdatadeembarque.Font = new Font("Segoe UI", 11F);
            LBLdatadeembarque.Location = new Point(570, 335);
            LBLdatadeembarque.Name = "LBLdatadeembarque";
            LBLdatadeembarque.Size = new Size(134, 20);
            LBLdatadeembarque.TabIndex = 375;
            LBLdatadeembarque.Text = "Data de Embarque";
            // 
            // Label17
            // 
            Label17.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Label17.AutoSize = true;
            Label17.Font = new Font("Segoe UI", 12F);
            Label17.Location = new Point(242, 120);
            Label17.Name = "Label17";
            Label17.Size = new Size(89, 21);
            Label17.TabIndex = 373;
            Label17.Text = "Importador";
            // 
            // TXTimportador
            // 
            TXTimportador.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TXTimportador.DataBindings.Add(new Binding("Text", bsModificaIbama, "Importador", true));
            TXTimportador.Location = new Point(337, 118);
            TXTimportador.Name = "TXTimportador";
            TXTimportador.Size = new Size(126, 23);
            TXTimportador.TabIndex = 372;
            // 
            // DTPdatadeinspecao
            // 
            DTPdatadeinspecao.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            DTPdatadeinspecao.Format = DateTimePickerFormat.Short;
            DTPdatadeinspecao.Location = new Point(401, 358);
            DTPdatadeinspecao.MinDate = new DateTime(2023, 8, 22, 0, 0, 0, 0);
            DTPdatadeinspecao.Name = "DTPdatadeinspecao";
            DTPdatadeinspecao.Size = new Size(135, 23);
            DTPdatadeinspecao.TabIndex = 371;
            DTPdatadeinspecao.Value = new DateTime(2023, 8, 22, 0, 0, 0, 0);
            // 
            // CBamostra
            // 
            CBamostra.AutoSize = true;
            CBamostra.DataBindings.Add(new Binding("Checked", bsModificaIbama, "Amostra", true));
            CBamostra.Font = new Font("Segoe UI", 12F);
            CBamostra.Location = new Point(47, 542);
            CBamostra.Name = "CBamostra";
            CBamostra.Size = new Size(88, 25);
            CBamostra.TabIndex = 370;
            CBamostra.Text = "Amostra";
            CBamostra.UseVisualStyleBackColor = true;
            // 
            // Button1
            // 
            Button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Button1.Location = new Point(661, 535);
            Button1.Name = "Button1";
            Button1.Size = new Size(112, 32);
            Button1.TabIndex = 369;
            Button1.Text = "Cancelar";
            Button1.UseVisualStyleBackColor = true;
            Button1.Click += BtnCancel_Click;
            // 
            // Label14
            // 
            Label14.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Label14.AutoSize = true;
            Label14.Font = new Font("Segoe UI", 12F);
            Label14.Location = new Point(652, 63);
            Label14.Name = "Label14";
            Label14.Size = new Size(63, 21);
            Label14.TabIndex = 368;
            Label14.Text = "Origem";
            // 
            // TXTorigem
            // 
            TXTorigem.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TXTorigem.DataBindings.Add(new Binding("Text", bsModificaIbama, "Origem", true));
            TXTorigem.Location = new Point(721, 61);
            TXTorigem.Name = "TXTorigem";
            TXTorigem.Size = new Size(181, 23);
            TXTorigem.TabIndex = 367;
            // 
            // BtnAdiciona
            // 
            BtnAdiciona.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnAdiciona.Location = new Point(779, 535);
            BtnAdiciona.Name = "BtnAdiciona";
            BtnAdiciona.Size = new Size(112, 32);
            BtnAdiciona.TabIndex = 366;
            BtnAdiciona.Text = "Ok";
            BtnAdiciona.UseVisualStyleBackColor = true;
            BtnAdiciona.Click += BtnEditar_Click;
            // 
            // DTPdatadeatracacao
            // 
            DTPdatadeatracacao.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            DTPdatadeatracacao.Format = DateTimePickerFormat.Short;
            DTPdatadeatracacao.Location = new Point(233, 358);
            DTPdatadeatracacao.MinDate = new DateTime(2023, 8, 22, 0, 0, 0, 0);
            DTPdatadeatracacao.Name = "DTPdatadeatracacao";
            DTPdatadeatracacao.Size = new Size(135, 23);
            DTPdatadeatracacao.TabIndex = 365;
            DTPdatadeatracacao.Value = new DateTime(2023, 8, 22, 0, 0, 0, 0);
            // 
            // DTPdatadeembarque
            // 
            DTPdatadeembarque.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            DTPdatadeembarque.Format = DateTimePickerFormat.Short;
            DTPdatadeembarque.Location = new Point(570, 358);
            DTPdatadeembarque.MinDate = new DateTime(2023, 8, 22, 0, 0, 0, 0);
            DTPdatadeembarque.Name = "DTPdatadeembarque";
            DTPdatadeembarque.Size = new Size(135, 23);
            DTPdatadeembarque.TabIndex = 364;
            DTPdatadeembarque.Value = new DateTime(2023, 8, 22, 0, 0, 0, 0);
            // 
            // Label11
            // 
            Label11.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Label11.AutoSize = true;
            Label11.Font = new Font("Segoe UI", 12F);
            Label11.Location = new Point(494, 12);
            Label11.Name = "Label11";
            Label11.Size = new Size(49, 21);
            Label11.TabIndex = 363;
            Label11.Text = "S. Ref";
            // 
            // Label9
            // 
            Label9.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Label9.AutoSize = true;
            Label9.Font = new Font("Segoe UI", 12F);
            Label9.Location = new Point(253, 12);
            Label9.Name = "Label9";
            Label9.Size = new Size(66, 21);
            Label9.TabIndex = 362;
            Label9.Text = "Ref. Usa";
            // 
            // TXTsr
            // 
            TXTsr.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TXTsr.DataBindings.Add(new Binding("Text", bsModificaIbama, "SR", true));
            TXTsr.Location = new Point(549, 12);
            TXTsr.Name = "TXTsr";
            TXTsr.Size = new Size(136, 23);
            TXTsr.TabIndex = 361;
            // 
            // TXTnr
            // 
            TXTnr.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TXTnr.DataBindings.Add(new Binding("Text", bsModificaIbama, "Ref_USA", true));
            TXTnr.Location = new Point(325, 12);
            TXTnr.Name = "TXTnr";
            TXTnr.Size = new Size(126, 23);
            TXTnr.TabIndex = 360;
            // 
            // Label10
            // 
            Label10.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Label10.AutoSize = true;
            Label10.Font = new Font("Segoe UI", 12F, FontStyle.Underline);
            Label10.Location = new Point(45, 394);
            Label10.Name = "Label10";
            Label10.Size = new Size(140, 21);
            Label10.TabIndex = 359;
            Label10.Text = "Status do Processo";
            // 
            // TXTstatusdoprocesso
            // 
            TXTstatusdoprocesso.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TXTstatusdoprocesso.DataBindings.Add(new Binding("Text", bsModificaIbama, "StatusDoProcesso", true));
            TXTstatusdoprocesso.Location = new Point(191, 393);
            TXTstatusdoprocesso.Multiline = true;
            TXTstatusdoprocesso.Name = "TXTstatusdoprocesso";
            TXTstatusdoprocesso.Size = new Size(684, 74);
            TXTstatusdoprocesso.TabIndex = 358;
            // 
            // Label7
            // 
            Label7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Label7.AutoSize = true;
            Label7.Font = new Font("Segoe UI", 12F);
            Label7.Location = new Point(341, 63);
            Label7.Name = "Label7";
            Label7.Size = new Size(66, 21);
            Label7.TabIndex = 357;
            Label7.Text = "Produto";
            // 
            // TXTProduto
            // 
            TXTProduto.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TXTProduto.DataBindings.Add(new Binding("Text", bsModificaIbama, "Produto", true));
            TXTProduto.Location = new Point(413, 61);
            TXTProduto.Name = "TXTProduto";
            TXTProduto.Size = new Size(178, 23);
            TXTProduto.TabIndex = 356;
            // 
            // Label8
            // 
            Label8.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Label8.AutoSize = true;
            Label8.Font = new Font("Segoe UI", 12F);
            Label8.Location = new Point(93, 486);
            Label8.Name = "Label8";
            Label8.Size = new Size(80, 21);
            Label8.TabIndex = 355;
            Label8.Text = "Pendência";
            // 
            // TXTpendencia
            // 
            TXTpendencia.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TXTpendencia.DataBindings.Add(new Binding("Text", bsModificaIbama, "Pendencia", true));
            TXTpendencia.Location = new Point(176, 484);
            TXTpendencia.Name = "TXTpendencia";
            TXTpendencia.Size = new Size(671, 23);
            TXTpendencia.TabIndex = 354;
            // 
            // Exportador
            // 
            Exportador.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Exportador.AutoSize = true;
            Exportador.Font = new Font("Segoe UI", 12F);
            Exportador.Location = new Point(36, 63);
            Exportador.Name = "Exportador";
            Exportador.Size = new Size(86, 21);
            Exportador.TabIndex = 353;
            Exportador.Text = "Exportador";
            // 
            // TXTexportador
            // 
            TXTexportador.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TXTexportador.DataBindings.Add(new Binding("Text", bsModificaIbama, "Exportador", true));
            TXTexportador.Location = new Point(131, 61);
            TXTexportador.Name = "TXTexportador";
            TXTexportador.Size = new Size(137, 23);
            TXTexportador.TabIndex = 352;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(506, 116);
            label2.Name = "label2";
            label2.Size = new Size(51, 21);
            label2.TabIndex = 383;
            label2.Text = "Navio";
            // 
            // TXTNavio
            // 
            TXTNavio.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TXTNavio.DataBindings.Add(new Binding("Text", bsModificaIbama, "Navio", true));
            TXTNavio.Location = new Point(563, 116);
            TXTNavio.Name = "TXTNavio";
            TXTNavio.Size = new Size(136, 23);
            TXTNavio.TabIndex = 382;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(flpLis);
            groupBox1.Location = new Point(12, 147);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(917, 175);
            groupBox1.TabIndex = 384;
            groupBox1.TabStop = false;
            groupBox1.Text = "LI";
            // 
            // flpLis
            // 
            flpLis.Location = new Point(6, 22);
            flpLis.Name = "flpLis";
            flpLis.Size = new Size(905, 147);
            flpLis.TabIndex = 380;
            // 
            // FrmModificaIbama
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(941, 580);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(TXTNavio);
            Controls.Add(LBLinspecao);
            Controls.Add(LBLdatadeatracacao);
            Controls.Add(LBLdatadeembarque);
            Controls.Add(Label17);
            Controls.Add(TXTimportador);
            Controls.Add(DTPdatadeinspecao);
            Controls.Add(CBamostra);
            Controls.Add(Button1);
            Controls.Add(Label14);
            Controls.Add(TXTorigem);
            Controls.Add(BtnAdiciona);
            Controls.Add(DTPdatadeatracacao);
            Controls.Add(DTPdatadeembarque);
            Controls.Add(Label11);
            Controls.Add(Label9);
            Controls.Add(TXTsr);
            Controls.Add(TXTnr);
            Controls.Add(Label10);
            Controls.Add(TXTstatusdoprocesso);
            Controls.Add(Label7);
            Controls.Add(TXTProduto);
            Controls.Add(Label8);
            Controls.Add(TXTpendencia);
            Controls.Add(Exportador);
            Controls.Add(TXTexportador);
            MaximizeBox = false;
            Name = "FrmModificaIbama";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ibama";
            Load += FrmModificaIbama_Load;
            ((System.ComponentModel.ISupportInitialize)bsModificaIbama).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private BindingSource bsModificaIbama;
        private Label LBLinspecao;
        private Label LBLdatadeatracacao;
        private Label LBLdatadeembarque;
        private Label Label17;
        private TextBox TXTimportador;
        private DateTimePicker DTPdatadeinspecao;
        private CheckBox CBamostra;
        private Button Button1;
        private Label Label14;
        private TextBox TXTorigem;
        private Button BtnAdiciona;
        private DateTimePicker DTPdatadeatracacao;
        private DateTimePicker DTPdatadeembarque;
        private Label Label11;
        private Label Label9;
        private TextBox TXTsr;
        private TextBox TXTnr;
        private Label Label10;
        private TextBox TXTstatusdoprocesso;
        private Label Label7;
        private TextBox TXTProduto;
        private Label Label8;
        private TextBox TXTpendencia;
        private Label Exportador;
        private TextBox TXTexportador;
        private Label label2;
        private TextBox TXTNavio;
        private GroupBox groupBox1;
        private FlowLayoutPanel flpLis;
    }
}