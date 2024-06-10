namespace Trabalho
{
    partial class frmModificaDecex
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
            bsModificaDecex = new BindingSource(components);
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
            label1 = new Label();
            insImportador = new TextBox();
            ((System.ComponentModel.ISupportInitialize)bsModificaDecex).BeginInit();
            SuspendLayout();
            // 
            // bsModificaDecex
            // 
            bsModificaDecex.DataSource = typeof(CLUSA.Decex);
            // 
            // dtpDatadeEntrada
            // 
            dtpDatadeEntrada.DataBindings.Add(new Binding("Text", bsModificaDecex, "DataDeEntrada", true));
            dtpDatadeEntrada.DataBindings.Add(new Binding("Value", bsModificaDecex, "DataDeEntrada", true));
            dtpDatadeEntrada.DataBindings.Add(new Binding("Tag", bsModificaDecex, "DataDeEntrada", true));
            dtpDatadeEntrada.Location = new Point(92, 169);
            dtpDatadeEntrada.MinDate = new DateTime(2023, 8, 22, 0, 0, 0, 0);
            dtpDatadeEntrada.Name = "dtpDatadeEntrada";
            dtpDatadeEntrada.Size = new Size(135, 23);
            dtpDatadeEntrada.TabIndex = 44;
            dtpDatadeEntrada.Value = new DateTime(2023, 8, 22, 0, 0, 0, 0);
            // 
            // dtpPrevisao
            // 
            dtpPrevisao.DataBindings.Add(new Binding("Text", bsModificaDecex, "Previsao", true));
            dtpPrevisao.DataBindings.Add(new Binding("Value", bsModificaDecex, "Previsao", true));
            dtpPrevisao.DataBindings.Add(new Binding("Tag", bsModificaDecex, "Previsao", true));
            dtpPrevisao.Location = new Point(591, 169);
            dtpPrevisao.MinDate = new DateTime(2023, 8, 22, 0, 0, 0, 0);
            dtpPrevisao.Name = "dtpPrevisao";
            dtpPrevisao.Size = new Size(135, 23);
            dtpPrevisao.TabIndex = 43;
            dtpPrevisao.Value = new DateTime(2023, 8, 22, 0, 0, 0, 0);
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(401, 51);
            label11.Name = "label11";
            label11.Size = new Size(35, 21);
            label11.TabIndex = 42;
            label11.Text = "S/R";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(249, 51);
            label9.Name = "label9";
            label9.Size = new Size(38, 21);
            label9.TabIndex = 41;
            label9.Text = "N/R";
            // 
            // insSR
            // 
            insSR.DataBindings.Add(new Binding("Text", bsModificaDecex, "SR", true));
            insSR.DataBindings.Add(new Binding("Tag", bsModificaDecex, "SR", true));
            insSR.Location = new Point(442, 49);
            insSR.Name = "insSR";
            insSR.Size = new Size(100, 23);
            insSR.TabIndex = 40;
            // 
            // insNR
            // 
            insNR.DataBindings.Add(new Binding("Text", bsModificaDecex, "NR", true));
            insNR.DataBindings.Add(new Binding("Tag", bsModificaDecex, "NR", true));
            insNR.Location = new Point(291, 49);
            insNR.Name = "insNR";
            insNR.Size = new Size(100, 23);
            insNR.TabIndex = 39;
            // 
            // btnOkMAPA
            // 
            btnOkMAPA.Location = new Point(591, 370);
            btnOkMAPA.Name = "btnOkMAPA";
            btnOkMAPA.Size = new Size(107, 28);
            btnOkMAPA.TabIndex = 38;
            btnOkMAPA.Text = "Ok";
            btnOkMAPA.UseVisualStyleBackColor = true;
            btnOkMAPA.Click += btnOkMAPA_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(50, 287);
            label10.Name = "label10";
            label10.Size = new Size(140, 21);
            label10.TabIndex = 37;
            label10.Text = "Status do Processo";
            // 
            // insStatusdoProcesso
            // 
            insStatusdoProcesso.DataBindings.Add(new Binding("Text", bsModificaDecex, "StatusDoProcesso", true));
            insStatusdoProcesso.DataBindings.Add(new Binding("Tag", bsModificaDecex, "StatusDoProcesso", true));
            insStatusdoProcesso.Location = new Point(196, 287);
            insStatusdoProcesso.Name = "insStatusdoProcesso";
            insStatusdoProcesso.Size = new Size(558, 23);
            insStatusdoProcesso.TabIndex = 36;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(283, 187);
            label5.Name = "label5";
            label5.Size = new Size(22, 21);
            label5.TabIndex = 35;
            label5.Text = "LI";
            // 
            // insLI
            // 
            insLI.DataBindings.Add(new Binding("Text", bsModificaDecex, "LI", true));
            insLI.DataBindings.Add(new Binding("Tag", bsModificaDecex, "LI", true));
            insLI.Location = new Point(311, 185);
            insLI.Name = "insLI";
            insLI.Size = new Size(204, 23);
            insLI.TabIndex = 34;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(107, 145);
            label6.Name = "label6";
            label6.Size = new Size(120, 21);
            label6.TabIndex = 33;
            label6.Text = "Data de Entrada";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(95, 336);
            label8.Name = "label8";
            label8.Size = new Size(80, 21);
            label8.TabIndex = 32;
            label8.Text = "Pendência";
            // 
            // insPendencia
            // 
            insPendencia.DataBindings.Add(new Binding("Text", bsModificaDecex, "Pendencia", true));
            insPendencia.DataBindings.Add(new Binding("Tag", bsModificaDecex, "Pendencia", true));
            insPendencia.Location = new Point(178, 334);
            insPendencia.Name = "insPendencia";
            insPendencia.Size = new Size(337, 23);
            insPendencia.TabIndex = 31;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(283, 149);
            label3.Name = "label3";
            label3.Size = new Size(69, 21);
            label3.TabIndex = 30;
            label3.Text = "Terminal";
            // 
            // insTerminal
            // 
            insTerminal.DataBindings.Add(new Binding("Text", bsModificaDecex, "Terminal", true));
            insTerminal.DataBindings.Add(new Binding("Tag", bsModificaDecex, "Terminal", true));
            insTerminal.Location = new Point(358, 147);
            insTerminal.Name = "insTerminal";
            insTerminal.Size = new Size(157, 23);
            insTerminal.TabIndex = 29;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(621, 145);
            label4.Name = "label4";
            label4.Size = new Size(69, 21);
            label4.TabIndex = 28;
            label4.Text = "Previsão";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(283, 111);
            label1.Name = "label1";
            label1.Size = new Size(89, 21);
            label1.TabIndex = 27;
            label1.Text = "Importador";
            // 
            // insImportador
            // 
            insImportador.DataBindings.Add(new Binding("Text", bsModificaDecex, "Importador", true));
            insImportador.DataBindings.Add(new Binding("Tag", bsModificaDecex, "Importador", true));
            insImportador.Location = new Point(378, 109);
            insImportador.Name = "insImportador";
            insImportador.Size = new Size(137, 23);
            insImportador.TabIndex = 26;
            // 
            // frmModificaDecex
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
            Controls.Add(label1);
            Controls.Add(insImportador);
            Name = "frmModificaDecex";
            Text = "frmModificaDecex";
            Load += frmModificaDecex_Load;
            ((System.ComponentModel.ISupportInitialize)bsModificaDecex).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private BindingSource bsModificaDecex;
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
        private Label label1;
        private TextBox insImportador;
    }
}