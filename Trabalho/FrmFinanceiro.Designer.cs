namespace Trabalho
{
    partial class FrmFinanceiro
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel panelFaturamento;
        private System.Windows.Forms.Panel panelRecibo;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            panelFaturamento = new Panel();
            panelRecibo = new Panel();
            SuspendLayout();

            // 
            // panelFaturamento
            // 
            panelFaturamento.Dock = DockStyle.Left;
            panelFaturamento.Width = 380;
            panelFaturamento.AutoScroll = true;
            panelFaturamento.BorderStyle = BorderStyle.FixedSingle;
            panelFaturamento.Name = "panelFaturamento";
            panelFaturamento.TabIndex = 0;

            // 
            // panelRecibo
            // 
            panelRecibo.Dock = DockStyle.Fill;
            panelRecibo.AutoScroll = true;
            panelRecibo.BorderStyle = BorderStyle.FixedSingle;
            panelRecibo.Name = "panelRecibo";
            panelRecibo.TabIndex = 1;

            // 
            // FrmFinanceiro
            // 
            ClientSize = new Size(920, 780);
            ControlBox = false;
            Controls.Add(panelRecibo);
            Controls.Add(panelFaturamento);
            Name = "FrmFinanceiro";
            Text = "Financeiro";
            WindowState = FormWindowState.Maximized;

            ResumeLayout(false);

        }
    }
}
