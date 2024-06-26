﻿namespace Trabalho
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
            ((System.ComponentModel.ISupportInitialize)bsModificaMAPA).BeginInit();
            SuspendLayout();
            // 
            // insImportador
            // 
            insImportador.DataBindings.Add(new Binding("Text", bsModificaMAPA, "Importador", true));
            insImportador.Location = new Point(213, 130);
            insImportador.Name = "insImportador";
            insImportador.Size = new Size(137, 23);
            insImportador.TabIndex = 0;
            // 
            // bsModificaMAPA
            // 
            bsModificaMAPA.DataSource = typeof(CLUSA.MAPA);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(118, 132);
            label1.Name = "label1";
            label1.Size = new Size(89, 21);
            label1.TabIndex = 1;
            label1.Text = "Importador";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(452, 170);
            label2.Name = "label2";
            label2.Size = new Size(49, 21);
            label2.TabIndex = 3;
            label2.Text = "LPCO";
            // 
            // insLPCO
            // 
            insLPCO.DataBindings.Add(new Binding("Text", bsModificaMAPA, "LPCO", true));
            insLPCO.Location = new Point(507, 168);
            insLPCO.Name = "insLPCO";
            insLPCO.Size = new Size(195, 23);
            insLPCO.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(118, 170);
            label3.Name = "label3";
            label3.Size = new Size(69, 21);
            label3.TabIndex = 7;
            label3.Text = "Terminal";
            // 
            // insTerminal
            // 
            insTerminal.DataBindings.Add(new Binding("Text", bsModificaMAPA, "Terminal", true));
            insTerminal.Location = new Point(193, 168);
            insTerminal.Name = "insTerminal";
            insTerminal.Size = new Size(157, 23);
            insTerminal.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(546, 259);
            label4.Name = "label4";
            label4.Size = new Size(69, 21);
            label4.TabIndex = 5;
            label4.Text = "Previsão";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(118, 211);
            label5.Name = "label5";
            label5.Size = new Size(22, 21);
            label5.TabIndex = 15;
            label5.Text = "LI";
            // 
            // insLI
            // 
            insLI.DataBindings.Add(new Binding("Text", bsModificaMAPA, "LI", true));
            insLI.Location = new Point(146, 209);
            insLI.Name = "insLI";
            insLI.Size = new Size(204, 23);
            insLI.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(193, 259);
            label6.Name = "label6";
            label6.Size = new Size(120, 21);
            label6.TabIndex = 13;
            label6.Text = "Data de Entrada";
            // 
            // insParametrizacao
            // 
            insParametrizacao.DataBindings.Add(new Binding("Text", bsModificaMAPA, "Parametrizacao", true));
            insParametrizacao.Location = new Point(574, 205);
            insParametrizacao.Name = "insParametrizacao";
            insParametrizacao.Size = new Size(128, 23);
            insParametrizacao.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(452, 132);
            label7.Name = "label7";
            label7.Size = new Size(93, 21);
            label7.TabIndex = 11;
            label7.Text = "CSI Original";
            // 
            // insCSIOriginal
            // 
            insCSIOriginal.DataBindings.Add(new Binding("Text", bsModificaMAPA, "CSIOriginal", true));
            insCSIOriginal.Location = new Point(551, 130);
            insCSIOriginal.Name = "insCSIOriginal";
            insCSIOriginal.Size = new Size(151, 23);
            insCSIOriginal.TabIndex = 10;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(93, 385);
            label8.Name = "label8";
            label8.Size = new Size(80, 21);
            label8.TabIndex = 9;
            label8.Text = "Pendência";
            // 
            // insPendencia
            // 
            insPendencia.DataBindings.Add(new Binding("Text", bsModificaMAPA, "Pendencia", true));
            insPendencia.Location = new Point(176, 383);
            insPendencia.Name = "insPendencia";
            insPendencia.Size = new Size(266, 23);
            insPendencia.TabIndex = 8;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(48, 336);
            label10.Name = "label10";
            label10.Size = new Size(140, 21);
            label10.TabIndex = 17;
            label10.Text = "Status do Processo";
            // 
            // insStatusdoProcesso
            // 
            insStatusdoProcesso.DataBindings.Add(new Binding("Text", bsModificaMAPA, "StatusDoProcesso", true));
            insStatusdoProcesso.Location = new Point(194, 336);
            insStatusdoProcesso.Name = "insStatusdoProcesso";
            insStatusdoProcesso.Size = new Size(558, 23);
            insStatusdoProcesso.TabIndex = 16;
            // 
            // btnOkMAPA
            // 
            btnOkMAPA.Location = new Point(632, 383);
            btnOkMAPA.Name = "btnOkMAPA";
            btnOkMAPA.Size = new Size(107, 28);
            btnOkMAPA.TabIndex = 19;
            btnOkMAPA.Text = "Ok";
            btnOkMAPA.UseVisualStyleBackColor = true;
            btnOkMAPA.Click += button1_Click;
            // 
            // insNR
            // 
            insNR.DataBindings.Add(new Binding("Text", bsModificaMAPA, "NR", true));
            insNR.Location = new Point(306, 62);
            insNR.Name = "insNR";
            insNR.Size = new Size(100, 23);
            insNR.TabIndex = 20;
            // 
            // insSR
            // 
            insSR.DataBindings.Add(new Binding("Text", bsModificaMAPA, "SR", true));
            insSR.Location = new Point(457, 62);
            insSR.Name = "insSR";
            insSR.Size = new Size(100, 23);
            insSR.TabIndex = 21;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(264, 64);
            label9.Name = "label9";
            label9.Size = new Size(38, 21);
            label9.TabIndex = 22;
            label9.Text = "N/R";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(416, 64);
            label11.Name = "label11";
            label11.Size = new Size(35, 21);
            label11.TabIndex = 23;
            label11.Text = "S/R";
            // 
            // dtpPrevisao
            // 
            dtpPrevisao.DataBindings.Add(new Binding("Tag", bsModificaMAPA, "Previsao", true));
            dtpPrevisao.DataBindings.Add(new Binding("Text", bsModificaMAPA, "Previsao", true));
            dtpPrevisao.Location = new Point(516, 283);
            dtpPrevisao.MinDate = new DateTime(2023, 8, 22, 0, 0, 0, 0);
            dtpPrevisao.Name = "dtpPrevisao";
            dtpPrevisao.Size = new Size(135, 23);
            dtpPrevisao.TabIndex = 24;
            dtpPrevisao.Value = new DateTime(2023, 8, 22, 0, 0, 0, 0);
            // 
            // dtpDatadeEntrada
            // 
            dtpDatadeEntrada.DataBindings.Add(new Binding("Tag", bsModificaMAPA, "DataDeEntrada", true));
            dtpDatadeEntrada.DataBindings.Add(new Binding("Text", bsModificaMAPA, "DataDeEntrada", true));
            dtpDatadeEntrada.Location = new Point(178, 283);
            dtpDatadeEntrada.MinDate = new DateTime(2023, 8, 22, 0, 0, 0, 0);
            dtpDatadeEntrada.Name = "dtpDatadeEntrada";
            dtpDatadeEntrada.Size = new Size(135, 23);
            dtpDatadeEntrada.TabIndex = 25;
            dtpDatadeEntrada.Value = new DateTime(2023, 8, 22, 0, 0, 0, 0);
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(452, 207);
            label12.Name = "label12";
            label12.Size = new Size(116, 21);
            label12.TabIndex = 26;
            label12.Text = "Parametrização";
            // 
            // dtpDatadeInspecao
            // 
            dtpDatadeInspecao.DataBindings.Add(new Binding("Text", bsModificaMAPA, "DataDeInspeção", true));
            dtpDatadeInspecao.DataBindings.Add(new Binding("Tag", bsModificaMAPA, "DataDeInspeção", true));
            dtpDatadeInspecao.Location = new Point(353, 283);
            dtpDatadeInspecao.MinDate = new DateTime(2023, 8, 22, 0, 0, 0, 0);
            dtpDatadeInspecao.Name = "dtpDatadeInspecao";
            dtpDatadeInspecao.Size = new Size(135, 23);
            dtpDatadeInspecao.TabIndex = 28;
            dtpDatadeInspecao.Value = new DateTime(2023, 8, 22, 0, 0, 0, 0);
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(360, 259);
            label13.Name = "label13";
            label13.Size = new Size(128, 21);
            label13.TabIndex = 27;
            label13.Text = "Data de Inspeção";
            // 
            // tErro
            // 
            tErro.Tick += tErro_Tick;
            // 
            // frmModificaMapa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(824, 470);
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
            Name = "frmModificaMapa";
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
    }
}