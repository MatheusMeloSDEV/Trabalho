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
            this.components = new System.ComponentModel.Container();
            this.panelFaturamento = new System.Windows.Forms.Panel();
            this.panelRecibo = new System.Windows.Forms.Panel();

            this.SuspendLayout();

            // Panel Faturamento
            this.panelFaturamento.AutoScroll = true;
            this.panelFaturamento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelFaturamento.Location = new System.Drawing.Point(10, 10);
            this.panelFaturamento.Size = new System.Drawing.Size(380, 760);
            this.panelFaturamento.Anchor = (System.Windows.Forms.AnchorStyles.Top |
                                            System.Windows.Forms.AnchorStyles.Bottom |
                                            System.Windows.Forms.AnchorStyles.Left);

            // Panel Recibo
            this.panelRecibo.AutoScroll = true;
            this.panelRecibo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelRecibo.Location = new System.Drawing.Point(10, 10);
            this.panelRecibo.Size = new System.Drawing.Size(380, 760);
            this.panelRecibo.Anchor = (System.Windows.Forms.AnchorStyles.Top |
                                        System.Windows.Forms.AnchorStyles.Bottom |
                                        System.Windows.Forms.AnchorStyles.Right);

            // Form Financeiro
            this.ClientSize = new System.Drawing.Size(920, 780);
            this.Controls.Add(this.panelFaturamento);
            this.Controls.Add(this.panelRecibo);
            this.Name = "FrmFinanceiro";
            this.Text = "Financeiro";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;

            this.ResumeLayout(false);
        }
    }
}
