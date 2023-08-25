namespace Trabalho
{
    partial class frmModifica
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
            txtImportador = new TextBox();
            bsModificaMAPA = new BindingSource(components);
            label1 = new Label();
            label2 = new Label();
            txtNavio = new TextBox();
            label3 = new Label();
            txtTerminal = new TextBox();
            label4 = new Label();
            label5 = new Label();
            textBox5 = new TextBox();
            label6 = new Label();
            txtAnuete = new TextBox();
            label7 = new Label();
            txtContainer = new TextBox();
            label8 = new Label();
            txtArmazem = new TextBox();
            label10 = new Label();
            textBox10 = new TextBox();
            btnOkMAPA = new Button();
            textBox4 = new TextBox();
            textBox9 = new TextBox();
            label9 = new Label();
            label11 = new Label();
            dateTimePicker1 = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)bsModificaMAPA).BeginInit();
            SuspendLayout();
            // 
            // txtImportador
            // 
            txtImportador.DataBindings.Add(new Binding("Text", bsModificaMAPA, "Importador", true));
            txtImportador.Location = new Point(130, 126);
            txtImportador.Name = "txtImportador";
            txtImportador.Size = new Size(137, 23);
            txtImportador.TabIndex = 0;
            // 
            // bsModificaMAPA
            // 
            bsModificaMAPA.DataSource = typeof(CLUSA.MAPA);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(35, 128);
            label1.Name = "label1";
            label1.Size = new Size(89, 21);
            label1.TabIndex = 1;
            label1.Text = "Importador";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(285, 128);
            label2.Name = "label2";
            label2.Size = new Size(51, 21);
            label2.TabIndex = 3;
            label2.Text = "Navio";
            // 
            // txtNavio
            // 
            txtNavio.DataBindings.Add(new Binding("Text", bsModificaMAPA, "Navio", true));
            txtNavio.Location = new Point(342, 126);
            txtNavio.Name = "txtNavio";
            txtNavio.Size = new Size(149, 23);
            txtNavio.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(511, 128);
            label3.Name = "label3";
            label3.Size = new Size(69, 21);
            label3.TabIndex = 7;
            label3.Text = "Terminal";
            // 
            // txtTerminal
            // 
            txtTerminal.DataBindings.Add(new Binding("Text", bsModificaMAPA, "Terminal", true));
            txtTerminal.Location = new Point(586, 126);
            txtTerminal.Name = "txtTerminal";
            txtTerminal.Size = new Size(126, 23);
            txtTerminal.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(583, 178);
            label4.Name = "label4";
            label4.Size = new Size(69, 21);
            label4.TabIndex = 5;
            label4.Text = "Previsão";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(285, 240);
            label5.Name = "label5";
            label5.Size = new Size(28, 21);
            label5.TabIndex = 15;
            label5.Text = "CE";
            // 
            // textBox5
            // 
            textBox5.DataBindings.Add(new Binding("Text", bsModificaMAPA, "CE", true));
            textBox5.Location = new Point(319, 240);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(172, 23);
            textBox5.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(35, 242);
            label6.Name = "label6";
            label6.Size = new Size(59, 21);
            label6.TabIndex = 13;
            label6.Text = "Anuete";
            // 
            // txtAnuete
            // 
            txtAnuete.DataBindings.Add(new Binding("Text", bsModificaMAPA, "Anuete", true));
            txtAnuete.Location = new Point(100, 240);
            txtAnuete.Name = "txtAnuete";
            txtAnuete.Size = new Size(167, 23);
            txtAnuete.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(285, 182);
            label7.Name = "label7";
            label7.Size = new Size(78, 21);
            label7.TabIndex = 11;
            label7.Text = "Container";
            // 
            // txtContainer
            // 
            txtContainer.DataBindings.Add(new Binding("Text", bsModificaMAPA, "Container", true));
            txtContainer.Location = new Point(369, 180);
            txtContainer.Name = "txtContainer";
            txtContainer.Size = new Size(122, 23);
            txtContainer.TabIndex = 10;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(35, 182);
            label8.Name = "label8";
            label8.Size = new Size(77, 21);
            label8.TabIndex = 9;
            label8.Text = "Armazém";
            // 
            // txtArmazem
            // 
            txtArmazem.DataBindings.Add(new Binding("Text", bsModificaMAPA, "Armazem", true));
            txtArmazem.Location = new Point(118, 180);
            txtArmazem.Name = "txtArmazem";
            txtArmazem.Size = new Size(149, 23);
            txtArmazem.TabIndex = 8;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(35, 308);
            label10.Name = "label10";
            label10.Size = new Size(77, 21);
            label10.TabIndex = 17;
            label10.Text = "Descrição";
            // 
            // textBox10
            // 
            textBox10.DataBindings.Add(new Binding("Text", bsModificaMAPA, "Descricao", true));
            textBox10.Location = new Point(118, 306);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(594, 23);
            textBox10.TabIndex = 16;
            // 
            // btnOkMAPA
            // 
            btnOkMAPA.Location = new Point(605, 367);
            btnOkMAPA.Name = "btnOkMAPA";
            btnOkMAPA.Size = new Size(107, 28);
            btnOkMAPA.TabIndex = 19;
            btnOkMAPA.Text = "Ok";
            btnOkMAPA.UseVisualStyleBackColor = true;
            btnOkMAPA.Click += button1_Click;
            btnOkMAPA.Enter += btnOkMAPA_Enter;
            // 
            // textBox4
            // 
            textBox4.DataBindings.Add(new Binding("Text", bsModificaMAPA, "NR", true));
            textBox4.Location = new Point(263, 75);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 20;
            // 
            // textBox9
            // 
            textBox9.DataBindings.Add(new Binding("Text", bsModificaMAPA, "SR", true));
            textBox9.Location = new Point(414, 75);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(100, 23);
            textBox9.TabIndex = 21;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(221, 77);
            label9.Name = "label9";
            label9.Size = new Size(38, 21);
            label9.TabIndex = 22;
            label9.Text = "N/R";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(373, 77);
            label11.Name = "label11";
            label11.Size = new Size(35, 21);
            label11.TabIndex = 23;
            label11.Text = "S/R";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.DataBindings.Add(new Binding("Tag", bsModificaMAPA, "Previsao", true));
            dateTimePicker1.Location = new Point(553, 213);
            dateTimePicker1.MinDate = new DateTime(2023, 8, 22, 0, 0, 0, 0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(135, 23);
            dateTimePicker1.TabIndex = 24;
            dateTimePicker1.Value = new DateTime(2023, 8, 22, 0, 0, 0, 0);
            // 
            // frmModifica
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(800, 450);
            Controls.Add(dateTimePicker1);
            Controls.Add(label11);
            Controls.Add(label9);
            Controls.Add(textBox9);
            Controls.Add(textBox4);
            Controls.Add(btnOkMAPA);
            Controls.Add(label10);
            Controls.Add(textBox10);
            Controls.Add(label5);
            Controls.Add(textBox5);
            Controls.Add(label6);
            Controls.Add(txtAnuete);
            Controls.Add(label7);
            Controls.Add(txtContainer);
            Controls.Add(label8);
            Controls.Add(txtArmazem);
            Controls.Add(label3);
            Controls.Add(txtTerminal);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(txtNavio);
            Controls.Add(label1);
            Controls.Add(txtImportador);
            Name = "frmModifica";
            Load += frmModifica_Load;
            ((System.ComponentModel.ISupportInitialize)bsModificaMAPA).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtImportador;
        private Label label1;
        private Label label2;
        private TextBox txtNavio;
        private Label label3;
        private TextBox txtTerminal;
        private Label label4;
        private Label label5;
        private TextBox textBox5;
        private Label label6;
        private TextBox txtAnuete;
        private Label label7;
        private TextBox txtContainer;
        private Label label8;
        private TextBox txtArmazem;
        private Label label10;
        private TextBox textBox10;
        private Button btnOkMAPA;
        private BindingSource bsModificaMAPA;
        private TextBox textBox4;
        private TextBox textBox9;
        private Label label9;
        private Label label11;
        private DateTimePicker dateTimePicker1;
    }
}