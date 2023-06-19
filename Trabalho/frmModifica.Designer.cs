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
            textBox1 = new TextBox();
            bsModificaMAPA = new BindingSource(components);
            label1 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            textBox5 = new TextBox();
            label6 = new Label();
            textBox6 = new TextBox();
            label7 = new Label();
            textBox7 = new TextBox();
            label8 = new Label();
            textBox8 = new TextBox();
            label10 = new Label();
            textBox10 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            btnOkMAPA = new Button();
            textBox4 = new TextBox();
            textBox9 = new TextBox();
            label9 = new Label();
            label11 = new Label();
            ((System.ComponentModel.ISupportInitialize)bsModificaMAPA).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.DataBindings.Add(new Binding("Text", bsModificaMAPA, "Importador", true));
            textBox1.Location = new Point(130, 126);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(137, 23);
            textBox1.TabIndex = 0;
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
            // textBox2
            // 
            textBox2.DataBindings.Add(new Binding("Text", bsModificaMAPA, "Navio", true));
            textBox2.Location = new Point(342, 126);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(149, 23);
            textBox2.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(529, 128);
            label3.Name = "label3";
            label3.Size = new Size(69, 21);
            label3.TabIndex = 7;
            label3.Text = "Terminal";
            // 
            // textBox3
            // 
            textBox3.DataBindings.Add(new Binding("Text", bsModificaMAPA, "Terminal", true));
            textBox3.Location = new Point(604, 126);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(124, 23);
            textBox3.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(546, 182);
            label4.Name = "label4";
            label4.Size = new Size(69, 21);
            label4.TabIndex = 5;
            label4.Text = "Previsão";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(424, 235);
            label5.Name = "label5";
            label5.Size = new Size(28, 21);
            label5.TabIndex = 15;
            label5.Text = "CE";
            // 
            // textBox5
            // 
            textBox5.DataBindings.Add(new Binding("Text", bsModificaMAPA, "CE", true));
            textBox5.Location = new Point(458, 233);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(141, 23);
            textBox5.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(130, 235);
            label6.Name = "label6";
            label6.Size = new Size(59, 21);
            label6.TabIndex = 13;
            label6.Text = "Anuete";
            // 
            // textBox6
            // 
            textBox6.DataBindings.Add(new Binding("Text", bsModificaMAPA, "Anuete", true));
            textBox6.Location = new Point(195, 233);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(137, 23);
            textBox6.TabIndex = 12;
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
            // textBox7
            // 
            textBox7.DataBindings.Add(new Binding("Text", bsModificaMAPA, "Container", true));
            textBox7.Location = new Point(369, 180);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(122, 23);
            textBox7.TabIndex = 10;
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
            // textBox8
            // 
            textBox8.DataBindings.Add(new Binding("Text", bsModificaMAPA, "Armazem", true));
            textBox8.Location = new Point(118, 180);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(149, 23);
            textBox8.TabIndex = 8;
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
            textBox10.Size = new Size(610, 23);
            textBox10.TabIndex = 16;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.DataBindings.Add(new Binding("Value", bsModificaMAPA, "Previsao", true));
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(621, 181);
            dateTimePicker1.MinDate = new DateTime(2023, 6, 19, 0, 0, 0, 0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(107, 23);
            dateTimePicker1.TabIndex = 18;
            // 
            // btnOkMAPA
            // 
            btnOkMAPA.Location = new Point(634, 370);
            btnOkMAPA.Name = "btnOkMAPA";
            btnOkMAPA.Size = new Size(75, 23);
            btnOkMAPA.TabIndex = 19;
            btnOkMAPA.Text = "Ok";
            btnOkMAPA.UseVisualStyleBackColor = true;
            btnOkMAPA.Click += button1_Click;
            // 
            // textBox4
            // 
            textBox4.DataBindings.Add(new Binding("Text", bsModificaMAPA, "NR", true));
            textBox4.Location = new Point(285, 67);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 20;
            // 
            // textBox9
            // 
            textBox9.DataBindings.Add(new Binding("Text", bsModificaMAPA, "SR", true));
            textBox9.Location = new Point(436, 67);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(100, 23);
            textBox9.TabIndex = 21;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(243, 69);
            label9.Name = "label9";
            label9.Size = new Size(38, 21);
            label9.TabIndex = 22;
            label9.Text = "N/R";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(395, 69);
            label11.Name = "label11";
            label11.Size = new Size(35, 21);
            label11.TabIndex = 23;
            label11.Text = "S/R";
            // 
            // frmModifica
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label11);
            Controls.Add(label9);
            Controls.Add(textBox9);
            Controls.Add(textBox4);
            Controls.Add(btnOkMAPA);
            Controls.Add(dateTimePicker1);
            Controls.Add(label10);
            Controls.Add(textBox10);
            Controls.Add(label5);
            Controls.Add(textBox5);
            Controls.Add(label6);
            Controls.Add(textBox6);
            Controls.Add(label7);
            Controls.Add(textBox7);
            Controls.Add(label8);
            Controls.Add(textBox8);
            Controls.Add(label3);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "frmModifica";
            Text = "frmModifica";
            Load += frmModifica_Load;
            ((System.ComponentModel.ISupportInitialize)bsModificaMAPA).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private Label label4;
        private Label label5;
        private TextBox textBox5;
        private Label label6;
        private TextBox textBox6;
        private Label label7;
        private TextBox textBox7;
        private Label label8;
        private TextBox textBox8;
        private Label label10;
        private TextBox textBox10;
        private DateTimePicker dateTimePicker1;
        private Button btnOkMAPA;
        private BindingSource bsModificaMAPA;
        private TextBox textBox4;
        private TextBox textBox9;
        private Label label9;
        private Label label11;
    }
}