namespace Trabalho
{
    partial class frmModificaMapa
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
            bsModificaMAPA = new BindingSource(components);
            tErro = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            TXTncm = new TextBox();
            label2 = new Label();
            TXTli = new TextBox();
            LBLinspecao = new Label();
            LBLdatadeatracacao = new Label();
            LBLdatadeembarque = new Label();
            groupBox3 = new GroupBox();
            label22 = new Label();
            label20 = new Label();
            label18 = new Label();
            CBparametrizacaolilpco = new ComboBox();
            DTPdatadedeferimentolilpco = new DateTimePicker();
            DTPdataderegistrolilpco = new DateTimePicker();
            TXTlilpco = new TextBox();
            label26 = new Label();
            cbEmbarque = new CheckBox();
            label17 = new Label();
            TXTimportador = new TextBox();
            DTPdatadeinspecao = new DateTimePicker();
            CBamostra = new CheckBox();
            button1 = new Button();
            label14 = new Label();
            TXTorigem = new TextBox();
            btnAdiciona = new Button();
            DTPdatadeatracacao = new DateTimePicker();
            DTPdatadeembarque = new DateTimePicker();
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
            lblPEmbarque = new Label();
            ((System.ComponentModel.ISupportInitialize)bsModificaMAPA).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // tErro
            // 
            tErro.Tick += tErro_Tick;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(653, 140);
            label1.Name = "label1";
            label1.Size = new Size(46, 21);
            label1.TabIndex = 308;
            label1.Text = "NCM";
            // 
            // TXTncm
            // 
            TXTncm.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TXTncm.Location = new Point(705, 138);
            TXTncm.Name = "TXTncm";
            TXTncm.Size = new Size(198, 23);
            TXTncm.TabIndex = 307;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(343, 140);
            label2.Name = "label2";
            label2.Size = new Size(22, 21);
            label2.TabIndex = 306;
            label2.Text = "LI";
            // 
            // TXTli
            // 
            TXTli.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TXTli.Location = new Point(371, 140);
            TXTli.Name = "TXTli";
            TXTli.Size = new Size(221, 23);
            TXTli.TabIndex = 305;
            // 
            // LBLinspecao
            // 
            LBLinspecao.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            LBLinspecao.AutoSize = true;
            LBLinspecao.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            LBLinspecao.Location = new Point(432, 348);
            LBLinspecao.Name = "LBLinspecao";
            LBLinspecao.Size = new Size(68, 20);
            LBLinspecao.TabIndex = 304;
            LBLinspecao.Text = "Inspeção";
            LBLinspecao.Visible = false;
            // 
            // LBLdatadeatracacao
            // 
            LBLdatadeatracacao.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            LBLdatadeatracacao.AutoSize = true;
            LBLdatadeatracacao.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            LBLdatadeatracacao.Location = new Point(232, 348);
            LBLdatadeatracacao.Name = "LBLdatadeatracacao";
            LBLdatadeatracacao.Size = new Size(133, 20);
            LBLdatadeatracacao.TabIndex = 303;
            LBLdatadeatracacao.Text = "Data de Atracação";
            LBLdatadeatracacao.Visible = false;
            // 
            // LBLdatadeembarque
            // 
            LBLdatadeembarque.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            LBLdatadeembarque.AutoSize = true;
            LBLdatadeembarque.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            LBLdatadeembarque.Location = new Point(568, 349);
            LBLdatadeembarque.Name = "LBLdatadeembarque";
            LBLdatadeembarque.Size = new Size(134, 20);
            LBLdatadeembarque.TabIndex = 302;
            LBLdatadeembarque.Text = "Data de Embarque";
            LBLdatadeembarque.Visible = false;
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
            groupBox3.Location = new Point(81, 200);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(750, 82);
            groupBox3.TabIndex = 301;
            groupBox3.TabStop = false;
            groupBox3.Text = "LPCO";
            // 
            // label22
            // 
            label22.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label22.Location = new Point(581, 22);
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
            label20.Location = new Point(397, 23);
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
            label18.Location = new Point(230, 23);
            label18.Name = "label18";
            label18.Size = new Size(121, 20);
            label18.TabIndex = 145;
            label18.Text = "Data de Registro";
            // 
            // CBparametrizacaolilpco
            // 
            CBparametrizacaolilpco.FormattingEnabled = true;
            CBparametrizacaolilpco.Items.AddRange(new object[] { "Verde", "Amarelo", "Vermelho" });
            CBparametrizacaolilpco.Location = new Point(572, 46);
            CBparametrizacaolilpco.Name = "CBparametrizacaolilpco";
            CBparametrizacaolilpco.Size = new Size(128, 23);
            CBparametrizacaolilpco.TabIndex = 101;
            // 
            // DTPdatadedeferimentolilpco
            // 
            DTPdatadedeferimentolilpco.Anchor = AnchorStyles.Top | AnchorStyles.Right;
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
            TXTlilpco.Location = new Point(68, 35);
            TXTlilpco.Name = "TXTlilpco";
            TXTlilpco.Size = new Size(120, 23);
            TXTlilpco.TabIndex = 84;
            // 
            // label26
            // 
            label26.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label26.AutoSize = true;
            label26.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label26.Location = new Point(34, 37);
            label26.Name = "label26";
            label26.Size = new Size(28, 21);
            label26.TabIndex = 85;
            label26.Text = "N°";
            // 
            // cbEmbarque
            // 
            cbEmbarque.AutoSize = true;
            cbEmbarque.Location = new Point(457, 321);
            cbEmbarque.Name = "cbEmbarque";
            cbEmbarque.Size = new Size(15, 14);
            cbEmbarque.TabIndex = 299;
            cbEmbarque.UseVisualStyleBackColor = true;
            cbEmbarque.Click += cbEmbarque_CheckedChanged;
            // 
            // label17
            // 
            label17.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label17.Location = new Point(37, 140);
            label17.Name = "label17";
            label17.Size = new Size(89, 21);
            label17.TabIndex = 298;
            label17.Text = "Importador";
            // 
            // TXTimportador
            // 
            TXTimportador.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TXTimportador.Location = new Point(132, 138);
            TXTimportador.Name = "TXTimportador";
            TXTimportador.Size = new Size(137, 23);
            TXTimportador.TabIndex = 297;
            // 
            // DTPdatadeinspecao
            // 
            DTPdatadeinspecao.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            DTPdatadeinspecao.Format = DateTimePickerFormat.Short;
            DTPdatadeinspecao.Location = new Point(399, 372);
            DTPdatadeinspecao.MinDate = new DateTime(2023, 8, 22, 0, 0, 0, 0);
            DTPdatadeinspecao.Name = "DTPdatadeinspecao";
            DTPdatadeinspecao.Size = new Size(135, 23);
            DTPdatadeinspecao.TabIndex = 296;
            DTPdatadeinspecao.Value = new DateTime(2023, 8, 22, 0, 0, 0, 0);
            DTPdatadeinspecao.Visible = false;
            // 
            // CBamostra
            // 
            CBamostra.AutoSize = true;
            CBamostra.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CBamostra.Location = new Point(43, 516);
            CBamostra.Name = "CBamostra";
            CBamostra.Size = new Size(88, 25);
            CBamostra.TabIndex = 295;
            CBamostra.Text = "Amostra";
            CBamostra.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.Location = new Point(657, 509);
            button1.Name = "button1";
            button1.Size = new Size(112, 32);
            button1.TabIndex = 294;
            button1.Text = "Cancelar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnCancelar_Click;
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(653, 84);
            label14.Name = "label14";
            label14.Size = new Size(63, 21);
            label14.TabIndex = 293;
            label14.Text = "Origem";
            // 
            // TXTorigem
            // 
            TXTorigem.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TXTorigem.Location = new Point(722, 82);
            TXTorigem.Name = "TXTorigem";
            TXTorigem.Size = new Size(181, 23);
            TXTorigem.TabIndex = 292;
            // 
            // btnAdiciona
            // 
            btnAdiciona.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAdiciona.Location = new Point(775, 509);
            btnAdiciona.Name = "btnAdiciona";
            btnAdiciona.Size = new Size(112, 32);
            btnAdiciona.TabIndex = 291;
            btnAdiciona.Text = "Ok";
            btnAdiciona.UseVisualStyleBackColor = true;
            btnAdiciona.Click += btnEditar_Click;
            // 
            // DTPdatadeatracacao
            // 
            DTPdatadeatracacao.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            DTPdatadeatracacao.Format = DateTimePickerFormat.Short;
            DTPdatadeatracacao.Location = new Point(231, 372);
            DTPdatadeatracacao.MinDate = new DateTime(2023, 8, 22, 0, 0, 0, 0);
            DTPdatadeatracacao.Name = "DTPdatadeatracacao";
            DTPdatadeatracacao.Size = new Size(135, 23);
            DTPdatadeatracacao.TabIndex = 290;
            DTPdatadeatracacao.Value = new DateTime(2023, 8, 22, 0, 0, 0, 0);
            DTPdatadeatracacao.Visible = false;
            // 
            // DTPdatadeembarque
            // 
            DTPdatadeembarque.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            DTPdatadeembarque.Format = DateTimePickerFormat.Short;
            DTPdatadeembarque.Location = new Point(568, 372);
            DTPdatadeembarque.MinDate = new DateTime(2023, 8, 22, 0, 0, 0, 0);
            DTPdatadeembarque.Name = "DTPdatadeembarque";
            DTPdatadeembarque.Size = new Size(135, 23);
            DTPdatadeembarque.TabIndex = 289;
            DTPdatadeembarque.Value = new DateTime(2023, 8, 22, 0, 0, 0, 0);
            DTPdatadeembarque.Visible = false;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(468, 35);
            label11.Name = "label11";
            label11.Size = new Size(35, 21);
            label11.TabIndex = 288;
            label11.Text = "S/R";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(243, 35);
            label9.Name = "label9";
            label9.Size = new Size(38, 21);
            label9.TabIndex = 287;
            label9.Text = "N/R";
            // 
            // TXTsr
            // 
            TXTsr.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TXTsr.Location = new Point(509, 33);
            TXTsr.Name = "TXTsr";
            TXTsr.Size = new Size(136, 23);
            TXTsr.TabIndex = 286;
            // 
            // TXTnr
            // 
            TXTnr.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TXTnr.Location = new Point(285, 33);
            TXTnr.Name = "TXTnr";
            TXTnr.Size = new Size(126, 23);
            TXTnr.TabIndex = 285;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(43, 420);
            label10.Name = "label10";
            label10.Size = new Size(140, 21);
            label10.TabIndex = 284;
            label10.Text = "Status do Processo";
            // 
            // TXTstatusdoprocesso
            // 
            TXTstatusdoprocesso.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TXTstatusdoprocesso.Location = new Point(189, 419);
            TXTstatusdoprocesso.Name = "TXTstatusdoprocesso";
            TXTstatusdoprocesso.Size = new Size(684, 23);
            TXTstatusdoprocesso.TabIndex = 283;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(342, 84);
            label7.Name = "label7";
            label7.Size = new Size(66, 21);
            label7.TabIndex = 282;
            label7.Text = "Produto";
            // 
            // TXTProduto
            // 
            TXTProduto.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TXTProduto.Location = new Point(414, 82);
            TXTProduto.Name = "TXTProduto";
            TXTProduto.Size = new Size(178, 23);
            TXTProduto.TabIndex = 281;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(89, 460);
            label8.Name = "label8";
            label8.Size = new Size(80, 21);
            label8.TabIndex = 280;
            label8.Text = "Pendência";
            // 
            // TXTpendencia
            // 
            TXTpendencia.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TXTpendencia.Location = new Point(172, 458);
            TXTpendencia.Name = "TXTpendencia";
            TXTpendencia.Size = new Size(671, 23);
            TXTpendencia.TabIndex = 279;
            // 
            // Exportador
            // 
            Exportador.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Exportador.AutoSize = true;
            Exportador.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Exportador.Location = new Point(37, 84);
            Exportador.Name = "Exportador";
            Exportador.Size = new Size(86, 21);
            Exportador.TabIndex = 278;
            Exportador.Text = "Exportador";
            // 
            // TXTexportador
            // 
            TXTexportador.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TXTexportador.Location = new Point(132, 82);
            TXTexportador.Name = "TXTexportador";
            TXTexportador.Size = new Size(137, 23);
            TXTexportador.TabIndex = 277;
            // 
            // lblPEmbarque
            // 
            lblPEmbarque.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblPEmbarque.AutoSize = true;
            lblPEmbarque.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblPEmbarque.Location = new Point(426, 298);
            lblPEmbarque.Name = "lblPEmbarque";
            lblPEmbarque.Size = new Size(77, 20);
            lblPEmbarque.TabIndex = 300;
            lblPEmbarque.Text = "Embarque";
            // 
            // frmModificaMapa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(941, 575);
            ControlBox = false;
            Controls.Add(label1);
            Controls.Add(TXTncm);
            Controls.Add(label2);
            Controls.Add(TXTli);
            Controls.Add(LBLinspecao);
            Controls.Add(LBLdatadeatracacao);
            Controls.Add(LBLdatadeembarque);
            Controls.Add(groupBox3);
            Controls.Add(cbEmbarque);
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
            Controls.Add(lblPEmbarque);
            Name = "frmModificaMapa";
            StartPosition = FormStartPosition.CenterScreen;
            Load += frmModifica_Load;
            ((System.ComponentModel.ISupportInitialize)bsModificaMAPA).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private BindingSource bsModificaMAPA;
        private System.Windows.Forms.Timer tErro;
        private Label label1;
        private TextBox TXTncm;
        private Label label2;
        private TextBox TXTli;
        private Label LBLinspecao;
        private Label LBLdatadeatracacao;
        private Label LBLdatadeembarque;
        private GroupBox groupBox3;
        private Label label22;
        private Label label20;
        private Label label18;
        private ComboBox CBparametrizacaolilpco;
        private DateTimePicker DTPdatadedeferimentolilpco;
        private DateTimePicker DTPdataderegistrolilpco;
        private TextBox TXTlilpco;
        private Label label26;
        private CheckBox cbEmbarque;
        private Label label17;
        private TextBox TXTimportador;
        private DateTimePicker DTPdatadeinspecao;
        private CheckBox CBamostra;
        private Button button1;
        private Label label14;
        private TextBox TXTorigem;
        private Button btnAdiciona;
        private DateTimePicker DTPdatadeatracacao;
        private DateTimePicker DTPdatadeembarque;
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
        private Label lblPEmbarque;
    }
}