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
            this.lblDocumento = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.cboDocumento = new System.Windows.Forms.ComboBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDocumento
            // 
            this.lblDocumento.AutoSize = true;
            this.lblDocumento.Location = new System.Drawing.Point(20, 20);
            this.lblDocumento.Name = "lblDocumento";
            this.lblDocumento.Size = new System.Drawing.Size(110, 15);
            this.lblDocumento.TabIndex = 0;
            this.lblDocumento.Text = "Nome do Doc.:";
            // 
            // cboDocumento
            // 
            this.cboDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDocumento.FormattingEnabled = true;
            this.cboDocumento.Items.AddRange(new object[] {
            "DI",
            "B/L",
            "Fatura",
            "Pack List",
            "Cert. de Origem",
            "Cert. Sanitário"});
            this.cboDocumento.Location = new System.Drawing.Point(140, 17);
            this.cboDocumento.Name = "cboDocumento";
            this.cboDocumento.Size = new System.Drawing.Size(200, 23);
            this.cboDocumento.TabIndex = 1;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(20, 60);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(114, 15);
            this.lblNumero.TabIndex = 2;
            this.lblNumero.Text = "Número de Doc.:";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(140, 57);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(200, 23);
            this.txtNumero.TabIndex = 3;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(140, 100);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(90, 30);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "Salvar";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(250, 100);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(90, 30);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FrmDocumento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 150);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.cboDocumento);
            this.Controls.Add(this.lblDocumento);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDocumento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Novo Documento";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
