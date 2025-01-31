
namespace Trabalho
{
    partial class ImporterSelectionForm
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
            listBoxImportadores = new ListBox();
            btnConfirmar = new Button();
            SuspendLayout();
            // 
            // listBoxImportadores
            // 
            listBoxImportadores.FormattingEnabled = true;
            listBoxImportadores.ItemHeight = 15;
            listBoxImportadores.Location = new Point(14, 14);
            listBoxImportadores.Margin = new Padding(4, 3, 4, 3);
            listBoxImportadores.Name = "listBoxImportadores";
            listBoxImportadores.Size = new Size(303, 214);
            listBoxImportadores.TabIndex = 0;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(14, 235);
            btnConfirmar.Margin = new Padding(4, 3, 4, 3);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(303, 35);
            btnConfirmar.TabIndex = 1;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += BtnConfirmar_Click;
            // 
            // ImporterSelectionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(331, 284);
            Controls.Add(btnConfirmar);
            Controls.Add(listBoxImportadores);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ImporterSelectionForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Seleção de Importador";
            ResumeLayout(false);
        }

        Button btnConfirmar;
        ListBox listBoxImportadores;
        #endregion
    }
}