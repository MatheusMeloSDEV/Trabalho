﻿namespace Trabalho
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            lblError = new Label();
            check = new PictureBox();
            lblLogado = new Label();
            btnLogin = new Button();
            lblPassword = new Label();
            lblUsername = new Label();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            tLogado = new System.Windows.Forms.Timer(components);
            tErro = new System.Windows.Forms.Timer(components);
            btnFechar = new Button();
            ftLua = new PictureBox();
            ftSol = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)check).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ftLua).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ftSol).BeginInit();
            SuspendLayout();
            // 
            // lblError
            // 
            lblError.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblError.AutoSize = true;
            lblError.BackColor = Color.Transparent;
            lblError.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblError.ForeColor = Color.Red;
            lblError.Location = new Point(263, 141);
            lblError.Name = "lblError";
            lblError.Size = new Size(274, 19);
            lblError.TabIndex = 25;
            lblError.Text = "Usuário ou Senha digitados incorretamente";
            lblError.Visible = false;
            // 
            // check
            // 
            check.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
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
            lblLogado.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
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
            btnLogin.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLogin.BackColor = Color.Transparent;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Location = new Point(370, 292);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 23);
            btnLogin.TabIndex = 22;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblPassword
            // 
            lblPassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblPassword.AutoSize = true;
            lblPassword.BackColor = Color.Transparent;
            lblPassword.Location = new Point(274, 241);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(57, 15);
            lblPassword.TabIndex = 21;
            lblPassword.Text = "Password";
            // 
            // lblUsername
            // 
            lblUsername.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblUsername.AutoSize = true;
            lblUsername.BackColor = Color.Transparent;
            lblUsername.Location = new Point(271, 189);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(60, 15);
            lblUsername.TabIndex = 20;
            lblUsername.Text = "Username";
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtPassword.BackColor = SystemColors.Control;
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Location = new Point(334, 237);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(196, 23);
            txtPassword.TabIndex = 19;
            // 
            // txtUsername
            // 
            txtUsername.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtUsername.BackColor = SystemColors.Control;
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.Location = new Point(334, 185);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(196, 23);
            txtUsername.TabIndex = 18;
            // 
            // tLogado
            // 
            tLogado.Tick += timer1_Tick;
            // 
            // tErro
            // 
            tErro.Tick += tErro_Tick;
            // 
            // btnFechar
            // 
            btnFechar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnFechar.BackColor = Color.Transparent;
            btnFechar.FlatStyle = FlatStyle.Flat;
            btnFechar.ForeColor = Color.Black;
            btnFechar.Location = new Point(713, 12);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(75, 23);
            btnFechar.TabIndex = 26;
            btnFechar.Text = "Fechar";
            btnFechar.UseVisualStyleBackColor = false;
            btnFechar.Click += btnFechar_Click;
            // 
            // ftLua
            // 
            ftLua.Image = (Image)resources.GetObject("ftLua.Image");
            ftLua.Location = new Point(12, 12);
            ftLua.Name = "ftLua";
            ftLua.Size = new Size(43, 42);
            ftLua.SizeMode = PictureBoxSizeMode.StretchImage;
            ftLua.TabIndex = 27;
            ftLua.TabStop = false;
            ftLua.Click += ftLua_Click;
            // 
            // ftSol
            // 
            ftSol.BackColor = SystemColors.ControlDarkDark;
            ftSol.Image = (Image)resources.GetObject("ftSol.Image");
            ftSol.Location = new Point(12, 12);
            ftSol.Name = "ftSol";
            ftSol.Size = new Size(43, 42);
            ftSol.SizeMode = PictureBoxSizeMode.StretchImage;
            ftSol.TabIndex = 28;
            ftSol.TabStop = false;
            ftSol.Visible = false;
            ftSol.Click += ftSol_Click;
            // 
            // frmLogin
            // 
            AcceptButton = btnLogin;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(ftSol);
            Controls.Add(ftLua);
            Controls.Add(btnFechar);
            Controls.Add(lblError);
            Controls.Add(check);
            Controls.Add(lblLogado);
            Controls.Add(btnLogin);
            Controls.Add(lblPassword);
            Controls.Add(lblUsername);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "   Login";
            TransparencyKey = Color.Transparent;
            Load += frmPricipal_Load;
            ((System.ComponentModel.ISupportInitialize)check).EndInit();
            ((System.ComponentModel.ISupportInitialize)ftLua).EndInit();
            ((System.ComponentModel.ISupportInitialize)ftSol).EndInit();
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
        private System.Windows.Forms.Timer tLogado;
        private System.Windows.Forms.Timer tErro;
        private Button btnFechar;
        private PictureBox ftLua;
        private PictureBox ftSol;
    }
}