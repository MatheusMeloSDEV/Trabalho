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
            menuStrip1 = new MenuStrip();
            menuToolStripMenuItem = new ToolStripMenuItem();
            maximizarToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            planilhasToolStripMenuItem = new ToolStripMenuItem();
            mAPAToolStripMenuItem = new ToolStripMenuItem();
            decexToolStripMenuItem = new ToolStripMenuItem();
            aDMINToolStripMenuItem = new ToolStripMenuItem();
            bindingSource1 = new BindingSource(components);
            bindingSource2 = new BindingSource(components);
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource2).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem, planilhasToolStripMenuItem, aDMINToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { maximizarToolStripMenuItem, sairToolStripMenuItem });
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(50, 20);
            menuToolStripMenuItem.Text = "Menu";
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
            planilhasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mAPAToolStripMenuItem, decexToolStripMenuItem });
            planilhasToolStripMenuItem.Name = "planilhasToolStripMenuItem";
            planilhasToolStripMenuItem.Size = new Size(66, 20);
            planilhasToolStripMenuItem.Text = "Planilhas";
            planilhasToolStripMenuItem.Click += planilhasToolStripMenuItem_Click;
            // 
            // mAPAToolStripMenuItem
            // 
            mAPAToolStripMenuItem.Name = "mAPAToolStripMenuItem";
            mAPAToolStripMenuItem.Size = new Size(107, 22);
            mAPAToolStripMenuItem.Text = "MAPA";
            mAPAToolStripMenuItem.Click += mAPAToolStripMenuItem_Click;
            // 
            // decexToolStripMenuItem
            // 
            decexToolStripMenuItem.Name = "decexToolStripMenuItem";
            decexToolStripMenuItem.Size = new Size(107, 22);
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
            // bindingSource1
            // 
            bindingSource1.CurrentChanged += bindingSource1_CurrentChanged;
            // 
            // frmPricipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "frmPricipal";
            Text = "   USA";
            Load += frmPricipal_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private ToolStripMenuItem planilhasToolStripMenuItem;
        private ToolStripMenuItem mAPAToolStripMenuItem;
        private ToolStripMenuItem maximizarToolStripMenuItem;
        private ToolStripMenuItem aDMINToolStripMenuItem;
        private ToolStripMenuItem decexToolStripMenuItem;
        private BindingSource bindingSource1;
        private BindingSource bindingSource2;
    }
}