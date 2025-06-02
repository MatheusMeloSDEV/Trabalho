namespace Trabalho
{
    partial class DetalhesAgencia
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private TextBox txtAgencia;
        private TextBox precoCusto;
        private Button btnOK;
        private Button btnCancelar;
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
            this.txtAgencia = new TextBox();
            this.btnOK = new Button();
            this.btnCancelar = new Button();
            this.SuspendLayout();

            // txtAgencia
            this.txtAgencia.Location = new System.Drawing.Point(20, 20);
            this.txtAgencia.Name = "txtAgencia";
            this.txtAgencia.Size = new System.Drawing.Size(200, 23);
            this.txtAgencia.TabIndex = 0;
            this.txtAgencia.PlaceholderText = "Número da Agência";

            this.precoCusto = new TextBox();
            this.precoCusto.Location = new System.Drawing.Point(20, 60);
            this.precoCusto.Name = "txtCusto";
            this.precoCusto.Size = new System.Drawing.Size(120, 23);
            this.precoCusto.TabIndex = 1;
            this.precoCusto.PlaceholderText = "Preço Agência";
            this.precoCusto.TextChanged += new System.EventHandler(this.AplicarMascaraMoeda);


            // btnOK
            this.btnOK.Location = new System.Drawing.Point(20, 100);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);

            // btnCancelar
            this.btnCancelar.Location = new System.Drawing.Point(110, 100);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);

            // FrmAgenciaCusto
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 150);
            this.Controls.Add(this.txtAgencia);
            this.Controls.Add(this.precoCusto);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancelar);
            this.Name = "FrmAgenciaCusto";
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Cadastro de Agência e Custo";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}