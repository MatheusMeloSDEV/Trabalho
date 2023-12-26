namespace Trabalho
{
    partial class frmMenu
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
            txtResultado = new TextBox();
            button1 = new Button();
            label2 = new Label();
            label1 = new Label();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            SuspendLayout();
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(340, 87);
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(196, 23);
            txtResultado.TabIndex = 15;
            // 
            // button1
            // 
            button1.Location = new Point(377, 341);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 14;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(264, 276);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 13;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(264, 224);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 12;
            label1.Text = "Username";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(340, 273);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(196, 23);
            txtPassword.TabIndex = 11;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(340, 221);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(196, 23);
            txtUsername.TabIndex = 10;
            // 
            // frmMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtResultado);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Name = "frmMenu";
            Text = "frmMenu";
            Load += frmMenu_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtResultado;
        private Button button1;
        private Label label2;
        private Label label1;
        private TextBox txtPassword;
        private TextBox txtUsername;
    }
}