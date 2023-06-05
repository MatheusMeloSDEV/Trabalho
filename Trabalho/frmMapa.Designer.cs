namespace Trabalho
{
    partial class frmMapa
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
            dataGridView1 = new DataGridView();
            btnMAPAEnviar = new Button();
            btnMAPAExcluir = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(776, 397);
            dataGridView1.TabIndex = 0;
            // 
            // btnMAPAEnviar
            // 
            btnMAPAEnviar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnMAPAEnviar.Cursor = Cursors.Hand;
            btnMAPAEnviar.Location = new Point(12, 415);
            btnMAPAEnviar.Name = "btnMAPAEnviar";
            btnMAPAEnviar.Size = new Size(75, 23);
            btnMAPAEnviar.TabIndex = 1;
            btnMAPAEnviar.Text = "Enviar";
            btnMAPAEnviar.UseVisualStyleBackColor = true;
            // 
            // btnMAPAExcluir
            // 
            btnMAPAExcluir.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnMAPAExcluir.Cursor = Cursors.Hand;
            btnMAPAExcluir.Location = new Point(139, 415);
            btnMAPAExcluir.Name = "btnMAPAExcluir";
            btnMAPAExcluir.Size = new Size(75, 23);
            btnMAPAExcluir.TabIndex = 2;
            btnMAPAExcluir.Text = "Excluir";
            btnMAPAExcluir.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button3.Cursor = Cursors.Hand;
            button3.Location = new Point(274, 415);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 3;
            button3.Text = "Editar";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button4.Cursor = Cursors.Hand;
            button4.Location = new Point(423, 415);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 4;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button5.Cursor = Cursors.Hand;
            button5.Location = new Point(571, 415);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 5;
            button5.Text = "button5";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button6.Cursor = Cursors.Hand;
            button6.Location = new Point(713, 415);
            button6.MaximumSize = new Size(75, 23);
            button6.MinimumSize = new Size(75, 23);
            button6.Name = "button6";
            button6.Size = new Size(75, 23);
            button6.TabIndex = 6;
            button6.Text = "button6";
            button6.UseVisualStyleBackColor = true;
            // 
            // frmMapa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(btnMAPAExcluir);
            Controls.Add(btnMAPAEnviar);
            Controls.Add(dataGridView1);
            Name = "frmMapa";
            Text = "frmMapa";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnMAPAEnviar;
        private Button btnMAPAExcluir;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
    }
}