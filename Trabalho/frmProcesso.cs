using CLUSA;
using System.Diagnostics;

namespace Trabalho
{
    public partial class frmProcesso : Form
    {
        private RepositorioProcesso repositorio;
        public frmProcesso()
        {
            InitializeComponent();
            repositorio = new();
            bsProcesso.DataSource = repositorio;
        }

        private async void btnAdicionar_Click(object sender, EventArgs e)
        {
            Processo processo = new();
            frmModificaProcesso frm = new();
            frm.processo = processo;
            frm.ShowDialog();

            if (frm.DialogResult == DialogResult.OK)
            {
                await repositorio.Create(processo);
                bsProcesso.Add(processo);
            }
        }

        private async void btnExcluir_Click(object sender, EventArgs e)
        {
            await repositorio.Delete(bsProcesso.Current as Processo);
            bsProcesso.Remove(bsProcesso.Current as Processo);
            bsProcesso.ResetBindings(false);
            bsProcesso.DataSource = repositorio.FindAll();
        }

        private async void btnEditar_Click(object sender, EventArgs e)
        {
            frmModificaProcesso frm = new()
            {
                processo = bsProcesso.Current as Processo
            };
            Processo pr = new()
            {
                TMapa = frm.processo.TMapa,
                TDecex = frm.processo.TDecex,
                TAnvisa = frm.processo.TAnvisa,
                TIbama = frm.processo.TIbama,
                TImetro = frm.processo.TImetro
            };
            frm.ShowDialog();

            if (frm.DialogResult == DialogResult.OK)
            {
                if(pr.TMapa != frm.processo.TMapa)
                {
                    if (frm.processo.TMapa)
                    {
                        await repositorio.Create(frm.processo);
                        bsProcesso.Add(frm.processo);
                    }
                }
                if (pr.TDecex != frm.processo.TDecex)
                {
                    if (frm.processo.TDecex)
                    {
                        await repositorio.Create(frm.processo);
                        bsProcesso.Add(frm.processo);
                    }
                }
                if (pr.TAnvisa != frm.processo.TAnvisa)
                {
                    if (frm.processo.TAnvisa)
                    {
                        await repositorio.Create(frm.processo);
                        bsProcesso.Add(frm.processo);
                    }
                }
                if (pr.TImetro != frm.processo.TImetro)
                {
                    if (frm.processo.TImetro)
                    {
                        await repositorio.Create(frm.processo);
                        bsProcesso.Add(frm.processo);
                    }
                }
                if (pr.TIbama != frm.processo.TIbama)
                {
                    if (frm.processo.TIbama)
                    {
                        await repositorio.Create(frm.processo);
                        bsProcesso.Add(frm.processo);
                    }
                }
                await repositorio.Update(frm.processo);
                bsProcesso.ResetBindings(false);
            }
            bsProcesso.DataSource = repositorio.FindAll();
        }

        private void CmbPesquisar_Click(object sender, EventArgs e)
        {

        }

        private void txtPesquisar_Click(object sender, EventArgs e)
        {

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            repositorio = new();
            bsProcesso.DataSource = repositorio.Find(CmbPesquisar.Text, txtPesquisar.Text);
        }

        private void frmProcesso_Load(object sender, EventArgs e)
        {
            if (frmLogin.instance.escuro)
            {
                DarkMode();
            }
        }

        private void DarkMode()
        {
            this.BackColor = SystemColors.ControlDark;
            toolStrip1.BackColor = SystemColors.ControlDark;
            dataGridView1.BackgroundColor = SystemColors.ControlDarkDark;
        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                string columnName = dataGridView1.Columns[e.ColumnIndex].Name;

                object cellValue = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;

                string cellText = cellValue != null ? cellValue.ToString() : "Célula vazia";

                bsProcesso.DataSource = repositorio.Find(CmbPesquisar.Text = columnName, txtPesquisar.Text = cellText);
            }
        }
    }
}
