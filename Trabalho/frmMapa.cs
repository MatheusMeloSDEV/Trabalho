using CLUSA;
using iText.Commons.Datastructures;
using iText.Kernel.Exceptions;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Trabalho
{
    public partial class frmMapa : Form
    {
        private RepositorioMAPA repositorio;
        public frmMapa()
        {
            InitializeComponent();
        }

        private void frmMapa_Load(object sender, EventArgs e)
        {
            repositorio = new RepositorioMAPA();
            BSmapa.DataSource = repositorio;
            if (frmLogin.instance.escuro)
            {
                DarkMode();
            }
        }

        private void DarkMode()
        {
            toolStrip1.BackColor = SystemColors.ControlDark;
            this.BackColor = SystemColors.ControlDark;
            CmbPesquisar.BackColor = SystemColors.ControlDarkDark;
            txtPesquisar.BackColor = SystemColors.ControlDarkDark;
            dataGridView1.DefaultCellStyle.BackColor = SystemColors.ControlDark;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = SystemColors.ControlDarkDark;
            dataGridView1.BackgroundColor = SystemColors.ControlDark;
        }

        private async void btnAdicionar_click(object sender, EventArgs e)
        {

        }

        private void bsMAPA_CurrentChanged(object sender, EventArgs e)
        {

        }

        private async void btnExcluir_Click(object sender, EventArgs e)
        {
            await repositorio.Delete(BSmapa.Current as MAPA);
            BSmapa.Remove(BSmapa.Current as MAPA);
            BSmapa.ResetBindings(false);
            BSmapa.DataSource = repositorio.FindAll();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            repositorio = new RepositorioMAPA();
            BSmapa.DataSource = repositorio.FindAll();
            CmbPesquisar.Text = "";
        }

        private void txtPesquisar_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                repositorio = new RepositorioMAPA();
                BSmapa.DataSource = repositorio.Find(CmbPesquisar.Text, txtPesquisar.Text);
            }
        }

        private void frmMapa_FormClosed(object sender, FormClosedEventArgs e)
        {
            repositorio = null;
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            BSmapa.DataSource = repositorio.FindAll();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            repositorio = new RepositorioMAPA();
            BSmapa.DataSource = repositorio.Find(CmbPesquisar.Text, txtPesquisar.Text);
        }

        private void CmbPesquisar_Click(object sender, EventArgs e)
        {

        }
        public class PdfExporter
        {
            public void ExportDataGridViewToPdf(DataGridView dataGridView, string filePath)
            {
                try
                {
                    // Verifica se o DataGridView tem um DataSource
                    if (dataGridView.DataSource == null)
                    {
                        MessageBox.Show("O DataGridView não possui um DataSource válido.");
                        return;
                    }

                    // Verifica se o arquivo já existe
                    if (File.Exists(filePath))
                    {
                        // Pergunta ao usuário se deseja sobrescrever o arquivo
                        if (MessageBox.Show("O arquivo já existe. Deseja sobrescrevê-lo?", "Sobrescrever?", MessageBoxButtons.YesNo) == DialogResult.No)
                        {
                            return;
                        }
                    }

                    // Cria um objeto PDFWriter para salvar o PDF no local especificado
                    using (PdfWriter writer = new PdfWriter(filePath))
                    {
                        using (PdfDocument pdf = new PdfDocument(writer))
                        {
                            // Cria um documento PDF
                            Document document = new Document(pdf);

                            // Cria uma tabela com a mesma quantidade de colunas do DataGridView
                            Table table = new Table(dataGridView.ColumnCount);
                            table.SetWidth(UnitValue.CreatePercentValue(100)); // Definindo a largura da tabela

                            // Adiciona o cabeçalho das colunas
                            foreach (DataGridViewColumn column in dataGridView.Columns)
                            {
                                table.AddHeaderCell(new Cell().Add(new Paragraph(column.HeaderText)));
                            }

                            // Adiciona as linhas da tabela (valores das células)
                            foreach (DataGridViewRow row in dataGridView.Rows)
                            {
                                if (row.IsNewRow) continue; // Ignora a última linha vazia
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    string cellValue = cell.Value?.ToString() ?? "";
                                    table.AddCell(new Cell().Add(new Paragraph(cellValue)));
                                }
                            }

                            // Adiciona a tabela ao documento PDF
                            document.Add(table);

                            // Fecha o documento
                            document.Close();
                        }
                    }

                    MessageBox.Show("PDF gerado com sucesso em: " + filePath);
                }
                catch (PdfException ex)
                {
                    MessageBox.Show("Erro ao gerar o PDF: " + ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro geral: " + ex.Message);
                }
            }
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            PdfExporter exporter = new PdfExporter();
            exporter.ExportDataGridViewToPdf(dataGridView1, @"C:\FollowUp\teste.pdf");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void BTNeditar_Click_1(object sender, EventArgs e)
        {
            frmModificaMapa frm = new frmModificaMapa();
            frm.mapa = BSmapa.Current as MAPA;
            frm.ShowDialog();

            if (frm.DialogResult == DialogResult.OK)
            {
                await repositorio.Update(frm.mapa);
                BSmapa.ResetBindings(false);
            }
            BSmapa.DataSource = repositorio.FindAll();
        }
    }
}
