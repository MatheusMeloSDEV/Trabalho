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
            menuStrip1 = new MenuStrip();
            menuToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            planilhasToolStripMenuItem = new ToolStripMenuItem();
            mAPAToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem, planilhasToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { sairToolStripMenuItem });
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(50, 20);
            menuToolStripMenuItem.Text = "Menu";
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(93, 22);
            sairToolStripMenuItem.Text = "Sair";
            // 
            // planilhasToolStripMenuItem
            // 
            planilhasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mAPAToolStripMenuItem });
            planilhasToolStripMenuItem.Name = "planilhasToolStripMenuItem";
            planilhasToolStripMenuItem.Size = new Size(66, 20);
            planilhasToolStripMenuItem.Text = "Planilhas";
            // 
            // mAPAToolStripMenuItem
            // 
            mAPAToolStripMenuItem.Name = "mAPAToolStripMenuItem";
            mAPAToolStripMenuItem.Size = new Size(107, 22);
            mAPAToolStripMenuItem.Text = "MAPA";
            mAPAToolStripMenuItem.Click += mAPAToolStripMenuItem_Click;
            // 
            // frmPricipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "frmPricipal";
            Text = "frmPricipal";
            Load += frmPricipal_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private ToolStripMenuItem planilhasToolStripMenuItem;
        private ToolStripMenuItem mAPAToolStripMenuItem;
    }
}