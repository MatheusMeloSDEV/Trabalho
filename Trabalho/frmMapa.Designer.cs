using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Trabalho
{
    partial class FrmMapa
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
        /// Required method for Designer support - do not modify the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            BSmapa = new BindingSource(components);
            toolStrip1 = new ToolStrip();
            BtnEditar = new ToolStripButton();
            BtnCancelar = new ToolStripButton();
            TxtPesquisar = new ToolStripTextBox();
            CmbPesquisar = new ToolStripComboBox();
            BtnPesquisar = new ToolStripButton();
            BtnReload = new ToolStripButton();
            dataGridView1 = new DataGridView();

            // Configuração do ToolStrip
            toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip1.RenderMode = ToolStripRenderMode.Professional;
            toolStrip1.BackColor = Color.LightGray;
            toolStrip1.AutoSize = false;
            toolStrip1.Height = 40;

            BtnEditar.Text = "Editar";
            BtnCancelar.Text = "Cancelar";
            TxtPesquisar.Size = new Size(250, 25);
            CmbPesquisar.Size = new Size(175, 25);
            BtnPesquisar.Text = "Pesquisar";
            BtnReload.Text = "Recarregar";

            toolStrip1.Items.AddRange(new ToolStripItem[]
            {
                BtnEditar,
                new ToolStripSeparator(),
                BtnCancelar,
                new ToolStripSeparator(),
                TxtPesquisar,
                CmbPesquisar,
                BtnPesquisar,
                BtnReload
            });

            // Configuração do DataGridView
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(12, 41);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(776, 397);

            // Configuração do Formulário
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(dataGridView1);
            Controls.Add(toolStrip1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmMapa";
            Text = "Planilha MAPA";
            WindowState = FormWindowState.Maximized;
            Load += FrmMapa_Load;

            ((System.ComponentModel.ISupportInitialize)BSmapa).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private BindingSource BSmapa;
        private ToolStrip toolStrip1;
        private ToolStripButton BtnEditar;
        private ToolStripButton BtnCancelar;
        private ToolStripButton BtnPesquisar;
        private ToolStripButton BtnReload;
        private ToolStripTextBox TxtPesquisar;
        private ToolStripComboBox CmbPesquisar;
        private DataGridView dataGridView1;
    }
}
