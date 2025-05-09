namespace Trabalho
{
    partial class FrmModificaMapa
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
            BsModificaMAPA = new BindingSource(components);
            TErro = new System.Windows.Forms.Timer(components);
            Label1 = new Label();
            TXTncm = new TextBox();
            Label2 = new Label();
            TXTli = new TextBox();
            LBLinspecao = new Label();
            LBLdatadeatracacao = new Label();
            LBLdatadeembarque = new Label();
            GroupBox3 = new GroupBox();
            Label22 = new Label();
            Label20 = new Label();
            Label18 = new Label();
            CBparametrizacaolilpco = new ComboBox();
            DTPdatadedeferimentolilpco = new DateTimePicker();
            DTPdataderegistrolilpco = new DateTimePicker();
            TXTlilpco = new TextBox();
            Label26 = new Label();
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
            ((System.ComponentModel.ISupportInitialize)BsModificaMAPA).BeginInit();
            GroupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // BsModificaMAPA
            // 
            BsModificaMAPA.DataMember = "ListaMapa";
            BsModificaMAPA.DataSource = typeof(CLUSA.RepositorioMAPA);
            // 
            // TErro
            // 
            TErro.Tick += TErro_Tick;
            // 
            // Label1
            // 
            Label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Label1.AutoSize = true;
            Label1.Font = new Font("Segoe UI", 12F);
            Label1.Location = new Point(653, 140);
            Label1.Name = "Label1";
            Label1.Size = new Size(46, 21);
            Label1.TabIndex = 308;
            Label1.Text = "NCM";
            // 
            // TXTncm
            // 
            TXTncm.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TXTncm.DataBindings.Add(new Binding("Text", BsModificaMAPA, "NCM", true));
            TXTncm.Location = new Point(705, 138);
            TXTncm.Name = "TXTncm";
            TXTncm.Size = new Size(198, 23);
            TXTncm.TabIndex = 307;
            // 
            // Label2
            // 
            Label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Label2.AutoSize = true;
            Label2.Font = new Font("Segoe UI", 12F);
            Label2.Location = new Point(343, 140);
            Label2.Name = "Label2";
            Label2.Size = new Size(22, 21);
            Label2.TabIndex = 306;
            Label2.Text = "LI";
            // 
            // TXTli
            // 
            TXTli.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TXTli.DataBindings.Add(new Binding("Text", BsModificaMAPA, "LI", true));
            TXTli.Location = new Point(371, 140);
            TXTli.Name = "TXTli";
            TXTli.Size = new Size(221, 23);
            TXTli.TabIndex = 305;
            // 
            // LBLinspecao
            // 
            LBLinspecao.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            LBLinspecao.AutoSize = true;
            LBLinspecao.Font = new Font("Segoe UI", 11F);
            LBLinspecao.Location = new Point(435, 299);
            LBLinspecao.Name = "LBLinspecao";
            LBLinspecao.Size = new Size(68, 20);
            LBLinspecao.TabIndex = 304;
            LBLinspecao.Text = "Inspeção";
            // 
            // LBLdatadeatracacao
            // 
            LBLdatadeatracacao.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            LBLdatadeatracacao.AutoSize = true;
            LBLdatadeatracacao.Font = new Font("Segoe UI", 11F);
            LBLdatadeatracacao.Location = new Point(235, 299);
            LBLdatadeatracacao.Name = "LBLdatadeatracacao";
            LBLdatadeatracacao.Size = new Size(133, 20);
            LBLdatadeatracacao.TabIndex = 303;
            LBLdatadeatracacao.Text = "Data de Atracação";
            // 
            // LBLdatadeembarque
            // 
            LBLdatadeembarque.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            LBLdatadeembarque.AutoSize = true;
            LBLdatadeembarque.Font = new Font("Segoe UI", 11F);
            LBLdatadeembarque.Location = new Point(571, 300);
            LBLdatadeembarque.Name = "LBLdatadeembarque";
            LBLdatadeembarque.Size = new Size(134, 20);
            LBLdatadeembarque.TabIndex = 302;
            LBLdatadeembarque.Text = "Data de Embarque";
            // 
            // GroupBox3
            // 
            GroupBox3.Controls.Add(Label22);
            GroupBox3.Controls.Add(Label20);
            GroupBox3.Controls.Add(Label18);
            GroupBox3.Controls.Add(CBparametrizacaolilpco);
            GroupBox3.Controls.Add(DTPdatadedeferimentolilpco);
            GroupBox3.Controls.Add(DTPdataderegistrolilpco);
            GroupBox3.Controls.Add(TXTlilpco);
            GroupBox3.Controls.Add(Label26);
            GroupBox3.Location = new Point(81, 200);
            GroupBox3.Name = "GroupBox3";
            GroupBox3.Size = new Size(750, 82);
            GroupBox3.TabIndex = 301;
            GroupBox3.TabStop = false;
            GroupBox3.Text = "LPCO";
            // 
            // Label22
            // 
            Label22.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Label22.AutoSize = true;
            Label22.Font = new Font("Segoe UI", 11F);
            Label22.Location = new Point(581, 22);
            Label22.Name = "Label22";
            Label22.Size = new Size(111, 20);
            Label22.TabIndex = 146;
            Label22.Text = "Parametrização";
            // 
            // Label20
            // 
            Label20.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Label20.AutoSize = true;
            Label20.Font = new Font("Segoe UI", 11F);
            Label20.Location = new Point(397, 23);
            Label20.Name = "Label20";
            Label20.Size = new Size(150, 20);
            Label20.TabIndex = 145;
            Label20.Text = "Data de Deferimento";
            // 
            // Label18
            // 
            Label18.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Label18.AutoSize = true;
            Label18.Font = new Font("Segoe UI", 11F);
            Label18.Location = new Point(230, 23);
            Label18.Name = "Label18";
            Label18.Size = new Size(121, 20);
            Label18.TabIndex = 145;
            Label18.Text = "Data de Registro";
            // 
            // CBparametrizacaolilpco
            // 
            CBparametrizacaolilpco.DataBindings.Add(new Binding("SelectedValue", BsModificaMAPA, "ParametrizacaoLPCO", true));
            CBparametrizacaolilpco.DataBindings.Add(new Binding("SelectedItem", BsModificaMAPA, "ParametrizacaoLPCO", true));
            CBparametrizacaolilpco.FormattingEnabled = true;
            CBparametrizacaolilpco.Items.AddRange(new object[] { "Documental", "Conferência Física", "Exame Físico", "Coleta de Amostra" });
            CBparametrizacaolilpco.Location = new Point(572, 46);
            CBparametrizacaolilpco.Name = "CBparametrizacaolilpco";
            CBparametrizacaolilpco.Size = new Size(128, 23);
            CBparametrizacaolilpco.TabIndex = 101;
            // 
            // DTPdatadedeferimentolilpco
            // 
            DTPdatadedeferimentolilpco.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            DTPdatadedeferimentolilpco.DataBindings.Add(new Binding("Text", BsModificaMAPA, "DataDeferimentoLPCO", true));
            DTPdatadedeferimentolilpco.DataBindings.Add(new Binding("Value", BsModificaMAPA, "DataDeferimentoLPCO", true));
            DTPdatadedeferimentolilpco.Enabled = false;
            DTPdatadedeferimentolilpco.Format = DateTimePickerFormat.Short;
            DTPdatadedeferimentolilpco.Location = new Point(391, 46);
            DTPdatadedeferimentolilpco.MinDate = new DateTime(2024, 10, 17, 0, 0, 0, 0);
            DTPdatadedeferimentolilpco.Name = "DTPdatadedeferimentolilpco";
            DTPdatadedeferimentolilpco.Size = new Size(163, 23);
            DTPdatadedeferimentolilpco.TabIndex = 103;
            DTPdatadedeferimentolilpco.Value = new DateTime(2024, 10, 17, 0, 0, 0, 0);
            // 
            // DTPdataderegistrolilpco
            // 
            DTPdataderegistrolilpco.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            DTPdataderegistrolilpco.DataBindings.Add(new Binding("Value", BsModificaMAPA, "DataRegistroLPCO", true));
            DTPdataderegistrolilpco.DataBindings.Add(new Binding("Text", BsModificaMAPA, "DataRegistroLPCO", true));
            DTPdataderegistrolilpco.Enabled = false;
            DTPdataderegistrolilpco.Format = DateTimePickerFormat.Short;
            DTPdataderegistrolilpco.Location = new Point(209, 46);
            DTPdataderegistrolilpco.MinDate = new DateTime(2024, 10, 17, 0, 0, 0, 0);
            DTPdataderegistrolilpco.Name = "DTPdataderegistrolilpco";
            DTPdataderegistrolilpco.Size = new Size(163, 23);
            DTPdataderegistrolilpco.TabIndex = 100;
            DTPdataderegistrolilpco.Value = new DateTime(2024, 10, 17, 0, 0, 0, 0);
            // 
            // TXTlilpco
            // 
            TXTlilpco.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TXTlilpco.DataBindings.Add(new Binding("Text", BsModificaMAPA, "LPCO", true));
            TXTlilpco.Location = new Point(68, 35);
            TXTlilpco.Name = "TXTlilpco";
            TXTlilpco.ReadOnly = true;
            TXTlilpco.Size = new Size(120, 23);
            TXTlilpco.TabIndex = 84;
            // 
            // Label26
            // 
            Label26.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Label26.AutoSize = true;
            Label26.Font = new Font("Segoe UI", 12F);
            Label26.Location = new Point(34, 37);
            Label26.Name = "Label26";
            Label26.Size = new Size(28, 21);
            Label26.TabIndex = 85;
            Label26.Text = "N°";
            // 
            // Label17
            // 
            Label17.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Label17.AutoSize = true;
            Label17.Font = new Font("Segoe UI", 12F);
            Label17.Location = new Point(37, 140);
            Label17.Name = "Label17";
            Label17.Size = new Size(89, 21);
            Label17.TabIndex = 298;
            Label17.Text = "Importador";
            // 
            // TXTimportador
            // 
            TXTimportador.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TXTimportador.DataBindings.Add(new Binding("Text", BsModificaMAPA, "Importador", true));
            TXTimportador.Location = new Point(132, 138);
            TXTimportador.Name = "TXTimportador";
            TXTimportador.Size = new Size(137, 23);
            TXTimportador.TabIndex = 297;
            // 
            // DTPdatadeinspecao
            // 
            DTPdatadeinspecao.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            DTPdatadeinspecao.Format = DateTimePickerFormat.Short;
            DTPdatadeinspecao.Location = new Point(402, 323);
            DTPdatadeinspecao.MinDate = new DateTime(2023, 8, 22, 0, 0, 0, 0);
            DTPdatadeinspecao.Name = "DTPdatadeinspecao";
            DTPdatadeinspecao.Size = new Size(135, 23);
            DTPdatadeinspecao.TabIndex = 296;
            DTPdatadeinspecao.Value = new DateTime(2023, 8, 22, 0, 0, 0, 0);
            // 
            // CBamostra
            // 
            CBamostra.AutoSize = true;
            CBamostra.Font = new Font("Segoe UI", 12F);
            CBamostra.Location = new Point(48, 519);
            CBamostra.Name = "CBamostra";
            CBamostra.Size = new Size(88, 25);
            CBamostra.TabIndex = 295;
            CBamostra.Text = "Amostra";
            CBamostra.UseVisualStyleBackColor = true;
            // 
            // Button1
            // 
            Button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Button1.Location = new Point(662, 512);
            Button1.Name = "Button1";
            Button1.Size = new Size(112, 32);
            Button1.TabIndex = 294;
            Button1.Text = "Cancelar";
            Button1.UseVisualStyleBackColor = true;
            Button1.Click += BtnCancelar_Click;
            // 
            // Label14
            // 
            Label14.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Label14.AutoSize = true;
            Label14.Font = new Font("Segoe UI", 12F);
            Label14.Location = new Point(653, 84);
            Label14.Name = "Label14";
            Label14.Size = new Size(63, 21);
            Label14.TabIndex = 293;
            Label14.Text = "Origem";
            // 
            // TXTorigem
            // 
            TXTorigem.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TXTorigem.DataBindings.Add(new Binding("Text", BsModificaMAPA, "Origem", true));
            TXTorigem.Location = new Point(722, 82);
            TXTorigem.Name = "TXTorigem";
            TXTorigem.Size = new Size(181, 23);
            TXTorigem.TabIndex = 292;
            // 
            // BtnAdiciona
            // 
            BtnAdiciona.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnAdiciona.Location = new Point(780, 512);
            BtnAdiciona.Name = "BtnAdiciona";
            BtnAdiciona.Size = new Size(112, 32);
            BtnAdiciona.TabIndex = 291;
            BtnAdiciona.Text = "Ok";
            BtnAdiciona.UseVisualStyleBackColor = true;
            BtnAdiciona.Click += BtnEditar_Click;
            // 
            // DTPdatadeatracacao
            // 
            DTPdatadeatracacao.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            DTPdatadeatracacao.Format = DateTimePickerFormat.Short;
            DTPdatadeatracacao.Location = new Point(234, 323);
            DTPdatadeatracacao.MinDate = new DateTime(2023, 8, 22, 0, 0, 0, 0);
            DTPdatadeatracacao.Name = "DTPdatadeatracacao";
            DTPdatadeatracacao.Size = new Size(135, 23);
            DTPdatadeatracacao.TabIndex = 290;
            DTPdatadeatracacao.Value = new DateTime(2023, 8, 22, 0, 0, 0, 0);
            // 
            // DTPdatadeembarque
            // 
            DTPdatadeembarque.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            DTPdatadeembarque.Format = DateTimePickerFormat.Short;
            DTPdatadeembarque.Location = new Point(571, 323);
            DTPdatadeembarque.MinDate = new DateTime(2023, 8, 22, 0, 0, 0, 0);
            DTPdatadeembarque.Name = "DTPdatadeembarque";
            DTPdatadeembarque.Size = new Size(135, 23);
            DTPdatadeembarque.TabIndex = 289;
            DTPdatadeembarque.Value = new DateTime(2023, 8, 22, 0, 0, 0, 0);
            // 
            // Label11
            // 
            Label11.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Label11.AutoSize = true;
            Label11.Font = new Font("Segoe UI", 12F);
            Label11.Location = new Point(454, 33);
            Label11.Name = "Label11";
            Label11.Size = new Size(49, 21);
            Label11.TabIndex = 288;
            Label11.Text = "S. Ref";
            // 
            // Label9
            // 
            Label9.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Label9.AutoSize = true;
            Label9.Font = new Font("Segoe UI", 12F);
            Label9.Location = new Point(213, 33);
            Label9.Name = "Label9";
            Label9.Size = new Size(66, 21);
            Label9.TabIndex = 287;
            Label9.Text = "Ref. Usa";
            // 
            // TXTsr
            // 
            TXTsr.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TXTsr.DataBindings.Add(new Binding("Text", BsModificaMAPA, "SR", true));
            TXTsr.Location = new Point(509, 33);
            TXTsr.Name = "TXTsr";
            TXTsr.Size = new Size(136, 23);
            TXTsr.TabIndex = 286;
            // 
            // TXTnr
            // 
            TXTnr.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TXTnr.DataBindings.Add(new Binding("Text", BsModificaMAPA, "Ref_USA", true));
            TXTnr.Location = new Point(285, 33);
            TXTnr.Name = "TXTnr";
            TXTnr.Size = new Size(126, 23);
            TXTnr.TabIndex = 285;
            // 
            // Label10
            // 
            Label10.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Label10.AutoSize = true;
            Label10.Font = new Font("Segoe UI", 12F, FontStyle.Underline);
            Label10.Location = new Point(46, 371);
            Label10.Name = "Label10";
            Label10.Size = new Size(140, 21);
            Label10.TabIndex = 284;
            Label10.Text = "Status do Processo";
            // 
            // TXTstatusdoprocesso
            // 
            TXTstatusdoprocesso.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TXTstatusdoprocesso.Location = new Point(192, 370);
            TXTstatusdoprocesso.Multiline = true;
            TXTstatusdoprocesso.Name = "TXTstatusdoprocesso";
            TXTstatusdoprocesso.Size = new Size(684, 74);
            TXTstatusdoprocesso.TabIndex = 283;
            // 
            // Label7
            // 
            Label7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Label7.AutoSize = true;
            Label7.Font = new Font("Segoe UI", 12F);
            Label7.Location = new Point(342, 84);
            Label7.Name = "Label7";
            Label7.Size = new Size(66, 21);
            Label7.TabIndex = 282;
            Label7.Text = "Produto";
            // 
            // TXTProduto
            // 
            TXTProduto.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TXTProduto.DataBindings.Add(new Binding("Text", BsModificaMAPA, "Produto", true));
            TXTProduto.Location = new Point(414, 82);
            TXTProduto.Name = "TXTProduto";
            TXTProduto.Size = new Size(178, 23);
            TXTProduto.TabIndex = 281;
            // 
            // Label8
            // 
            Label8.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Label8.AutoSize = true;
            Label8.Font = new Font("Segoe UI", 12F);
            Label8.Location = new Point(94, 463);
            Label8.Name = "Label8";
            Label8.Size = new Size(80, 21);
            Label8.TabIndex = 280;
            Label8.Text = "Pendência";
            // 
            // TXTpendencia
            // 
            TXTpendencia.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TXTpendencia.Location = new Point(177, 461);
            TXTpendencia.Name = "TXTpendencia";
            TXTpendencia.Size = new Size(671, 23);
            TXTpendencia.TabIndex = 279;
            // 
            // Exportador
            // 
            Exportador.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Exportador.AutoSize = true;
            Exportador.Font = new Font("Segoe UI", 12F);
            Exportador.Location = new Point(37, 84);
            Exportador.Name = "Exportador";
            Exportador.Size = new Size(86, 21);
            Exportador.TabIndex = 278;
            Exportador.Text = "Exportador";
            // 
            // TXTexportador
            // 
            TXTexportador.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TXTexportador.DataBindings.Add(new Binding("Text", BsModificaMAPA, "Exportador", true));
            TXTexportador.Location = new Point(132, 82);
            TXTexportador.Name = "TXTexportador";
            TXTexportador.Size = new Size(137, 23);
            TXTexportador.TabIndex = 277;
            // 
            // FrmModificaMapa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(941, 572);
            ControlBox = false;
            Controls.Add(Label1);
            Controls.Add(TXTncm);
            Controls.Add(Label2);
            Controls.Add(TXTli);
            Controls.Add(LBLinspecao);
            Controls.Add(LBLdatadeatracacao);
            Controls.Add(LBLdatadeembarque);
            Controls.Add(GroupBox3);
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
            Name = "FrmModificaMapa";
            StartPosition = FormStartPosition.CenterScreen;
            Load += FrmModifica_Load;
            ((System.ComponentModel.ISupportInitialize)BsModificaMAPA).EndInit();
            GroupBox3.ResumeLayout(false);
            GroupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private BindingSource BsModificaMAPA;
        private System.Windows.Forms.Timer TErro;
        private Label Label1;
        private TextBox TXTncm;
        private Label Label2;
        private TextBox TXTli;
        private Label LBLinspecao;
        private Label LBLdatadeatracacao;
        private Label LBLdatadeembarque;
        private GroupBox GroupBox3;
        private Label Label22;
        private Label Label20;
        private Label Label18;
        private ComboBox CBparametrizacaolilpco;
        private DateTimePicker DTPdatadedeferimentolilpco;
        private DateTimePicker DTPdataderegistrolilpco;
        private TextBox TXTlilpco;
        private Label Label26;
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
    }
}