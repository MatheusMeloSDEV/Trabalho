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
            components = new System.ComponentModel.Container();
            TabPage tabPage1;
            menuStrip1 = new MenuStrip();
            menuToolStripMenuItem = new ToolStripMenuItem();
            inícioToolStripMenuItem = new ToolStripMenuItem();
            maximizarToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            planilhasToolStripMenuItem = new ToolStripMenuItem();
            processoToolStripMenuItem = new ToolStripMenuItem();
            mAPAToolStripMenuItem = new ToolStripMenuItem();
            anvisaToolStripMenuItem = new ToolStripMenuItem();
            decexToolStripMenuItem = new ToolStripMenuItem();
            aDMINToolStripMenuItem = new ToolStripMenuItem();
            tLiberaSaida = new System.Windows.Forms.Timer(components);
            tabControl1 = new TabControl();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            tabPage4 = new TabPage();
            tabPage5 = new TabPage();
            tabPage1 = new TabPage();
            menuStrip1.SuspendLayout();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(671, 280);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Data de Atracação";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.Control;
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem, planilhasToolStripMenuItem, aDMINToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(878, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { inícioToolStripMenuItem, maximizarToolStripMenuItem, sairToolStripMenuItem });
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(50, 20);
            menuToolStripMenuItem.Text = "Menu";
            // 
            // inícioToolStripMenuItem
            // 
            inícioToolStripMenuItem.Name = "inícioToolStripMenuItem";
            inícioToolStripMenuItem.Size = new Size(129, 22);
            inícioToolStripMenuItem.Text = "Início";
            inícioToolStripMenuItem.Click += inícioToolStripMenuItem_Click;
            // 
            // maximizarToolStripMenuItem
            // 
            maximizarToolStripMenuItem.Name = "maximizarToolStripMenuItem";
            maximizarToolStripMenuItem.Size = new Size(129, 22);
            maximizarToolStripMenuItem.Text = "Maximizar";
            maximizarToolStripMenuItem.Click += maximizarToolStripMenuItem_Click;
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(129, 22);
            sairToolStripMenuItem.Text = "Sair";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // planilhasToolStripMenuItem
            // 
            planilhasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { processoToolStripMenuItem, mAPAToolStripMenuItem, anvisaToolStripMenuItem, decexToolStripMenuItem });
            planilhasToolStripMenuItem.Name = "planilhasToolStripMenuItem";
            planilhasToolStripMenuItem.Size = new Size(66, 20);
            planilhasToolStripMenuItem.Text = "Planilhas";
            // 
            // processoToolStripMenuItem
            // 
            processoToolStripMenuItem.Name = "processoToolStripMenuItem";
            processoToolStripMenuItem.Size = new Size(121, 22);
            processoToolStripMenuItem.Text = "Processo";
            processoToolStripMenuItem.Click += processoToolStripMenuItem_Click;
            // 
            // mAPAToolStripMenuItem
            // 
            mAPAToolStripMenuItem.Name = "mAPAToolStripMenuItem";
            mAPAToolStripMenuItem.Size = new Size(121, 22);
            mAPAToolStripMenuItem.Text = "MAPA";
            mAPAToolStripMenuItem.Click += mAPAToolStripMenuItem_Click;
            // 
            // anvisaToolStripMenuItem
            // 
            anvisaToolStripMenuItem.Name = "anvisaToolStripMenuItem";
            anvisaToolStripMenuItem.Size = new Size(121, 22);
            anvisaToolStripMenuItem.Text = "Anvisa";
            anvisaToolStripMenuItem.Click += anvisaToolStripMenuItem_Click;
            // 
            // decexToolStripMenuItem
            // 
            decexToolStripMenuItem.Name = "decexToolStripMenuItem";
            decexToolStripMenuItem.Size = new Size(121, 22);
            decexToolStripMenuItem.Text = "Decex";
            decexToolStripMenuItem.Click += decexToolStripMenuItem_Click;
            // 
            // aDMINToolStripMenuItem
            // 
            aDMINToolStripMenuItem.Name = "aDMINToolStripMenuItem";
            aDMINToolStripMenuItem.Size = new Size(58, 20);
            aDMINToolStripMenuItem.Text = "ADMIN";
            aDMINToolStripMenuItem.Click += aDMINToolStripMenuItem_Click;
            // 
            // tLiberaSaida
            // 
            tLiberaSaida.Tick += tLiberaSaida_Tick;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPage5);
            tabControl1.Location = new Point(100, 90);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(679, 308);
            tabControl1.TabIndex = 3;
            tabControl1.Visible = false;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(671, 280);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Data de entrada (Mapa)";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(671, 280);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Data de Entrada (Anvisa)";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(671, 280);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Data de Redestinação";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            tabPage5.Location = new Point(4, 24);
            tabPage5.Name = "tabPage5";
            tabPage5.Size = new Size(671, 280);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "Data CE Mercante";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // frmMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(878, 448);
            ControlBox = false;
            Controls.Add(tabControl1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Área de trabalho";
            WindowState = FormWindowState.Maximized;
            Load += frmMenu_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem maximizarToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private ToolStripMenuItem planilhasToolStripMenuItem;
        private ToolStripMenuItem mAPAToolStripMenuItem;
        private ToolStripMenuItem decexToolStripMenuItem;
        private ToolStripMenuItem aDMINToolStripMenuItem;
        private System.Windows.Forms.Timer tLiberaSaida;
        private ToolStripMenuItem processoToolStripMenuItem;
        private ToolStripMenuItem anvisaToolStripMenuItem;
        private ToolStripMenuItem inícioToolStripMenuItem;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TabPage tabPage5;
    }
}