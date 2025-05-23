using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Reflection;

namespace Trabalho
{
    partial class FrmMapa
    {
        private System.ComponentModel.IContainer components = null;

        // BindingSource
        private BindingSource BSmapa;

        // ToolStrip e itens
        private ToolStrip toolStrip1;
        private ToolStripButton BtnEditar;
        private ToolStripButton BtnCancelar;
        private ToolStripButton BtnPesquisar;
        private ToolStripButton BtnReload;
        private ToolStripTextBox TxtPesquisar;
        private ToolStripComboBox CmbPesquisar;

        // DataGridView
        private DataGridView dataGridView1;

        /// <summary>
        /// Liberar recursos usados.
        /// </summary>
        /// <param name="disposing">true se gerenciado, senão false</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
                BSmapa.Dispose();
            }
            base.Dispose(disposing);
        }

        /// <summary>
        /// Método gerado pelo designer para inicializar componentes.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            BSmapa = new BindingSource(components);

            #region ToolStrip Config

            toolStrip1 = new ToolStrip
            {
                GripStyle = ToolStripGripStyle.Hidden,
                RenderMode = ToolStripRenderMode.Professional,
                BackColor = Color.WhiteSmoke,
                AutoSize = false,
                Height = 40,
                Padding = new Padding(5, 5, 5, 5)
            };

            // Definir uma fonte padrão
            Font defaultFont = new Font("Segoe UI", 10, FontStyle.Regular);

            BtnEditar = new ToolStripButton
            {
                Text = "Editar",
                Font = defaultFont,
                DisplayStyle = ToolStripItemDisplayStyle.ImageAndText,
                ImageScaling = ToolStripItemImageScaling.SizeToFit
            };
            BtnEditar.Click += BtnEditar_Click;

            new ToolStripSeparator();

            BtnCancelar = new ToolStripButton
            {
                Alignment = ToolStripItemAlignment.Right,
                Text = "Cancelar",
                Font = defaultFont,
                DisplayStyle = ToolStripItemDisplayStyle.ImageAndText,
                ImageScaling = ToolStripItemImageScaling.SizeToFit
            };
            BtnCancelar.Click += BtnCancelar_Click;

            BtnReload = new ToolStripButton
            {
                Alignment = ToolStripItemAlignment.Right,
                Text = "Recarregar",
                Font = defaultFont,
                DisplayStyle = ToolStripItemDisplayStyle.ImageAndText,
                ImageScaling = ToolStripItemImageScaling.SizeToFit
            };
            BtnReload.Click += BtnReload_Click;

            new ToolStripSeparator();

            BtnPesquisar = new ToolStripButton
            {
                Alignment = ToolStripItemAlignment.Right,
                Text = "Pesquisar",
                Font = defaultFont,
                DisplayStyle = ToolStripItemDisplayStyle.ImageAndText,
                ImageScaling = ToolStripItemImageScaling.SizeToFit
            };
            BtnPesquisar.Click += BtnPesquisar_Click;

            CmbPesquisar = new ToolStripComboBox
            {
                Alignment = ToolStripItemAlignment.Right,
                Font = defaultFont,
                Size = new Size(150, 25),
                DropDownStyle = ComboBoxStyle.DropDownList
            };
            CmbPesquisar.SelectedIndexChanged += CmbPesquisar_SelectedIndexChanged;

            TxtPesquisar = new ToolStripTextBox
            {
                Alignment = ToolStripItemAlignment.Right,
                Font = defaultFont,
                Size = new Size(200, 25),
                BorderStyle = BorderStyle.FixedSingle
            };

            // Agora adicione na ordem inversa desejada para itens à direita:
            ToolStripSeparator ToolStripRight = new ToolStripSeparator
            {
                Alignment = ToolStripItemAlignment.Right,
            };
            ToolStripSeparator ToolStripRight1 = new ToolStripSeparator
            {
                Alignment = ToolStripItemAlignment.Right,
            };

            toolStrip1.Items.Add(BtnEditar);
            toolStrip1.Items.Add(BtnCancelar);
            toolStrip1.Items.Add(ToolStripRight1);
            toolStrip1.Items.Add(BtnReload);
            toolStrip1.Items.Add(ToolStripRight);
            toolStrip1.Items.Add(BtnPesquisar);
            toolStrip1.Items.Add(CmbPesquisar);
            toolStrip1.Items.Add(TxtPesquisar);

            #endregion

            #region DataGridView Config

            dataGridView1 = new DataGridView
            {
                AllowUserToAddRows = false,
                AllowUserToDeleteRows = false,
                AllowUserToResizeRows = false,
                AutoGenerateColumns = false,
                Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right,
                EnableHeadersVisualStyles = false,
                Location = new Point(12, 50),
                Name = "dataGridView1",
                ReadOnly = true,
                RowHeadersVisible = false,
                RowTemplate = { Height = 25 },
                Size = new Size(776, 388),
                BorderStyle = BorderStyle.FixedSingle,
                BackgroundColor = Color.White,
            };

            // Estilo do cabeçalho
            dataGridView1.ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle
            {
                BackColor = Color.FromArgb(50, 50, 50),
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                Alignment = DataGridViewContentAlignment.MiddleLeft,
                WrapMode = DataGridViewTriState.True
            };

            // Estilo das células
            dataGridView1.DefaultCellStyle = new DataGridViewCellStyle
            {
                Font = new Font("Segoe UI", 10),
                BackColor = Color.White,
                ForeColor = Color.Black,
                SelectionBackColor = Color.LightBlue,
                SelectionForeColor = Color.Black,
                Alignment = DataGridViewContentAlignment.MiddleLeft
            };

            dataGridView1.CellDoubleClick += DataGridView1_CellDoubleClick;
            // Ajuste automático das colunas
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Estilo alternado nas linhas
            dataGridView1.AlternatingRowsDefaultCellStyle = new DataGridViewCellStyle
            {
                BackColor = Color.WhiteSmoke
            };

            #endregion

            #region Form Config

            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(dataGridView1);
            Controls.Add(toolStrip1);
            Text = "Gerenciamento de Mapa";
            WindowState = FormWindowState.Maximized;

            Load += FrmMapa_Load;

            #endregion

            ((System.ComponentModel.ISupportInitialize)BSmapa).EndInit();
            ResumeLayout(false);
        }
    }
}
