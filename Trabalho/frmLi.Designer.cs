namespace Trabalho
{
    partial class frmLi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblLi;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancelar;

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
        /// Método necessário para o Designer – não modifique
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            lblLi = new Label();
            btnOK = new Button();
            btnCancelar = new Button();
            groupBox1 = new GroupBox();
            cbIbama = new CheckBox();
            cbInmetro = new CheckBox();
            cbDecex = new CheckBox();
            cbAnvisa = new CheckBox();
            cbMapa = new CheckBox();
            TxtLi = new TextBox();
            GroupBox3 = new GroupBox();
            Label22 = new Label();
            Label20 = new Label();
            Label18 = new Label();
            CBparametrizacaolilpco = new ComboBox();
            DTPdatadedeferimentolilpco = new DateTimePicker();
            DTPdataderegistrolilpco = new DateTimePicker();
            TXTlilpco = new TextBox();
            Label26 = new Label();
            groupBox1.SuspendLayout();
            GroupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // lblLi
            // 
            lblLi.AutoSize = true;
            lblLi.Location = new Point(12, 20);
            lblLi.Name = "lblLi";
            lblLi.Size = new Size(66, 15);
            lblLi.TabIndex = 0;
            lblLi.Text = "Número LI:";
            // 
            // btnOK
            // 
            btnOK.Location = new Point(195, 271);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(90, 30);
            btnOK.TabIndex = 4;
            btnOK.Text = "Salvar";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(305, 271);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(90, 30);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cbIbama);
            groupBox1.Controls.Add(cbInmetro);
            groupBox1.Controls.Add(cbDecex);
            groupBox1.Controls.Add(cbAnvisa);
            groupBox1.Controls.Add(cbMapa);
            groupBox1.Location = new Point(12, 208);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(383, 56);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Órgãos Anuentes";
            // 
            // cbIbama
            // 
            cbIbama.AutoSize = true;
            cbIbama.Location = new Point(295, 22);
            cbIbama.Name = "cbIbama";
            cbIbama.Size = new Size(59, 19);
            cbIbama.TabIndex = 4;
            cbIbama.Text = "Ibama";
            cbIbama.UseVisualStyleBackColor = true;
            // 
            // cbInmetro
            // 
            cbInmetro.AutoSize = true;
            cbInmetro.Location = new Point(221, 22);
            cbInmetro.Name = "cbInmetro";
            cbInmetro.Size = new Size(68, 19);
            cbInmetro.TabIndex = 3;
            cbInmetro.Text = "Inmetro";
            cbInmetro.UseVisualStyleBackColor = true;
            // 
            // cbDecex
            // 
            cbDecex.AutoSize = true;
            cbDecex.Location = new Point(158, 22);
            cbDecex.Name = "cbDecex";
            cbDecex.Size = new Size(57, 19);
            cbDecex.TabIndex = 2;
            cbDecex.Text = "Decex";
            cbDecex.UseVisualStyleBackColor = true;
            // 
            // cbAnvisa
            // 
            cbAnvisa.AutoSize = true;
            cbAnvisa.Location = new Point(91, 22);
            cbAnvisa.Name = "cbAnvisa";
            cbAnvisa.Size = new Size(61, 19);
            cbAnvisa.TabIndex = 1;
            cbAnvisa.Text = "Anvisa";
            cbAnvisa.UseVisualStyleBackColor = true;
            // 
            // cbMapa
            // 
            cbMapa.AutoSize = true;
            cbMapa.Location = new Point(29, 22);
            cbMapa.Name = "cbMapa";
            cbMapa.Size = new Size(56, 19);
            cbMapa.TabIndex = 0;
            cbMapa.Text = "Mapa";
            cbMapa.UseVisualStyleBackColor = true;
            // 
            // TxtLi
            // 
            TxtLi.Location = new Point(84, 17);
            TxtLi.Name = "TxtLi";
            TxtLi.Size = new Size(311, 23);
            TxtLi.TabIndex = 7;
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
            GroupBox3.Location = new Point(12, 57);
            GroupBox3.Name = "GroupBox3";
            GroupBox3.Size = new Size(383, 145);
            GroupBox3.TabIndex = 375;
            GroupBox3.TabStop = false;
            GroupBox3.Text = "LPCO";
            // 
            // Label22
            // 
            Label22.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Label22.AutoSize = true;
            Label22.Font = new Font("Segoe UI", 11F);
            Label22.Location = new Point(41, 84);
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
            Label20.Location = new Point(199, 84);
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
            Label18.Location = new Point(214, 23);
            Label18.Name = "Label18";
            Label18.Size = new Size(121, 20);
            Label18.TabIndex = 145;
            Label18.Text = "Data de Registro";
            // 
            // CBparametrizacaolilpco
            // 
            CBparametrizacaolilpco.FormattingEnabled = true;
            CBparametrizacaolilpco.Items.AddRange(new object[] { "Documental", "Conferência Física", "Exame Físico", "Coleta de Amostra" });
            CBparametrizacaolilpco.Location = new Point(34, 107);
            CBparametrizacaolilpco.Name = "CBparametrizacaolilpco";
            CBparametrizacaolilpco.Size = new Size(128, 23);
            CBparametrizacaolilpco.TabIndex = 101;
            // 
            // DTPdatadedeferimentolilpco
            // 
            DTPdatadedeferimentolilpco.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            DTPdatadedeferimentolilpco.Format = DateTimePickerFormat.Short;
            DTPdatadedeferimentolilpco.Location = new Point(193, 107);
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
            DTPdataderegistrolilpco.Location = new Point(193, 46);
            DTPdataderegistrolilpco.MinDate = new DateTime(2024, 10, 17, 0, 0, 0, 0);
            DTPdataderegistrolilpco.Name = "DTPdataderegistrolilpco";
            DTPdataderegistrolilpco.Size = new Size(163, 23);
            DTPdataderegistrolilpco.TabIndex = 100;
            DTPdataderegistrolilpco.Value = new DateTime(2024, 10, 17, 0, 0, 0, 0);
            // 
            // TXTlilpco
            // 
            TXTlilpco.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TXTlilpco.Location = new Point(52, 35);
            TXTlilpco.Name = "TXTlilpco";
            TXTlilpco.Size = new Size(120, 23);
            TXTlilpco.TabIndex = 84;
            // 
            // Label26
            // 
            Label26.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Label26.AutoSize = true;
            Label26.Font = new Font("Segoe UI", 12F);
            Label26.Location = new Point(18, 37);
            Label26.Name = "Label26";
            Label26.Size = new Size(28, 21);
            Label26.TabIndex = 85;
            Label26.Text = "N°";
            // 
            // frmLi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(407, 314);
            Controls.Add(GroupBox3);
            Controls.Add(TxtLi);
            Controls.Add(groupBox1);
            Controls.Add(btnCancelar);
            Controls.Add(btnOK);
            Controls.Add(lblLi);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmLi";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Novo Documento";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            GroupBox3.ResumeLayout(false);
            GroupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private CheckBox cbIbama;
        private CheckBox cbInmetro;
        private CheckBox cbDecex;
        private CheckBox cbAnvisa;
        private CheckBox cbMapa;
        private TextBox TxtLi;
        private GroupBox GroupBox3;
        private Label Label22;
        private Label Label20;
        private Label Label18;
        private ComboBox CBparametrizacaolilpco;
        private DateTimePicker DTPdatadedeferimentolilpco;
        private DateTimePicker DTPdataderegistrolilpco;
        private TextBox TXTlilpco;
        private Label Label26;
    }
}
