﻿namespace Trabalho
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
            btnCancel = new Button();
            dtpDatadeInspecao = new DateTimePicker();
            label13 = new Label();
            label12 = new Label();
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
            insParametrizacao = new TextBox();
            label7 = new Label();
            insCSIOriginal = new TextBox();
            label8 = new Label();
            insPendencia = new TextBox();
            label3 = new Label();
            insTerminal = new TextBox();
            label4 = new Label();
            label2 = new Label();
            insLPCO = new TextBox();
            label1 = new Label();
            insImportador = new TextBox();
            ((System.ComponentModel.ISupportInitialize)bsModificaProcesso).BeginInit();
            SuspendLayout();
            // 
            // bsModificaProcesso
            // 
            bsModificaProcesso.DataSource = typeof(CLUSA.Processo);
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCancel.Location = new Point(507, 372);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(107, 28);
            btnCancel.TabIndex = 57;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // dtpDatadeInspecao
            // 
            dtpDatadeInspecao.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dtpDatadeInspecao.Location = new Point(353, 272);
            dtpDatadeInspecao.MinDate = new DateTime(2023, 8, 22, 0, 0, 0, 0);
            dtpDatadeInspecao.Name = "dtpDatadeInspecao";
            dtpDatadeInspecao.Size = new Size(135, 23);
            dtpDatadeInspecao.TabIndex = 56;
            dtpDatadeInspecao.Value = new DateTime(2023, 8, 22, 0, 0, 0, 0);
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(360, 248);
            label13.Name = "label13";
            label13.Size = new Size(128, 21);
            label13.TabIndex = 55;
            label13.Text = "Data de Inspeção";
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(452, 196);
            label12.Name = "label12";
            label12.Size = new Size(116, 21);
            label12.TabIndex = 54;
            label12.Text = "Parametrização";
            // 
            // dtpDatadeEntrada
            // 
            dtpDatadeEntrada.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dtpDatadeEntrada.Location = new Point(178, 272);
            dtpDatadeEntrada.MinDate = new DateTime(2023, 8, 22, 0, 0, 0, 0);
            dtpDatadeEntrada.Name = "dtpDatadeEntrada";
            dtpDatadeEntrada.Size = new Size(135, 23);
            dtpDatadeEntrada.TabIndex = 53;
            dtpDatadeEntrada.Value = new DateTime(2023, 8, 22, 0, 0, 0, 0);
            // 
            // dtpPrevisao
            // 
            dtpPrevisao.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dtpPrevisao.Location = new Point(516, 272);
            dtpPrevisao.MinDate = new DateTime(2023, 8, 22, 0, 0, 0, 0);
            dtpPrevisao.Name = "dtpPrevisao";
            dtpPrevisao.Size = new Size(135, 23);
            dtpPrevisao.TabIndex = 52;
            dtpPrevisao.Value = new DateTime(2023, 8, 22, 0, 0, 0, 0);
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(416, 53);
            label11.Name = "label11";
            label11.Size = new Size(35, 21);
            label11.TabIndex = 51;
            label11.Text = "S/R";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(264, 53);
            label9.Name = "label9";
            label9.Size = new Size(38, 21);
            label9.TabIndex = 50;
            label9.Text = "N/R";
            // 
            // insSR
            // 
            insSR.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            insSR.Location = new Point(457, 51);
            insSR.Name = "insSR";
            insSR.Size = new Size(100, 23);
            insSR.TabIndex = 49;
            // 
            // insNR
            // 
            insNR.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            insNR.Location = new Point(306, 51);
            insNR.Name = "insNR";
            insNR.Size = new Size(100, 23);
            insNR.TabIndex = 48;
            // 
            // btnOkMAPA
            // 
            btnOkMAPA.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnOkMAPA.Location = new Point(632, 372);
            btnOkMAPA.Name = "btnOkMAPA";
            btnOkMAPA.Size = new Size(107, 28);
            btnOkMAPA.TabIndex = 47;
            btnOkMAPA.Text = "Editar";
            btnOkMAPA.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(48, 325);
            label10.Name = "label10";
            label10.Size = new Size(140, 21);
            label10.TabIndex = 46;
            label10.Text = "Status do Processo";
            // 
            // insStatusdoProcesso
            // 
            insStatusdoProcesso.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            insStatusdoProcesso.Location = new Point(194, 325);
            insStatusdoProcesso.Name = "insStatusdoProcesso";
            insStatusdoProcesso.Size = new Size(558, 23);
            insStatusdoProcesso.TabIndex = 45;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(118, 200);
            label5.Name = "label5";
            label5.Size = new Size(22, 21);
            label5.TabIndex = 44;
            label5.Text = "LI";
            // 
            // insLI
            // 
            insLI.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            insLI.Location = new Point(146, 198);
            insLI.Name = "insLI";
            insLI.Size = new Size(204, 23);
            insLI.TabIndex = 43;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(193, 248);
            label6.Name = "label6";
            label6.Size = new Size(120, 21);
            label6.TabIndex = 42;
            label6.Text = "Data de Entrada";
            // 
            // insParametrizacao
            // 
            insParametrizacao.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            insParametrizacao.Location = new Point(574, 194);
            insParametrizacao.Name = "insParametrizacao";
            insParametrizacao.Size = new Size(128, 23);
            insParametrizacao.TabIndex = 41;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(452, 121);
            label7.Name = "label7";
            label7.Size = new Size(93, 21);
            label7.TabIndex = 40;
            label7.Text = "CSI Original";
            // 
            // insCSIOriginal
            // 
            insCSIOriginal.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            insCSIOriginal.Location = new Point(551, 119);
            insCSIOriginal.Name = "insCSIOriginal";
            insCSIOriginal.Size = new Size(151, 23);
            insCSIOriginal.TabIndex = 39;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(93, 374);
            label8.Name = "label8";
            label8.Size = new Size(80, 21);
            label8.TabIndex = 38;
            label8.Text = "Pendência";
            // 
            // insPendencia
            // 
            insPendencia.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            insPendencia.Location = new Point(176, 372);
            insPendencia.Name = "insPendencia";
            insPendencia.Size = new Size(266, 23);
            insPendencia.TabIndex = 37;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(118, 159);
            label3.Name = "label3";
            label3.Size = new Size(69, 21);
            label3.TabIndex = 36;
            label3.Text = "Terminal";
            // 
            // insTerminal
            // 
            insTerminal.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            insTerminal.Location = new Point(193, 157);
            insTerminal.Name = "insTerminal";
            insTerminal.Size = new Size(157, 23);
            insTerminal.TabIndex = 35;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(546, 248);
            label4.Name = "label4";
            label4.Size = new Size(69, 21);
            label4.TabIndex = 34;
            label4.Text = "Previsão";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(452, 159);
            label2.Name = "label2";
            label2.Size = new Size(49, 21);
            label2.TabIndex = 33;
            label2.Text = "LPCO";
            // 
            // insLPCO
            // 
            insLPCO.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            insLPCO.Location = new Point(507, 157);
            insLPCO.Name = "insLPCO";
            insLPCO.Size = new Size(195, 23);
            insLPCO.TabIndex = 32;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(118, 121);
            label1.Name = "label1";
            label1.Size = new Size(89, 21);
            label1.TabIndex = 31;
            label1.Text = "Importador";
            // 
            // insImportador
            // 
            insImportador.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            insImportador.Location = new Point(213, 119);
            insImportador.Name = "insImportador";
            insImportador.Size = new Size(137, 23);
            insImportador.TabIndex = 30;
            // 
            // frmModificaProcesso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
            Name = "frmModificaProcesso";
            Text = "frmModificaProcesso";
            Load += frmModificaProcesso_Load;
            ((System.ComponentModel.ISupportInitialize)bsModificaProcesso).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private BindingSource bsModificaProcesso;
        private Button btnCancel;
        private DateTimePicker dtpDatadeInspecao;
        private Label label13;
        private Label label12;
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
        private TextBox insParametrizacao;
        private Label label7;
        private TextBox insCSIOriginal;
        private Label label8;
        private TextBox insPendencia;
        private Label label3;
        private TextBox insTerminal;
        private Label label4;
        private Label label2;
        private TextBox insLPCO;
        private Label label1;
        private TextBox insImportador;
    }
}