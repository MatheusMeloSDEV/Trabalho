using System;
using System.Drawing;
using System.Windows.Forms;

namespace Trabalho
{
    public partial class FrmFinanceiro : Form
    {
        private Label lblFaturamento;
        private Label lblRecibo;

        public FrmFinanceiro()
        {
            InitializeComponent();
            InicializarLabels();
            CriarBotoes(panelFaturamento);
            CriarBotoes(panelRecibo);
        }

        private void InicializarLabels()
        {
            lblFaturamento = new Label
            {
                Text = "Faturamento",
                Font = new Font("Arial", 12, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Top,
                Height = 30
            };
            panelFaturamento.Controls.Add(lblFaturamento);

            lblRecibo = new Label
            {
                Text = "Recibo",
                Font = new Font("Arial", 12, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Top,
                Height = 30
            };
            panelRecibo.Controls.Add(lblRecibo);
        }

        private void CriarBotoes(Panel panel)
        {
            string[] referencias = { "12345", "67890", "11111", "22222", "33333", "44444", "55555", "66666", "77777", "88888", "99999" };
            string[] importadores = { "Importador A", "Importador B", "Importador C", "Importador D", "Importador E", "Importador F", "Importador G", "Importador H", "Importador I", "Importador J", "Importador K" };

            int colunas = 3;
            int espacoX = 10, espacoY = 10;
            int btnWidth = 250, btnHeight = 40;
            int panelWidth = btnWidth + 40, panelHeight = btnHeight + 60;

            panel.Width = (panelWidth + espacoX) * colunas;

            for (int i = 0; i < referencias.Length; i++)
            {
                Label lblReferencia = new Label
                {
                    Text = referencias[i],
                    TextAlign = ContentAlignment.MiddleCenter,
                    Height = 20,
                    Dock = DockStyle.Top,
                    Margin = new Padding(0, 0, 0, 5)
                };

                Button btnImportador = new Button
                {
                    Text = importadores[i],
                    Tag = (referencias[i], importadores[i]),
                    Width = btnWidth - 5,
                    Height = btnHeight,
                    MaximumSize = new Size(btnWidth, btnHeight),
                    Margin = new Padding(0, 0, 0, 5),
                    Anchor = AnchorStyles.None
                };

                btnImportador.Click += (s, e) =>
                {
                    var (referencia, importador) = ((string, string))((Button)s).Tag;
                    MessageBox.Show($"Número de Referência: {referencia}\nNome do Importador: {importador}", "Detalhes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                };

                Panel itemPanel = new Panel
                {
                    Width = panelWidth - 15,
                    Height = panelHeight,
                    BorderStyle = BorderStyle.FixedSingle,
                    Margin = new Padding(2)
                };

                itemPanel.Controls.Add(lblReferencia);
                itemPanel.Controls.Add(btnImportador);
                btnImportador.Top = lblReferencia.Bottom + 5;
                btnImportador.Left = (itemPanel.Width - btnImportador.Width) / 2;

                int x = (i % colunas) * (panelWidth + espacoX);
                int y = (i / colunas) * (panelHeight + espacoY);

                itemPanel.Location = new Point(x+10, y + 35);
                panel.Controls.Add(itemPanel);
            }
        }
    }
}
