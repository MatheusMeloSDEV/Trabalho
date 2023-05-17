namespace Trabalho
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dgvNavios = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ageDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            mailDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cachorroDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            naviosBindingSource = new BindingSource(components);
            txtName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtAge = new TextBox();
            label3 = new Label();
            txtMail = new TextBox();
            label4 = new Label();
            txtDog = new TextBox();
            button1 = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvNavios).BeginInit();
            ((System.ComponentModel.ISupportInitialize)naviosBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dgvNavios
            // 
            dgvNavios.AllowUserToResizeColumns = false;
            dgvNavios.AllowUserToResizeRows = false;
            dgvNavios.AutoGenerateColumns = false;
            dgvNavios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNavios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNavios.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, ageDataGridViewTextBoxColumn, mailDataGridViewTextBoxColumn, cachorroDataGridViewTextBoxColumn });
            dgvNavios.DataSource = naviosBindingSource;
            dgvNavios.EditMode = DataGridViewEditMode.EditOnEnter;
            dgvNavios.Location = new Point(12, 130);
            dgvNavios.MultiSelect = false;
            dgvNavios.Name = "dgvNavios";
            dgvNavios.ReadOnly = true;
            dgvNavios.RowTemplate.Height = 25;
            dgvNavios.Size = new Size(964, 416);
            dgvNavios.TabIndex = 0;
            dgvNavios.TabStop = false;
            dgvNavios.VirtualMode = true;
            dgvNavios.CellClick += dgvNavios_CellClick;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            idDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ageDataGridViewTextBoxColumn
            // 
            ageDataGridViewTextBoxColumn.DataPropertyName = "Age";
            ageDataGridViewTextBoxColumn.HeaderText = "Age";
            ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            ageDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mailDataGridViewTextBoxColumn
            // 
            mailDataGridViewTextBoxColumn.DataPropertyName = "Mail";
            mailDataGridViewTextBoxColumn.HeaderText = "Mail";
            mailDataGridViewTextBoxColumn.Name = "mailDataGridViewTextBoxColumn";
            mailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cachorroDataGridViewTextBoxColumn
            // 
            cachorroDataGridViewTextBoxColumn.DataPropertyName = "Cachorro";
            cachorroDataGridViewTextBoxColumn.HeaderText = "Cachorro";
            cachorroDataGridViewTextBoxColumn.Name = "cachorroDataGridViewTextBoxColumn";
            cachorroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // naviosBindingSource
            // 
            naviosBindingSource.DataSource = typeof(Navios);
            // 
            // txtName
            // 
            txtName.DataBindings.Add(new Binding("Text", naviosBindingSource, "Name", true));
            txtName.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(372, 9);
            txtName.Name = "txtName";
            txtName.Size = new Size(232, 34);
            txtName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(302, 12);
            label1.Name = "label1";
            label1.Size = new Size(64, 28);
            label1.TabIndex = 2;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(319, 61);
            label2.Name = "label2";
            label2.Size = new Size(47, 28);
            label2.TabIndex = 4;
            label2.Text = "Age";
            // 
            // txtAge
            // 
            txtAge.DataBindings.Add(new Binding("Text", naviosBindingSource, "Age", true));
            txtAge.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtAge.Location = new Point(372, 61);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(232, 34);
            txtAge.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(656, 15);
            label3.Name = "label3";
            label3.Size = new Size(50, 28);
            label3.TabIndex = 6;
            label3.Text = "Mail";
            // 
            // txtMail
            // 
            txtMail.DataBindings.Add(new Binding("Text", naviosBindingSource, "Mail", true));
            txtMail.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtMail.Location = new Point(712, 12);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(232, 34);
            txtMail.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(656, 64);
            label4.Name = "label4";
            label4.Size = new Size(50, 28);
            label4.TabIndex = 8;
            label4.Text = "Dog";
            // 
            // txtDog
            // 
            txtDog.DataBindings.Add(new Binding("Text", naviosBindingSource, "Cachorro", true));
            txtDog.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtDog.Location = new Point(712, 64);
            txtDog.Name = "txtDog";
            txtDog.Size = new Size(232, 34);
            txtDog.TabIndex = 7;
            // 
            // button1
            // 
            button1.Location = new Point(28, 12);
            button1.Name = "button1";
            button1.Size = new Size(134, 87);
            button1.TabIndex = 12;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(193, 44);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 13;
            btnDelete.Text = "button2";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(988, 558);
            Controls.Add(btnDelete);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(txtDog);
            Controls.Add(label3);
            Controls.Add(txtMail);
            Controls.Add(label2);
            Controls.Add(txtAge);
            Controls.Add(label1);
            Controls.Add(txtName);
            Controls.Add(dgvNavios);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvNavios).EndInit();
            ((System.ComponentModel.ISupportInitialize)naviosBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvNavios;
        private TextBox txtName;
        private Label label1;
        private Label label2;
        private TextBox txtAge;
        private Label label3;
        private TextBox txtMail;
        private Label label4;
        private TextBox txtDog;
        private Button button1;
        private BindingSource naviosBindingSource;
        private Button btnDelete;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn mailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cachorroDataGridViewTextBoxColumn;
    }
}