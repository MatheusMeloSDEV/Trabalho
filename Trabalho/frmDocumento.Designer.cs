namespace Trabalho
{
    partial class frmDocumento
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblDocumento;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.ComboBox cboDocumento;
        private System.Windows.Forms.TextBox txtNumero;
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
            lblDocumento = new Label();
            lblNumero = new Label();
            cboDocumento = new ComboBox();
            txtNumero = new TextBox();
            btnOK = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // lblDocumento
            // 
            lblDocumento.AutoSize = true;
            lblDocumento.Location = new Point(20, 20);
            lblDocumento.Name = "lblDocumento";
            lblDocumento.Size = new Size(87, 15);
            lblDocumento.TabIndex = 0;
            lblDocumento.Text = "Nome do Doc.:";
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(20, 60);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(97, 15);
            lblNumero.TabIndex = 2;
            lblNumero.Text = "Número de Doc.:";
            // 
            // cboDocumento
            // 
            cboDocumento.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDocumento.FormattingEnabled = true;
            cboDocumento.Items.AddRange(new object[] { "DI", "B/L", "Fatura", "Pack List", "Cert. de Origem", "Cert. Sanitário", "Cert. Análise" });
            cboDocumento.Location = new Point(140, 17);
            cboDocumento.Name = "cboDocumento";
            cboDocumento.Size = new Size(200, 23);
            cboDocumento.TabIndex = 1;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(140, 57);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(200, 23);
            txtNumero.TabIndex = 3;
            // 
            // btnOK
            // 
            btnOK.Location = new Point(140, 100);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(90, 30);
            btnOK.TabIndex = 4;
            btnOK.Text = "Salvar";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(250, 100);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(90, 30);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // frmDocumento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(380, 150);
            Controls.Add(btnCancelar);
            Controls.Add(btnOK);
            Controls.Add(txtNumero);
            Controls.Add(lblNumero);
            Controls.Add(cboDocumento);
            Controls.Add(lblDocumento);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmDocumento";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Novo Documento";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}
