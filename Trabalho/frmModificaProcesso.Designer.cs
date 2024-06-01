namespace Trabalho
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
            label11 = new Label();
            label9 = new Label();
            insSR = new TextBox();
            insNR = new TextBox();
            label1 = new Label();
            insImportador = new TextBox();
            label3 = new Label();
            insTerminal = new TextBox();
            label10 = new Label();
            insStatusdoProcesso = new TextBox();
            SuspendLayout();
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(161, 26);
            label11.Name = "label11";
            label11.Size = new Size(35, 21);
            label11.TabIndex = 27;
            label11.Text = "S/R";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(9, 26);
            label9.Name = "label9";
            label9.Size = new Size(38, 21);
            label9.TabIndex = 26;
            label9.Text = "N/R";
            // 
            // insSR
            // 
            insSR.Location = new Point(202, 24);
            insSR.Name = "insSR";
            insSR.Size = new Size(100, 23);
            insSR.TabIndex = 25;
            // 
            // insNR
            // 
            insNR.Location = new Point(51, 24);
            insNR.Name = "insNR";
            insNR.Size = new Size(100, 23);
            insNR.TabIndex = 24;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(10, 53);
            label1.Name = "label1";
            label1.Size = new Size(89, 21);
            label1.TabIndex = 29;
            label1.Text = "Importador";
            // 
            // insImportador
            // 
            insImportador.Location = new Point(105, 53);
            insImportador.Name = "insImportador";
            insImportador.Size = new Size(137, 23);
            insImportador.TabIndex = 28;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(10, 82);
            label3.Name = "label3";
            label3.Size = new Size(69, 21);
            label3.TabIndex = 31;
            label3.Text = "Terminal";
            // 
            // insTerminal
            // 
            insTerminal.Location = new Point(85, 82);
            insTerminal.Name = "insTerminal";
            insTerminal.Size = new Size(157, 23);
            insTerminal.TabIndex = 30;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(11, 108);
            label10.Name = "label10";
            label10.Size = new Size(140, 21);
            label10.TabIndex = 33;
            label10.Text = "Status do Processo";
            // 
            // insStatusdoProcesso
            // 
            insStatusdoProcesso.Location = new Point(157, 108);
            insStatusdoProcesso.Name = "insStatusdoProcesso";
            insStatusdoProcesso.Size = new Size(558, 23);
            insStatusdoProcesso.TabIndex = 32;
            // 
            // frmModificaProcesso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label10);
            Controls.Add(insStatusdoProcesso);
            Controls.Add(label3);
            Controls.Add(insTerminal);
            Controls.Add(label1);
            Controls.Add(insImportador);
            Controls.Add(label11);
            Controls.Add(label9);
            Controls.Add(insSR);
            Controls.Add(insNR);
            Name = "frmModificaProcesso";
            Text = "frmModificaProcesso";
            Load += frmModificaProcesso_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label11;
        private Label label9;
        private TextBox insSR;
        private TextBox insNR;
        private Label label1;
        private TextBox insImportador;
        private Label label3;
        private TextBox insTerminal;
        private Label label10;
        private TextBox insStatusdoProcesso;
    }
}