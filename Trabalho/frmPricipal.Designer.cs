namespace Trabalho
{
    partial class frmPricipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPricipal));
            lblError = new Label();
            check = new PictureBox();
            lblLogado = new Label();
            btnLogin = new Button();
            lblPassword = new Label();
            lblUsername = new Label();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)check).BeginInit();
            SuspendLayout();
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.BackColor = SystemColors.Control;
            lblError.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblError.ForeColor = Color.IndianRed;
            lblError.Location = new Point(263, 141);
            lblError.Name = "lblError";
            lblError.Size = new Size(274, 19);
            lblError.TabIndex = 25;
            lblError.Text = "Usuário ou Senha digitados incorretamente";
            lblError.Visible = false;
            // 
            // check
            // 
            check.Anchor = AnchorStyles.None;
            check.Image = (Image)resources.GetObject("check.Image");
            check.Location = new Point(334, 237);
            check.Name = "check";
            check.Size = new Size(23, 20);
            check.SizeMode = PictureBoxSizeMode.Zoom;
            check.TabIndex = 24;
            check.TabStop = false;
            check.Visible = false;
            // 
            // lblLogado
            // 
            lblLogado.Anchor = AnchorStyles.None;
            lblLogado.AutoSize = true;
            lblLogado.Location = new Point(363, 240);
            lblLogado.Name = "lblLogado";
            lblLogado.Size = new Size(104, 15);
            lblLogado.TabIndex = 23;
            lblLogado.Text = "Funções Liberadas";
            lblLogado.Visible = false;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(363, 286);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 23);
            btnLogin.TabIndex = 22;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(274, 241);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(57, 15);
            lblPassword.TabIndex = 21;
            lblPassword.Text = "Password";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(271, 189);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(60, 15);
            lblUsername.TabIndex = 20;
            lblUsername.Text = "Username";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(334, 237);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(196, 23);
            txtPassword.TabIndex = 19;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(334, 185);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(196, 23);
            txtUsername.TabIndex = 18;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // frmPricipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(lblError);
            Controls.Add(check);
            Controls.Add(lblLogado);
            Controls.Add(btnLogin);
            Controls.Add(lblPassword);
            Controls.Add(lblUsername);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "frmPricipal";
            Text = "      Login";
            Load += frmPricipal_Load;
            ((System.ComponentModel.ISupportInitialize)check).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblError;
        private PictureBox check;
        private Label lblLogado;
        private Button btnLogin;
        private Label lblPassword;
        private Label lblUsername;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private System.Windows.Forms.Timer timer1;
    }
}