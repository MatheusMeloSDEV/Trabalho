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
            components = new System.ComponentModel.Container();
            bsModificaProcesso = new BindingSource(components);
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)bsModificaProcesso).BeginInit();
            SuspendLayout();
            // 
            // bsModificaProcesso
            // 
            bsModificaProcesso.DataSource = typeof(CLUSA.Processo);
            // 
            // button2
            // 
            button2.Location = new Point(713, 415);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 1;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // frmModificaProcesso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Name = "frmModificaProcesso";
            Text = "frmModificaProcesso";
            Load += frmModificaProcesso_Load;
            ((System.ComponentModel.ISupportInitialize)bsModificaProcesso).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private BindingSource bsModificaProcesso;
        private Button button2;
    }
}