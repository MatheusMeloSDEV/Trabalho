namespace Trabalho
{
    partial class frmModificaAnvisa
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
            bsModificaAnvisa = new BindingSource(components);
            dtpDatadeInspecao = new DateTimePicker();
            label13 = new Label();
            dtpDatadeEntrada = new DateTimePicker();
            dtpPrevisao = new DateTimePicker();
            label11 = new Label();
            label9 = new Label();
            insSR = new TextBox();
            insNR = new TextBox();
            btnOkMAPA = new Button();
            label10 = new Label();
            insStatusdoProcesso = new TextBox();
            label5 = new Label();
            insLI = new TextBox();
            label6 = new Label();
            label8 = new Label();
            insPendencia = new TextBox();
            label3 = new Label();
            insTerminal = new TextBox();
            label4 = new Label();
            label2 = new Label();
            insLPCO = new TextBox();
            label1 = new Label();
            insImportador = new TextBox();
            tError = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)bsModificaAnvisa).BeginInit();
            SuspendLayout();
            // 
            // bsModificaAnvisa
            // 
            bsModificaAnvisa.DataSource = typeof(CLUSA.Anvisa);
            // 
            // dtpDatadeInspecao
            // 
            dtpDatadeInspecao.DataBindings.Add(new Binding("Value", bsModificaAnvisa, "DataDeInspeção", true));
            dtpDatadeInspecao.Location = new Point(348, 266);
            dtpDatadeInspecao.MinDate = new DateTime(2023, 8, 22, 0, 0, 0, 0);
            dtpDatadeInspecao.Name = "dtpDatadeInspecao";
            dtpDatadeInspecao.Size = new Size(135, 23);
            dtpDatadeInspecao.TabIndex = 55;
            dtpDatadeInspecao.Value = new DateTime(2023, 8, 22, 0, 0, 0, 0);
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(355, 242);
            label13.Name = "label13";
            label13.Size = new Size(128, 21);
            label13.TabIndex = 54;
            label13.Text = "Data de Inspeção";
            // 
            // dtpDatadeEntrada
            // 
            dtpDatadeEntrada.DataBindings.Add(new Binding("Value", bsModificaAnvisa, "DataDeEntrada", true));
            dtpDatadeEntrada.Location = new Point(173, 266);
            dtpDatadeEntrada.MinDate = new DateTime(2023, 8, 22, 0, 0, 0, 0);
            dtpDatadeEntrada.Name = "dtpDatadeEntrada";
            dtpDatadeEntrada.Size = new Size(135, 23);
            dtpDatadeEntrada.TabIndex = 52;
            dtpDatadeEntrada.Value = new DateTime(2023, 8, 22, 0, 0, 0, 0);
            // 
            // dtpPrevisao
            // 
            dtpPrevisao.DataBindings.Add(new Binding("Value", bsModificaAnvisa, "Previsao", true));
            dtpPrevisao.Location = new Point(511, 266);
            dtpPrevisao.MinDate = new DateTime(2023, 8, 22, 0, 0, 0, 0);
            dtpPrevisao.Name = "dtpPrevisao";
            dtpPrevisao.Size = new Size(135, 23);
            dtpPrevisao.TabIndex = 51;
            dtpPrevisao.Value = new DateTime(2023, 8, 22, 0, 0, 0, 0);
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(419, 53);
            label11.Name = "label11";
            label11.Size = new Size(35, 21);
            label11.TabIndex = 50;
            label11.Text = "S/R";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(267, 53);
            label9.Name = "label9";
            label9.Size = new Size(38, 21);
            label9.TabIndex = 49;
            label9.Text = "N/R";
            // 
            // insSR
            // 
            insSR.DataBindings.Add(new Binding("Text", bsModificaAnvisa, "SR", true));
            insSR.Location = new Point(460, 51);
            insSR.Name = "insSR";
            insSR.Size = new Size(100, 23);
            insSR.TabIndex = 48;
            // 
            // insNR
            // 
            insNR.DataBindings.Add(new Binding("Text", bsModificaAnvisa, "NR", true));
            insNR.Location = new Point(309, 51);
            insNR.Name = "insNR";
            insNR.Size = new Size(100, 23);
            insNR.TabIndex = 47;
            // 
            // btnOkMAPA
            // 
            btnOkMAPA.Location = new Point(632, 372);
            btnOkMAPA.Name = "btnOkMAPA";
            btnOkMAPA.Size = new Size(107, 28);
            btnOkMAPA.TabIndex = 46;
            btnOkMAPA.Text = "Ok";
            btnOkMAPA.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(48, 325);
            label10.Name = "label10";
            label10.Size = new Size(140, 21);
            label10.TabIndex = 45;
            label10.Text = "Status do Processo";
            // 
            // insStatusdoProcesso
            // 
            insStatusdoProcesso.DataBindings.Add(new Binding("Text", bsModificaAnvisa, "StatusDoProcesso", true));
            insStatusdoProcesso.Location = new Point(194, 325);
            insStatusdoProcesso.Name = "insStatusdoProcesso";
            insStatusdoProcesso.Size = new Size(558, 23);
            insStatusdoProcesso.TabIndex = 44;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(446, 168);
            label5.Name = "label5";
            label5.Size = new Size(22, 21);
            label5.TabIndex = 43;
            label5.Text = "LI";
            // 
            // insLI
            // 
            insLI.DataBindings.Add(new Binding("Text", bsModificaAnvisa, "LI", true));
            insLI.Location = new Point(474, 166);
            insLI.Name = "insLI";
            insLI.Size = new Size(222, 23);
            insLI.TabIndex = 42;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(188, 242);
            label6.Name = "label6";
            label6.Size = new Size(120, 21);
            label6.TabIndex = 41;
            label6.Text = "Data de Entrada";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(93, 374);
            label8.Name = "label8";
            label8.Size = new Size(80, 21);
            label8.TabIndex = 37;
            label8.Text = "Pendência";
            // 
            // insPendencia
            // 
            insPendencia.DataBindings.Add(new Binding("Text", bsModificaAnvisa, "Pendencia", true));
            insPendencia.Location = new Point(176, 372);
            insPendencia.Name = "insPendencia";
            insPendencia.Size = new Size(266, 23);
            insPendencia.TabIndex = 36;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(118, 168);
            label3.Name = "label3";
            label3.Size = new Size(69, 21);
            label3.TabIndex = 35;
            label3.Text = "Terminal";
            // 
            // insTerminal
            // 
            insTerminal.DataBindings.Add(new Binding("Text", bsModificaAnvisa, "Terminal", true));
            insTerminal.Location = new Point(193, 166);
            insTerminal.Name = "insTerminal";
            insTerminal.Size = new Size(157, 23);
            insTerminal.TabIndex = 34;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(541, 242);
            label4.Name = "label4";
            label4.Size = new Size(69, 21);
            label4.TabIndex = 33;
            label4.Text = "Previsão";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(446, 130);
            label2.Name = "label2";
            label2.Size = new Size(49, 21);
            label2.TabIndex = 32;
            label2.Text = "LPCO";
            // 
            // insLPCO
            // 
            insLPCO.DataBindings.Add(new Binding("Text", bsModificaAnvisa, "LPCO", true));
            insLPCO.Location = new Point(501, 128);
            insLPCO.Name = "insLPCO";
            insLPCO.Size = new Size(195, 23);
            insLPCO.TabIndex = 31;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(118, 130);
            label1.Name = "label1";
            label1.Size = new Size(89, 21);
            label1.TabIndex = 30;
            label1.Text = "Importador";
            // 
            // insImportador
            // 
            insImportador.DataBindings.Add(new Binding("Text", bsModificaAnvisa, "Importador", true));
            insImportador.Location = new Point(213, 128);
            insImportador.Name = "insImportador";
            insImportador.Size = new Size(137, 23);
            insImportador.TabIndex = 29;
            // 
            // tError
            // 
            tError.Tick += tError_Tick;
            // 
            // frmModificaAnvisa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dtpDatadeInspecao);
            Controls.Add(label13);
            Controls.Add(dtpDatadeEntrada);
            Controls.Add(dtpPrevisao);
            Controls.Add(label11);
            Controls.Add(label9);
            Controls.Add(insSR);
            Controls.Add(insNR);
            Controls.Add(btnOkMAPA);
            Controls.Add(label10);
            Controls.Add(insStatusdoProcesso);
            Controls.Add(label5);
            Controls.Add(insLI);
            Controls.Add(label6);
            Controls.Add(label8);
            Controls.Add(insPendencia);
            Controls.Add(label3);
            Controls.Add(insTerminal);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(insLPCO);
            Controls.Add(label1);
            Controls.Add(insImportador);
            Name = "frmModificaAnvisa";
            Text = "frmModificaAnvisa";
            Load += frmModificaAnvisa_Load;
            ((System.ComponentModel.ISupportInitialize)bsModificaAnvisa).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private BindingSource bsModificaAnvisa;
        private DateTimePicker dtpDatadeInspecao;
        private Label label13;
        private DateTimePicker dtpDatadeEntrada;
        private DateTimePicker dtpPrevisao;
        private Label label11;
        private Label label9;
        private TextBox insSR;
        private TextBox insNR;
        private Button btnOkMAPA;
        private Label label10;
        private TextBox insStatusdoProcesso;
        private Label label5;
        private TextBox insLI;
        private Label label6;
        private Label label8;
        private TextBox insPendencia;
        private Label label3;
        private TextBox insTerminal;
        private Label label4;
        private Label label2;
        private TextBox insLPCO;
        private Label label1;
        private TextBox insImportador;
        private System.Windows.Forms.Timer tError;
    }
}