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
            insImportador = new TextBox();
            bsModificaMAPA = new BindingSource(components);
            label1 = new Label();
            label2 = new Label();
            insLPCO = new TextBox();
            label3 = new Label();
            insTerminal = new TextBox();
            label4 = new Label();
            label5 = new Label();
            insLI = new TextBox();
            label6 = new Label();
            insParametrizacao = new TextBox();
            label7 = new Label();
            insCSIOriginal = new TextBox();
            label8 = new Label();
            insPendencia = new TextBox();
            label10 = new Label();
            insStatusdoProcesso = new TextBox();
            btnOkMAPA = new Button();
            insNR = new TextBox();
            insSR = new TextBox();
            label9 = new Label();
            label11 = new Label();
            dtpPrevisao = new DateTimePicker();
            dtpDatadeEntrada = new DateTimePicker();
            label12 = new Label();
            dtpDatadeInspecao = new DateTimePicker();
            label13 = new Label();
            tErro = new System.Windows.Forms.Timer(components);
            btnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)bsModificaMAPA).BeginInit();
            SuspendLayout();
            // 
            // insImportador
            // 
            insImportador.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            insImportador.DataBindings.Add(new Binding("Text", bsModificaMAPA, "Importador", true));
            insImportador.Location = new Point(302, 188);
            insImportador.Margin = new Padding(3, 4, 3, 4);
            insImportador.Name = "insImportador";
            insImportador.Size = new Size(156, 27);
            insImportador.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(193, 191);
            label1.Name = "label1";
            label1.Size = new Size(113, 28);
            label1.TabIndex = 1;
            label1.Text = "Importador";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(575, 241);
            label2.Name = "label2";
            label2.Size = new Size(58, 28);
            label2.TabIndex = 3;
            label2.Text = "LPCO";
            // 
            // insLPCO
            // 
            insLPCO.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            insLPCO.DataBindings.Add(new Binding("Text", bsModificaMAPA, "LPCO", true));
            insLPCO.Location = new Point(638, 239);
            insLPCO.Margin = new Padding(3, 4, 3, 4);
            insLPCO.Name = "insLPCO";
            insLPCO.Size = new Size(222, 27);
            insLPCO.TabIndex = 2;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(193, 241);
            label3.Name = "label3";
            label3.Size = new Size(85, 28);
            label3.TabIndex = 7;
            label3.Text = "Terminal";
            // 
            // insTerminal
            // 
            insTerminal.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            insTerminal.DataBindings.Add(new Binding("Text", bsModificaMAPA, "Terminal", true));
            insTerminal.Location = new Point(279, 239);
            insTerminal.Margin = new Padding(3, 4, 3, 4);
            insTerminal.Name = "insTerminal";
            insTerminal.Size = new Size(179, 27);
            insTerminal.TabIndex = 6;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(682, 360);
            label4.Name = "label4";
            label4.Size = new Size(85, 28);
            label4.TabIndex = 5;
            label4.Text = "Previsão";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(193, 296);
            label5.Name = "label5";
            label5.Size = new Size(26, 28);
            label5.TabIndex = 15;
            label5.Text = "LI";
            // 
            // insLI
            // 
            insLI.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            insLI.DataBindings.Add(new Binding("Text", bsModificaMAPA, "LI", true));
            insLI.Location = new Point(225, 293);
            insLI.Margin = new Padding(3, 4, 3, 4);
            insLI.Name = "insLI";
            insLI.Size = new Size(233, 27);
            insLI.TabIndex = 14;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(279, 360);
            label6.Name = "label6";
            label6.Size = new Size(152, 28);
            label6.TabIndex = 13;
            label6.Text = "Data de Entrada";
            // 
            // insParametrizacao
            // 
            insParametrizacao.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            insParametrizacao.DataBindings.Add(new Binding("Text", bsModificaMAPA, "Parametrizacao", true));
            insParametrizacao.Location = new Point(714, 288);
            insParametrizacao.Margin = new Padding(3, 4, 3, 4);
            insParametrizacao.Name = "insParametrizacao";
            insParametrizacao.Size = new Size(146, 27);
            insParametrizacao.TabIndex = 12;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(575, 191);
            label7.Name = "label7";
            label7.Size = new Size(115, 28);
            label7.TabIndex = 11;
            label7.Text = "CSI Original";
            // 
            // insCSIOriginal
            // 
            insCSIOriginal.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            insCSIOriginal.DataBindings.Add(new Binding("Text", bsModificaMAPA, "CSIOriginal", true));
            insCSIOriginal.Location = new Point(688, 188);
            insCSIOriginal.Margin = new Padding(3, 4, 3, 4);
            insCSIOriginal.Name = "insCSIOriginal";
            insCSIOriginal.Size = new Size(172, 27);
            insCSIOriginal.TabIndex = 10;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(165, 528);
            label8.Name = "label8";
            label8.Size = new Size(100, 28);
            label8.TabIndex = 9;
            label8.Text = "Pendência";
            // 
            // insPendencia
            // 
            insPendencia.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            insPendencia.DataBindings.Add(new Binding("Text", bsModificaMAPA, "Pendencia", true));
            insPendencia.Location = new Point(259, 525);
            insPendencia.Margin = new Padding(3, 4, 3, 4);
            insPendencia.Name = "insPendencia";
            insPendencia.Size = new Size(303, 27);
            insPendencia.TabIndex = 8;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(113, 463);
            label10.Name = "label10";
            label10.Size = new Size(176, 28);
            label10.TabIndex = 17;
            label10.Text = "Status do Processo";
            // 
            // insStatusdoProcesso
            // 
            insStatusdoProcesso.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            insStatusdoProcesso.DataBindings.Add(new Binding("Text", bsModificaMAPA, "StatusDoProcesso", true));
            insStatusdoProcesso.Location = new Point(280, 463);
            insStatusdoProcesso.Margin = new Padding(3, 4, 3, 4);
            insStatusdoProcesso.Name = "insStatusdoProcesso";
            insStatusdoProcesso.Size = new Size(637, 27);
            insStatusdoProcesso.TabIndex = 16;
            // 
            // btnOkMAPA
            // 
            btnOkMAPA.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnOkMAPA.Location = new Point(781, 525);
            btnOkMAPA.Margin = new Padding(3, 4, 3, 4);
            btnOkMAPA.Name = "btnOkMAPA";
            btnOkMAPA.Size = new Size(122, 37);
            btnOkMAPA.TabIndex = 19;
            btnOkMAPA.Text = "Editar";
            btnOkMAPA.UseVisualStyleBackColor = true;
            btnOkMAPA.Click += button1_Click;
            // 
            // insNR
            // 
            insNR.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            insNR.DataBindings.Add(new Binding("Text", bsModificaMAPA, "NR", true));
            insNR.Location = new Point(408, 97);
            insNR.Margin = new Padding(3, 4, 3, 4);
            insNR.Name = "insNR";
            insNR.Size = new Size(114, 27);
            insNR.TabIndex = 20;
            // 
            // insSR
            // 
            insSR.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            insSR.DataBindings.Add(new Binding("Text", bsModificaMAPA, "SR", true));
            insSR.Location = new Point(581, 97);
            insSR.Margin = new Padding(3, 4, 3, 4);
            insSR.Name = "insSR";
            insSR.Size = new Size(114, 27);
            insSR.TabIndex = 21;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(360, 100);
            label9.Name = "label9";
            label9.Size = new Size(47, 28);
            label9.TabIndex = 22;
            label9.Text = "N/R";
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(534, 100);
            label11.Name = "label11";
            label11.Size = new Size(43, 28);
            label11.TabIndex = 23;
            label11.Text = "S/R";
            // 
            // dtpPrevisao
            // 
            dtpPrevisao.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dtpPrevisao.DataBindings.Add(new Binding("Tag", bsModificaMAPA, "Previsao", true));
            dtpPrevisao.DataBindings.Add(new Binding("Text", bsModificaMAPA, "Previsao", true));
            dtpPrevisao.Location = new Point(648, 392);
            dtpPrevisao.Margin = new Padding(3, 4, 3, 4);
            dtpPrevisao.MinDate = new DateTime(2023, 8, 22, 0, 0, 0, 0);
            dtpPrevisao.Name = "dtpPrevisao";
            dtpPrevisao.Size = new Size(154, 27);
            dtpPrevisao.TabIndex = 24;
            dtpPrevisao.Value = new DateTime(2023, 8, 22, 0, 0, 0, 0);
            // 
            // dtpDatadeEntrada
            // 
            dtpDatadeEntrada.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dtpDatadeEntrada.DataBindings.Add(new Binding("Tag", bsModificaMAPA, "DataDeEntrada", true));
            dtpDatadeEntrada.DataBindings.Add(new Binding("Text", bsModificaMAPA, "DataDeEntrada", true));
            dtpDatadeEntrada.Location = new Point(262, 392);
            dtpDatadeEntrada.Margin = new Padding(3, 4, 3, 4);
            dtpDatadeEntrada.MinDate = new DateTime(2023, 8, 22, 0, 0, 0, 0);
            dtpDatadeEntrada.Name = "dtpDatadeEntrada";
            dtpDatadeEntrada.Size = new Size(154, 27);
            dtpDatadeEntrada.TabIndex = 25;
            dtpDatadeEntrada.Value = new DateTime(2023, 8, 22, 0, 0, 0, 0);
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(575, 291);
            label12.Name = "label12";
            label12.Size = new Size(145, 28);
            label12.TabIndex = 26;
            label12.Text = "Parametrização";
            // 
            // dtpDatadeInspecao
            // 
            dtpDatadeInspecao.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dtpDatadeInspecao.DataBindings.Add(new Binding("Text", bsModificaMAPA, "DataDeInspeção", true));
            dtpDatadeInspecao.DataBindings.Add(new Binding("Tag", bsModificaMAPA, "DataDeInspeção", true));
            dtpDatadeInspecao.Location = new Point(462, 392);
            dtpDatadeInspecao.Margin = new Padding(3, 4, 3, 4);
            dtpDatadeInspecao.MinDate = new DateTime(2023, 8, 22, 0, 0, 0, 0);
            dtpDatadeInspecao.Name = "dtpDatadeInspecao";
            dtpDatadeInspecao.Size = new Size(154, 27);
            dtpDatadeInspecao.TabIndex = 28;
            dtpDatadeInspecao.Value = new DateTime(2023, 8, 22, 0, 0, 0, 0);
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(470, 360);
            label13.Name = "label13";
            label13.Size = new Size(162, 28);
            label13.TabIndex = 27;
            label13.Text = "Data de Inspeção";
            // 
            // tErro
            // 
            tErro.Tick += tErro_Tick;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCancel.Location = new Point(638, 525);
            btnCancel.Margin = new Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(122, 37);
            btnCancel.TabIndex = 29;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // frmModificaMapa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1075, 664);
            ControlBox = false;
            Controls.Add(btnCancel);
            Controls.Add(dtpDatadeInspecao);
            Controls.Add(label13);
            Controls.Add(label12);
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
            Controls.Add(insParametrizacao);
            Controls.Add(label7);
            Controls.Add(insCSIOriginal);
            Controls.Add(label8);
            Controls.Add(insPendencia);
            Controls.Add(label3);
            Controls.Add(insTerminal);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(insLPCO);
            Controls.Add(label1);
            Controls.Add(insImportador);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmModificaMapa";
            StartPosition = FormStartPosition.CenterScreen;
            Load += frmModifica_Load;
            ((System.ComponentModel.ISupportInitialize)bsModificaMAPA).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox insImportador;
        private Label label1;
        private Label label2;
        private TextBox insLPCO;
        private Label label3;
        private TextBox insTerminal;
        private Label label4;
        private Label label5;
        private TextBox insLI;
        private Label label6;
        private TextBox insParametrizacao;
        private Label label7;
        private TextBox insCSIOriginal;
        private Label label8;
        private TextBox insPendencia;
        private Label label10;
        private TextBox insStatusdoProcesso;
        private Button btnOkMAPA;
        private BindingSource bsModificaMAPA;
        private TextBox insNR;
        private TextBox insSR;
        private Label label9;
        private Label label11;
        private DateTimePicker dtpPrevisao;
        private DateTimePicker dtpDatadeEntrada;
        private Label label12;
        private DateTimePicker dtpDatadeInspecao;
        private Label label13;
        private System.Windows.Forms.Timer tErro;
        private Button btnCancel;
    }
}